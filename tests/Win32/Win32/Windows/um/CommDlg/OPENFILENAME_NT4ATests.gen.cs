// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "OPENFILENAME_NT4A"/> struct.</summary>
public static unsafe partial class OPENFILENAME_NT4ATests
{
    /// <summary>Validates that the <see cref = "OPENFILENAME_NT4A"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<OPENFILENAME_NT4A>(), Is.EqualTo(sizeof(OPENFILENAME_NT4A)));
    }

    /// <summary>Validates that the <see cref = "OPENFILENAME_NT4A"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(OPENFILENAME_NT4A).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "OPENFILENAME_NT4A"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(OPENFILENAME_NT4A), Is.EqualTo(136));
        }
        else
        {
            Assert.That(sizeof(OPENFILENAME_NT4A), Is.EqualTo(76));
        }
    }
}
