// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32.UnitTests;

/// <summary>Provides validation of the <see cref = "SIGNER_ATTR_AUTHCODE"/> struct.</summary>
public static unsafe partial class SIGNER_ATTR_AUTHCODETests
{
    /// <summary>Validates that the <see cref = "SIGNER_ATTR_AUTHCODE"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SIGNER_ATTR_AUTHCODE>(),
            Is.EqualTo(sizeof(SIGNER_ATTR_AUTHCODE))
        );
    }

    /// <summary>Validates that the <see cref = "SIGNER_ATTR_AUTHCODE"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SIGNER_ATTR_AUTHCODE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SIGNER_ATTR_AUTHCODE"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SIGNER_ATTR_AUTHCODE), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(SIGNER_ATTR_AUTHCODE), Is.EqualTo(20));
        }
    }
}
