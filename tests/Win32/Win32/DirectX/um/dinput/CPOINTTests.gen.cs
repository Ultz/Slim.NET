// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "CPOINT"/> struct.</summary>
public static unsafe partial class CPOINTTests
{
    /// <summary>Validates that the <see cref = "CPOINT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CPOINT>(), Is.EqualTo(sizeof(CPOINT)));
    }

    /// <summary>Validates that the <see cref = "CPOINT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CPOINT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CPOINT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(CPOINT), Is.EqualTo(8));
    }
}
