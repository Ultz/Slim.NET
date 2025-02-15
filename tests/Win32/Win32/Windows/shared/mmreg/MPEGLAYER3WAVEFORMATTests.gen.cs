// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "MPEGLAYER3WAVEFORMAT"/> struct.</summary>
public static unsafe partial class MPEGLAYER3WAVEFORMATTests
{
    /// <summary>Validates that the <see cref = "MPEGLAYER3WAVEFORMAT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<MPEGLAYER3WAVEFORMAT>(),
            Is.EqualTo(sizeof(MPEGLAYER3WAVEFORMAT))
        );
    }

    /// <summary>Validates that the <see cref = "MPEGLAYER3WAVEFORMAT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MPEGLAYER3WAVEFORMAT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MPEGLAYER3WAVEFORMAT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MPEGLAYER3WAVEFORMAT), Is.EqualTo(30));
    }
}
