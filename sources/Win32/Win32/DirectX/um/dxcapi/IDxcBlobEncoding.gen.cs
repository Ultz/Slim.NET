// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("7241D424-2646-4191-97C0-98E96E42FC68")]
[NativeTypeName("struct IDxcBlobEncoding : IDxcBlob")]
[NativeInheritance("IDxcBlob")]
public unsafe partial struct IDxcBlobEncoding : IDxcBlobEncoding.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcBlobEncoding));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDxcBlobEncoding, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDxcBlobEncoding, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDxcBlobEncoding, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("LPVOID")]
    public void* GetBufferPointer()
    {
        return ((delegate* unmanaged<IDxcBlobEncoding, void*>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("SIZE_T")]
    public nuint GetBufferSize()
    {
        return ((delegate* unmanaged<IDxcBlobEncoding, nuint>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetEncoding(BOOL* pKnown, [NativeTypeName("UINT32 *")] uint* pCodePage)
    {
        return ((delegate* unmanaged<IDxcBlobEncoding, BOOL*, uint*, int>)((*lpVtbl)[5]))(
            this,
            pKnown,
            pCodePage
        );
    }

    public interface Interface : IDxcBlob.Interface
    {
        [VtblIndex(5)]
        HRESULT GetEncoding(BOOL* pKnown, [NativeTypeName("UINT32 *")] uint* pCodePage);
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

        [NativeTypeName("LPVOID () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*> GetBufferPointer;

        [NativeTypeName("SIZE_T () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint> GetBufferSize;

        [NativeTypeName("HRESULT (BOOL *, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, uint*, int> GetEncoding;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDxcBlobEncoding"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDxcBlobEncoding(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDxcBlob"/> to <see cref = "IDxcBlobEncoding"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDxcBlob"/> instance to be converted </param>
    public static explicit operator IDxcBlobEncoding(Silk.NET.DirectX.IDxcBlob value)
    {
        return new IDxcBlobEncoding(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDxcBlobEncoding"/> to <see cref = "Silk.NET.DirectX.IDxcBlob"/>.</summary>
    /// <param name = "value">The <see cref = "IDxcBlobEncoding"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDxcBlob(IDxcBlobEncoding value)
    {
        return new Silk.NET.DirectX.IDxcBlob(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDxcBlobEncoding"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDxcBlobEncoding(Silk.NET.Windows.IUnknown value)
    {
        return new IDxcBlobEncoding(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDxcBlobEncoding"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDxcBlobEncoding"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDxcBlobEncoding value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
