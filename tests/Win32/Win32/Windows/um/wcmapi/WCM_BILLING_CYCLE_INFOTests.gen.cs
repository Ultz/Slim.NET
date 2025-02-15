// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wcmapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "WCM_BILLING_CYCLE_INFO"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class WCM_BILLING_CYCLE_INFOTests
{
    /// <summary>Validates that the <see cref = "WCM_BILLING_CYCLE_INFO"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<WCM_BILLING_CYCLE_INFO>(),
            Is.EqualTo(sizeof(WCM_BILLING_CYCLE_INFO))
        );
    }

    /// <summary>Validates that the <see cref = "WCM_BILLING_CYCLE_INFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WCM_BILLING_CYCLE_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WCM_BILLING_CYCLE_INFO"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WCM_BILLING_CYCLE_INFO), Is.EqualTo(28));
    }
}
