// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IDiscFormat2TrackAtOnceEventArgs"/> struct.</summary>
public static unsafe partial class IDiscFormat2TrackAtOnceEventArgsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDiscFormat2TrackAtOnceEventArgs"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IDiscFormat2TrackAtOnceEventArgs).GUID,
            Is.EqualTo(IID_IDiscFormat2TrackAtOnceEventArgs)
        );
    }

    /// <summary>Validates that the <see cref = "IDiscFormat2TrackAtOnceEventArgs"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IDiscFormat2TrackAtOnceEventArgs>(),
            Is.EqualTo(sizeof(IDiscFormat2TrackAtOnceEventArgs))
        );
    }

    /// <summary>Validates that the <see cref = "IDiscFormat2TrackAtOnceEventArgs"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDiscFormat2TrackAtOnceEventArgs).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDiscFormat2TrackAtOnceEventArgs"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDiscFormat2TrackAtOnceEventArgs), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDiscFormat2TrackAtOnceEventArgs), Is.EqualTo(4));
        }
    }
}
