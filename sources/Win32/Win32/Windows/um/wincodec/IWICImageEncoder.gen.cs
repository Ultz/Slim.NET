// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("04C75BF8-3CE1-473B-ACC5-3CC4F5E94999")]
[NativeTypeName("struct IWICImageEncoder : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IWICImageEncoder : IWICImageEncoder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICImageEncoder));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICImageEncoder, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWICImageEncoder, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICImageEncoder, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT WriteFrame(
        ID2D1Image pImage,
        IWICBitmapFrameEncode pFrameEncode,
        [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters
    )
    {
        return (
            (delegate* unmanaged<
                IWICImageEncoder,
                ID2D1Image,
                IWICBitmapFrameEncode,
                WICImageParameters*,
                int>)((*lpVtbl)[3])
        )(this, pImage, pFrameEncode, pImageParameters);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT WriteFrameThumbnail(
        ID2D1Image pImage,
        IWICBitmapFrameEncode pFrameEncode,
        [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters
    )
    {
        return (
            (delegate* unmanaged<
                IWICImageEncoder,
                ID2D1Image,
                IWICBitmapFrameEncode,
                WICImageParameters*,
                int>)((*lpVtbl)[4])
        )(this, pImage, pFrameEncode, pImageParameters);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT WriteThumbnail(
        ID2D1Image pImage,
        IWICBitmapEncoder pEncoder,
        [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters
    )
    {
        return (
            (delegate* unmanaged<
                IWICImageEncoder,
                ID2D1Image,
                IWICBitmapEncoder,
                WICImageParameters*,
                int>)((*lpVtbl)[5])
        )(this, pImage, pEncoder, pImageParameters);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT WriteFrame(
            ID2D1Image pImage,
            IWICBitmapFrameEncode pFrameEncode,
            [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters
        );

        [VtblIndex(4)]
        HRESULT WriteFrameThumbnail(
            ID2D1Image pImage,
            IWICBitmapFrameEncode pFrameEncode,
            [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters
        );

        [VtblIndex(5)]
        HRESULT WriteThumbnail(
            ID2D1Image pImage,
            IWICBitmapEncoder pEncoder,
            [NativeTypeName("const WICImageParameters *")] WICImageParameters* pImageParameters
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

        [NativeTypeName(
            "HRESULT (ID2D1Image *, IWICBitmapFrameEncode *, const WICImageParameters *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1Image,
            IWICBitmapFrameEncode,
            WICImageParameters*,
            int> WriteFrame;

        [NativeTypeName(
            "HRESULT (ID2D1Image *, IWICBitmapFrameEncode *, const WICImageParameters *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1Image,
            IWICBitmapFrameEncode,
            WICImageParameters*,
            int> WriteFrameThumbnail;

        [NativeTypeName(
            "HRESULT (ID2D1Image *, IWICBitmapEncoder *, const WICImageParameters *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1Image,
            IWICBitmapEncoder,
            WICImageParameters*,
            int> WriteThumbnail;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWICImageEncoder"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWICImageEncoder(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWICImageEncoder"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWICImageEncoder(Silk.NET.Windows.IUnknown value)
    {
        return new IWICImageEncoder(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICImageEncoder"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWICImageEncoder"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWICImageEncoder value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
