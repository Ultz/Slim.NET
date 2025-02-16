// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_barriers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using static Silk.NET.DirectX.D3D12_RESOURCE_BARRIER_FLAGS;
using static Silk.NET.DirectX.D3D12_RESOURCE_BARRIER_TYPE;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_RESOURCE_BARRIER.xml' path='doc/member[@name="D3D12_RESOURCE_BARRIER"]/*'/>
[NativeTypeName("struct CD3DX12_RESOURCE_BARRIER : D3D12_RESOURCE_BARRIER")]
[NativeInheritance("D3D12_RESOURCE_BARRIER")]
public unsafe partial struct D3D12_RESOURCE_BARRIER
{
    [return: NativeTypeName("CD3DX12_RESOURCE_BARRIER")]
    public static D3D12_RESOURCE_BARRIER InitAliasing(
        ID3D12Resource pResourceBefore,
        ID3D12Resource pResourceAfter
    )
    {
        Unsafe.SkipInit(out D3D12_RESOURCE_BARRIER result);
        result.Type = D3D12_RESOURCE_BARRIER_TYPE_ALIASING;
        result.Flags = D3D12_RESOURCE_BARRIER_FLAG_NONE;
        result.Aliasing.pResourceBefore = pResourceBefore;
        result.Aliasing.pResourceAfter = pResourceAfter;
        return result;
    }

    [return: NativeTypeName("CD3DX12_RESOURCE_BARRIER")]
    public static D3D12_RESOURCE_BARRIER InitTransition(
        ID3D12Resource pResource,
        D3D12_RESOURCE_STATES stateBefore,
        D3D12_RESOURCE_STATES stateAfter,
        uint subresource = (0xffffffff),
        D3D12_RESOURCE_BARRIER_FLAGS flags = D3D12_RESOURCE_BARRIER_FLAG_NONE
    )
    {
        Unsafe.SkipInit(out D3D12_RESOURCE_BARRIER result);
        result.Type = D3D12_RESOURCE_BARRIER_TYPE_TRANSITION;
        result.Flags = flags;
        result.Anonymous.Transition.pResource = pResource;
        result.Anonymous.Transition.StateBefore = stateBefore;
        result.Anonymous.Transition.StateAfter = stateAfter;
        result.Anonymous.Transition.Subresource = subresource;
        return result;
    }

    [return: NativeTypeName("CD3DX12_RESOURCE_BARRIER")]
    public static D3D12_RESOURCE_BARRIER InitUAV(ID3D12Resource pResource)
    {
        Unsafe.SkipInit(out D3D12_RESOURCE_BARRIER result);
        result.Type = D3D12_RESOURCE_BARRIER_TYPE_UAV;
        result.Flags = D3D12_RESOURCE_BARRIER_FLAG_NONE;
        result.Anonymous.UAV.pResource = pResource;
        return result;
    }
}
