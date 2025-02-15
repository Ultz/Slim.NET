// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("000214E9-0000-0000-C000-000000000046")]
[NativeTypeName("struct IShellPropSheetExt : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IShellPropSheetExt : IShellPropSheetExt.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellPropSheetExt));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellPropSheetExt, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IShellPropSheetExt, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellPropSheetExt, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddPages(
        [NativeTypeName("LPFNSVADDPROPSHEETPAGE")]
            delegate* unmanaged<HPROPSHEETPAGE, LPARAM, BOOL> pfnAddPage,
        LPARAM lParam
    )
    {
        return (
            (delegate* unmanaged<
                IShellPropSheetExt,
                delegate* unmanaged<HPROPSHEETPAGE, LPARAM, BOOL>,
                LPARAM,
                int>)((*lpVtbl)[3])
        )(this, pfnAddPage, lParam);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ReplacePage(
        [NativeTypeName("EXPPS")] uint uPageID,
        [NativeTypeName("LPFNSVADDPROPSHEETPAGE")]
            delegate* unmanaged<HPROPSHEETPAGE, LPARAM, BOOL> pfnReplaceWith,
        LPARAM lParam
    )
    {
        return (
            (delegate* unmanaged<
                IShellPropSheetExt,
                uint,
                delegate* unmanaged<HPROPSHEETPAGE, LPARAM, BOOL>,
                LPARAM,
                int>)((*lpVtbl)[4])
        )(this, uPageID, pfnReplaceWith, lParam);
    }

    public interface Interface : IUnknown.Interface { }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (LPFNSVADDPROPSHEETPAGE, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            delegate* unmanaged<HPROPSHEETPAGE, LPARAM, BOOL>,
            LPARAM,
            int> AddPages;

        [NativeTypeName("HRESULT (EXPPS, LPFNSVADDPROPSHEETPAGE, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            delegate* unmanaged<HPROPSHEETPAGE, LPARAM, BOOL>,
            LPARAM,
            int> ReplacePage;
    }

    /// <summary>Initializes a new instance of the <see cref = "IShellPropSheetExt"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IShellPropSheetExt(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IShellPropSheetExt"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IShellPropSheetExt(Silk.NET.Windows.IUnknown value)
    {
        return new IShellPropSheetExt(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellPropSheetExt"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IShellPropSheetExt"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IShellPropSheetExt value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
