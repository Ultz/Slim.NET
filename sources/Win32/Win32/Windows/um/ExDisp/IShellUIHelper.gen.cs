// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("729FE2F8-1EA8-11D1-8F85-00C04FC2FBE1")]
[NativeTypeName("struct IShellUIHelper : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IShellUIHelper : IShellUIHelper.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellUIHelper));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellUIHelper, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IShellUIHelper, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellUIHelper, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IShellUIHelper, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<IShellUIHelper, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
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
            (delegate* unmanaged<IShellUIHelper, Guid*, ushort**, uint, uint, int*, int>)(
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
                IShellUIHelper,
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
    public HRESULT ResetFirstBootMode()
    {
        return ((delegate* unmanaged<IShellUIHelper, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ResetSafeMode()
    {
        return ((delegate* unmanaged<IShellUIHelper, int>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RefreshOfflineDesktop()
    {
        return ((delegate* unmanaged<IShellUIHelper, int>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT AddFavorite([NativeTypeName("BSTR")] ushort* URL, VARIANT* Title)
    {
        return ((delegate* unmanaged<IShellUIHelper, ushort*, VARIANT*, int>)((*lpVtbl)[10]))(
            this,
            URL,
            Title
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT AddChannel([NativeTypeName("BSTR")] ushort* URL)
    {
        return ((delegate* unmanaged<IShellUIHelper, ushort*, int>)((*lpVtbl)[11]))(this, URL);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT AddDesktopComponent(
        [NativeTypeName("BSTR")] ushort* URL,
        [NativeTypeName("BSTR")] ushort* Type,
        VARIANT* Left,
        VARIANT* Top,
        VARIANT* Width,
        VARIANT* Height
    )
    {
        return (
            (delegate* unmanaged<
                IShellUIHelper,
                ushort*,
                ushort*,
                VARIANT*,
                VARIANT*,
                VARIANT*,
                VARIANT*,
                int>)((*lpVtbl)[12])
        )(this, URL, Type, Left, Top, Width, Height);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT IsSubscribed(
        [NativeTypeName("BSTR")] ushort* URL,
        [NativeTypeName("VARIANT_BOOL *")] short* pBool
    )
    {
        return ((delegate* unmanaged<IShellUIHelper, ushort*, short*, int>)((*lpVtbl)[13]))(
            this,
            URL,
            pBool
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT NavigateAndFind(
        [NativeTypeName("BSTR")] ushort* URL,
        [NativeTypeName("BSTR")] ushort* strQuery,
        VARIANT* varTargetFrame
    )
    {
        return (
            (delegate* unmanaged<IShellUIHelper, ushort*, ushort*, VARIANT*, int>)((*lpVtbl)[14])
        )(this, URL, strQuery, varTargetFrame);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ImportExportFavorites(
        [NativeTypeName("VARIANT_BOOL")] short fImport,
        [NativeTypeName("BSTR")] ushort* strImpExpPath
    )
    {
        return ((delegate* unmanaged<IShellUIHelper, short, ushort*, int>)((*lpVtbl)[15]))(
            this,
            fImport,
            strImpExpPath
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT AutoCompleteSaveForm(VARIANT* Form)
    {
        return ((delegate* unmanaged<IShellUIHelper, VARIANT*, int>)((*lpVtbl)[16]))(this, Form);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT AutoScan(
        [NativeTypeName("BSTR")] ushort* strSearch,
        [NativeTypeName("BSTR")] ushort* strFailureUrl,
        VARIANT* pvarTargetFrame
    )
    {
        return (
            (delegate* unmanaged<IShellUIHelper, ushort*, ushort*, VARIANT*, int>)((*lpVtbl)[17])
        )(this, strSearch, strFailureUrl, pvarTargetFrame);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT AutoCompleteAttach(VARIANT* Reserved)
    {
        return ((delegate* unmanaged<IShellUIHelper, VARIANT*, int>)((*lpVtbl)[18]))(
            this,
            Reserved
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT ShowBrowserUI(
        [NativeTypeName("BSTR")] ushort* bstrName,
        VARIANT* pvarIn,
        VARIANT* pvarOut
    )
    {
        return (
            (delegate* unmanaged<IShellUIHelper, ushort*, VARIANT*, VARIANT*, int>)((*lpVtbl)[19])
        )(this, bstrName, pvarIn, pvarOut);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT ResetFirstBootMode();

        [VtblIndex(8)]
        HRESULT ResetSafeMode();

        [VtblIndex(9)]
        HRESULT RefreshOfflineDesktop();

        [VtblIndex(10)]
        HRESULT AddFavorite([NativeTypeName("BSTR")] ushort* URL, VARIANT* Title);

        [VtblIndex(11)]
        HRESULT AddChannel([NativeTypeName("BSTR")] ushort* URL);

        [VtblIndex(12)]
        HRESULT AddDesktopComponent(
            [NativeTypeName("BSTR")] ushort* URL,
            [NativeTypeName("BSTR")] ushort* Type,
            VARIANT* Left,
            VARIANT* Top,
            VARIANT* Width,
            VARIANT* Height
        );

        [VtblIndex(13)]
        HRESULT IsSubscribed(
            [NativeTypeName("BSTR")] ushort* URL,
            [NativeTypeName("VARIANT_BOOL *")] short* pBool
        );

        [VtblIndex(14)]
        HRESULT NavigateAndFind(
            [NativeTypeName("BSTR")] ushort* URL,
            [NativeTypeName("BSTR")] ushort* strQuery,
            VARIANT* varTargetFrame
        );

        [VtblIndex(15)]
        HRESULT ImportExportFavorites(
            [NativeTypeName("VARIANT_BOOL")] short fImport,
            [NativeTypeName("BSTR")] ushort* strImpExpPath
        );

        [VtblIndex(16)]
        HRESULT AutoCompleteSaveForm(VARIANT* Form);

        [VtblIndex(17)]
        HRESULT AutoScan(
            [NativeTypeName("BSTR")] ushort* strSearch,
            [NativeTypeName("BSTR")] ushort* strFailureUrl,
            VARIANT* pvarTargetFrame
        );

        [VtblIndex(18)]
        HRESULT AutoCompleteAttach(VARIANT* Reserved);

        [VtblIndex(19)]
        HRESULT ShowBrowserUI(
            [NativeTypeName("BSTR")] ushort* bstrName,
            VARIANT* pvarIn,
            VARIANT* pvarOut
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ResetFirstBootMode;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ResetSafeMode;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RefreshOfflineDesktop;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> AddFavorite;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> AddChannel;

        [NativeTypeName(
            "HRESULT (BSTR, BSTR, VARIANT *, VARIANT *, VARIANT *, VARIANT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            VARIANT*,
            VARIANT*,
            VARIANT*,
            VARIANT*,
            int> AddDesktopComponent;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> IsSubscribed;

        [NativeTypeName("HRESULT (BSTR, BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, VARIANT*, int> NavigateAndFind;

        [NativeTypeName("HRESULT (VARIANT_BOOL, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, ushort*, int> ImportExportFavorites;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> AutoCompleteSaveForm;

        [NativeTypeName("HRESULT (BSTR, BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, VARIANT*, int> AutoScan;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> AutoCompleteAttach;

        [NativeTypeName("HRESULT (BSTR, VARIANT *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, VARIANT*, int> ShowBrowserUI;
    }

    /// <summary>Initializes a new instance of the <see cref = "IShellUIHelper"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IShellUIHelper(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IShellUIHelper"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IShellUIHelper(Silk.NET.Windows.IDispatch value)
    {
        return new IShellUIHelper(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellUIHelper"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IShellUIHelper"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IShellUIHelper value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IShellUIHelper"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IShellUIHelper(Silk.NET.Windows.IUnknown value)
    {
        return new IShellUIHelper(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellUIHelper"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IShellUIHelper"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IShellUIHelper value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
