// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System.Runtime.CompilerServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks"]/*'/>
public unsafe partial struct ID3DX12PipelineParserCallbacks : ID3DX12PipelineParserCallbacks.Native.Interface, INativeInterface
{
    public Native* lpVtbl;
    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks"]/*'/>
    public unsafe partial struct Native : ID3DX12PipelineParserCallbacks.Native.Interface
    {
        public void** lpVtbl;
        public interface Interface
        {
            [VtblIndex(13)]
            void ASCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* AS);
            [VtblIndex(13)]
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            void ASCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] Ref<D3D12_SHADER_BYTECODE> AS);
            [VtblIndex(15)]
            void BlendStateCb([NativeTypeName("const D3D12_BLEND_DESC &")] D3D12_BLEND_DESC* BlendState);
            [VtblIndex(15)]
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            void BlendStateCb([NativeTypeName("const D3D12_BLEND_DESC &")] Ref<D3D12_BLEND_DESC> BlendState);
            [VtblIndex(27)]
            void CachedPSOCb([NativeTypeName("const D3D12_CACHED_PIPELINE_STATE &")] D3D12_CACHED_PIPELINE_STATE* CachedPSO);
            [VtblIndex(27)]
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            void CachedPSOCb([NativeTypeName("const D3D12_CACHED_PIPELINE_STATE &")] Ref<D3D12_CACHED_PIPELINE_STATE> CachedPSO);
            [VtblIndex(12)]
            void CSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* CS);
            [VtblIndex(12)]
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            void CSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] Ref<D3D12_SHADER_BYTECODE> CS);
            [VtblIndex(17)]
            void DepthStencilState1Cb([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC1 &")] D3D12_DEPTH_STENCIL_DESC1* DepthStencilState);
            [VtblIndex(17)]
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            void DepthStencilState1Cb([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC1 &")] Ref<D3D12_DEPTH_STENCIL_DESC1> DepthStencilState);
            [VtblIndex(18)]
            void DepthStencilState2Cb([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC2 &")] D3D12_DEPTH_STENCIL_DESC2* DepthStencilState);
            [VtblIndex(18)]
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            void DepthStencilState2Cb([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC2 &")] Ref<D3D12_DEPTH_STENCIL_DESC2> DepthStencilState);
            [VtblIndex(16)]
            void DepthStencilStateCb([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC &")] D3D12_DEPTH_STENCIL_DESC* DepthStencilState);
            [VtblIndex(16)]
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            void DepthStencilStateCb([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC &")] Ref<D3D12_DEPTH_STENCIL_DESC> DepthStencilState);
            [VtblIndex(31)]
            void Dispose();
            [VtblIndex(10)]
            void DSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* DS);
            [VtblIndex(10)]
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            void DSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] Ref<D3D12_SHADER_BYTECODE> DS);
            [VtblIndex(19)]
            void DSVFormatCb(DXGI_FORMAT DSVFormat);
            [VtblIndex(28)]
            void ErrorBadInputParameter(uint ParameterIndex);
            [VtblIndex(29)]
            void ErrorDuplicateSubobject(D3D12_PIPELINE_STATE_SUBOBJECT_TYPE DuplicateType);
            [VtblIndex(30)]
            void ErrorUnknownSubobject(uint UnknownTypeValue);
            [VtblIndex(0)]
            void FlagsCb(D3D12_PIPELINE_STATE_FLAGS Flags);
            [VtblIndex(7)]
            void GSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* GS);
            [VtblIndex(7)]
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            void GSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] Ref<D3D12_SHADER_BYTECODE> GS);
            [VtblIndex(9)]
            void HSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* HS);
            [VtblIndex(9)]
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            void HSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] Ref<D3D12_SHADER_BYTECODE> HS);
            [VtblIndex(4)]
            void IBStripCutValueCb(D3D12_INDEX_BUFFER_STRIP_CUT_VALUE IBStripCutValue);
            [VtblIndex(3)]
            void InputLayoutCb([NativeTypeName("const D3D12_INPUT_LAYOUT_DESC &")] D3D12_INPUT_LAYOUT_DESC* InputLayout);
            [VtblIndex(3)]
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            void InputLayoutCb([NativeTypeName("const D3D12_INPUT_LAYOUT_DESC &")] Ref<D3D12_INPUT_LAYOUT_DESC> InputLayout);
            [VtblIndex(14)]
            void MSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* MS);
            [VtblIndex(14)]
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            void MSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] Ref<D3D12_SHADER_BYTECODE> MS);
            [VtblIndex(1)]
            void NodeMaskCb(uint NodeMask);
            [VtblIndex(5)]
            void PrimitiveTopologyTypeCb(D3D12_PRIMITIVE_TOPOLOGY_TYPE PrimitiveTopologyType);
            [VtblIndex(11)]
            void PSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* PS);
            [VtblIndex(11)]
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            void PSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] Ref<D3D12_SHADER_BYTECODE> PS);
            [VtblIndex(21)]
            void RasterizerState1Cb([NativeTypeName("const D3D12_RASTERIZER_DESC1 &")] D3D12_RASTERIZER_DESC1* RasterizerState);
            [VtblIndex(21)]
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            void RasterizerState1Cb([NativeTypeName("const D3D12_RASTERIZER_DESC1 &")] Ref<D3D12_RASTERIZER_DESC1> RasterizerState);
            [VtblIndex(22)]
            void RasterizerState2Cb([NativeTypeName("const D3D12_RASTERIZER_DESC2 &")] D3D12_RASTERIZER_DESC2* RasterizerState);
            [VtblIndex(22)]
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            void RasterizerState2Cb([NativeTypeName("const D3D12_RASTERIZER_DESC2 &")] Ref<D3D12_RASTERIZER_DESC2> RasterizerState);
            [VtblIndex(20)]
            void RasterizerStateCb([NativeTypeName("const D3D12_RASTERIZER_DESC &")] D3D12_RASTERIZER_DESC* RasterizerState);
            [VtblIndex(20)]
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            void RasterizerStateCb([NativeTypeName("const D3D12_RASTERIZER_DESC &")] Ref<D3D12_RASTERIZER_DESC> RasterizerState);
            [VtblIndex(2)]
            void RootSignatureCb(ID3D12RootSignature pRootSignature);
            [VtblIndex(23)]
            void RTVFormatsCb([NativeTypeName("const D3D12_RT_FORMAT_ARRAY &")] D3D12_RT_FORMAT_ARRAY* RTVFormats);
            [VtblIndex(23)]
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            void RTVFormatsCb([NativeTypeName("const D3D12_RT_FORMAT_ARRAY &")] Ref<D3D12_RT_FORMAT_ARRAY> RTVFormats);
            [VtblIndex(24)]
            void SampleDescCb([NativeTypeName("const DXGI_SAMPLE_DESC &")] DXGI_SAMPLE_DESC* SampleDesc);
            [VtblIndex(24)]
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            void SampleDescCb([NativeTypeName("const DXGI_SAMPLE_DESC &")] Ref<DXGI_SAMPLE_DESC> SampleDesc);
            [VtblIndex(25)]
            void SampleMaskCb(uint SampleMask);
            [VtblIndex(8)]
            void StreamOutputCb([NativeTypeName("const D3D12_STREAM_OUTPUT_DESC &")] D3D12_STREAM_OUTPUT_DESC* StreamOutput);
            [VtblIndex(8)]
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            void StreamOutputCb([NativeTypeName("const D3D12_STREAM_OUTPUT_DESC &")] Ref<D3D12_STREAM_OUTPUT_DESC> StreamOutput);
            [VtblIndex(26)]
            void ViewInstancingCb([NativeTypeName("const D3D12_VIEW_INSTANCING_DESC &")] D3D12_VIEW_INSTANCING_DESC* ViewInstancingDesc);
            [VtblIndex(26)]
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            void ViewInstancingCb([NativeTypeName("const D3D12_VIEW_INSTANCING_DESC &")] Ref<D3D12_VIEW_INSTANCING_DESC> ViewInstancingDesc);
            [VtblIndex(6)]
            void VSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* VS);
            [VtblIndex(6)]
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            void VSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] Ref<D3D12_SHADER_BYTECODE> VS);
        }

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("void (D3D12_PIPELINE_STATE_FLAGS)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_PIPELINE_STATE_FLAGS, void> FlagsCb;
            [NativeTypeName("void (UINT)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, void> NodeMaskCb;
            [NativeTypeName("void (ID3D12RootSignature *)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, ID3D12RootSignature.Native*, void> RootSignatureCb;
            [NativeTypeName("void (const D3D12_INPUT_LAYOUT_DESC &)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_INPUT_LAYOUT_DESC*, void> InputLayoutCb;
            [NativeTypeName("void (D3D12_INDEX_BUFFER_STRIP_CUT_VALUE)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_INDEX_BUFFER_STRIP_CUT_VALUE, void> IBStripCutValueCb;
            [NativeTypeName("void (D3D12_PRIMITIVE_TOPOLOGY_TYPE)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_PRIMITIVE_TOPOLOGY_TYPE, void> PrimitiveTopologyTypeCb;
            [NativeTypeName("void (const D3D12_SHADER_BYTECODE &)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_SHADER_BYTECODE*, void> VSCb;
            [NativeTypeName("void (const D3D12_SHADER_BYTECODE &)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_SHADER_BYTECODE*, void> GSCb;
            [NativeTypeName("void (const D3D12_STREAM_OUTPUT_DESC &)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_STREAM_OUTPUT_DESC*, void> StreamOutputCb;
            [NativeTypeName("void (const D3D12_SHADER_BYTECODE &)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_SHADER_BYTECODE*, void> HSCb;
            [NativeTypeName("void (const D3D12_SHADER_BYTECODE &)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_SHADER_BYTECODE*, void> DSCb;
            [NativeTypeName("void (const D3D12_SHADER_BYTECODE &)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_SHADER_BYTECODE*, void> PSCb;
            [NativeTypeName("void (const D3D12_SHADER_BYTECODE &)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_SHADER_BYTECODE*, void> CSCb;
            [NativeTypeName("void (const D3D12_SHADER_BYTECODE &)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_SHADER_BYTECODE*, void> ASCb;
            [NativeTypeName("void (const D3D12_SHADER_BYTECODE &)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_SHADER_BYTECODE*, void> MSCb;
            [NativeTypeName("void (const D3D12_BLEND_DESC &)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_BLEND_DESC*, void> BlendStateCb;
            [NativeTypeName("void (const D3D12_DEPTH_STENCIL_DESC &)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_DEPTH_STENCIL_DESC*, void> DepthStencilStateCb;
            [NativeTypeName("void (const D3D12_DEPTH_STENCIL_DESC1 &)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_DEPTH_STENCIL_DESC1*, void> DepthStencilState1Cb;
            [NativeTypeName("void (const D3D12_DEPTH_STENCIL_DESC2 &)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_DEPTH_STENCIL_DESC2*, void> DepthStencilState2Cb;
            [NativeTypeName("void (DXGI_FORMAT)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, DXGI_FORMAT, void> DSVFormatCb;
            [NativeTypeName("void (const D3D12_RASTERIZER_DESC &)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_RASTERIZER_DESC*, void> RasterizerStateCb;
            [NativeTypeName("void (const D3D12_RASTERIZER_DESC1 &)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_RASTERIZER_DESC1*, void> RasterizerState1Cb;
            [NativeTypeName("void (const D3D12_RASTERIZER_DESC2 &)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_RASTERIZER_DESC2*, void> RasterizerState2Cb;
            [NativeTypeName("void (const D3D12_RT_FORMAT_ARRAY &)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_RT_FORMAT_ARRAY*, void> RTVFormatsCb;
            [NativeTypeName("void (const DXGI_SAMPLE_DESC &)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, DXGI_SAMPLE_DESC*, void> SampleDescCb;
            [NativeTypeName("void (UINT)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, void> SampleMaskCb;
            [NativeTypeName("void (const D3D12_VIEW_INSTANCING_DESC &)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_VIEW_INSTANCING_DESC*, void> ViewInstancingCb;
            [NativeTypeName("void (const D3D12_CACHED_PIPELINE_STATE &)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_CACHED_PIPELINE_STATE*, void> CachedPSOCb;
            [NativeTypeName("void (UINT)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, void> ErrorBadInputParameter;
            [NativeTypeName("void (D3D12_PIPELINE_STATE_SUBOBJECT_TYPE)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_PIPELINE_STATE_SUBOBJECT_TYPE, void> ErrorDuplicateSubobject;
            [NativeTypeName("void (UINT)")]
            public delegate* unmanaged[MemberFunction]<TSelf*, uint, void> ErrorUnknownSubobject;
            [NativeTypeName("void () noexcept")]
            public delegate* unmanaged[MemberFunction]<TSelf*, void> Dispose;
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.ASCb"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public void ASCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* AS)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, D3D12_SHADER_BYTECODE*, void> )(lpVtbl[13]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), AS);
        }

        [VtblIndex(13)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void ASCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] Ref<D3D12_SHADER_BYTECODE> AS)
        {
            fixed (D3D12_SHADER_BYTECODE* __dsl_AS = AS)
            {
                ASCb(__dsl_AS);
            }
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.BlendStateCb"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public void BlendStateCb([NativeTypeName("const D3D12_BLEND_DESC &")] D3D12_BLEND_DESC* BlendState)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, D3D12_BLEND_DESC*, void> )(lpVtbl[15]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), BlendState);
        }

        [VtblIndex(15)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void BlendStateCb([NativeTypeName("const D3D12_BLEND_DESC &")] Ref<D3D12_BLEND_DESC> BlendState)
        {
            fixed (D3D12_BLEND_DESC* __dsl_BlendState = BlendState)
            {
                BlendStateCb(__dsl_BlendState);
            }
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.CachedPSOCb"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public void CachedPSOCb([NativeTypeName("const D3D12_CACHED_PIPELINE_STATE &")] D3D12_CACHED_PIPELINE_STATE* CachedPSO)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, D3D12_CACHED_PIPELINE_STATE*, void> )(lpVtbl[27]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), CachedPSO);
        }

        [VtblIndex(27)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void CachedPSOCb([NativeTypeName("const D3D12_CACHED_PIPELINE_STATE &")] Ref<D3D12_CACHED_PIPELINE_STATE> CachedPSO)
        {
            fixed (D3D12_CACHED_PIPELINE_STATE* __dsl_CachedPSO = CachedPSO)
            {
                CachedPSOCb(__dsl_CachedPSO);
            }
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.CSCb"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public void CSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* CS)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, D3D12_SHADER_BYTECODE*, void> )(lpVtbl[12]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), CS);
        }

        [VtblIndex(12)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void CSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] Ref<D3D12_SHADER_BYTECODE> CS)
        {
            fixed (D3D12_SHADER_BYTECODE* __dsl_CS = CS)
            {
                CSCb(__dsl_CS);
            }
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.DepthStencilState1Cb"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public void DepthStencilState1Cb([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC1 &")] D3D12_DEPTH_STENCIL_DESC1* DepthStencilState)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, D3D12_DEPTH_STENCIL_DESC1*, void> )(lpVtbl[17]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), DepthStencilState);
        }

        [VtblIndex(17)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void DepthStencilState1Cb([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC1 &")] Ref<D3D12_DEPTH_STENCIL_DESC1> DepthStencilState)
        {
            fixed (D3D12_DEPTH_STENCIL_DESC1* __dsl_DepthStencilState = DepthStencilState)
            {
                DepthStencilState1Cb(__dsl_DepthStencilState);
            }
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.DepthStencilState2Cb"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public void DepthStencilState2Cb([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC2 &")] D3D12_DEPTH_STENCIL_DESC2* DepthStencilState)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, D3D12_DEPTH_STENCIL_DESC2*, void> )(lpVtbl[18]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), DepthStencilState);
        }

        [VtblIndex(18)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void DepthStencilState2Cb([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC2 &")] Ref<D3D12_DEPTH_STENCIL_DESC2> DepthStencilState)
        {
            fixed (D3D12_DEPTH_STENCIL_DESC2* __dsl_DepthStencilState = DepthStencilState)
            {
                DepthStencilState2Cb(__dsl_DepthStencilState);
            }
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.DepthStencilStateCb"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public void DepthStencilStateCb([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC &")] D3D12_DEPTH_STENCIL_DESC* DepthStencilState)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, D3D12_DEPTH_STENCIL_DESC*, void> )(lpVtbl[16]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), DepthStencilState);
        }

        [VtblIndex(16)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void DepthStencilStateCb([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC &")] Ref<D3D12_DEPTH_STENCIL_DESC> DepthStencilState)
        {
            fixed (D3D12_DEPTH_STENCIL_DESC* __dsl_DepthStencilState = DepthStencilState)
            {
                DepthStencilStateCb(__dsl_DepthStencilState);
            }
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.Dispose"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public void Dispose()
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, void> )(lpVtbl[31]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.DSCb"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public void DSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* DS)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, D3D12_SHADER_BYTECODE*, void> )(lpVtbl[10]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), DS);
        }

        [VtblIndex(10)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void DSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] Ref<D3D12_SHADER_BYTECODE> DS)
        {
            fixed (D3D12_SHADER_BYTECODE* __dsl_DS = DS)
            {
                DSCb(__dsl_DS);
            }
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.DSVFormatCb"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public void DSVFormatCb(DXGI_FORMAT DSVFormat)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, DXGI_FORMAT, void> )(lpVtbl[19]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), DSVFormat);
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.ErrorBadInputParameter"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public void ErrorBadInputParameter(uint ParameterIndex)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, uint, void> )(lpVtbl[28]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), ParameterIndex);
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.ErrorDuplicateSubobject"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public void ErrorDuplicateSubobject(D3D12_PIPELINE_STATE_SUBOBJECT_TYPE DuplicateType)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, D3D12_PIPELINE_STATE_SUBOBJECT_TYPE, void> )(lpVtbl[29]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), DuplicateType);
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.ErrorUnknownSubobject"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public void ErrorUnknownSubobject(uint UnknownTypeValue)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, uint, void> )(lpVtbl[30]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), UnknownTypeValue);
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.FlagsCb"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public void FlagsCb(D3D12_PIPELINE_STATE_FLAGS Flags)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, D3D12_PIPELINE_STATE_FLAGS, void> )(lpVtbl[0]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), Flags);
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.GSCb"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void GSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* GS)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, D3D12_SHADER_BYTECODE*, void> )(lpVtbl[7]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), GS);
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void GSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] Ref<D3D12_SHADER_BYTECODE> GS)
        {
            fixed (D3D12_SHADER_BYTECODE* __dsl_GS = GS)
            {
                GSCb(__dsl_GS);
            }
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.HSCb"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public void HSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* HS)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, D3D12_SHADER_BYTECODE*, void> )(lpVtbl[9]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), HS);
        }

        [VtblIndex(9)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void HSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] Ref<D3D12_SHADER_BYTECODE> HS)
        {
            fixed (D3D12_SHADER_BYTECODE* __dsl_HS = HS)
            {
                HSCb(__dsl_HS);
            }
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.IBStripCutValueCb"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void IBStripCutValueCb(D3D12_INDEX_BUFFER_STRIP_CUT_VALUE IBStripCutValue)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, D3D12_INDEX_BUFFER_STRIP_CUT_VALUE, void> )(lpVtbl[4]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), IBStripCutValue);
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.InputLayoutCb"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void InputLayoutCb([NativeTypeName("const D3D12_INPUT_LAYOUT_DESC &")] D3D12_INPUT_LAYOUT_DESC* InputLayout)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, D3D12_INPUT_LAYOUT_DESC*, void> )(lpVtbl[3]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), InputLayout);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void InputLayoutCb([NativeTypeName("const D3D12_INPUT_LAYOUT_DESC &")] Ref<D3D12_INPUT_LAYOUT_DESC> InputLayout)
        {
            fixed (D3D12_INPUT_LAYOUT_DESC* __dsl_InputLayout = InputLayout)
            {
                InputLayoutCb(__dsl_InputLayout);
            }
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.MSCb"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public void MSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* MS)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, D3D12_SHADER_BYTECODE*, void> )(lpVtbl[14]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), MS);
        }

        [VtblIndex(14)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void MSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] Ref<D3D12_SHADER_BYTECODE> MS)
        {
            fixed (D3D12_SHADER_BYTECODE* __dsl_MS = MS)
            {
                MSCb(__dsl_MS);
            }
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.NodeMaskCb"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public void NodeMaskCb(uint NodeMask)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, uint, void> )(lpVtbl[1]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), NodeMask);
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.PrimitiveTopologyTypeCb"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void PrimitiveTopologyTypeCb(D3D12_PRIMITIVE_TOPOLOGY_TYPE PrimitiveTopologyType)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, D3D12_PRIMITIVE_TOPOLOGY_TYPE, void> )(lpVtbl[5]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), PrimitiveTopologyType);
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.PSCb"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public void PSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* PS)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, D3D12_SHADER_BYTECODE*, void> )(lpVtbl[11]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), PS);
        }

        [VtblIndex(11)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void PSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] Ref<D3D12_SHADER_BYTECODE> PS)
        {
            fixed (D3D12_SHADER_BYTECODE* __dsl_PS = PS)
            {
                PSCb(__dsl_PS);
            }
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.RasterizerState1Cb"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public void RasterizerState1Cb([NativeTypeName("const D3D12_RASTERIZER_DESC1 &")] D3D12_RASTERIZER_DESC1* RasterizerState)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, D3D12_RASTERIZER_DESC1*, void> )(lpVtbl[21]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), RasterizerState);
        }

        [VtblIndex(21)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void RasterizerState1Cb([NativeTypeName("const D3D12_RASTERIZER_DESC1 &")] Ref<D3D12_RASTERIZER_DESC1> RasterizerState)
        {
            fixed (D3D12_RASTERIZER_DESC1* __dsl_RasterizerState = RasterizerState)
            {
                RasterizerState1Cb(__dsl_RasterizerState);
            }
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.RasterizerState2Cb"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public void RasterizerState2Cb([NativeTypeName("const D3D12_RASTERIZER_DESC2 &")] D3D12_RASTERIZER_DESC2* RasterizerState)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, D3D12_RASTERIZER_DESC2*, void> )(lpVtbl[22]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), RasterizerState);
        }

        [VtblIndex(22)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void RasterizerState2Cb([NativeTypeName("const D3D12_RASTERIZER_DESC2 &")] Ref<D3D12_RASTERIZER_DESC2> RasterizerState)
        {
            fixed (D3D12_RASTERIZER_DESC2* __dsl_RasterizerState = RasterizerState)
            {
                RasterizerState2Cb(__dsl_RasterizerState);
            }
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.RasterizerStateCb"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public void RasterizerStateCb([NativeTypeName("const D3D12_RASTERIZER_DESC &")] D3D12_RASTERIZER_DESC* RasterizerState)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, D3D12_RASTERIZER_DESC*, void> )(lpVtbl[20]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), RasterizerState);
        }

        [VtblIndex(20)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void RasterizerStateCb([NativeTypeName("const D3D12_RASTERIZER_DESC &")] Ref<D3D12_RASTERIZER_DESC> RasterizerState)
        {
            fixed (D3D12_RASTERIZER_DESC* __dsl_RasterizerState = RasterizerState)
            {
                RasterizerStateCb(__dsl_RasterizerState);
            }
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.RootSignatureCb"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public void RootSignatureCb(ID3D12RootSignature pRootSignature)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, ID3D12RootSignature.Native*, void> )(lpVtbl[2]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), pRootSignature.lpVtbl);
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.RTVFormatsCb"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public void RTVFormatsCb([NativeTypeName("const D3D12_RT_FORMAT_ARRAY &")] D3D12_RT_FORMAT_ARRAY* RTVFormats)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, D3D12_RT_FORMAT_ARRAY*, void> )(lpVtbl[23]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), RTVFormats);
        }

        [VtblIndex(23)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void RTVFormatsCb([NativeTypeName("const D3D12_RT_FORMAT_ARRAY &")] Ref<D3D12_RT_FORMAT_ARRAY> RTVFormats)
        {
            fixed (D3D12_RT_FORMAT_ARRAY* __dsl_RTVFormats = RTVFormats)
            {
                RTVFormatsCb(__dsl_RTVFormats);
            }
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.SampleDescCb"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public void SampleDescCb([NativeTypeName("const DXGI_SAMPLE_DESC &")] DXGI_SAMPLE_DESC* SampleDesc)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, DXGI_SAMPLE_DESC*, void> )(lpVtbl[24]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), SampleDesc);
        }

        [VtblIndex(24)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void SampleDescCb([NativeTypeName("const DXGI_SAMPLE_DESC &")] Ref<DXGI_SAMPLE_DESC> SampleDesc)
        {
            fixed (DXGI_SAMPLE_DESC* __dsl_SampleDesc = SampleDesc)
            {
                SampleDescCb(__dsl_SampleDesc);
            }
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.SampleMaskCb"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public void SampleMaskCb(uint SampleMask)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, uint, void> )(lpVtbl[25]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), SampleMask);
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.StreamOutputCb"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void StreamOutputCb([NativeTypeName("const D3D12_STREAM_OUTPUT_DESC &")] D3D12_STREAM_OUTPUT_DESC* StreamOutput)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, D3D12_STREAM_OUTPUT_DESC*, void> )(lpVtbl[8]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), StreamOutput);
        }

        [VtblIndex(8)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void StreamOutputCb([NativeTypeName("const D3D12_STREAM_OUTPUT_DESC &")] Ref<D3D12_STREAM_OUTPUT_DESC> StreamOutput)
        {
            fixed (D3D12_STREAM_OUTPUT_DESC* __dsl_StreamOutput = StreamOutput)
            {
                StreamOutputCb(__dsl_StreamOutput);
            }
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.ViewInstancingCb"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public void ViewInstancingCb([NativeTypeName("const D3D12_VIEW_INSTANCING_DESC &")] D3D12_VIEW_INSTANCING_DESC* ViewInstancingDesc)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, D3D12_VIEW_INSTANCING_DESC*, void> )(lpVtbl[26]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), ViewInstancingDesc);
        }

        [VtblIndex(26)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void ViewInstancingCb([NativeTypeName("const D3D12_VIEW_INSTANCING_DESC &")] Ref<D3D12_VIEW_INSTANCING_DESC> ViewInstancingDesc)
        {
            fixed (D3D12_VIEW_INSTANCING_DESC* __dsl_ViewInstancingDesc = ViewInstancingDesc)
            {
                ViewInstancingCb(__dsl_ViewInstancingDesc);
            }
        }

        /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.VSCb"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public void VSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* VS)
        {
            ((delegate* unmanaged[MemberFunction]<ID3DX12PipelineParserCallbacks.Native*, D3D12_SHADER_BYTECODE*, void> )(lpVtbl[6]))((ID3DX12PipelineParserCallbacks.Native*)Unsafe.AsPointer(ref this), VS);
        }

        [VtblIndex(6)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void VSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] Ref<D3D12_SHADER_BYTECODE> VS)
        {
            fixed (D3D12_SHADER_BYTECODE* __dsl_VS = VS)
            {
                VSCb(__dsl_VS);
            }
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3DX12PipelineParserCallbacks"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3DX12PipelineParserCallbacks(Ptr2D* vtbl) => lpVtbl = (ID3DX12PipelineParserCallbacks.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3DX12PipelineParserCallbacks"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3DX12PipelineParserCallbacks(ID3DX12PipelineParserCallbacks.Native* vtbl) => lpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3DX12PipelineParserCallbacks.Native"/> to <see cref = "ID3DX12PipelineParserCallbacks"/>.</summary>
    /// <param name = "value">The <see cref = "ID3DX12PipelineParserCallbacks.Native"/> instance to be converted </param>
    public static implicit operator ID3DX12PipelineParserCallbacks(ID3DX12PipelineParserCallbacks.Native* value) => new ID3DX12PipelineParserCallbacks(value);
    /// <summary>casts <see cref = "ID3DX12PipelineParserCallbacks"/> to <see cref = "ID3DX12PipelineParserCallbacks.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3DX12PipelineParserCallbacks"/> instance to be converted </param>
    public static implicit operator ID3DX12PipelineParserCallbacks.Native*(ID3DX12PipelineParserCallbacks value) => value.lpVtbl;
    /// <summary>casts <see cref = "Ptr2D"/> to <see cref = "ID3DX12PipelineParserCallbacks"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr2D"/> instance to be converted </param>
    public static explicit operator ID3DX12PipelineParserCallbacks(Ptr2D* value) => new ID3DX12PipelineParserCallbacks(value);
    /// <summary>casts <see cref = "ID3DX12PipelineParserCallbacks"/> to <see cref = "Ptr2D"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3DX12PipelineParserCallbacks"/> instance to be converted </param>
    public static implicit operator Ptr2D*(ID3DX12PipelineParserCallbacks value) => (Ptr2D*)value.lpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3DX12PipelineParserCallbacks"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3DX12PipelineParserCallbacks(Ptr<ID3DX12PipelineParserCallbacks.Native> value) => new ID3DX12PipelineParserCallbacks(value);
    /// <summary>casts <see cref = "ID3DX12PipelineParserCallbacks"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3DX12PipelineParserCallbacks"/> instance to be converted </param>
    public static implicit operator Ptr<ID3DX12PipelineParserCallbacks.Native>(ID3DX12PipelineParserCallbacks value) => (Ptr<ID3DX12PipelineParserCallbacks.Native>)value.lpVtbl;
    /// <summary>casts void*** pointer to <see cref = "ID3DX12PipelineParserCallbacks"/>.</summary>
    /// <param name = "value">The void*** instance to be converted</param>
    public static explicit operator ID3DX12PipelineParserCallbacks(void*** value) => new ID3DX12PipelineParserCallbacks((Native*)value);
    /// <summary>casts <see cref = "ID3DX12PipelineParserCallbacks"/> to void*** pointer</summary>
    /// <param name = "value">The <see cref = "ID3DX12PipelineParserCallbacks"/> instance to be converted </param>
    public static implicit operator void***(ID3DX12PipelineParserCallbacks value) => (void***)value.lpVtbl;
    /// <summary>casts nuint to <see cref = "ID3DX12PipelineParserCallbacks"/>.</summary>
    /// <param name = "value">The nuint instance to be converted</param>
    public static explicit operator ID3DX12PipelineParserCallbacks(nuint value) => new ID3DX12PipelineParserCallbacks((Native*)value.ToPointer());
    /// <summary>casts <see cref = "ID3DX12PipelineParserCallbacks"/> to nuint</summary>
    /// <param name = "value">The <see cref = "ID3DX12PipelineParserCallbacks"/> instance to be converted </param>
    public static implicit operator nuint(ID3DX12PipelineParserCallbacks value) => (nuint)value.lpVtbl;
    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.ASCb"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void ASCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* AS) => lpVtbl->ASCb(AS);
    [VtblIndex(13)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void ASCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] Ref<D3D12_SHADER_BYTECODE> AS)
    {
        fixed (D3D12_SHADER_BYTECODE* __dsl_AS = AS)
        {
            ASCb(__dsl_AS);
        }
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.BlendStateCb"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public void BlendStateCb([NativeTypeName("const D3D12_BLEND_DESC &")] D3D12_BLEND_DESC* BlendState) => lpVtbl->BlendStateCb(BlendState);
    [VtblIndex(15)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void BlendStateCb([NativeTypeName("const D3D12_BLEND_DESC &")] Ref<D3D12_BLEND_DESC> BlendState)
    {
        fixed (D3D12_BLEND_DESC* __dsl_BlendState = BlendState)
        {
            BlendStateCb(__dsl_BlendState);
        }
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.CachedPSOCb"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public void CachedPSOCb([NativeTypeName("const D3D12_CACHED_PIPELINE_STATE &")] D3D12_CACHED_PIPELINE_STATE* CachedPSO) => lpVtbl->CachedPSOCb(CachedPSO);
    [VtblIndex(27)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void CachedPSOCb([NativeTypeName("const D3D12_CACHED_PIPELINE_STATE &")] Ref<D3D12_CACHED_PIPELINE_STATE> CachedPSO)
    {
        fixed (D3D12_CACHED_PIPELINE_STATE* __dsl_CachedPSO = CachedPSO)
        {
            CachedPSOCb(__dsl_CachedPSO);
        }
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.CSCb"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void CSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* CS) => lpVtbl->CSCb(CS);
    [VtblIndex(12)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void CSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] Ref<D3D12_SHADER_BYTECODE> CS)
    {
        fixed (D3D12_SHADER_BYTECODE* __dsl_CS = CS)
        {
            CSCb(__dsl_CS);
        }
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.DepthStencilState1Cb"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public void DepthStencilState1Cb([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC1 &")] D3D12_DEPTH_STENCIL_DESC1* DepthStencilState) => lpVtbl->DepthStencilState1Cb(DepthStencilState);
    [VtblIndex(17)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void DepthStencilState1Cb([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC1 &")] Ref<D3D12_DEPTH_STENCIL_DESC1> DepthStencilState)
    {
        fixed (D3D12_DEPTH_STENCIL_DESC1* __dsl_DepthStencilState = DepthStencilState)
        {
            DepthStencilState1Cb(__dsl_DepthStencilState);
        }
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.DepthStencilState2Cb"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void DepthStencilState2Cb([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC2 &")] D3D12_DEPTH_STENCIL_DESC2* DepthStencilState) => lpVtbl->DepthStencilState2Cb(DepthStencilState);
    [VtblIndex(18)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void DepthStencilState2Cb([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC2 &")] Ref<D3D12_DEPTH_STENCIL_DESC2> DepthStencilState)
    {
        fixed (D3D12_DEPTH_STENCIL_DESC2* __dsl_DepthStencilState = DepthStencilState)
        {
            DepthStencilState2Cb(__dsl_DepthStencilState);
        }
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.DepthStencilStateCb"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public void DepthStencilStateCb([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC &")] D3D12_DEPTH_STENCIL_DESC* DepthStencilState) => lpVtbl->DepthStencilStateCb(DepthStencilState);
    [VtblIndex(16)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void DepthStencilStateCb([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC &")] Ref<D3D12_DEPTH_STENCIL_DESC> DepthStencilState)
    {
        fixed (D3D12_DEPTH_STENCIL_DESC* __dsl_DepthStencilState = DepthStencilState)
        {
            DepthStencilStateCb(__dsl_DepthStencilState);
        }
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.Dispose"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public void Dispose() => lpVtbl->Dispose();
    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.DSCb"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void DSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* DS) => lpVtbl->DSCb(DS);
    [VtblIndex(10)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void DSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] Ref<D3D12_SHADER_BYTECODE> DS)
    {
        fixed (D3D12_SHADER_BYTECODE* __dsl_DS = DS)
        {
            DSCb(__dsl_DS);
        }
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.DSVFormatCb"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public void DSVFormatCb(DXGI_FORMAT DSVFormat) => lpVtbl->DSVFormatCb(DSVFormat);
    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.ErrorBadInputParameter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public void ErrorBadInputParameter(uint ParameterIndex) => lpVtbl->ErrorBadInputParameter(ParameterIndex);
    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.ErrorDuplicateSubobject"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public void ErrorDuplicateSubobject(D3D12_PIPELINE_STATE_SUBOBJECT_TYPE DuplicateType) => lpVtbl->ErrorDuplicateSubobject(DuplicateType);
    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.ErrorUnknownSubobject"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public void ErrorUnknownSubobject(uint UnknownTypeValue) => lpVtbl->ErrorUnknownSubobject(UnknownTypeValue);
    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.FlagsCb"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void FlagsCb(D3D12_PIPELINE_STATE_FLAGS Flags) => lpVtbl->FlagsCb(Flags);
    /// <inheritdoc cref = "INativeInterface.GetAddressOf{TNativeInterface}()"></inheritdoc>
	public readonly Ptr2D<TNativeInterface> GetAddressOf<TNativeInterface>()
        where TNativeInterface : unmanaged => (TNativeInterface**)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
    /// <inheritdoc cref = "INativeInterface.GetAddressOf()"></inheritdoc>
	public readonly Ptr2D GetAddressOf() => (void**)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.GSCb"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* GS) => lpVtbl->GSCb(GS);
    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void GSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] Ref<D3D12_SHADER_BYTECODE> GS)
    {
        fixed (D3D12_SHADER_BYTECODE* __dsl_GS = GS)
        {
            GSCb(__dsl_GS);
        }
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.HSCb"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void HSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* HS) => lpVtbl->HSCb(HS);
    [VtblIndex(9)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void HSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] Ref<D3D12_SHADER_BYTECODE> HS)
    {
        fixed (D3D12_SHADER_BYTECODE* __dsl_HS = HS)
        {
            HSCb(__dsl_HS);
        }
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.IBStripCutValueCb"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void IBStripCutValueCb(D3D12_INDEX_BUFFER_STRIP_CUT_VALUE IBStripCutValue) => lpVtbl->IBStripCutValueCb(IBStripCutValue);
    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.InputLayoutCb"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void InputLayoutCb([NativeTypeName("const D3D12_INPUT_LAYOUT_DESC &")] D3D12_INPUT_LAYOUT_DESC* InputLayout) => lpVtbl->InputLayoutCb(InputLayout);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void InputLayoutCb([NativeTypeName("const D3D12_INPUT_LAYOUT_DESC &")] Ref<D3D12_INPUT_LAYOUT_DESC> InputLayout)
    {
        fixed (D3D12_INPUT_LAYOUT_DESC* __dsl_InputLayout = InputLayout)
        {
            InputLayoutCb(__dsl_InputLayout);
        }
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.MSCb"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void MSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* MS) => lpVtbl->MSCb(MS);
    [VtblIndex(14)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void MSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] Ref<D3D12_SHADER_BYTECODE> MS)
    {
        fixed (D3D12_SHADER_BYTECODE* __dsl_MS = MS)
        {
            MSCb(__dsl_MS);
        }
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.NodeMaskCb"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public void NodeMaskCb(uint NodeMask) => lpVtbl->NodeMaskCb(NodeMask);
    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.PrimitiveTopologyTypeCb"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void PrimitiveTopologyTypeCb(D3D12_PRIMITIVE_TOPOLOGY_TYPE PrimitiveTopologyType) => lpVtbl->PrimitiveTopologyTypeCb(PrimitiveTopologyType);
    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.PSCb"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void PSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* PS) => lpVtbl->PSCb(PS);
    [VtblIndex(11)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void PSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] Ref<D3D12_SHADER_BYTECODE> PS)
    {
        fixed (D3D12_SHADER_BYTECODE* __dsl_PS = PS)
        {
            PSCb(__dsl_PS);
        }
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.RasterizerState1Cb"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public void RasterizerState1Cb([NativeTypeName("const D3D12_RASTERIZER_DESC1 &")] D3D12_RASTERIZER_DESC1* RasterizerState) => lpVtbl->RasterizerState1Cb(RasterizerState);
    [VtblIndex(21)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void RasterizerState1Cb([NativeTypeName("const D3D12_RASTERIZER_DESC1 &")] Ref<D3D12_RASTERIZER_DESC1> RasterizerState)
    {
        fixed (D3D12_RASTERIZER_DESC1* __dsl_RasterizerState = RasterizerState)
        {
            RasterizerState1Cb(__dsl_RasterizerState);
        }
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.RasterizerState2Cb"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public void RasterizerState2Cb([NativeTypeName("const D3D12_RASTERIZER_DESC2 &")] D3D12_RASTERIZER_DESC2* RasterizerState) => lpVtbl->RasterizerState2Cb(RasterizerState);
    [VtblIndex(22)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void RasterizerState2Cb([NativeTypeName("const D3D12_RASTERIZER_DESC2 &")] Ref<D3D12_RASTERIZER_DESC2> RasterizerState)
    {
        fixed (D3D12_RASTERIZER_DESC2* __dsl_RasterizerState = RasterizerState)
        {
            RasterizerState2Cb(__dsl_RasterizerState);
        }
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.RasterizerStateCb"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public void RasterizerStateCb([NativeTypeName("const D3D12_RASTERIZER_DESC &")] D3D12_RASTERIZER_DESC* RasterizerState) => lpVtbl->RasterizerStateCb(RasterizerState);
    [VtblIndex(20)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void RasterizerStateCb([NativeTypeName("const D3D12_RASTERIZER_DESC &")] Ref<D3D12_RASTERIZER_DESC> RasterizerState)
    {
        fixed (D3D12_RASTERIZER_DESC* __dsl_RasterizerState = RasterizerState)
        {
            RasterizerStateCb(__dsl_RasterizerState);
        }
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.RootSignatureCb"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public void RootSignatureCb(ID3D12RootSignature pRootSignature) => lpVtbl->RootSignatureCb(pRootSignature);
    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.RTVFormatsCb"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public void RTVFormatsCb([NativeTypeName("const D3D12_RT_FORMAT_ARRAY &")] D3D12_RT_FORMAT_ARRAY* RTVFormats) => lpVtbl->RTVFormatsCb(RTVFormats);
    [VtblIndex(23)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void RTVFormatsCb([NativeTypeName("const D3D12_RT_FORMAT_ARRAY &")] Ref<D3D12_RT_FORMAT_ARRAY> RTVFormats)
    {
        fixed (D3D12_RT_FORMAT_ARRAY* __dsl_RTVFormats = RTVFormats)
        {
            RTVFormatsCb(__dsl_RTVFormats);
        }
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.SampleDescCb"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public void SampleDescCb([NativeTypeName("const DXGI_SAMPLE_DESC &")] DXGI_SAMPLE_DESC* SampleDesc) => lpVtbl->SampleDescCb(SampleDesc);
    [VtblIndex(24)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void SampleDescCb([NativeTypeName("const DXGI_SAMPLE_DESC &")] Ref<DXGI_SAMPLE_DESC> SampleDesc)
    {
        fixed (DXGI_SAMPLE_DESC* __dsl_SampleDesc = SampleDesc)
        {
            SampleDescCb(__dsl_SampleDesc);
        }
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.SampleMaskCb"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public void SampleMaskCb(uint SampleMask) => lpVtbl->SampleMaskCb(SampleMask);
    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.StreamOutputCb"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void StreamOutputCb([NativeTypeName("const D3D12_STREAM_OUTPUT_DESC &")] D3D12_STREAM_OUTPUT_DESC* StreamOutput) => lpVtbl->StreamOutputCb(StreamOutput);
    [VtblIndex(8)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void StreamOutputCb([NativeTypeName("const D3D12_STREAM_OUTPUT_DESC &")] Ref<D3D12_STREAM_OUTPUT_DESC> StreamOutput)
    {
        fixed (D3D12_STREAM_OUTPUT_DESC* __dsl_StreamOutput = StreamOutput)
        {
            StreamOutputCb(__dsl_StreamOutput);
        }
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.ViewInstancingCb"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public void ViewInstancingCb([NativeTypeName("const D3D12_VIEW_INSTANCING_DESC &")] D3D12_VIEW_INSTANCING_DESC* ViewInstancingDesc) => lpVtbl->ViewInstancingCb(ViewInstancingDesc);
    [VtblIndex(26)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void ViewInstancingCb([NativeTypeName("const D3D12_VIEW_INSTANCING_DESC &")] Ref<D3D12_VIEW_INSTANCING_DESC> ViewInstancingDesc)
    {
        fixed (D3D12_VIEW_INSTANCING_DESC* __dsl_ViewInstancingDesc = ViewInstancingDesc)
        {
            ViewInstancingCb(__dsl_ViewInstancingDesc);
        }
    }

    /// <include file='ID3DX12PipelineParserCallbacks.xml' path='doc/member[@name="ID3DX12PipelineParserCallbacks.VSCb"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void VSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] D3D12_SHADER_BYTECODE* VS) => lpVtbl->VSCb(VS);
    [VtblIndex(6)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void VSCb([NativeTypeName("const D3D12_SHADER_BYTECODE &")] Ref<D3D12_SHADER_BYTECODE> VS)
    {
        fixed (D3D12_SHADER_BYTECODE* __dsl_VS = VS)
        {
            VSCb(__dsl_VS);
        }
    }
}