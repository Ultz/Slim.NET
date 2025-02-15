// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "IDMLDebugDevice"/> struct.</summary>
public static unsafe partial class IDMLDebugDeviceTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDMLDebugDevice"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDMLDebugDevice).GUID, Is.EqualTo(IID_IDMLDebugDevice));
    }

    /// <summary>Validates that the <see cref = "IDMLDebugDevice"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDMLDebugDevice>(), Is.EqualTo(sizeof(IDMLDebugDevice)));
    }

    /// <summary>Validates that the <see cref = "IDMLDebugDevice"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDMLDebugDevice).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDMLDebugDevice"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDMLDebugDevice), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDMLDebugDevice), Is.EqualTo(4));
        }
    }
}
