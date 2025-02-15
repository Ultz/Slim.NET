// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "XAUDIO2_VOICE_DETAILS"/> struct.</summary>
public static unsafe partial class XAUDIO2_VOICE_DETAILSTests
{
    /// <summary>Validates that the <see cref = "XAUDIO2_VOICE_DETAILS"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<XAUDIO2_VOICE_DETAILS>(),
            Is.EqualTo(sizeof(XAUDIO2_VOICE_DETAILS))
        );
    }

    /// <summary>Validates that the <see cref = "XAUDIO2_VOICE_DETAILS"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(XAUDIO2_VOICE_DETAILS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "XAUDIO2_VOICE_DETAILS"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(XAUDIO2_VOICE_DETAILS), Is.EqualTo(16));
    }
}
