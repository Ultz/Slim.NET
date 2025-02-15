// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "ID2D1Properties"/> struct.</summary>
public static unsafe partial class ID2D1PropertiesTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ID2D1Properties"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ID2D1Properties).GUID, Is.EqualTo(IID_ID2D1Properties));
    }

    /// <summary>Validates that the <see cref = "ID2D1Properties"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ID2D1Properties>(), Is.EqualTo(sizeof(ID2D1Properties)));
    }

    /// <summary>Validates that the <see cref = "ID2D1Properties"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ID2D1Properties).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ID2D1Properties"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ID2D1Properties), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ID2D1Properties), Is.EqualTo(4));
        }
    }
}
