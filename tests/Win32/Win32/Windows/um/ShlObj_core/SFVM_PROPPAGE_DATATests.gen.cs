// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "SFVM_PROPPAGE_DATA"/> struct.</summary>
public static unsafe partial class SFVM_PROPPAGE_DATATests
{
    /// <summary>Validates that the <see cref = "SFVM_PROPPAGE_DATA"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SFVM_PROPPAGE_DATA>(), Is.EqualTo(sizeof(SFVM_PROPPAGE_DATA)));
    }

    /// <summary>Validates that the <see cref = "SFVM_PROPPAGE_DATA"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SFVM_PROPPAGE_DATA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SFVM_PROPPAGE_DATA"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SFVM_PROPPAGE_DATA), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(SFVM_PROPPAGE_DATA), Is.EqualTo(12));
        }
    }
}
