// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe struct CD3DX12_PIPELINE_MESH_STATE_STREAM
{
    public CD3DX12_PIPELINE_STATE_STREAM_FLAGS Flags;
    public CD3DX12_PIPELINE_STATE_STREAM_NODE_MASK NodeMask;
    public CD3DX12_PIPELINE_STATE_STREAM_ROOT_SIGNATURE pRootSignature;
    public CD3DX12_PIPELINE_STATE_STREAM_PS PS;
    public CD3DX12_PIPELINE_STATE_STREAM_AS AS;
    public CD3DX12_PIPELINE_STATE_STREAM_MS MS;
    public CD3DX12_PIPELINE_STATE_STREAM_BLEND_DESC BlendState;
    public CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL1 DepthStencilState;
    public CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL_FORMAT DSVFormat;
    public CD3DX12_PIPELINE_STATE_STREAM_RASTERIZER RasterizerState;
    public CD3DX12_PIPELINE_STATE_STREAM_RENDER_TARGET_FORMATS RTVFormats;
    public CD3DX12_PIPELINE_STATE_STREAM_SAMPLE_DESC SampleDesc;
    public CD3DX12_PIPELINE_STATE_STREAM_SAMPLE_MASK SampleMask;
    public CD3DX12_PIPELINE_STATE_STREAM_CACHED_PSO CachedPSO;
    public CD3DX12_PIPELINE_STATE_STREAM_VIEW_INSTANCING ViewInstancingDesc;

    public CD3DX12_PIPELINE_MESH_STATE_STREAM(
        [NativeTypeName("const D3DX12_MESH_SHADER_PIPELINE_STATE_DESC &")]
            in D3DX12_MESH_SHADER_PIPELINE_STATE_DESC Desc
    )
    {
        Flags = Desc.Flags;
        NodeMask = Desc.NodeMask;
        pRootSignature = Desc.pRootSignature;
        PS = Desc.PS;
        AS = Desc.AS;
        MS = Desc.MS;
        BlendState = Desc.BlendState;
        DepthStencilState = new D3D12_DEPTH_STENCIL_DESC1(Desc.DepthStencilState);
        DSVFormat = Desc.DSVFormat;
        RasterizerState = Desc.RasterizerState;
        fixed (DXGI_FORMAT* pFormats = &Desc.RTVFormats[0])
        {
            RTVFormats = new D3D12_RT_FORMAT_ARRAY(pFormats, Desc.NumRenderTargets);
        }
        SampleDesc = Desc.SampleDesc;
        SampleMask = Desc.SampleMask;
        CachedPSO = Desc.CachedPSO;
        ViewInstancingDesc = D3D12_VIEW_INSTANCING_DESC.DEFAULT;
    }

    public readonly D3DX12_MESH_SHADER_PIPELINE_STATE_DESC MeshShaderDescV0()
    {
        D3DX12_MESH_SHADER_PIPELINE_STATE_DESC D = new D3DX12_MESH_SHADER_PIPELINE_STATE_DESC
        {
            Flags = Flags,
            NodeMask = NodeMask,
            pRootSignature = pRootSignature,
            PS = PS,
            AS = AS,
            MS = MS,
            BlendState = BlendState,
            DepthStencilState = (D3D12_DEPTH_STENCIL_DESC)(DepthStencilState.pssInner),
            DSVFormat = DSVFormat,
            RasterizerState = RasterizerState,
            NumRenderTargets = RTVFormats.pssInner.NumRenderTargets,
            SampleDesc = SampleDesc,
            SampleMask = SampleMask,
            CachedPSO = CachedPSO,
        };
        fixed (DXGI_FORMAT* pFormat = &RTVFormats.pssInner.RTFormats[0])
        {
            NativeMemory.Copy(pFormat, &D.RTVFormats[0], 8 * sizeof(DXGI_FORMAT));
        }
        return D;
    }
}
