// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DICONSTANTFORCE"/> struct.</summary>
public static unsafe partial class DICONSTANTFORCETests
{
    /// <summary>Validates that the <see cref = "DICONSTANTFORCE"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DICONSTANTFORCE>(), Is.EqualTo(sizeof(DICONSTANTFORCE)));
    }

    /// <summary>Validates that the <see cref = "DICONSTANTFORCE"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DICONSTANTFORCE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DICONSTANTFORCE"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DICONSTANTFORCE), Is.EqualTo(4));
    }
}
