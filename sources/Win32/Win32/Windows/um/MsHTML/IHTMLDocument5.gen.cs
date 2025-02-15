// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3050F80C-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLDocument5 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLDocument5 : IHTMLDocument5.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLDocument5));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLDocument5, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHTMLDocument5, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLDocument5, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLDocument5, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLDocument5, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
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
            (delegate* unmanaged<IHTMLDocument5, Guid*, ushort**, uint, uint, int*, int>)(
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
                IHTMLDocument5,
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
    public HRESULT put_onmousewheel(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument5, VARIANT, int>)((*lpVtbl)[7]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_onmousewheel(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument5, VARIANT*, int>)((*lpVtbl)[8]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_doctype(IHTMLDOMNode* p)
    {
        return ((delegate* unmanaged<IHTMLDocument5, IHTMLDOMNode*, int>)((*lpVtbl)[9]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_implementation(IHTMLDOMImplementation* p)
    {
        return ((delegate* unmanaged<IHTMLDocument5, IHTMLDOMImplementation*, int>)((*lpVtbl)[10]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT createAttribute(
        [NativeTypeName("BSTR")] ushort* bstrattrName,
        IHTMLDOMAttribute* ppattribute
    )
    {
        return (
            (delegate* unmanaged<IHTMLDocument5, ushort*, IHTMLDOMAttribute*, int>)((*lpVtbl)[11])
        )(this, bstrattrName, ppattribute);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT createComment([NativeTypeName("BSTR")] ushort* bstrdata, IHTMLDOMNode* ppRetNode)
    {
        return ((delegate* unmanaged<IHTMLDocument5, ushort*, IHTMLDOMNode*, int>)((*lpVtbl)[12]))(
            this,
            bstrdata,
            ppRetNode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_onfocusin(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument5, VARIANT, int>)((*lpVtbl)[13]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_onfocusin(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument5, VARIANT*, int>)((*lpVtbl)[14]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_onfocusout(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument5, VARIANT, int>)((*lpVtbl)[15]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_onfocusout(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument5, VARIANT*, int>)((*lpVtbl)[16]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_onactivate(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument5, VARIANT, int>)((*lpVtbl)[17]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_onactivate(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument5, VARIANT*, int>)((*lpVtbl)[18]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_ondeactivate(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument5, VARIANT, int>)((*lpVtbl)[19]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_ondeactivate(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument5, VARIANT*, int>)((*lpVtbl)[20]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_onbeforeactivate(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument5, VARIANT, int>)((*lpVtbl)[21]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_onbeforeactivate(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument5, VARIANT*, int>)((*lpVtbl)[22]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_onbeforedeactivate(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument5, VARIANT, int>)((*lpVtbl)[23]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_onbeforedeactivate(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument5, VARIANT*, int>)((*lpVtbl)[24]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_compatMode([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLDocument5, ushort**, int>)((*lpVtbl)[25]))(this, p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_onmousewheel(VARIANT v);

        [VtblIndex(8)]
        HRESULT get_onmousewheel(VARIANT* p);

        [VtblIndex(9)]
        HRESULT get_doctype(IHTMLDOMNode* p);

        [VtblIndex(10)]
        HRESULT get_implementation(IHTMLDOMImplementation* p);

        [VtblIndex(11)]
        HRESULT createAttribute(
            [NativeTypeName("BSTR")] ushort* bstrattrName,
            IHTMLDOMAttribute* ppattribute
        );

        [VtblIndex(12)]
        HRESULT createComment([NativeTypeName("BSTR")] ushort* bstrdata, IHTMLDOMNode* ppRetNode);

        [VtblIndex(13)]
        HRESULT put_onfocusin(VARIANT v);

        [VtblIndex(14)]
        HRESULT get_onfocusin(VARIANT* p);

        [VtblIndex(15)]
        HRESULT put_onfocusout(VARIANT v);

        [VtblIndex(16)]
        HRESULT get_onfocusout(VARIANT* p);

        [VtblIndex(17)]
        HRESULT put_onactivate(VARIANT v);

        [VtblIndex(18)]
        HRESULT get_onactivate(VARIANT* p);

        [VtblIndex(19)]
        HRESULT put_ondeactivate(VARIANT v);

        [VtblIndex(20)]
        HRESULT get_ondeactivate(VARIANT* p);

        [VtblIndex(21)]
        HRESULT put_onbeforeactivate(VARIANT v);

        [VtblIndex(22)]
        HRESULT get_onbeforeactivate(VARIANT* p);

        [VtblIndex(23)]
        HRESULT put_onbeforedeactivate(VARIANT v);

        [VtblIndex(24)]
        HRESULT get_onbeforedeactivate(VARIANT* p);

        [VtblIndex(25)]
        HRESULT get_compatMode([NativeTypeName("BSTR *")] ushort** p);
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

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmousewheel;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmousewheel;

        [NativeTypeName("HRESULT (IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMNode*, int> get_doctype;

        [NativeTypeName("HRESULT (IHTMLDOMImplementation **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDOMImplementation*, int> get_implementation;

        [NativeTypeName("HRESULT (BSTR, IHTMLDOMAttribute **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IHTMLDOMAttribute*, int> createAttribute;

        [NativeTypeName("HRESULT (BSTR, IHTMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IHTMLDOMNode*, int> createComment;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onfocusin;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onfocusin;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onfocusout;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onfocusout;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onactivate;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onactivate;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ondeactivate;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_ondeactivate;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onbeforeactivate;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onbeforeactivate;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onbeforedeactivate;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onbeforedeactivate;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_compatMode;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHTMLDocument5"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHTMLDocument5(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IHTMLDocument5"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IHTMLDocument5(Silk.NET.Windows.IDispatch value)
    {
        return new IHTMLDocument5(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLDocument5"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLDocument5"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IHTMLDocument5 value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHTMLDocument5"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHTMLDocument5(Silk.NET.Windows.IUnknown value)
    {
        return new IHTMLDocument5(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLDocument5"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLDocument5"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHTMLDocument5 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
