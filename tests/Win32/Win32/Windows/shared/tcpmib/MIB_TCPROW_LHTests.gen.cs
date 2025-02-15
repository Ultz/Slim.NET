// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "MIB_TCPROW_LH"/> struct.</summary>
public static unsafe partial class MIB_TCPROW_LHTests
{
    /// <summary>Validates that the <see cref = "MIB_TCPROW_LH"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MIB_TCPROW_LH>(), Is.EqualTo(sizeof(MIB_TCPROW_LH)));
    }

    /// <summary>Validates that the <see cref = "MIB_TCPROW_LH"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MIB_TCPROW_LH).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MIB_TCPROW_LH"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MIB_TCPROW_LH), Is.EqualTo(20));
    }
}
