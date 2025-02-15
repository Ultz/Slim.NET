// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("B722BCC6-4E68-101B-A2BC-00AA00404770")]
[NativeTypeName("struct IOleDocumentView : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IOleDocumentView : IOleDocumentView.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleDocumentView));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleDocumentView, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IOleDocumentView, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleDocumentView, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetInPlaceSite(IOleInPlaceSite pIPSite)
    {
        return ((delegate* unmanaged<IOleDocumentView, IOleInPlaceSite, int>)((*lpVtbl)[3]))(
            this,
            pIPSite
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetInPlaceSite(IOleInPlaceSite* ppIPSite)
    {
        return ((delegate* unmanaged<IOleDocumentView, IOleInPlaceSite*, int>)((*lpVtbl)[4]))(
            this,
            ppIPSite
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDocument(IUnknown* ppunk)
    {
        return ((delegate* unmanaged<IOleDocumentView, IUnknown*, int>)((*lpVtbl)[5]))(this, ppunk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetRect([NativeTypeName("LPRECT")] RECT* prcView)
    {
        return ((delegate* unmanaged<IOleDocumentView, RECT*, int>)((*lpVtbl)[6]))(this, prcView);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetRect([NativeTypeName("LPRECT")] RECT* prcView)
    {
        return ((delegate* unmanaged<IOleDocumentView, RECT*, int>)((*lpVtbl)[7]))(this, prcView);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetRectComplex(
        [NativeTypeName("LPRECT")] RECT* prcView,
        [NativeTypeName("LPRECT")] RECT* prcHScroll,
        [NativeTypeName("LPRECT")] RECT* prcVScroll,
        [NativeTypeName("LPRECT")] RECT* prcSizeBox
    )
    {
        return (
            (delegate* unmanaged<IOleDocumentView, RECT*, RECT*, RECT*, RECT*, int>)((*lpVtbl)[8])
        )(this, prcView, prcHScroll, prcVScroll, prcSizeBox);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Show(BOOL fShow)
    {
        return ((delegate* unmanaged<IOleDocumentView, BOOL, int>)((*lpVtbl)[9]))(this, fShow);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT UIActivate(BOOL fUIActivate)
    {
        return ((delegate* unmanaged<IOleDocumentView, BOOL, int>)((*lpVtbl)[10]))(
            this,
            fUIActivate
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Open()
    {
        return ((delegate* unmanaged<IOleDocumentView, int>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CloseView([NativeTypeName("DWORD")] uint dwReserved)
    {
        return ((delegate* unmanaged<IOleDocumentView, uint, int>)((*lpVtbl)[12]))(
            this,
            dwReserved
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SaveViewState([NativeTypeName("LPSTREAM")] IStream pstm)
    {
        return ((delegate* unmanaged<IOleDocumentView, IStream, int>)((*lpVtbl)[13]))(this, pstm);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ApplyViewState([NativeTypeName("LPSTREAM")] IStream pstm)
    {
        return ((delegate* unmanaged<IOleDocumentView, IStream, int>)((*lpVtbl)[14]))(this, pstm);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT Clone(IOleInPlaceSite pIPSiteNew, IOleDocumentView* ppViewNew)
    {
        return (
            (delegate* unmanaged<IOleDocumentView, IOleInPlaceSite, IOleDocumentView*, int>)(
                (*lpVtbl)[15]
            )
        )(this, pIPSiteNew, ppViewNew);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetInPlaceSite(IOleInPlaceSite pIPSite);

        [VtblIndex(4)]
        HRESULT GetInPlaceSite(IOleInPlaceSite* ppIPSite);

        [VtblIndex(5)]
        HRESULT GetDocument(IUnknown* ppunk);

        [VtblIndex(6)]
        HRESULT SetRect([NativeTypeName("LPRECT")] RECT* prcView);

        [VtblIndex(7)]
        HRESULT GetRect([NativeTypeName("LPRECT")] RECT* prcView);

        [VtblIndex(8)]
        HRESULT SetRectComplex(
            [NativeTypeName("LPRECT")] RECT* prcView,
            [NativeTypeName("LPRECT")] RECT* prcHScroll,
            [NativeTypeName("LPRECT")] RECT* prcVScroll,
            [NativeTypeName("LPRECT")] RECT* prcSizeBox
        );

        [VtblIndex(9)]
        HRESULT Show(BOOL fShow);

        [VtblIndex(10)]
        HRESULT UIActivate(BOOL fUIActivate);

        [VtblIndex(11)]
        HRESULT Open();

        [VtblIndex(12)]
        HRESULT CloseView([NativeTypeName("DWORD")] uint dwReserved);

        [VtblIndex(13)]
        HRESULT SaveViewState([NativeTypeName("LPSTREAM")] IStream pstm);

        [VtblIndex(14)]
        HRESULT ApplyViewState([NativeTypeName("LPSTREAM")] IStream pstm);

        [VtblIndex(15)]
        HRESULT Clone(IOleInPlaceSite pIPSiteNew, IOleDocumentView* ppViewNew);
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

        [NativeTypeName("HRESULT (IOleInPlaceSite *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleInPlaceSite, int> SetInPlaceSite;

        [NativeTypeName("HRESULT (IOleInPlaceSite **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleInPlaceSite*, int> GetInPlaceSite;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> GetDocument;

        [NativeTypeName("HRESULT (LPRECT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> SetRect;

        [NativeTypeName("HRESULT (LPRECT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> GetRect;

        [NativeTypeName("HRESULT (LPRECT, LPRECT, LPRECT, LPRECT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, RECT*, RECT*, RECT*, int> SetRectComplex;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> Show;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> UIActivate;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Open;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> CloseView;

        [NativeTypeName("HRESULT (LPSTREAM) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream, int> SaveViewState;

        [NativeTypeName("HRESULT (LPSTREAM) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream, int> ApplyViewState;

        [NativeTypeName(
            "HRESULT (IOleInPlaceSite *, IOleDocumentView **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IOleInPlaceSite, IOleDocumentView*, int> Clone;
    }

    /// <summary>Initializes a new instance of the <see cref = "IOleDocumentView"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IOleDocumentView(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IOleDocumentView"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IOleDocumentView(Silk.NET.Windows.IUnknown value)
    {
        return new IOleDocumentView(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleDocumentView"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IOleDocumentView"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IOleDocumentView value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
