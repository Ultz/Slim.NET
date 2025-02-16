// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_root_signature.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using static Silk.NET.DirectX.D3D12_ROOT_DESCRIPTOR_FLAGS;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_ROOT_DESCRIPTOR1
{
    public D3D12_ROOT_DESCRIPTOR1(
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12_ROOT_DESCRIPTOR_FLAGS flags = D3D12_ROOT_DESCRIPTOR_FLAG_NONE
    )
    {
        Init(shaderRegister, registerSpace, flags);
    }

    public void Init(
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12_ROOT_DESCRIPTOR_FLAGS flags = D3D12_ROOT_DESCRIPTOR_FLAG_NONE
    )
    {
        Init(ref this, shaderRegister, registerSpace, flags);
    }

    public static void Init(
        [NativeTypeName("D3D12_ROOT_DESCRIPTOR1 &")] ref D3D12_ROOT_DESCRIPTOR1 table,
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12_ROOT_DESCRIPTOR_FLAGS flags = D3D12_ROOT_DESCRIPTOR_FLAG_NONE
    )
    {
        table.ShaderRegister = shaderRegister;
        table.RegisterSpace = registerSpace;
        table.Flags = flags;
    }
}
