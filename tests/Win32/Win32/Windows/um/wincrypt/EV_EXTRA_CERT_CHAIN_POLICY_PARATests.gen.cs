// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "EV_EXTRA_CERT_CHAIN_POLICY_PARA"/> struct.</summary>
public static unsafe partial class EV_EXTRA_CERT_CHAIN_POLICY_PARATests
{
    /// <summary>Validates that the <see cref = "EV_EXTRA_CERT_CHAIN_POLICY_PARA"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<EV_EXTRA_CERT_CHAIN_POLICY_PARA>(),
            Is.EqualTo(sizeof(EV_EXTRA_CERT_CHAIN_POLICY_PARA))
        );
    }

    /// <summary>Validates that the <see cref = "EV_EXTRA_CERT_CHAIN_POLICY_PARA"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EV_EXTRA_CERT_CHAIN_POLICY_PARA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "EV_EXTRA_CERT_CHAIN_POLICY_PARA"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(EV_EXTRA_CERT_CHAIN_POLICY_PARA), Is.EqualTo(8));
    }
}
