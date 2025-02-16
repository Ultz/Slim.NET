// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Win32.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "ID3DDestructionNotifier"/> struct.</summary>
public static unsafe partial class ID3DDestructionNotifierTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ID3DDestructionNotifier"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ID3DDestructionNotifier).GUID, Is.EqualTo(IID_ID3DDestructionNotifier));
    }

    /// <summary>Validates that the <see cref = "ID3DDestructionNotifier"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ID3DDestructionNotifier>(),
            Is.EqualTo(sizeof(ID3DDestructionNotifier))
        );
    }

    /// <summary>Validates that the <see cref = "ID3DDestructionNotifier"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ID3DDestructionNotifier).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ID3DDestructionNotifier"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ID3DDestructionNotifier), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ID3DDestructionNotifier), Is.EqualTo(4));
        }
    }
}
