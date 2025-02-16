// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_barriers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using static Silk.NET.DirectX.D3D12_TEXTURE_BARRIER_FLAGS;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_TEXTURE_BARRIER
{
    public D3D12_TEXTURE_BARRIER(
        D3D12_BARRIER_SYNC syncBefore,
        D3D12_BARRIER_SYNC syncAfter,
        D3D12_BARRIER_ACCESS accessBefore,
        D3D12_BARRIER_ACCESS accessAfter,
        D3D12_BARRIER_LAYOUT layoutBefore,
        D3D12_BARRIER_LAYOUT layoutAfter,
        ID3D12Resource pRes,
        [NativeTypeName("const D3D12_BARRIER_SUBRESOURCE_RANGE &")]
            in D3D12_BARRIER_SUBRESOURCE_RANGE subresources,
        D3D12_TEXTURE_BARRIER_FLAGS flag = D3D12_TEXTURE_BARRIER_FLAG_NONE
    )
    {
        SyncBefore = syncBefore;
        SyncAfter = syncAfter;
        AccessBefore = accessBefore;
        AccessAfter = accessAfter;
        LayoutBefore = layoutBefore;
        LayoutAfter = layoutAfter;
        pResource = pRes;
        Subresources = subresources;
        Flags = flag;
    }
}
