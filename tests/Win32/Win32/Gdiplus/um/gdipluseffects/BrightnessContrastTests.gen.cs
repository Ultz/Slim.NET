// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdipluseffects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus.UnitTests;

/// <summary>Provides validation of the <see cref = "BrightnessContrast"/> struct.</summary>
public static unsafe partial class BrightnessContrastTests
{
    /// <summary>Validates that the <see cref = "BrightnessContrast"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<BrightnessContrast>(), Is.EqualTo(sizeof(BrightnessContrast)));
    }

    /// <summary>Validates that the <see cref = "BrightnessContrast"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(BrightnessContrast).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "BrightnessContrast"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(BrightnessContrast), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(BrightnessContrast), Is.EqualTo(20));
        }
    }
}
