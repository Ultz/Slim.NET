// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Win32;
using static Silk.NET.DirectX.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE;
using static Silk.NET.Win32.E;
using static Silk.NET.Win32.S;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    public static HRESULT D3DX12ParsePipelineStream(
        [NativeTypeName("const D3D12_PIPELINE_STATE_STREAM_DESC &")]
            in D3D12_PIPELINE_STATE_STREAM_DESC Desc,
        ID3DX12PipelineParserCallbacks pCallbacks
    )
    {
        if (pCallbacks.lpVtbl == null)
        {
            return E_INVALIDARG;
        }
        if (Desc.SizeInBytes == 0 || Desc.pPipelineStateSubobjectStream == null)
        {
            pCallbacks.ErrorBadInputParameter(1); // first parameter issue
            return E_INVALIDARG;
        }
        bool* SubobjectSeen = stackalloc bool[(int)(D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_MAX_VALID)];
        for (
            nuint CurOffset = 0, SizeOfSubobject = 0;
            CurOffset < Desc.SizeInBytes;
            CurOffset += SizeOfSubobject
        )
        {
            byte* pStream = (byte*)(Desc.pPipelineStateSubobjectStream) + CurOffset;
            D3D12_PIPELINE_STATE_SUBOBJECT_TYPE SubobjectType =
                *(D3D12_PIPELINE_STATE_SUBOBJECT_TYPE*)(pStream);
            if (
                (SubobjectType < 0)
                || (SubobjectType >= D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_MAX_VALID)
            )
            {
                pCallbacks.ErrorUnknownSubobject((uint)(SubobjectType));
                return E_INVALIDARG;
            }
            if (SubobjectSeen[(int)(D3DX12GetBaseSubobjectType(SubobjectType))])
            {
                pCallbacks.ErrorDuplicateSubobject(SubobjectType);
                return E_INVALIDARG; // disallow subobject duplicates in a stream
            }
            SubobjectSeen[(int)(SubobjectType)] = true;
            switch (SubobjectType)
            {
                case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_ROOT_SIGNATURE:
                {
                    pCallbacks.RootSignatureCb(
                        ((CD3DX12_PIPELINE_STATE_STREAM_ROOT_SIGNATURE*)(pStream))
                            ->Anonymous
                            .pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(CD3DX12_PIPELINE_STATE_STREAM_ROOT_SIGNATURE));
                    break;
                }
                case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_VS:
                {
                    pCallbacks.VSCb(
                        &((CD3DX12_PIPELINE_STATE_STREAM_VS*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(CD3DX12_PIPELINE_STATE_STREAM_VS));
                    break;
                }
                case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PS:
                {
                    pCallbacks.PSCb(
                        &((CD3DX12_PIPELINE_STATE_STREAM_PS*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(CD3DX12_PIPELINE_STATE_STREAM_PS));
                    break;
                }
                case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DS:
                {
                    pCallbacks.DSCb(
                        &((CD3DX12_PIPELINE_STATE_STREAM_DS*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(CD3DX12_PIPELINE_STATE_STREAM_DS));
                    break;
                }
                case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_HS:
                {
                    pCallbacks.HSCb(
                        &((CD3DX12_PIPELINE_STATE_STREAM_HS*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(CD3DX12_PIPELINE_STATE_STREAM_HS));
                    break;
                }
                case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_GS:
                {
                    pCallbacks.GSCb(
                        &((CD3DX12_PIPELINE_STATE_STREAM_GS*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(CD3DX12_PIPELINE_STATE_STREAM_GS));
                    break;
                }
                case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_CS:
                {
                    pCallbacks.CSCb(
                        &((CD3DX12_PIPELINE_STATE_STREAM_CS*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(CD3DX12_PIPELINE_STATE_STREAM_CS));
                    break;
                }
                case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_AS:
                {
                    pCallbacks.ASCb(
                        &((CD3DX12_PIPELINE_STATE_STREAM_AS*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(CD3DX12_PIPELINE_STATE_STREAM_AS));
                    break;
                }
                case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_MS:
                {
                    pCallbacks.MSCb(
                        &((CD3DX12_PIPELINE_STATE_STREAM_MS*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(CD3DX12_PIPELINE_STATE_STREAM_MS));
                    break;
                }
                case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_STREAM_OUTPUT:
                {
                    pCallbacks.StreamOutputCb(
                        &((CD3DX12_PIPELINE_STATE_STREAM_STREAM_OUTPUT*)(pStream))
                            ->Anonymous
                            .pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(CD3DX12_PIPELINE_STATE_STREAM_STREAM_OUTPUT));
                    break;
                }
                case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_BLEND:
                {
                    pCallbacks.BlendStateCb(
                        &((CD3DX12_PIPELINE_STATE_STREAM_BLEND_DESC*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(CD3DX12_PIPELINE_STATE_STREAM_BLEND_DESC));
                    break;
                }
                case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_SAMPLE_MASK:
                {
                    pCallbacks.SampleMaskCb(
                        ((CD3DX12_PIPELINE_STATE_STREAM_SAMPLE_MASK*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(CD3DX12_PIPELINE_STATE_STREAM_SAMPLE_MASK));
                    break;
                }
                case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RASTERIZER:
                {
                    pCallbacks.RasterizerStateCb(
                        &((CD3DX12_PIPELINE_STATE_STREAM_RASTERIZER*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(CD3DX12_PIPELINE_STATE_STREAM_RASTERIZER));
                    break;
                }
                case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RASTERIZER1:
                {
                    pCallbacks.RasterizerState1Cb(
                        &((CD3DX12_PIPELINE_STATE_STREAM_RASTERIZER1*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(CD3DX12_PIPELINE_STATE_STREAM_RASTERIZER1));
                    break;
                }
                case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RASTERIZER2:
                {
                    pCallbacks.RasterizerState2Cb(
                        &((CD3DX12_PIPELINE_STATE_STREAM_RASTERIZER2*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(CD3DX12_PIPELINE_STATE_STREAM_RASTERIZER2));
                    break;
                }
                case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL:
                {
                    pCallbacks.DepthStencilStateCb(
                        &((CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL*)(pStream))
                            ->Anonymous
                            .pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL));
                    break;
                }
                case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL1:
                {
                    pCallbacks.DepthStencilState1Cb(
                        &((CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL1*)(pStream))
                            ->Anonymous
                            .pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL1));
                    break;
                }
                case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL2:
                {
                    pCallbacks.DepthStencilState2Cb(
                        &((CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL2*)(pStream))
                            ->Anonymous
                            .pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL2));
                    break;
                }
                case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_INPUT_LAYOUT:
                {
                    pCallbacks.InputLayoutCb(
                        &((CD3DX12_PIPELINE_STATE_STREAM_INPUT_LAYOUT*)(pStream))
                            ->Anonymous
                            .pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(CD3DX12_PIPELINE_STATE_STREAM_INPUT_LAYOUT));
                    break;
                }
                case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_IB_STRIP_CUT_VALUE:
                {
                    pCallbacks.IBStripCutValueCb(
                        ((CD3DX12_PIPELINE_STATE_STREAM_IB_STRIP_CUT_VALUE*)(pStream))
                            ->Anonymous
                            .pssInner
                    );
                    SizeOfSubobject = (uint)(
                        sizeof(CD3DX12_PIPELINE_STATE_STREAM_IB_STRIP_CUT_VALUE)
                    );
                    break;
                }
                case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PRIMITIVE_TOPOLOGY:
                {
                    pCallbacks.PrimitiveTopologyTypeCb(
                        ((CD3DX12_PIPELINE_STATE_STREAM_PRIMITIVE_TOPOLOGY*)(pStream))
                            ->Anonymous
                            .pssInner
                    );
                    SizeOfSubobject = (uint)(
                        sizeof(CD3DX12_PIPELINE_STATE_STREAM_PRIMITIVE_TOPOLOGY)
                    );
                    break;
                }
                case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RENDER_TARGET_FORMATS:
                {
                    pCallbacks.RTVFormatsCb(
                        &((CD3DX12_PIPELINE_STATE_STREAM_RENDER_TARGET_FORMATS*)(pStream))
                            ->Anonymous
                            .pssInner
                    );
                    SizeOfSubobject = (uint)(
                        sizeof(CD3DX12_PIPELINE_STATE_STREAM_RENDER_TARGET_FORMATS)
                    );
                    break;
                }
                case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL_FORMAT:
                {
                    pCallbacks.DSVFormatCb(
                        ((CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL_FORMAT*)(pStream))
                            ->Anonymous
                            .pssInner
                    );
                    SizeOfSubobject = (uint)(
                        sizeof(CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL_FORMAT)
                    );
                    break;
                }
                case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_SAMPLE_DESC:
                {
                    pCallbacks.SampleDescCb(
                        &((CD3DX12_PIPELINE_STATE_STREAM_SAMPLE_DESC*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(CD3DX12_PIPELINE_STATE_STREAM_SAMPLE_DESC));
                    break;
                }
                case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_NODE_MASK:
                {
                    pCallbacks.NodeMaskCb(
                        ((CD3DX12_PIPELINE_STATE_STREAM_NODE_MASK*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(CD3DX12_PIPELINE_STATE_STREAM_NODE_MASK));
                    break;
                }
                case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_CACHED_PSO:
                {
                    pCallbacks.CachedPSOCb(
                        &((CD3DX12_PIPELINE_STATE_STREAM_CACHED_PSO*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(CD3DX12_PIPELINE_STATE_STREAM_CACHED_PSO));
                    break;
                }
                case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_FLAGS:
                {
                    pCallbacks.FlagsCb(
                        ((CD3DX12_PIPELINE_STATE_STREAM_FLAGS*)(pStream))->Anonymous.pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(CD3DX12_PIPELINE_STATE_STREAM_FLAGS));
                    break;
                }
                case D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_VIEW_INSTANCING:
                {
                    pCallbacks.ViewInstancingCb(
                        &((CD3DX12_PIPELINE_STATE_STREAM_VIEW_INSTANCING*)(pStream))
                            ->Anonymous
                            .pssInner
                    );
                    SizeOfSubobject = (uint)(sizeof(CD3DX12_PIPELINE_STATE_STREAM_VIEW_INSTANCING));
                    break;
                }
                default:
                {
                    pCallbacks.ErrorUnknownSubobject((uint)(SubobjectType));
                    return E_INVALIDARG;
                }
            }
        }
        return S_OK;
    }
}
