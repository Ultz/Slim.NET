// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "LOAD_DLL_DEBUG_INFO"/> struct.</summary>
public static unsafe partial class LOAD_DLL_DEBUG_INFOTests
{
    /// <summary>Validates that the <see cref = "LOAD_DLL_DEBUG_INFO"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<LOAD_DLL_DEBUG_INFO>(), Is.EqualTo(sizeof(LOAD_DLL_DEBUG_INFO)));
    }

    /// <summary>Validates that the <see cref = "LOAD_DLL_DEBUG_INFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(LOAD_DLL_DEBUG_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "LOAD_DLL_DEBUG_INFO"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(LOAD_DLL_DEBUG_INFO), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(LOAD_DLL_DEBUG_INFO), Is.EqualTo(24));
        }
    }
}
