// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IMAGEHLP_DEFERRED_SYMBOL_LOAD64"/> struct.</summary>
public static unsafe partial class IMAGEHLP_DEFERRED_SYMBOL_LOAD64Tests
{
    /// <summary>Validates that the <see cref = "IMAGEHLP_DEFERRED_SYMBOL_LOAD64"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IMAGEHLP_DEFERRED_SYMBOL_LOAD64>(),
            Is.EqualTo(sizeof(IMAGEHLP_DEFERRED_SYMBOL_LOAD64))
        );
    }

    /// <summary>Validates that the <see cref = "IMAGEHLP_DEFERRED_SYMBOL_LOAD64"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMAGEHLP_DEFERRED_SYMBOL_LOAD64).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMAGEHLP_DEFERRED_SYMBOL_LOAD64"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMAGEHLP_DEFERRED_SYMBOL_LOAD64), Is.EqualTo(304));
        }
        else
        {
            Assert.That(sizeof(IMAGEHLP_DEFERRED_SYMBOL_LOAD64), Is.EqualTo(296));
        }
    }
}
