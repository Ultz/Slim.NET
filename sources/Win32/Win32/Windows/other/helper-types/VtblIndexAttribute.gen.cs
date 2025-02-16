// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
using System.Diagnostics;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET;

/// <summary>Defines the vtbl index of a method as it was in the native signature.</summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
[Conditional("DEBUG")]
internal sealed partial class VtblIndexAttribute : Attribute
{
    private readonly uint _index;

    /// <summary>Initializes a new instance of the <see cref = "VtblIndexAttribute"/> class.</summary>
    /// <param name = "index">The vtbl index of a method as it was in the native signature.</param>

    public VtblIndexAttribute(uint index)
    {
        _index = index;
    }

    /// <summary>Gets the vtbl index of a method as it was in the native signature.</summary>

    public uint Index => _index;
}
