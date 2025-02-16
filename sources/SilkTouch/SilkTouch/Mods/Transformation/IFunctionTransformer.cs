using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Silk.NET.SilkTouch.Mods.Transformation;

/// <summary>
/// Represents a function transformer, consuming a low-level native function signature and providing a high-level
/// wrapping method (and implementation code) for the next transformer.
/// </summary>
public interface IFunctionTransformer
{
    /// <summary>
    /// Transforms the function, wrapping its implementation and passing the new signature to the given callback. Note
    /// that it is required that all transformers can detect when the function has already been transformed
    /// </summary>
    /// <param name="current">The inner function implementation.</param>
    /// <param name="isInInterface">is this function in an interface</param>
    /// <param name="ctx">The wider context for the function transformation operation.</param>
    /// <param name="next">The callback for the outer function produced by this transformer.</param>
    /// <remarks>
    /// <paramref name="next"/> can be called multiple times for the same input. This can be used to generate
    /// transformative overloads for a function.
    /// </remarks>
    /// <returns>the transformed function</returns>
    MethodDeclarationSyntax Transform(
        MethodDeclarationSyntax current,
        bool isInInterface,
        ITransformationContext ctx,
        Func<MethodDeclarationSyntax, bool, MethodDeclarationSyntax> next
    );
}
