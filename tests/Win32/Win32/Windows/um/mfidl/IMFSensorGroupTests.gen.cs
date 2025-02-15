// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IMFSensorGroup"/> struct.</summary>
[SupportedOSPlatform("windows10.0.14393.0")]
public static unsafe partial class IMFSensorGroupTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMFSensorGroup"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFSensorGroup).GUID, Is.EqualTo(IID_IMFSensorGroup));
    }

    /// <summary>Validates that the <see cref = "IMFSensorGroup"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFSensorGroup>(), Is.EqualTo(sizeof(IMFSensorGroup)));
    }

    /// <summary>Validates that the <see cref = "IMFSensorGroup"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFSensorGroup).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMFSensorGroup"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFSensorGroup), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFSensorGroup), Is.EqualTo(4));
        }
    }
}
