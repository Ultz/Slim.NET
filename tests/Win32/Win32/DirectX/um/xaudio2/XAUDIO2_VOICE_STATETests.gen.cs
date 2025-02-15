// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "XAUDIO2_VOICE_STATE"/> struct.</summary>
public static unsafe partial class XAUDIO2_VOICE_STATETests
{
    /// <summary>Validates that the <see cref = "XAUDIO2_VOICE_STATE"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<XAUDIO2_VOICE_STATE>(), Is.EqualTo(sizeof(XAUDIO2_VOICE_STATE)));
    }

    /// <summary>Validates that the <see cref = "XAUDIO2_VOICE_STATE"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(XAUDIO2_VOICE_STATE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "XAUDIO2_VOICE_STATE"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(XAUDIO2_VOICE_STATE), Is.EqualTo(20));
        }
        else
        {
            Assert.That(sizeof(XAUDIO2_VOICE_STATE), Is.EqualTo(16));
        }
    }
}
