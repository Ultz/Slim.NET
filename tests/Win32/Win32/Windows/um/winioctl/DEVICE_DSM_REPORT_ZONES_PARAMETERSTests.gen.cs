// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "DEVICE_DSM_REPORT_ZONES_PARAMETERS"/> struct.</summary>
public static unsafe partial class DEVICE_DSM_REPORT_ZONES_PARAMETERSTests
{
    /// <summary>Validates that the <see cref = "DEVICE_DSM_REPORT_ZONES_PARAMETERS"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DEVICE_DSM_REPORT_ZONES_PARAMETERS>(),
            Is.EqualTo(sizeof(DEVICE_DSM_REPORT_ZONES_PARAMETERS))
        );
    }

    /// <summary>Validates that the <see cref = "DEVICE_DSM_REPORT_ZONES_PARAMETERS"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DEVICE_DSM_REPORT_ZONES_PARAMETERS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DEVICE_DSM_REPORT_ZONES_PARAMETERS"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DEVICE_DSM_REPORT_ZONES_PARAMETERS), Is.EqualTo(8));
    }
}
