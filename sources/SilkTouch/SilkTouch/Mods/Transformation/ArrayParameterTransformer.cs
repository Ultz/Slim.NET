// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Buffers;
using System.Diagnostics;
using System.Linq;
using Humanizer;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Mods.Metadata;
using Silk.NET.SilkTouch.Naming;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods.Transformation;

/// <summary>
/// Transforms functions with exactly one pointer parameter with an element count determined from another parameter.
/// </summary>
public class ArrayParameterTransformer(IOptionsSnapshot<TransformFunctions.Configuration>? options)
    : IFunctionTransformer
{
    /// <inheritdoc />
    public MethodDeclarationSyntax Transform(
        MethodDeclarationSyntax decl,
        bool isInInterface,
        ITransformationContext ctx,
        Func<MethodDeclarationSyntax, bool, MethodDeclarationSyntax> next
    )
    {
        // Ported from https://github.com/dotnet/Silk.NET/blob/0e8e0398/src/Core/Silk.NET.BuildTools/Overloading/Complex/ArrayParameterOverloader.cs#L32
        // Modified heavily to use count metadata instead of function signature styles. This allowed us to also coalesce
        // the ReturnTypeOverloader and NonKhrReturnTypeOverloader into this single transformer.

        var cfg = options?.Get(ctx.JobKey);

        // Keep the original in the loop:
        decl = next(decl, isInInterface);

        if (ctx.Transformers is null)
        {
            return decl;
        }

        decl.AttributeLists.GetNativeFunctionInfo(out _, out var entryPoint, out _);
        entryPoint ??= decl.Identifier.ToString();

        // is void or HRESULT return
        var isHr = false;
        if (
            // If it is a IdentifierNameSyntax, it must be a HRESULT wrapper struct.
            !(
                isHr =
                    decl.ReturnType is IdentifierNameSyntax iden
                    && iden.Identifier.ToString().ToUpper() is "HRESULT"
            )
            // Otherwise, it must be a PredefinedTypeSyntax representing either void or a HRESULT as an integer.
            && (
                decl.ReturnType is not PredefinedTypeSyntax pt
                || (
                    // Return if it is not a void return...
                    !pt.Keyword.IsKind(SyntaxKind.VoidKeyword)
                    // ...and if it is also not a HRESULT wrapper struct.
                    && !(
                        isHr =
                            pt.Keyword.IsKind(SyntaxKind.IntKeyword)
                            && decl.GetNativeReturnTypeName() is "HRESULT"
                    )
                )
            )
        )
        {
            return decl;
        }

        // has a single pointer parameter that has either:
        // - a parameter-based count
        // - a count of 1
        // Let's evaluate the first option first.
        var ((countParam, _, ((ptrParam, _, ptrCount), _)), countParamNo) =
            // 1. Get all count parameters
            decl.EnumerateCountParameterInfo(
                    ctx.Transformers.OfType<IApiMetadataProvider<SymbolConstraints>>(),
                    entryPoint,
                    ctx.JobKey
                )
                .Select(x =>
                    (
                        x.CountParam,
                        x.CountParamIdx,
                        // 2. Select only the last parameter this count parameter is associated with
                        ParamForCount: x.ParamsForCount.Select(
                                (y, j) => (PtrParamInfo: y, ParamForCountIdx: j)
                            )
                            .LastOrDefault()
                    )
                )
                .Where(x =>
                    // 3. Only select this count parameter if the associated parameter was the only associated parameter
                    // (as indicated by the 0 index)
                    x
                        is {
                            ParamForCount: { PtrParamInfo.PtrParam: not null, ParamForCountIdx: 0 }
                        }
                )
                // 4. Only select the last count parameter
                .Select((x, i) => (CountParamInfo: x, CountParamInfoIdx: i))
                .LastOrDefault();

        // If there is no parameter-based count, let's look for a maximum of 1 parameter with a count of 1.
        if (countParam is null)
        {
            ((ptrParam, _, ptrCount), countParamNo) = decl.EnumerateSymbolConstraints(
                    ctx.Transformers.OfType<IApiMetadataProvider<SymbolConstraints>>(),
                    entryPoint,
                    ctx.JobKey
                )
                .Where(x => x.ParamConstraints?.CommonUsage?.StaticCount == 1)
                .Select((x, i) => (x, i))
                .LastOrDefault();
        }

        if (ptrCount?.CommonUsage is { IsIn: true, IsOut: true } or { IsCountBytes: true })
        {
            // Flow isn't compatible with either of our signatures.
            return decl;
        }

        // Get information from the function name for benefit-of-doubt overloading i.e. if the function matches a very
        // well-known function style then let's just go ahead and overload it. (Mainly for OpenAL)
        var epSpan = entryPoint.AsSpan();
        var verb = epSpan[int.Max(epSpan.IndexOfAny(NameUtils.Uppercase), 0)..];
        verb = verb[..(verb[1..].IndexOfAny(NameUtils.Uppercase) + 1)];
        var benefitOfDoubt = false;
        if (
            (cfg?.BenefitOfTheDoubtArrayTransformation ?? false)
            && countParam is null
            && ptrParam is null
            && verb is "Get" or "Gen" or "Create" or "New" or "Delete"
            && decl.ParameterList.Parameters.Count == 2 // Type checking is done in the next if.
        )
        {
            countParam = decl.ParameterList.Parameters[0];
            ptrParam = decl.ParameterList.Parameters[1];
            countParamNo = 0;
            benefitOfDoubt = true;
        }

        // If the flow is indeterminate, determine the flow from the native mutability.
        var ptrCommonUsage = ptrCount?.CommonUsage;
        benefitOfDoubt |= ptrCommonUsage is { IsIndeterminateFlow: true };

        // 5. If there was no count parameter or this was not the only count parameter that met our criteria, skip.
        if (
            ptrParam is null
            || (!benefitOfDoubt && ptrCount is not { ElementTypeConstraints: not null }) // we have element count info
            || countParamNo != 0 // there is more than one parameter that met our criteria
            || !((countParam?.Type?.IsInteger() ?? false) || ptrCommonUsage?.StaticCount == 1) // we must have an integral count parameter or the pointer parameter must have a count of 1
            || ptrParam.Type?.GetPointerLikeElementType() is not { } element // must be a pointer
            || (
                element is PredefinedTypeSyntax ptrept
                && ptrept.Keyword.IsKind(SyntaxKind.VoidKeyword)
            ) // the pointer must not be a void pointer
        )
        {
            return decl;
        }

        // Get the type information to verify that the usage constraints match the type info (if applicable, if not
        // applicable then we'll likely fall back on the type info if we're giving the signature the benefit of the
        // doubt in lieu of proper constraint info)
        if (ptrParam.GetNativeTypeName() is not { } nativeType)
        {
            return decl;
        }

        Span<bool> mutability = stackalloc bool[nativeType.AsSpan().GetIndirectionLevels() + 1];
        nativeType.AsSpan().GetTypeDetails(mutability, out var arrayCount);
        var hasValidAndConsistentCount = arrayCount is 0 or 1
            ? countParam is not null || ptrCommonUsage?.StaticCount is not (null or 0)
            : countParam is null
                && (ptrCommonUsage?.StaticCount is not { } v || v == 0 || v == arrayCount);
        if (
            // If array count is specified but we have a count param or constant count -or-
            // array count is not specified but we don't have a count parameter or a constant count
            !hasValidAndConsistentCount
            // the native type is not a pointer
            || mutability.Length < 2
            // the array count, if applicable, is contrary to the metadata-recevied count
            || (ptrCommonUsage?.StaticCount is { } sc && arrayCount is not 0 && sc != arrayCount)
            || (
                // there is a discrepancy between the count and the type info
                !benefitOfDoubt
                && (
                    ptrCommonUsage is not { } cu
                    || cu.IsIn != !mutability[1]
                    || cu.IsOut != mutability[1]
                    || ptrCount!.IsMutable != mutability[1]
                )
            )
        )
        {
            // Discrepancy between the type signature and recorded count.
            return decl;
        }

        // Determine whether this is an outputting function. If it is, we need to transform the method to have the
        // return type be the pointee type and eliminate both the count param (if applicable) and the pointer param.
        // Otherwise, we only eliminate the count
        var isOutput = ptrCommonUsage?.IsOut ?? ptrCount?.ElementTypeConstraints?.IsMutable;
        if (isOutput is null || benefitOfDoubt) // (benefit of doubt)
        {
            Debug.Assert(benefitOfDoubt); // former case
            isOutput = mutability[1];
        }

        // rewrite the method
        var rw = new TransformArrayParameterRewriter(
            countParam?.Identifier.ToString(),
            ptrParam.Identifier.ToString(),
            ptrParam.Type,
            element,
            isOutput.Value,
            isHr
        );
        return next(rw.Visit(decl) as MethodDeclarationSyntax ?? decl, isInInterface);
    }

    class TransformArrayParameterRewriter(
        string? countParam,
        string ptrParam,
        TypeSyntax ptrParamType,
        TypeSyntax ptrElementType,
        bool isOutput,
        bool isHr
    ) : CSharpSyntaxRewriter
    {
        public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node) =>
            node.WithIdentifier(Identifier(node.Identifier.ToString().Singularize(false)))
                .WithReturnType(
                    isOutput ? ptrElementType : PredefinedType(Token(SyntaxKind.VoidKeyword))
                )
                .WithBody(
                    // Rewrite the inner usages of the parameters, see the below Visit methods.
                    Visit(
                        // Convert expression bodies to blocks
                        node.Body
                            ?? (
                                node.ExpressionBody?.Expression is { } exp
                                    ? Block(isHr ? ReturnStatement(exp) : ExpressionStatement(exp))
                                    : null
                            )
                    )
                        is BlockSyntax blk
                        ? isOutput
                            // If it's an output we need to create the output variable and return it after doing the inner
                            // call.
                            ? Block(
                                (StatementSyntax[])
                                    [
                                        LocalDeclarationStatement(
                                            VariableDeclaration(
                                                ptrElementType,
                                                SingletonSeparatedList(
                                                    VariableDeclarator(ptrParam)
                                                        .WithInitializer(
                                                            EqualsValueClause(
                                                                LiteralExpression(
                                                                    SyntaxKind.DefaultLiteralExpression
                                                                )
                                                            )
                                                        )
                                                )
                                            )
                                        ),
                                        .. blk.Statements,
                                        ReturnStatement(IdentifierName(ptrParam)),
                                    ]
                            )
                            : blk
                        : null
                )
                .WithExpressionBody(null) // <-- converted to block, may be converted back later by FunctionTransformer.
                .WithSemicolonToken(default)
                .WithParameterList(
                    Visit(node.ParameterList) as ParameterListSyntax ?? ParameterList()
                );

        public override SyntaxNode VisitReturnStatement(ReturnStatementSyntax node) =>
            ExpressionStatement(
                InvocationExpression(
                    MemberAccessExpression(
                        SyntaxKind.SimpleMemberAccessExpression,
                        IdentifierName("SilkMarshal"),
                        IdentifierName("ThrowHResult")
                    ),
                    ArgumentList(
                        SingletonSeparatedList(
                            Argument(
                                node.Expression
                                    ?? throw new InvalidOperationException(
                                        "Return statement with no expression."
                                    )
                            )
                        )
                    )
                )
            );

        public override SyntaxNode? VisitParameterList(ParameterListSyntax node) =>
            base.VisitParameterList(node) is ParameterListSyntax syn
                ? syn.WithParameters(
                    SeparatedList(
                        syn.Parameters.Select(x =>
                                x.Identifier.ToString() == countParam
                                || (isOutput && x.Identifier.ToString() == ptrParam)
                                    ? null
                                : base.VisitParameter(x) is ParameterSyntax p
                                    ? p.Identifier.ToString() == ptrParam
                                            ? p.WithType(ptrElementType)
                                        : p
                                : null
                            )
                            .OfType<ParameterSyntax>()
                    )
                )
                : null;

        public override SyntaxNode? VisitIdentifierName(IdentifierNameSyntax node) =>
            node.Identifier.ToString() == ptrParam
                ? ptrParamType is GenericNameSyntax gn && gn.Identifier.ToString().StartsWith("Ref")
                    ? InvocationExpression(
                        MemberAccessExpression(
                            SyntaxKind.SimpleMemberAccessExpression,
                            node,
                            IdentifierName($"As{gn.Identifier}")
                        )
                    )
                    : CastExpression(
                        ptrParamType,
                        PrefixUnaryExpression(SyntaxKind.AddressOfExpression, node)
                    )
                : node.Identifier.ToString() == countParam
                    ? LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(1))
                    : base.VisitIdentifierName(node);
    }
}
