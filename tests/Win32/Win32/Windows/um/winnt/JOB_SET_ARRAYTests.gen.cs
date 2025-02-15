// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "JOB_SET_ARRAY"/> struct.</summary>
public static unsafe partial class JOB_SET_ARRAYTests
{
    /// <summary>Validates that the <see cref = "JOB_SET_ARRAY"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<JOB_SET_ARRAY>(), Is.EqualTo(sizeof(JOB_SET_ARRAY)));
    }

    /// <summary>Validates that the <see cref = "JOB_SET_ARRAY"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(JOB_SET_ARRAY).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "JOB_SET_ARRAY"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(JOB_SET_ARRAY), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(JOB_SET_ARRAY), Is.EqualTo(12));
        }
    }
}
