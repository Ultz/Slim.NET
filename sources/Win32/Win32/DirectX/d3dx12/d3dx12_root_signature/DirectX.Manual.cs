// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_root_signature.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
using static Silk.NET.DirectX.D3D_ROOT_SIGNATURE_VERSION;
using static Silk.NET.DirectX.D3D12_ROOT_PARAMETER_TYPE;
using static Silk.NET.DirectX.D3D12_SAMPLER_FLAGS;
using static Silk.NET.Win32.E;
using static Silk.NET.Win32.S;
using static Silk.NET.Win32.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DX12SerializeVersionedRootSignature"]/*'/>

    public static HRESULT D3DX12SerializeVersionedRootSignature(
        [NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")]
            D3D12_VERSIONED_ROOT_SIGNATURE_DESC* pRootSignatureDesc,
        D3D_ROOT_SIGNATURE_VERSION MaxVersion,
        ID3DBlob* ppBlob,
        ID3DBlob* ppErrorBlob
    )
    {
        if (ppErrorBlob != null)
        {
            *ppErrorBlob = default;
        }
        switch (MaxVersion)
        {
            case D3D_ROOT_SIGNATURE_VERSION_1_0:
            {
                switch (pRootSignatureDesc->Version)
                {
                    case D3D_ROOT_SIGNATURE_VERSION_1_0:
                    {
                        return D3D12SerializeRootSignature(
                            &pRootSignatureDesc->Anonymous.Desc_1_0,
                            D3D_ROOT_SIGNATURE_VERSION_1,
                            ppBlob,
                            ppErrorBlob
                        );
                    }
                    case D3D_ROOT_SIGNATURE_VERSION_1_1:
                    case D3D_ROOT_SIGNATURE_VERSION_1_2:
                    {
                        HRESULT hr = S_OK;
                        D3D12_ROOT_SIGNATURE_DESC1* desc_1_1 = &pRootSignatureDesc
                            ->Anonymous
                            .Desc_1_1;
                        nuint ParametersSize =
                            (uint)sizeof(D3D12_ROOT_PARAMETER) * (nuint)desc_1_1->NumParameters;
                        void* pParameters =
                            (ParametersSize > 0)
                                ? HeapAllocRaw(GetProcessHeap(), 0, ParametersSize)
                                : null;
                        if ((ParametersSize > 0) && (pParameters == null))
                        {
                            hr = E_OUTOFMEMORY;
                        }
                        D3D12_ROOT_PARAMETER* pParameters_1_0 = (D3D12_ROOT_PARAMETER*)(
                            pParameters
                        );
                        if (SUCCEEDED(hr))
                        {
                            for (uint n = 0; n < desc_1_1->NumParameters; n++)
                            {
                                Debug.Assert(
                                    ParametersSize
                                        == (uint)sizeof(D3D12_ROOT_PARAMETER)
                                            * (nuint)desc_1_1->NumParameters
                                );
                                pParameters_1_0[n].ParameterType = desc_1_1
                                    ->pParameters[n]
                                    .ParameterType;
                                pParameters_1_0[n].ShaderVisibility = desc_1_1
                                    ->pParameters[n]
                                    .ShaderVisibility;
                                switch (desc_1_1->pParameters[n].ParameterType)
                                {
                                    case D3D12_ROOT_PARAMETER_TYPE_32BIT_CONSTANTS:
                                    {
                                        pParameters_1_0[n].Anonymous.Constants.Num32BitValues =
                                            desc_1_1
                                                ->pParameters[n]
                                                .Anonymous
                                                .Constants
                                                .Num32BitValues;
                                        pParameters_1_0[n].Anonymous.Constants.RegisterSpace =
                                            desc_1_1
                                                ->pParameters[n]
                                                .Anonymous
                                                .Constants
                                                .RegisterSpace;
                                        pParameters_1_0[n].Anonymous.Constants.ShaderRegister =
                                            desc_1_1
                                                ->pParameters[n]
                                                .Anonymous
                                                .Constants
                                                .ShaderRegister;
                                        break;
                                    }
                                    case D3D12_ROOT_PARAMETER_TYPE_CBV:
                                    case D3D12_ROOT_PARAMETER_TYPE_SRV:
                                    case D3D12_ROOT_PARAMETER_TYPE_UAV:
                                    {
                                        pParameters_1_0[n].Anonymous.Descriptor.RegisterSpace =
                                            desc_1_1
                                                ->pParameters[n]
                                                .Anonymous
                                                .Descriptor
                                                .RegisterSpace;
                                        pParameters_1_0[n].Anonymous.Descriptor.ShaderRegister =
                                            desc_1_1
                                                ->pParameters[n]
                                                .Anonymous
                                                .Descriptor
                                                .ShaderRegister;
                                        break;
                                    }
                                    case D3D12_ROOT_PARAMETER_TYPE_DESCRIPTOR_TABLE:
                                    {
                                        D3D12_ROOT_DESCRIPTOR_TABLE1* table_1_1 = &desc_1_1
                                            ->pParameters[n]
                                            .Anonymous
                                            .DescriptorTable;
                                        nuint DescriptorRangesSize =
                                            20 * table_1_1->NumDescriptorRanges;
                                        void* pDescriptorRanges =
                                            ((DescriptorRangesSize > 0) && SUCCEEDED(hr))
                                                ? HeapAllocRaw(
                                                    GetProcessHeap(),
                                                    0,
                                                    DescriptorRangesSize
                                                )
                                                : null;
                                        if (
                                            unchecked(DescriptorRangesSize > 0)
                                            && pDescriptorRanges == null
                                        )
                                        {
                                            hr = E_OUTOFMEMORY;
                                        }
                                        D3D12_DESCRIPTOR_RANGE* pDescriptorRanges_1_0 =
                                            (D3D12_DESCRIPTOR_RANGE*)(pDescriptorRanges);
                                        if (SUCCEEDED(hr))
                                        {
                                            for (
                                                uint x = 0;
                                                x < table_1_1->NumDescriptorRanges;
                                                x++
                                            )
                                            {
                                                Debug.Assert(
                                                    DescriptorRangesSize
                                                        == (
                                                            (uint)sizeof(D3D12_DESCRIPTOR_RANGE)
                                                            * (nuint)table_1_1->NumDescriptorRanges
                                                        )
                                                );
                                                pDescriptorRanges_1_0[x].BaseShaderRegister =
                                                    table_1_1
                                                        ->pDescriptorRanges[x]
                                                        .BaseShaderRegister;
                                                pDescriptorRanges_1_0[x].NumDescriptors = table_1_1
                                                    ->pDescriptorRanges[x]
                                                    .NumDescriptors;
                                                pDescriptorRanges_1_0[
                                                    x
                                                ].OffsetInDescriptorsFromTableStart = table_1_1
                                                    ->pDescriptorRanges[x]
                                                    .OffsetInDescriptorsFromTableStart;
                                                pDescriptorRanges_1_0[x].RangeType = table_1_1
                                                    ->pDescriptorRanges[x]
                                                    .RangeType;
                                                pDescriptorRanges_1_0[x].RegisterSpace = table_1_1
                                                    ->pDescriptorRanges[x]
                                                    .RegisterSpace;
                                            }
                                        }
                                        D3D12_ROOT_DESCRIPTOR_TABLE* table_1_0 = &pParameters_1_0[n]
                                            .Anonymous
                                            .DescriptorTable;
                                        table_1_0->NumDescriptorRanges =
                                            table_1_1->NumDescriptorRanges;
                                        table_1_0->pDescriptorRanges = pDescriptorRanges_1_0;
                                        break;
                                    }
                                }
                            }
                        }
                        D3D12_STATIC_SAMPLER_DESC* pStaticSamplers = null;
                        if (
                            (desc_1_1->NumStaticSamplers > 0)
                            && (pRootSignatureDesc->Version == D3D_ROOT_SIGNATURE_VERSION_1_2)
                        )
                        {
                            nuint SamplersSize = 52 * desc_1_1->NumStaticSamplers;
                            pStaticSamplers = (D3D12_STATIC_SAMPLER_DESC*)(
                                HeapAllocRaw(GetProcessHeap(), 0, SamplersSize)
                            );
                            if (pStaticSamplers == null)
                            {
                                hr = E_OUTOFMEMORY;
                            }
                            else
                            {
                                D3D12_ROOT_SIGNATURE_DESC2* desc_1_2 = &pRootSignatureDesc
                                    ->Anonymous
                                    .Desc_1_2;
                                for (uint n = 0; n < desc_1_1->NumStaticSamplers; ++n)
                                {
                                    if (
                                        (
                                            desc_1_2->pStaticSamplers[n].Flags
                                            & ~D3D12_SAMPLER_FLAG_UINT_BORDER_COLOR
                                        ) != 0
                                    )
                                    {
                                        hr = E_INVALIDARG;
                                        break;
                                    }
                                    NativeMemory.Copy(
                                        desc_1_2->pStaticSamplers + n,
                                        pStaticSamplers + n,
                                        (uint)(sizeof(D3D12_STATIC_SAMPLER_DESC))
                                    );
                                }
                            }
                        }
                        if (SUCCEEDED(hr))
                        {
                            D3D12_ROOT_SIGNATURE_DESC desc_1_0 = new D3D12_ROOT_SIGNATURE_DESC(
                                desc_1_1->NumParameters,
                                pParameters_1_0,
                                desc_1_1->NumStaticSamplers,
                                (pStaticSamplers == null)
                                    ? desc_1_1->pStaticSamplers
                                    : pStaticSamplers,
                                desc_1_1->Flags
                            );
                            hr = D3D12SerializeRootSignature(
                                &desc_1_0,
                                D3D_ROOT_SIGNATURE_VERSION_1,
                                ppBlob,
                                ppErrorBlob
                            );
                        }
                        if (pParameters != null)
                        {
                            for (uint n = 0; n < desc_1_1->NumParameters; n++)
                            {
                                if (
                                    desc_1_1->pParameters[n].ParameterType
                                    == D3D12_ROOT_PARAMETER_TYPE_DESCRIPTOR_TABLE
                                )
                                {
                                    D3D12_DESCRIPTOR_RANGE* pDescriptorRanges_1_0 = pParameters_1_0[
                                        n
                                    ]
                                        .Anonymous
                                        .DescriptorTable
                                        .pDescriptorRanges;
                                    _ = HeapFree(
                                        GetProcessHeap(),
                                        0,
                                        (void*)(pDescriptorRanges_1_0)
                                    );
                                }
                            }
                            _ = HeapFree(GetProcessHeap(), 0, pParameters);
                        }
                        if ((pStaticSamplers) != null)
                        {
                            _ = HeapFree(GetProcessHeap(), 0, pStaticSamplers);
                        }
                        return hr;
                    }
                }
                break;
            }
            case D3D_ROOT_SIGNATURE_VERSION_1_1:
            {
                switch (pRootSignatureDesc->Version)
                {
                    case D3D_ROOT_SIGNATURE_VERSION_1_0:
                    case D3D_ROOT_SIGNATURE_VERSION_1_1:
                    {
                        return D3D12SerializeVersionedRootSignature(
                            pRootSignatureDesc,
                            ppBlob,
                            ppErrorBlob
                        );
                    }
                    case D3D_ROOT_SIGNATURE_VERSION_1_2:
                    {
                        HRESULT hr = S_OK;
                        D3D12_ROOT_SIGNATURE_DESC1* desc_1_1 = &pRootSignatureDesc
                            ->Anonymous
                            .Desc_1_1;
                        D3D12_STATIC_SAMPLER_DESC* pStaticSamplers = null;
                        if (desc_1_1->NumStaticSamplers > 0)
                        {
                            nuint SamplersSize = 52 * desc_1_1->NumStaticSamplers;
                            pStaticSamplers = (D3D12_STATIC_SAMPLER_DESC*)(
                                HeapAllocRaw(GetProcessHeap(), 0, SamplersSize)
                            );
                            if (pStaticSamplers == null)
                            {
                                hr = E_OUTOFMEMORY;
                            }
                            else
                            {
                                D3D12_ROOT_SIGNATURE_DESC2* desc_1_2 = &pRootSignatureDesc
                                    ->Anonymous
                                    .Desc_1_2;
                                for (uint n = 0; n < desc_1_1->NumStaticSamplers; ++n)
                                {
                                    if (
                                        (
                                            desc_1_2->pStaticSamplers[n].Flags
                                            & ~D3D12_SAMPLER_FLAG_UINT_BORDER_COLOR
                                        ) != 0
                                    )
                                    {
                                        hr = E_INVALIDARG;
                                        break;
                                    }
                                    NativeMemory.Copy(
                                        desc_1_2->pStaticSamplers + n,
                                        pStaticSamplers + n,
                                        (uint)(sizeof(D3D12_STATIC_SAMPLER_DESC))
                                    );
                                }
                            }
                        }
                        if (SUCCEEDED(hr))
                        {
                            D3D12_VERSIONED_ROOT_SIGNATURE_DESC desc =
                                new D3D12_VERSIONED_ROOT_SIGNATURE_DESC(
                                    desc_1_1->NumParameters,
                                    desc_1_1->pParameters,
                                    desc_1_1->NumStaticSamplers,
                                    pStaticSamplers == null
                                        ? desc_1_1->pStaticSamplers
                                        : pStaticSamplers,
                                    desc_1_1->Flags
                                );
                            hr = D3D12SerializeVersionedRootSignature(&desc, ppBlob, ppErrorBlob);
                        }
                        if ((pStaticSamplers) != null)
                        {
                            _ = HeapFree(GetProcessHeap(), 0, pStaticSamplers);
                        }
                        return hr;
                    }
                }
                break;
            }
            case D3D_ROOT_SIGNATURE_VERSION_1_2:
            {
                return D3D12SerializeVersionedRootSignature(
                    pRootSignatureDesc,
                    ppBlob,
                    ppErrorBlob
                );
            }
        }
        return E_INVALIDARG;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT D3DX12SerializeVersionedRootSignature(
        [NativeTypeName("const D3D12_VERSIONED_ROOT_SIGNATURE_DESC *")]
            Ref<D3D12_VERSIONED_ROOT_SIGNATURE_DESC> pRootSignatureDesc,
        D3D_ROOT_SIGNATURE_VERSION MaxVersion,
        Ref<ID3DBlob> ppBlob,
        Ref<ID3DBlob> ppErrorBlob
    )
    {
        fixed (ID3DBlob* __dsl_ppErrorBlob = ppErrorBlob)
        fixed (ID3DBlob* __dsl_ppBlob = ppBlob)
        fixed (D3D12_VERSIONED_ROOT_SIGNATURE_DESC* __dsl_pRootSignatureDesc = pRootSignatureDesc)
        {
            return (HRESULT)D3DX12SerializeVersionedRootSignature(
                __dsl_pRootSignatureDesc,
                MaxVersion,
                __dsl_ppBlob,
                __dsl_ppErrorBlob
            );
        }
    }
}
