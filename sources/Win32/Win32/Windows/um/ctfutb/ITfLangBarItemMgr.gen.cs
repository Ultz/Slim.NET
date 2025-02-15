// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("BA468C55-9956-4FB1-A59D-52A7DD7CC6AA")]
[NativeTypeName("struct ITfLangBarItemMgr : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfLangBarItemMgr : ITfLangBarItemMgr.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfLangBarItemMgr));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfLangBarItemMgr, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfLangBarItemMgr, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfLangBarItemMgr, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT EnumItems(IEnumTfLangBarItems* ppEnum)
    {
        return ((delegate* unmanaged<ITfLangBarItemMgr, IEnumTfLangBarItems*, int>)((*lpVtbl)[3]))(
            this,
            ppEnum
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetItem([NativeTypeName("const GUID &")] Guid* rguid, ITfLangBarItem* ppItem)
    {
        return (
            (delegate* unmanaged<ITfLangBarItemMgr, Guid*, ITfLangBarItem*, int>)((*lpVtbl)[4])
        )(this, rguid, ppItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddItem(ITfLangBarItem punk)
    {
        return ((delegate* unmanaged<ITfLangBarItemMgr, ITfLangBarItem, int>)((*lpVtbl)[5]))(
            this,
            punk
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RemoveItem(ITfLangBarItem punk)
    {
        return ((delegate* unmanaged<ITfLangBarItemMgr, ITfLangBarItem, int>)((*lpVtbl)[6]))(
            this,
            punk
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AdviseItemSink(
        ITfLangBarItemSink punk,
        [NativeTypeName("DWORD *")] uint* pdwCookie,
        [NativeTypeName("const GUID &")] Guid* rguidItem
    )
    {
        return (
            (delegate* unmanaged<ITfLangBarItemMgr, ITfLangBarItemSink, uint*, Guid*, int>)(
                (*lpVtbl)[7]
            )
        )(this, punk, pdwCookie, rguidItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT UnadviseItemSink([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged<ITfLangBarItemMgr, uint, int>)((*lpVtbl)[8]))(this, dwCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetItemFloatingRect(
        [NativeTypeName("DWORD")] uint dwThreadId,
        [NativeTypeName("const GUID &")] Guid* rguid,
        RECT* prc
    )
    {
        return ((delegate* unmanaged<ITfLangBarItemMgr, uint, Guid*, RECT*, int>)((*lpVtbl)[9]))(
            this,
            dwThreadId,
            rguid,
            prc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetItemsStatus(
        [NativeTypeName("ULONG")] uint ulCount,
        [NativeTypeName("const GUID *")] Guid* prgguid,
        [NativeTypeName("DWORD *")] uint* pdwStatus
    )
    {
        return ((delegate* unmanaged<ITfLangBarItemMgr, uint, Guid*, uint*, int>)((*lpVtbl)[10]))(
            this,
            ulCount,
            prgguid,
            pdwStatus
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetItemNum([NativeTypeName("ULONG *")] uint* pulCount)
    {
        return ((delegate* unmanaged<ITfLangBarItemMgr, uint*, int>)((*lpVtbl)[11]))(
            this,
            pulCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetItems(
        [NativeTypeName("ULONG")] uint ulCount,
        ITfLangBarItem* ppItem,
        TF_LANGBARITEMINFO* pInfo,
        [NativeTypeName("DWORD *")] uint* pdwStatus,
        [NativeTypeName("ULONG *")] uint* pcFetched
    )
    {
        return (
            (delegate* unmanaged<
                ITfLangBarItemMgr,
                uint,
                ITfLangBarItem*,
                TF_LANGBARITEMINFO*,
                uint*,
                uint*,
                int>)((*lpVtbl)[12])
        )(this, ulCount, ppItem, pInfo, pdwStatus, pcFetched);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT AdviseItemsSink(
        [NativeTypeName("ULONG")] uint ulCount,
        ITfLangBarItemSink* ppunk,
        [NativeTypeName("const GUID *")] Guid* pguidItem,
        [NativeTypeName("DWORD *")] uint* pdwCookie
    )
    {
        return (
            (delegate* unmanaged<ITfLangBarItemMgr, uint, ITfLangBarItemSink*, Guid*, uint*, int>)(
                (*lpVtbl)[13]
            )
        )(this, ulCount, ppunk, pguidItem, pdwCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT UnadviseItemsSink(
        [NativeTypeName("ULONG")] uint ulCount,
        [NativeTypeName("DWORD *")] uint* pdwCookie
    )
    {
        return ((delegate* unmanaged<ITfLangBarItemMgr, uint, uint*, int>)((*lpVtbl)[14]))(
            this,
            ulCount,
            pdwCookie
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT EnumItems(IEnumTfLangBarItems* ppEnum);

        [VtblIndex(4)]
        HRESULT GetItem([NativeTypeName("const GUID &")] Guid* rguid, ITfLangBarItem* ppItem);

        [VtblIndex(5)]
        HRESULT AddItem(ITfLangBarItem punk);

        [VtblIndex(6)]
        HRESULT RemoveItem(ITfLangBarItem punk);

        [VtblIndex(7)]
        HRESULT AdviseItemSink(
            ITfLangBarItemSink punk,
            [NativeTypeName("DWORD *")] uint* pdwCookie,
            [NativeTypeName("const GUID &")] Guid* rguidItem
        );

        [VtblIndex(8)]
        HRESULT UnadviseItemSink([NativeTypeName("DWORD")] uint dwCookie);

        [VtblIndex(9)]
        HRESULT GetItemFloatingRect(
            [NativeTypeName("DWORD")] uint dwThreadId,
            [NativeTypeName("const GUID &")] Guid* rguid,
            RECT* prc
        );

        [VtblIndex(10)]
        HRESULT GetItemsStatus(
            [NativeTypeName("ULONG")] uint ulCount,
            [NativeTypeName("const GUID *")] Guid* prgguid,
            [NativeTypeName("DWORD *")] uint* pdwStatus
        );

        [VtblIndex(11)]
        HRESULT GetItemNum([NativeTypeName("ULONG *")] uint* pulCount);

        [VtblIndex(12)]
        HRESULT GetItems(
            [NativeTypeName("ULONG")] uint ulCount,
            ITfLangBarItem* ppItem,
            TF_LANGBARITEMINFO* pInfo,
            [NativeTypeName("DWORD *")] uint* pdwStatus,
            [NativeTypeName("ULONG *")] uint* pcFetched
        );

        [VtblIndex(13)]
        HRESULT AdviseItemsSink(
            [NativeTypeName("ULONG")] uint ulCount,
            ITfLangBarItemSink* ppunk,
            [NativeTypeName("const GUID *")] Guid* pguidItem,
            [NativeTypeName("DWORD *")] uint* pdwCookie
        );

        [VtblIndex(14)]
        HRESULT UnadviseItemsSink(
            [NativeTypeName("ULONG")] uint ulCount,
            [NativeTypeName("DWORD *")] uint* pdwCookie
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

        [NativeTypeName("HRESULT (IEnumTfLangBarItems **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumTfLangBarItems*, int> EnumItems;

        [NativeTypeName("HRESULT (const GUID &, ITfLangBarItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ITfLangBarItem*, int> GetItem;

        [NativeTypeName("HRESULT (ITfLangBarItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfLangBarItem, int> AddItem;

        [NativeTypeName("HRESULT (ITfLangBarItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfLangBarItem, int> RemoveItem;

        [NativeTypeName(
            "HRESULT (ITfLangBarItemSink *, DWORD *, const GUID &) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ITfLangBarItemSink, uint*, Guid*, int> AdviseItemSink;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> UnadviseItemSink;

        [NativeTypeName("HRESULT (DWORD, const GUID &, RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, RECT*, int> GetItemFloatingRect;

        [NativeTypeName("HRESULT (ULONG, const GUID *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, uint*, int> GetItemsStatus;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetItemNum;

        [NativeTypeName(
            "HRESULT (ULONG, ITfLangBarItem **, TF_LANGBARITEMINFO *, DWORD *, ULONG *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            ITfLangBarItem*,
            TF_LANGBARITEMINFO*,
            uint*,
            uint*,
            int> GetItems;

        [NativeTypeName(
            "HRESULT (ULONG, ITfLangBarItemSink **, const GUID *, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            ITfLangBarItemSink*,
            Guid*,
            uint*,
            int> AdviseItemsSink;

        [NativeTypeName("HRESULT (ULONG, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> UnadviseItemsSink;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfLangBarItemMgr"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfLangBarItemMgr(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfLangBarItemMgr"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfLangBarItemMgr(Silk.NET.Windows.IUnknown value)
    {
        return new ITfLangBarItemMgr(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfLangBarItemMgr"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfLangBarItemMgr"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfLangBarItemMgr value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
