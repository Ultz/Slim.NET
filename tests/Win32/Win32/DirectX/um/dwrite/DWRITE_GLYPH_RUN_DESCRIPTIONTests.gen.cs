// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DWRITE_GLYPH_RUN_DESCRIPTION"/> struct.</summary>
public static unsafe partial class DWRITE_GLYPH_RUN_DESCRIPTIONTests
{
    /// <summary>Validates that the <see cref = "DWRITE_GLYPH_RUN_DESCRIPTION"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DWRITE_GLYPH_RUN_DESCRIPTION>(),
            Is.EqualTo(sizeof(DWRITE_GLYPH_RUN_DESCRIPTION))
        );
    }

    /// <summary>Validates that the <see cref = "DWRITE_GLYPH_RUN_DESCRIPTION"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DWRITE_GLYPH_RUN_DESCRIPTION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DWRITE_GLYPH_RUN_DESCRIPTION"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DWRITE_GLYPH_RUN_DESCRIPTION), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(DWRITE_GLYPH_RUN_DESCRIPTION), Is.EqualTo(20));
        }
    }
}
