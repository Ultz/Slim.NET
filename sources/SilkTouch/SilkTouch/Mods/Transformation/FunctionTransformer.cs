using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.FindSymbols;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Utility;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods.Transformation;

/// <summary>
/// Contains utilities for actioning <see cref="IFunctionTransformer"/>s.
/// </summary>
/// <param name="transformers">The function transformers.</param>
/// <param name="logger">The logger.</param>
public class FunctionTransformer(
    IEnumerable<IJobDependency<IFunctionTransformer>> transformers,
    ILogger<FunctionTransformer> logger
)
{
    /// <summary>
    /// Transforms all of the given functions, optionally including the original function signatures in the returned
    /// transformed functions.
    /// </summary>
    /// <param name="key">The job key.</param>
    /// <param name="functions">The functions.</param>
    /// <param name="ctx">The wider context for this function transformation operation.</param>
    /// <param name="typeName">Name of containing type</param>
    /// <param name="toRename">list of symbols to rename</param>
    /// <param name="includeOriginal">
    /// Whether to include the original function in the outputs before the transformed ones.
    /// </param>
    /// <returns>The transformed (and optionally original) functions.</returns>
    public IEnumerable<MethodDeclarationSyntax> GetTransformedFunctions(
        string? key,
        string typeName,
        Dictionary<string, string> toRename,
        IEnumerable<MethodDeclarationSyntax> functions,
        ITransformationContext ctx,
        bool includeOriginal = true
    )
    {
        var ret = functions is IReadOnlyCollection<MethodDeclarationSyntax> coll
            ? new List<MethodDeclarationSyntax>(coll.Count)
            : [];
        var discrims = new HashSet<string>();

        // Aggregate all the transformers into one delegate
        ctx.Transformers = transformers.SelectMany(x => x.Get(key)).ToArray();
        var transform = ctx.Transformers.Aggregate<
            IFunctionTransformer,
            Func<MethodDeclarationSyntax, bool, MethodDeclarationSyntax>
        >(
            (meth, isInInterface) =>
            {
                // Get the discriminator string to determine whether it conflicts. Note that we set the return type
                // to null as overloads that differ only by return type aren't acceptable. However, we do need a
                // discriminator that does include the return type so we can determine whether the function has gone
                // through the transformation pipeline completely unmodified.
                var discrim = ModUtils.DiscrimStr(
                    meth.Modifiers,
                    meth.TypeParameterList,
                    meth.Identifier.ToString(),
                    meth.ParameterList,
                    returnType: null
                );
                var discrimWithRet = ModUtils.DiscrimStr(
                    meth.Modifiers,
                    meth.TypeParameterList,
                    meth.Identifier.ToString(),
                    meth.ParameterList,
                    meth.ReturnType
                );

                // Only add it if it's an overload that does not conflict.
                if (discrims.Add(discrimWithRet) && discrims.Add(discrim))
                {
                    if (isInInterface)
                    {
                        meth = meth.WithBody(null)
                            .WithExpressionBody(null)
                            .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
                    }
                    // Small fixup to convert to use expression bodies where possible
                    else if (
                        meth.ExpressionBody is null
                        && meth.Body?.Statements.Count == 1
                        && (
                            (meth.Body.Statements[0] as ReturnStatementSyntax)?.Expression
                            ?? (
                                meth.ReturnType is PredefinedTypeSyntax pt
                                && pt.Keyword.IsKind(SyntaxKind.VoidKeyword)
                                    ? (
                                        meth.Body.Statements[0] as ExpressionStatementSyntax
                                    )?.Expression
                                    : null
                            )
                        )
                            is { } expr
                    )
                    {
                        meth = meth.WithBody(null)
                            .WithExpressionBody(ArrowExpressionClause(expr))
                            .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
                    }
                    ret.Add(meth);
                }

                return meth;
                // TODO else warn maybe?
            },
            (c, t) => ((meth, isInInterface) => t.Transform(meth, isInInterface, ctx, c))
        );
        foreach (var function in functions)
        {
            // We can't handle varargs right now
            if (
                function.ParameterList.Parameters.Any(x =>
                    x.Identifier.IsKind(SyntaxKind.ArgListKeyword)
                )
            )
            {
                logger.LogWarning(
                    "Varargs are not supported yet, excluding function: {}",
                    function
                        .WithBody(null)
                        .WithExpressionBody(null)
                        .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                        .NormalizeWhitespace(eol: "\n")
                        .ToFullString()
                );
                continue;
            }

            // Get the discriminator string to determine whether it conflicts. Note that we set the return type
            // to null as overloads that differ only by return type aren't acceptable. However, we do need a
            // discriminator that does include the return type so we can determine whether the function has gone
            // through the transformation pipeline completely unmodified.
            var discrim = ModUtils.DiscrimStr(
                function.Modifiers,
                function.TypeParameterList,
                function.Identifier.ToString(),
                function.ParameterList,
                returnType: null
            );
            var discrimWithRet = ModUtils.DiscrimStr(
                function.Modifiers,
                function.TypeParameterList,
                function.Identifier.ToString(),
                function.ParameterList,
                function.ReturnType
            );
            var idx = ret.Count;

            // Add the discriminator to the hash set to prevent unmodified functions from being output as transformed
            // ones. We might remove it later.
            if (!discrims.Add(discrimWithRet))
            {
                logger.LogWarning(
                    "Failed to add discriminator for original function \"{}\" because a previous transformed or original function conflicts with it. This may cause inconsistencies in outputs.",
                    discrim
                );
            }

            ctx.Original = function;
            MethodDeclarationSyntax? transformedFunc = TransformFunctions(function, transform);
            if (transformedFunc is not null && includeOriginal)
            {
                // Try to add the original function as-is
                if (discrims.Add(discrim))
                {
                    ret.Insert(
                        idx,
                        function.WithAttributeLists(
                            List(
                                function
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
                    );
                }
                else
                {
                    // Sometimes when functions are transformed they only differ by return type. C# doesn't allow
                    // this, so we add a suffix to the original function to differentiate them.
                    var newIden = $"{function.Identifier}Raw";

                    var transformedDiscrimWithRet =
                        typeName
                        + ":"
                        + ModUtils.DiscrimStr(
                            transformedFunc.Modifiers,
                            transformedFunc.TypeParameterList,
                            transformedFunc.Identifier.ToString(),
                            transformedFunc.ParameterList,
                            transformedFunc.ReturnType
                        );
                    toRename.Add(transformedDiscrimWithRet, newIden);

                    var rep = new Dictionary<string, string>
                    {
                        { function.Identifier.ToString(), newIden },
                    };

                    // Any reference to the original function needs to be replaced as well.
                    foreach (ref var added in CollectionsMarshal.AsSpan(ret)[idx..])
                    {
                        added = (MethodDeclarationSyntax)added.ReplaceIdentifiers(rep);
                    }

                    // Add the suffixed function
                    var newFun = function
                        .WithRenameSafeAttributeLists()
                        .WithIdentifier(Identifier(newIden))
                        .WithAttributeLists(
                            List(
                                function
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
                        );
                    discrim = ModUtils.DiscrimStr(
                        function.Modifiers,
                        function.TypeParameterList,
                        newIden,
                        function.ParameterList,
                        returnType: null
                    );
                    if (discrims.Add(discrim))
                    {
                        ret.Insert(idx, newFun);
                    }
                }
            }
            else if (transformedFunc is null)
            {
                ret.Add(function);
            }

            ctx.Original = null;
        }

        ctx.Transformers = null;
        return ret;
    }

    private MethodDeclarationSyntax? TransformFunctions(
        MethodDeclarationSyntax function,
        Func<MethodDeclarationSyntax, bool, MethodDeclarationSyntax> transform
    )
    {
        if (function.ExplicitInterfaceSpecifier is not null)
        {
            return null;
        }

        var declTy = function.FirstAncestorOrSelf<BaseTypeDeclarationSyntax>();

        bool isInInterface = declTy is InterfaceDeclarationSyntax;
        // The Silk DSL can be applied to static and non-static methods in a class or a struct.
        if (declTy is not (ClassDeclarationSyntax or StructDeclarationSyntax) && !isInInterface)
        {
            return null;
        }

        if (isInInterface)
        {
            transform(function, true);
            return function;
        }

        StatementSyntax impl = ExpressionStatement(
            InvocationExpression(
                IdentifierName(function.Identifier),
                ArgumentList(
                    SeparatedList(
                        function.ParameterList.Parameters.Select(x =>
                            Argument(
                                null,
                                x.Modifiers.Where(mod =>
                                        mod.IsKind(SyntaxKind.RefKeyword)
                                        || mod.IsKind(SyntaxKind.InKeyword)
                                        || mod.IsKind(SyntaxKind.OutKeyword)
                                    )
                                    .FirstOrDefault(),
                                IdentifierName(
                                    x.Identifier.Text == function.Identifier.Text
                                        ? $"_{x.Identifier.Text}"
                                        : x.Identifier.Text
                                )
                            )
                        )
                    )
                )
            )
        );

        if (function.ReturnType.ToString() != "void")
        {
            impl = ReturnStatement(
                CastExpression(function.ReturnType, ((ExpressionStatementSyntax)impl).Expression)
            );
        }

        // Fix for some malformed trivia
        var originalFunction = function;

        if (function.HasLeadingTrivia)
        {
            function = function.WithLeadingTrivia(
                function
                    .GetLeadingTrivia()
                    .Where(trivia =>
                        !trivia.IsKind(SyntaxKind.SingleLineDocumentationCommentTrivia)
                    )
                    .ToSyntaxTriviaList()
            );
        }

        function = function
            .WithBody(Block(impl))
            .WithAttributeLists(
                List(
                    function
                        .AttributeLists.Select(x =>
                            x.WithAttributes(
                                SeparatedList(
                                    x.Attributes.Where(y =>
                                        !y.IsAttribute("System.Runtime.InteropServices.DllImport")
                                        && !y.IsAttribute("Silk.NET.Core.NativeFunction")
                                        && !y.IsAttribute(
                                            "System.Runtime.CompilerServices.MethodImpl"
                                        )
                                    )
                                )
                            )
                        )
                        .Where(x => x.Attributes.Count > 0)
                        .Concat(
                            Enumerable.Repeat(
                                AttributeList(
                                    SingletonSeparatedList(Attribute(IdentifierName("Transformed")))
                                ),
                                1
                            )
                        )
                )
            )
            .AddNativeFunction(originalFunction)
            .WithExpressionBody(null)
            .WithSemicolonToken(default)
            .WithParameterList(
                ParameterList(
                    SeparatedList(
                        function.ParameterList.Parameters.Select(param =>
                            param.Identifier.Text == function.Identifier.Text
                                ? param.WithIdentifier(Identifier($"_{param.Identifier.Text}"))
                                : param
                        )
                    )
                )
            )
            .WithModifiers(
                TokenList(function.Modifiers.Where(x => !x.IsKind(SyntaxKind.ExternKeyword)))
            );

        return transform(function, false);
    }
}
