// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DWRITE_GLYPH_IMAGE_DATA"/> struct.</summary>
public static unsafe partial class DWRITE_GLYPH_IMAGE_DATATests
{
    /// <summary>Validates that the <see cref = "DWRITE_GLYPH_IMAGE_DATA"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DWRITE_GLYPH_IMAGE_DATA>(),
            Is.EqualTo(sizeof(DWRITE_GLYPH_IMAGE_DATA))
        );
    }

    /// <summary>Validates that the <see cref = "DWRITE_GLYPH_IMAGE_DATA"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DWRITE_GLYPH_IMAGE_DATA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DWRITE_GLYPH_IMAGE_DATA"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DWRITE_GLYPH_IMAGE_DATA), Is.EqualTo(64));
        }
        else
        {
            Assert.That(sizeof(DWRITE_GLYPH_IMAGE_DATA), Is.EqualTo(56));
        }
    }
}
