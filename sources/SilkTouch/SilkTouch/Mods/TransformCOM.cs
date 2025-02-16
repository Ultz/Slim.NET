// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.CommandLine;
using System.Diagnostics;
using System.Reflection;
using ClangSharp;
using ClangSharp.Interop;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Differencing;
using Microsoft.CodeAnalysis.Editing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Silk.NET.Core;
using Silk.NET.SilkTouch.Logging;
using Silk.NET.SilkTouch.Sources;
using Silk.NET.SilkTouch.Utility;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods
{
    /// <summary>
    /// A mod to modify COM interface structs into opaque structs that act like ComPtr objects
    /// </summary>
    /// <param name="logger">The logger to use.</param>
    /// <param name="config">The configuration to use.</param>
    /// <param name="progressService">the progress service to use</param>
    [ModConfiguration<Configuration>]
    public class TransformCOM(
        ILogger<TransformCOM> logger,
        IOptionsSnapshot<TransformCOM.Configuration> config,
        IProgressService progressService
    ) : Mod
    {
        /// <summary>
        /// The configuration for the <see cref="TransformCOM"/> mod.
        /// </summary>
        public class Configuration
        {
            /// <summary>
            /// The base type names and their full namespace definition to consider the base of the com tree
            /// Usually this is (IUnknown.Interface, Silk.NET.Windows.IUnknown.Interface)
            /// </summary>
            public Dictionary<string, string>? BaseTypes { get; init; }

            /// <summary>
            /// Additional Com Types and (namespace, parent type) which are not read in this job but referenced by it
            /// </summary>
            public IConfigurationSection[]? AdditionalCOMTypes { get; init; }
        }

        /// <inheritdoc />
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

            int count = proj?.DocumentIds.Count ?? 0;
            int index = 0;

            progressService.SetTask("COM Object Discovery");
            var firstPass = new TypeDiscoverer(
                cfg.BaseTypes
                    ?? new() { { "IUnknown.Interface", "Silk.NET.Windows.IUnknown.Interface" } },
                logger
            );

            foreach (var comType in cfg.AdditionalCOMTypes ?? [])
            {
                firstPass.AddInitialType(
                    comType.Key,
                    comType.GetValue<string>("Namespace") ?? "Silk.NET",
                    comType.GetValue<string>("Parent") ?? string.Empty
                );
            }

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

            //Cleanup our lists
            firstPass.FoundCOMTypes = firstPass
                .FoundCOMTypes.Where(val => val.Value.Item1)
                .ToDictionary();

            index = 0;
            var rewriter = new Rewriter(firstPass.FoundCOMTypes);

            progressService.SetTask("COM Object Rewrite");
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

                logger.LogDebug("COM Rewrite for {0} Complete ({1}/{2})", doc.Name, index, count);
                progressService.SetProgress((float)index / count);
            }
            ctx.SourceProject = proj;
        }

        class TypeDiscoverer : CSharpSyntaxWalker
        {
            private Dictionary<string, List<(string, bool, string)>> _interfaceParenting =
                new Dictionary<string, List<(string, bool, string)>>();

            /// <summary>
            /// The list of known COM interface types
            /// (name of type, is it a struct?, InheritanceTree)
            /// </summary>
            public Dictionary<string, (bool, KeyedStringTree?)> FoundCOMTypes = [];

            private readonly Dictionary<string, string> _baseTypes;
            private ILogger<TransformCOM> _logger;

            private List<string> _Namespace = [];

            private List<string> _ObjectNames = [];

            public TypeDiscoverer(
                Dictionary<string, string> BaseTypes,
                ILogger<TransformCOM> logger
            )
            {
                _logger = logger;
                _baseTypes = BaseTypes;
                InheritanceTrees = new KeyedStringTree[_baseTypes.Count];

                int i = 0;
                foreach (var baseType in BaseTypes)
                {
                    InheritanceTrees[i] = new(baseType.Key, baseType.Value);
                    i++;
                }
            }

            public KeyedStringTree[] InheritanceTrees;

            public override void VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
            {
                _Namespace.Add(node.Name.ToString());
                base.VisitNamespaceDeclaration(node);
                _Namespace.RemoveAt(_Namespace.Count - 1);
            }

            public override void VisitFileScopedNamespaceDeclaration(
                FileScopedNamespaceDeclarationSyntax node
            )
            {
                _Namespace.Add(node.Name.ToString());
                base.VisitFileScopedNamespaceDeclaration(node);
                _Namespace.RemoveAt(_Namespace.Count - 1);
            }

            public override void VisitStructDeclaration(StructDeclarationSyntax node)
            {
                _ObjectNames.Add(node.Identifier.Text);
                base.VisitStructDeclaration(node);
                _ObjectNames.RemoveAt(_ObjectNames.Count - 1);

                if (node.Identifier.Text == "Native")
                    return;

                var bases = node.BaseList;

                var fields = node.Members.OfType<FieldDeclarationSyntax>();

                if (
                    bases is null
                    || fields.Any(fds =>
                        !fds.Modifiers.Contains(Token(SyntaxKind.StaticKeyword))
                        && fds.Declaration.Type.ToString() != "Native*"
                        && !fds.Declaration.Type.ToString().StartsWith("delegate")
                        && fds.Declaration.Variables[0].Identifier.Text != "lpVtbl"
                    )
                    || !fields.Any(fds =>
                        fds.Declaration.Type.ToString() == "Native*"
                        && fds.Declaration.Variables[0].Identifier.Text == "lpVtbl"
                    )
                )
                {
                    return;
                }

                var typeName = $"{node.Identifier}";

                if (_ObjectNames.Count > 0)
                    typeName = $"{string.Join('.', _ObjectNames)}.{typeName}";

                CheckBases((typeName, true, string.Join('.', _Namespace)), bases);
            }

            public override void VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
            {
                base.VisitInterfaceDeclaration(node);

                var bases = node.BaseList;

                if (bases is null)
                {
                    return;
                }

                var typeName = $"{node.Identifier}";

                if (_ObjectNames.Count > 0)
                    typeName = $"{string.Join('.', _ObjectNames)}.{typeName}";

                CheckBases((typeName, false, string.Join('.', _Namespace)), bases);
            }

            public void AddInitialType(string typeName, string _namespace, string? parentName)
            {
                if (parentName is null)
                {
                    FoundCOMTypes.Add(typeName, (true, null));
                    return;
                }
                KeyedStringTree? tree = null;

                foreach (var inheritanceTree in InheritanceTrees)
                {
                    if (
                        inheritanceTree.TryAddNode(parentName, typeName, $"{_namespace}.{typeName}")
                    )
                    {
                        tree = inheritanceTree;
                        break;
                    }
                }

                if (tree is not null)
                {
                    COMTypeValidated(typeName, (false, tree), parentName, _namespace);
                    return;
                }

                if (!_interfaceParenting.ContainsKey(parentName))
                    _interfaceParenting.Add(parentName, new());

                _interfaceParenting[parentName].Add((typeName, false, _namespace));
            }

            private void CheckBases((string, bool, string) typeName, BaseListSyntax bases)
            {
                foreach (BaseTypeSyntax baseType in bases.Types)
                {
                    string type = baseType.Type.ToString();
                    bool found = false;

                    int i = 0;
                    foreach (var BaseType in _baseTypes)
                    {
                        if (BaseType.Key == type)
                        {
                            COMTypeValidated(
                                typeName.Item1,
                                (typeName.Item2, InheritanceTrees[i]),
                                BaseType.Key,
                                typeName.Item3
                            );
                            found = true;
                            break;
                        }
                    }

                    if (found)
                        break;

                    if (FoundCOMTypes.TryGetValue(type, out var val))
                    {
                        COMTypeValidated(
                            typeName.Item1,
                            (typeName.Item2, val.Item2),
                            type,
                            typeName.Item3
                        );
                        break;
                    }
                }

                foreach (BaseTypeSyntax baseType in bases.Types)
                {
                    string fullName = $"{baseType.Type}";
                    if (!_interfaceParenting.ContainsKey(fullName))
                        _interfaceParenting.Add(fullName, new());

                    _interfaceParenting[fullName].Add(typeName);
                }
            }

            private void COMTypeValidated(
                string typeName,
                (bool, KeyedStringTree?) value,
                string parentName,
                string _namespace
            )
            {
                if (FoundCOMTypes.ContainsKey(typeName))
                {
                    return;
                }

                FoundCOMTypes.Add(typeName, value);

                if (_namespace is null)
                {
                    _namespace = string.Join('.', _Namespace);
                }

                if (
                    !value.Item2?.TryAddNode(parentName, typeName, $"{_namespace}.{typeName}")
                    ?? true
                )
                {
                    _logger.LogWarning(
                        "Failed to add {} to its Inheritence tree, casts will not generate properly",
                        typeName
                    );
                }

                if (
                    !_interfaceParenting.TryGetValue(
                        typeName,
                        out List<(string, bool, string)>? children
                    )
                )
                    return;

                foreach ((string, bool, string) childName in children)
                {
                    COMTypeValidated(
                        childName.Item1,
                        (childName.Item2, value.Item2),
                        typeName,
                        childName.Item3
                    );
                }
            }
        }

        class Rewriter(Dictionary<string, (bool, KeyedStringTree?)> ComTypes) : CSharpSyntaxRewriter
        {
            bool isInCom = false;
            bool disposeFound = false;
            List<MethodDeclarationSyntax> addedMethods = [];

            public override SyntaxNode? VisitStructDeclaration(StructDeclarationSyntax node)
            {
                string name = node.Identifier.ToString();
                List<MethodDeclarationSyntax> parentMethods = addedMethods;
                addedMethods = addedMethods.Count > 0 ? [] : addedMethods;

                if (
                    ComTypes.TryGetValue(name, out var Value)
                    && Value.Item2 is not null
                    && Value.Item2.FindNode(name, out KeyedStringTree.Node? treeNode)
                    && treeNode.Parent is not null
                )
                {
                    bool parentIsCom = isInCom;
                    bool parentDispose = disposeFound;
                    isInCom = true;
                    disposeFound = false;
                    //visit and modify ComType Variables and internal usages first
                    node = (base.VisitStructDeclaration(node) as StructDeclarationSyntax)!;
                    node = node.RemoveNodes(
                                node.BaseList?.Types.Where(bas =>
                                    bas.Type.ToString() == "INativeGuid"
                                ) ?? [],
                                SyntaxRemoveOptions.KeepNoTrivia
                            )!
                        .AddBaseListTypes(SimpleBaseType(ParseTypeName("IDisposable")))
                        .AddMembers(addedMethods.ToArray());

                    if (!disposeFound)
                    {
                        node = node.AddMembers(
                                MethodDeclaration(ParseTypeName("void"), "Dispose")
                                    .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                                    .WithExpressionBody(
                                        ArrowExpressionClause(
                                            InvocationExpression(IdentifierName("Release"))
                                        )
                                    )
                                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                            )
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
                                                                            "IDisposable.Dispose"
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
                            );
                    }

                    //Correct to the .Interface version which will always be our parent
                    treeNode = treeNode.Parent;

                    if (treeNode.Parent is not null)
                    {
                        node = generateUpcasts(node, name, treeNode.Parent);
                    }

                    isInCom = parentIsCom;
                    disposeFound = parentDispose;
                }
                else
                {
                    node = (base.VisitStructDeclaration(node) as StructDeclarationSyntax)!;
                    node = node.AddMembers(addedMethods.ToArray());
                }

                addedMethods.Clear();
                addedMethods = parentMethods;
                return node;
            }

            public override SyntaxNode? VisitSimpleBaseType(SimpleBaseTypeSyntax node)
            {
                return isInCom && node.Type.ToString() == "INativeInterface"
                    ? SimpleBaseType(ParseTypeName("IComInterface"))
                    : base.VisitSimpleBaseType(node);
            }

            public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node)
            {
                if (
                    isInCom
                    && node.Identifier.Text == "Dispose"
                    && node.ParameterList.Parameters.Count == 0
                )
                {
                    if (node.ExpressionBody is not null)
                    {
                        node = node.WithBody(
                                Block(
                                    ExpressionStatement(node.ExpressionBody.Expression),
                                    ExpressionStatement(
                                        InvocationExpression(IdentifierName("Release"))
                                    )
                                )
                            )
                            .WithExpressionBody(null);
                    }
                    else if (node.Body is not null)
                    {
                        node = node.WithBody(
                            Block(
                                node.Body.Statements.Append(
                                    ExpressionStatement(
                                        InvocationExpression(IdentifierName("Release"))
                                    )
                                )
                            )
                        );
                    }

                    node = node.WithLeadingTrivia(
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
                                                                    "IDisposable.Dispose"
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
                    );
                }
                else if (node.Modifiers.Any(mod => mod.IsKind(SyntaxKind.PublicKeyword)))
                {
                    int guidPtrIndex = -1;
                    int voidPtrIndex = -1;

                    List<ParameterSyntax> paramList = [];
                    List<ArgumentSyntax> argList = [];
                    AssignmentExpressionSyntax? assignment = null;

                    for (var i = 0; i < node.ParameterList.Parameters.Count; i++)
                    {
                        var param = node.ParameterList.Parameters[i];

                        if (voidPtrIndex == -1)
                        {
                            if (param.Type?.ToString() == "Guid*")
                            {
                                guidPtrIndex = i;
                            }
                            else if (guidPtrIndex != -1 && param.Type?.ToString() == "void**")
                            {
                                voidPtrIndex = i;

                                paramList.RemoveAt(guidPtrIndex);
                                argList[guidPtrIndex] = Argument(
                                    MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        IdentifierName("TCom"),
                                        IdentifierName("NativeGuid")
                                    )
                                );

                                paramList.Add(
                                    Parameter(
                                            param.AttributeLists,
                                            param.Modifiers,
                                            ParseTypeName("TCom"),
                                            param.Identifier,
                                            null
                                        )
                                        .AddModifiers(Token(SyntaxKind.OutKeyword))
                                );
                                argList.Add(
                                    Argument(
                                        InvocationExpression(
                                            MemberAccessExpression(
                                                SyntaxKind.SimpleMemberAccessExpression,
                                                IdentifierName(param.Identifier),
                                                IdentifierName("GetAddressOf")
                                            )
                                        )
                                    )
                                );
                                assignment = AssignmentExpression(
                                    SyntaxKind.SimpleAssignmentExpression,
                                    IdentifierName(param.Identifier),
                                    LiteralExpression(SyntaxKind.DefaultLiteralExpression)
                                );
                                continue;
                            }
                        }
                        argList.Add(Argument(IdentifierName(param.Identifier.Text)));
                        paramList.Add(param);
                    }

                    if (assignment is not null)
                    {
                        addedMethods.Add(
                            node.AddTypeParameterListParameters(TypeParameter("TCom"))
                                .AddConstraintClauses(
                                    TypeParameterConstraintClause(
                                        IdentifierName("TCom"),
                                        SeparatedList<TypeParameterConstraintSyntax>(
                                            [
                                                TypeConstraint(IdentifierName("unmanaged")),
                                                TypeConstraint(IdentifierName("IComInterface")),
                                            ]
                                        )
                                    )
                                )
                                .WithParameterList(ParameterList(SeparatedList(paramList)))
                                .WithExpressionBody(null)
                                .WithSemicolonToken(Token(SyntaxKind.None))
                                .WithBody(
                                    Block(
                                        ExpressionStatement(assignment),
                                        ReturnStatement(
                                            InvocationExpression(
                                                IdentifierName(node.Identifier),
                                                ArgumentList(SeparatedList(argList))
                                            )
                                        )
                                    )
                                )
                        );
                    }
                }

                return base.VisitMethodDeclaration(node);
            }

            private StructDeclarationSyntax generateUpcasts(
                StructDeclarationSyntax node,
                string className,
                KeyedStringTree.Node treeNode
            )
            {
                string castName = InterfaceNameToStructName(treeNode.Value);

                node = node.AddMembers(GenerateCastDefinition(className, castName, false));
                node = node.AddMembers(GenerateCastDefinition(castName, className));

                if (treeNode.Parent is not null)
                {
                    return generateUpcasts(node, className, treeNode.Parent);
                }

                return node;
            }

            private string InterfaceNameToStructName(string interfaceName) =>
                interfaceName.EndsWith(".Native.Interface")
                    ? interfaceName.Remove(interfaceName.Length - 17)
                    : interfaceName;

            private ConversionOperatorDeclarationSyntax GenerateCastDefinition(
                string className,
                string castName,
                bool implicitCast = true
            )
            {
                return ConversionOperatorDeclaration(
                        Token(
                            implicitCast ? SyntaxKind.ImplicitKeyword : SyntaxKind.ExplicitKeyword
                        ),
                        ParseTypeName(className)
                    )
                    .WithModifiers(
                        TokenList(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.StaticKeyword))
                    )
                    .WithParameterList(
                        ParameterList(
                            SingletonSeparatedList(
                                Parameter(Identifier("value")).WithType(ParseTypeName(castName))
                            )
                        )
                    )
                    .WithExpressionBody(
                        ArrowExpressionClause(
                            ObjectCreationExpression(IdentifierName(className))
                                .WithArgumentList(
                                    ArgumentList(
                                        SingletonSeparatedList(
                                            Argument(
                                                CastExpression(
                                                    ParseTypeName($"Ptr<{className}.Native>")
                                                    ,
                                                    IdentifierName("value.lpVtbl")
                                                )
                                            )
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
                                                            XmlText(
                                                                $"{(implicitCast ? "Up" : "Down")}casts "
                                                            ),
                                                            XmlEmptyElement(
                                                                XmlName("see"),
                                                                List<XmlAttributeSyntax>(
                                                                    new[]
                                                                    {
                                                                        XmlCrefAttribute(
                                                                            NameMemberCref(
                                                                                IdentifierName(
                                                                                    castName
                                                                                )
                                                                            )
                                                                        ),
                                                                    }
                                                                )
                                                            ),
                                                            XmlText(" to "),
                                                            XmlEmptyElement(
                                                                XmlName("see"),
                                                                List<XmlAttributeSyntax>(
                                                                    new[]
                                                                    {
                                                                        XmlCrefAttribute(
                                                                            NameMemberCref(
                                                                                IdentifierName(
                                                                                    className
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
                                                            XmlEmptyElement(
                                                                XmlName("see"),
                                                                List<XmlAttributeSyntax>(
                                                                    new[]
                                                                    {
                                                                        XmlCrefAttribute(
                                                                            NameMemberCref(
                                                                                IdentifierName(
                                                                                    castName
                                                                                )
                                                                            )
                                                                        ),
                                                                    }
                                                                )
                                                            ),
                                                            XmlText(" instance to be converted "),
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
                    );
            }
        }
    }
}
