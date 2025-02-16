// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
using System.Diagnostics;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

/// <summary>Defines the annotation found in a native declaration.</summary>
[AttributeUsage(
    AttributeTargets.Struct
        | AttributeTargets.Enum
        | AttributeTargets.Property
        | AttributeTargets.Field
        | AttributeTargets.Parameter
        | AttributeTargets.ReturnValue,
    AllowMultiple = true,
    Inherited = false
)]
[Conditional("DEBUG")]
internal sealed partial class NativeAnnotationAttribute : Attribute
{
    private readonly string _annotation;

    /// <summary>Initializes a new instance of the <see cref = "NativeAnnotationAttribute"/> class.</summary>
    /// <param name = "annotation">The annotation that was used in the native declaration.</param>

    public NativeAnnotationAttribute(string annotation)
    {
        _annotation = annotation;
    }

    /// <summary>Gets the annotation that was used in the native declaration.</summary>

    public string Annotation => _annotation;
}
