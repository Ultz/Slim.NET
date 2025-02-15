// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/inkrenderer.h and um/inkrenderer_i.c in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.CLSID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "InkD2DRenderer"/> struct.</summary>
public static unsafe partial class InkD2DRendererTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "InkD2DRenderer"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(InkD2DRenderer).GUID, Is.EqualTo(CLSID_InkD2DRenderer));
    }

    /// <summary>Validates that the <see cref = "InkD2DRenderer"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<InkD2DRenderer>(), Is.EqualTo(sizeof(InkD2DRenderer)));
    }

    /// <summary>Validates that the <see cref = "InkD2DRenderer"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(InkD2DRenderer).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "InkD2DRenderer"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(InkD2DRenderer), Is.EqualTo(1));
    }
}
