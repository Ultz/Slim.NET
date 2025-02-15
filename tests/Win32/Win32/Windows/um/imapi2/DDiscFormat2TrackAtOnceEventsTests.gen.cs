// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "DDiscFormat2TrackAtOnceEvents"/> struct.</summary>
public static unsafe partial class DDiscFormat2TrackAtOnceEventsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "DDiscFormat2TrackAtOnceEvents"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(DDiscFormat2TrackAtOnceEvents).GUID,
            Is.EqualTo(IID_DDiscFormat2TrackAtOnceEvents)
        );
    }

    /// <summary>Validates that the <see cref = "DDiscFormat2TrackAtOnceEvents"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DDiscFormat2TrackAtOnceEvents>(),
            Is.EqualTo(sizeof(DDiscFormat2TrackAtOnceEvents))
        );
    }

    /// <summary>Validates that the <see cref = "DDiscFormat2TrackAtOnceEvents"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DDiscFormat2TrackAtOnceEvents).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DDiscFormat2TrackAtOnceEvents"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DDiscFormat2TrackAtOnceEvents), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(DDiscFormat2TrackAtOnceEvents), Is.EqualTo(4));
        }
    }
}
