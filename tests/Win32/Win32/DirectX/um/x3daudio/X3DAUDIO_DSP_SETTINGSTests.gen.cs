// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/x3daudio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "X3DAUDIO_DSP_SETTINGS"/> struct.</summary>
public static unsafe partial class X3DAUDIO_DSP_SETTINGSTests
{
    /// <summary>Validates that the <see cref = "X3DAUDIO_DSP_SETTINGS"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<X3DAUDIO_DSP_SETTINGS>(),
            Is.EqualTo(sizeof(X3DAUDIO_DSP_SETTINGS))
        );
    }

    /// <summary>Validates that the <see cref = "X3DAUDIO_DSP_SETTINGS"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(X3DAUDIO_DSP_SETTINGS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "X3DAUDIO_DSP_SETTINGS"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(X3DAUDIO_DSP_SETTINGS), Is.EqualTo(56));
        }
        else
        {
            Assert.That(sizeof(X3DAUDIO_DSP_SETTINGS), Is.EqualTo(48));
        }
    }
}
