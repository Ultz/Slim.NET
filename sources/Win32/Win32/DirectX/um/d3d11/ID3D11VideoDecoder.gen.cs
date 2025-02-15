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

[Guid("3C9C5B51-995D-48D1-9B8D-FA5CAEDED65C")]
[NativeTypeName("struct ID3D11VideoDecoder : ID3D11DeviceChild")]
[NativeInheritance("ID3D11DeviceChild")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct ID3D11VideoDecoder : ID3D11VideoDecoder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11VideoDecoder));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11VideoDecoder, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D11VideoDecoder, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11VideoDecoder, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetDevice(ID3D11Device* ppDevice)
    {
        ((delegate* unmanaged<ID3D11VideoDecoder, ID3D11Device*, void>)((*lpVtbl)[3]))(
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
        return ((delegate* unmanaged<ID3D11VideoDecoder, Guid*, uint*, void*, int>)((*lpVtbl)[4]))(
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
        return ((delegate* unmanaged<ID3D11VideoDecoder, Guid*, uint, void*, int>)((*lpVtbl)[5]))(
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
        return ((delegate* unmanaged<ID3D11VideoDecoder, Guid*, IUnknown, int>)((*lpVtbl)[6]))(
            this,
            guid,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCreationParameters(
        D3D11_VIDEO_DECODER_DESC* pVideoDesc,
        D3D11_VIDEO_DECODER_CONFIG* pConfig
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11VideoDecoder,
                D3D11_VIDEO_DECODER_DESC*,
                D3D11_VIDEO_DECODER_CONFIG*,
                int>)((*lpVtbl)[7])
        )(this, pVideoDesc, pConfig);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDriverHandle(HANDLE* pDriverHandle)
    {
        return ((delegate* unmanaged<ID3D11VideoDecoder, HANDLE*, int>)((*lpVtbl)[8]))(
            this,
            pDriverHandle
        );
    }

    public interface Interface : ID3D11DeviceChild.Interface
    {
        [VtblIndex(7)]
        HRESULT GetCreationParameters(
            D3D11_VIDEO_DECODER_DESC* pVideoDesc,
            D3D11_VIDEO_DECODER_CONFIG* pConfig
        );

        [VtblIndex(8)]
        HRESULT GetDriverHandle(HANDLE* pDriverHandle);
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
            "HRESULT (D3D11_VIDEO_DECODER_DESC *, D3D11_VIDEO_DECODER_CONFIG *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D11_VIDEO_DECODER_DESC*,
            D3D11_VIDEO_DECODER_CONFIG*,
            int> GetCreationParameters;

        [NativeTypeName("HRESULT (HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE*, int> GetDriverHandle;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D11VideoDecoder"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D11VideoDecoder(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D11DeviceChild"/> to <see cref = "ID3D11VideoDecoder"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D11DeviceChild"/> instance to be converted </param>
    public static explicit operator ID3D11VideoDecoder(Silk.NET.DirectX.ID3D11DeviceChild value)
    {
        return new ID3D11VideoDecoder(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11VideoDecoder"/> to <see cref = "Silk.NET.DirectX.ID3D11DeviceChild"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11VideoDecoder"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D11DeviceChild(ID3D11VideoDecoder value)
    {
        return new Silk.NET.DirectX.ID3D11DeviceChild(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D11VideoDecoder"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D11VideoDecoder(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D11VideoDecoder(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11VideoDecoder"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11VideoDecoder"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D11VideoDecoder value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
