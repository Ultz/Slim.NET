// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "REPAIR_COPIES_INPUT"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class REPAIR_COPIES_INPUTTests
{
    /// <summary>Validates that the <see cref = "REPAIR_COPIES_INPUT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<REPAIR_COPIES_INPUT>(), Is.EqualTo(sizeof(REPAIR_COPIES_INPUT)));
    }

    /// <summary>Validates that the <see cref = "REPAIR_COPIES_INPUT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(REPAIR_COPIES_INPUT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "REPAIR_COPIES_INPUT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(REPAIR_COPIES_INPUT), Is.EqualTo(32));
    }
}
