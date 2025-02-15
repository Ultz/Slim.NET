// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C3ACEFB5-F69D-4905-938F-FCADCF4BE830")]
[NativeTypeName("struct ITfCategoryMgr : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfCategoryMgr : ITfCategoryMgr.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfCategoryMgr));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfCategoryMgr, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfCategoryMgr, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfCategoryMgr, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterCategory(
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("const GUID &")] Guid* rcatid,
        [NativeTypeName("const GUID &")] Guid* rguid
    )
    {
        return ((delegate* unmanaged<ITfCategoryMgr, Guid*, Guid*, Guid*, int>)((*lpVtbl)[3]))(
            this,
            rclsid,
            rcatid,
            rguid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnregisterCategory(
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("const GUID &")] Guid* rcatid,
        [NativeTypeName("const GUID &")] Guid* rguid
    )
    {
        return ((delegate* unmanaged<ITfCategoryMgr, Guid*, Guid*, Guid*, int>)((*lpVtbl)[4]))(
            this,
            rclsid,
            rcatid,
            rguid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EnumCategoriesInItem(
        [NativeTypeName("const GUID &")] Guid* rguid,
        IEnumGUID* ppEnum
    )
    {
        return ((delegate* unmanaged<ITfCategoryMgr, Guid*, IEnumGUID*, int>)((*lpVtbl)[5]))(
            this,
            rguid,
            ppEnum
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EnumItemsInCategory(
        [NativeTypeName("const GUID &")] Guid* rcatid,
        IEnumGUID* ppEnum
    )
    {
        return ((delegate* unmanaged<ITfCategoryMgr, Guid*, IEnumGUID*, int>)((*lpVtbl)[6]))(
            this,
            rcatid,
            ppEnum
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FindClosestCategory(
        [NativeTypeName("const GUID &")] Guid* rguid,
        Guid* pcatid,
        [NativeTypeName("const GUID **")] Guid** ppcatidList,
        [NativeTypeName("ULONG")] uint ulCount
    )
    {
        return (
            (delegate* unmanaged<ITfCategoryMgr, Guid*, Guid*, Guid**, uint, int>)((*lpVtbl)[7])
        )(this, rguid, pcatid, ppcatidList, ulCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RegisterGUIDDescription(
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("const GUID &")] Guid* rguid,
        [NativeTypeName("const WCHAR *")] ushort* pchDesc,
        [NativeTypeName("ULONG")] uint cch
    )
    {
        return (
            (delegate* unmanaged<ITfCategoryMgr, Guid*, Guid*, ushort*, uint, int>)((*lpVtbl)[8])
        )(this, rclsid, rguid, pchDesc, cch);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT UnregisterGUIDDescription(
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("const GUID &")] Guid* rguid
    )
    {
        return ((delegate* unmanaged<ITfCategoryMgr, Guid*, Guid*, int>)((*lpVtbl)[9]))(
            this,
            rclsid,
            rguid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetGUIDDescription(
        [NativeTypeName("const GUID &")] Guid* rguid,
        [NativeTypeName("BSTR *")] ushort** pbstrDesc
    )
    {
        return ((delegate* unmanaged<ITfCategoryMgr, Guid*, ushort**, int>)((*lpVtbl)[10]))(
            this,
            rguid,
            pbstrDesc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RegisterGUIDDWORD(
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("const GUID &")] Guid* rguid,
        [NativeTypeName("DWORD")] uint dw
    )
    {
        return ((delegate* unmanaged<ITfCategoryMgr, Guid*, Guid*, uint, int>)((*lpVtbl)[11]))(
            this,
            rclsid,
            rguid,
            dw
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT UnregisterGUIDDWORD(
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("const GUID &")] Guid* rguid
    )
    {
        return ((delegate* unmanaged<ITfCategoryMgr, Guid*, Guid*, int>)((*lpVtbl)[12]))(
            this,
            rclsid,
            rguid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetGUIDDWORD(
        [NativeTypeName("const GUID &")] Guid* rguid,
        [NativeTypeName("DWORD *")] uint* pdw
    )
    {
        return ((delegate* unmanaged<ITfCategoryMgr, Guid*, uint*, int>)((*lpVtbl)[13]))(
            this,
            rguid,
            pdw
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT RegisterGUID(
        [NativeTypeName("const GUID &")] Guid* rguid,
        [NativeTypeName("TfGuidAtom *")] uint* pguidatom
    )
    {
        return ((delegate* unmanaged<ITfCategoryMgr, Guid*, uint*, int>)((*lpVtbl)[14]))(
            this,
            rguid,
            pguidatom
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetGUID([NativeTypeName("TfGuidAtom")] uint guidatom, Guid* pguid)
    {
        return ((delegate* unmanaged<ITfCategoryMgr, uint, Guid*, int>)((*lpVtbl)[15]))(
            this,
            guidatom,
            pguid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT IsEqualTfGuidAtom(
        [NativeTypeName("TfGuidAtom")] uint guidatom,
        [NativeTypeName("const GUID &")] Guid* rguid,
        BOOL* pfEqual
    )
    {
        return ((delegate* unmanaged<ITfCategoryMgr, uint, Guid*, BOOL*, int>)((*lpVtbl)[16]))(
            this,
            guidatom,
            rguid,
            pfEqual
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RegisterCategory(
            [NativeTypeName("const IID &")] Guid* rclsid,
            [NativeTypeName("const GUID &")] Guid* rcatid,
            [NativeTypeName("const GUID &")] Guid* rguid
        );

        [VtblIndex(4)]
        HRESULT UnregisterCategory(
            [NativeTypeName("const IID &")] Guid* rclsid,
            [NativeTypeName("const GUID &")] Guid* rcatid,
            [NativeTypeName("const GUID &")] Guid* rguid
        );

        [VtblIndex(5)]
        HRESULT EnumCategoriesInItem(
            [NativeTypeName("const GUID &")] Guid* rguid,
            IEnumGUID* ppEnum
        );

        [VtblIndex(6)]
        HRESULT EnumItemsInCategory(
            [NativeTypeName("const GUID &")] Guid* rcatid,
            IEnumGUID* ppEnum
        );

        [VtblIndex(7)]
        HRESULT FindClosestCategory(
            [NativeTypeName("const GUID &")] Guid* rguid,
            Guid* pcatid,
            [NativeTypeName("const GUID **")] Guid** ppcatidList,
            [NativeTypeName("ULONG")] uint ulCount
        );

        [VtblIndex(8)]
        HRESULT RegisterGUIDDescription(
            [NativeTypeName("const IID &")] Guid* rclsid,
            [NativeTypeName("const GUID &")] Guid* rguid,
            [NativeTypeName("const WCHAR *")] ushort* pchDesc,
            [NativeTypeName("ULONG")] uint cch
        );

        [VtblIndex(9)]
        HRESULT UnregisterGUIDDescription(
            [NativeTypeName("const IID &")] Guid* rclsid,
            [NativeTypeName("const GUID &")] Guid* rguid
        );

        [VtblIndex(10)]
        HRESULT GetGUIDDescription(
            [NativeTypeName("const GUID &")] Guid* rguid,
            [NativeTypeName("BSTR *")] ushort** pbstrDesc
        );

        [VtblIndex(11)]
        HRESULT RegisterGUIDDWORD(
            [NativeTypeName("const IID &")] Guid* rclsid,
            [NativeTypeName("const GUID &")] Guid* rguid,
            [NativeTypeName("DWORD")] uint dw
        );

        [VtblIndex(12)]
        HRESULT UnregisterGUIDDWORD(
            [NativeTypeName("const IID &")] Guid* rclsid,
            [NativeTypeName("const GUID &")] Guid* rguid
        );

        [VtblIndex(13)]
        HRESULT GetGUIDDWORD(
            [NativeTypeName("const GUID &")] Guid* rguid,
            [NativeTypeName("DWORD *")] uint* pdw
        );

        [VtblIndex(14)]
        HRESULT RegisterGUID(
            [NativeTypeName("const GUID &")] Guid* rguid,
            [NativeTypeName("TfGuidAtom *")] uint* pguidatom
        );

        [VtblIndex(15)]
        HRESULT GetGUID([NativeTypeName("TfGuidAtom")] uint guidatom, Guid* pguid);

        [VtblIndex(16)]
        HRESULT IsEqualTfGuidAtom(
            [NativeTypeName("TfGuidAtom")] uint guidatom,
            [NativeTypeName("const GUID &")] Guid* rguid,
            BOOL* pfEqual
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
            "HRESULT (const IID &, const GUID &, const GUID &) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, Guid*, int> RegisterCategory;

        [NativeTypeName(
            "HRESULT (const IID &, const GUID &, const GUID &) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, Guid*, int> UnregisterCategory;

        [NativeTypeName("HRESULT (const GUID &, IEnumGUID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IEnumGUID*, int> EnumCategoriesInItem;

        [NativeTypeName("HRESULT (const GUID &, IEnumGUID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IEnumGUID*, int> EnumItemsInCategory;

        [NativeTypeName(
            "HRESULT (const GUID &, GUID *, const GUID **, ULONG) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, Guid**, uint, int> FindClosestCategory;

        [NativeTypeName(
            "HRESULT (const IID &, const GUID &, const WCHAR *, ULONG) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            Guid*,
            ushort*,
            uint,
            int> RegisterGUIDDescription;

        [NativeTypeName("HRESULT (const IID &, const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, int> UnregisterGUIDDescription;

        [NativeTypeName("HRESULT (const GUID &, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, int> GetGUIDDescription;

        [NativeTypeName("HRESULT (const IID &, const GUID &, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, uint, int> RegisterGUIDDWORD;

        [NativeTypeName("HRESULT (const IID &, const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, int> UnregisterGUIDDWORD;

        [NativeTypeName("HRESULT (const GUID &, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, int> GetGUIDDWORD;

        [NativeTypeName("HRESULT (const GUID &, TfGuidAtom *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, int> RegisterGUID;

        [NativeTypeName("HRESULT (TfGuidAtom, GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, int> GetGUID;

        [NativeTypeName("HRESULT (TfGuidAtom, const GUID &, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, BOOL*, int> IsEqualTfGuidAtom;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfCategoryMgr"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfCategoryMgr(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfCategoryMgr"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfCategoryMgr(Silk.NET.Windows.IUnknown value)
    {
        return new ITfCategoryMgr(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfCategoryMgr"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfCategoryMgr"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfCategoryMgr value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
