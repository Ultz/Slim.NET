// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C8AD25A1-3294-41EE-8165-71174BD01C57")]
[NativeTypeName("struct ICommDlgBrowser3 : ICommDlgBrowser2")]
[NativeInheritance("ICommDlgBrowser2")]
public unsafe partial struct ICommDlgBrowser3 : ICommDlgBrowser3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICommDlgBrowser3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICommDlgBrowser3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICommDlgBrowser3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICommDlgBrowser3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnDefaultCommand(IShellView ppshv)
    {
        return ((delegate* unmanaged<ICommDlgBrowser3, IShellView, int>)((*lpVtbl)[3]))(
            this,
            ppshv
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnStateChange(IShellView ppshv, [NativeTypeName("ULONG")] uint uChange)
    {
        return ((delegate* unmanaged<ICommDlgBrowser3, IShellView, uint, int>)((*lpVtbl)[4]))(
            this,
            ppshv,
            uChange
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT IncludeObject(
        IShellView ppshv,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl
    )
    {
        return (
            (delegate* unmanaged<ICommDlgBrowser3, IShellView, ITEMIDLIST*, int>)((*lpVtbl)[5])
        )(this, ppshv, pidl);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Notify(IShellView ppshv, [NativeTypeName("DWORD")] uint dwNotifyType)
    {
        return ((delegate* unmanaged<ICommDlgBrowser3, IShellView, uint, int>)((*lpVtbl)[6]))(
            this,
            ppshv,
            dwNotifyType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDefaultMenuText(
        IShellView ppshv,
        [NativeTypeName("LPWSTR")] ushort* pszText,
        int cchMax
    )
    {
        return (
            (delegate* unmanaged<ICommDlgBrowser3, IShellView, ushort*, int, int>)((*lpVtbl)[7])
        )(this, ppshv, pszText, cchMax);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetViewFlags([NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<ICommDlgBrowser3, uint*, int>)((*lpVtbl)[8]))(this, pdwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT OnColumnClicked(IShellView ppshv, int iColumn)
    {
        return ((delegate* unmanaged<ICommDlgBrowser3, IShellView, int, int>)((*lpVtbl)[9]))(
            this,
            ppshv,
            iColumn
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetCurrentFilter([NativeTypeName("LPWSTR")] ushort* pszFileSpec, int cchFileSpec)
    {
        return ((delegate* unmanaged<ICommDlgBrowser3, ushort*, int, int>)((*lpVtbl)[10]))(
            this,
            pszFileSpec,
            cchFileSpec
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT OnPreViewCreated(IShellView ppshv)
    {
        return ((delegate* unmanaged<ICommDlgBrowser3, IShellView, int>)((*lpVtbl)[11]))(
            this,
            ppshv
        );
    }

    public interface Interface : ICommDlgBrowser2.Interface
    {
        [VtblIndex(9)]
        HRESULT OnColumnClicked(IShellView ppshv, int iColumn);

        [VtblIndex(10)]
        HRESULT GetCurrentFilter([NativeTypeName("LPWSTR")] ushort* pszFileSpec, int cchFileSpec);

        [VtblIndex(11)]
        HRESULT OnPreViewCreated(IShellView ppshv);
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

        [NativeTypeName("HRESULT (IShellView *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellView, int> OnDefaultCommand;

        [NativeTypeName("HRESULT (IShellView *, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellView, uint, int> OnStateChange;

        [NativeTypeName("HRESULT (IShellView *, LPCITEMIDLIST) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellView, ITEMIDLIST*, int> IncludeObject;

        [NativeTypeName("HRESULT (IShellView *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellView, uint, int> Notify;

        [NativeTypeName("HRESULT (IShellView *, LPWSTR, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellView, ushort*, int, int> GetDefaultMenuText;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetViewFlags;

        [NativeTypeName("HRESULT (IShellView *, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellView, int, int> OnColumnClicked;

        [NativeTypeName("HRESULT (LPWSTR, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, int> GetCurrentFilter;

        [NativeTypeName("HRESULT (IShellView *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellView, int> OnPreViewCreated;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICommDlgBrowser3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICommDlgBrowser3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ICommDlgBrowser2"/> to <see cref = "ICommDlgBrowser3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ICommDlgBrowser2"/> instance to be converted </param>
    public static explicit operator ICommDlgBrowser3(Silk.NET.Windows.ICommDlgBrowser2 value)
    {
        return new ICommDlgBrowser3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICommDlgBrowser3"/> to <see cref = "Silk.NET.Windows.ICommDlgBrowser2"/>.</summary>
    /// <param name = "value">The <see cref = "ICommDlgBrowser3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ICommDlgBrowser2(ICommDlgBrowser3 value)
    {
        return new Silk.NET.Windows.ICommDlgBrowser2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ICommDlgBrowser"/> to <see cref = "ICommDlgBrowser3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ICommDlgBrowser"/> instance to be converted </param>
    public static explicit operator ICommDlgBrowser3(Silk.NET.Windows.ICommDlgBrowser value)
    {
        return new ICommDlgBrowser3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICommDlgBrowser3"/> to <see cref = "Silk.NET.Windows.ICommDlgBrowser"/>.</summary>
    /// <param name = "value">The <see cref = "ICommDlgBrowser3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ICommDlgBrowser(ICommDlgBrowser3 value)
    {
        return new Silk.NET.Windows.ICommDlgBrowser(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICommDlgBrowser3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICommDlgBrowser3(Silk.NET.Windows.IUnknown value)
    {
        return new ICommDlgBrowser3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICommDlgBrowser3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICommDlgBrowser3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICommDlgBrowser3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
