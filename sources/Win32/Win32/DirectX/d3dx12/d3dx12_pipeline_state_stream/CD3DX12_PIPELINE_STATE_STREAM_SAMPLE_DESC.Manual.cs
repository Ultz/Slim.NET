// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using static Silk.NET.DirectX.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[StructLayout(LayoutKind.Explicit)]
public struct CD3DX12_PIPELINE_STATE_STREAM_SAMPLE_DESC
{
    [FieldOffset(0)]
    private readonly unsafe void* _Anonymous_e__Alignment;

    [FieldOffset(0)]
    public _Anonymous_e__Struct Anonymous;

    [UnscopedRef]
    public ref D3D12_PIPELINE_STATE_SUBOBJECT_TYPE pssType => ref Anonymous.pssType;

    [UnscopedRef]
    public ref DXGI_SAMPLE_DESC pssInner => ref Anonymous.pssInner;

    public CD3DX12_PIPELINE_STATE_STREAM_SAMPLE_DESC()
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_SAMPLE_DESC;
        pssInner = new DXGI_SAMPLE_DESC(1, 0);
    }

    public CD3DX12_PIPELINE_STATE_STREAM_SAMPLE_DESC(
        [NativeTypeName("DXGI_SAMPLE_DESC const &")] in DXGI_SAMPLE_DESC i
    )
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_SAMPLE_DESC;
        pssInner = i;
    }

    public static implicit operator CD3DX12_PIPELINE_STATE_STREAM_SAMPLE_DESC(
        in DXGI_SAMPLE_DESC value
    ) => new CD3DX12_PIPELINE_STATE_STREAM_SAMPLE_DESC(value);

    public static implicit operator DXGI_SAMPLE_DESC(
        in CD3DX12_PIPELINE_STATE_STREAM_SAMPLE_DESC value
    ) => value.pssInner;

    public struct _Anonymous_e__Struct
    {
        public D3D12_PIPELINE_STATE_SUBOBJECT_TYPE pssType;
        public DXGI_SAMPLE_DESC pssInner;
    }
}
