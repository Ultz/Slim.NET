// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/prsht.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "PROPSHEETHEADERW_V2"/> struct.</summary>
public static unsafe partial class PROPSHEETHEADERW_V2Tests
{
    /// <summary>Validates that the <see cref = "PROPSHEETHEADERW_V2"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PROPSHEETHEADERW_V2>(), Is.EqualTo(sizeof(PROPSHEETHEADERW_V2)));
    }

    /// <summary>Validates that the <see cref = "PROPSHEETHEADERW_V2"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PROPSHEETHEADERW_V2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PROPSHEETHEADERW_V2"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PROPSHEETHEADERW_V2), Is.EqualTo(96));
        }
        else
        {
            Assert.That(sizeof(PROPSHEETHEADERW_V2), Is.EqualTo(52));
        }
    }
}
