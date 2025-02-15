// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/rendezvoussession.h and um/rendezvoussession_i.c in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "DRendezvousSessionEvents"/> struct.</summary>
public static unsafe partial class DRendezvousSessionEventsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "DRendezvousSessionEvents"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(DRendezvousSessionEvents).GUID,
            Is.EqualTo(DIID_DRendezvousSessionEvents)
        );
    }

    /// <summary>Validates that the <see cref = "DRendezvousSessionEvents"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DRendezvousSessionEvents>(),
            Is.EqualTo(sizeof(DRendezvousSessionEvents))
        );
    }

    /// <summary>Validates that the <see cref = "DRendezvousSessionEvents"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DRendezvousSessionEvents).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DRendezvousSessionEvents"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DRendezvousSessionEvents), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(DRendezvousSessionEvents), Is.EqualTo(4));
        }
    }
}
