// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("61F21C45-3C0E-4A74-9CEA-67100D9AD5E4")]
[NativeTypeName("struct ID3D11VideoContext : ID3D11DeviceChild")]
[NativeInheritance("ID3D11DeviceChild")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct ID3D11VideoContext : ID3D11VideoContext.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11VideoContext));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11VideoContext, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D11VideoContext, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11VideoContext, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetDevice(ID3D11Device* ppDevice)
    {
        ((delegate* unmanaged<ID3D11VideoContext, ID3D11Device*, void>)((*lpVtbl)[3]))(
            this,
            ppDevice
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint* pDataSize,
        void* pData
    )
    {
        return ((delegate* unmanaged<ID3D11VideoContext, Guid*, uint*, void*, int>)((*lpVtbl)[4]))(
            this,
            guid,
            pDataSize,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint DataSize,
        [NativeTypeName("const void *")] void* pData
    )
    {
        return ((delegate* unmanaged<ID3D11VideoContext, Guid*, uint, void*, int>)((*lpVtbl)[5]))(
            this,
            guid,
            DataSize,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetPrivateDataInterface(
        [NativeTypeName("const GUID &")] Guid* guid,
        [NativeTypeName("const IUnknown *")] IUnknown pData
    )
    {
        return ((delegate* unmanaged<ID3D11VideoContext, Guid*, IUnknown, int>)((*lpVtbl)[6]))(
            this,
            guid,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDecoderBuffer(
        ID3D11VideoDecoder pDecoder,
        D3D11_VIDEO_DECODER_BUFFER_TYPE Type,
        uint* pBufferSize,
        void** ppBuffer
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoDecoder,
                D3D11_VIDEO_DECODER_BUFFER_TYPE,
                uint*,
                void**,
                int>)((*lpVtbl)[7])
        )(this, pDecoder, Type, pBufferSize, ppBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ReleaseDecoderBuffer(
        ID3D11VideoDecoder pDecoder,
        D3D11_VIDEO_DECODER_BUFFER_TYPE Type
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoDecoder,
                D3D11_VIDEO_DECODER_BUFFER_TYPE,
                int>)((*lpVtbl)[8])
        )(this, pDecoder, Type);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT DecoderBeginFrame(
        ID3D11VideoDecoder pDecoder,
        ID3D11VideoDecoderOutputView pView,
        uint ContentKeySize,
        [NativeTypeName("const void *")] void* pContentKey
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoDecoder,
                ID3D11VideoDecoderOutputView,
                uint,
                void*,
                int>)((*lpVtbl)[9])
        )(this, pDecoder, pView, ContentKeySize, pContentKey);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT DecoderEndFrame(ID3D11VideoDecoder pDecoder)
    {
        return ((delegate* unmanaged<ID3D11VideoContext, ID3D11VideoDecoder, int>)((*lpVtbl)[10]))(
            this,
            pDecoder
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SubmitDecoderBuffers(
        ID3D11VideoDecoder pDecoder,
        uint NumBuffers,
        [NativeTypeName("const D3D11_VIDEO_DECODER_BUFFER_DESC *")]
            D3D11_VIDEO_DECODER_BUFFER_DESC* pBufferDesc
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoDecoder,
                uint,
                D3D11_VIDEO_DECODER_BUFFER_DESC*,
                int>)((*lpVtbl)[11])
        )(this, pDecoder, NumBuffers, pBufferDesc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
    public HRESULT DecoderExtension(
        ID3D11VideoDecoder pDecoder,
        [NativeTypeName("const D3D11_VIDEO_DECODER_EXTENSION *")]
            D3D11_VIDEO_DECODER_EXTENSION* pExtensionData
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoDecoder,
                D3D11_VIDEO_DECODER_EXTENSION*,
                int>)((*lpVtbl)[12])
        )(this, pDecoder, pExtensionData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void VideoProcessorSetOutputTargetRect(
        ID3D11VideoProcessor pVideoProcessor,
        BOOL Enable,
        [NativeTypeName("const RECT *")] RECT* pRect
    )
    {
        (
            (delegate* unmanaged<ID3D11VideoContext, ID3D11VideoProcessor, BOOL, RECT*, void>)(
                (*lpVtbl)[13]
            )
        )(this, pVideoProcessor, Enable, pRect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void VideoProcessorSetOutputBackgroundColor(
        ID3D11VideoProcessor pVideoProcessor,
        BOOL YCbCr,
        [NativeTypeName("const D3D11_VIDEO_COLOR *")] D3D11_VIDEO_COLOR* pColor
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                BOOL,
                D3D11_VIDEO_COLOR*,
                void>)((*lpVtbl)[14])
        )(this, pVideoProcessor, YCbCr, pColor);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public void VideoProcessorSetOutputColorSpace(
        ID3D11VideoProcessor pVideoProcessor,
        [NativeTypeName("const D3D11_VIDEO_PROCESSOR_COLOR_SPACE *")]
            D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                D3D11_VIDEO_PROCESSOR_COLOR_SPACE*,
                void>)((*lpVtbl)[15])
        )(this, pVideoProcessor, pColorSpace);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public void VideoProcessorSetOutputAlphaFillMode(
        ID3D11VideoProcessor pVideoProcessor,
        D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE AlphaFillMode,
        uint StreamIndex
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE,
                uint,
                void>)((*lpVtbl)[16])
        )(this, pVideoProcessor, AlphaFillMode, StreamIndex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public void VideoProcessorSetOutputConstriction(
        ID3D11VideoProcessor pVideoProcessor,
        BOOL Enable,
        SIZE Size
    )
    {
        (
            (delegate* unmanaged<ID3D11VideoContext, ID3D11VideoProcessor, BOOL, SIZE, void>)(
                (*lpVtbl)[17]
            )
        )(this, pVideoProcessor, Enable, Size);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void VideoProcessorSetOutputStereoMode(ID3D11VideoProcessor pVideoProcessor, BOOL Enable)
    {
        (
            (delegate* unmanaged<ID3D11VideoContext, ID3D11VideoProcessor, BOOL, void>)(
                (*lpVtbl)[18]
            )
        )(this, pVideoProcessor, Enable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
    public HRESULT VideoProcessorSetOutputExtension(
        ID3D11VideoProcessor pVideoProcessor,
        [NativeTypeName("const GUID *")] Guid* pExtensionGuid,
        uint DataSize,
        void* pData
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                Guid*,
                uint,
                void*,
                int>)((*lpVtbl)[19])
        )(this, pVideoProcessor, pExtensionGuid, DataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public void VideoProcessorGetOutputTargetRect(
        ID3D11VideoProcessor pVideoProcessor,
        BOOL* Enabled,
        RECT* pRect
    )
    {
        (
            (delegate* unmanaged<ID3D11VideoContext, ID3D11VideoProcessor, BOOL*, RECT*, void>)(
                (*lpVtbl)[20]
            )
        )(this, pVideoProcessor, Enabled, pRect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public void VideoProcessorGetOutputBackgroundColor(
        ID3D11VideoProcessor pVideoProcessor,
        BOOL* pYCbCr,
        D3D11_VIDEO_COLOR* pColor
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                BOOL*,
                D3D11_VIDEO_COLOR*,
                void>)((*lpVtbl)[21])
        )(this, pVideoProcessor, pYCbCr, pColor);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public void VideoProcessorGetOutputColorSpace(
        ID3D11VideoProcessor pVideoProcessor,
        D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                D3D11_VIDEO_PROCESSOR_COLOR_SPACE*,
                void>)((*lpVtbl)[22])
        )(this, pVideoProcessor, pColorSpace);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public void VideoProcessorGetOutputAlphaFillMode(
        ID3D11VideoProcessor pVideoProcessor,
        D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE* pAlphaFillMode,
        uint* pStreamIndex
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE*,
                uint*,
                void>)((*lpVtbl)[23])
        )(this, pVideoProcessor, pAlphaFillMode, pStreamIndex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public void VideoProcessorGetOutputConstriction(
        ID3D11VideoProcessor pVideoProcessor,
        BOOL* pEnabled,
        SIZE* pSize
    )
    {
        (
            (delegate* unmanaged<ID3D11VideoContext, ID3D11VideoProcessor, BOOL*, SIZE*, void>)(
                (*lpVtbl)[24]
            )
        )(this, pVideoProcessor, pEnabled, pSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public void VideoProcessorGetOutputStereoMode(
        ID3D11VideoProcessor pVideoProcessor,
        BOOL* pEnabled
    )
    {
        (
            (delegate* unmanaged<ID3D11VideoContext, ID3D11VideoProcessor, BOOL*, void>)(
                (*lpVtbl)[25]
            )
        )(this, pVideoProcessor, pEnabled);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
    public HRESULT VideoProcessorGetOutputExtension(
        ID3D11VideoProcessor pVideoProcessor,
        [NativeTypeName("const GUID *")] Guid* pExtensionGuid,
        uint DataSize,
        void* pData
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                Guid*,
                uint,
                void*,
                int>)((*lpVtbl)[26])
        )(this, pVideoProcessor, pExtensionGuid, DataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public void VideoProcessorSetStreamFrameFormat(
        ID3D11VideoProcessor pVideoProcessor,
        uint StreamIndex,
        D3D11_VIDEO_FRAME_FORMAT FrameFormat
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                uint,
                D3D11_VIDEO_FRAME_FORMAT,
                void>)((*lpVtbl)[27])
        )(this, pVideoProcessor, StreamIndex, FrameFormat);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public void VideoProcessorSetStreamColorSpace(
        ID3D11VideoProcessor pVideoProcessor,
        uint StreamIndex,
        [NativeTypeName("const D3D11_VIDEO_PROCESSOR_COLOR_SPACE *")]
            D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                uint,
                D3D11_VIDEO_PROCESSOR_COLOR_SPACE*,
                void>)((*lpVtbl)[28])
        )(this, pVideoProcessor, StreamIndex, pColorSpace);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public void VideoProcessorSetStreamOutputRate(
        ID3D11VideoProcessor pVideoProcessor,
        uint StreamIndex,
        D3D11_VIDEO_PROCESSOR_OUTPUT_RATE OutputRate,
        BOOL RepeatFrame,
        [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pCustomRate
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                uint,
                D3D11_VIDEO_PROCESSOR_OUTPUT_RATE,
                BOOL,
                DXGI_RATIONAL*,
                void>)((*lpVtbl)[29])
        )(this, pVideoProcessor, StreamIndex, OutputRate, RepeatFrame, pCustomRate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public void VideoProcessorSetStreamSourceRect(
        ID3D11VideoProcessor pVideoProcessor,
        uint StreamIndex,
        BOOL Enable,
        [NativeTypeName("const RECT *")] RECT* pRect
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                uint,
                BOOL,
                RECT*,
                void>)((*lpVtbl)[30])
        )(this, pVideoProcessor, StreamIndex, Enable, pRect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public void VideoProcessorSetStreamDestRect(
        ID3D11VideoProcessor pVideoProcessor,
        uint StreamIndex,
        BOOL Enable,
        [NativeTypeName("const RECT *")] RECT* pRect
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                uint,
                BOOL,
                RECT*,
                void>)((*lpVtbl)[31])
        )(this, pVideoProcessor, StreamIndex, Enable, pRect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public void VideoProcessorSetStreamAlpha(
        ID3D11VideoProcessor pVideoProcessor,
        uint StreamIndex,
        BOOL Enable,
        float Alpha
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                uint,
                BOOL,
                float,
                void>)((*lpVtbl)[32])
        )(this, pVideoProcessor, StreamIndex, Enable, Alpha);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public void VideoProcessorSetStreamPalette(
        ID3D11VideoProcessor pVideoProcessor,
        uint StreamIndex,
        uint Count,
        [NativeTypeName("const UINT *")] uint* pEntries
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                uint,
                uint,
                uint*,
                void>)((*lpVtbl)[33])
        )(this, pVideoProcessor, StreamIndex, Count, pEntries);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public void VideoProcessorSetStreamPixelAspectRatio(
        ID3D11VideoProcessor pVideoProcessor,
        uint StreamIndex,
        BOOL Enable,
        [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pSourceAspectRatio,
        [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pDestinationAspectRatio
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                uint,
                BOOL,
                DXGI_RATIONAL*,
                DXGI_RATIONAL*,
                void>)((*lpVtbl)[34])
        )(this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatio);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public void VideoProcessorSetStreamLumaKey(
        ID3D11VideoProcessor pVideoProcessor,
        uint StreamIndex,
        BOOL Enable,
        float Lower,
        float Upper
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                uint,
                BOOL,
                float,
                float,
                void>)((*lpVtbl)[35])
        )(this, pVideoProcessor, StreamIndex, Enable, Lower, Upper);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public void VideoProcessorSetStreamStereoFormat(
        ID3D11VideoProcessor pVideoProcessor,
        uint StreamIndex,
        BOOL Enable,
        D3D11_VIDEO_PROCESSOR_STEREO_FORMAT Format,
        BOOL LeftViewFrame0,
        BOOL BaseViewFrame0,
        D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE FlipMode,
        int MonoOffset
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                uint,
                BOOL,
                D3D11_VIDEO_PROCESSOR_STEREO_FORMAT,
                BOOL,
                BOOL,
                D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE,
                int,
                void>)((*lpVtbl)[36])
        )(
            this,
            pVideoProcessor,
            StreamIndex,
            Enable,
            Format,
            LeftViewFrame0,
            BaseViewFrame0,
            FlipMode,
            MonoOffset
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public void VideoProcessorSetStreamAutoProcessingMode(
        ID3D11VideoProcessor pVideoProcessor,
        uint StreamIndex,
        BOOL Enable
    )
    {
        (
            (delegate* unmanaged<ID3D11VideoContext, ID3D11VideoProcessor, uint, BOOL, void>)(
                (*lpVtbl)[37]
            )
        )(this, pVideoProcessor, StreamIndex, Enable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public void VideoProcessorSetStreamFilter(
        ID3D11VideoProcessor pVideoProcessor,
        uint StreamIndex,
        D3D11_VIDEO_PROCESSOR_FILTER Filter,
        BOOL Enable,
        int Level
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                uint,
                D3D11_VIDEO_PROCESSOR_FILTER,
                BOOL,
                int,
                void>)((*lpVtbl)[38])
        )(this, pVideoProcessor, StreamIndex, Filter, Enable, Level);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
    public HRESULT VideoProcessorSetStreamExtension(
        ID3D11VideoProcessor pVideoProcessor,
        uint StreamIndex,
        [NativeTypeName("const GUID *")] Guid* pExtensionGuid,
        uint DataSize,
        void* pData
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                uint,
                Guid*,
                uint,
                void*,
                int>)((*lpVtbl)[39])
        )(this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public void VideoProcessorGetStreamFrameFormat(
        ID3D11VideoProcessor pVideoProcessor,
        uint StreamIndex,
        D3D11_VIDEO_FRAME_FORMAT* pFrameFormat
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                uint,
                D3D11_VIDEO_FRAME_FORMAT*,
                void>)((*lpVtbl)[40])
        )(this, pVideoProcessor, StreamIndex, pFrameFormat);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public void VideoProcessorGetStreamColorSpace(
        ID3D11VideoProcessor pVideoProcessor,
        uint StreamIndex,
        D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                uint,
                D3D11_VIDEO_PROCESSOR_COLOR_SPACE*,
                void>)((*lpVtbl)[41])
        )(this, pVideoProcessor, StreamIndex, pColorSpace);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public void VideoProcessorGetStreamOutputRate(
        ID3D11VideoProcessor pVideoProcessor,
        uint StreamIndex,
        D3D11_VIDEO_PROCESSOR_OUTPUT_RATE* pOutputRate,
        BOOL* pRepeatFrame,
        DXGI_RATIONAL* pCustomRate
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                uint,
                D3D11_VIDEO_PROCESSOR_OUTPUT_RATE*,
                BOOL*,
                DXGI_RATIONAL*,
                void>)((*lpVtbl)[42])
        )(this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFrame, pCustomRate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public void VideoProcessorGetStreamSourceRect(
        ID3D11VideoProcessor pVideoProcessor,
        uint StreamIndex,
        BOOL* pEnabled,
        RECT* pRect
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                uint,
                BOOL*,
                RECT*,
                void>)((*lpVtbl)[43])
        )(this, pVideoProcessor, StreamIndex, pEnabled, pRect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public void VideoProcessorGetStreamDestRect(
        ID3D11VideoProcessor pVideoProcessor,
        uint StreamIndex,
        BOOL* pEnabled,
        RECT* pRect
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                uint,
                BOOL*,
                RECT*,
                void>)((*lpVtbl)[44])
        )(this, pVideoProcessor, StreamIndex, pEnabled, pRect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public void VideoProcessorGetStreamAlpha(
        ID3D11VideoProcessor pVideoProcessor,
        uint StreamIndex,
        BOOL* pEnabled,
        float* pAlpha
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                uint,
                BOOL*,
                float*,
                void>)((*lpVtbl)[45])
        )(this, pVideoProcessor, StreamIndex, pEnabled, pAlpha);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public void VideoProcessorGetStreamPalette(
        ID3D11VideoProcessor pVideoProcessor,
        uint StreamIndex,
        uint Count,
        uint* pEntries
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                uint,
                uint,
                uint*,
                void>)((*lpVtbl)[46])
        )(this, pVideoProcessor, StreamIndex, Count, pEntries);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public void VideoProcessorGetStreamPixelAspectRatio(
        ID3D11VideoProcessor pVideoProcessor,
        uint StreamIndex,
        BOOL* pEnabled,
        DXGI_RATIONAL* pSourceAspectRatio,
        DXGI_RATIONAL* pDestinationAspectRatio
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                uint,
                BOOL*,
                DXGI_RATIONAL*,
                DXGI_RATIONAL*,
                void>)((*lpVtbl)[47])
        )(
            this,
            pVideoProcessor,
            StreamIndex,
            pEnabled,
            pSourceAspectRatio,
            pDestinationAspectRatio
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public void VideoProcessorGetStreamLumaKey(
        ID3D11VideoProcessor pVideoProcessor,
        uint StreamIndex,
        BOOL* pEnabled,
        float* pLower,
        float* pUpper
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                uint,
                BOOL*,
                float*,
                float*,
                void>)((*lpVtbl)[48])
        )(this, pVideoProcessor, StreamIndex, pEnabled, pLower, pUpper);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public void VideoProcessorGetStreamStereoFormat(
        ID3D11VideoProcessor pVideoProcessor,
        uint StreamIndex,
        BOOL* pEnable,
        D3D11_VIDEO_PROCESSOR_STEREO_FORMAT* pFormat,
        BOOL* pLeftViewFrame0,
        BOOL* pBaseViewFrame0,
        D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE* pFlipMode,
        int* MonoOffset
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                uint,
                BOOL*,
                D3D11_VIDEO_PROCESSOR_STEREO_FORMAT*,
                BOOL*,
                BOOL*,
                D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE*,
                int*,
                void>)((*lpVtbl)[49])
        )(
            this,
            pVideoProcessor,
            StreamIndex,
            pEnable,
            pFormat,
            pLeftViewFrame0,
            pBaseViewFrame0,
            pFlipMode,
            MonoOffset
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public void VideoProcessorGetStreamAutoProcessingMode(
        ID3D11VideoProcessor pVideoProcessor,
        uint StreamIndex,
        BOOL* pEnabled
    )
    {
        (
            (delegate* unmanaged<ID3D11VideoContext, ID3D11VideoProcessor, uint, BOOL*, void>)(
                (*lpVtbl)[50]
            )
        )(this, pVideoProcessor, StreamIndex, pEnabled);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public void VideoProcessorGetStreamFilter(
        ID3D11VideoProcessor pVideoProcessor,
        uint StreamIndex,
        D3D11_VIDEO_PROCESSOR_FILTER Filter,
        BOOL* pEnabled,
        int* pLevel
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                uint,
                D3D11_VIDEO_PROCESSOR_FILTER,
                BOOL*,
                int*,
                void>)((*lpVtbl)[51])
        )(this, pVideoProcessor, StreamIndex, Filter, pEnabled, pLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
    public HRESULT VideoProcessorGetStreamExtension(
        ID3D11VideoProcessor pVideoProcessor,
        uint StreamIndex,
        [NativeTypeName("const GUID *")] Guid* pExtensionGuid,
        uint DataSize,
        void* pData
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                uint,
                Guid*,
                uint,
                void*,
                int>)((*lpVtbl)[52])
        )(this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT VideoProcessorBlt(
        ID3D11VideoProcessor pVideoProcessor,
        ID3D11VideoProcessorOutputView pView,
        uint OutputFrame,
        uint StreamCount,
        [NativeTypeName("const D3D11_VIDEO_PROCESSOR_STREAM *")]
            D3D11_VIDEO_PROCESSOR_STREAM* pStreams
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                ID3D11VideoProcessorOutputView,
                uint,
                uint,
                D3D11_VIDEO_PROCESSOR_STREAM*,
                int>)((*lpVtbl)[53])
        )(this, pVideoProcessor, pView, OutputFrame, StreamCount, pStreams);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT NegotiateCryptoSessionKeyExchange(
        ID3D11CryptoSession pCryptoSession,
        uint DataSize,
        void* pData
    )
    {
        return (
            (delegate* unmanaged<ID3D11VideoContext, ID3D11CryptoSession, uint, void*, int>)(
                (*lpVtbl)[54]
            )
        )(this, pCryptoSession, DataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public void EncryptionBlt(
        ID3D11CryptoSession pCryptoSession,
        ID3D11Texture2D pSrcSurface,
        ID3D11Texture2D pDstSurface,
        uint IVSize,
        void* pIV
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11CryptoSession,
                ID3D11Texture2D,
                ID3D11Texture2D,
                uint,
                void*,
                void>)((*lpVtbl)[55])
        )(this, pCryptoSession, pSrcSurface, pDstSurface, IVSize, pIV);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public void DecryptionBlt(
        ID3D11CryptoSession pCryptoSession,
        ID3D11Texture2D pSrcSurface,
        ID3D11Texture2D pDstSurface,
        D3D11_ENCRYPTED_BLOCK_INFO* pEncryptedBlockInfo,
        uint ContentKeySize,
        [NativeTypeName("const void *")] void* pContentKey,
        uint IVSize,
        void* pIV
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11CryptoSession,
                ID3D11Texture2D,
                ID3D11Texture2D,
                D3D11_ENCRYPTED_BLOCK_INFO*,
                uint,
                void*,
                uint,
                void*,
                void>)((*lpVtbl)[56])
        )(
            this,
            pCryptoSession,
            pSrcSurface,
            pDstSurface,
            pEncryptedBlockInfo,
            ContentKeySize,
            pContentKey,
            IVSize,
            pIV
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public void StartSessionKeyRefresh(
        ID3D11CryptoSession pCryptoSession,
        uint RandomNumberSize,
        void* pRandomNumber
    )
    {
        (
            (delegate* unmanaged<ID3D11VideoContext, ID3D11CryptoSession, uint, void*, void>)(
                (*lpVtbl)[57]
            )
        )(this, pCryptoSession, RandomNumberSize, pRandomNumber);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public void FinishSessionKeyRefresh(ID3D11CryptoSession pCryptoSession)
    {
        ((delegate* unmanaged<ID3D11VideoContext, ID3D11CryptoSession, void>)((*lpVtbl)[58]))(
            this,
            pCryptoSession
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT GetEncryptionBltKey(
        ID3D11CryptoSession pCryptoSession,
        uint KeySize,
        void* pReadbackKey
    )
    {
        return (
            (delegate* unmanaged<ID3D11VideoContext, ID3D11CryptoSession, uint, void*, int>)(
                (*lpVtbl)[59]
            )
        )(this, pCryptoSession, KeySize, pReadbackKey);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT NegotiateAuthenticatedChannelKeyExchange(
        ID3D11AuthenticatedChannel pChannel,
        uint DataSize,
        void* pData
    )
    {
        return (
            (delegate* unmanaged<ID3D11VideoContext, ID3D11AuthenticatedChannel, uint, void*, int>)(
                (*lpVtbl)[60]
            )
        )(this, pChannel, DataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT QueryAuthenticatedChannel(
        ID3D11AuthenticatedChannel pChannel,
        uint InputSize,
        [NativeTypeName("const void *")] void* pInput,
        uint OutputSize,
        void* pOutput
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11AuthenticatedChannel,
                uint,
                void*,
                uint,
                void*,
                int>)((*lpVtbl)[61])
        )(this, pChannel, InputSize, pInput, OutputSize, pOutput);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT ConfigureAuthenticatedChannel(
        ID3D11AuthenticatedChannel pChannel,
        uint InputSize,
        [NativeTypeName("const void *")] void* pInput,
        D3D11_AUTHENTICATED_CONFIGURE_OUTPUT* pOutput
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11AuthenticatedChannel,
                uint,
                void*,
                D3D11_AUTHENTICATED_CONFIGURE_OUTPUT*,
                int>)((*lpVtbl)[62])
        )(this, pChannel, InputSize, pInput, pOutput);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public void VideoProcessorSetStreamRotation(
        ID3D11VideoProcessor pVideoProcessor,
        uint StreamIndex,
        BOOL Enable,
        D3D11_VIDEO_PROCESSOR_ROTATION Rotation
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                uint,
                BOOL,
                D3D11_VIDEO_PROCESSOR_ROTATION,
                void>)((*lpVtbl)[63])
        )(this, pVideoProcessor, StreamIndex, Enable, Rotation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public void VideoProcessorGetStreamRotation(
        ID3D11VideoProcessor pVideoProcessor,
        uint StreamIndex,
        BOOL* pEnable,
        D3D11_VIDEO_PROCESSOR_ROTATION* pRotation
    )
    {
        (
            (delegate* unmanaged<
                ID3D11VideoContext,
                ID3D11VideoProcessor,
                uint,
                BOOL*,
                D3D11_VIDEO_PROCESSOR_ROTATION*,
                void>)((*lpVtbl)[64])
        )(this, pVideoProcessor, StreamIndex, pEnable, pRotation);
    }

    public interface Interface : ID3D11DeviceChild.Interface
    {
        [VtblIndex(7)]
        HRESULT GetDecoderBuffer(
            ID3D11VideoDecoder pDecoder,
            D3D11_VIDEO_DECODER_BUFFER_TYPE Type,
            uint* pBufferSize,
            void** ppBuffer
        );

        [VtblIndex(8)]
        HRESULT ReleaseDecoderBuffer(
            ID3D11VideoDecoder pDecoder,
            D3D11_VIDEO_DECODER_BUFFER_TYPE Type
        );

        [VtblIndex(9)]
        HRESULT DecoderBeginFrame(
            ID3D11VideoDecoder pDecoder,
            ID3D11VideoDecoderOutputView pView,
            uint ContentKeySize,
            [NativeTypeName("const void *")] void* pContentKey
        );

        [VtblIndex(10)]
        HRESULT DecoderEndFrame(ID3D11VideoDecoder pDecoder);

        [VtblIndex(11)]
        HRESULT SubmitDecoderBuffers(
            ID3D11VideoDecoder pDecoder,
            uint NumBuffers,
            [NativeTypeName("const D3D11_VIDEO_DECODER_BUFFER_DESC *")]
                D3D11_VIDEO_DECODER_BUFFER_DESC* pBufferDesc
        );

        [VtblIndex(12)]
        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        HRESULT DecoderExtension(
            ID3D11VideoDecoder pDecoder,
            [NativeTypeName("const D3D11_VIDEO_DECODER_EXTENSION *")]
                D3D11_VIDEO_DECODER_EXTENSION* pExtensionData
        );

        [VtblIndex(13)]
        void VideoProcessorSetOutputTargetRect(
            ID3D11VideoProcessor pVideoProcessor,
            BOOL Enable,
            [NativeTypeName("const RECT *")] RECT* pRect
        );

        [VtblIndex(14)]
        void VideoProcessorSetOutputBackgroundColor(
            ID3D11VideoProcessor pVideoProcessor,
            BOOL YCbCr,
            [NativeTypeName("const D3D11_VIDEO_COLOR *")] D3D11_VIDEO_COLOR* pColor
        );

        [VtblIndex(15)]
        void VideoProcessorSetOutputColorSpace(
            ID3D11VideoProcessor pVideoProcessor,
            [NativeTypeName("const D3D11_VIDEO_PROCESSOR_COLOR_SPACE *")]
                D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace
        );

        [VtblIndex(16)]
        void VideoProcessorSetOutputAlphaFillMode(
            ID3D11VideoProcessor pVideoProcessor,
            D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE AlphaFillMode,
            uint StreamIndex
        );

        [VtblIndex(17)]
        void VideoProcessorSetOutputConstriction(
            ID3D11VideoProcessor pVideoProcessor,
            BOOL Enable,
            SIZE Size
        );

        [VtblIndex(18)]
        void VideoProcessorSetOutputStereoMode(ID3D11VideoProcessor pVideoProcessor, BOOL Enable);

        [VtblIndex(19)]
        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        HRESULT VideoProcessorSetOutputExtension(
            ID3D11VideoProcessor pVideoProcessor,
            [NativeTypeName("const GUID *")] Guid* pExtensionGuid,
            uint DataSize,
            void* pData
        );

        [VtblIndex(20)]
        void VideoProcessorGetOutputTargetRect(
            ID3D11VideoProcessor pVideoProcessor,
            BOOL* Enabled,
            RECT* pRect
        );

        [VtblIndex(21)]
        void VideoProcessorGetOutputBackgroundColor(
            ID3D11VideoProcessor pVideoProcessor,
            BOOL* pYCbCr,
            D3D11_VIDEO_COLOR* pColor
        );

        [VtblIndex(22)]
        void VideoProcessorGetOutputColorSpace(
            ID3D11VideoProcessor pVideoProcessor,
            D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace
        );

        [VtblIndex(23)]
        void VideoProcessorGetOutputAlphaFillMode(
            ID3D11VideoProcessor pVideoProcessor,
            D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE* pAlphaFillMode,
            uint* pStreamIndex
        );

        [VtblIndex(24)]
        void VideoProcessorGetOutputConstriction(
            ID3D11VideoProcessor pVideoProcessor,
            BOOL* pEnabled,
            SIZE* pSize
        );

        [VtblIndex(25)]
        void VideoProcessorGetOutputStereoMode(
            ID3D11VideoProcessor pVideoProcessor,
            BOOL* pEnabled
        );

        [VtblIndex(26)]
        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        HRESULT VideoProcessorGetOutputExtension(
            ID3D11VideoProcessor pVideoProcessor,
            [NativeTypeName("const GUID *")] Guid* pExtensionGuid,
            uint DataSize,
            void* pData
        );

        [VtblIndex(27)]
        void VideoProcessorSetStreamFrameFormat(
            ID3D11VideoProcessor pVideoProcessor,
            uint StreamIndex,
            D3D11_VIDEO_FRAME_FORMAT FrameFormat
        );

        [VtblIndex(28)]
        void VideoProcessorSetStreamColorSpace(
            ID3D11VideoProcessor pVideoProcessor,
            uint StreamIndex,
            [NativeTypeName("const D3D11_VIDEO_PROCESSOR_COLOR_SPACE *")]
                D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace
        );

        [VtblIndex(29)]
        void VideoProcessorSetStreamOutputRate(
            ID3D11VideoProcessor pVideoProcessor,
            uint StreamIndex,
            D3D11_VIDEO_PROCESSOR_OUTPUT_RATE OutputRate,
            BOOL RepeatFrame,
            [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pCustomRate
        );

        [VtblIndex(30)]
        void VideoProcessorSetStreamSourceRect(
            ID3D11VideoProcessor pVideoProcessor,
            uint StreamIndex,
            BOOL Enable,
            [NativeTypeName("const RECT *")] RECT* pRect
        );

        [VtblIndex(31)]
        void VideoProcessorSetStreamDestRect(
            ID3D11VideoProcessor pVideoProcessor,
            uint StreamIndex,
            BOOL Enable,
            [NativeTypeName("const RECT *")] RECT* pRect
        );

        [VtblIndex(32)]
        void VideoProcessorSetStreamAlpha(
            ID3D11VideoProcessor pVideoProcessor,
            uint StreamIndex,
            BOOL Enable,
            float Alpha
        );

        [VtblIndex(33)]
        void VideoProcessorSetStreamPalette(
            ID3D11VideoProcessor pVideoProcessor,
            uint StreamIndex,
            uint Count,
            [NativeTypeName("const UINT *")] uint* pEntries
        );

        [VtblIndex(34)]
        void VideoProcessorSetStreamPixelAspectRatio(
            ID3D11VideoProcessor pVideoProcessor,
            uint StreamIndex,
            BOOL Enable,
            [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pSourceAspectRatio,
            [NativeTypeName("const DXGI_RATIONAL *")] DXGI_RATIONAL* pDestinationAspectRatio
        );

        [VtblIndex(35)]
        void VideoProcessorSetStreamLumaKey(
            ID3D11VideoProcessor pVideoProcessor,
            uint StreamIndex,
            BOOL Enable,
            float Lower,
            float Upper
        );

        [VtblIndex(36)]
        void VideoProcessorSetStreamStereoFormat(
            ID3D11VideoProcessor pVideoProcessor,
            uint StreamIndex,
            BOOL Enable,
            D3D11_VIDEO_PROCESSOR_STEREO_FORMAT Format,
            BOOL LeftViewFrame0,
            BOOL BaseViewFrame0,
            D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE FlipMode,
            int MonoOffset
        );

        [VtblIndex(37)]
        void VideoProcessorSetStreamAutoProcessingMode(
            ID3D11VideoProcessor pVideoProcessor,
            uint StreamIndex,
            BOOL Enable
        );

        [VtblIndex(38)]
        void VideoProcessorSetStreamFilter(
            ID3D11VideoProcessor pVideoProcessor,
            uint StreamIndex,
            D3D11_VIDEO_PROCESSOR_FILTER Filter,
            BOOL Enable,
            int Level
        );

        [VtblIndex(39)]
        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        HRESULT VideoProcessorSetStreamExtension(
            ID3D11VideoProcessor pVideoProcessor,
            uint StreamIndex,
            [NativeTypeName("const GUID *")] Guid* pExtensionGuid,
            uint DataSize,
            void* pData
        );

        [VtblIndex(40)]
        void VideoProcessorGetStreamFrameFormat(
            ID3D11VideoProcessor pVideoProcessor,
            uint StreamIndex,
            D3D11_VIDEO_FRAME_FORMAT* pFrameFormat
        );

        [VtblIndex(41)]
        void VideoProcessorGetStreamColorSpace(
            ID3D11VideoProcessor pVideoProcessor,
            uint StreamIndex,
            D3D11_VIDEO_PROCESSOR_COLOR_SPACE* pColorSpace
        );

        [VtblIndex(42)]
        void VideoProcessorGetStreamOutputRate(
            ID3D11VideoProcessor pVideoProcessor,
            uint StreamIndex,
            D3D11_VIDEO_PROCESSOR_OUTPUT_RATE* pOutputRate,
            BOOL* pRepeatFrame,
            DXGI_RATIONAL* pCustomRate
        );

        [VtblIndex(43)]
        void VideoProcessorGetStreamSourceRect(
            ID3D11VideoProcessor pVideoProcessor,
            uint StreamIndex,
            BOOL* pEnabled,
            RECT* pRect
        );

        [VtblIndex(44)]
        void VideoProcessorGetStreamDestRect(
            ID3D11VideoProcessor pVideoProcessor,
            uint StreamIndex,
            BOOL* pEnabled,
            RECT* pRect
        );

        [VtblIndex(45)]
        void VideoProcessorGetStreamAlpha(
            ID3D11VideoProcessor pVideoProcessor,
            uint StreamIndex,
            BOOL* pEnabled,
            float* pAlpha
        );

        [VtblIndex(46)]
        void VideoProcessorGetStreamPalette(
            ID3D11VideoProcessor pVideoProcessor,
            uint StreamIndex,
            uint Count,
            uint* pEntries
        );

        [VtblIndex(47)]
        void VideoProcessorGetStreamPixelAspectRatio(
            ID3D11VideoProcessor pVideoProcessor,
            uint StreamIndex,
            BOOL* pEnabled,
            DXGI_RATIONAL* pSourceAspectRatio,
            DXGI_RATIONAL* pDestinationAspectRatio
        );

        [VtblIndex(48)]
        void VideoProcessorGetStreamLumaKey(
            ID3D11VideoProcessor pVideoProcessor,
            uint StreamIndex,
            BOOL* pEnabled,
            float* pLower,
            float* pUpper
        );

        [VtblIndex(49)]
        void VideoProcessorGetStreamStereoFormat(
            ID3D11VideoProcessor pVideoProcessor,
            uint StreamIndex,
            BOOL* pEnable,
            D3D11_VIDEO_PROCESSOR_STEREO_FORMAT* pFormat,
            BOOL* pLeftViewFrame0,
            BOOL* pBaseViewFrame0,
            D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE* pFlipMode,
            int* MonoOffset
        );

        [VtblIndex(50)]
        void VideoProcessorGetStreamAutoProcessingMode(
            ID3D11VideoProcessor pVideoProcessor,
            uint StreamIndex,
            BOOL* pEnabled
        );

        [VtblIndex(51)]
        void VideoProcessorGetStreamFilter(
            ID3D11VideoProcessor pVideoProcessor,
            uint StreamIndex,
            D3D11_VIDEO_PROCESSOR_FILTER Filter,
            BOOL* pEnabled,
            int* pLevel
        );

        [VtblIndex(52)]
        [return: NativeTypeName("APP_DEPRECATED_HRESULT")]
        HRESULT VideoProcessorGetStreamExtension(
            ID3D11VideoProcessor pVideoProcessor,
            uint StreamIndex,
            [NativeTypeName("const GUID *")] Guid* pExtensionGuid,
            uint DataSize,
            void* pData
        );

        [VtblIndex(53)]
        HRESULT VideoProcessorBlt(
            ID3D11VideoProcessor pVideoProcessor,
            ID3D11VideoProcessorOutputView pView,
            uint OutputFrame,
            uint StreamCount,
            [NativeTypeName("const D3D11_VIDEO_PROCESSOR_STREAM *")]
                D3D11_VIDEO_PROCESSOR_STREAM* pStreams
        );

        [VtblIndex(54)]
        HRESULT NegotiateCryptoSessionKeyExchange(
            ID3D11CryptoSession pCryptoSession,
            uint DataSize,
            void* pData
        );

        [VtblIndex(55)]
        void EncryptionBlt(
            ID3D11CryptoSession pCryptoSession,
            ID3D11Texture2D pSrcSurface,
            ID3D11Texture2D pDstSurface,
            uint IVSize,
            void* pIV
        );

        [VtblIndex(56)]
        void DecryptionBlt(
            ID3D11CryptoSession pCryptoSession,
            ID3D11Texture2D pSrcSurface,
            ID3D11Texture2D pDstSurface,
            D3D11_ENCRYPTED_BLOCK_INFO* pEncryptedBlockInfo,
            uint ContentKeySize,
            [NativeTypeName("const void *")] void* pContentKey,
            uint IVSize,
            void* pIV
        );

        [VtblIndex(57)]
        void StartSessionKeyRefresh(
            ID3D11CryptoSession pCryptoSession,
            uint RandomNumberSize,
            void* pRandomNumber
        );

        [VtblIndex(58)]
        void FinishSessionKeyRefresh(ID3D11CryptoSession pCryptoSession);

        [VtblIndex(59)]
        HRESULT GetEncryptionBltKey(
            ID3D11CryptoSession pCryptoSession,
            uint KeySize,
            void* pReadbackKey
        );

        [VtblIndex(60)]
        HRESULT NegotiateAuthenticatedChannelKeyExchange(
            ID3D11AuthenticatedChannel pChannel,
            uint DataSize,
            void* pData
        );

        [VtblIndex(61)]
        HRESULT QueryAuthenticatedChannel(
            ID3D11AuthenticatedChannel pChannel,
            uint InputSize,
            [NativeTypeName("const void *")] void* pInput,
            uint OutputSize,
            void* pOutput
        );

        [VtblIndex(62)]
        HRESULT ConfigureAuthenticatedChannel(
            ID3D11AuthenticatedChannel pChannel,
            uint InputSize,
            [NativeTypeName("const void *")] void* pInput,
            D3D11_AUTHENTICATED_CONFIGURE_OUTPUT* pOutput
        );

        [VtblIndex(63)]
        void VideoProcessorSetStreamRotation(
            ID3D11VideoProcessor pVideoProcessor,
            uint StreamIndex,
            BOOL Enable,
            D3D11_VIDEO_PROCESSOR_ROTATION Rotation
        );

        [VtblIndex(64)]
        void VideoProcessorGetStreamRotation(
            ID3D11VideoProcessor pVideoProcessor,
            uint StreamIndex,
            BOOL* pEnable,
            D3D11_VIDEO_PROCESSOR_ROTATION* pRotation
        );
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("void (ID3D11Device **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Device*, void> GetDevice;

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown, int> SetPrivateDataInterface;

        [NativeTypeName(
            "HRESULT (ID3D11VideoDecoder *, D3D11_VIDEO_DECODER_BUFFER_TYPE, UINT *, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoDecoder,
            D3D11_VIDEO_DECODER_BUFFER_TYPE,
            uint*,
            void**,
            int> GetDecoderBuffer;

        [NativeTypeName(
            "HRESULT (ID3D11VideoDecoder *, D3D11_VIDEO_DECODER_BUFFER_TYPE) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoDecoder,
            D3D11_VIDEO_DECODER_BUFFER_TYPE,
            int> ReleaseDecoderBuffer;

        [NativeTypeName(
            "HRESULT (ID3D11VideoDecoder *, ID3D11VideoDecoderOutputView *, UINT, const void *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoDecoder,
            ID3D11VideoDecoderOutputView,
            uint,
            void*,
            int> DecoderBeginFrame;

        [NativeTypeName("HRESULT (ID3D11VideoDecoder *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11VideoDecoder, int> DecoderEndFrame;

        [NativeTypeName(
            "HRESULT (ID3D11VideoDecoder *, UINT, const D3D11_VIDEO_DECODER_BUFFER_DESC *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoDecoder,
            uint,
            D3D11_VIDEO_DECODER_BUFFER_DESC*,
            int> SubmitDecoderBuffers;

        [NativeTypeName(
            "APP_DEPRECATED_HRESULT (ID3D11VideoDecoder *, const D3D11_VIDEO_DECODER_EXTENSION *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoDecoder,
            D3D11_VIDEO_DECODER_EXTENSION*,
            int> DecoderExtension;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, BOOL, const RECT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            BOOL,
            RECT*,
            void> VideoProcessorSetOutputTargetRect;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, BOOL, const D3D11_VIDEO_COLOR *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            BOOL,
            D3D11_VIDEO_COLOR*,
            void> VideoProcessorSetOutputBackgroundColor;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, const D3D11_VIDEO_PROCESSOR_COLOR_SPACE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            D3D11_VIDEO_PROCESSOR_COLOR_SPACE*,
            void> VideoProcessorSetOutputColorSpace;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE, UINT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE,
            uint,
            void> VideoProcessorSetOutputAlphaFillMode;

        [NativeTypeName("void (ID3D11VideoProcessor *, BOOL, SIZE) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            BOOL,
            SIZE,
            void> VideoProcessorSetOutputConstriction;

        [NativeTypeName("void (ID3D11VideoProcessor *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            BOOL,
            void> VideoProcessorSetOutputStereoMode;

        [NativeTypeName(
            "APP_DEPRECATED_HRESULT (ID3D11VideoProcessor *, const GUID *, UINT, void *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            Guid*,
            uint,
            void*,
            int> VideoProcessorSetOutputExtension;

        [NativeTypeName("void (ID3D11VideoProcessor *, BOOL *, RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            BOOL*,
            RECT*,
            void> VideoProcessorGetOutputTargetRect;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, BOOL *, D3D11_VIDEO_COLOR *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            BOOL*,
            D3D11_VIDEO_COLOR*,
            void> VideoProcessorGetOutputBackgroundColor;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, D3D11_VIDEO_PROCESSOR_COLOR_SPACE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            D3D11_VIDEO_PROCESSOR_COLOR_SPACE*,
            void> VideoProcessorGetOutputColorSpace;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE*,
            uint*,
            void> VideoProcessorGetOutputAlphaFillMode;

        [NativeTypeName("void (ID3D11VideoProcessor *, BOOL *, SIZE *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            BOOL*,
            SIZE*,
            void> VideoProcessorGetOutputConstriction;

        [NativeTypeName("void (ID3D11VideoProcessor *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            BOOL*,
            void> VideoProcessorGetOutputStereoMode;

        [NativeTypeName(
            "APP_DEPRECATED_HRESULT (ID3D11VideoProcessor *, const GUID *, UINT, void *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            Guid*,
            uint,
            void*,
            int> VideoProcessorGetOutputExtension;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, UINT, D3D11_VIDEO_FRAME_FORMAT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            uint,
            D3D11_VIDEO_FRAME_FORMAT,
            void> VideoProcessorSetStreamFrameFormat;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, UINT, const D3D11_VIDEO_PROCESSOR_COLOR_SPACE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            uint,
            D3D11_VIDEO_PROCESSOR_COLOR_SPACE*,
            void> VideoProcessorSetStreamColorSpace;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, UINT, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE, BOOL, const DXGI_RATIONAL *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            uint,
            D3D11_VIDEO_PROCESSOR_OUTPUT_RATE,
            BOOL,
            DXGI_RATIONAL*,
            void> VideoProcessorSetStreamOutputRate;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, UINT, BOOL, const RECT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            uint,
            BOOL,
            RECT*,
            void> VideoProcessorSetStreamSourceRect;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, UINT, BOOL, const RECT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            uint,
            BOOL,
            RECT*,
            void> VideoProcessorSetStreamDestRect;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, UINT, BOOL, FLOAT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            uint,
            BOOL,
            float,
            void> VideoProcessorSetStreamAlpha;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, UINT, UINT, const UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            uint,
            uint,
            uint*,
            void> VideoProcessorSetStreamPalette;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, UINT, BOOL, const DXGI_RATIONAL *, const DXGI_RATIONAL *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            uint,
            BOOL,
            DXGI_RATIONAL*,
            DXGI_RATIONAL*,
            void> VideoProcessorSetStreamPixelAspectRatio;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, UINT, BOOL, FLOAT, FLOAT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            uint,
            BOOL,
            float,
            float,
            void> VideoProcessorSetStreamLumaKey;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, UINT, BOOL, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT, BOOL, BOOL, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE, int) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            uint,
            BOOL,
            D3D11_VIDEO_PROCESSOR_STEREO_FORMAT,
            BOOL,
            BOOL,
            D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE,
            int,
            void> VideoProcessorSetStreamStereoFormat;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            uint,
            BOOL,
            void> VideoProcessorSetStreamAutoProcessingMode;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, UINT, D3D11_VIDEO_PROCESSOR_FILTER, BOOL, int) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            uint,
            D3D11_VIDEO_PROCESSOR_FILTER,
            BOOL,
            int,
            void> VideoProcessorSetStreamFilter;

        [NativeTypeName(
            "APP_DEPRECATED_HRESULT (ID3D11VideoProcessor *, UINT, const GUID *, UINT, void *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            uint,
            Guid*,
            uint,
            void*,
            int> VideoProcessorSetStreamExtension;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, UINT, D3D11_VIDEO_FRAME_FORMAT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            uint,
            D3D11_VIDEO_FRAME_FORMAT*,
            void> VideoProcessorGetStreamFrameFormat;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, UINT, D3D11_VIDEO_PROCESSOR_COLOR_SPACE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            uint,
            D3D11_VIDEO_PROCESSOR_COLOR_SPACE*,
            void> VideoProcessorGetStreamColorSpace;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, UINT, D3D11_VIDEO_PROCESSOR_OUTPUT_RATE *, BOOL *, DXGI_RATIONAL *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            uint,
            D3D11_VIDEO_PROCESSOR_OUTPUT_RATE*,
            BOOL*,
            DXGI_RATIONAL*,
            void> VideoProcessorGetStreamOutputRate;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, UINT, BOOL *, RECT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            uint,
            BOOL*,
            RECT*,
            void> VideoProcessorGetStreamSourceRect;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, UINT, BOOL *, RECT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            uint,
            BOOL*,
            RECT*,
            void> VideoProcessorGetStreamDestRect;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, UINT, BOOL *, FLOAT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            uint,
            BOOL*,
            float*,
            void> VideoProcessorGetStreamAlpha;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, UINT, UINT, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            uint,
            uint,
            uint*,
            void> VideoProcessorGetStreamPalette;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, UINT, BOOL *, DXGI_RATIONAL *, DXGI_RATIONAL *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            uint,
            BOOL*,
            DXGI_RATIONAL*,
            DXGI_RATIONAL*,
            void> VideoProcessorGetStreamPixelAspectRatio;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, UINT, BOOL *, FLOAT *, FLOAT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            uint,
            BOOL*,
            float*,
            float*,
            void> VideoProcessorGetStreamLumaKey;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, UINT, BOOL *, D3D11_VIDEO_PROCESSOR_STEREO_FORMAT *, BOOL *, BOOL *, D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE *, int *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            uint,
            BOOL*,
            D3D11_VIDEO_PROCESSOR_STEREO_FORMAT*,
            BOOL*,
            BOOL*,
            D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE*,
            int*,
            void> VideoProcessorGetStreamStereoFormat;

        [NativeTypeName("void (ID3D11VideoProcessor *, UINT, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            uint,
            BOOL*,
            void> VideoProcessorGetStreamAutoProcessingMode;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, UINT, D3D11_VIDEO_PROCESSOR_FILTER, BOOL *, int *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            uint,
            D3D11_VIDEO_PROCESSOR_FILTER,
            BOOL*,
            int*,
            void> VideoProcessorGetStreamFilter;

        [NativeTypeName(
            "APP_DEPRECATED_HRESULT (ID3D11VideoProcessor *, UINT, const GUID *, UINT, void *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            uint,
            Guid*,
            uint,
            void*,
            int> VideoProcessorGetStreamExtension;

        [NativeTypeName(
            "HRESULT (ID3D11VideoProcessor *, ID3D11VideoProcessorOutputView *, UINT, UINT, const D3D11_VIDEO_PROCESSOR_STREAM *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            ID3D11VideoProcessorOutputView,
            uint,
            uint,
            D3D11_VIDEO_PROCESSOR_STREAM*,
            int> VideoProcessorBlt;

        [NativeTypeName("HRESULT (ID3D11CryptoSession *, UINT, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ID3D11CryptoSession,
            uint,
            void*,
            int> NegotiateCryptoSessionKeyExchange;

        [NativeTypeName(
            "void (ID3D11CryptoSession *, ID3D11Texture2D *, ID3D11Texture2D *, UINT, void *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11CryptoSession,
            ID3D11Texture2D,
            ID3D11Texture2D,
            uint,
            void*,
            void> EncryptionBlt;

        [NativeTypeName(
            "void (ID3D11CryptoSession *, ID3D11Texture2D *, ID3D11Texture2D *, D3D11_ENCRYPTED_BLOCK_INFO *, UINT, const void *, UINT, void *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11CryptoSession,
            ID3D11Texture2D,
            ID3D11Texture2D,
            D3D11_ENCRYPTED_BLOCK_INFO*,
            uint,
            void*,
            uint,
            void*,
            void> DecryptionBlt;

        [NativeTypeName("void (ID3D11CryptoSession *, UINT, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ID3D11CryptoSession,
            uint,
            void*,
            void> StartSessionKeyRefresh;

        [NativeTypeName("void (ID3D11CryptoSession *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11CryptoSession, void> FinishSessionKeyRefresh;

        [NativeTypeName("HRESULT (ID3D11CryptoSession *, UINT, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ID3D11CryptoSession,
            uint,
            void*,
            int> GetEncryptionBltKey;

        [NativeTypeName(
            "HRESULT (ID3D11AuthenticatedChannel *, UINT, void *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11AuthenticatedChannel,
            uint,
            void*,
            int> NegotiateAuthenticatedChannelKeyExchange;

        [NativeTypeName(
            "HRESULT (ID3D11AuthenticatedChannel *, UINT, const void *, UINT, void *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11AuthenticatedChannel,
            uint,
            void*,
            uint,
            void*,
            int> QueryAuthenticatedChannel;

        [NativeTypeName(
            "HRESULT (ID3D11AuthenticatedChannel *, UINT, const void *, D3D11_AUTHENTICATED_CONFIGURE_OUTPUT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11AuthenticatedChannel,
            uint,
            void*,
            D3D11_AUTHENTICATED_CONFIGURE_OUTPUT*,
            int> ConfigureAuthenticatedChannel;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, UINT, BOOL, D3D11_VIDEO_PROCESSOR_ROTATION) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            uint,
            BOOL,
            D3D11_VIDEO_PROCESSOR_ROTATION,
            void> VideoProcessorSetStreamRotation;

        [NativeTypeName(
            "void (ID3D11VideoProcessor *, UINT, BOOL *, D3D11_VIDEO_PROCESSOR_ROTATION *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VideoProcessor,
            uint,
            BOOL*,
            D3D11_VIDEO_PROCESSOR_ROTATION*,
            void> VideoProcessorGetStreamRotation;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D11VideoContext"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D11VideoContext(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D11DeviceChild"/> to <see cref = "ID3D11VideoContext"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D11DeviceChild"/> instance to be converted </param>
    public static explicit operator ID3D11VideoContext(Silk.NET.DirectX.ID3D11DeviceChild value)
    {
        return new ID3D11VideoContext(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11VideoContext"/> to <see cref = "Silk.NET.DirectX.ID3D11DeviceChild"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11VideoContext"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D11DeviceChild(ID3D11VideoContext value)
    {
        return new Silk.NET.DirectX.ID3D11DeviceChild(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D11VideoContext"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D11VideoContext(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D11VideoContext(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11VideoContext"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11VideoContext"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D11VideoContext value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
