// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IMFRateSupport"/> struct.</summary>
public static unsafe partial class IMFRateSupportTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMFRateSupport"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFRateSupport).GUID, Is.EqualTo(IID_IMFRateSupport));
    }

    /// <summary>Validates that the <see cref = "IMFRateSupport"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFRateSupport>(), Is.EqualTo(sizeof(IMFRateSupport)));
    }

    /// <summary>Validates that the <see cref = "IMFRateSupport"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFRateSupport).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMFRateSupport"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFRateSupport), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFRateSupport), Is.EqualTo(4));
        }
    }
}
