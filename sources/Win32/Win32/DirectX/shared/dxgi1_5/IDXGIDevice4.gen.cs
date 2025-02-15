// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_5.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("95B4F95F-D8DA-4CA4-9EE6-3B76D5968A10")]
[NativeTypeName("struct IDXGIDevice4 : IDXGIDevice3")]
[NativeInheritance("IDXGIDevice3")]
public unsafe partial struct IDXGIDevice4 : IDXGIDevice4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIDevice4));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGIDevice4, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDXGIDevice4, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGIDevice4, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPrivateData(
        [NativeTypeName("const GUID &")] Guid* Name,
        uint DataSize,
        [NativeTypeName("const void *")] void* pData
    )
    {
        return ((delegate* unmanaged<IDXGIDevice4, Guid*, uint, void*, int>)((*lpVtbl)[3]))(
            this,
            Name,
            DataSize,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateDataInterface(
        [NativeTypeName("const GUID &")] Guid* Name,
        [NativeTypeName("const IUnknown *")] IUnknown pUnknown
    )
    {
        return ((delegate* unmanaged<IDXGIDevice4, Guid*, IUnknown, int>)((*lpVtbl)[4]))(
            this,
            Name,
            pUnknown
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPrivateData(
        [NativeTypeName("const GUID &")] Guid* Name,
        uint* pDataSize,
        void* pData
    )
    {
        return ((delegate* unmanaged<IDXGIDevice4, Guid*, uint*, void*, int>)((*lpVtbl)[5]))(
            this,
            Name,
            pDataSize,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
    {
        return ((delegate* unmanaged<IDXGIDevice4, Guid*, void**, int>)((*lpVtbl)[6]))(
            this,
            riid,
            ppParent
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetAdapter(IDXGIAdapter* pAdapter)
    {
        return ((delegate* unmanaged<IDXGIDevice4, IDXGIAdapter*, int>)((*lpVtbl)[7]))(
            this,
            pAdapter
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateSurface(
        [NativeTypeName("const DXGI_SURFACE_DESC *")] DXGI_SURFACE_DESC* pDesc,
        uint NumSurfaces,
        [NativeTypeName("DXGI_USAGE")] uint Usage,
        [NativeTypeName("const DXGI_SHARED_RESOURCE *")] DXGI_SHARED_RESOURCE* pSharedResource,
        IDXGISurface* ppSurface
    )
    {
        return (
            (delegate* unmanaged<
                IDXGIDevice4,
                DXGI_SURFACE_DESC*,
                uint,
                uint,
                DXGI_SHARED_RESOURCE*,
                IDXGISurface*,
                int>)((*lpVtbl)[8])
        )(this, pDesc, NumSurfaces, Usage, pSharedResource, ppSurface);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT QueryResourceResidency(
        [NativeTypeName("IUnknown *const *")] IUnknown* ppResources,
        DXGI_RESIDENCY* pResidencyStatus,
        uint NumResources
    )
    {
        return (
            (delegate* unmanaged<IDXGIDevice4, IUnknown*, DXGI_RESIDENCY*, uint, int>)((*lpVtbl)[9])
        )(this, ppResources, pResidencyStatus, NumResources);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetGPUThreadPriority(int Priority)
    {
        return ((delegate* unmanaged<IDXGIDevice4, int, int>)((*lpVtbl)[10]))(this, Priority);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetGPUThreadPriority(int* pPriority)
    {
        return ((delegate* unmanaged<IDXGIDevice4, int*, int>)((*lpVtbl)[11]))(this, pPriority);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetMaximumFrameLatency(uint MaxLatency)
    {
        return ((delegate* unmanaged<IDXGIDevice4, uint, int>)((*lpVtbl)[12]))(this, MaxLatency);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetMaximumFrameLatency(uint* pMaxLatency)
    {
        return ((delegate* unmanaged<IDXGIDevice4, uint*, int>)((*lpVtbl)[13]))(this, pMaxLatency);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT OfferResources(
        uint NumResources,
        [NativeTypeName("IDXGIResource *const *")] IDXGIResource* ppResources,
        DXGI_OFFER_RESOURCE_PRIORITY Priority
    )
    {
        return (
            (delegate* unmanaged<
                IDXGIDevice4,
                uint,
                IDXGIResource*,
                DXGI_OFFER_RESOURCE_PRIORITY,
                int>)((*lpVtbl)[14])
        )(this, NumResources, ppResources, Priority);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ReclaimResources(
        uint NumResources,
        [NativeTypeName("IDXGIResource *const *")] IDXGIResource* ppResources,
        BOOL* pDiscarded
    )
    {
        return (
            (delegate* unmanaged<IDXGIDevice4, uint, IDXGIResource*, BOOL*, int>)((*lpVtbl)[15])
        )(this, NumResources, ppResources, pDiscarded);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT EnqueueSetEvent(HANDLE hEvent)
    {
        return ((delegate* unmanaged<IDXGIDevice4, HANDLE, int>)((*lpVtbl)[16]))(this, hEvent);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public void Trim()
    {
        ((delegate* unmanaged<IDXGIDevice4, void>)((*lpVtbl)[17]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT OfferResources1(
        uint NumResources,
        [NativeTypeName("IDXGIResource *const *")] IDXGIResource* ppResources,
        DXGI_OFFER_RESOURCE_PRIORITY Priority,
        uint Flags
    )
    {
        return (
            (delegate* unmanaged<
                IDXGIDevice4,
                uint,
                IDXGIResource*,
                DXGI_OFFER_RESOURCE_PRIORITY,
                uint,
                int>)((*lpVtbl)[18])
        )(this, NumResources, ppResources, Priority, Flags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT ReclaimResources1(
        uint NumResources,
        [NativeTypeName("IDXGIResource *const *")] IDXGIResource* ppResources,
        DXGI_RECLAIM_RESOURCE_RESULTS* pResults
    )
    {
        return (
            (delegate* unmanaged<
                IDXGIDevice4,
                uint,
                IDXGIResource*,
                DXGI_RECLAIM_RESOURCE_RESULTS*,
                int>)((*lpVtbl)[19])
        )(this, NumResources, ppResources, pResults);
    }

    public interface Interface : IDXGIDevice3.Interface
    {
        [VtblIndex(18)]
        HRESULT OfferResources1(
            uint NumResources,
            [NativeTypeName("IDXGIResource *const *")] IDXGIResource* ppResources,
            DXGI_OFFER_RESOURCE_PRIORITY Priority,
            uint Flags
        );

        [VtblIndex(19)]
        HRESULT ReclaimResources1(
            uint NumResources,
            [NativeTypeName("IDXGIResource *const *")] IDXGIResource* ppResources,
            DXGI_RECLAIM_RESOURCE_RESULTS* pResults
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

        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown, int> SetPrivateDataInterface;

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetParent;

        [NativeTypeName("HRESULT (IDXGIAdapter **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDXGIAdapter*, int> GetAdapter;

        [NativeTypeName(
            "HRESULT (const DXGI_SURFACE_DESC *, UINT, DXGI_USAGE, const DXGI_SHARED_RESOURCE *, IDXGISurface **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DXGI_SURFACE_DESC*,
            uint,
            uint,
            DXGI_SHARED_RESOURCE*,
            IDXGISurface*,
            int> CreateSurface;

        [NativeTypeName(
            "HRESULT (IUnknown *const *, DXGI_RESIDENCY *, UINT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown*,
            DXGI_RESIDENCY*,
            uint,
            int> QueryResourceResidency;

        [NativeTypeName("HRESULT (INT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> SetGPUThreadPriority;

        [NativeTypeName("HRESULT (INT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetGPUThreadPriority;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetMaximumFrameLatency;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMaximumFrameLatency;

        [NativeTypeName(
            "HRESULT (UINT, IDXGIResource *const *, DXGI_OFFER_RESOURCE_PRIORITY) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IDXGIResource*,
            DXGI_OFFER_RESOURCE_PRIORITY,
            int> OfferResources;

        [NativeTypeName("HRESULT (UINT, IDXGIResource *const *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDXGIResource*, BOOL*, int> ReclaimResources;

        [NativeTypeName("HRESULT (HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, int> EnqueueSetEvent;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Trim;

        [NativeTypeName(
            "HRESULT (UINT, IDXGIResource *const *, DXGI_OFFER_RESOURCE_PRIORITY, UINT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IDXGIResource*,
            DXGI_OFFER_RESOURCE_PRIORITY,
            uint,
            int> OfferResources1;

        [NativeTypeName(
            "HRESULT (UINT, IDXGIResource *const *, DXGI_RECLAIM_RESOURCE_RESULTS *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IDXGIResource*,
            DXGI_RECLAIM_RESOURCE_RESULTS*,
            int> ReclaimResources1;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDXGIDevice4"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDXGIDevice4(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIDevice3"/> to <see cref = "IDXGIDevice4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIDevice3"/> instance to be converted </param>
    public static explicit operator IDXGIDevice4(Silk.NET.DirectX.IDXGIDevice3 value)
    {
        return new IDXGIDevice4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIDevice4"/> to <see cref = "Silk.NET.DirectX.IDXGIDevice3"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIDevice4"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIDevice3(IDXGIDevice4 value)
    {
        return new Silk.NET.DirectX.IDXGIDevice3(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIDevice2"/> to <see cref = "IDXGIDevice4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIDevice2"/> instance to be converted </param>
    public static explicit operator IDXGIDevice4(Silk.NET.DirectX.IDXGIDevice2 value)
    {
        return new IDXGIDevice4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIDevice4"/> to <see cref = "Silk.NET.DirectX.IDXGIDevice2"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIDevice4"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIDevice2(IDXGIDevice4 value)
    {
        return new Silk.NET.DirectX.IDXGIDevice2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIDevice1"/> to <see cref = "IDXGIDevice4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIDevice1"/> instance to be converted </param>
    public static explicit operator IDXGIDevice4(Silk.NET.DirectX.IDXGIDevice1 value)
    {
        return new IDXGIDevice4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIDevice4"/> to <see cref = "Silk.NET.DirectX.IDXGIDevice1"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIDevice4"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIDevice1(IDXGIDevice4 value)
    {
        return new Silk.NET.DirectX.IDXGIDevice1(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIDevice"/> to <see cref = "IDXGIDevice4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIDevice"/> instance to be converted </param>
    public static explicit operator IDXGIDevice4(Silk.NET.DirectX.IDXGIDevice value)
    {
        return new IDXGIDevice4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIDevice4"/> to <see cref = "Silk.NET.DirectX.IDXGIDevice"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIDevice4"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIDevice(IDXGIDevice4 value)
    {
        return new Silk.NET.DirectX.IDXGIDevice(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIObject"/> to <see cref = "IDXGIDevice4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIObject"/> instance to be converted </param>
    public static explicit operator IDXGIDevice4(Silk.NET.DirectX.IDXGIObject value)
    {
        return new IDXGIDevice4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIDevice4"/> to <see cref = "Silk.NET.DirectX.IDXGIObject"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIDevice4"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIObject(IDXGIDevice4 value)
    {
        return new Silk.NET.DirectX.IDXGIObject(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDXGIDevice4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDXGIDevice4(Silk.NET.Windows.IUnknown value)
    {
        return new IDXGIDevice4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIDevice4"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIDevice4"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDXGIDevice4 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
