// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "ID3DInclude"/> struct.</summary>
public static unsafe partial class ID3DIncludeTests
{
    /// <summary>Validates that the <see cref = "ID3DInclude"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ID3DInclude>(), Is.EqualTo(sizeof(ID3DInclude)));
    }

    /// <summary>Validates that the <see cref = "ID3DInclude"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ID3DInclude).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ID3DInclude"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ID3DInclude), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ID3DInclude), Is.EqualTo(4));
        }
    }
}
