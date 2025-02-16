using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods.Transformation;

/// <summary>
/// A transformer that converts between raw pointers and Silk DSL pointer types.
/// </summary>
public sealed partial class PtrRefTransformer()
    : ModCSharpSyntaxRewriter(true),
        IFunctionTransformer
{
    private const int MaxIndirections = 3;
    private ThreadLocal<ITransformationContext?> _ctx = new();
    private bool isInInterface = false;

    /// <inheritdoc />
    public MethodDeclarationSyntax Transform(
        MethodDeclarationSyntax current,
        bool isInInterface,
        ITransformationContext ctx,
        Func<MethodDeclarationSyntax, bool, MethodDeclarationSyntax> next
    )
    {
        this.isInInterface = isInInterface;
        _ctx.Value = ctx;
        MethodDeclarationSyntax ret;
        if (Visit(current) is MethodDeclarationSyntax modded)
        {
            ret = next(modded, isInInterface);
        }
        else
        {
            ret = next(current, isInInterface);
        }

        _ctx.Value = null;
        isInInterface = false;
        return ret;
    }

    private static bool ShouldConvertToDSL(TypeSyntax syn) =>
        syn is PointerTypeSyntax ptr && DoesNotContainIllegalGeneric(ptr);

    private static bool DoesNotContainIllegalGeneric(PointerTypeSyntax syn) =>
        syn.ElementType is not FunctionPointerTypeSyntax
        && (syn.ElementType is not PointerTypeSyntax el || DoesNotContainIllegalGeneric(el));

    private static bool ShouldConvertFromDSL(TypeSyntax syn)
    {
        var ident = syn.DescendantNodes()
            .OfType<IdentifierNameSyntax>()
            .FirstOrDefault()
            ?.Identifier.ToString();
        for (var i = MaxIndirections; ident is not null && i > 0; i--)
        {
            if (
                (i == 1 && ident is "Ptr" or "Ref")
                || (i != 1 && (ident == $"Ptr{i}D" || ident == $"Ref{i}D"))
            )
            {
                return true;
            }
        }

        return false;
    }

    private static TypeSyntax GetDSLType(
        TypeSyntax syntax,
        IEnumerable<AttributeListSyntax?>? attrLists,
        SyntaxKind? target
    )
    {
        var indirectionLevels = 0;
        var isVoid = false;
        while (syntax is PointerTypeSyntax inner)
        {
            indirectionLevels++;
            syntax = inner.ElementType;
        }

        if (syntax is PredefinedTypeSyntax lang && lang.Keyword.IsKind(SyntaxKind.VoidKeyword))
        {
            isVoid = true;
        }

        if (indirectionLevels > 3)
        {
            throw new ArgumentOutOfRangeException(
                nameof(syntax),
                "Indirection levels greater than 3 are currently unsupported by SilkDSL."
            );
        }

        var isOut =
            target == SyntaxKind.ReturnKeyword
            || (
                attrLists is not null
                && attrLists.Any(a =>
                    a is not null && a.Attributes.Any(attr => attr.Name.ToString() == "Out")
                )
            );

        return isVoid
            ? IdentifierName(
                isOut switch
                {
                    true => indirectionLevels > 1 ? $"Ptr{indirectionLevels}D" : "Ptr",
                    false => indirectionLevels > 1 ? $"Ref{indirectionLevels}D" : "Ref",
                }
            )
            : GenericName(
                    Identifier(
                        isOut switch
                        {
                            true => indirectionLevels > 1 ? $"Ptr{indirectionLevels}D" : "Ptr",
                            false => indirectionLevels > 1 ? $"Ref{indirectionLevels}D" : "Ref",
                        }
                    )
                )
                .WithTypeArgumentList(TypeArgumentList(SingletonSeparatedList(syntax)));
    }

    private Dictionary<string, bool>? _parameterIdentifiers;
    private bool _returnTypeReplaceable;

    /// <inheritdoc />
    public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node)
    {
        Debug.Assert(!_returnTypeReplaceable);
        Debug.Assert(_parameterIdentifiers is null);

        // Get the list of DSL applicable parameters
        var paramsToChange = node
            .ParameterList.Parameters.Where(x =>
                x.Type is not null && (ShouldConvertToDSL(x.Type) || ShouldConvertFromDSL(x.Type))
            )
            .ToArray();
        _parameterIdentifiers = paramsToChange.ToDictionary(
            x => x.Identifier.ToString(),
            x => ShouldConvertToDSL(x.Type!)
        );
        _returnTypeReplaceable =
            ShouldConvertFromDSL(node.ReturnType) || ShouldConvertToDSL(node.ReturnType);

        // VisitParameter and VisitIdentifierName will change the parameter types and replace any references of
        // the parameter with the "inner identifier" - the name of the variable yielded from the fixed statement
        // that we're yet to generate.
        if (
            base.VisitMethodDeclaration(node)
            is not MethodDeclarationSyntax methWithReplacementsButNoFixed
        )
        {
            _parameterIdentifiers = null;
            return null;
        }

        // If we didn't do any replacements and aren't doing anything to the return type, don't do anything
        if (paramsToChange.Length == 0 && !_returnTypeReplaceable)
        {
            _parameterIdentifiers = null;
            return methWithReplacementsButNoFixed;
        }

        // Defensive check, the transformer should always make the initial body for us.
        var body = methWithReplacementsButNoFixed.Body;
        if (body is null && !isInInterface)
        {
            _parameterIdentifiers = null;
            return node;
        }

        // Remove the extern keyword from the outer method
        methWithReplacementsButNoFixed = methWithReplacementsButNoFixed
            .WithModifiers(
                TokenList(
                    methWithReplacementsButNoFixed.Modifiers.Where(x =>
                        !x.IsKind(SyntaxKind.ExternKeyword)
                    )
                )
            )
            .WithAttributeLists(
                List(
                    methWithReplacementsButNoFixed
                        .AttributeLists.Select(x =>
                            x.WithAttributes(
                                SeparatedList(
                                    x.Attributes.Where(y =>
                                        !y.IsAttribute(
                                            "System.Runtime.InteropServices.UnmanagedCallersOnly"
                                        )
                                    )
                                )
                            )
                        )
                        .Where(x => x.Attributes.Count > 0)
                )
            )
            .AddMaxOpt();
        _ctx.Value?.AddUsing("System.Runtime.CompilerServices");

        // Need to check on the return type, but assume that there's an implicit conversion in the DSL
        if (_returnTypeReplaceable)
        {
            _returnTypeReplaceable = false;
            methWithReplacementsButNoFixed = methWithReplacementsButNoFixed.WithReturnType(
                GetDSLType(node.ReturnType, node.AttributeLists, SyntaxKind.ReturnKeyword)
            );
        }

        if (isInInterface)
        {
            _parameterIdentifiers = null;
            return methWithReplacementsButNoFixed;
        }

        // Generate the fixed blocks for the "inner idents"
        foreach (var param in paramsToChange)
        {
            Debug.Assert(param.Type is not null);

            // We don't need to do anything when we're converting back to a raw function from a DSL one as DSL types
            // implicitly cast to their pointer types.
            if (!_parameterIdentifiers[param.Identifier.ToString()])
            {
                continue;
            }

            body = body!.WithStatements(
                SingletonList<StatementSyntax>(
                    body.Statements.AddFixed(s =>
                        FixedStatement(
                            VariableDeclaration(
                                param.Type,
                                SingletonSeparatedList(
                                    VariableDeclarator(IdentToInnerIdent(param.Identifier))
                                        .WithInitializer(
                                            EqualsValueClause(IdentifierName(param.Identifier))
                                        )
                                )
                            ),
                            s
                        )
                    )
                )
            );
        }

        _parameterIdentifiers = null;

        return methWithReplacementsButNoFixed.WithBody(body);
    }

    /// <inheritdoc />
    public override SyntaxNode? VisitParameter(ParameterSyntax node)
    {
        var ret = base.VisitParameter(node) as ParameterSyntax;

        // In release builds don't do the _parameterIdentifiers lookup because we do this in the VisitIdentifierName
        if (
            (_parameterIdentifiers?.TryGetValue(node.Identifier.ToString(), out var toDsl) ?? false)
            && ret is { Type: not null }
        )
        {
            // Are we converting *to* a DSL type?
            if (toDsl)
            {
                return ret.WithType(GetDSLType(ret.Type, node.AttributeLists, null))
                    .WithDefault(
                        node.Default is not null && node.Default.Value.ToString() == "null"
                            ? EqualsValueClause(
                                LiteralExpression(SyntaxKind.DefaultLiteralExpression)
                            )
                            : node.Default
                    );
            }

            // Are we converting *from* a DSL type?
            if (
                ret.Type
                    is GenericNameSyntax { TypeArgumentList.Arguments.Count: 1 }
                        or IdentifierNameSyntax
                && DslName().Match(((SimpleNameSyntax)ret.Type).Identifier.ToString())
                    is { Success: true, Groups: var g }
            )
            {
                var ty =
                    (ret.Type as GenericNameSyntax)?.TypeArgumentList.Arguments[0]
                    ?? PredefinedType(Token(SyntaxKind.VoidKeyword));
                var i = 0;
                var il = g.Count > 2 ? g[2].Value : null;
                do
                {
                    ty = PointerType(ty);
                } while (
                    --i > 1
                    || (
                        i == 0 && !string.IsNullOrWhiteSpace(il) && int.TryParse(il, out i) && i > 1
                    )
                );

                return ret.WithType(ty);
            }
        }

        return ret;
    }

    [GeneratedRegex("^(Ptr|Ref)(([0-9]*)D)?$")]
    private partial Regex DslName();

    /// <inheritdoc />
    public override SyntaxNode? VisitIdentifierName(IdentifierNameSyntax node)
    {
        var ret = base.VisitIdentifierName(node) as IdentifierNameSyntax;
        if (ret is null || ret.Parent is InvocationExpressionSyntax)
        {
            return ret;
        }

        if (
            !(
                (
                    _parameterIdentifiers?.TryGetValue(node.Identifier.ToString(), out var fix)
                    ?? false
                ) && fix
            )
        )
        {
            return ret;
        }

        return IdentifierName(IdentToInnerIdent(ret.Identifier)).WithTriviaFrom(ret);
    }

    /// <inheritdoc />
    public override SyntaxNode? VisitAttribute(AttributeSyntax node)
    {
        if ((_parameterIdentifiers?.Count).GetValueOrDefault() == 0 && !_returnTypeReplaceable)
        {
            return base.VisitAttribute(node);
        }

        return node.IsAttribute("System.Runtime.InteropServices.DllImport")
            ? null // Remove the attribute as it is being moved to a local function
            : base.VisitAttribute(node);
    }

    /// <inheritdoc />
    public override SyntaxNode? VisitAttributeList(AttributeListSyntax node)
    {
        var ret = base.VisitAttributeList(node) as AttributeListSyntax;
        if (ret is not null && ret.Attributes.Count == 0)
        {
            return null;
        }

        return ret;
    }

    private static SyntaxToken IdentToInnerIdent(SyntaxToken token)
    {
        Debug.Assert(token.IsKind(SyntaxKind.IdentifierToken));
        return Identifier($"__dsl_{token.ToString().TrimStart('@')}");
    }
}
