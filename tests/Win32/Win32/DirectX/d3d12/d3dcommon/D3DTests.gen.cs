// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using NUnit.Framework;
using static Silk.NET.DirectX.D3D;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "D3D"/> class.</summary>
public static partial class D3DTests
{
    /// <summary>Validates that the value of the <see cref = "D3D_TEXTURE_LAYOUT_ROW_MAJOR"/> property is correct.</summary>

    [Test]
    public static void D3D_TEXTURE_LAYOUT_ROW_MAJORTest()
    {
        Assert.That(
            D3D_TEXTURE_LAYOUT_ROW_MAJOR,
            Is.EqualTo(
                new Guid(0xb5dc234f, 0x72bb, 0x4bec, 0x97, 0x05, 0x8c, 0xf2, 0x58, 0xdf, 0x6b, 0x6c)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D_TEXTURE_LAYOUT_64KB_STANDARD_SWIZZLE"/> property is correct.</summary>

    [Test]
    public static void D3D_TEXTURE_LAYOUT_64KB_STANDARD_SWIZZLETest()
    {
        Assert.That(
            D3D_TEXTURE_LAYOUT_64KB_STANDARD_SWIZZLE,
            Is.EqualTo(
                new Guid(0x4c0f29e3, 0x3f5f, 0x4d35, 0x84, 0xc9, 0xbc, 0x09, 0x83, 0xb6, 0x2c, 0x28)
            )
        );
    }
}
