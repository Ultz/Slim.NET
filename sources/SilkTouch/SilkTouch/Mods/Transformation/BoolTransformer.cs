// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Options;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods.Transformation;

/// <summary>
/// A transformer transforming parameters that are recognised to be akin to booleans to use the <c>MaybeBool</c> type.
/// </summary>
public class BoolTransformer(IOptionsSnapshot<TransformFunctions.Configuration> options)
    : IFunctionTransformer
{
    /// <inheritdoc />
    public MethodDeclarationSyntax Transform(
        MethodDeclarationSyntax current,
        bool isInInterface,
        ITransformationContext ctx,
        Func<MethodDeclarationSyntax, bool, MethodDeclarationSyntax> next
    )
    {
        var ogCurrent = current;
        var cfg = options.Get(ctx.JobKey);
        string? retBoolScheme = null;
        TypeSyntax? newRetType = null;
        var retNative = current.GetNativeReturnTypeName() ?? current.ReturnType.ToString();
        if (
            (current.ReturnType.IsInteger() && cfg.IntReturnsMaybeBool)
            || (cfg.BoolTypes?.TryGetValue(retNative, out retBoolScheme) ?? false)
            || (retNative == "bool" && current.ReturnType.ToString().Trim() != "bool") // stdbool.h, hopefully...
        )
        {
            current = current.WithReturnType(
                newRetType = string.IsNullOrWhiteSpace(retBoolScheme)
                    ? GenericName(
                        Identifier("MaybeBool"),
                        TypeArgumentList(SingletonSeparatedList(current.ReturnType))
                    )
                    : GenericName(
                        Identifier("MaybeBool"),
                        TypeArgumentList(
                            SeparatedList(
                                // ReSharper disable once RedundantCast <-- false positive
                                (IEnumerable<TypeSyntax>)
                                    [current.ReturnType, IdentifierName(retBoolScheme)]
                            )
                        )
                    )
            );
        }

        List<ParameterSyntax>? @params = null;
        for (var i = 0; i < current.ParameterList.Parameters.Count; i++)
        {
            var param = current.ParameterList.Parameters[i];
            var paramNative = param.GetNativeTypeName() ?? param.Type?.ToString();
            string? paramBoolScheme = null;
            if (
                paramNative is not null
                && param.Type is not null
                && (
                    (cfg.BoolTypes?.TryGetValue(paramNative, out paramBoolScheme) ?? false)
                    || (paramNative == "bool" && param.Type.ToString().Trim() != "bool") // stdbool.h, hopefully...
                )
            )
            {
                var defaultAttr = param
                    .AttributeLists.Select(attrList =>
                        attrList.Attributes.FirstOrDefault(attr =>
                            attr.IsAttribute("System.Runtime.InteropServices.DefaultParameterValue")
                        )
                    )
                    .FirstOrDefault();

                if (defaultAttr is not null && defaultAttr.ArgumentList?.Arguments.Count > 0)
                {
                    string argValue =
                        defaultAttr.ArgumentList?.Arguments[0].Expression.ToString()
                        ?? string.Empty;

                    if (argValue != string.Empty && argValue != "true" && argValue != "false")
                    {
                        param = param.ReplaceNode(
                            defaultAttr,
                            defaultAttr.WithArgumentList(
                                AttributeArgumentList(
                                    SingletonSeparatedList(
                                        AttributeArgument(
                                            IdentifierName(argValue == "0" ? "false" : "true")
                                        )
                                    )
                                )
                            )
                        );
                    }
                }

                (@params ??= [.. current.ParameterList.Parameters])[i] = param.WithType(
                    string.IsNullOrWhiteSpace(paramBoolScheme)
                        ? GenericName(
                            Identifier("MaybeBool"),
                            TypeArgumentList(SingletonSeparatedList(param.Type!))
                        )
                        : GenericName(
                            Identifier("MaybeBool"),
                            TypeArgumentList(
                                SeparatedList(
                                    // ReSharper disable once RedundantCast <-- false positive
                                    (IEnumerable<TypeSyntax>)
                                        [param.Type!, IdentifierName(paramBoolScheme)]
                                )
                            )
                        )
                );
            }
        }

        if (@params is not null)
        {
            current = current.WithParameterList(
                current.ParameterList.WithParameters(SeparatedList(@params))
            );
        }

        if (!ReferenceEquals(current, ogCurrent))
        {
            current =
                current.CastFunctionCalls(
                    ctx.Original!,
                    newRetType,
                    current.ParameterList.Parameters
                ) as MethodDeclarationSyntax
                ?? current;
        }

        return next(current, isInInterface);
    }
}
