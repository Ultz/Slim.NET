// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_root_signature.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_ROOT_DESCRIPTOR
{
    public D3D12_ROOT_DESCRIPTOR(uint shaderRegister, uint registerSpace = 0)
    {
        Init(shaderRegister, registerSpace);
    }

    public void Init(uint shaderRegister, uint registerSpace = 0)
    {
        Init(ref this, shaderRegister, registerSpace);
    }

    public static void Init(
        [NativeTypeName("D3D12_ROOT_DESCRIPTOR &")] ref D3D12_ROOT_DESCRIPTOR table,
        uint shaderRegister,
        uint registerSpace = 0
    )
    {
        table.ShaderRegister = shaderRegister;
        table.RegisterSpace = registerSpace;
    }
}
