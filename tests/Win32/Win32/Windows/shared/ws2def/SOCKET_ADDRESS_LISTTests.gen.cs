// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "SOCKET_ADDRESS_LIST"/> struct.</summary>
public static unsafe partial class SOCKET_ADDRESS_LISTTests
{
    /// <summary>Validates that the <see cref = "SOCKET_ADDRESS_LIST"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SOCKET_ADDRESS_LIST>(), Is.EqualTo(sizeof(SOCKET_ADDRESS_LIST)));
    }

    /// <summary>Validates that the <see cref = "SOCKET_ADDRESS_LIST"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SOCKET_ADDRESS_LIST).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SOCKET_ADDRESS_LIST"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SOCKET_ADDRESS_LIST), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(SOCKET_ADDRESS_LIST), Is.EqualTo(12));
        }
    }
}
