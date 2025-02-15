// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "ADDRINFOEX2A"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class ADDRINFOEX2ATests
{
    /// <summary>Validates that the <see cref = "ADDRINFOEX2A"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ADDRINFOEX2A>(), Is.EqualTo(sizeof(ADDRINFOEX2A)));
    }

    /// <summary>Validates that the <see cref = "ADDRINFOEX2A"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ADDRINFOEX2A).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ADDRINFOEX2A"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ADDRINFOEX2A), Is.EqualTo(88));
        }
        else
        {
            Assert.That(sizeof(ADDRINFOEX2A), Is.EqualTo(52));
        }
    }
}
