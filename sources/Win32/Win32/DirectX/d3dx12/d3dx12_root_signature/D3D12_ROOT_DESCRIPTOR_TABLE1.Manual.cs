// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_root_signature.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_ROOT_DESCRIPTOR_TABLE1
{
    public D3D12_ROOT_DESCRIPTOR_TABLE1(
        uint numDescriptorRanges,
        [NativeTypeName("const D3D12_DESCRIPTOR_RANGE1 *")]
            D3D12_DESCRIPTOR_RANGE1* _pDescriptorRanges
    )
    {
        Init(numDescriptorRanges, _pDescriptorRanges);
    }

    public void Init(
        uint numDescriptorRanges,
        [NativeTypeName("const D3D12_DESCRIPTOR_RANGE1 *")]
            D3D12_DESCRIPTOR_RANGE1* _pDescriptorRanges
    )
    {
        Init(ref this, numDescriptorRanges, _pDescriptorRanges);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void Init(
        uint numDescriptorRanges,
        [NativeTypeName("const D3D12_DESCRIPTOR_RANGE1 *")]
            Ref<D3D12_DESCRIPTOR_RANGE1> _pDescriptorRanges
    )
    {
        fixed (D3D12_DESCRIPTOR_RANGE1* __dsl__pDescriptorRanges = _pDescriptorRanges)
        {
            Init(numDescriptorRanges, __dsl__pDescriptorRanges);
        }
    }

    public static void Init(
        [NativeTypeName("D3D12_ROOT_DESCRIPTOR_TABLE1 &")]
            ref D3D12_ROOT_DESCRIPTOR_TABLE1 rootDescriptorTable,
        uint numDescriptorRanges,
        [NativeTypeName("const D3D12_DESCRIPTOR_RANGE1 *")]
            D3D12_DESCRIPTOR_RANGE1* _pDescriptorRanges
    )
    {
        rootDescriptorTable.NumDescriptorRanges = numDescriptorRanges;
        rootDescriptorTable.pDescriptorRanges = _pDescriptorRanges;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Init(
        [NativeTypeName("D3D12_ROOT_DESCRIPTOR_TABLE1 &")]
            ref D3D12_ROOT_DESCRIPTOR_TABLE1 rootDescriptorTable,
        uint numDescriptorRanges,
        [NativeTypeName("const D3D12_DESCRIPTOR_RANGE1 *")]
            Ref<D3D12_DESCRIPTOR_RANGE1> _pDescriptorRanges
    )
    {
        fixed (D3D12_DESCRIPTOR_RANGE1* __dsl__pDescriptorRanges = _pDescriptorRanges)
        {
            Init(ref rootDescriptorTable, numDescriptorRanges, __dsl__pDescriptorRanges);
        }
    }
}
