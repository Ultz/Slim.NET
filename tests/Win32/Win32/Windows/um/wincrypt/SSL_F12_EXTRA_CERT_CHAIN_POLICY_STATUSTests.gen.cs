// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "SSL_F12_EXTRA_CERT_CHAIN_POLICY_STATUS"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class SSL_F12_EXTRA_CERT_CHAIN_POLICY_STATUSTests
{
    /// <summary>Validates that the <see cref = "SSL_F12_EXTRA_CERT_CHAIN_POLICY_STATUS"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SSL_F12_EXTRA_CERT_CHAIN_POLICY_STATUS>(),
            Is.EqualTo(sizeof(SSL_F12_EXTRA_CERT_CHAIN_POLICY_STATUS))
        );
    }

    /// <summary>Validates that the <see cref = "SSL_F12_EXTRA_CERT_CHAIN_POLICY_STATUS"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SSL_F12_EXTRA_CERT_CHAIN_POLICY_STATUS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SSL_F12_EXTRA_CERT_CHAIN_POLICY_STATUS"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SSL_F12_EXTRA_CERT_CHAIN_POLICY_STATUS), Is.EqualTo(528));
    }
}
