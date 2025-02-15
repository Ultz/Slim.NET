// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "SCM_BUS_DEDICATED_MEMORY_STATE"/> struct.</summary>
public static unsafe partial class SCM_BUS_DEDICATED_MEMORY_STATETests
{
    /// <summary>Validates that the <see cref = "SCM_BUS_DEDICATED_MEMORY_STATE"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SCM_BUS_DEDICATED_MEMORY_STATE>(),
            Is.EqualTo(sizeof(SCM_BUS_DEDICATED_MEMORY_STATE))
        );
    }

    /// <summary>Validates that the <see cref = "SCM_BUS_DEDICATED_MEMORY_STATE"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SCM_BUS_DEDICATED_MEMORY_STATE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SCM_BUS_DEDICATED_MEMORY_STATE"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SCM_BUS_DEDICATED_MEMORY_STATE), Is.EqualTo(1));
    }
}
