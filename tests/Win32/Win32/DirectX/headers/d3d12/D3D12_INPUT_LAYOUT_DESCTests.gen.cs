// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "D3D12_INPUT_LAYOUT_DESC"/> struct.</summary>
public static unsafe partial class D3D12_INPUT_LAYOUT_DESCTests
{
    /// <summary>Validates that the <see cref = "D3D12_INPUT_LAYOUT_DESC"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<D3D12_INPUT_LAYOUT_DESC>(),
            Is.EqualTo(sizeof(D3D12_INPUT_LAYOUT_DESC))
        );
    }

    /// <summary>Validates that the <see cref = "D3D12_INPUT_LAYOUT_DESC"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3D12_INPUT_LAYOUT_DESC).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "D3D12_INPUT_LAYOUT_DESC"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(D3D12_INPUT_LAYOUT_DESC), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(D3D12_INPUT_LAYOUT_DESC), Is.EqualTo(8));
        }
    }
}
