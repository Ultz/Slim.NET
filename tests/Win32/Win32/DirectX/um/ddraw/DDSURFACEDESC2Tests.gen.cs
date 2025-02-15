// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DDSURFACEDESC2"/> struct.</summary>
public static unsafe partial class DDSURFACEDESC2Tests
{
    /// <summary>Validates that the <see cref = "DDSURFACEDESC2"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DDSURFACEDESC2>(), Is.EqualTo(sizeof(DDSURFACEDESC2)));
    }

    /// <summary>Validates that the <see cref = "DDSURFACEDESC2"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DDSURFACEDESC2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DDSURFACEDESC2"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DDSURFACEDESC2), Is.EqualTo(136));
        }
        else
        {
            Assert.That(sizeof(DDSURFACEDESC2), Is.EqualTo(124));
        }
    }
}
