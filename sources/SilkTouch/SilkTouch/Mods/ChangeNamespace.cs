using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using ClangSharp;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Logging;
using Silk.NET.SilkTouch.Utility;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// A mod that changes namespaces in response files. It is assumed that there will be no other sources of variance with
/// regards to namespaces.
/// </summary>
[ModConfiguration<Configuration>]
public class ChangeNamespace(IOptionsSnapshot<ChangeNamespace.Configuration> config, IProgressService progressService)
    : IMod,
        IResponseFileMod
{
    private readonly Dictionary<string, (HashSet<string>, IReadOnlyList<(Regex, string)>)> _jobs =
        new();

    /// <summary>
    /// The configuration for the change namespace mod.
    /// </summary>
    public record Configuration // DON'T USE CONSTRUCTOR-STYLE RECORDS! Needs a default ctor.
    {
        /// <summary>
        /// A mapping of namespace regexes to replacements.
        /// </summary>
        public required Dictionary<string, string>? Mappings { get; init; }
    }

    /// <inheritdoc />
    public Task<List<ResponseFile>> BeforeScrapeAsync(string key, List<ResponseFile> rsps)
    {
        var regexes =
            config.Get(key).Mappings?.Select(kvp => (new Regex(kvp.Key), kvp.Value)).ToArray()
            ?? Array.Empty<(Regex, string)>();
        var tmp = Path.GetTempFileName();
        progressService.SetTask("Change Namespace Init");
        for (var i = 0; i < rsps.Count; i++)
        {
            var rsp = rsps[i];
            var def = ModUtils.GroupedRegexReplace(
                regexes,
                rsp.GeneratorConfiguration.DefaultNamespace
            );
            var with = new Dictionary<string, string>();
            foreach (var (symbol, toNamespace) in rsp.GeneratorConfiguration.WithNamespaces)
            {
                with[symbol] = ModUtils.GroupedRegexReplace(regexes, toNamespace);
            }

            File.WriteAllText(tmp, rsp.GeneratorConfiguration.HeaderText);
            rsps[i] = rsp with
            {
                GeneratorConfiguration = new PInvokeGeneratorConfiguration(
                    rsp.GeneratorConfiguration.Language,
                    rsp.GeneratorConfiguration.LanguageStandard,
                    def,
                    rsp.GeneratorConfiguration.OutputLocation,
                    tmp,
                    rsp.GeneratorConfiguration.OutputMode,
                    rsp.GeneratorConfiguration.ReconstructOptions()
                )
                {
                    DefaultClass = rsp.GeneratorConfiguration.DefaultClass,
                    ExcludedNames = rsp.GeneratorConfiguration.ExcludedNames,
                    IncludedNames = rsp.GeneratorConfiguration.IncludedNames,
                    LibraryPath = rsp.GeneratorConfiguration.LibraryPath,
                    MethodPrefixToStrip = rsp.GeneratorConfiguration.MethodPrefixToStrip,
                    NativeTypeNamesToStrip = rsp.GeneratorConfiguration.NativeTypeNamesToStrip,
                    RemappedNames = rsp.GeneratorConfiguration.RemappedNames,
                    TraversalNames = rsp.GeneratorConfiguration.TraversalNames,
                    TestOutputLocation = rsp.GeneratorConfiguration.TestOutputLocation,
                    WithAccessSpecifiers = rsp.GeneratorConfiguration.WithAccessSpecifiers,
                    WithAttributes = rsp.GeneratorConfiguration.WithAttributes,
                    WithCallConvs = rsp.GeneratorConfiguration.WithCallConvs,
                    WithClasses = rsp.GeneratorConfiguration.WithClasses,
                    WithGuids = rsp.GeneratorConfiguration.WithGuids,
                    WithLibraryPaths = rsp.GeneratorConfiguration.WithLibraryPaths,
                    WithManualImports = rsp.GeneratorConfiguration.WithManualImports,
                    WithNamespaces = with,
                    WithSetLastErrors = rsp.GeneratorConfiguration.WithSetLastErrors,
                    WithSuppressGCTransitions =
                        rsp.GeneratorConfiguration.WithSuppressGCTransitions,
                    WithTransparentStructs = rsp.GeneratorConfiguration.WithTransparentStructs,
                    WithTypes = rsp.GeneratorConfiguration.WithTypes,
                    WithUsings = rsp.GeneratorConfiguration.WithUsings,
                    WithPackings = rsp.GeneratorConfiguration.WithPackings,
                },
            };

            progressService.SetProgress(i / (float)rsps.Count);
        }
        _jobs[key] = (
            rsps.Select(x => x.GeneratorConfiguration.DefaultNamespace)
                .Concat(
                    rsps.SelectMany(x =>
                        x.GeneratorConfiguration.WithNamespaces.Select(y => y.Value)
                    )
                )
                .Distinct()
                .ToHashSet(),
            regexes
        );
        File.Delete(tmp);
        return Task.FromResult(rsps);
    }

    /// <inheritdoc />
    public async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        var (ns, regexes) = _jobs[ctx.JobKey];
        var rewriter = new Rewriter(ns, regexes);
        var proj = ctx.SourceProject;
        foreach (var docId in proj?.DocumentIds ?? [])
        {
            var doc =
                proj!.GetDocument(docId) ?? throw new InvalidOperationException("Document missing");
            proj = doc.WithSyntaxRoot(
                rewriter.Visit(await doc.GetSyntaxRootAsync(ct))?.NormalizeWhitespace()
                    ?? throw new InvalidOperationException("Visit returned null.")
            ).Project;
        }

        ctx.SourceProject = proj;
        _jobs.Remove(ctx.JobKey);
    }

    private class Rewriter : CSharpSyntaxRewriter
    {
        private readonly HashSet<string> _allNamespaces;
        private readonly IReadOnlyList<(Regex Regex, string Replacement)> _regexes;
        private readonly List<string> _usingsToAdd = new();

        public Rewriter(
            HashSet<string> allNamespaces,
            IReadOnlyList<(Regex Regex, string Replacement)> regexes
        ) => (_allNamespaces, _regexes) = (allNamespaces, regexes);

        public override SyntaxNode? VisitCompilationUnit(CompilationUnitSyntax node)
        {
            _usingsToAdd.Clear();
            return base.VisitCompilationUnit(node) switch
            {
                CompilationUnitSyntax syntax => syntax.AddUsings(
                    _usingsToAdd
                        .Select(x => UsingDirective(ModUtils.NamespaceIntoIdentifierName(x)))
                        .Where(x =>
                            syntax.Usings.All(y => x.Name?.ToString() != y.Name?.ToString())
                        )
                        .ToArray()
                ),
                { } ret => ret,
                null => null,
            };
        }

        public override SyntaxNode? VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
        {
            var oldNs = node.Name.ToString();
            var newNs = ModUtils.GroupedRegexReplace(_regexes, oldNs);
            if (oldNs != newNs && _allNamespaces.Contains(oldNs))
            {
                _usingsToAdd.Add(oldNs);
            }
            return base.VisitNamespaceDeclaration(node) switch
            {
                NamespaceDeclarationSyntax syntax => syntax.WithName(
                    ModUtils.NamespaceIntoIdentifierName(newNs)
                ),
                { } ret => ret,
                null => null,
            };
        }

        public override SyntaxNode? VisitFileScopedNamespaceDeclaration(
            FileScopedNamespaceDeclarationSyntax node
        )
        {
            var oldNs = node.Name.ToString();
            var newNs = ModUtils.GroupedRegexReplace(_regexes, oldNs);
            if (oldNs != newNs && _allNamespaces.Contains(oldNs))
            {
                _usingsToAdd.Add(oldNs);
            }
            return base.VisitFileScopedNamespaceDeclaration(node) switch
            {
                FileScopedNamespaceDeclarationSyntax syntax => syntax.WithName(
                    ModUtils.NamespaceIntoIdentifierName(newNs)
                ),
                { } ret => ret,
                null => null,
            };
        }

        public override SyntaxNode? VisitUsingDirective(UsingDirectiveSyntax node)
        {
            var oldNs = node.Name?.ToString() ?? string.Empty;
            var newNs = ModUtils.GroupedRegexReplace(_regexes, oldNs);
            if (oldNs != newNs && _allNamespaces.Contains(oldNs))
            {
                _usingsToAdd.Add(oldNs);
            }
            return base.VisitUsingDirective(node) switch
            {
                UsingDirectiveSyntax syntax => syntax.WithName(
                    ModUtils.NamespaceIntoIdentifierName(newNs)
                ),
                { } ret => ret,
                null => null,
            };
        }
    }
}
