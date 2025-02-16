// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using static Silk.NET.DirectX.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[StructLayout(LayoutKind.Explicit)]
public unsafe struct CD3DX12_PIPELINE_STATE_STREAM_ROOT_SIGNATURE
{
    [FieldOffset(0)]
    private readonly unsafe void* _Anonymous_e__Alignment;

    [FieldOffset(0)]
    public _Anonymous_e__Struct Anonymous;

    [UnscopedRef]
    public ref D3D12_PIPELINE_STATE_SUBOBJECT_TYPE pssType => ref Anonymous.pssType;

    [UnscopedRef]
    public ref ID3D12RootSignature pssInner => ref Anonymous.pssInner;

    public CD3DX12_PIPELINE_STATE_STREAM_ROOT_SIGNATURE()
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_ROOT_SIGNATURE;
        pssInner = default;
    }

    public CD3DX12_PIPELINE_STATE_STREAM_ROOT_SIGNATURE(
        [NativeTypeName("ID3D12RootSignature* const &")] in ID3D12RootSignature i
    )
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_ROOT_SIGNATURE;
        pssInner = i;
    }

    public static implicit operator CD3DX12_PIPELINE_STATE_STREAM_ROOT_SIGNATURE(
        in ID3D12RootSignature value
    ) => new CD3DX12_PIPELINE_STATE_STREAM_ROOT_SIGNATURE(value);

    public static implicit operator ID3D12RootSignature(
        in CD3DX12_PIPELINE_STATE_STREAM_ROOT_SIGNATURE value
    ) => value.pssInner;

    public struct _Anonymous_e__Struct
    {
        public D3D12_PIPELINE_STATE_SUBOBJECT_TYPE pssType;
        public ID3D12RootSignature pssInner;
    }
}
