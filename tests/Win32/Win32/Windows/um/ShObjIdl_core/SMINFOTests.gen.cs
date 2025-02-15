// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "SMINFO"/> struct.</summary>
public static unsafe partial class SMINFOTests
{
    /// <summary>Validates that the <see cref = "SMINFO"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SMINFO>(), Is.EqualTo(sizeof(SMINFO)));
    }

    /// <summary>Validates that the <see cref = "SMINFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SMINFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SMINFO"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SMINFO), Is.EqualTo(16));
    }
}
