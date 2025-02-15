// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "CRYPT_PROVUI_DATA"/> struct.</summary>
public static unsafe partial class CRYPT_PROVUI_DATATests
{
    /// <summary>Validates that the <see cref = "CRYPT_PROVUI_DATA"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CRYPT_PROVUI_DATA>(), Is.EqualTo(sizeof(CRYPT_PROVUI_DATA)));
    }

    /// <summary>Validates that the <see cref = "CRYPT_PROVUI_DATA"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CRYPT_PROVUI_DATA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CRYPT_PROVUI_DATA"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CRYPT_PROVUI_DATA), Is.EqualTo(64));
        }
        else
        {
            Assert.That(sizeof(CRYPT_PROVUI_DATA), Is.EqualTo(36));
        }
    }
}
