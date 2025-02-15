// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DIEFFECTINFOA"/> struct.</summary>
public static unsafe partial class DIEFFECTINFOATests
{
    /// <summary>Validates that the <see cref = "DIEFFECTINFOA"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DIEFFECTINFOA>(), Is.EqualTo(sizeof(DIEFFECTINFOA)));
    }

    /// <summary>Validates that the <see cref = "DIEFFECTINFOA"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DIEFFECTINFOA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DIEFFECTINFOA"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DIEFFECTINFOA), Is.EqualTo(292));
    }
}
