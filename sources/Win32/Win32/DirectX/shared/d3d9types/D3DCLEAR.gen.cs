// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3DCLEAR
{
    [NativeTypeName("#define D3DCLEAR_TARGET 0x00000001l")]
    public const int D3DCLEAR_TARGET = 0x00000001;

    [NativeTypeName("#define D3DCLEAR_ZBUFFER 0x00000002l")]
    public const int D3DCLEAR_ZBUFFER = 0x00000002;

    [NativeTypeName("#define D3DCLEAR_STENCIL 0x00000004l")]
    public const int D3DCLEAR_STENCIL = 0x00000004;
}
