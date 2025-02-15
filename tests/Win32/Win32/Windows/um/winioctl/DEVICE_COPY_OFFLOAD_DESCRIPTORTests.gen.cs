// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "DEVICE_COPY_OFFLOAD_DESCRIPTOR"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class DEVICE_COPY_OFFLOAD_DESCRIPTORTests
{
    /// <summary>Validates that the <see cref = "DEVICE_COPY_OFFLOAD_DESCRIPTOR"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DEVICE_COPY_OFFLOAD_DESCRIPTOR>(),
            Is.EqualTo(sizeof(DEVICE_COPY_OFFLOAD_DESCRIPTOR))
        );
    }

    /// <summary>Validates that the <see cref = "DEVICE_COPY_OFFLOAD_DESCRIPTOR"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DEVICE_COPY_OFFLOAD_DESCRIPTOR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DEVICE_COPY_OFFLOAD_DESCRIPTOR"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DEVICE_COPY_OFFLOAD_DESCRIPTOR), Is.EqualTo(48));
    }
}
