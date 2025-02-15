// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("50C83A1C-E072-4C48-87B0-3630FA36A6D0")]
[NativeTypeName("struct IDXGIFactory2 : IDXGIFactory1")]
[NativeInheritance("IDXGIFactory1")]
public unsafe partial struct IDXGIFactory2 : IDXGIFactory2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIFactory2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGIFactory2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDXGIFactory2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGIFactory2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPrivateData(
        [NativeTypeName("const GUID &")] Guid* Name,
        uint DataSize,
        [NativeTypeName("const void *")] void* pData
    )
    {
        return ((delegate* unmanaged<IDXGIFactory2, Guid*, uint, void*, int>)((*lpVtbl)[3]))(
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
        return ((delegate* unmanaged<IDXGIFactory2, Guid*, IUnknown, int>)((*lpVtbl)[4]))(
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
        return ((delegate* unmanaged<IDXGIFactory2, Guid*, uint*, void*, int>)((*lpVtbl)[5]))(
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
        return ((delegate* unmanaged<IDXGIFactory2, Guid*, void**, int>)((*lpVtbl)[6]))(
            this,
            riid,
            ppParent
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT EnumAdapters(uint Adapter, IDXGIAdapter* ppAdapter)
    {
        return ((delegate* unmanaged<IDXGIFactory2, uint, IDXGIAdapter*, int>)((*lpVtbl)[7]))(
            this,
            Adapter,
            ppAdapter
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT MakeWindowAssociation(HWND WindowHandle, uint Flags)
    {
        return ((delegate* unmanaged<IDXGIFactory2, HWND, uint, int>)((*lpVtbl)[8]))(
            this,
            WindowHandle,
            Flags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetWindowAssociation(HWND* pWindowHandle)
    {
        return ((delegate* unmanaged<IDXGIFactory2, HWND*, int>)((*lpVtbl)[9]))(
            this,
            pWindowHandle
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateSwapChain(
        IUnknown pDevice,
        DXGI_SWAP_CHAIN_DESC* pDesc,
        IDXGISwapChain* ppSwapChain
    )
    {
        return (
            (delegate* unmanaged<
                IDXGIFactory2,
                IUnknown,
                DXGI_SWAP_CHAIN_DESC*,
                IDXGISwapChain*,
                int>)((*lpVtbl)[10])
        )(this, pDevice, pDesc, ppSwapChain);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateSoftwareAdapter(HMODULE Module, IDXGIAdapter* ppAdapter)
    {
        return ((delegate* unmanaged<IDXGIFactory2, HMODULE, IDXGIAdapter*, int>)((*lpVtbl)[11]))(
            this,
            Module,
            ppAdapter
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT EnumAdapters1(uint Adapter, IDXGIAdapter1* ppAdapter)
    {
        return ((delegate* unmanaged<IDXGIFactory2, uint, IDXGIAdapter1*, int>)((*lpVtbl)[12]))(
            this,
            Adapter,
            ppAdapter
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public BOOL IsCurrent()
    {
        return ((delegate* unmanaged<IDXGIFactory2, int>)((*lpVtbl)[13]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public BOOL IsWindowedStereoEnabled()
    {
        return ((delegate* unmanaged<IDXGIFactory2, int>)((*lpVtbl)[14]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateSwapChainForHwnd(
        IUnknown pDevice,
        HWND hWnd,
        [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc,
        [NativeTypeName("const DXGI_SWAP_CHAIN_FULLSCREEN_DESC *")]
            DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pFullscreenDesc,
        IDXGIOutput pRestrictToOutput,
        IDXGISwapChain1* ppSwapChain
    )
    {
        return (
            (delegate* unmanaged<
                IDXGIFactory2,
                IUnknown,
                HWND,
                DXGI_SWAP_CHAIN_DESC1*,
                DXGI_SWAP_CHAIN_FULLSCREEN_DESC*,
                IDXGIOutput,
                IDXGISwapChain1*,
                int>)((*lpVtbl)[15])
        )(this, pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateSwapChainForCoreWindow(
        IUnknown pDevice,
        IUnknown pWindow,
        [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc,
        IDXGIOutput pRestrictToOutput,
        IDXGISwapChain1* ppSwapChain
    )
    {
        return (
            (delegate* unmanaged<
                IDXGIFactory2,
                IUnknown,
                IUnknown,
                DXGI_SWAP_CHAIN_DESC1*,
                IDXGIOutput,
                IDXGISwapChain1*,
                int>)((*lpVtbl)[16])
        )(this, pDevice, pWindow, pDesc, pRestrictToOutput, ppSwapChain);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetSharedResourceAdapterLuid(HANDLE hResource, LUID* pLuid)
    {
        return ((delegate* unmanaged<IDXGIFactory2, HANDLE, LUID*, int>)((*lpVtbl)[17]))(
            this,
            hResource,
            pLuid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT RegisterStereoStatusWindow(
        HWND WindowHandle,
        uint wMsg,
        [NativeTypeName("DWORD *")] uint* pdwCookie
    )
    {
        return ((delegate* unmanaged<IDXGIFactory2, HWND, uint, uint*, int>)((*lpVtbl)[18]))(
            this,
            WindowHandle,
            wMsg,
            pdwCookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT RegisterStereoStatusEvent(
        HANDLE hEvent,
        [NativeTypeName("DWORD *")] uint* pdwCookie
    )
    {
        return ((delegate* unmanaged<IDXGIFactory2, HANDLE, uint*, int>)((*lpVtbl)[19]))(
            this,
            hEvent,
            pdwCookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public void UnregisterStereoStatus([NativeTypeName("DWORD")] uint dwCookie)
    {
        ((delegate* unmanaged<IDXGIFactory2, uint, void>)((*lpVtbl)[20]))(this, dwCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT RegisterOcclusionStatusWindow(
        HWND WindowHandle,
        uint wMsg,
        [NativeTypeName("DWORD *")] uint* pdwCookie
    )
    {
        return ((delegate* unmanaged<IDXGIFactory2, HWND, uint, uint*, int>)((*lpVtbl)[21]))(
            this,
            WindowHandle,
            wMsg,
            pdwCookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT RegisterOcclusionStatusEvent(
        HANDLE hEvent,
        [NativeTypeName("DWORD *")] uint* pdwCookie
    )
    {
        return ((delegate* unmanaged<IDXGIFactory2, HANDLE, uint*, int>)((*lpVtbl)[22]))(
            this,
            hEvent,
            pdwCookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public void UnregisterOcclusionStatus([NativeTypeName("DWORD")] uint dwCookie)
    {
        ((delegate* unmanaged<IDXGIFactory2, uint, void>)((*lpVtbl)[23]))(this, dwCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT CreateSwapChainForComposition(
        IUnknown pDevice,
        [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc,
        IDXGIOutput pRestrictToOutput,
        IDXGISwapChain1* ppSwapChain
    )
    {
        return (
            (delegate* unmanaged<
                IDXGIFactory2,
                IUnknown,
                DXGI_SWAP_CHAIN_DESC1*,
                IDXGIOutput,
                IDXGISwapChain1*,
                int>)((*lpVtbl)[24])
        )(this, pDevice, pDesc, pRestrictToOutput, ppSwapChain);
    }

    public interface Interface : IDXGIFactory1.Interface
    {
        [VtblIndex(14)]
        BOOL IsWindowedStereoEnabled();

        [VtblIndex(15)]
        HRESULT CreateSwapChainForHwnd(
            IUnknown pDevice,
            HWND hWnd,
            [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc,
            [NativeTypeName("const DXGI_SWAP_CHAIN_FULLSCREEN_DESC *")]
                DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pFullscreenDesc,
            IDXGIOutput pRestrictToOutput,
            IDXGISwapChain1* ppSwapChain
        );

        [VtblIndex(16)]
        HRESULT CreateSwapChainForCoreWindow(
            IUnknown pDevice,
            IUnknown pWindow,
            [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc,
            IDXGIOutput pRestrictToOutput,
            IDXGISwapChain1* ppSwapChain
        );

        [VtblIndex(17)]
        HRESULT GetSharedResourceAdapterLuid(HANDLE hResource, LUID* pLuid);

        [VtblIndex(18)]
        HRESULT RegisterStereoStatusWindow(
            HWND WindowHandle,
            uint wMsg,
            [NativeTypeName("DWORD *")] uint* pdwCookie
        );

        [VtblIndex(19)]
        HRESULT RegisterStereoStatusEvent(
            HANDLE hEvent,
            [NativeTypeName("DWORD *")] uint* pdwCookie
        );

        [VtblIndex(20)]
        void UnregisterStereoStatus([NativeTypeName("DWORD")] uint dwCookie);

        [VtblIndex(21)]
        HRESULT RegisterOcclusionStatusWindow(
            HWND WindowHandle,
            uint wMsg,
            [NativeTypeName("DWORD *")] uint* pdwCookie
        );

        [VtblIndex(22)]
        HRESULT RegisterOcclusionStatusEvent(
            HANDLE hEvent,
            [NativeTypeName("DWORD *")] uint* pdwCookie
        );

        [VtblIndex(23)]
        void UnregisterOcclusionStatus([NativeTypeName("DWORD")] uint dwCookie);

        [VtblIndex(24)]
        HRESULT CreateSwapChainForComposition(
            IUnknown pDevice,
            [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc,
            IDXGIOutput pRestrictToOutput,
            IDXGISwapChain1* ppSwapChain
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

        [NativeTypeName("HRESULT (UINT, IDXGIAdapter **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDXGIAdapter*, int> EnumAdapters;

        [NativeTypeName("HRESULT (HWND, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, int> MakeWindowAssociation;

        [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND*, int> GetWindowAssociation;

        [NativeTypeName(
            "HRESULT (IUnknown *, DXGI_SWAP_CHAIN_DESC *, IDXGISwapChain **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            DXGI_SWAP_CHAIN_DESC*,
            IDXGISwapChain*,
            int> CreateSwapChain;

        [NativeTypeName("HRESULT (HMODULE, IDXGIAdapter **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HMODULE, IDXGIAdapter*, int> CreateSoftwareAdapter;

        [NativeTypeName("HRESULT (UINT, IDXGIAdapter1 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDXGIAdapter1*, int> EnumAdapters1;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsCurrent;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsWindowedStereoEnabled;

        [NativeTypeName(
            "HRESULT (IUnknown *, HWND, const DXGI_SWAP_CHAIN_DESC1 *, const DXGI_SWAP_CHAIN_FULLSCREEN_DESC *, IDXGIOutput *, IDXGISwapChain1 **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            HWND,
            DXGI_SWAP_CHAIN_DESC1*,
            DXGI_SWAP_CHAIN_FULLSCREEN_DESC*,
            IDXGIOutput,
            IDXGISwapChain1*,
            int> CreateSwapChainForHwnd;

        [NativeTypeName(
            "HRESULT (IUnknown *, IUnknown *, const DXGI_SWAP_CHAIN_DESC1 *, IDXGIOutput *, IDXGISwapChain1 **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            IUnknown,
            DXGI_SWAP_CHAIN_DESC1*,
            IDXGIOutput,
            IDXGISwapChain1*,
            int> CreateSwapChainForCoreWindow;

        [NativeTypeName("HRESULT (HANDLE, LUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, LUID*, int> GetSharedResourceAdapterLuid;

        [NativeTypeName("HRESULT (HWND, UINT, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, uint*, int> RegisterStereoStatusWindow;

        [NativeTypeName("HRESULT (HANDLE, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, uint*, int> RegisterStereoStatusEvent;

        [NativeTypeName("void (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void> UnregisterStereoStatus;

        [NativeTypeName("HRESULT (HWND, UINT, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, uint*, int> RegisterOcclusionStatusWindow;

        [NativeTypeName("HRESULT (HANDLE, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, uint*, int> RegisterOcclusionStatusEvent;

        [NativeTypeName("void (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void> UnregisterOcclusionStatus;

        [NativeTypeName(
            "HRESULT (IUnknown *, const DXGI_SWAP_CHAIN_DESC1 *, IDXGIOutput *, IDXGISwapChain1 **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            DXGI_SWAP_CHAIN_DESC1*,
            IDXGIOutput,
            IDXGISwapChain1*,
            int> CreateSwapChainForComposition;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDXGIFactory2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDXGIFactory2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIFactory1"/> to <see cref = "IDXGIFactory2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIFactory1"/> instance to be converted </param>
    public static explicit operator IDXGIFactory2(Silk.NET.DirectX.IDXGIFactory1 value)
    {
        return new IDXGIFactory2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIFactory2"/> to <see cref = "Silk.NET.DirectX.IDXGIFactory1"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIFactory2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIFactory1(IDXGIFactory2 value)
    {
        return new Silk.NET.DirectX.IDXGIFactory1(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIFactory"/> to <see cref = "IDXGIFactory2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIFactory"/> instance to be converted </param>
    public static explicit operator IDXGIFactory2(Silk.NET.DirectX.IDXGIFactory value)
    {
        return new IDXGIFactory2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIFactory2"/> to <see cref = "Silk.NET.DirectX.IDXGIFactory"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIFactory2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIFactory(IDXGIFactory2 value)
    {
        return new Silk.NET.DirectX.IDXGIFactory(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDXGIObject"/> to <see cref = "IDXGIFactory2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDXGIObject"/> instance to be converted </param>
    public static explicit operator IDXGIFactory2(Silk.NET.DirectX.IDXGIObject value)
    {
        return new IDXGIFactory2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIFactory2"/> to <see cref = "Silk.NET.DirectX.IDXGIObject"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIFactory2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDXGIObject(IDXGIFactory2 value)
    {
        return new Silk.NET.DirectX.IDXGIObject(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDXGIFactory2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDXGIFactory2(Silk.NET.Windows.IUnknown value)
    {
        return new IDXGIFactory2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIFactory2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIFactory2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDXGIFactory2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
