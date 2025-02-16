// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_check_feature_support.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
using static Silk.NET.DirectX.D3D_FEATURE_LEVEL;
using static Silk.NET.DirectX.D3D_ROOT_SIGNATURE_VERSION;
using static Silk.NET.DirectX.D3D_SHADER_MODEL;
using static Silk.NET.DirectX.D3D12;
using static Silk.NET.DirectX.D3D12_CROSS_NODE_SHARING_TIER;
using static Silk.NET.DirectX.D3D12_FEATURE;
using static Silk.NET.DirectX.D3D12_HEAP_SERIALIZATION_TIER;
using static Silk.NET.DirectX.D3D12_PROTECTED_RESOURCE_SESSION_SUPPORT_FLAGS;
using static Silk.NET.DirectX.D3D12_TRI_STATE;
using static Silk.NET.DirectX.DXGI;
using static Silk.NET.Win32.E;
using static Silk.NET.Win32.S;
using static Silk.NET.Win32.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe struct CD3DX12FeatureSupport : IDisposable
{
    private ID3D12Device m_pDevice;
    private HRESULT m_hStatus;
    private D3D12_FEATURE_DATA_D3D12_OPTIONS m_dOptions;
    private D3D_FEATURE_LEVEL m_eMaxFeatureLevel;
    private D3D12_FEATURE_DATA_GPU_VIRTUAL_ADDRESS_SUPPORT m_dGPUVASupport;
    private D3D12_FEATURE_DATA_SHADER_MODEL m_dShaderModel;
    private D3D12_FEATURE_DATA_D3D12_OPTIONS1 m_dOptions1;

    [NativeTypeName("std::vector<D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_SUPPORT>")]
    private D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_SUPPORT* m_dProtectedResourceSessionSupport;
    private D3D12_FEATURE_DATA_ROOT_SIGNATURE m_dRootSignature;

    [NativeTypeName("std::vector<D3D12_FEATURE_DATA_ARCHITECTURE1>")]
    private D3D12_FEATURE_DATA_ARCHITECTURE1* m_dArchitecture1;
    private D3D12_FEATURE_DATA_D3D12_OPTIONS2 m_dOptions2;
    private D3D12_FEATURE_DATA_SHADER_CACHE m_dShaderCache;
    private D3D12_FEATURE_DATA_COMMAND_QUEUE_PRIORITY m_dCommandQueuePriority;
    private D3D12_FEATURE_DATA_D3D12_OPTIONS3 m_dOptions3;
    private D3D12_FEATURE_DATA_EXISTING_HEAPS m_dExistingHeaps;
    private D3D12_FEATURE_DATA_D3D12_OPTIONS4 m_dOptions4;

    [NativeTypeName("std::vector<D3D12_FEATURE_DATA_SERIALIZATION>")]
    private D3D12_FEATURE_DATA_SERIALIZATION* m_dSerialization;
    private D3D12_FEATURE_DATA_CROSS_NODE m_dCrossNode;
    private D3D12_FEATURE_DATA_D3D12_OPTIONS5 m_dOptions5;
    private D3D12_FEATURE_DATA_DISPLAYABLE m_dDisplayable;
    private D3D12_FEATURE_DATA_D3D12_OPTIONS6 m_dOptions6;
    private D3D12_FEATURE_DATA_D3D12_OPTIONS7 m_dOptions7;

    [NativeTypeName("std::vector<D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPE_COUNT>")]
    private D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPE_COUNT* m_dProtectedResourceSessionTypeCount;

    [NativeTypeName("std::vector<ProtectedResourceSessionTypesLocal>")]
    private ProtectedResourceSessionTypesLocal* m_dProtectedResourceSessionTypes;
    private D3D12_FEATURE_DATA_D3D12_OPTIONS8 m_dOptions8;
    private D3D12_FEATURE_DATA_D3D12_OPTIONS9 m_dOptions9;
    private D3D12_FEATURE_DATA_D3D12_OPTIONS10 m_dOptions10;
    private D3D12_FEATURE_DATA_D3D12_OPTIONS11 m_dOptions11;
    private D3D12_FEATURE_DATA_D3D12_OPTIONS12 m_dOptions12;
    private D3D12_FEATURE_DATA_D3D12_OPTIONS13 m_dOptions13;
    private D3D12_FEATURE_DATA_D3D12_OPTIONS14 m_dOptions14;
    private D3D12_FEATURE_DATA_D3D12_OPTIONS15 m_dOptions15;
    private D3D12_FEATURE_DATA_D3D12_OPTIONS16 m_dOptions16;
    private D3D12_FEATURE_DATA_D3D12_OPTIONS17 m_dOptions17;
    private D3D12_FEATURE_DATA_D3D12_OPTIONS18 m_dOptions18;
    private D3D12_FEATURE_DATA_D3D12_OPTIONS19 m_dOptions19;
    private D3D12_FEATURE_DATA_D3D12_OPTIONS20 m_dOptions20;

    // Default constructor that creates an empty object
    public CD3DX12FeatureSupport()
    {
        m_hStatus = E_INVALIDARG;
    }

    [NativeTypeName(
        "struct ProtectedResourceSessionTypesLocal : D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPES"
    )]
    [NativeInheritance("D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPES")]
    private struct ProtectedResourceSessionTypesLocal
    {
        public D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPES Base;

        [NativeTypeName("std::vector<GUID>")]
        public Guid* TypeVec;

        [UnscopedRef]
        public ref uint NodeIndex => ref Base.NodeIndex;

        [UnscopedRef]
        public ref uint Count => ref Base.Count;

        [UnscopedRef]
        public ref Guid* pTypes => ref Base.pTypes;
    }

    [Transformed]
    // D3D12_OPTIONS6
    public readonly MaybeBool<BOOL> AdditionalShadingRatesSupported() =>
        (MaybeBool<BOOL>)(BOOL)AdditionalShadingRatesSupportedRaw();

    // D3D12_OPTIONS6
    public readonly BOOL AdditionalShadingRatesSupportedRaw() =>
        m_dOptions6.AdditionalShadingRatesSupported;

    [Transformed]
    // D3D12_OPTIONS14
    public readonly MaybeBool<BOOL> AdvancedTextureOpsSupported() =>
        (MaybeBool<BOOL>)(BOOL)AdvancedTextureOpsSupportedRaw();

    // D3D12_OPTIONS14
    public readonly BOOL AdvancedTextureOpsSupportedRaw() =>
        m_dOptions14.AdvancedTextureOpsSupported;

    [Transformed]
    public readonly MaybeBool<BOOL> AlphaBlendFactorSupported() =>
        (MaybeBool<BOOL>)(BOOL)AlphaBlendFactorSupportedRaw();

    public readonly BOOL AlphaBlendFactorSupportedRaw() => m_dOptions13.AlphaBlendFactorSupported;

    [Transformed]
    public readonly MaybeBool<BOOL> AnisoFilterWithPointMipSupported() =>
        (MaybeBool<BOOL>)(BOOL)AnisoFilterWithPointMipSupportedRaw();

    public readonly BOOL AnisoFilterWithPointMipSupportedRaw() =>
        m_dOptions19.AnisoFilterWithPointMipSupported;

    [Transformed]
    // D3D12_OPTIONS11
    public readonly MaybeBool<BOOL> AtomicInt64OnDescriptorHeapResourceSupported() =>
        (MaybeBool<BOOL>)(BOOL)AtomicInt64OnDescriptorHeapResourceSupportedRaw();

    // D3D12_OPTIONS11
    public readonly BOOL AtomicInt64OnDescriptorHeapResourceSupportedRaw() =>
        m_dOptions11.AtomicInt64OnDescriptorHeapResourceSupported;

    [Transformed]
    public readonly MaybeBool<BOOL> AtomicInt64OnGroupSharedSupported() =>
        (MaybeBool<BOOL>)(BOOL)AtomicInt64OnGroupSharedSupportedRaw();

    public readonly BOOL AtomicInt64OnGroupSharedSupportedRaw() =>
        m_dOptions9.AtomicInt64OnGroupSharedSupported;

    [Transformed]
    public readonly MaybeBool<BOOL> AtomicInt64OnTypedResourceSupported() =>
        (MaybeBool<BOOL>)(BOOL)AtomicInt64OnTypedResourceSupportedRaw();

    public readonly BOOL AtomicInt64OnTypedResourceSupportedRaw() =>
        m_dOptions9.AtomicInt64OnTypedResourceSupported;

    [Transformed]
    public readonly MaybeBool<BOOL> BackgroundProcessingSupported() =>
        (MaybeBool<BOOL>)(BOOL)BackgroundProcessingSupportedRaw();

    public readonly BOOL BackgroundProcessingSupportedRaw() =>
        m_dOptions6.BackgroundProcessingSupported;

    [Transformed]
    public readonly MaybeBool<BOOL> BarycentricsSupported() =>
        (MaybeBool<BOOL>)(BOOL)BarycentricsSupportedRaw();

    public readonly BOOL BarycentricsSupportedRaw() => m_dOptions3.BarycentricsSupported;

    [Transformed]
    public readonly MaybeBool<BOOL> CacheCoherentUMA(uint NodeIndex = 0) =>
        (MaybeBool<BOOL>)(BOOL)CacheCoherentUMARaw(NodeIndex);

    public readonly BOOL CacheCoherentUMARaw(uint NodeIndex = 0) =>
        m_dArchitecture1[NodeIndex].CacheCoherentUMA;

    [Transformed]
    public readonly MaybeBool<BOOL> CastingFullyTypedFormatSupported() =>
        (MaybeBool<BOOL>)(BOOL)CastingFullyTypedFormatSupportedRaw();

    public readonly BOOL CastingFullyTypedFormatSupportedRaw() =>
        m_dOptions3.CastingFullyTypedFormatSupported;

    [Transformed]
    // COMMAND_QUEUE_PRIORITY
    public MaybeBool<BOOL> CommandQueuePrioritySupported(
        D3D12_COMMAND_LIST_TYPE CommandListType,
        uint Priority
    ) => (MaybeBool<BOOL>)(BOOL)CommandQueuePrioritySupportedRaw(CommandListType, Priority);

    // COMMAND_QUEUE_PRIORITY
    public BOOL CommandQueuePrioritySupportedRaw(
        D3D12_COMMAND_LIST_TYPE CommandListType,
        uint Priority
    )
    {
        m_dCommandQueuePriority.CommandListType = CommandListType;
        m_dCommandQueuePriority.Priority = Priority;
        fixed (CD3DX12FeatureSupport* pThis = &this)
        {
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_COMMAND_QUEUE_PRIORITY,
                        &pThis->m_dCommandQueuePriority,
                        (uint)(sizeof(D3D12_FEATURE_DATA_COMMAND_QUEUE_PRIORITY))
                    )
                )
            )
            {
                return false;
            }
        }
        return m_dCommandQueuePriority.PriorityForTypeIsSupported;
    }

    [Transformed]
    // D3D12_OPTIONS20
    public readonly MaybeBool<BOOL> ComputeOnlyWriteWatchSupported() =>
        (MaybeBool<BOOL>)(BOOL)ComputeOnlyWriteWatchSupportedRaw();

    // D3D12_OPTIONS20
    public readonly BOOL ComputeOnlyWriteWatchSupportedRaw() =>
        m_dOptions20.ComputeOnlyWriteWatchSupported;

    public readonly D3D12_CONSERVATIVE_RASTERIZATION_TIER ConservativeRasterizationTier() =>
        m_dOptions.ConservativeRasterizationTier;

    [Transformed]
    // D3D12_OPTIONS3
    public readonly MaybeBool<BOOL> CopyQueueTimestampQueriesSupported() =>
        (MaybeBool<BOOL>)(BOOL)CopyQueueTimestampQueriesSupportedRaw();

    // D3D12_OPTIONS3
    public readonly BOOL CopyQueueTimestampQueriesSupportedRaw() =>
        m_dOptions3.CopyQueueTimestampQueriesSupported;

    [Transformed]
    public readonly MaybeBool<BOOL> CrossAdapterRowMajorTextureSupported() =>
        (MaybeBool<BOOL>)(BOOL)CrossAdapterRowMajorTextureSupportedRaw();

    public readonly BOOL CrossAdapterRowMajorTextureSupportedRaw() =>
        m_dOptions.CrossAdapterRowMajorTextureSupported;

    [Transformed]
    // CROSS_NODE
    // CrossNodeSharingTier handled in D3D12Options
    public readonly MaybeBool<BOOL> CrossNodeAtomicShaderInstructions() =>
        (MaybeBool<BOOL>)(BOOL)CrossNodeAtomicShaderInstructionsRaw();

    // CROSS_NODE
    // CrossNodeSharingTier handled in D3D12Options
    public readonly BOOL CrossNodeAtomicShaderInstructionsRaw() =>
        m_dCrossNode.AtomicShaderInstructions;

    public readonly D3D12_CROSS_NODE_SHARING_TIER CrossNodeSharingTier()
    {
        if (m_dCrossNode.SharingTier > D3D12_CROSS_NODE_SHARING_TIER_NOT_SUPPORTED)
        {
            return m_dCrossNode.SharingTier;
        }
        else
        {
            return m_dOptions.CrossNodeSharingTier;
        }
    }

    [Transformed]
    // D3D12_OPTIONS2
    public readonly MaybeBool<BOOL> DepthBoundsTestSupported() =>
        (MaybeBool<BOOL>)(BOOL)DepthBoundsTestSupportedRaw();

    // D3D12_OPTIONS2
    public readonly BOOL DepthBoundsTestSupportedRaw() => m_dOptions2.DepthBoundsTestSupported;

    [Transformed]
    public readonly MaybeBool<BOOL> DerivativesInMeshAndAmplificationShadersSupported() =>
        (MaybeBool<BOOL>)(BOOL)DerivativesInMeshAndAmplificationShadersSupportedRaw();

    public readonly BOOL DerivativesInMeshAndAmplificationShadersSupportedRaw() =>
        m_dOptions9.DerivativesInMeshAndAmplificationShadersSupported;

    [Transformed]
    // DISPLAYABLE
    public readonly MaybeBool<BOOL> DisplayableTexture() =>
        (MaybeBool<BOOL>)(BOOL)DisplayableTextureRaw();

    // DISPLAYABLE
    public readonly BOOL DisplayableTextureRaw() => m_dDisplayable.DisplayableTexture;

    public void Dispose()
    {
        NativeMemory.Free(m_dProtectedResourceSessionSupport);
        m_dProtectedResourceSessionSupport = null;
        NativeMemory.Free(m_dArchitecture1);
        m_dArchitecture1 = null;
        NativeMemory.Free(m_dSerialization);
        m_dSerialization = null;
        NativeMemory.Free(m_dProtectedResourceSessionTypeCount);
        m_dProtectedResourceSessionTypeCount = null;
        if (m_dProtectedResourceSessionTypes != null)
        {
            uint uNodeCount = m_pDevice.GetNodeCount();
            for (nuint NodeIndex = 0; NodeIndex < uNodeCount; NodeIndex++)
            {
                NativeMemory.Free(m_dProtectedResourceSessionTypes[NodeIndex].TypeVec);
            }
            NativeMemory.Free(m_dProtectedResourceSessionTypes);
            m_dProtectedResourceSessionTypes = null;
        }
    }

    [Transformed]
    // Getter functions for each feature class
    // D3D12_OPTIONS
    public readonly MaybeBool<BOOL> DoublePrecisionFloatShaderOps() =>
        (MaybeBool<BOOL>)(BOOL)DoublePrecisionFloatShaderOpsRaw();

    // Getter functions for each feature class
    // D3D12_OPTIONS
    public readonly BOOL DoublePrecisionFloatShaderOpsRaw() =>
        m_dOptions.DoublePrecisionFloatShaderOps;

    [Transformed]
    // D3D12_OPTIONS16
    public readonly MaybeBool<BOOL> DynamicDepthBiasSupported() =>
        (MaybeBool<BOOL>)(BOOL)DynamicDepthBiasSupportedRaw();

    // D3D12_OPTIONS16
    public readonly BOOL DynamicDepthBiasSupportedRaw() => m_dOptions16.DynamicDepthBiasSupported;

    [Transformed]
    public readonly MaybeBool<BOOL> DynamicIndexBufferStripCutSupported() =>
        (MaybeBool<BOOL>)(BOOL)DynamicIndexBufferStripCutSupportedRaw();

    public readonly BOOL DynamicIndexBufferStripCutSupportedRaw() =>
        m_dOptions15.DynamicIndexBufferStripCutSupported;

    [Transformed]
    public readonly MaybeBool<BOOL> EnhancedBarriersSupported() =>
        (MaybeBool<BOOL>)(BOOL)EnhancedBarriersSupportedRaw();

    public readonly BOOL EnhancedBarriersSupportedRaw() => m_dOptions12.EnhancedBarriersSupported;

    [Transformed]
    // EXISTING_HEAPS
    public readonly MaybeBool<BOOL> ExistingHeapsSupported() =>
        (MaybeBool<BOOL>)(BOOL)ExistingHeapsSupportedRaw();

    // EXISTING_HEAPS
    public readonly BOOL ExistingHeapsSupportedRaw() => m_dExistingHeaps.Supported;

    [Transformed]
    public readonly MaybeBool<BOOL> ExpandedComputeResourceStates() =>
        (MaybeBool<BOOL>)(BOOL)ExpandedComputeResourceStatesRaw();

    public readonly BOOL ExpandedComputeResourceStatesRaw() =>
        m_dOptions1.ExpandedComputeResourceStates;

    // FORMAT_INFO
    public readonly HRESULT FormatInfo(
        DXGI_FORMAT Format,
        [NativeTypeName("UINT8 &")] out byte PlaneCount
    )
    {
        D3D12_FEATURE_DATA_FORMAT_INFO dFormatInfo;
        dFormatInfo.Format = Format;
        HRESULT result = m_pDevice.CheckFeatureSupport(
            D3D12_FEATURE_FORMAT_INFO,
            &dFormatInfo,
            (uint)(sizeof(D3D12_FEATURE_DATA_FORMAT_INFO))
        );
        if (FAILED(result))
        {
            PlaneCount = 0;
        }
        else
        {
            PlaneCount = dFormatInfo.PlaneCount;
        }
        return result;
    }

    // FORMAT_SUPPORT
    public readonly HRESULT FormatSupport(
        DXGI_FORMAT Format,
        [NativeTypeName("D3D12_FORMAT_SUPPORT1 &")] out D3D12_FORMAT_SUPPORT1 Support1,
        [NativeTypeName("D3D12_FORMAT_SUPPORT2 &")] out D3D12_FORMAT_SUPPORT2 Support2
    )
    {
        D3D12_FEATURE_DATA_FORMAT_SUPPORT dFormatSupport;
        dFormatSupport.Format = Format;
        // It is possible that the function call returns an error
        HRESULT result = m_pDevice.CheckFeatureSupport(
            D3D12_FEATURE_FORMAT_SUPPORT,
            &dFormatSupport,
            (uint)(sizeof(D3D12_FEATURE_DATA_FORMAT_SUPPORT))
        );
        Support1 = dFormatSupport.Support1;
        Support2 = dFormatSupport.Support2; // Two outputs. Probably better just to take in the struct as an argument?
        return result;
    }

    // Retrieves the status of the object. If an error occurred in the initialization process, the function returns the error code.
    public readonly HRESULT GetStatus() => m_hStatus;

    [Transformed]
    public readonly MaybeBool<BOOL> GPUUploadHeapSupported() =>
        (MaybeBool<BOOL>)(BOOL)GPUUploadHeapSupportedRaw();

    public readonly BOOL GPUUploadHeapSupportedRaw() => m_dOptions16.GPUUploadHeapSupported;

    // SERIALIZATION
    public readonly D3D12_HEAP_SERIALIZATION_TIER HeapSerializationTier(uint NodeIndex = 0) =>
        m_dSerialization[NodeIndex].HeapSerializationTier;

    // ROOT_SIGNATURE
    public readonly D3D_ROOT_SIGNATURE_VERSION HighestRootSignatureVersion() =>
        m_dRootSignature.HighestVersion;

    // SHADER_MODEL
    public readonly D3D_SHADER_MODEL HighestShaderModel() => m_dShaderModel.HighestShaderModel;

    [Transformed]
    public readonly MaybeBool<BOOL> IndependentFrontAndBackStencilRefMaskSupported() =>
        (MaybeBool<BOOL>)(BOOL)IndependentFrontAndBackStencilRefMaskSupportedRaw();

    public readonly BOOL IndependentFrontAndBackStencilRefMaskSupportedRaw() =>
        m_dOptions14.IndependentFrontAndBackStencilRefMaskSupported;

    // Initialize data from the given device
    public HRESULT Init(ID3D12Device pDevice)
    {
        if (pDevice.lpVtbl == null)
        {
            m_hStatus = E_INVALIDARG;
            return m_hStatus;
        }
        m_pDevice = pDevice;
        fixed (CD3DX12FeatureSupport* pThis = &this)
        {
            // Initialize static feature support data structures
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_D3D12_OPTIONS,
                        &pThis->m_dOptions,
                        (uint)(sizeof(D3D12_FEATURE_DATA_D3D12_OPTIONS))
                    )
                )
            )
            {
                m_dOptions = default;
            }
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_GPU_VIRTUAL_ADDRESS_SUPPORT,
                        &pThis->m_dGPUVASupport,
                        (uint)(sizeof(D3D12_FEATURE_DATA_GPU_VIRTUAL_ADDRESS_SUPPORT))
                    )
                )
            )
            {
                m_dGPUVASupport = default;
            }
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_D3D12_OPTIONS1,
                        &pThis->m_dOptions1,
                        (uint)(sizeof(D3D12_FEATURE_DATA_D3D12_OPTIONS1))
                    )
                )
            )
            {
                m_dOptions1 = default;
            }
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_D3D12_OPTIONS2,
                        &pThis->m_dOptions2,
                        (uint)(sizeof(D3D12_FEATURE_DATA_D3D12_OPTIONS2))
                    )
                )
            )
            {
                m_dOptions2 = default;
            }
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_SHADER_CACHE,
                        &pThis->m_dShaderCache,
                        (uint)(sizeof(D3D12_FEATURE_DATA_SHADER_CACHE))
                    )
                )
            )
            {
                m_dShaderCache = default;
            }
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_D3D12_OPTIONS3,
                        &pThis->m_dOptions3,
                        (uint)(sizeof(D3D12_FEATURE_DATA_D3D12_OPTIONS3))
                    )
                )
            )
            {
                m_dOptions3 = default;
            }
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_EXISTING_HEAPS,
                        &pThis->m_dExistingHeaps,
                        (uint)(sizeof(D3D12_FEATURE_DATA_EXISTING_HEAPS))
                    )
                )
            )
            {
                m_dExistingHeaps = default;
            }
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_D3D12_OPTIONS4,
                        &pThis->m_dOptions4,
                        (uint)(sizeof(D3D12_FEATURE_DATA_D3D12_OPTIONS4))
                    )
                )
            )
            {
                m_dOptions4 = default;
            }
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_CROSS_NODE,
                        &pThis->m_dCrossNode,
                        (uint)(sizeof(D3D12_FEATURE_DATA_CROSS_NODE))
                    )
                )
            )
            {
                m_dCrossNode = default;
            }
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_D3D12_OPTIONS5,
                        &pThis->m_dOptions5,
                        (uint)(sizeof(D3D12_FEATURE_DATA_D3D12_OPTIONS5))
                    )
                )
            )
            {
                m_dOptions5 = default;
            }
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_DISPLAYABLE,
                        &pThis->m_dDisplayable,
                        (uint)(sizeof(D3D12_FEATURE_DATA_DISPLAYABLE))
                    )
                )
            )
            {
                m_dDisplayable = default;
            }
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_D3D12_OPTIONS6,
                        &pThis->m_dOptions6,
                        (uint)(sizeof(D3D12_FEATURE_DATA_D3D12_OPTIONS6))
                    )
                )
            )
            {
                m_dOptions6 = default;
            }
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_D3D12_OPTIONS7,
                        &pThis->m_dOptions7,
                        (uint)(sizeof(D3D12_FEATURE_DATA_D3D12_OPTIONS7))
                    )
                )
            )
            {
                m_dOptions7 = default;
            }
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_D3D12_OPTIONS8,
                        &pThis->m_dOptions8,
                        (uint)(sizeof(D3D12_FEATURE_DATA_D3D12_OPTIONS8))
                    )
                )
            )
            {
                m_dOptions8 = default;
            }
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_D3D12_OPTIONS9,
                        &pThis->m_dOptions9,
                        (uint)(sizeof(D3D12_FEATURE_DATA_D3D12_OPTIONS9))
                    )
                )
            )
            {
                m_dOptions9 = default;
            }
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_D3D12_OPTIONS10,
                        &pThis->m_dOptions10,
                        (uint)(sizeof(D3D12_FEATURE_DATA_D3D12_OPTIONS10))
                    )
                )
            )
            {
                m_dOptions10 = default;
            }
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_D3D12_OPTIONS11,
                        &pThis->m_dOptions11,
                        (uint)(sizeof(D3D12_FEATURE_DATA_D3D12_OPTIONS11))
                    )
                )
            )
            {
                m_dOptions11 = default;
            }
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_D3D12_OPTIONS12,
                        &pThis->m_dOptions12,
                        (uint)(sizeof(D3D12_FEATURE_DATA_D3D12_OPTIONS12))
                    )
                )
            )
            {
                m_dOptions12 = default;
                m_dOptions12.MSPrimitivesPipelineStatisticIncludesCulledPrimitives =
                    D3D12_TRI_STATE_UNKNOWN;
            }
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_D3D12_OPTIONS13,
                        &pThis->m_dOptions13,
                        (uint)(sizeof(D3D12_FEATURE_DATA_D3D12_OPTIONS13))
                    )
                )
            )
            {
                m_dOptions13 = default;
            }
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_D3D12_OPTIONS14,
                        &pThis->m_dOptions14,
                        (uint)(sizeof(D3D12_FEATURE_DATA_D3D12_OPTIONS14))
                    )
                )
            )
            {
                m_dOptions14 = default;
            }
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_D3D12_OPTIONS15,
                        &pThis->m_dOptions15,
                        (uint)(sizeof(D3D12_FEATURE_DATA_D3D12_OPTIONS15))
                    )
                )
            )
            {
                m_dOptions15 = default;
            }
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_D3D12_OPTIONS16,
                        &pThis->m_dOptions16,
                        (uint)(sizeof(D3D12_FEATURE_DATA_D3D12_OPTIONS16))
                    )
                )
            )
            {
                m_dOptions16 = default;
            }
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_D3D12_OPTIONS17,
                        &pThis->m_dOptions17,
                        (uint)(sizeof(D3D12_FEATURE_DATA_D3D12_OPTIONS17))
                    )
                )
            )
            {
                m_dOptions17 = default;
            }
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_D3D12_OPTIONS18,
                        &pThis->m_dOptions18,
                        (uint)(sizeof(D3D12_FEATURE_DATA_D3D12_OPTIONS18))
                    )
                )
            )
            {
                m_dOptions18.RenderPassesValid = false;
            }
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_D3D12_OPTIONS19,
                        &pThis->m_dOptions19,
                        (uint)(sizeof(D3D12_FEATURE_DATA_D3D12_OPTIONS19))
                    )
                )
            )
            {
                m_dOptions19 = default;
                m_dOptions19.SupportedSampleCountsWithNoOutputs = 1;
                m_dOptions19.MaxSamplerDescriptorHeapSize =
                    D3D12_MAX_SHADER_VISIBLE_SAMPLER_HEAP_SIZE;
                m_dOptions19.MaxSamplerDescriptorHeapSizeWithStaticSamplers =
                    D3D12_MAX_SHADER_VISIBLE_SAMPLER_HEAP_SIZE;
                m_dOptions19.MaxViewDescriptorHeapSize =
                    D3D12_MAX_SHADER_VISIBLE_DESCRIPTOR_HEAP_SIZE_TIER_1;
            }
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_D3D12_OPTIONS20,
                        &pThis->m_dOptions20,
                        (uint)(sizeof(D3D12_FEATURE_DATA_D3D12_OPTIONS20))
                    )
                )
            )
            {
                m_dOptions20 = default;
            }
        }
        // Initialize per-node feature support data structures
        uint uNodeCount = m_pDevice.GetNodeCount();
        NativeMemory.Free(m_dProtectedResourceSessionSupport);
        m_dProtectedResourceSessionSupport =
            (D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_SUPPORT*)(
                NativeMemory.Alloc(
                    uNodeCount,
                    (uint)(sizeof(D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_SUPPORT))
                )
            );
        NativeMemory.Free(m_dArchitecture1);
        m_dArchitecture1 = (D3D12_FEATURE_DATA_ARCHITECTURE1*)(
            NativeMemory.Alloc(uNodeCount, (uint)(sizeof(D3D12_FEATURE_DATA_ARCHITECTURE1)))
        );
        NativeMemory.Free(m_dSerialization);
        m_dSerialization = (D3D12_FEATURE_DATA_SERIALIZATION*)(
            NativeMemory.Alloc(uNodeCount, (uint)(sizeof(D3D12_FEATURE_DATA_SERIALIZATION)))
        );
        NativeMemory.Free(m_dProtectedResourceSessionTypeCount);
        m_dProtectedResourceSessionTypeCount =
            (D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPE_COUNT*)(
                NativeMemory.Alloc(
                    uNodeCount,
                    (uint)(sizeof(D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPE_COUNT))
                )
            );
        NativeMemory.Free(m_dProtectedResourceSessionTypes);
        m_dProtectedResourceSessionTypes = (ProtectedResourceSessionTypesLocal*)(
            NativeMemory.Alloc(uNodeCount, (uint)(sizeof(ProtectedResourceSessionTypesLocal)))
        );
        for (uint NodeIndex = 0; NodeIndex < uNodeCount; NodeIndex++)
        {
            m_dProtectedResourceSessionSupport[NodeIndex].NodeIndex = NodeIndex;
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_PROTECTED_RESOURCE_SESSION_SUPPORT,
                        &m_dProtectedResourceSessionSupport[NodeIndex],
                        (uint)(sizeof(D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_SUPPORT))
                    )
                )
            )
            {
                m_dProtectedResourceSessionSupport[NodeIndex].Support =
                    D3D12_PROTECTED_RESOURCE_SESSION_SUPPORT_FLAG_NONE;
            }
            m_dArchitecture1[NodeIndex].NodeIndex = NodeIndex;
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_ARCHITECTURE1,
                        &m_dArchitecture1[NodeIndex],
                        (uint)(sizeof(D3D12_FEATURE_DATA_ARCHITECTURE1))
                    )
                )
            )
            {
                D3D12_FEATURE_DATA_ARCHITECTURE dArchLocal = default;
                dArchLocal.NodeIndex = NodeIndex;
                if (
                    FAILED(
                        m_pDevice.CheckFeatureSupport(
                            D3D12_FEATURE_ARCHITECTURE,
                            &dArchLocal,
                            (uint)(sizeof(D3D12_FEATURE_DATA_ARCHITECTURE))
                        )
                    )
                )
                {
                    dArchLocal.TileBasedRenderer = false;
                    dArchLocal.UMA = false;
                    dArchLocal.CacheCoherentUMA = false;
                }
                m_dArchitecture1[NodeIndex].TileBasedRenderer = dArchLocal.TileBasedRenderer;
                m_dArchitecture1[NodeIndex].UMA = dArchLocal.UMA;
                m_dArchitecture1[NodeIndex].CacheCoherentUMA = dArchLocal.CacheCoherentUMA;
                m_dArchitecture1[NodeIndex].IsolatedMMU = false;
            }
            m_dSerialization[NodeIndex].NodeIndex = NodeIndex;
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_SERIALIZATION,
                        &m_dSerialization[NodeIndex],
                        (uint)(sizeof(D3D12_FEATURE_DATA_SERIALIZATION))
                    )
                )
            )
            {
                m_dSerialization[NodeIndex].HeapSerializationTier = D3D12_HEAP_SERIALIZATION_TIER_0;
            }
            m_dProtectedResourceSessionTypeCount[NodeIndex].NodeIndex = NodeIndex;
            if (
                FAILED(
                    m_pDevice.CheckFeatureSupport(
                        D3D12_FEATURE_PROTECTED_RESOURCE_SESSION_TYPE_COUNT,
                        &m_dProtectedResourceSessionTypeCount[NodeIndex],
                        (uint)(sizeof(D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPE_COUNT))
                    )
                )
            )
            {
                m_dProtectedResourceSessionTypeCount[NodeIndex].Count = 0;
            }
            // Special procedure to initialize local protected resource session types structs
            // Must wait until session type count initialized
            _ = QueryProtectedResourceSessionTypes(
                NodeIndex,
                m_dProtectedResourceSessionTypeCount[NodeIndex].Count
            );
        }
        // Initialize features that requires highest version check
        if (FAILED(m_hStatus = QueryHighestShaderModel()))
        {
            return m_hStatus;
        }
        if (FAILED(m_hStatus = QueryHighestRootSignatureVersion()))
        {
            return m_hStatus;
        }
        // Initialize Feature Levels data
        if (FAILED(m_hStatus = QueryHighestFeatureLevel()))
        {
            return m_hStatus;
        }
        return m_hStatus;
    }

    [Transformed]
    public readonly MaybeBool<BOOL> Int64ShaderOps() => (MaybeBool<BOOL>)(BOOL)Int64ShaderOpsRaw();

    public readonly BOOL Int64ShaderOpsRaw() => m_dOptions1.Int64ShaderOps;

    [Transformed]
    public readonly MaybeBool<BOOL> InvertedViewportDepthFlipsZSupported() =>
        (MaybeBool<BOOL>)(BOOL)InvertedViewportDepthFlipsZSupportedRaw();

    public readonly BOOL InvertedViewportDepthFlipsZSupportedRaw() =>
        m_dOptions13.InvertedViewportDepthFlipsZSupported;

    [Transformed]
    public readonly MaybeBool<BOOL> InvertedViewportHeightFlipsYSupported() =>
        (MaybeBool<BOOL>)(BOOL)InvertedViewportHeightFlipsYSupportedRaw();

    public readonly BOOL InvertedViewportHeightFlipsYSupportedRaw() =>
        m_dOptions13.InvertedViewportHeightFlipsYSupported;

    [Transformed]
    public readonly MaybeBool<BOOL> IsolatedMMU(uint NodeIndex = 0) =>
        (MaybeBool<BOOL>)(BOOL)IsolatedMMURaw(NodeIndex);

    public readonly BOOL IsolatedMMURaw(uint NodeIndex = 0) =>
        m_dArchitecture1[NodeIndex].IsolatedMMU;

    [Transformed]
    public readonly MaybeBool<BOOL> ManualWriteTrackingResourceSupported() =>
        (MaybeBool<BOOL>)(BOOL)ManualWriteTrackingResourceSupportedRaw();

    public readonly BOOL ManualWriteTrackingResourceSupportedRaw() =>
        m_dOptions17.ManualWriteTrackingResourceSupported;

    // GPU_VIRTUAL_ADDRESS_SUPPORT
    public readonly uint MaxGPUVirtualAddressBitsPerProcess() =>
        m_dGPUVASupport.MaxGPUVirtualAddressBitsPerProcess;

    public readonly uint MaxGPUVirtualAddressBitsPerResource()
    {
        if (m_dOptions.MaxGPUVirtualAddressBitsPerResource > 0)
        {
            return m_dOptions.MaxGPUVirtualAddressBitsPerResource;
        }
        else
        {
            return m_dGPUVASupport.MaxGPUVirtualAddressBitsPerResource;
        }
    }

    public readonly uint MaxSamplerDescriptorHeapSize() =>
        m_dOptions19.MaxSamplerDescriptorHeapSize;

    public readonly uint MaxSamplerDescriptorHeapSizeWithStaticSamplers() =>
        m_dOptions19.MaxSamplerDescriptorHeapSizeWithStaticSamplers;

    // FEATURE_LEVELS
    public readonly D3D_FEATURE_LEVEL MaxSupportedFeatureLevel() => m_eMaxFeatureLevel;

    public readonly uint MaxViewDescriptorHeapSize() => m_dOptions19.MaxViewDescriptorHeapSize;

    [Transformed]
    public readonly MaybeBool<BOOL> MeshShaderPerPrimitiveShadingRateSupported() =>
        (MaybeBool<BOOL>)(BOOL)MeshShaderPerPrimitiveShadingRateSupportedRaw();

    public readonly BOOL MeshShaderPerPrimitiveShadingRateSupportedRaw() =>
        m_dOptions10.MeshShaderPerPrimitiveShadingRateSupported;

    [Transformed]
    // D3D12_OPTIONS9
    public readonly MaybeBool<BOOL> MeshShaderPipelineStatsSupported() =>
        (MaybeBool<BOOL>)(BOOL)MeshShaderPipelineStatsSupportedRaw();

    // D3D12_OPTIONS9
    public readonly BOOL MeshShaderPipelineStatsSupportedRaw() =>
        m_dOptions9.MeshShaderPipelineStatsSupported;

    [Transformed]
    public readonly MaybeBool<BOOL> MeshShaderSupportsFullRangeRenderTargetArrayIndex() =>
        (MaybeBool<BOOL>)(BOOL)MeshShaderSupportsFullRangeRenderTargetArrayIndexRaw();

    public readonly BOOL MeshShaderSupportsFullRangeRenderTargetArrayIndexRaw() =>
        m_dOptions9.MeshShaderSupportsFullRangeRenderTargetArrayIndex;

    // D3D12_OPTIONS7
    public readonly D3D12_MESH_SHADER_TIER MeshShaderTier() => m_dOptions7.MeshShaderTier;

    public readonly D3D12_SHADER_MIN_PRECISION_SUPPORT MinPrecisionSupport() =>
        m_dOptions.MinPrecisionSupport;

    [Transformed]
    // D3D12_OPTIONS19
    public readonly MaybeBool<BOOL> MismatchingOutputDimensionsSupported() =>
        (MaybeBool<BOOL>)(BOOL)MismatchingOutputDimensionsSupportedRaw();

    // D3D12_OPTIONS19
    public readonly BOOL MismatchingOutputDimensionsSupportedRaw() =>
        m_dOptions19.MismatchingOutputDimensionsSupported;

    [Transformed]
    // D3D12_OPTIONS4
    public readonly MaybeBool<BOOL> MSAA64KBAlignedTextureSupported() =>
        (MaybeBool<BOOL>)(BOOL)MSAA64KBAlignedTextureSupportedRaw();

    // D3D12_OPTIONS4
    public readonly BOOL MSAA64KBAlignedTextureSupportedRaw() =>
        m_dOptions4.MSAA64KBAlignedTextureSupported;

    // D3D12_OPTIONS12
    public readonly D3D12_TRI_STATE MSPrimitivesPipelineStatisticIncludesCulledPrimitives() =>
        m_dOptions12.MSPrimitivesPipelineStatisticIncludesCulledPrimitives;

    // MUTLTISAMPLE_QUALITY_LEVELS
    public readonly HRESULT MultisampleQualityLevels(
        DXGI_FORMAT Format,
        uint SampleCount,
        D3D12_MULTISAMPLE_QUALITY_LEVEL_FLAGS Flags,
        [NativeTypeName("UINT &")] out uint NumQualityLevels
    )
    {
        D3D12_FEATURE_DATA_MULTISAMPLE_QUALITY_LEVELS dMultisampleQualityLevels;
        dMultisampleQualityLevels.Format = Format;
        dMultisampleQualityLevels.SampleCount = SampleCount;
        dMultisampleQualityLevels.Flags = Flags;
        HRESULT result = m_pDevice.CheckFeatureSupport(
            D3D12_FEATURE_MULTISAMPLE_QUALITY_LEVELS,
            &dMultisampleQualityLevels,
            (uint)(sizeof(D3D12_FEATURE_DATA_MULTISAMPLE_QUALITY_LEVELS))
        );
        if (SUCCEEDED(result))
        {
            NumQualityLevels = dMultisampleQualityLevels.NumQualityLevels;
        }
        else
        {
            NumQualityLevels = 0;
        }
        return result;
    }

    [Transformed]
    public readonly MaybeBool<BOOL> NarrowQuadrilateralLinesSupported() =>
        (MaybeBool<BOOL>)(BOOL)NarrowQuadrilateralLinesSupportedRaw();

    public readonly BOOL NarrowQuadrilateralLinesSupportedRaw() =>
        m_dOptions19.NarrowQuadrilateralLinesSupported;

    [Transformed]
    public readonly MaybeBool<BOOL> Native16BitShaderOpsSupported() =>
        (MaybeBool<BOOL>)(BOOL)Native16BitShaderOpsSupportedRaw();

    public readonly BOOL Native16BitShaderOpsSupportedRaw() =>
        m_dOptions4.Native16BitShaderOpsSupported;

    [Transformed]
    // D3D12_OPTIONS17
    public readonly MaybeBool<BOOL> NonNormalizedCoordinateSamplersSupported() =>
        (MaybeBool<BOOL>)(BOOL)NonNormalizedCoordinateSamplersSupportedRaw();

    // D3D12_OPTIONS17
    public readonly BOOL NonNormalizedCoordinateSamplersSupportedRaw() =>
        m_dOptions17.NonNormalizedCoordinateSamplersSupported;

    [Transformed]
    public readonly MaybeBool<BOOL> OutputMergerLogicOp() =>
        (MaybeBool<BOOL>)(BOOL)OutputMergerLogicOpRaw();

    public readonly BOOL OutputMergerLogicOpRaw() => m_dOptions.OutputMergerLogicOp;

    [Transformed]
    public readonly MaybeBool<BOOL> PerPrimitiveShadingRateSupportedWithViewportIndexing() =>
        (MaybeBool<BOOL>)(BOOL)PerPrimitiveShadingRateSupportedWithViewportIndexingRaw();

    public readonly BOOL PerPrimitiveShadingRateSupportedWithViewportIndexingRaw() =>
        m_dOptions6.PerPrimitiveShadingRateSupportedWithViewportIndexing;

    [Transformed]
    public readonly MaybeBool<BOOL> PointSamplingAddressesNeverRoundUp() =>
        (MaybeBool<BOOL>)(BOOL)PointSamplingAddressesNeverRoundUpRaw();

    public readonly BOOL PointSamplingAddressesNeverRoundUpRaw() =>
        m_dOptions19.PointSamplingAddressesNeverRoundUp;

    public readonly D3D12_PROGRAMMABLE_SAMPLE_POSITIONS_TIER ProgrammableSamplePositionsTier() =>
        m_dOptions2.ProgrammableSamplePositionsTier;

    // PROTECTED_RESOURCE_SESSION_SUPPORT
    public readonly D3D12_PROTECTED_RESOURCE_SESSION_SUPPORT_FLAGS ProtectedResourceSessionSupport(
        uint NodeIndex = 0
    ) => m_dProtectedResourceSessionSupport[NodeIndex].Support;

    // PROTECTED_RESOURCE_SESSION_TYPE_COUNT
    public readonly uint ProtectedResourceSessionTypeCount(uint NodeIndex = 0) =>
        m_dProtectedResourceSessionTypeCount[NodeIndex].Count;

    [return: NativeTypeName("std::vector<GUID>")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public readonly Ptr<Guid> ProtectedResourceSessionTypes(uint NodeIndex = 0) =>
        (Guid*)ProtectedResourceSessionTypesRaw(NodeIndex);

    // PROTECTED_RESOURCE_SESSION_TYPES
    [return: NativeTypeName("std::vector<GUID>")]
    public readonly Guid* ProtectedResourceSessionTypesRaw(uint NodeIndex = 0) =>
        m_dProtectedResourceSessionTypes[NodeIndex].TypeVec;

    [Transformed]
    public readonly MaybeBool<BOOL> PSSpecifiedStencilRefSupported() =>
        (MaybeBool<BOOL>)(BOOL)PSSpecifiedStencilRefSupportedRaw();

    public readonly BOOL PSSpecifiedStencilRefSupportedRaw() =>
        m_dOptions.PSSpecifiedStencilRefSupported;

    // Helper function to decide the highest feature level
    private HRESULT QueryHighestFeatureLevel()
    {
        HRESULT result;
        // Check against a list of all feature levels present in d3dcommon.h
        // Needs to be updated for future feature levels
        const int numLevels = 12;
        D3D_FEATURE_LEVEL* allLevels =
            stackalloc D3D_FEATURE_LEVEL[numLevels] {
                D3D_FEATURE_LEVEL_12_2,
                D3D_FEATURE_LEVEL_12_1,
                D3D_FEATURE_LEVEL_12_0,
                D3D_FEATURE_LEVEL_11_1,
                D3D_FEATURE_LEVEL_11_0,
                D3D_FEATURE_LEVEL_10_1,
                D3D_FEATURE_LEVEL_10_0,
                D3D_FEATURE_LEVEL_9_3,
                D3D_FEATURE_LEVEL_9_2,
                D3D_FEATURE_LEVEL_9_1,
                D3D_FEATURE_LEVEL_1_0_CORE,
                D3D_FEATURE_LEVEL_1_0_GENERIC,
            };
        D3D12_FEATURE_DATA_FEATURE_LEVELS dFeatureLevel;
        dFeatureLevel.NumFeatureLevels = numLevels;
        dFeatureLevel.pFeatureLevelsRequested = allLevels;
        result = m_pDevice.CheckFeatureSupport(
            D3D12_FEATURE_FEATURE_LEVELS,
            &dFeatureLevel,
            (uint)(sizeof(D3D12_FEATURE_DATA_FEATURE_LEVELS))
        );
        if (SUCCEEDED(result))
        {
            m_eMaxFeatureLevel = dFeatureLevel.MaxSupportedFeatureLevel;
        }
        else
        {
            m_eMaxFeatureLevel = (D3D_FEATURE_LEVEL)(0);
            if (result == DXGI_ERROR_UNSUPPORTED)
            {
                // Indicates that none supported. Continue initialization
                result = S_OK;
            }
        }
        return result;
    }

    // Helper function to decide the highest root signature supported
    // Must be updated whenever a new root signature version is added to the d3d12.h header
    private HRESULT QueryHighestRootSignatureVersion()
    {
        HRESULT result;
        const int numRootSignatureVersions = 4;
        D3D_ROOT_SIGNATURE_VERSION* allRootSignatureVersions =
            stackalloc D3D_ROOT_SIGNATURE_VERSION[numRootSignatureVersions] {
                D3D_ROOT_SIGNATURE_VERSION_1_2,
                D3D_ROOT_SIGNATURE_VERSION_1_1,
                D3D_ROOT_SIGNATURE_VERSION_1_0,
                D3D_ROOT_SIGNATURE_VERSION_1,
            };
        fixed (CD3DX12FeatureSupport* pThis = &this)
        {
            for (nuint i = 0; i < numRootSignatureVersions; i++)
            {
                m_dRootSignature.HighestVersion = allRootSignatureVersions[i];
                result = m_pDevice.CheckFeatureSupport(
                    D3D12_FEATURE_ROOT_SIGNATURE,
                    &pThis->m_dRootSignature,
                    (uint)(sizeof(D3D12_FEATURE_DATA_ROOT_SIGNATURE))
                );
                if (result != E_INVALIDARG)
                {
                    if (FAILED(result))
                    {
                        m_dRootSignature.HighestVersion = (D3D_ROOT_SIGNATURE_VERSION)(0);
                    }
                    // If succeeded, the highest version is already written into the member struct
                    return result;
                }
            }
        }
        // No version left. Set to invalid value and continue.
        m_dRootSignature.HighestVersion = (D3D_ROOT_SIGNATURE_VERSION)(0);
        return S_OK;
    }

    // Helper function to decide the highest shader model supported by the system
    // Stores the result in m_dShaderModel
    // Must be updated whenever a new shader model is added to the d3d12.h header
    private HRESULT QueryHighestShaderModel()
    {
        // Check support in descending order
        HRESULT result;
        const int numModelVersions = 10;
        D3D_SHADER_MODEL* allModelVersions =
            stackalloc D3D_SHADER_MODEL[numModelVersions] {
                D3D_SHADER_MODEL_6_8,
                D3D_SHADER_MODEL_6_7,
                D3D_SHADER_MODEL_6_6,
                D3D_SHADER_MODEL_6_5,
                D3D_SHADER_MODEL_6_4,
                D3D_SHADER_MODEL_6_3,
                D3D_SHADER_MODEL_6_2,
                D3D_SHADER_MODEL_6_1,
                D3D_SHADER_MODEL_6_0,
                D3D_SHADER_MODEL_5_1,
            };
        fixed (CD3DX12FeatureSupport* pThis = &this)
        {
            for (nuint i = 0; i < numModelVersions; i++)
            {
                m_dShaderModel.HighestShaderModel = allModelVersions[i];
                result = m_pDevice.CheckFeatureSupport(
                    D3D12_FEATURE_SHADER_MODEL,
                    &pThis->m_dShaderModel,
                    (uint)(sizeof(D3D12_FEATURE_DATA_SHADER_MODEL))
                );
                if (result != E_INVALIDARG)
                {
                    // Indicates that the version is recognizable by the runtime and stored in the struct
                    // Also terminate on unexpected error code
                    if (FAILED(result))
                    {
                        m_dShaderModel.HighestShaderModel = (D3D_SHADER_MODEL)(0);
                    }
                    return result;
                }
            }
        }
        // Shader model may not be supported. Continue the rest initializations
        m_dShaderModel.HighestShaderModel = (D3D_SHADER_MODEL)(0);
        return S_OK;
    }

    // QUERY_META_COMMAND
    public readonly HRESULT QueryMetaCommand(
        [NativeTypeName("D3D12_FEATURE_DATA_QUERY_META_COMMAND &")]
            out D3D12_FEATURE_DATA_QUERY_META_COMMAND dQueryMetaCommand
    )
    {
        fixed (D3D12_FEATURE_DATA_QUERY_META_COMMAND* pQueryMetaCommand = &dQueryMetaCommand)
        {
            return m_pDevice.CheckFeatureSupport(
                D3D12_FEATURE_QUERY_META_COMMAND,
                pQueryMetaCommand,
                (uint)(sizeof(D3D12_FEATURE_DATA_QUERY_META_COMMAND))
            );
        }
    }

    // Helper function to initialize local protected resource session types structs
    private HRESULT QueryProtectedResourceSessionTypes(uint NodeIndex, uint Count)
    {
        ref ProtectedResourceSessionTypesLocal CurrentPRSTypes =
            ref m_dProtectedResourceSessionTypes[NodeIndex];
        CurrentPRSTypes.NodeIndex = NodeIndex;
        CurrentPRSTypes.Count = Count;
        NativeMemory.Free(CurrentPRSTypes.TypeVec);
        CurrentPRSTypes.TypeVec = (Guid*)(
            NativeMemory.Alloc(CurrentPRSTypes.Count, (uint)(sizeof(Guid)))
        );
        CurrentPRSTypes.pTypes = CurrentPRSTypes.TypeVec;
        HRESULT result = m_pDevice.CheckFeatureSupport(
            D3D12_FEATURE_PROTECTED_RESOURCE_SESSION_TYPES,
            &m_dProtectedResourceSessionTypes[NodeIndex],
            (uint)(sizeof(D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPES))
        );
        if (FAILED(result))
        {
            // Resize TypeVec to empty
            NativeMemory.Free(CurrentPRSTypes.TypeVec);
            CurrentPRSTypes.TypeVec = null;
        }
        return result;
    }

    [Transformed]
    public readonly MaybeBool<BOOL> RasterizerDesc2Supported() =>
        (MaybeBool<BOOL>)(BOOL)RasterizerDesc2SupportedRaw();

    public readonly BOOL RasterizerDesc2SupportedRaw() => m_dOptions19.RasterizerDesc2Supported;

    public readonly D3D12_RAYTRACING_TIER RaytracingTier() => m_dOptions5.RaytracingTier;

    [Transformed]
    public readonly MaybeBool<BOOL> RelaxedFormatCastingSupported() =>
        (MaybeBool<BOOL>)(BOOL)RelaxedFormatCastingSupportedRaw();

    public readonly BOOL RelaxedFormatCastingSupportedRaw() =>
        m_dOptions12.RelaxedFormatCastingSupported;

    public readonly D3D12_RENDER_PASS_TIER RenderPassesTier() => m_dOptions5.RenderPassesTier;

    [Transformed]
    // D3D12_OPTIONS18
    public readonly MaybeBool<BOOL> RenderPassesValid() =>
        (MaybeBool<BOOL>)(BOOL)RenderPassesValidRaw();

    // D3D12_OPTIONS18
    public readonly BOOL RenderPassesValidRaw() => m_dOptions18.RenderPassesValid;

    public readonly D3D12_RESOURCE_BINDING_TIER ResourceBindingTier() =>
        m_dOptions.ResourceBindingTier;

    public readonly D3D12_RESOURCE_HEAP_TIER ResourceHeapTier() => m_dOptions.ResourceHeapTier;

    [Transformed]
    public readonly MaybeBool<BOOL> ROVsSupported() => (MaybeBool<BOOL>)(BOOL)ROVsSupportedRaw();

    public readonly BOOL ROVsSupportedRaw() => m_dOptions.ROVsSupported;

    public readonly D3D12_SAMPLER_FEEDBACK_TIER SamplerFeedbackTier() =>
        m_dOptions7.SamplerFeedbackTier;

    // SHADER_CACHE
    public readonly D3D12_SHADER_CACHE_SUPPORT_FLAGS ShaderCacheSupportFlags() =>
        m_dShaderCache.SupportFlags;

    public readonly uint ShadingRateImageTileSize() => m_dOptions6.ShadingRateImageTileSize;

    public readonly D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER SharedResourceCompatibilityTier() =>
        m_dOptions4.SharedResourceCompatibilityTier;

    [Transformed]
    // D3D12_OPTIONS5
    public readonly MaybeBool<BOOL> SRVOnlyTiledResourceTier3() =>
        (MaybeBool<BOOL>)(BOOL)SRVOnlyTiledResourceTier3Raw();

    // D3D12_OPTIONS5
    public readonly BOOL SRVOnlyTiledResourceTier3Raw() => m_dOptions5.SRVOnlyTiledResourceTier3;

    [Transformed]
    public readonly MaybeBool<BOOL> StandardSwizzle64KBSupported() =>
        (MaybeBool<BOOL>)(BOOL)StandardSwizzle64KBSupportedRaw();

    public readonly BOOL StandardSwizzle64KBSupportedRaw() =>
        m_dOptions.StandardSwizzle64KBSupported;

    public readonly uint SupportedSampleCountsWithNoOutputs() =>
        m_dOptions19.SupportedSampleCountsWithNoOutputs;

    [Transformed]
    public readonly MaybeBool<BOOL> TextureCopyBetweenDimensionsSupported() =>
        (MaybeBool<BOOL>)(BOOL)TextureCopyBetweenDimensionsSupportedRaw();

    public readonly BOOL TextureCopyBetweenDimensionsSupportedRaw() =>
        m_dOptions13.TextureCopyBetweenDimensionsSupported;

    [Transformed]
    // ARCHITECTURE1
    public readonly MaybeBool<BOOL> TileBasedRenderer(uint NodeIndex = 0) =>
        (MaybeBool<BOOL>)(BOOL)TileBasedRendererRaw(NodeIndex);

    // ARCHITECTURE1
    public readonly BOOL TileBasedRendererRaw(uint NodeIndex = 0) =>
        m_dArchitecture1[NodeIndex].TileBasedRenderer;

    public readonly D3D12_TILED_RESOURCES_TIER TiledResourcesTier() =>
        m_dOptions.TiledResourcesTier;

    public readonly uint TotalLaneCount() => m_dOptions1.TotalLaneCount;

    [Transformed]
    // D3D12_OPTIONS15
    public readonly MaybeBool<BOOL> TriangleFanSupported() =>
        (MaybeBool<BOOL>)(BOOL)TriangleFanSupportedRaw();

    // D3D12_OPTIONS15
    public readonly BOOL TriangleFanSupportedRaw() => m_dOptions15.TriangleFanSupported;

    [Transformed]
    public readonly MaybeBool<BOOL> TypedUAVLoadAdditionalFormats() =>
        (MaybeBool<BOOL>)(BOOL)TypedUAVLoadAdditionalFormatsRaw();

    public readonly BOOL TypedUAVLoadAdditionalFormatsRaw() =>
        m_dOptions.TypedUAVLoadAdditionalFormats;

    [Transformed]
    public readonly MaybeBool<BOOL> UMA(uint NodeIndex = 0) =>
        (MaybeBool<BOOL>)(BOOL)UMARaw(NodeIndex);

    public readonly BOOL UMARaw(uint NodeIndex = 0) => m_dArchitecture1[NodeIndex].UMA;

    [Transformed]
    // D3D12_OPTIONS8
    public readonly MaybeBool<BOOL> UnalignedBlockTexturesSupported() =>
        (MaybeBool<BOOL>)(BOOL)UnalignedBlockTexturesSupportedRaw();

    // D3D12_OPTIONS8
    public readonly BOOL UnalignedBlockTexturesSupportedRaw() =>
        m_dOptions8.UnalignedBlockTexturesSupported;

    [Transformed]
    // D3D12_OPTIONS13
    public readonly MaybeBool<BOOL> UnrestrictedBufferTextureCopyPitchSupported() =>
        (MaybeBool<BOOL>)(BOOL)UnrestrictedBufferTextureCopyPitchSupportedRaw();

    // D3D12_OPTIONS13
    public readonly BOOL UnrestrictedBufferTextureCopyPitchSupportedRaw() =>
        m_dOptions13.UnrestrictedBufferTextureCopyPitchSupported;

    [Transformed]
    public readonly MaybeBool<BOOL> UnrestrictedVertexElementAlignmentSupported() =>
        (MaybeBool<BOOL>)(BOOL)UnrestrictedVertexElementAlignmentSupportedRaw();

    public readonly BOOL UnrestrictedVertexElementAlignmentSupportedRaw() =>
        m_dOptions13.UnrestrictedVertexElementAlignmentSupported;

    [Transformed]
    // D3D12_OPTIONS10
    public readonly MaybeBool<BOOL> VariableRateShadingSumCombinerSupported() =>
        (MaybeBool<BOOL>)(BOOL)VariableRateShadingSumCombinerSupportedRaw();

    // D3D12_OPTIONS10
    public readonly BOOL VariableRateShadingSumCombinerSupportedRaw() =>
        m_dOptions10.VariableRateShadingSumCombinerSupported;

    public readonly D3D12_VARIABLE_SHADING_RATE_TIER VariableShadingRateTier() =>
        m_dOptions6.VariableShadingRateTier;

    public readonly D3D12_VIEW_INSTANCING_TIER ViewInstancingTier() =>
        m_dOptions3.ViewInstancingTier;

    [Transformed]
    public readonly MaybeBool<BOOL> VPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulation() =>
        (MaybeBool<BOOL>)
            (BOOL)VPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulationRaw();

    public readonly BOOL VPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulationRaw() =>
        m_dOptions.VPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulation;

    public readonly uint WaveLaneCountMax() => m_dOptions1.WaveLaneCountMax;

    public readonly uint WaveLaneCountMin() => m_dOptions1.WaveLaneCountMin;

    public readonly D3D12_WAVE_MMA_TIER WaveMMATier() => m_dOptions9.WaveMMATier;

    [Transformed]
    // D3D12_OPTIONS1
    public readonly MaybeBool<BOOL> WaveOps() => (MaybeBool<BOOL>)(BOOL)WaveOpsRaw();

    // D3D12_OPTIONS1
    public readonly BOOL WaveOpsRaw() => m_dOptions1.WaveOps;

    [Transformed]
    public readonly MaybeBool<BOOL> WriteableMSAATexturesSupported() =>
        (MaybeBool<BOOL>)(BOOL)WriteableMSAATexturesSupportedRaw();

    public readonly BOOL WriteableMSAATexturesSupportedRaw() =>
        m_dOptions14.WriteableMSAATexturesSupported;

    public readonly D3D12_COMMAND_LIST_SUPPORT_FLAGS WriteBufferImmediateSupportFlags() =>
        m_dOptions3.WriteBufferImmediateSupportFlags;
}
