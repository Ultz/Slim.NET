// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "D2D1_SIMPLE_COLOR_PROFILE"/> struct.</summary>
public static unsafe partial class D2D1_SIMPLE_COLOR_PROFILETests
{
    /// <summary>Validates that the <see cref = "D2D1_SIMPLE_COLOR_PROFILE"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<D2D1_SIMPLE_COLOR_PROFILE>(),
            Is.EqualTo(sizeof(D2D1_SIMPLE_COLOR_PROFILE))
        );
    }

    /// <summary>Validates that the <see cref = "D2D1_SIMPLE_COLOR_PROFILE"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D2D1_SIMPLE_COLOR_PROFILE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "D2D1_SIMPLE_COLOR_PROFILE"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(D2D1_SIMPLE_COLOR_PROFILE), Is.EqualTo(36));
    }
}
