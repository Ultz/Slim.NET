// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_root_signature.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_DESCRIPTOR_RANGE
{
    public D3D12_DESCRIPTOR_RANGE(
        D3D12_DESCRIPTOR_RANGE_TYPE rangeType,
        uint numDescriptors,
        uint baseShaderRegister,
        uint registerSpace = 0,
        uint offsetInDescriptorsFromTableStart = (0xffffffff)
    )
    {
        Init(
            rangeType,
            numDescriptors,
            baseShaderRegister,
            registerSpace,
            offsetInDescriptorsFromTableStart
        );
    }

    public void Init(
        D3D12_DESCRIPTOR_RANGE_TYPE rangeType,
        uint numDescriptors,
        uint baseShaderRegister,
        uint registerSpace = 0,
        uint offsetInDescriptorsFromTableStart = (0xffffffff)
    )
    {
        Init(
            ref this,
            rangeType,
            numDescriptors,
            baseShaderRegister,
            registerSpace,
            offsetInDescriptorsFromTableStart
        );
    }

    public static void Init(
        [NativeTypeName("D3D12_DESCRIPTOR_RANGE &")] ref D3D12_DESCRIPTOR_RANGE range,
        D3D12_DESCRIPTOR_RANGE_TYPE rangeType,
        uint numDescriptors,
        uint baseShaderRegister,
        uint registerSpace = 0,
        uint offsetInDescriptorsFromTableStart = (0xffffffff)
    )
    {
        range.RangeType = rangeType;
        range.NumDescriptors = numDescriptors;
        range.BaseShaderRegister = baseShaderRegister;
        range.RegisterSpace = registerSpace;
        range.OffsetInDescriptorsFromTableStart = offsetInDescriptorsFromTableStart;
    }
}
