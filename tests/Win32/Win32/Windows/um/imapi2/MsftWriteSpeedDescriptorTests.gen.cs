// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.CLSID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "MsftWriteSpeedDescriptor"/> struct.</summary>
public static unsafe partial class MsftWriteSpeedDescriptorTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "MsftWriteSpeedDescriptor"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(MsftWriteSpeedDescriptor).GUID,
            Is.EqualTo(CLSID_MsftWriteSpeedDescriptor)
        );
    }

    /// <summary>Validates that the <see cref = "MsftWriteSpeedDescriptor"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<MsftWriteSpeedDescriptor>(),
            Is.EqualTo(sizeof(MsftWriteSpeedDescriptor))
        );
    }

    /// <summary>Validates that the <see cref = "MsftWriteSpeedDescriptor"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MsftWriteSpeedDescriptor).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MsftWriteSpeedDescriptor"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MsftWriteSpeedDescriptor), Is.EqualTo(1));
    }
}
