// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2Tests
{
    /// <summary>Validates that the <see cref = "JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2>(),
            Is.EqualTo(sizeof(JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2))
        );
    }

    /// <summary>Validates that the <see cref = "JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2), Is.EqualTo(72));
    }
}
