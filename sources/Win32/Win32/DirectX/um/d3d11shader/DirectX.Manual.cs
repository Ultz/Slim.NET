// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    public static int D3D11_SHVER_GET_MAJOR(int _Version) => (_Version >> 4) & 0xF;

    public static int D3D11_SHVER_GET_MINOR(int _Version) => (_Version >> 0) & 0xF;

    public static D3D11_SHADER_VERSION_TYPE D3D11_SHVER_GET_TYPE(int _Version) =>
        (D3D11_SHADER_VERSION_TYPE)((_Version >> 16) & 0xFFFF);
}
