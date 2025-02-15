// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "MDICREATESTRUCTA"/> struct.</summary>
public static unsafe partial class MDICREATESTRUCTATests
{
    /// <summary>Validates that the <see cref = "MDICREATESTRUCTA"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MDICREATESTRUCTA>(), Is.EqualTo(sizeof(MDICREATESTRUCTA)));
    }

    /// <summary>Validates that the <see cref = "MDICREATESTRUCTA"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MDICREATESTRUCTA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MDICREATESTRUCTA"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(MDICREATESTRUCTA), Is.EqualTo(56));
        }
        else
        {
            Assert.That(sizeof(MDICREATESTRUCTA), Is.EqualTo(36));
        }
    }
}
