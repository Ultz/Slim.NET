// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "SET_PURGE_FAILURE_MODE_INPUT"/> struct.</summary>
public static unsafe partial class SET_PURGE_FAILURE_MODE_INPUTTests
{
    /// <summary>Validates that the <see cref = "SET_PURGE_FAILURE_MODE_INPUT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SET_PURGE_FAILURE_MODE_INPUT>(),
            Is.EqualTo(sizeof(SET_PURGE_FAILURE_MODE_INPUT))
        );
    }

    /// <summary>Validates that the <see cref = "SET_PURGE_FAILURE_MODE_INPUT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SET_PURGE_FAILURE_MODE_INPUT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SET_PURGE_FAILURE_MODE_INPUT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SET_PURGE_FAILURE_MODE_INPUT), Is.EqualTo(4));
    }
}
