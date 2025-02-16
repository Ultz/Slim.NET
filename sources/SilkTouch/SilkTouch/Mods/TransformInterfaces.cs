// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ClangSharp;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileSystemGlobbing;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Logging;
using Silk.NET.SilkTouch.Utility;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using static Silk.NET.SilkTouch.Utility.KeyedStringTree;

namespace Silk.NET.SilkTouch.Mods
{
    /// <summary>
    /// A mod to modify interface structs into opaque structs to hide pointers
    /// </summary>
    /// <param name="logger">The logger to use.</param>
    /// <param name="config">The configuration to use.</param>
    /// <param name="progressService">The progress service to use</param>
    [ModConfiguration<Configuration>]
    public class TransformInterfaces(
        ILogger<TransformInterfaces> logger,
        IOptionsSnapshot<TransformInterfaces.Configuration> config,
        IProgressService progressService
    ) : Mod
    {
        /// <summary>
        /// The configuration for the <see cref="TransformInterfaces"/> mod.
        /// </summary>
        public class Configuration
        {
            /// <summary>
            /// List of namespaces to include
            /// </summary>
            public string[]? IncludeList { get; init; }

            /// <summary>
            /// List of additional interface names to consider
            /// </summary>
            public string[]? AdditionalInterfaces { get; set; }
        }

        /// <inheritdoc/>
        public override async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
        {
            await base.ExecuteAsync(ctx, ct);

            // Read the configuration.
            var cfg = config.Get(ctx.JobKey);
            var proj = ctx.SourceProject;

            if (proj is null)
            {
                return;
            }

            //setup matcher
            var includes = (cfg.IncludeList ?? ["**"]).Select(type => type.Replace(".", "/"));
            Matcher matcher = new Matcher();
            matcher.AddIncludePatterns(
                includes.Where(x => !x.StartsWith("!")).Select(ResponseFileHandler.PathFixup)
            );
            matcher.AddExcludePatterns(
                includes
                    .Where(x => x.StartsWith("!"))
                    .Select(x => x[1..])
                    .Select(ResponseFileHandler.PathFixup)
            );

            int count = proj?.DocumentIds.Count ?? 0;
            int index = 0;

            progressService.SetTask("Interface Discovery");
            var firstPass = new TypeDiscoverer(matcher);
            foreach (var docId in proj?.DocumentIds ?? [])
            {
                index++;

                var doc =
                    proj?.GetDocument(docId)
                    ?? throw new InvalidOperationException("Document missing");
                if (await doc.GetSyntaxRootAsync(ct) is not { } root)
                {
                    continue;
                }

                firstPass.Visit(root);

                progressService.SetProgress((float)index / count);
            }

            if (cfg.AdditionalInterfaces is not null)
            {
                foreach (var inter in cfg.AdditionalInterfaces)
                {
                    if (!firstPass.FoundTypes.ContainsKey(inter))
                        firstPass.FoundTypes.Add(inter, inter);
                }
            }

            var compilation = await proj!.GetCompilationAsync();
            if (compilation is null)
            {
                logger.LogWarning(
                    "project was unable to compile, some usages may not be properly updated"
                );
            }

            index = 0;
            progressService.SetTask("Interface Object Usage Update");

            UsageUpdater updater = new(firstPass.FoundTypes);
            foreach (var docId in proj?.DocumentIds ?? [])
            {
                index++;
                var doc =
                    proj?.GetDocument(docId)
                    ?? throw new InvalidOperationException("Document missing");
                if (await doc.GetSyntaxRootAsync(ct) is not { } root)
                {
                    continue;
                }

                var syntaxTree = await doc.GetSyntaxTreeAsync();
                if (syntaxTree is null)
                {
                    logger.LogWarning("unable to retrieve Semantic Model for {}", doc.Name);
                    continue;
                }
                updater.SemanticModel = compilation is not null
                    ? compilation.GetSemanticModel(syntaxTree!)
                    : await doc.GetSemanticModelAsync();

                doc = doc.WithSyntaxRoot(updater.Visit(root).NormalizeWhitespace());

                proj = doc.Project;

                logger.LogDebug(
                    "Interface Object Usage Update for {0} Complete ({1}/{2})",
                    doc.Name,
                    index,
                    count
                );
                progressService.SetProgress((float)index / count);
            }

            index = 0;
            var rewriter = new Rewriter(firstPass.FoundTypes);
            progressService.SetTask("Interface Object Usage Rewrite");
            foreach (var docId in proj?.DocumentIds ?? [])
            {
                index++;
                var doc =
                    proj?.GetDocument(docId)
                    ?? throw new InvalidOperationException("Document missing");
                if (await doc.GetSyntaxRootAsync(ct) is not { } root)
                {
                    continue;
                }

                doc = doc.WithSyntaxRoot(rewriter.Visit(root).NormalizeWhitespace());

                proj = doc.Project;

                logger.LogDebug(
                    "Interface Object Rewrite for {0} Complete ({1}/{2})",
                    doc.Name,
                    index,
                    count
                );
                progressService.SetProgress((float)index / count);
            }
            ctx.SourceProject = proj;
        }

        class TypeDiscoverer : CSharpSyntaxWalker
        {
            /// <summary>
            /// The list of known interface types
            /// </summary>
            public Dictionary<string, string> FoundTypes = [];

            private List<string> _namespace = [];

            private Matcher _matcher;

            public TypeDiscoverer(Matcher matcher)
            {
                _matcher = matcher;
            }

            public override void VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
            {
                _namespace.Add(node.Name.ToString());
                base.VisitNamespaceDeclaration(node);
                _namespace.RemoveAt(_namespace.Count - 1);
            }

            public override void VisitFileScopedNamespaceDeclaration(
                FileScopedNamespaceDeclarationSyntax node
            )
            {
                _namespace.Add(node.Name.ToString());
                base.VisitFileScopedNamespaceDeclaration(node);
                _namespace.RemoveAt(_namespace.Count - 1);
            }

            public override void VisitStructDeclaration(StructDeclarationSyntax node)
            {
                base.VisitStructDeclaration(node);

                var fields = node.DescendantNodes().OfType<FieldDeclarationSyntax>();

                string matchString =
                    $"{string.Join('/', _namespace.Select(ns => ns.Replace('.', '/')))}/{node.Identifier.Text}";

                if (
                    node.Identifier.Text == "Vtbl"
                    || !_matcher.Match(matchString).HasMatches
                    || fields.Any(fds =>
                        !fds.Modifiers.Contains(Token(SyntaxKind.StaticKeyword))
                        && fds.Declaration.Type.ToString() != "void**"
                        && !fds.Declaration.Type.ToString().StartsWith("delegate")
                        && fds.Declaration.Variables[0].Identifier.Text != "lpVtbl"
                    )
                    || !fields.Any(fds =>
                        fds.Declaration.Type is FunctionPointerTypeSyntax fpts
                        && fpts.ParameterList is not null
                        && fpts.ParameterList.Parameters[0].Type.ToString() == "TSelf*"
                    )
                    || !fields.Any(fds =>
                        fds.Declaration.Type.ToString() == "void**"
                        && fds.Declaration.Variables[0].Identifier.Text == "lpVtbl"
                    )
                    || FoundTypes.ContainsKey(node.Identifier.Text)
                )
                {
                    return;
                }

                FoundTypes.Add(node.Identifier.Text, node.Identifier.Text);
            }
        }

        class UsageUpdater(Dictionary<string, string> InterfaceTypes) : CSharpSyntaxRewriter
        {
            public SemanticModel? SemanticModel;
            List<MemberDeclarationSyntax> _newMethods = [];

            public override SyntaxNode? VisitMemberAccessExpression(
                MemberAccessExpressionSyntax node
            )
            {
                if (!node.IsKind(SyntaxKind.PointerMemberAccessExpression))
                    return base.VisitMemberAccessExpression(node);

                var typeInfo = SemanticModel.GetTypeInfo(node.Expression);
                if (
                    typeInfo.Type is null
                    || GetPointerDepth(typeInfo.Type, out ITypeSymbol innerType) > 1
                )
                    return base.VisitMemberAccessExpression(node);
                var name = GetTypeName(innerType.ToString() ?? string.Empty);

                // Check if the type is a ComType
                if (typeInfo.Type != null && InterfaceTypes.ContainsKey(name))
                {
                    return MemberAccessExpression(
                        SyntaxKind.SimpleMemberAccessExpression,
                        node.Expression,
                        node.Name
                    );
                }
                return base.VisitMemberAccessExpression(node);
            }

            public override SyntaxNode? VisitAssignmentExpression(AssignmentExpressionSyntax node)
            {
                if (!node.Right.IsKind(SyntaxKind.NullLiteralExpression))
                    return base.VisitAssignmentExpression(node);

                var typeInfo = SemanticModel.GetTypeInfo(node);
                if (
                    typeInfo.Type is null
                    || GetPointerDepth(typeInfo.Type, out ITypeSymbol innerType) > 1
                )
                    return base.VisitAssignmentExpression(node);

                var name = GetTypeName(innerType.ToString() ?? string.Empty);
                // Check if the type is a ComType
                if (typeInfo.Type is not null && InterfaceTypes.ContainsKey(name))
                {
                    return AssignmentExpression(
                        node.Kind(),
                        node.Left,
                        LiteralExpression(SyntaxKind.DefaultLiteralExpression)
                    );
                }
                return base.VisitAssignmentExpression(node);
            }

            public override SyntaxNode? VisitInvocationExpression(InvocationExpressionSyntax node)
            {
                var symbolInfo = SemanticModel.GetSymbolInfo(node);
                InvocationExpressionSyntax newInvocation = node;
                bool changed = false;
                string type = symbolInfo.Symbol?.GetType().ToString() ?? "";
                if (symbolInfo.Symbol is IMethodSymbol methodSymbol)
                {
                    var arguments = newInvocation.ArgumentList.Arguments;
                    for (int i = 0; i < arguments.Count; i++)
                    {
                        var argument = arguments[i];

                        // Get the corresponding parameter type
                        int pointerDepth = GetPointerDepth(
                            methodSymbol.Parameters[i].Type,
                            out ITypeSymbol parameterType
                        );

                        if (pointerDepth != 1)
                            continue;

                        var name = GetTypeName(parameterType?.ToString() ?? string.Empty);

                        // Check if the argument is a null literal
                        if (argument.Expression.IsKind(SyntaxKind.NullLiteralExpression))
                        {
                            // Check if the parameter type is ComType
                            if (InterfaceTypes.ContainsKey(name))
                            {
                                changed = true;
                                var newDefaultArg = Argument(
                                    LiteralExpression(SyntaxKind.DefaultLiteralExpression)
                                );
                                newInvocation = newInvocation.ReplaceNode(argument, newDefaultArg);
                                arguments = newInvocation.ArgumentList.Arguments;
                            }
                        }
                    }
                }
                else if (symbolInfo.Symbol is IFunctionPointerTypeSymbol functionPointerSymbol)
                {
                    var arguments = newInvocation.ArgumentList.Arguments;
                    int pointerDepth = 0;
                    ITypeSymbol parameterType;
                    string? name;
                    int i;
                    TypeSyntax castType;
                    for (i = 0; i < arguments.Count; i++)
                    {
                        ArgumentSyntax argument = arguments[i];

                        // Get the corresponding parameter type
                        pointerDepth = GetPointerDepth(
                            functionPointerSymbol.Signature.Parameters[i].Type,
                            out parameterType
                        );
                        name = GetTypeName(parameterType?.ToString() ?? string.Empty);

                        bool changedArg = TryChangeNativeArgument(
                            argument,
                            pointerDepth,
                            name,
                            out var newArg
                        );
                        if (changedArg)
                        {
                            changed = true;
                            newInvocation = newInvocation.ReplaceNode(argument, newArg);
                            arguments = newInvocation.ArgumentList.Arguments;
                        }
                    }

                    pointerDepth = GetPointerDepth(
                        functionPointerSymbol.Signature.ReturnType,
                        out parameterType
                    );
                    name = GetTypeName(parameterType?.ToString() ?? string.Empty);

                    castType = ParseTypeName(name);
                    for (; pointerDepth > 0; pointerDepth--)
                    {
                        castType = PointerType(castType);
                    }

                    if (InterfaceTypes.ContainsKey(name))
                    {
                        return CastExpression(castType, newInvocation);
                    }
                }
                return changed ? newInvocation : base.VisitInvocationExpression(node);
            }

            public override SyntaxNode? VisitBinaryExpression(BinaryExpressionSyntax node)
            {
                if (
                    !node.Left.IsKind(SyntaxKind.NullLiteralExpression)
                    && !node.Right.IsKind(SyntaxKind.NullLiteralExpression)
                )
                    return base.VisitBinaryExpression(node);

                var typeInfoR = SemanticModel.GetTypeInfo(node.Right);
                var typeInfoL = SemanticModel.GetTypeInfo(node.Left);

                ITypeSymbol? innerTypeR = null;
                ITypeSymbol? innerTypeL = null;
                int depthR = 0;
                int depthL = 0;

                if (
                    (
                        typeInfoR.Type is null
                        || (depthR = GetPointerDepth(typeInfoR.Type, out innerTypeR)) > 1
                    )
                    && (
                        typeInfoL.Type is null
                        || (depthL = GetPointerDepth(typeInfoL.Type, out innerTypeL)) > 1
                    )
                )
                    return base.VisitBinaryExpression(node);

                var nameR = GetTypeName(innerTypeR?.ToString() ?? string.Empty);
                var nameL = GetTypeName(innerTypeL?.ToString() ?? string.Empty);

                if (node.Left.IsKind(SyntaxKind.NullLiteralExpression))
                {
                    // Check if the type is a ComType
                    if (depthR <= 1 && typeInfoR.Type != null && InterfaceTypes.ContainsKey(nameR))
                    {
                        return BinaryExpression(
                            node.Kind(),
                            node.Left,
                            IdentifierName($"{node.Right.ToString()}.lpVtbl")
                        );
                    }
                }
                else
                {
                    // Check if the type is a ComType
                    if (depthL <= 1 && typeInfoL.Type != null && InterfaceTypes.ContainsKey(nameL))
                    {
                        return BinaryExpression(
                            node.Kind(),
                            IdentifierName($"{node.Left.ToString()}.lpVtbl"),
                            node.Right
                        );
                    }
                }

                return base.VisitBinaryExpression(node);
            }

            public override SyntaxNode? VisitVariableDeclaration(VariableDeclarationSyntax node)
            {
                if (
                    !node.Variables.Any(var =>
                        var.Initializer is not null
                        && var.Initializer.Value is LiteralExpressionSyntax lit
                        && lit.IsKind(SyntaxKind.NullLiteralExpression)
                    )
                )
                    return base.VisitVariableDeclaration(node);

                // Get the corresponding parameter type
                var variableType = node.Type;
                var pointerDepth = GetPointerDepth(variableType, out var innerType);
                if (pointerDepth > 1)
                    return base.VisitVariableDeclaration(node);

                if (pointerDepth == 0)
                {
                    return node.WithType(ParseTypeName($"{variableType}.Native"));
                }

                var name = GetTypeName(innerType.ToString() ?? string.Empty);

                // Check if the parameter type is ComType
                if (!InterfaceTypes.ContainsKey(name))
                {
                    return base.VisitVariableDeclaration(node);
                }

                var newInstantiation = node;
                var variables = node.Variables;
                for (int i = 0; i < variables.Count; i++)
                {
                    var variableExpression =
                        variables[i].Initializer?.Value as LiteralExpressionSyntax;
                    // Check if the variable is instantiated to a null literal
                    if (
                        variableExpression is not null
                        && variableExpression.IsKind(SyntaxKind.NullLiteralExpression)
                    )
                    {
                        var newDefaultArg = LiteralExpression(SyntaxKind.DefaultLiteralExpression);
                        newInstantiation = newInstantiation.ReplaceNode(
                            variableExpression,
                            newDefaultArg
                        );
                    }
                }
                return newInstantiation;
            }

            public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node)
            {
                var orig = node;
                if (node.Modifiers.Any(token => token.IsKind(SyntaxKind.ExternKeyword)))
                {
                    var pointerDepth = GetPointerDepth(node.ReturnType, out var innerType);
                    var name = innerType.ToString();
                    var shouldEditReturnType = InterfaceTypes.ContainsKey(name);
                    if (
                        shouldEditReturnType
                        || node.ParameterList.Parameters.Any(param =>
                        {
                            if (param.Type is null)
                                return false;
                            pointerDepth = GetPointerDepth(param.Type, out var innerType);
                            name = innerType.ToString();
                            return InterfaceTypes.ContainsKey(name);
                        })
                    )
                    {
                        pointerDepth = GetPointerDepth(orig.ReturnType, out innerType);
                        var returnType = shouldEditReturnType
                            ? IdentifierName($"{innerType}.Native")
                            : orig.ReturnType;
                        if (shouldEditReturnType)
                        {
                            for (; pointerDepth > 0; pointerDepth--)
                            {
                                returnType = PointerType(returnType);
                            }
                        }

                        node = node.WithIdentifier(Identifier($"_{node.Identifier}"))
                            .WithReturnType(returnType)
                            .WithModifiers(
                                TokenList(
                                    node.Modifiers.Where(modifier =>
                                        !modifier.IsKind(SyntaxKind.PublicKeyword)
                                    )
                                )
                            )
                            .AddModifiers(Token(SyntaxKind.PrivateKeyword).WithLeadingTrivia());

                        var InvocationExp = InvocationExpression(
                            IdentifierName(node.Identifier.Text),
                            ArgumentList(
                                SeparatedList(
                                    node.ParameterList.Parameters.Select(param =>
                                    {
                                        if (param.Type is null)
                                        {
                                            return Argument(IdentifierName(param.Identifier.Text));
                                        }

                                        pointerDepth = GetPointerDepth(
                                            param.Type,
                                            out var parameterType
                                        );
                                        name = GetTypeName(
                                            parameterType?.ToString() ?? string.Empty
                                        );

                                        TryChangeNativeArgument(
                                            Argument(IdentifierName(param.Identifier.Text)),
                                            pointerDepth,
                                            name,
                                            out var newArg
                                        );
                                        return newArg;
                                    })
                                )
                            )
                        );

                        _newMethods.Add(
                            MethodDeclaration(orig.ReturnType, orig.Identifier)
                                .WithParameterList(orig.ParameterList)
                                .WithModifiers(
                                    TokenList(
                                        orig.Modifiers.Where(modifier =>
                                            !modifier.IsKind(SyntaxKind.ExternKeyword)
                                        )
                                    )
                                )
                                .WithExpressionBody(
                                    ArrowExpressionClause(
                                        shouldEditReturnType
                                            ? CastExpression(orig.ReturnType, InvocationExp)
                                            : InvocationExp
                                    )
                                )
                                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                        );
                    }
                }

                return base.VisitMethodDeclaration(node);
            }

            public override SyntaxNode? VisitPropertyDeclaration(PropertyDeclarationSyntax node)
            {
                if (
                    node.Type is FunctionPointerTypeSyntax funcPtrType
                    && node.ExpressionBody is not null
                    && node.ExpressionBody.Expression is PrefixUnaryExpressionSyntax pues
                    && funcPtrType.ParameterList.Parameters.Any(param =>
                    {
                        var pointerDepth = GetPointerDepth(param.Type, out var innerType);
                        var name = innerType.ToString();
                        return InterfaceTypes.ContainsKey(name);
                    })
                )
                {
                    node = node.WithExpressionBody(
                        ArrowExpressionClause(
                            PrefixUnaryExpression(
                                SyntaxKind.AddressOfExpression,
                                IdentifierName($"_{pues.Operand.ToString()}")
                            )
                        )
                    );
                }
                return base.VisitPropertyDeclaration(node);
            }

            public override SyntaxNode? VisitStructDeclaration(StructDeclarationSyntax node) =>
                MethodAddDeclaration(() => base.VisitStructDeclaration(node));

            public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node) =>
                MethodAddDeclaration(() => base.VisitClassDeclaration(node));

            private SyntaxNode? MethodAddDeclaration(Func<SyntaxNode?> typeVisit)
            {
                var parentNewMehods = _newMethods;
                _newMethods = _newMethods.Count > 0 ? [] : _newMethods;
                var newNode = typeVisit();

                if (newNode is not TypeDeclarationSyntax typeNode)
                    return newNode;
                if (_newMethods.Count > 0)
                    typeNode = typeNode.AddMembers(_newMethods.ToArray());
                _newMethods.Clear();
                _newMethods = parentNewMehods;

                return typeNode;
            }

            private string GetTypeName(string fullTypeName)
            {
                int dot = fullTypeName.LastIndexOf('.');

                if (dot != -1)
                {
                    return fullTypeName.Substring(dot + 1);
                }

                return fullTypeName;
            }

            private bool TryChangeNativeArgument(
                ArgumentSyntax originalArg,
                int pointerDepth,
                string name,
                [NotNullWhen(true)] out ArgumentSyntax newArg
            )
            {
                if (
                    pointerDepth == 0
                    || !InterfaceTypes.ContainsKey(name)
                    || (
                        originalArg.Expression is CastExpressionSyntax cast
                        && cast.Expression.ToString() == "Unsafe.AsPointer(ref this)"
                    )
                )
                {
                    newArg = originalArg;
                    return false;
                }

                if (pointerDepth > 2)
                {
                    var castType = ParseTypeName(name);
                    for (; pointerDepth > 0; pointerDepth--)
                    {
                        castType = PointerType(castType);
                    }

                    newArg = Argument(CastExpression(castType, originalArg.Expression));
                    return true;
                }

                // Check if the argument is a null literal
                if (originalArg.Expression.IsKind(SyntaxKind.NullLiteralExpression))
                {
                    newArg = Argument(LiteralExpression(SyntaxKind.DefaultLiteralExpression));
                }
                else if (pointerDepth == 1)
                {
                    newArg = Argument(
                        MemberAccessExpression(
                            SyntaxKind.SimpleMemberAccessExpression,
                            originalArg.Expression,
                            IdentifierName("lpVtbl")
                        )
                    );
                }
                else
                {
                    newArg = Argument(
                        PrefixUnaryExpression(
                            SyntaxKind.AddressOfExpression,
                            MemberAccessExpression(
                                SyntaxKind.PointerMemberAccessExpression,
                                originalArg.Expression,
                                IdentifierName("lpVtbl")
                            )
                        )
                    );
                }
                return true;
            }
        }

        class Rewriter(Dictionary<string, string> InterfaceTypes) : CSharpSyntaxRewriter
        {
            string currentType = "";

            public override SyntaxNode? VisitPointerType(PointerTypeSyntax node)
            {
                var name = node.ElementType.ToString();

                return
                    (
                        name == currentType
                        && node.Parent?.Parent is ArgumentSyntax arg1
                        && arg1.Parent is ArgumentListSyntax argList1
                        && argList1.Arguments[0] == arg1
                    )
                    || (
                        node.Parent is CastExpressionSyntax cast1
                        && cast1.Expression.ToString() == "Unsafe.AsPointer(ref this)"
                    )
                    || node.Ancestors()
                        .Any(anc =>
                            anc is FunctionPointerParameterSyntax
                            || (
                                anc is InvocationExpressionSyntax ies
                                && (
                                    ies.Expression.DescendantNodes()
                                        .Any(desc => desc is FunctionPointerTypeSyntax)
                                    || (
                                        ies.FirstAncestorOrSelf<TypeDeclarationSyntax>(an =>
                                                an is TypeDeclarationSyntax
                                            )
                                            ?.Members.Any(mem =>
                                                mem is MethodDeclarationSyntax meth
                                                && meth.Identifier.Text == ies.Expression.ToString()
                                                && meth.Modifiers.Any(mod =>
                                                    mod.IsKind(SyntaxKind.PrivateKeyword)
                                                )
                                                && meth.Modifiers.Any(mod =>
                                                    mod.IsKind(SyntaxKind.ExternKeyword)
                                                )
                                            ) ?? false
                                    )
                                )
                            )
                            || (
                                anc is MethodDeclarationSyntax mds
                                && mds.Modifiers.Any(mod => mod.IsKind(SyntaxKind.ExternKeyword))
                                && mds.Modifiers.Any(mod => mod.IsKind(SyntaxKind.PrivateKeyword))
                            )
                        )
                    || !InterfaceTypes.ContainsKey(name)
                    ? base.VisitPointerType(node)
                    : IdentifierName(name);
            }

            public override SyntaxNode? VisitIdentifierName(IdentifierNameSyntax node)
            {
                var name = node.Identifier.Text;
                return
                    InterfaceTypes.ContainsKey(name)
                    && node.Ancestors().OfType<TypeSyntax>().Count() > 0
                    ? IdentifierName($"{name}.Native")
                    : base.VisitIdentifierName(node);
            }

            public override SyntaxNode? VisitParameter(ParameterSyntax node)
            {
                var visited = base.VisitParameter(node);
                var visitedParameter = visited as ParameterSyntax;
                if (
                    visitedParameter is null
                    || visitedParameter.Default is null
                    || visitedParameter.Type is null
                    || !visitedParameter.Default.Value.IsKind(SyntaxKind.NullLiteralExpression)
                    || !InterfaceTypes.ContainsKey(
                        visitedParameter.Type?.ToString() ?? string.Empty
                    )
                )
                {
                    return visited;
                }

                return Parameter(
                    visitedParameter.AttributeLists,
                    visitedParameter.Modifiers,
                    visitedParameter.Type,
                    visitedParameter.Identifier,
                    EqualsValueClause(LiteralExpression(SyntaxKind.DefaultLiteralExpression))
                );
            }

            const string NATIVE_VARIABLE_NAME = "lpVtbl";

            public override SyntaxNode? VisitStructDeclaration(StructDeclarationSyntax node)
            {
                string name = node.Identifier.ToString();

                if (InterfaceTypes.TryGetValue(name, out var Value))
                {
                    currentType = name;
                    //visit and modify ComType Variables and internal usages first
                    node = (base.VisitStructDeclaration(node) as StructDeclarationSyntax)!;

                    var constructors = node.Members.OfType<ConstructorDeclarationSyntax>();
                    node = node.RemoveNodes(constructors, SyntaxRemoveOptions.KeepNoTrivia)!;
                    node = node.AddMembers(
                        constructors
                            .Select(cons => cons.WithIdentifier(Identifier("Native")))
                            .ToArray()
                    );

                    var nativeName = $"{name}.Native";

                    var parentNode = StructDeclaration(
                            node.AttributeLists,
                            node.Modifiers,
                            Identifier(name),
                            null,
                            null,
                            List<TypeParameterConstraintClauseSyntax>([]),
                            List<MemberDeclarationSyntax>(
                                [
                                    FieldDeclaration(
                                            VariableDeclaration(
                                                PointerType(ParseTypeName("Native")),
                                                SingletonSeparatedList(
                                                    VariableDeclarator(NATIVE_VARIABLE_NAME)
                                                )
                                            )
                                        )
                                        .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword))),
                                ]
                            )
                        )
                        .AddMembers(
                            node.Members.Where(mem =>
                                    (
                                        mem is MethodDeclarationSyntax meth
                                        && meth.ExplicitInterfaceSpecifier is not null
                                    )
                                    || (
                                        mem is PropertyDeclarationSyntax prop
                                        && prop?.ExplicitInterfaceSpecifier is not null
                                    )
                                    || (
                                        (
                                            mem is MethodDeclarationSyntax
                                            || mem is PropertyDeclarationSyntax
                                        )
                                        && mem.Modifiers.Any(mod =>
                                            mod.IsKind(SyntaxKind.PublicKeyword)
                                        )
                                    )
                                )
                                .Select(origMember =>
                                {
                                    bool isStatic = origMember.Modifiers.Any(mod =>
                                        mod.IsKind(SyntaxKind.StaticKeyword)
                                    );
                                    bool isPublic = origMember.Modifiers.Any(mod =>
                                        mod.IsKind(SyntaxKind.PublicKeyword)
                                    );
                                    var AccessKind = isStatic
                                        ? SyntaxKind.SimpleMemberAccessExpression
                                        : SyntaxKind.PointerMemberAccessExpression;
                                    ExpressionSyntax variable = isStatic
                                        ? IdentifierName("Native")
                                        : IdentifierName(NATIVE_VARIABLE_NAME);
                                    if (origMember is MethodDeclarationSyntax method)
                                    {
                                        var node = MethodDeclaration(
                                                method.ReturnType,
                                                method.Identifier
                                            )
                                            .WithAttributeLists(method.AttributeLists)
                                            .WithModifiers(method.Modifiers)
                                            .WithExplicitInterfaceSpecifier(
                                                method.ExplicitInterfaceSpecifier
                                            )
                                            .WithParameterList(method.ParameterList)
                                            .WithLeadingTrivia(method.GetLeadingTrivia());

                                        if (method.ExplicitInterfaceSpecifier is not null)
                                        {
                                            if (method.ExpressionBody is not null)
                                            {
                                                node = node.WithExpressionBody(
                                                    method.ExpressionBody
                                                );
                                            }
                                            else
                                            {
                                                node = node.WithBody(method.Body);
                                            }
                                        }
                                        else
                                        {
                                            node = node.WithExpressionBody(
                                                    ArrowExpressionClause(
                                                        InvocationExpression(
                                                            MemberAccessExpression(
                                                                AccessKind,
                                                                variable,
                                                                IdentifierName(method.Identifier)
                                                            ),
                                                            ArgumentList(
                                                                SeparatedList(
                                                                    method.ParameterList.Parameters.Select(
                                                                        param =>
                                                                            Argument(
                                                                                IdentifierName(
                                                                                    param.Identifier
                                                                                )
                                                                            )
                                                                    )
                                                                )
                                                            )
                                                        )
                                                    )
                                                )
                                                .WithSemicolonToken(
                                                    Token(SyntaxKind.SemicolonToken)
                                                );
                                        }

                                        return (MemberDeclarationSyntax)node;
                                    }
                                    else
                                    {
                                        var property = (origMember as PropertyDeclarationSyntax)!;

                                        var node = PropertyDeclaration(
                                                property.Type,
                                                property.Identifier
                                            )
                                            .WithAttributeLists(property.AttributeLists)
                                            .WithModifiers(property.Modifiers)
                                            .WithExplicitInterfaceSpecifier(
                                                property.ExplicitInterfaceSpecifier
                                            )
                                            .WithLeadingTrivia(property.GetLeadingTrivia());

                                        if (property.ExplicitInterfaceSpecifier is not null)
                                        {
                                            if (property.ExpressionBody is not null)
                                            {
                                                node = node.WithExpressionBody(
                                                        property.ExpressionBody
                                                    )
                                                    .WithSemicolonToken(
                                                        Token(SyntaxKind.SemicolonToken)
                                                    );
                                            }
                                            else
                                            {
                                                node = node.WithAccessorList(property.AccessorList);
                                            }
                                        }
                                        else
                                        {
                                            node = node.WithExpressionBody(
                                                    ArrowExpressionClause(
                                                        MemberAccessExpression(
                                                            AccessKind,
                                                            variable,
                                                            IdentifierName(property.Identifier)
                                                        )
                                                    )
                                                )
                                                .WithSemicolonToken(
                                                    Token(SyntaxKind.SemicolonToken)
                                                );
                                        }

                                        return node;
                                    }
                                })
                                .ToArray()
                        )
                        .AddMembers([node.WithIdentifier(Identifier("Native"))])
                        .WithLeadingTrivia(node.GetLeadingTrivia())
                        .WithBaseList(node.BaseList)
                        .AddBaseListTypes(SimpleBaseType(ParseTypeName("INativeInterface")));

                    //Add vtbl constructor to ComType
                    parentNode = parentNode.AddMembers(
                        ConstructorDeclaration(name)
                            .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                            .WithParameterList(
                                ParameterList(
                                    SingletonSeparatedList(
                                        Parameter(Identifier("vtbl"))
                                            .WithType(ParseTypeName("Ptr3D"))
                                    )
                                )
                            )
                            .WithExpressionBody(
                                ArrowExpressionClause(
                                    AssignmentExpression(
                                        SyntaxKind.SimpleAssignmentExpression,
                                        IdentifierName("lpVtbl"),
                                        CastExpression(
                                            PointerType(ParseTypeName(nativeName)),
                                            IdentifierName("vtbl")
                                        )
                                    )
                                )
                            )
                            .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                            .WithLeadingTrivia(
                                TriviaList(
                                    Trivia(
                                        DocumentationCommentTrivia(
                                                SyntaxKind.SingleLineDocumentationCommentTrivia
                                            )
                                            .WithContent(
                                                List(
                                                    new XmlNodeSyntax[]
                                                    {
                                                        XmlText()
                                                            .WithTextTokens(
                                                                TokenList(
                                                                    XmlTextLiteral(
                                                                        TriviaList(
                                                                            DocumentationCommentExterior(
                                                                                "/// "
                                                                            )
                                                                        ),
                                                                        " ",
                                                                        " ",
                                                                        TriviaList()
                                                                    )
                                                                )
                                                            ),
                                                        XmlElement(
                                                            XmlElementStartTag(XmlName("summary")),
                                                            List(
                                                                new XmlNodeSyntax[]
                                                                {
                                                                    XmlText(
                                                                        "Initializes a new instance of the "
                                                                    ),
                                                                    XmlEmptyElement(
                                                                        XmlName("see"),
                                                                        List<XmlAttributeSyntax>(
                                                                            new[]
                                                                            {
                                                                                XmlCrefAttribute(
                                                                                    NameMemberCref(
                                                                                        IdentifierName(
                                                                                            name
                                                                                        )
                                                                                    )
                                                                                ),
                                                                            }
                                                                        )
                                                                    ),
                                                                    XmlText(
                                                                        " struct with the specified virtual table pointer."
                                                                    ),
                                                                }
                                                            ),
                                                            XmlElementEndTag(XmlName("summary"))
                                                        ),
                                                        XmlText()
                                                            .WithTextTokens(
                                                                TokenList(
                                                                    XmlTextNewLine(
                                                                        TriviaList(),
                                                                        "\n",
                                                                        "\n",
                                                                        TriviaList()
                                                                    )
                                                                )
                                                            ),
                                                        XmlText()
                                                            .WithTextTokens(
                                                                TokenList(
                                                                    XmlTextLiteral(
                                                                        TriviaList(
                                                                            DocumentationCommentExterior(
                                                                                "/// "
                                                                            )
                                                                        ),
                                                                        " ",
                                                                        " ",
                                                                        TriviaList()
                                                                    )
                                                                )
                                                            ),
                                                        XmlElement(
                                                            XmlElementStartTag(XmlName("param"))
                                                                .WithAttributes(
                                                                    SingletonList<XmlAttributeSyntax>(
                                                                        XmlNameAttribute(
                                                                            XmlName("name"),
                                                                            Token(
                                                                                SyntaxKind.DoubleQuoteToken
                                                                            ),
                                                                            IdentifierName("vtbl"),
                                                                            Token(
                                                                                SyntaxKind.DoubleQuoteToken
                                                                            )
                                                                        )
                                                                    )
                                                                ),
                                                            SingletonList<XmlNodeSyntax>(
                                                                XmlText(
                                                                    "The pointer to virtual table."
                                                                )
                                                            ),
                                                            XmlElementEndTag(XmlName("param"))
                                                        ),
                                                        XmlText()
                                                            .WithTextTokens(
                                                                TokenList(
                                                                    XmlTextNewLine(
                                                                        TriviaList(),
                                                                        "\n",
                                                                        "\n",
                                                                        TriviaList()
                                                                    )
                                                                )
                                                            ),
                                                    }
                                                )
                                            )
                                    )
                                )
                            ),
                        ConstructorDeclaration(name)
                            .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                            .WithParameterList(
                                ParameterList(
                                    SingletonSeparatedList(
                                        Parameter(Identifier("vtbl"))
                                            .WithType(ParseTypeName($"Ptr<{nativeName}>"))
                                    )
                                )
                            )
                            .WithExpressionBody(
                                ArrowExpressionClause(
                                    AssignmentExpression(
                                        SyntaxKind.SimpleAssignmentExpression,
                                        IdentifierName("lpVtbl"),
                                        IdentifierName("vtbl")
                                    )
                                )
                            )
                            .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                            .WithLeadingTrivia(
                                TriviaList(
                                    Trivia(
                                        DocumentationCommentTrivia(
                                                SyntaxKind.SingleLineDocumentationCommentTrivia
                                            )
                                            .WithContent(
                                                List(
                                                    new XmlNodeSyntax[]
                                                    {
                                                        XmlText()
                                                            .WithTextTokens(
                                                                TokenList(
                                                                    XmlTextLiteral(
                                                                        TriviaList(
                                                                            DocumentationCommentExterior(
                                                                                "/// "
                                                                            )
                                                                        ),
                                                                        " ",
                                                                        " ",
                                                                        TriviaList()
                                                                    )
                                                                )
                                                            ),
                                                        XmlElement(
                                                            XmlElementStartTag(XmlName("summary")),
                                                            List(
                                                                new XmlNodeSyntax[]
                                                                {
                                                                    XmlText(
                                                                        "Initializes a new instance of the "
                                                                    ),
                                                                    XmlEmptyElement(
                                                                        XmlName("see"),
                                                                        List<XmlAttributeSyntax>(
                                                                            new[]
                                                                            {
                                                                                XmlCrefAttribute(
                                                                                    NameMemberCref(
                                                                                        IdentifierName(
                                                                                            name
                                                                                        )
                                                                                    )
                                                                                ),
                                                                            }
                                                                        )
                                                                    ),
                                                                    XmlText(
                                                                        " struct with the specified virtual table pointer."
                                                                    ),
                                                                }
                                                            ),
                                                            XmlElementEndTag(XmlName("summary"))
                                                        ),
                                                        XmlText()
                                                            .WithTextTokens(
                                                                TokenList(
                                                                    XmlTextNewLine(
                                                                        TriviaList(),
                                                                        "\n",
                                                                        "\n",
                                                                        TriviaList()
                                                                    )
                                                                )
                                                            ),
                                                        XmlText()
                                                            .WithTextTokens(
                                                                TokenList(
                                                                    XmlTextLiteral(
                                                                        TriviaList(
                                                                            DocumentationCommentExterior(
                                                                                "/// "
                                                                            )
                                                                        ),
                                                                        " ",
                                                                        " ",
                                                                        TriviaList()
                                                                    )
                                                                )
                                                            ),
                                                        XmlElement(
                                                            XmlElementStartTag(XmlName("param"))
                                                                .WithAttributes(
                                                                    SingletonList<XmlAttributeSyntax>(
                                                                        XmlNameAttribute(
                                                                            XmlName("name"),
                                                                            Token(
                                                                                SyntaxKind.DoubleQuoteToken
                                                                            ),
                                                                            IdentifierName("vtbl"),
                                                                            Token(
                                                                                SyntaxKind.DoubleQuoteToken
                                                                            )
                                                                        )
                                                                    )
                                                                ),
                                                            SingletonList<XmlNodeSyntax>(
                                                                XmlText(
                                                                    "The pointer to virtual table."
                                                                )
                                                            ),
                                                            XmlElementEndTag(XmlName("param"))
                                                        ),
                                                        XmlText()
                                                            .WithTextTokens(
                                                                TokenList(
                                                                    XmlTextNewLine(
                                                                        TriviaList(),
                                                                        "\n",
                                                                        "\n",
                                                                        TriviaList()
                                                                    )
                                                                )
                                                            ),
                                                    }
                                                )
                                            )
                                    )
                                )
                            )
                    );

                    parentNode = parentNode.AddMembers(
                        MethodDeclaration(
                                GenericName("Ptr2D")
                                    .WithTypeArgumentList(
                                        TypeArgumentList(
                                            SingletonSeparatedList(
                                                ParseTypeName("TNativeInterface")
                                            )
                                        )
                                    ),
                                "GetAddressOf"
                            )
                            .WithModifiers(
                                TokenList(
                                    Token(SyntaxKind.PublicKeyword),
                                    Token(SyntaxKind.ReadOnlyKeyword)
                                )
                            )
                            .WithTypeParameterList(
                                TypeParameterList(
                                    SingletonSeparatedList(TypeParameter("TNativeInterface"))
                                )
                            )
                            .WithConstraintClauses(
                                List(
                                    [
                                        TypeParameterConstraintClause(
                                            IdentifierName("TNativeInterface"),
                                            SingletonSeparatedList<TypeParameterConstraintSyntax>(
                                                TypeConstraint(IdentifierName("unmanaged"))
                                            )
                                        ),
                                    ]
                                )
                            )
                            .WithExpressionBody(
                                ArrowExpressionClause(
                                    CastExpression(
                                        PointerType(PointerType(ParseTypeName("TNativeInterface"))),
                                        InvocationExpression(
                                            MemberAccessExpression(
                                                SyntaxKind.SimpleMemberAccessExpression,
                                                IdentifierName("Unsafe"),
                                                IdentifierName("AsPointer")
                                            ),
                                            ArgumentList(
                                                SingletonSeparatedList(
                                                    Argument(
                                                        RefExpression(
                                                            InvocationExpression(
                                                                MemberAccessExpression(
                                                                    SyntaxKind.SimpleMemberAccessExpression,
                                                                    IdentifierName("Unsafe"),
                                                                    IdentifierName("AsRef")
                                                                ),
                                                                ArgumentList(
                                                                    SingletonSeparatedList(
                                                                        Argument(ThisExpression())
                                                                            .WithRefKindKeyword(
                                                                                Token(
                                                                                    SyntaxKind.InKeyword
                                                                                )
                                                                            )
                                                                    )
                                                                )
                                                            )
                                                        )
                                                    )
                                                )
                                            )
                                        )
                                    )
                                )
                            )
                            .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                            .WithLeadingTrivia(
                                Trivia(
                                    DocumentationCommentTrivia(
                                        SyntaxKind.SingleLineDocumentationCommentTrivia,
                                        List(
                                            new XmlNodeSyntax[]
                                            {
                                                XmlText("/// "),
                                                XmlElement(
                                                    XmlElementStartTag(XmlName("inheritdoc"))
                                                        .WithAttributes(
                                                            SingletonList<XmlAttributeSyntax>(
                                                                XmlCrefAttribute(
                                                                    NameMemberCref(
                                                                        IdentifierName(
                                                                            "INativeInterface.GetAddressOf{TNativeInterface}()"
                                                                        )
                                                                    )
                                                                )
                                                            )
                                                        ),
                                                    XmlElementEndTag(XmlName("inheritdoc"))
                                                ),
                                                XmlText("\n\t"),
                                            }
                                        )
                                    )
                                )
                            ),
                        MethodDeclaration(ParseTypeName("Ptr2D"), "GetAddressOf")
                            .WithModifiers(
                                TokenList(
                                    Token(SyntaxKind.PublicKeyword),
                                    Token(SyntaxKind.ReadOnlyKeyword)
                                )
                            )
                            .WithExpressionBody(
                                ArrowExpressionClause(
                                    CastExpression(
                                        PointerType(PointerType(ParseTypeName("void"))),
                                        InvocationExpression(
                                            MemberAccessExpression(
                                                SyntaxKind.SimpleMemberAccessExpression,
                                                IdentifierName("Unsafe"),
                                                IdentifierName("AsPointer")
                                            ),
                                            ArgumentList(
                                                SingletonSeparatedList(
                                                    Argument(
                                                        RefExpression(
                                                            InvocationExpression(
                                                                MemberAccessExpression(
                                                                    SyntaxKind.SimpleMemberAccessExpression,
                                                                    IdentifierName("Unsafe"),
                                                                    IdentifierName("AsRef")
                                                                ),
                                                                ArgumentList(
                                                                    SingletonSeparatedList(
                                                                        Argument(ThisExpression())
                                                                            .WithRefKindKeyword(
                                                                                Token(
                                                                                    SyntaxKind.InKeyword
                                                                                )
                                                                            )
                                                                    )
                                                                )
                                                            )
                                                        )
                                                    )
                                                )
                                            )
                                        )
                                    )
                                )
                            )
                            .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                            .WithLeadingTrivia(
                                Trivia(
                                    DocumentationCommentTrivia(
                                        SyntaxKind.SingleLineDocumentationCommentTrivia,
                                        List(
                                            new XmlNodeSyntax[]
                                            {
                                                XmlText("/// "),
                                                XmlElement(
                                                    XmlElementStartTag(XmlName("inheritdoc"))
                                                        .WithAttributes(
                                                            SingletonList<XmlAttributeSyntax>(
                                                                XmlCrefAttribute(
                                                                    NameMemberCref(
                                                                        IdentifierName(
                                                                            "INativeInterface.GetAddressOf()"
                                                                        )
                                                                    )
                                                                )
                                                            )
                                                        ),
                                                    XmlElementEndTag(XmlName("inheritdoc"))
                                                ),
                                                XmlText("\n\t"),
                                            }
                                        )
                                    )
                                )
                            )
                    );

                    parentNode = generateCasts(parentNode, name, PointerType(ParseTypeName(nativeName)),  nativeName, CastExpression(ParseTypeName("Ptr<Native>"), IdentifierName("value")), false, true);
                    parentNode = generateCasts(parentNode, name, ParseTypeName("Ptr3D"), "Ptr3D", IdentifierName("value"), pointerCast: false);
                    parentNode = generateCasts(
                        parentNode,
                        name,
                        ParseTypeName($"Ptr<{nativeName}>"),
                        $"Ptr<T>",
                        IdentifierName("value"),
                        pointerCast: false
                    );
                    parentNode = generateCasts(
                        parentNode,
                        name,
                        PointerType(PointerType(PointerType(ParseTypeName("void")))),
                        "void***",
                        CastExpression(ParseTypeName("Ptr<Native>"),IdentifierName("value")),
                        castSeeTag: false
                        );

                    parentNode = generateCasts(
                        parentNode,
                        name,
                        ParseTypeName("nuint"),
                        "nuint",
                        CastExpression(ParseTypeName("Ptr<Native>"),
                            InvocationExpression(
                                MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    IdentifierName("value"),
                                    IdentifierName("ToPointer")
                                )
                            )
                        ),
                        pointerCast: false
                        );

                    currentType = "";
                    return parentNode;
                }

                return base.VisitStructDeclaration(node);
            }

            private StructDeclarationSyntax generateCasts(
                StructDeclarationSyntax node,
                string name,
                TypeSyntax castType,
                string castXmlName,
                ExpressionSyntax constructorArgExpression,
                bool castTo = true,
                bool implicitTo = false,
                bool pointerCast = true,
                bool castSeeTag = true
            )
            {
                var castXmlType = ParseTypeName(castXmlName);

                ExpressionSyntax expression = castTo
                    ? CastExpression(
                        castType,
                        MemberAccessExpression(
                            SyntaxKind.SimpleMemberAccessExpression,
                            IdentifierName("value"),
                            IdentifierName("lpVtbl")
                        )
                    )
                    : MemberAccessExpression(
                        SyntaxKind.SimpleMemberAccessExpression,
                        IdentifierName("value"),
                        IdentifierName("lpVtbl")
                    );

                XmlNodeSyntax castXmlTag = castSeeTag ?
                    XmlEmptyElement(
                        XmlName("see"),
                        List<XmlAttributeSyntax>(
                            new[]
                            {
                                XmlCrefAttribute(
                                    NameMemberCref(
                                        castXmlType
                                    )
                                ),
                            }
                        )
                    ) : XmlText(castXmlName);

                return node.AddMembers(
                    ConversionOperatorDeclaration(
                            Token(
                                implicitTo ? SyntaxKind.ImplicitKeyword : SyntaxKind.ExplicitKeyword
                            ),
                            ParseTypeName(name)
                        )
                        .WithModifiers(
                            TokenList(
                                Token(SyntaxKind.PublicKeyword),
                                Token(SyntaxKind.StaticKeyword)
                            )
                        )
                        .WithParameterList(
                            ParameterList(
                                SingletonSeparatedList(
                                    Parameter(Identifier("value")).WithType(castType)
                                )
                            )
                        )
                        .WithExpressionBody(
                            ArrowExpressionClause(
                                ObjectCreationExpression(IdentifierName(name))
                                    .WithArgumentList(
                                        ArgumentList(
                                            SingletonSeparatedList(
                                                Argument(constructorArgExpression)
                                            )
                                        )
                                    )
                            )
                        )
                        .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                        .WithLeadingTrivia(
                            TriviaList(
                                Trivia(
                                    DocumentationCommentTrivia(
                                            SyntaxKind.SingleLineDocumentationCommentTrivia
                                        )
                                        .WithContent(
                                            List(
                                                new XmlNodeSyntax[]
                                                {
                                                    XmlText()
                                                        .WithTextTokens(
                                                            TokenList(
                                                                XmlTextLiteral(
                                                                    TriviaList(
                                                                        DocumentationCommentExterior(
                                                                            "/// "
                                                                        )
                                                                    ),
                                                                    " ",
                                                                    " ",
                                                                    TriviaList()
                                                                )
                                                            )
                                                        ),
                                                    XmlElement(
                                                        XmlElementStartTag(XmlName("summary")),
                                                        List(
                                                            new XmlNodeSyntax[]
                                                            {
                                                                XmlText("casts "),
                                                                castXmlTag,
                                                                XmlText(" to "),
                                                                XmlEmptyElement(
                                                                    XmlName("see"),
                                                                    List<XmlAttributeSyntax>(
                                                                        new[]
                                                                        {
                                                                            XmlCrefAttribute(
                                                                                NameMemberCref(
                                                                                    IdentifierName(
                                                                                        name
                                                                                    )
                                                                                )
                                                                            ),
                                                                        }
                                                                    )
                                                                ),
                                                                XmlText("."),
                                                            }
                                                        ),
                                                        XmlElementEndTag(XmlName("summary"))
                                                    ),
                                                    XmlText()
                                                        .WithTextTokens(
                                                            TokenList(
                                                                XmlTextNewLine(
                                                                    TriviaList(),
                                                                    "\n",
                                                                    "\n",
                                                                    TriviaList()
                                                                )
                                                            )
                                                        ),
                                                    XmlText()
                                                        .WithTextTokens(
                                                            TokenList(
                                                                XmlTextLiteral(
                                                                    TriviaList(
                                                                        DocumentationCommentExterior(
                                                                            "/// "
                                                                        )
                                                                    ),
                                                                    " ",
                                                                    " ",
                                                                    TriviaList()
                                                                )
                                                            )
                                                        ),
                                                    XmlElement(
                                                        XmlElementStartTag(XmlName("param"))
                                                            .WithAttributes(
                                                                SingletonList<XmlAttributeSyntax>(
                                                                    XmlNameAttribute(
                                                                        XmlName("name"),
                                                                        Token(
                                                                            SyntaxKind.DoubleQuoteToken
                                                                        ),
                                                                        IdentifierName("value"),
                                                                        Token(
                                                                            SyntaxKind.DoubleQuoteToken
                                                                        )
                                                                    )
                                                                )
                                                            ),
                                                        List(
                                                            new XmlNodeSyntax[]
                                                            {
                                                                XmlText("The "),
                                                                castXmlTag,
                                                                XmlText(
                                                                    " instance to be converted "
                                                                ),
                                                            }
                                                        ),
                                                        XmlElementEndTag(XmlName("param"))
                                                    ),
                                                    XmlText()
                                                        .WithTextTokens(
                                                            TokenList(
                                                                XmlTextNewLine(
                                                                    TriviaList(),
                                                                    "\n",
                                                                    "\n",
                                                                    TriviaList()
                                                                )
                                                            )
                                                        ),
                                                }
                                            )
                                        )
                                )
                            )
                        ),
                    ConversionOperatorDeclaration(Token(SyntaxKind.ImplicitKeyword), castType)
                        .WithModifiers(
                            TokenList(
                                Token(SyntaxKind.PublicKeyword),
                                Token(SyntaxKind.StaticKeyword)
                            )
                        )
                        .WithParameterList(
                            ParameterList(
                                SingletonSeparatedList(
                                    Parameter(Identifier("value")).WithType(IdentifierName(name))
                                )
                            )
                        )
                        .WithExpressionBody(ArrowExpressionClause(expression))
                        .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                        .WithLeadingTrivia(
                            TriviaList(
                                Trivia(
                                    DocumentationCommentTrivia(
                                            SyntaxKind.SingleLineDocumentationCommentTrivia
                                        )
                                        .WithContent(
                                            List(
                                                new XmlNodeSyntax[]
                                                {
                                                    XmlText()
                                                        .WithTextTokens(
                                                            TokenList(
                                                                XmlTextLiteral(
                                                                    TriviaList(
                                                                        DocumentationCommentExterior(
                                                                            "/// "
                                                                        )
                                                                    ),
                                                                    " ",
                                                                    " ",
                                                                    TriviaList()
                                                                )
                                                            )
                                                        ),
                                                    XmlElement(
                                                        XmlElementStartTag(XmlName("summary")),
                                                        List(
                                                            new XmlNodeSyntax[]
                                                            {
                                                                XmlText("casts "),
                                                                XmlEmptyElement(
                                                                    XmlName("see"),
                                                                    List<XmlAttributeSyntax>(
                                                                        new[]
                                                                        {
                                                                            XmlCrefAttribute(
                                                                                NameMemberCref(
                                                                                    IdentifierName(
                                                                                        name
                                                                                    )
                                                                                )
                                                                            ),
                                                                        }
                                                                    )
                                                                ),
                                                                XmlText(" to "),
                                                                castXmlTag,
                                                                XmlText(
                                                                    $" {(pointerCast ? "pointer" : "")}."
                                                                ),
                                                            }
                                                        ),
                                                        XmlElementEndTag(XmlName("summary"))
                                                    ),
                                                    XmlText()
                                                        .WithTextTokens(
                                                            TokenList(
                                                                XmlTextNewLine(
                                                                    TriviaList(),
                                                                    "\n",
                                                                    "\n",
                                                                    TriviaList()
                                                                )
                                                            )
                                                        ),
                                                    XmlText()
                                                        .WithTextTokens(
                                                            TokenList(
                                                                XmlTextLiteral(
                                                                    TriviaList(
                                                                        DocumentationCommentExterior(
                                                                            "/// "
                                                                        )
                                                                    ),
                                                                    " ",
                                                                    " ",
                                                                    TriviaList()
                                                                )
                                                            )
                                                        ),
                                                    XmlElement(
                                                        XmlElementStartTag(XmlName("param"))
                                                            .WithAttributes(
                                                                SingletonList<XmlAttributeSyntax>(
                                                                    XmlNameAttribute(
                                                                        XmlName("name"),
                                                                        Token(
                                                                            SyntaxKind.DoubleQuoteToken
                                                                        ),
                                                                        IdentifierName("value"),
                                                                        Token(
                                                                            SyntaxKind.DoubleQuoteToken
                                                                        )
                                                                    )
                                                                )
                                                            ),
                                                        List(
                                                            new XmlNodeSyntax[]
                                                            {
                                                                XmlText("The "),
                                                                XmlEmptyElement(
                                                                    XmlName("see"),
                                                                    List<XmlAttributeSyntax>(
                                                                        new[]
                                                                        {
                                                                            XmlCrefAttribute(
                                                                                NameMemberCref(
                                                                                    IdentifierName(
                                                                                        name
                                                                                    )
                                                                                )
                                                                            ),
                                                                        }
                                                                    )
                                                                ),
                                                                XmlText(
                                                                    " instance to be converted "
                                                                ),
                                                            }
                                                        ),
                                                        XmlElementEndTag(XmlName("param"))
                                                    ),
                                                    XmlText()
                                                        .WithTextTokens(
                                                            TokenList(
                                                                XmlTextNewLine(
                                                                    TriviaList(),
                                                                    "\n",
                                                                    "\n",
                                                                    TriviaList()
                                                                )
                                                            )
                                                        ),
                                                }
                                            )
                                        )
                                )
                            )
                        )
                );
            }
        }

        private static int GetPointerDepth(TypeSyntax type, out TypeSyntax innerMost)
        {
            int depth = 0;
            innerMost = type;
            while (innerMost is PointerTypeSyntax pointerType)
            {
                depth++;
                innerMost = pointerType.ElementType;
            }
            return depth;
        }

        private static int GetPointerDepth(ITypeSymbol type, out ITypeSymbol innerMost)
        {
            int depth = 0;
            innerMost = type;
            while (innerMost is IPointerTypeSymbol pointerType)
            {
                depth++;
                innerMost = pointerType.PointedAtType;
            }
            return depth;
        }
    }
}
