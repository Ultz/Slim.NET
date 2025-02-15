// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "CABSTR"/> struct.</summary>
public static unsafe partial class CABSTRTests
{
    /// <summary>Validates that the <see cref = "CABSTR"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CABSTR>(), Is.EqualTo(sizeof(CABSTR)));
    }

    /// <summary>Validates that the <see cref = "CABSTR"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CABSTR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CABSTR"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CABSTR), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(CABSTR), Is.EqualTo(8));
        }
    }
}
