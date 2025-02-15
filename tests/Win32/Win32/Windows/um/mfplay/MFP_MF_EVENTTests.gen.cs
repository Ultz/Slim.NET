// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "MFP_MF_EVENT"/> struct.</summary>
public static unsafe partial class MFP_MF_EVENTTests
{
    /// <summary>Validates that the <see cref = "MFP_MF_EVENT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MFP_MF_EVENT>(), Is.EqualTo(sizeof(MFP_MF_EVENT)));
    }

    /// <summary>Validates that the <see cref = "MFP_MF_EVENT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MFP_MF_EVENT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MFP_MF_EVENT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(MFP_MF_EVENT), Is.EqualTo(56));
        }
        else
        {
            Assert.That(sizeof(MFP_MF_EVENT), Is.EqualTo(32));
        }
    }
}
