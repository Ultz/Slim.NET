using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Clang;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Adds opaque structs.
/// </summary>
[ModConfiguration<Configuration>]
public class AddOpaqueStructs(
    ILogger<AddOpaqueStructs> logger,
    IOptionsSnapshot<AddOpaqueStructs.Configuration> config
) : IMod, IResponseFileMod
{
    private readonly ConcurrentDictionary<string, string> _defaultNamespaces = new();

    /// <summary>
    /// The configuration for the opaque structs mod.
    /// </summary>
    public record Configuration // DON'T USE CONSTRUCTOR-STYLE RECORDS! Needs a default ctor.
    {
        /// <summary>
        /// Opaque struct names.
        /// </summary>
        public required string[]? Names { get; init; }
    }

    /// <inheritdoc />
    public Task<List<ResponseFile>> BeforeScrapeAsync(string key, List<ResponseFile> rsps)
    {
        if (rsps.Count <= 0)
        {
            return Task.FromResult(rsps);
        }

        var ns = rsps[0].GeneratorConfiguration.DefaultNamespace;
        if (rsps.All(responseFile => responseFile.GeneratorConfiguration.DefaultNamespace == ns))
        {
            _defaultNamespaces[key] = ns;
        }

        return Task.FromResult(rsps);
    }

    /// <inheritdoc />
    public Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        var cfg = config.Get(ctx.JobKey);
        var proj = ctx.SourceProject;
        if (
            proj?.FilePath is null
            || Path.GetDirectoryName(proj.FilePath) is not { Length: > 0 } dir
        )
        {
            logger.LogError("Couldn't determine source project file path.");
            return Task.CompletedTask;
        }

        foreach (var name in cfg.Names ?? Array.Empty<string>())
        {
            var qualified = name.LastIndexOf('.');
            var ns =
                qualified != -1 ? ModUtils.NamespaceIntoIdentifierName(name.AsSpan()[..qualified])
                : _defaultNamespaces.TryGetValue(ctx.JobKey, out var def)
                    ? ModUtils.NamespaceIntoIdentifierName(def)
                : null;
            if (ns is null)
            {
                logger.LogWarning(
                    "Couldn't resolve namespace for opaque struct \"{0}\" - consider fully qualifying the type in the "
                        + "config",
                    name
                );
                continue;
            }

            var fname = $"{name[(qualified + 1)..]}.gen.cs";
            proj = proj.AddDocument(
                fname,
                CompilationUnit()
                    .WithMembers(
                        SingletonList<MemberDeclarationSyntax>(
                            FileScopedNamespaceDeclaration(ns)
                                .WithMembers(
                                    SingletonList<MemberDeclarationSyntax>(
                                        StructDeclaration(name[(qualified + 1)..])
                                            .WithModifiers(
                                                TokenList(
                                                    Token(SyntaxKind.PublicKeyword),
                                                    Token(SyntaxKind.ReadOnlyKeyword),
                                                    Token(SyntaxKind.PartialKeyword)
                                                )
                                            )
                                    )
                                )
                        )
                    )
                    .NormalizeWhitespace(),
                filePath: proj.FullPath(fname)
            ).Project;
        }

        ctx.SourceProject = proj;
        return Task.CompletedTask;
    }
}
