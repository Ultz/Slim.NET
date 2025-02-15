// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "TCPIP_OWNER_MODULE_BASIC_INFO"/> struct.</summary>
public static unsafe partial class TCPIP_OWNER_MODULE_BASIC_INFOTests
{
    /// <summary>Validates that the <see cref = "TCPIP_OWNER_MODULE_BASIC_INFO"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<TCPIP_OWNER_MODULE_BASIC_INFO>(),
            Is.EqualTo(sizeof(TCPIP_OWNER_MODULE_BASIC_INFO))
        );
    }

    /// <summary>Validates that the <see cref = "TCPIP_OWNER_MODULE_BASIC_INFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TCPIP_OWNER_MODULE_BASIC_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TCPIP_OWNER_MODULE_BASIC_INFO"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(TCPIP_OWNER_MODULE_BASIC_INFO), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(TCPIP_OWNER_MODULE_BASIC_INFO), Is.EqualTo(8));
        }
    }
}
