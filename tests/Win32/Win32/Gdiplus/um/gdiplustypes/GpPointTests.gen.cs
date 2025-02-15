// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus.UnitTests;

/// <summary>Provides validation of the <see cref = "GpPoint"/> struct.</summary>
public static unsafe partial class GpPointTests
{
    /// <summary>Validates that the <see cref = "GpPoint"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<GpPoint>(), Is.EqualTo(sizeof(GpPoint)));
    }

    /// <summary>Validates that the <see cref = "GpPoint"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(GpPoint).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "GpPoint"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(GpPoint), Is.EqualTo(8));
    }
}
