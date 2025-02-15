// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "WS_CERTIFICATE_VALIDATION_CALLBACK_CONTEXT"/> struct.</summary>
public static unsafe partial class WS_CERTIFICATE_VALIDATION_CALLBACK_CONTEXTTests
{
    /// <summary>Validates that the <see cref = "WS_CERTIFICATE_VALIDATION_CALLBACK_CONTEXT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<WS_CERTIFICATE_VALIDATION_CALLBACK_CONTEXT>(),
            Is.EqualTo(sizeof(WS_CERTIFICATE_VALIDATION_CALLBACK_CONTEXT))
        );
    }

    /// <summary>Validates that the <see cref = "WS_CERTIFICATE_VALIDATION_CALLBACK_CONTEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WS_CERTIFICATE_VALIDATION_CALLBACK_CONTEXT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WS_CERTIFICATE_VALIDATION_CALLBACK_CONTEXT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(WS_CERTIFICATE_VALIDATION_CALLBACK_CONTEXT), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(WS_CERTIFICATE_VALIDATION_CALLBACK_CONTEXT), Is.EqualTo(8));
        }
    }
}
