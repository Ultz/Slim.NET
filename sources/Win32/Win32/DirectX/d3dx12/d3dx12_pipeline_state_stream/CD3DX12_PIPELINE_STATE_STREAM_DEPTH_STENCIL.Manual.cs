// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using static Silk.NET.DirectX.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[StructLayout(LayoutKind.Explicit)]
public struct CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL
{
    [FieldOffset(0)]
    private readonly unsafe void* _Anonymous_e__Alignment;

    [FieldOffset(0)]
    public _Anonymous_e__Struct Anonymous;

    [UnscopedRef]
    public ref D3D12_PIPELINE_STATE_SUBOBJECT_TYPE pssType => ref Anonymous.pssType;

    [UnscopedRef]
    public ref D3D12_DEPTH_STENCIL_DESC pssInner => ref Anonymous.pssInner;

    public CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL()
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL;
        pssInner = D3D12_DEPTH_STENCIL_DESC.DEFAULT;
    }

    public CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL(
        [NativeTypeName("D3D12_DEPTH_STENCIL_DESC const &")] in D3D12_DEPTH_STENCIL_DESC i
    )
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL;
        pssInner = i;
    }

    public static implicit operator CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL(
        in D3D12_DEPTH_STENCIL_DESC value
    ) => new CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL(value);

    public static implicit operator D3D12_DEPTH_STENCIL_DESC(
        in CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL value
    ) => value.pssInner;

    public struct _Anonymous_e__Struct
    {
        public D3D12_PIPELINE_STATE_SUBOBJECT_TYPE pssType;
        public D3D12_DEPTH_STENCIL_DESC pssInner;
    }
}
