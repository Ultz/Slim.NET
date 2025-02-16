// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
using System.Diagnostics;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET;

/// <summary>Defines the base type of a struct as it was in the native signature.</summary>
[AttributeUsage(AttributeTargets.Struct, AllowMultiple = false, Inherited = true)]
[Conditional("DEBUG")]
internal sealed partial class NativeInheritanceAttribute : Attribute
{
    private readonly string _name;

    /// <summary>Initializes a new instance of the <see cref = "NativeInheritanceAttribute"/> class.</summary>
    /// <param name = "name">The name of the base type that was inherited from in the native signature.</param>

    public NativeInheritanceAttribute(string name)
    {
        _name = name;
    }

    /// <summary>Gets the name of the base type that was inherited from in the native signature.</summary>

    public string Name => _name;
}
