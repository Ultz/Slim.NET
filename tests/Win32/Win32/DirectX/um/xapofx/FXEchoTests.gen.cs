// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xapofx.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.CLSID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "FXEcho"/> struct.</summary>
public static unsafe partial class FXEchoTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "FXEcho"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(FXEcho).GUID, Is.EqualTo(CLSID_FXEcho));
    }

    /// <summary>Validates that the <see cref = "FXEcho"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FXEcho>(), Is.EqualTo(sizeof(FXEcho)));
    }

    /// <summary>Validates that the <see cref = "FXEcho"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FXEcho).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "FXEcho"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(FXEcho), Is.EqualTo(1));
    }
}
