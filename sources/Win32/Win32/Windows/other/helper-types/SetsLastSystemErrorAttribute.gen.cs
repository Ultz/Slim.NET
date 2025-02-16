// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

/// <summary>Specifies that the given method sets the last system error and it can be retrieved via <see cref = "Marshal.GetLastSystemError"/>.</summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
[Conditional("DEBUG")]
internal sealed partial class SetsLastSystemErrorAttribute : Attribute
{
    /// <summary>Initializes a new instance of the <see cref = "SetsLastSystemErrorAttribute"/> class.</summary>

    public SetsLastSystemErrorAttribute() { }
}
