// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("EAA7C309-BBEC-49D5-821D-64D966CB667F")]
[NativeTypeName("struct FolderItems3 : FolderItems2")]
[NativeInheritance("FolderItems2")]
public unsafe partial struct FolderItems3 : FolderItems3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_FolderItems3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<FolderItems3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<FolderItems3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<FolderItems3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<FolderItems3, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<FolderItems3, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
            this,
            iTInfo,
            lcid,
            ppTInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPOLESTR *")] ushort** rgszNames,
        uint cNames,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("DISPID *")] int* rgDispId
    )
    {
        return (
            (delegate* unmanaged<FolderItems3, Guid*, ushort**, uint, uint, int*, int>)(
                (*lpVtbl)[5]
            )
        )(this, riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke(
        [NativeTypeName("DISPID")] int dispIdMember,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("WORD")] ushort wFlags,
        DISPPARAMS* pDispParams,
        VARIANT* pVarResult,
        EXCEPINFO* pExcepInfo,
        uint* puArgErr
    )
    {
        return (
            (delegate* unmanaged<
                FolderItems3,
                int,
                Guid*,
                uint,
                ushort,
                DISPPARAMS*,
                VARIANT*,
                EXCEPINFO*,
                uint*,
                int>)((*lpVtbl)[6])
        )(this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Count([NativeTypeName("long *")] int* plCount)
    {
        return ((delegate* unmanaged<FolderItems3, int*, int>)((*lpVtbl)[7]))(this, plCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Application(IDispatch* ppid)
    {
        return ((delegate* unmanaged<FolderItems3, IDispatch*, int>)((*lpVtbl)[8]))(this, ppid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Parent(IDispatch* ppid)
    {
        return ((delegate* unmanaged<FolderItems3, IDispatch*, int>)((*lpVtbl)[9]))(this, ppid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Item(VARIANT index, FolderItem* ppid)
    {
        return ((delegate* unmanaged<FolderItems3, VARIANT, FolderItem*, int>)((*lpVtbl)[10]))(
            this,
            index,
            ppid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT _NewEnum(IUnknown* ppunk)
    {
        return ((delegate* unmanaged<FolderItems3, IUnknown*, int>)((*lpVtbl)[11]))(this, ppunk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT InvokeVerbEx(VARIANT vVerb, VARIANT vArgs)
    {
        return ((delegate* unmanaged<FolderItems3, VARIANT, VARIANT, int>)((*lpVtbl)[12]))(
            this,
            vVerb,
            vArgs
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Filter(
        [NativeTypeName("long")] int grfFlags,
        [NativeTypeName("BSTR")] ushort* bstrFileSpec
    )
    {
        return ((delegate* unmanaged<FolderItems3, int, ushort*, int>)((*lpVtbl)[13]))(
            this,
            grfFlags,
            bstrFileSpec
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Verbs(FolderItemVerbs* ppfic)
    {
        return ((delegate* unmanaged<FolderItems3, FolderItemVerbs*, int>)((*lpVtbl)[14]))(
            this,
            ppfic
        );
    }

    public interface Interface : FolderItems2.Interface
    {
        [VtblIndex(13)]
        HRESULT Filter(
            [NativeTypeName("long")] int grfFlags,
            [NativeTypeName("BSTR")] ushort* bstrFileSpec
        );

        [VtblIndex(14)]
        HRESULT get_Verbs(FolderItemVerbs* ppfic);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo*, int> GetTypeInfo;

        [NativeTypeName(
            "HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName(
            "HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            Guid*,
            uint,
            ushort,
            DISPPARAMS*,
            VARIANT*,
            EXCEPINFO*,
            uint*,
            int> Invoke;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Count;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_Application;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_Parent;

        [NativeTypeName("HRESULT (VARIANT, FolderItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, FolderItem*, int> Item;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> _NewEnum;

        [NativeTypeName("HRESULT (VARIANT, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, VARIANT, int> InvokeVerbEx;

        [NativeTypeName("HRESULT (long, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ushort*, int> Filter;

        [NativeTypeName("HRESULT (FolderItemVerbs **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FolderItemVerbs*, int> get_Verbs;
    }

    /// <summary>Initializes a new instance of the <see cref = "FolderItems3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public FolderItems3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.FolderItems2"/> to <see cref = "FolderItems3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.FolderItems2"/> instance to be converted </param>
    public static explicit operator FolderItems3(Silk.NET.Windows.FolderItems2 value)
    {
        return new FolderItems3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "FolderItems3"/> to <see cref = "Silk.NET.Windows.FolderItems2"/>.</summary>
    /// <param name = "value">The <see cref = "FolderItems3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.FolderItems2(FolderItems3 value)
    {
        return new Silk.NET.Windows.FolderItems2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.FolderItems"/> to <see cref = "FolderItems3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.FolderItems"/> instance to be converted </param>
    public static explicit operator FolderItems3(Silk.NET.Windows.FolderItems value)
    {
        return new FolderItems3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "FolderItems3"/> to <see cref = "Silk.NET.Windows.FolderItems"/>.</summary>
    /// <param name = "value">The <see cref = "FolderItems3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.FolderItems(FolderItems3 value)
    {
        return new Silk.NET.Windows.FolderItems(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "FolderItems3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator FolderItems3(Silk.NET.Windows.IDispatch value)
    {
        return new FolderItems3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "FolderItems3"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "FolderItems3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(FolderItems3 value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "FolderItems3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator FolderItems3(Silk.NET.Windows.IUnknown value)
    {
        return new FolderItems3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "FolderItems3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "FolderItems3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(FolderItems3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
