// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "SINGLE_LIST_ENTRY"/> struct.</summary>
public static unsafe partial class SINGLE_LIST_ENTRYTests
{
    /// <summary>Validates that the <see cref = "SINGLE_LIST_ENTRY"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SINGLE_LIST_ENTRY>(), Is.EqualTo(sizeof(SINGLE_LIST_ENTRY)));
    }

    /// <summary>Validates that the <see cref = "SINGLE_LIST_ENTRY"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SINGLE_LIST_ENTRY).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SINGLE_LIST_ENTRY"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SINGLE_LIST_ENTRY), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(SINGLE_LIST_ENTRY), Is.EqualTo(4));
        }
    }
}
