// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Xinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "XINPUT_BATTERY_INFORMATION"/> struct.</summary>
public static unsafe partial class XINPUT_BATTERY_INFORMATIONTests
{
    /// <summary>Validates that the <see cref = "XINPUT_BATTERY_INFORMATION"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<XINPUT_BATTERY_INFORMATION>(),
            Is.EqualTo(sizeof(XINPUT_BATTERY_INFORMATION))
        );
    }

    /// <summary>Validates that the <see cref = "XINPUT_BATTERY_INFORMATION"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(XINPUT_BATTERY_INFORMATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "XINPUT_BATTERY_INFORMATION"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(XINPUT_BATTERY_INFORMATION), Is.EqualTo(2));
    }
}
