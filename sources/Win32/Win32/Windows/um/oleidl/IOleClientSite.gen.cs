// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00000118-0000-0000-C000-000000000046")]
[NativeTypeName("struct IOleClientSite : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IOleClientSite : IOleClientSite.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleClientSite));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleClientSite, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IOleClientSite, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleClientSite, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SaveObject()
    {
        return ((delegate* unmanaged<IOleClientSite, int>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMoniker(
        [NativeTypeName("DWORD")] uint dwAssign,
        [NativeTypeName("DWORD")] uint dwWhichMoniker,
        IMoniker* ppmk
    )
    {
        return ((delegate* unmanaged<IOleClientSite, uint, uint, IMoniker*, int>)((*lpVtbl)[4]))(
            this,
            dwAssign,
            dwWhichMoniker,
            ppmk
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetContainer(IOleContainer* ppContainer)
    {
        return ((delegate* unmanaged<IOleClientSite, IOleContainer*, int>)((*lpVtbl)[5]))(
            this,
            ppContainer
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ShowObject()
    {
        return ((delegate* unmanaged<IOleClientSite, int>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnShowWindow(BOOL fShow)
    {
        return ((delegate* unmanaged<IOleClientSite, BOOL, int>)((*lpVtbl)[7]))(this, fShow);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RequestNewObjectLayout()
    {
        return ((delegate* unmanaged<IOleClientSite, int>)((*lpVtbl)[8]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SaveObject();

        [VtblIndex(4)]
        HRESULT GetMoniker(
            [NativeTypeName("DWORD")] uint dwAssign,
            [NativeTypeName("DWORD")] uint dwWhichMoniker,
            IMoniker* ppmk
        );

        [VtblIndex(5)]
        HRESULT GetContainer(IOleContainer* ppContainer);

        [VtblIndex(6)]
        HRESULT ShowObject();

        [VtblIndex(7)]
        HRESULT OnShowWindow(BOOL fShow);

        [VtblIndex(8)]
        HRESULT RequestNewObjectLayout();
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SaveObject;

        [NativeTypeName("HRESULT (DWORD, DWORD, IMoniker **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, IMoniker*, int> GetMoniker;

        [NativeTypeName("HRESULT (IOleContainer **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleContainer*, int> GetContainer;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ShowObject;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> OnShowWindow;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RequestNewObjectLayout;
    }

    /// <summary>Initializes a new instance of the <see cref = "IOleClientSite"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IOleClientSite(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IOleClientSite"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IOleClientSite(Silk.NET.Windows.IUnknown value)
    {
        return new IOleClientSite(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleClientSite"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IOleClientSite"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IOleClientSite value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
