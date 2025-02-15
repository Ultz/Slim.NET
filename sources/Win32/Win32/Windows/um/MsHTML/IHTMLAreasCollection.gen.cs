// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3050F383-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLAreasCollection : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLAreasCollection : IHTMLAreasCollection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLAreasCollection));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLAreasCollection, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHTMLAreasCollection, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLAreasCollection, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLAreasCollection, uint*, int>)((*lpVtbl)[3]))(
            this,
            pctinfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<IHTMLAreasCollection, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4])
        )(this, iTInfo, lcid, ppTInfo);
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
            (delegate* unmanaged<IHTMLAreasCollection, Guid*, ushort**, uint, uint, int*, int>)(
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
                IHTMLAreasCollection,
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
    public HRESULT put_length([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLAreasCollection, int, int>)((*lpVtbl)[7]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_length([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLAreasCollection, int*, int>)((*lpVtbl)[8]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get__newEnum(IUnknown* p)
    {
        return ((delegate* unmanaged<IHTMLAreasCollection, IUnknown*, int>)((*lpVtbl)[9]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT item(VARIANT name, VARIANT index, IDispatch* pdisp)
    {
        return (
            (delegate* unmanaged<IHTMLAreasCollection, VARIANT, VARIANT, IDispatch*, int>)(
                (*lpVtbl)[10]
            )
        )(this, name, index, pdisp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT tags(VARIANT tagName, IDispatch* pdisp)
    {
        return (
            (delegate* unmanaged<IHTMLAreasCollection, VARIANT, IDispatch*, int>)((*lpVtbl)[11])
        )(this, tagName, pdisp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add(IHTMLElement element, VARIANT before)
    {
        return (
            (delegate* unmanaged<IHTMLAreasCollection, IHTMLElement, VARIANT, int>)((*lpVtbl)[12])
        )(this, element, before);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove([NativeTypeName("long")] int index = -1)
    {
        return ((delegate* unmanaged<IHTMLAreasCollection, int, int>)((*lpVtbl)[13]))(this, index);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_length([NativeTypeName("long")] int v);

        [VtblIndex(8)]
        HRESULT get_length([NativeTypeName("long *")] int* p);

        [VtblIndex(9)]
        HRESULT get__newEnum(IUnknown* p);

        [VtblIndex(10)]
        HRESULT item(VARIANT name, VARIANT index, IDispatch* pdisp);

        [VtblIndex(11)]
        HRESULT tags(VARIANT tagName, IDispatch* pdisp);

        [VtblIndex(12)]
        HRESULT add(IHTMLElement element, VARIANT before);

        [VtblIndex(13)]
        HRESULT remove([NativeTypeName("long")] int index = -1);
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

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_length;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_length;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> get__newEnum;

        [NativeTypeName("HRESULT (VARIANT, VARIANT, IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, VARIANT, IDispatch*, int> item;

        [NativeTypeName("HRESULT (VARIANT, IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, IDispatch*, int> tags;

        [NativeTypeName("HRESULT (IHTMLElement *, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement, VARIANT, int> add;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> remove;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHTMLAreasCollection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHTMLAreasCollection(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IHTMLAreasCollection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IHTMLAreasCollection(Silk.NET.Windows.IDispatch value)
    {
        return new IHTMLAreasCollection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLAreasCollection"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLAreasCollection"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IHTMLAreasCollection value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHTMLAreasCollection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHTMLAreasCollection(Silk.NET.Windows.IUnknown value)
    {
        return new IHTMLAreasCollection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLAreasCollection"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLAreasCollection"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHTMLAreasCollection value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
