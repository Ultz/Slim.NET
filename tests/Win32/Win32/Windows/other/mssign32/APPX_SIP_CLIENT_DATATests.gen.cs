// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32.UnitTests;

/// <summary>Provides validation of the <see cref = "APPX_SIP_CLIENT_DATA"/> struct.</summary>
public static unsafe partial class APPX_SIP_CLIENT_DATATests
{
    /// <summary>Validates that the <see cref = "APPX_SIP_CLIENT_DATA"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<APPX_SIP_CLIENT_DATA>(),
            Is.EqualTo(sizeof(APPX_SIP_CLIENT_DATA))
        );
    }

    /// <summary>Validates that the <see cref = "APPX_SIP_CLIENT_DATA"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(APPX_SIP_CLIENT_DATA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "APPX_SIP_CLIENT_DATA"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(APPX_SIP_CLIENT_DATA), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(APPX_SIP_CLIENT_DATA), Is.EqualTo(8));
        }
    }
}
