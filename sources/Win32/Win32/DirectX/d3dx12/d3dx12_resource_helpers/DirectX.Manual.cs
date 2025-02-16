// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_resource_helpers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
using static Silk.NET.DirectX.D3D12;
using static Silk.NET.DirectX.D3D12_RESOURCE_DIMENSION;
using static Silk.NET.Win32.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    public static void D3D12DecomposeSubresource<T, U, V>(
        [NativeTypeName("UINT")] uint Subresource,
        [NativeTypeName("UINT")] uint MipLevels,
        [NativeTypeName("UINT")] uint ArraySize,
        [NativeTypeName("T &")] out T MipSlice,
        [NativeTypeName("T &")] out U ArraySlice,
        [NativeTypeName("T &")] out V PlaneSlice
    )
        where T : IBinaryInteger<T>
        where U : IBinaryInteger<U>
        where V : IBinaryInteger<V>
    {
        MipSlice = T.CreateTruncating(Subresource % MipLevels);
        ArraySlice = U.CreateTruncating((Subresource / MipLevels) % ArraySize);
        PlaneSlice = V.CreateTruncating(Subresource / (MipLevels * ArraySize));
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DX12Align"]/*'/>

    public static T D3DX12Align<T>(T uValue, T uAlign)
        where T : IBinaryInteger<T>
    {
        Debug.Assert(T.Zero == (uAlign & (uAlign - T.One)));
        T uMask = uAlign - T.One;
        T uResult = (uValue + uMask) & ~uMask;
        Debug.Assert(uResult >= uValue);
        Debug.Assert(T.Zero == (uResult % uAlign));
        return uResult;
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DX12AlignAtLeast"]/*'/>

    public static T D3DX12AlignAtLeast<T>(T uValue, T uAlign)
        where T : IBinaryInteger<T>
    {
        T aligned = D3DX12Align(uValue, uAlign);
        return (aligned > uAlign) ? aligned : uAlign;
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DX12GetCopyableFootprints"]/*'/>

    public static bool D3DX12GetCopyableFootprints(
        [NativeTypeName("const D3D12_RESOURCE_DESC1 &")] in D3D12_RESOURCE_DESC1 ResourceDesc,
        uint FirstSubresource,
        uint NumSubresources,
        [NativeTypeName("UINT64")] ulong BaseOffset,
        D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts,
        uint* pNumRows,
        [NativeTypeName("UINT64 *")] ulong* pRowSizeInBytes,
        [NativeTypeName("UINT64 *")] ulong* pTotalBytes
    )
    {
        const ulong uint64_max = ~0ul;
        ulong TotalBytes = uint64_max;
        uint uSubRes = 0;
        bool bResourceOverflow = false;
        TotalBytes = 0;
        DXGI_FORMAT Format = ResourceDesc.Format;
        Unsafe.SkipInit(out D3D12_RESOURCE_DESC1 LresourceDesc);
        ref readonly D3D12_RESOURCE_DESC1 resourceDesc = ref D3DX12ConditionallyExpandAPIDesc(
            ref LresourceDesc,
            in ResourceDesc
        );
        // Check if its a valid format
        Debug.Assert(D3D12_PROPERTY_LAYOUT_FORMAT_TABLE.FormatExists(Format));
        uint WidthAlignment = D3D12_PROPERTY_LAYOUT_FORMAT_TABLE.GetWidthAlignment(Format);
        uint HeightAlignment = D3D12_PROPERTY_LAYOUT_FORMAT_TABLE.GetHeightAlignment(Format);
        ushort DepthAlignment = (ushort)(
            D3D12_PROPERTY_LAYOUT_FORMAT_TABLE.GetDepthAlignment(Format)
        );
        for (; uSubRes < NumSubresources; ++uSubRes)
        {
            bool bOverflow = false;
            uint Subresource = FirstSubresource + uSubRes;
            Debug.Assert(resourceDesc.MipLevels != 0);
            uint subresourceCount =
                (uint)(resourceDesc.MipLevels)
                * resourceDesc.ArraySize()
                * D3D12_PROPERTY_LAYOUT_FORMAT_TABLE.GetPlaneCount(resourceDesc.Format);
            if (Subresource > subresourceCount)
            {
                break;
            }
            TotalBytes = D3DX12Align<ulong>(TotalBytes, D3D12_TEXTURE_DATA_PLACEMENT_ALIGNMENT);
            D3D12DecomposeSubresource(
                Subresource,
                resourceDesc.MipLevels,
                resourceDesc.ArraySize(),
                out uint MipLevel,
                out uint ArraySlice,
                out uint PlaneSlice
            );
            ulong Width = D3DX12AlignAtLeast<ulong>(
                resourceDesc.Width >> (int)(MipLevel),
                WidthAlignment
            );
            uint Height = D3DX12AlignAtLeast(
                resourceDesc.Height >> (int)(MipLevel),
                HeightAlignment
            );
            ushort Depth = D3DX12AlignAtLeast<ushort>(
                (ushort)(resourceDesc.Depth() >> (int)(MipLevel)),
                DepthAlignment
            );
            D3D12_PROPERTY_LAYOUT_FORMAT_TABLE.GetPlaneSubsampledSizeAndFormatForCopyableLayout(
                PlaneSlice,
                Format,
                (uint)(Width),
                Height,
                out DXGI_FORMAT PlaneFormat,
                out uint MinPlanePitchWidth,
                out uint PlaneWidth,
                out uint PlaneHeight
            );
            D3D12_SUBRESOURCE_FOOTPRINT LocalPlacement;
            D3D12_SUBRESOURCE_FOOTPRINT* Placement =
                (pLayouts != null) ? &pLayouts[uSubRes].Footprint : &LocalPlacement;
            Placement->Format = PlaneFormat;
            Placement->Width = PlaneWidth;
            Placement->Height = PlaneHeight;
            Placement->Depth = Depth;
            _ = D3D12_PROPERTY_LAYOUT_FORMAT_TABLE.CalculateMinimumRowMajorRowPitch(
                PlaneFormat,
                MinPlanePitchWidth,
                out uint MinPlaneRowPitch
            );
            Debug.Assert(
                (D3D12_TEXTURE_DATA_PLACEMENT_ALIGNMENT >= D3D12_TEXTURE_DATA_PITCH_ALIGNMENT)
                    && (
                        (
                            D3D12_TEXTURE_DATA_PLACEMENT_ALIGNMENT
                            % D3D12_TEXTURE_DATA_PITCH_ALIGNMENT
                        ) == 0
                    ),
                "D3D12_TEXTURE_DATA_PLACEMENT_ALIGNMENT must be >= and evenly divisible by D3D12_TEXTURE_DATA_PITCH_ALIGNMENT."
            );
            Placement->RowPitch = D3D12_PROPERTY_LAYOUT_FORMAT_TABLE.PlanarRaw(Format)
                ? D3DX12Align<uint>(MinPlaneRowPitch, D3D12_TEXTURE_DATA_PLACEMENT_ALIGNMENT)
                : D3DX12Align<uint>(MinPlaneRowPitch, D3D12_TEXTURE_DATA_PITCH_ALIGNMENT);
            if (pRowSizeInBytes != null)
            {
                _ = D3D12_PROPERTY_LAYOUT_FORMAT_TABLE.CalculateMinimumRowMajorRowPitch(
                    PlaneFormat,
                    PlaneWidth,
                    out uint PlaneRowSize
                );
                pRowSizeInBytes[uSubRes] = PlaneRowSize;
            }
            uint NumRows = 0;
            if (D3D12_PROPERTY_LAYOUT_FORMAT_TABLE.PlanarRaw(Format))
            {
                NumRows = PlaneHeight;
            }
            else
            {
                Debug.Assert((Height % HeightAlignment) == 0);
                NumRows = Height / HeightAlignment;
            }
            if (pNumRows != null)
            {
                pNumRows[uSubRes] = NumRows;
            }
            if (pLayouts != null)
            {
                pLayouts[uSubRes].Offset = (bOverflow ? uint64_max : TotalBytes + BaseOffset);
            }
            ushort NumSlices = Depth;
            ulong SubresourceSize =
                (NumRows * NumSlices - 1) * Placement->RowPitch + MinPlaneRowPitch;
            TotalBytes += SubresourceSize;
            if (TotalBytes < SubresourceSize)
            {
                TotalBytes = uint64_max;
            }
            bResourceOverflow = bResourceOverflow || bOverflow;
        }
        // Overflow error
        if (bResourceOverflow)
        {
            TotalBytes = uint64_max;
        }
        if (pLayouts != null)
        {
            NativeMemory.Fill(
                pLayouts + uSubRes,
                (nuint)(sizeof(D3D12_PLACED_SUBRESOURCE_FOOTPRINT)) * (NumSubresources - uSubRes),
                byte.MaxValue
            );
        }
        if (pNumRows != null)
        {
            NativeMemory.Fill(
                pNumRows + uSubRes,
                (nuint)(sizeof(uint)) * (NumSubresources - uSubRes),
                byte.MaxValue
            );
        }
        if (pRowSizeInBytes != null)
        {
            NativeMemory.Fill(
                pRowSizeInBytes + uSubRes,
                (nuint)(sizeof(ulong)) * (NumSubresources - uSubRes),
                byte.MaxValue
            );
        }
        if (pTotalBytes != null)
        {
            *pTotalBytes = TotalBytes;
        }
        if (TotalBytes == uint64_max)
        {
            return false;
        }
        return true;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool D3DX12GetCopyableFootprints(
        [NativeTypeName("const D3D12_RESOURCE_DESC1 &")] in D3D12_RESOURCE_DESC1 ResourceDesc,
        uint FirstSubresource,
        uint NumSubresources,
        [NativeTypeName("UINT64")] ulong BaseOffset,
        Ref<D3D12_PLACED_SUBRESOURCE_FOOTPRINT> pLayouts,
        Ref<uint> pNumRows,
        [NativeTypeName("UINT64 *")] Ref<ulong> pRowSizeInBytes,
        [NativeTypeName("UINT64 *")] Ref<ulong> pTotalBytes
    )
    {
        fixed (ulong* __dsl_pTotalBytes = pTotalBytes)
        fixed (ulong* __dsl_pRowSizeInBytes = pRowSizeInBytes)
        fixed (uint* __dsl_pNumRows = pNumRows)
        fixed (D3D12_PLACED_SUBRESOURCE_FOOTPRINT* __dsl_pLayouts = pLayouts)
        {
            return (bool)D3DX12GetCopyableFootprints(
                in ResourceDesc,
                FirstSubresource,
                NumSubresources,
                BaseOffset,
                __dsl_pLayouts,
                __dsl_pNumRows,
                __dsl_pRowSizeInBytes,
                __dsl_pTotalBytes
            );
        }
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DX12GetCopyableFootprints"]/*'/>

    public static bool D3DX12GetCopyableFootprints(
        [NativeTypeName("const D3D12_RESOURCE_DESC &")] in D3D12_RESOURCE_DESC pResourceDesc,
        uint FirstSubresource,
        uint NumSubresources,
        [NativeTypeName("UINT64")] ulong BaseOffset,
        D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts,
        uint* pNumRows,
        [NativeTypeName("UINT64 *")] ulong* pRowSizeInBytes,
        [NativeTypeName("UINT64 *")] ulong* pTotalBytes
    )
    {
        D3D12_RESOURCE_DESC1 desc = D3DX12ResourceDesc0ToDesc1(pResourceDesc);
        return D3DX12GetCopyableFootprints(
            in desc,
            FirstSubresource,
            NumSubresources,
            BaseOffset,
            pLayouts,
            pNumRows,
            pRowSizeInBytes,
            pTotalBytes
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool D3DX12GetCopyableFootprints(
        [NativeTypeName("const D3D12_RESOURCE_DESC &")] in D3D12_RESOURCE_DESC pResourceDesc,
        uint FirstSubresource,
        uint NumSubresources,
        [NativeTypeName("UINT64")] ulong BaseOffset,
        Ref<D3D12_PLACED_SUBRESOURCE_FOOTPRINT> pLayouts,
        Ref<uint> pNumRows,
        [NativeTypeName("UINT64 *")] Ref<ulong> pRowSizeInBytes,
        [NativeTypeName("UINT64 *")] Ref<ulong> pTotalBytes
    )
    {
        fixed (ulong* __dsl_pTotalBytes = pTotalBytes)
        fixed (ulong* __dsl_pRowSizeInBytes = pRowSizeInBytes)
        fixed (uint* __dsl_pNumRows = pNumRows)
        fixed (D3D12_PLACED_SUBRESOURCE_FOOTPRINT* __dsl_pLayouts = pLayouts)
        {
            return (bool)D3DX12GetCopyableFootprints(
                in pResourceDesc,
                FirstSubresource,
                NumSubresources,
                BaseOffset,
                __dsl_pLayouts,
                __dsl_pNumRows,
                __dsl_pRowSizeInBytes,
                __dsl_pTotalBytes
            );
        }
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DX12ResourceDesc0ToDesc1"]/*'/>

    public static D3D12_RESOURCE_DESC1 D3DX12ResourceDesc0ToDesc1(
        [NativeTypeName("const D3D12_RESOURCE_DESC &")] in D3D12_RESOURCE_DESC desc0
    )
    {
        D3D12_RESOURCE_DESC1 desc1 = new D3D12_RESOURCE_DESC1()
        {
            Dimension = desc0.Dimension,
            Alignment = desc0.Alignment,
            Width = desc0.Width,
            Height = desc0.Height,
            DepthOrArraySize = desc0.DepthOrArraySize,
            MipLevels = desc0.MipLevels,
            Format = desc0.Format,
            SampleDesc = new DXGI_SAMPLE_DESC
            {
                Count = desc0.SampleDesc.Count,
                Quality = desc0.SampleDesc.Quality,
            },
            Layout = desc0.Layout,
            Flags = desc0.Flags,
            SamplerFeedbackMipRegion = new D3D12_MIP_REGION
            {
                Width = 0,
                Height = 0,
                Depth = 0,
            },
        };
        return desc1;
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.GetRequiredIntermediateSize"]/*'/>

    [return: NativeTypeName("UINT64")]
    public static ulong GetRequiredIntermediateSize(
        ID3D12Resource pDestinationResource,
        uint FirstSubresource,
        uint NumSubresources
    )
    {
        D3D12_RESOURCE_DESC Desc = pDestinationResource.GetDesc();
        ulong RequiredSize = 0;
        ID3D12Device pDevice = default;
        _ = pDestinationResource.GetDevice(__uuidof<ID3D12Device.Native>(), (void**)(&pDevice));
        pDevice.GetCopyableFootprints(
            &Desc,
            FirstSubresource,
            NumSubresources,
            0,
            null,
            null,
            null,
            &RequiredSize
        );
        _ = pDevice.Release();
        return RequiredSize;
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.UpdateSubresources"]/*'/>

    [return: NativeTypeName("UINT64")]
    public static ulong UpdateSubresources(
        ID3D12GraphicsCommandList pCmdList,
        ID3D12Resource pDestinationResource,
        ID3D12Resource pIntermediate,
        uint FirstSubresource,
        uint NumSubresources,
        [NativeTypeName("UINT64")] ulong RequiredSize,
        [NativeTypeName("const D3D12_PLACED_SUBRESOURCE_FOOTPRINT *")]
            D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts,
        [NativeTypeName("const UINT *")] uint* pNumRows,
        [NativeTypeName("const UINT64 *")] ulong* pRowSizesInBytes,
        [NativeTypeName("const D3D12_SUBRESOURCE_DATA *")] D3D12_SUBRESOURCE_DATA* pSrcData
    )
    {
        D3D12_RESOURCE_DESC IntermediateDesc = pIntermediate.GetDesc();
        D3D12_RESOURCE_DESC DestinationDesc = pDestinationResource.GetDesc();
        if (
            (IntermediateDesc.Dimension != D3D12_RESOURCE_DIMENSION_BUFFER)
            || (IntermediateDesc.Width < (RequiredSize + pLayouts[0].Offset))
            || (RequiredSize > nuint.MaxValue)
            || (
                (DestinationDesc.Dimension == D3D12_RESOURCE_DIMENSION_BUFFER)
                && ((FirstSubresource != 0) || (NumSubresources != 1))
            )
        )
        {
            return 0;
        }
        byte* pData;
        HRESULT hr = pIntermediate.Map(0, null, (void**)(&pData));
        if (FAILED(hr))
        {
            return 0;
        }
        for (uint i = 0; i < NumSubresources; ++i)
        {
            if (pRowSizesInBytes[i] > nuint.MaxValue)
            {
                return 0;
            }
            D3D12_MEMCPY_DEST DestData = new D3D12_MEMCPY_DEST
            {
                pData = pData + pLayouts[i].Offset,
                RowPitch = pLayouts[i].Footprint.RowPitch,
                SlicePitch = unchecked(
                    (nuint)(pLayouts[i].Footprint.RowPitch) * (nuint)(pNumRows[i])
                ),
            };
            MemcpySubresource(
                &DestData,
                &pSrcData[i],
                unchecked((nuint)(pRowSizesInBytes[i])),
                pNumRows[i],
                pLayouts[i].Footprint.Depth
            );
        }
        pIntermediate.Unmap(0, null);
        if (DestinationDesc.Dimension == D3D12_RESOURCE_DIMENSION_BUFFER)
        {
            pCmdList.CopyBufferRegion(
                pDestinationResource,
                0,
                pIntermediate,
                pLayouts[0].Offset,
                pLayouts[0].Footprint.Width
            );
        }
        else
        {
            for (uint i = 0; i < NumSubresources; ++i)
            {
                D3D12_TEXTURE_COPY_LOCATION Dst = new D3D12_TEXTURE_COPY_LOCATION(
                    pDestinationResource,
                    i + FirstSubresource
                );
                D3D12_TEXTURE_COPY_LOCATION Src = new D3D12_TEXTURE_COPY_LOCATION(
                    pIntermediate,
                    &pLayouts[i]
                );
                pCmdList.CopyTextureRegion(&Dst, 0, 0, 0, &Src, null);
            }
        }
        return RequiredSize;
    }

    [return: NativeTypeName("UINT64")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong UpdateSubresources(
        ID3D12GraphicsCommandList pCmdList,
        ID3D12Resource pDestinationResource,
        ID3D12Resource pIntermediate,
        uint FirstSubresource,
        uint NumSubresources,
        [NativeTypeName("UINT64")] ulong RequiredSize,
        [NativeTypeName("const D3D12_PLACED_SUBRESOURCE_FOOTPRINT *")]
            Ref<D3D12_PLACED_SUBRESOURCE_FOOTPRINT> pLayouts,
        [NativeTypeName("const UINT *")] Ref<uint> pNumRows,
        [NativeTypeName("const UINT64 *")] Ref<ulong> pRowSizesInBytes,
        [NativeTypeName("const D3D12_SUBRESOURCE_DATA *")] Ref<D3D12_SUBRESOURCE_DATA> pSrcData
    )
    {
        fixed (D3D12_SUBRESOURCE_DATA* __dsl_pSrcData = pSrcData)
        fixed (ulong* __dsl_pRowSizesInBytes = pRowSizesInBytes)
        fixed (uint* __dsl_pNumRows = pNumRows)
        fixed (D3D12_PLACED_SUBRESOURCE_FOOTPRINT* __dsl_pLayouts = pLayouts)
        {
            return (ulong)UpdateSubresources(
                pCmdList,
                pDestinationResource,
                pIntermediate,
                FirstSubresource,
                NumSubresources,
                RequiredSize,
                __dsl_pLayouts,
                __dsl_pNumRows,
                __dsl_pRowSizesInBytes,
                __dsl_pSrcData
            );
        }
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.UpdateSubresources"]/*'/>

    [return: NativeTypeName("UINT64")]
    public static ulong UpdateSubresources(
        ID3D12GraphicsCommandList pCmdList,
        ID3D12Resource pDestinationResource,
        ID3D12Resource pIntermediate,
        uint FirstSubresource,
        uint NumSubresources,
        [NativeTypeName("UINT64")] ulong RequiredSize,
        [NativeTypeName("const D3D12_PLACED_SUBRESOURCE_FOOTPRINT *")]
            D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts,
        [NativeTypeName("const UINT *")] uint* pNumRows,
        [NativeTypeName("const UINT64 *")] ulong* pRowSizesInBytes,
        [NativeTypeName("const void *")] void* pResourceData,
        [NativeTypeName("const D3D12_SUBRESOURCE_INFO *")] D3D12_SUBRESOURCE_INFO* pSrcData
    )
    {
        D3D12_RESOURCE_DESC IntermediateDesc = pIntermediate.GetDesc();
        D3D12_RESOURCE_DESC DestinationDesc = pDestinationResource.GetDesc();
        if (
            (IntermediateDesc.Dimension != D3D12_RESOURCE_DIMENSION_BUFFER)
            || (IntermediateDesc.Width < (RequiredSize + pLayouts[0].Offset))
            || (RequiredSize > nuint.MaxValue)
            || (
                (DestinationDesc.Dimension == D3D12_RESOURCE_DIMENSION_BUFFER)
                && ((FirstSubresource != 0) || (NumSubresources != 1))
            )
        )
        {
            return 0;
        }
        byte* pData;
        HRESULT hr = pIntermediate.Map(0, null, (void**)(&pData));
        if (FAILED(hr))
        {
            return 0;
        }
        for (uint i = 0; i < NumSubresources; ++i)
        {
            if (pRowSizesInBytes[i] > nuint.MaxValue)
            {
                return 0;
            }
            D3D12_MEMCPY_DEST DestData = new D3D12_MEMCPY_DEST
            {
                pData = pData + pLayouts[i].Offset,
                RowPitch = pLayouts[i].Footprint.RowPitch,
                SlicePitch = unchecked(
                    (nuint)(pLayouts[i].Footprint.RowPitch) * (nuint)(pNumRows[i])
                ),
            };
            MemcpySubresource(
                &DestData,
                pResourceData,
                &pSrcData[i],
                unchecked((nuint)(pRowSizesInBytes[i])),
                pNumRows[i],
                pLayouts[i].Footprint.Depth
            );
        }
        pIntermediate.Unmap(0, null);
        if (DestinationDesc.Dimension == D3D12_RESOURCE_DIMENSION_BUFFER)
        {
            pCmdList.CopyBufferRegion(
                pDestinationResource,
                0,
                pIntermediate,
                pLayouts[0].Offset,
                pLayouts[0].Footprint.Width
            );
        }
        else
        {
            for (uint i = 0; i < NumSubresources; ++i)
            {
                D3D12_TEXTURE_COPY_LOCATION Dst = new D3D12_TEXTURE_COPY_LOCATION(
                    pDestinationResource,
                    i + FirstSubresource
                );
                D3D12_TEXTURE_COPY_LOCATION Src = new D3D12_TEXTURE_COPY_LOCATION(
                    pIntermediate,
                    &pLayouts[i]
                );
                pCmdList.CopyTextureRegion(&Dst, 0, 0, 0, &Src, null);
            }
        }
        return RequiredSize;
    }

    [return: NativeTypeName("UINT64")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong UpdateSubresources(
        ID3D12GraphicsCommandList pCmdList,
        ID3D12Resource pDestinationResource,
        ID3D12Resource pIntermediate,
        uint FirstSubresource,
        uint NumSubresources,
        [NativeTypeName("UINT64")] ulong RequiredSize,
        [NativeTypeName("const D3D12_PLACED_SUBRESOURCE_FOOTPRINT *")]
            Ref<D3D12_PLACED_SUBRESOURCE_FOOTPRINT> pLayouts,
        [NativeTypeName("const UINT *")] Ref<uint> pNumRows,
        [NativeTypeName("const UINT64 *")] Ref<ulong> pRowSizesInBytes,
        [NativeTypeName("const void *")] Ref pResourceData,
        [NativeTypeName("const D3D12_SUBRESOURCE_INFO *")] Ref<D3D12_SUBRESOURCE_INFO> pSrcData
    )
    {
        fixed (D3D12_SUBRESOURCE_INFO* __dsl_pSrcData = pSrcData)
        fixed (void* __dsl_pResourceData = pResourceData)
        fixed (ulong* __dsl_pRowSizesInBytes = pRowSizesInBytes)
        fixed (uint* __dsl_pNumRows = pNumRows)
        fixed (D3D12_PLACED_SUBRESOURCE_FOOTPRINT* __dsl_pLayouts = pLayouts)
        {
            return (ulong)UpdateSubresources(
                pCmdList,
                pDestinationResource,
                pIntermediate,
                FirstSubresource,
                NumSubresources,
                RequiredSize,
                __dsl_pLayouts,
                __dsl_pNumRows,
                __dsl_pRowSizesInBytes,
                __dsl_pResourceData,
                __dsl_pSrcData
            );
        }
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.UpdateSubresources"]/*'/>

    [return: NativeTypeName("UINT64")]
    public static ulong UpdateSubresources(
        ID3D12GraphicsCommandList pCmdList,
        ID3D12Resource pDestinationResource,
        ID3D12Resource pIntermediate,
        [NativeTypeName("UINT64")] ulong IntermediateOffset,
        uint FirstSubresource,
        uint NumSubresources,
        [NativeTypeName("const D3D12_SUBRESOURCE_DATA *")] D3D12_SUBRESOURCE_DATA* pSrcData
    )
    {
        ulong RequiredSize = 0;
        ulong MemToAlloc = (ulong)(32 + 4 + 8) * NumSubresources;
        if (MemToAlloc > 0xffffffffffffffffUL)
        {
            return 0;
        }
        void* pMem = HeapAllocRaw(GetProcessHeap(), 0, (nuint)(MemToAlloc));
        if (pMem == null)
        {
            return 0;
        }
        D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts = (D3D12_PLACED_SUBRESOURCE_FOOTPRINT*)(pMem);
        ulong* pRowSizesInBytes = (ulong*)(pLayouts + NumSubresources);
        uint* pNumRows = (uint*)(pRowSizesInBytes + NumSubresources);
        D3D12_RESOURCE_DESC Desc = pDestinationResource.GetDesc();
        ID3D12Device pDevice = default;
        _ = pDestinationResource.GetDevice(__uuidof<ID3D12Device.Native>(), (void**)(&pDevice));
        pDevice.GetCopyableFootprints(
            &Desc,
            FirstSubresource,
            NumSubresources,
            IntermediateOffset,
            pLayouts,
            pNumRows,
            pRowSizesInBytes,
            &RequiredSize
        );
        _ = pDevice.Release();
        ulong Result = UpdateSubresources(
            pCmdList,
            pDestinationResource,
            pIntermediate,
            FirstSubresource,
            NumSubresources,
            RequiredSize,
            pLayouts,
            pNumRows,
            pRowSizesInBytes,
            pSrcData
        );
        _ = HeapFree(GetProcessHeap(), 0, pMem);
        return Result;
    }

    [return: NativeTypeName("UINT64")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong UpdateSubresources(
        ID3D12GraphicsCommandList pCmdList,
        ID3D12Resource pDestinationResource,
        ID3D12Resource pIntermediate,
        [NativeTypeName("UINT64")] ulong IntermediateOffset,
        uint FirstSubresource,
        uint NumSubresources,
        [NativeTypeName("const D3D12_SUBRESOURCE_DATA *")] Ref<D3D12_SUBRESOURCE_DATA> pSrcData
    )
    {
        fixed (D3D12_SUBRESOURCE_DATA* __dsl_pSrcData = pSrcData)
        {
            return (ulong)UpdateSubresources(
                pCmdList,
                pDestinationResource,
                pIntermediate,
                IntermediateOffset,
                FirstSubresource,
                NumSubresources,
                __dsl_pSrcData
            );
        }
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.UpdateSubresources"]/*'/>

    [return: NativeTypeName("UINT64")]
    public static ulong UpdateSubresources(
        ID3D12GraphicsCommandList pCmdList,
        ID3D12Resource pDestinationResource,
        ID3D12Resource pIntermediate,
        [NativeTypeName("UINT64")] ulong IntermediateOffset,
        uint FirstSubresource,
        uint NumSubresources,
        [NativeTypeName("const void *")] void* pResourceData,
        [NativeTypeName("const D3D12_SUBRESOURCE_INFO *")] D3D12_SUBRESOURCE_INFO* pSrcData
    )
    {
        ulong RequiredSize = 0;
        ulong MemToAlloc = (ulong)(32 + 4 + 8) * NumSubresources;
        if (MemToAlloc > 0xffffffffffffffffUL)
        {
            return 0;
        }
        void* pMem = HeapAllocRaw(GetProcessHeap(), 0, (nuint)(MemToAlloc));
        if (pMem == null)
        {
            return 0;
        }
        D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts = (D3D12_PLACED_SUBRESOURCE_FOOTPRINT*)(pMem);
        ulong* pRowSizesInBytes = (ulong*)(pLayouts + NumSubresources);
        uint* pNumRows = (uint*)(pRowSizesInBytes + NumSubresources);
        D3D12_RESOURCE_DESC Desc = pDestinationResource.GetDesc();
        ID3D12Device pDevice = default;
        _ = pDestinationResource.GetDevice(__uuidof<ID3D12Device.Native>(), (void**)(&pDevice));
        pDevice.GetCopyableFootprints(
            &Desc,
            FirstSubresource,
            NumSubresources,
            IntermediateOffset,
            pLayouts,
            pNumRows,
            pRowSizesInBytes,
            &RequiredSize
        );
        _ = pDevice.Release();
        ulong Result = UpdateSubresources(
            pCmdList,
            pDestinationResource,
            pIntermediate,
            FirstSubresource,
            NumSubresources,
            RequiredSize,
            pLayouts,
            pNumRows,
            pRowSizesInBytes,
            pResourceData,
            pSrcData
        );
        _ = HeapFree(GetProcessHeap(), 0, pMem);
        return Result;
    }

    [return: NativeTypeName("UINT64")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ulong UpdateSubresources(
        ID3D12GraphicsCommandList pCmdList,
        ID3D12Resource pDestinationResource,
        ID3D12Resource pIntermediate,
        [NativeTypeName("UINT64")] ulong IntermediateOffset,
        uint FirstSubresource,
        uint NumSubresources,
        [NativeTypeName("const void *")] Ref pResourceData,
        [NativeTypeName("const D3D12_SUBRESOURCE_INFO *")] Ref<D3D12_SUBRESOURCE_INFO> pSrcData
    )
    {
        fixed (D3D12_SUBRESOURCE_INFO* __dsl_pSrcData = pSrcData)
        fixed (void* __dsl_pResourceData = pResourceData)
        {
            return (ulong)UpdateSubresources(
                pCmdList,
                pDestinationResource,
                pIntermediate,
                IntermediateOffset,
                FirstSubresource,
                NumSubresources,
                __dsl_pResourceData,
                __dsl_pSrcData
            );
        }
    }
}
