// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "MSAUDIO1WAVEFORMAT"/> struct.</summary>
public static unsafe partial class MSAUDIO1WAVEFORMATTests
{
    /// <summary>Validates that the <see cref = "MSAUDIO1WAVEFORMAT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MSAUDIO1WAVEFORMAT>(), Is.EqualTo(sizeof(MSAUDIO1WAVEFORMAT)));
    }

    /// <summary>Validates that the <see cref = "MSAUDIO1WAVEFORMAT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MSAUDIO1WAVEFORMAT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MSAUDIO1WAVEFORMAT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MSAUDIO1WAVEFORMAT), Is.EqualTo(22));
    }
}
