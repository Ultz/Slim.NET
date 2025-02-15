// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IP_MREQ"/> struct.</summary>
public static unsafe partial class IP_MREQTests
{
    /// <summary>Validates that the <see cref = "IP_MREQ"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IP_MREQ>(), Is.EqualTo(sizeof(IP_MREQ)));
    }

    /// <summary>Validates that the <see cref = "IP_MREQ"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IP_MREQ).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IP_MREQ"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IP_MREQ), Is.EqualTo(8));
    }
}
