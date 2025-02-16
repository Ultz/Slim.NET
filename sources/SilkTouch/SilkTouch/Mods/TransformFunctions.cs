using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Logging;
using Silk.NET.SilkTouch.Mods.Transformation;
using Silk.NET.SilkTouch.Naming;
using Silk.NET.SilkTouch.Utility;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Mods the bindings to use the Silk.NET.Core pointer types.
/// </summary>
[ModConfiguration<Configuration>]
public class TransformFunctions(FunctionTransformer ft, ILogger<TransformFunctions> logger, IProgressService progressService)
    : ModCSharpSyntaxRewriter,
        IMod
{
    private ThreadLocal<string> _jobKey = new();

    private SemanticModel? _semanticModel;
    private Dictionary<string, string> _toRename = [];
    private string _typeName = string.Empty;

    /// <summary>
    /// Configuration for the <see cref="TransformFunctions"/> and related code.
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// Whether all integer return types should be treated as potentially boolean.
        /// </summary>
        public required bool IntReturnsMaybeBool { get; init; }

        /// <summary>
        /// Types to treat as boolean and their boolean schemes if different to default.
        /// </summary>
        public Dictionary<string, string?>? BoolTypes { get; init; }

        /// <summary>
        /// Should the benefit of the doubt transformation be used for ArrayParameterTransformer
        /// </summary>
        public bool BenefitOfTheDoubtArrayTransformation { get; init; } = false;
    }

    /// <inheritdoc />
    public override string? JobKey
    {
        get => _jobKey.Value;
        set
        {
            if (value is null)
            {
                return;
            }
            _jobKey.Value = value;
        }
    }

    /// <inheritdoc />
    public async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        _jobKey.Value = ctx.JobKey;
        var proj = ctx.SourceProject;

        int count = proj?.DocumentIds.Count ?? 0;
        int index = 0;

        progressService.SetTask("Transforming Functions");
        foreach (var docId in ctx.SourceProject?.DocumentIds ?? [])
        {
            index++;
            UsingsToAdd.Clear();
            _typeName = string.Empty;
            var doc =
                proj!.GetDocument(docId) ?? throw new InvalidOperationException("Document missing");
            if (await doc.GetSyntaxRootAsync(ct) is { } root)
            {
                proj = doc.WithSyntaxRoot(Visit(root).NormalizeWhitespace()).Project;
            }

            progressService.SetProgress((float)index / count);
        }

        logger.LogInformation("Getting Project Compilation");
        var compilation = await proj!.GetCompilationAsync();
        if (compilation is null)
        {
            logger.LogWarning(
                "project was unable to compile, some usages may not be properly updated"
            );
        }

        List<(ISymbol, string)> toRenameSymbols = [];
        Visitor visitor = new(_toRename, toRenameSymbols, logger);

        index = 0;

        progressService.SetTask("Gathering Symbols");
        foreach (var docId in proj.DocumentIds ?? [])
        {
            index++;
            var doc =
                proj!.GetDocument(docId) ?? throw new InvalidOperationException("Document missing");
            if (await doc.GetSyntaxRootAsync(ct) is { } root)
            {
                var syntaxTree = await doc.GetSyntaxTreeAsync();
                _semanticModel =
                    compilation is not null && syntaxTree is not null
                        ? compilation.GetSemanticModel(syntaxTree!)
                        : await doc.GetSemanticModelAsync();

                visitor.SemanticModel = _semanticModel;
                visitor.Visit(root);
            }
            progressService.SetProgress((float)index / count);
        }

        ctx.SourceProject = proj;

        await NameUtils.RenameAllAsync(ctx, logger, toRenameSymbols, ct, false, true);
    }

    /// <inheritdoc />
    public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node)
    {
        string parentName = _typeName;
        _typeName += $".{node.Identifier}";
        var ret = base.VisitClassDeclaration(node) is ClassDeclarationSyntax cd
            ? cd.WithMembers(
                List(
                    cd.Members.Where(x => x is not MethodDeclarationSyntax)
                        .Concat(
                            ft.GetTransformedFunctions(
                                    _jobKey.Value,
                                    _typeName,
                                    _toRename,
                                    cd.Members.OfType<MethodDeclarationSyntax>(),
                                    this
                                )
                                .OrderBy(x => x.Identifier.ToString())
                        )
                )
            )
            : node;
        _typeName = parentName;
        return ret;
    }

    /// <inheritdoc />
    public override SyntaxNode? VisitStructDeclaration(StructDeclarationSyntax node)
    {
        string parentName = _typeName;
        _typeName += $".{node.Identifier}";
        var ret = base.VisitStructDeclaration(node) is StructDeclarationSyntax cd
            ? cd.WithMembers(
                List(
                    cd.Members.Where(x => x is not MethodDeclarationSyntax)
                        .Concat(
                            ft.GetTransformedFunctions(
                                    _jobKey.Value,
                                    _typeName,
                                    _toRename,
                                    cd.Members.OfType<MethodDeclarationSyntax>(),
                                    this
                                )
                                .OrderBy(x => x.Identifier.ToString())
                        )
                )
            )
            : node;
        _typeName = parentName;
        return ret;
    }

    /// <inheritdoc />
    public override SyntaxNode? VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
    {
        string parentName = _typeName;
        _typeName += $".{node.Identifier}";
        var ret = base.VisitInterfaceDeclaration(node) is InterfaceDeclarationSyntax id
            ? id.WithMembers(
                List(
                    id.Members.Where(x => x is not MethodDeclarationSyntax)
                        .Concat(
                            ft.GetTransformedFunctions(
                                    _jobKey.Value,
                                    _typeName,
                                    _toRename,
                                    id.Members.OfType<MethodDeclarationSyntax>(),
                                    this
                                )
                                .OrderBy(x => x.Identifier.ToString())
                        )
                )
            )
            : node;
        _typeName = parentName;
        return ret;
    }

    private class Visitor(
        Dictionary<string, string> toRename,
        List<(ISymbol, string)> toRenameSymbols,
        ILogger logger
    ) : CSharpSyntaxWalker
    {
        public SemanticModel? SemanticModel;

        private string _typeName = string.Empty;

        public override void VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            string parentName = _typeName;
            _typeName += $".{node.Identifier}";
            base.VisitClassDeclaration(node);
            _typeName = parentName;
        }

        public override void VisitStructDeclaration(StructDeclarationSyntax node)
        {
            string parentName = _typeName;
            _typeName += $".{node.Identifier}";
            base.VisitStructDeclaration(node);
            _typeName = parentName;
        }

        public override void VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
        {
            string parentName = _typeName;
            _typeName += $".{node.Identifier}";
            base.VisitInterfaceDeclaration(node);
            _typeName = parentName;
        }

        public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            base.VisitMethodDeclaration(node);

            var discrimWithRet =
                _typeName
                + ":"
                + ModUtils.DiscrimStr(
                    node.Modifiers,
                    node.TypeParameterList,
                    node.Identifier.ToString(),
                    node.ParameterList,
                    node.ReturnType
                );

            if (!toRename.TryGetValue(discrimWithRet, out string? newName))
            {
                return;
            }

            var symbol = SemanticModel.GetDeclaredSymbol(node);

            if (symbol is not null)
            {
                toRenameSymbols.Add((symbol, newName));
            }
            else
            {
                logger.LogError("Unable to retrieve symbol for {}", discrimWithRet);
            }
        }
    }
}
