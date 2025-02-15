// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IMFSourceBuffer"/> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class IMFSourceBufferTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMFSourceBuffer"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFSourceBuffer).GUID, Is.EqualTo(IID_IMFSourceBuffer));
    }

    /// <summary>Validates that the <see cref = "IMFSourceBuffer"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFSourceBuffer>(), Is.EqualTo(sizeof(IMFSourceBuffer)));
    }

    /// <summary>Validates that the <see cref = "IMFSourceBuffer"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFSourceBuffer).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMFSourceBuffer"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFSourceBuffer), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFSourceBuffer), Is.EqualTo(4));
        }
    }
}
