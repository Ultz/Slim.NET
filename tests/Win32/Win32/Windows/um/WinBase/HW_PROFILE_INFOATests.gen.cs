// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "HW_PROFILE_INFOA"/> struct.</summary>
public static unsafe partial class HW_PROFILE_INFOATests
{
    /// <summary>Validates that the <see cref = "HW_PROFILE_INFOA"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HW_PROFILE_INFOA>(), Is.EqualTo(sizeof(HW_PROFILE_INFOA)));
    }

    /// <summary>Validates that the <see cref = "HW_PROFILE_INFOA"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HW_PROFILE_INFOA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HW_PROFILE_INFOA"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HW_PROFILE_INFOA), Is.EqualTo(124));
    }
}
