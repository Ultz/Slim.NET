// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "CMC_STATUS_INFO"/> struct.</summary>
public static unsafe partial class CMC_STATUS_INFOTests
{
    /// <summary>Validates that the <see cref = "CMC_STATUS_INFO"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CMC_STATUS_INFO>(), Is.EqualTo(sizeof(CMC_STATUS_INFO)));
    }

    /// <summary>Validates that the <see cref = "CMC_STATUS_INFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CMC_STATUS_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CMC_STATUS_INFO"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CMC_STATUS_INFO), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(CMC_STATUS_INFO), Is.EqualTo(24));
        }
    }
}
