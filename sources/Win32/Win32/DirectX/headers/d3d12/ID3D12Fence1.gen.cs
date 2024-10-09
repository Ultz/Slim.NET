// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID3D12Fence1.xml' path='doc/member[@name="ID3D12Fence1"]/*'/>
[Guid("433685FE-E22B-4CA0-A8DB-B5B4F4DD0E4A")]
[NativeTypeName("struct ID3D12Fence1 : ID3D12Fence")]
[NativeInheritance("ID3D12Fence")]
public unsafe partial struct ID3D12Fence1 : ID3D12Fence1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Fence1));
    public void** lpVtbl;

    /// <inheritdoc cref = "IUnknown.QueryInterface"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12Fence1*, Guid*, void**, int>)(lpVtbl[0]))(
            (ID3D12Fence1*)Unsafe.AsPointer(ref this),
            riid,
            ppvObject
        );
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12Fence1*, uint>)(lpVtbl[1]))(
            (ID3D12Fence1*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "IUnknown.Release"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12Fence1*, uint>)(lpVtbl[2]))(
            (ID3D12Fence1*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "ID3D12Object.GetPrivateData"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint* pDataSize,
        void* pData
    )
    {
        return ((delegate* unmanaged<ID3D12Fence1*, Guid*, uint*, void*, int>)(lpVtbl[3]))(
            (ID3D12Fence1*)Unsafe.AsPointer(ref this),
            guid,
            pDataSize,
            pData
        );
    }

    /// <inheritdoc cref = "ID3D12Object.SetPrivateData"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint DataSize,
        [NativeTypeName("const void *")] void* pData
    )
    {
        return ((delegate* unmanaged<ID3D12Fence1*, Guid*, uint, void*, int>)(lpVtbl[4]))(
            (ID3D12Fence1*)Unsafe.AsPointer(ref this),
            guid,
            DataSize,
            pData
        );
    }

    /// <inheritdoc cref = "ID3D12Object.SetPrivateDataInterface"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface(
        [NativeTypeName("const GUID &")] Guid* guid,
        [NativeTypeName("const IUnknown *")] IUnknown* pData
    )
    {
        return ((delegate* unmanaged<ID3D12Fence1*, Guid*, IUnknown*, int>)(lpVtbl[5]))(
            (ID3D12Fence1*)Unsafe.AsPointer(ref this),
            guid,
            pData
        );
    }

    /// <inheritdoc cref = "ID3D12Object.SetName"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("LPCWSTR")] ushort* Name)
    {
        return ((delegate* unmanaged<ID3D12Fence1*, ushort*, int>)(lpVtbl[6]))(
            (ID3D12Fence1*)Unsafe.AsPointer(ref this),
            Name
        );
    }

    /// <inheritdoc cref = "ID3D12DeviceChild.GetDevice"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
    {
        return ((delegate* unmanaged<ID3D12Fence1*, Guid*, void**, int>)(lpVtbl[7]))(
            (ID3D12Fence1*)Unsafe.AsPointer(ref this),
            riid,
            ppvDevice
        );
    }

    /// <inheritdoc cref = "ID3D12Fence.GetCompletedValue"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("UINT64")]
    public ulong GetCompletedValue()
    {
        return ((delegate* unmanaged<ID3D12Fence1*, ulong>)(lpVtbl[8]))(
            (ID3D12Fence1*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "ID3D12Fence.SetEventOnCompletion"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetEventOnCompletion([NativeTypeName("UINT64")] ulong Value, HANDLE hEvent)
    {
        return ((delegate* unmanaged<ID3D12Fence1*, ulong, HANDLE, int>)(lpVtbl[9]))(
            (ID3D12Fence1*)Unsafe.AsPointer(ref this),
            Value,
            hEvent
        );
    }

    /// <inheritdoc cref = "ID3D12Fence.Signal"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Signal([NativeTypeName("UINT64")] ulong Value)
    {
        return ((delegate* unmanaged<ID3D12Fence1*, ulong, int>)(lpVtbl[10]))(
            (ID3D12Fence1*)Unsafe.AsPointer(ref this),
            Value
        );
    }

    /// <include file='ID3D12Fence1.xml' path='doc/member[@name="ID3D12Fence1.GetCreationFlags"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public D3D12_FENCE_FLAGS GetCreationFlags()
    {
        return ((delegate* unmanaged<ID3D12Fence1*, D3D12_FENCE_FLAGS>)(lpVtbl[11]))(
            (ID3D12Fence1*)Unsafe.AsPointer(ref this)
        );
    }

    public interface Interface : ID3D12Fence.Interface
    {
        [VtblIndex(11)]
        D3D12_FENCE_FLAGS GetCreationFlags();
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

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> SetPrivateDataInterface;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetName;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetDevice;

        [NativeTypeName("UINT64 () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong> GetCompletedValue;

        [NativeTypeName("HRESULT (UINT64, HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, HANDLE, int> SetEventOnCompletion;

        [NativeTypeName("HRESULT (UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, int> Signal;

        [NativeTypeName("D3D12_FENCE_FLAGS () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_FENCE_FLAGS> GetCreationFlags;
    }
}
