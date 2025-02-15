// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "CERT_CHAIN_CONTEXT"/> struct.</summary>
public static unsafe partial class CERT_CHAIN_CONTEXTTests
{
    /// <summary>Validates that the <see cref = "CERT_CHAIN_CONTEXT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CERT_CHAIN_CONTEXT>(), Is.EqualTo(sizeof(CERT_CHAIN_CONTEXT)));
    }

    /// <summary>Validates that the <see cref = "CERT_CHAIN_CONTEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CERT_CHAIN_CONTEXT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CERT_CHAIN_CONTEXT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CERT_CHAIN_CONTEXT), Is.EqualTo(72));
        }
        else
        {
            Assert.That(sizeof(CERT_CHAIN_CONTEXT), Is.EqualTo(56));
        }
    }
}
