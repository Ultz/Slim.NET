// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32.UnitTests;

/// <summary>Provides validation of the <see cref = "SIGNER_PROVIDER_INFO"/> struct.</summary>
public static unsafe partial class SIGNER_PROVIDER_INFOTests
{
    /// <summary>Validates that the <see cref = "SIGNER_PROVIDER_INFO"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SIGNER_PROVIDER_INFO>(),
            Is.EqualTo(sizeof(SIGNER_PROVIDER_INFO))
        );
    }

    /// <summary>Validates that the <see cref = "SIGNER_PROVIDER_INFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SIGNER_PROVIDER_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SIGNER_PROVIDER_INFO"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SIGNER_PROVIDER_INFO), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(SIGNER_PROVIDER_INFO), Is.EqualTo(24));
        }
    }
}
