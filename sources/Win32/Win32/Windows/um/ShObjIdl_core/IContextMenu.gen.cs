// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("000214E4-0000-0000-C000-000000000046")]
[NativeTypeName("struct IContextMenu : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IContextMenu : IContextMenu.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContextMenu));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IContextMenu, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IContextMenu, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContextMenu, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueryContextMenu(
        HMENU hmenu,
        uint indexMenu,
        uint idCmdFirst,
        uint idCmdLast,
        uint uFlags
    )
    {
        return (
            (delegate* unmanaged<IContextMenu, HMENU, uint, uint, uint, uint, int>)((*lpVtbl)[3])
        )(this, hmenu, indexMenu, idCmdFirst, idCmdLast, uFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT InvokeCommand(CMINVOKECOMMANDINFO* pici)
    {
        return ((delegate* unmanaged<IContextMenu, CMINVOKECOMMANDINFO*, int>)((*lpVtbl)[4]))(
            this,
            pici
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCommandString(
        [NativeTypeName("UINT_PTR")] nuint idCmd,
        uint uType,
        uint* pReserved,
        [NativeTypeName("CHAR *")] sbyte* pszName,
        uint cchMax
    )
    {
        return (
            (delegate* unmanaged<IContextMenu, nuint, uint, uint*, sbyte*, uint, int>)((*lpVtbl)[5])
        )(this, idCmd, uType, pReserved, pszName, cchMax);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT QueryContextMenu(
            HMENU hmenu,
            uint indexMenu,
            uint idCmdFirst,
            uint idCmdLast,
            uint uFlags
        );

        [VtblIndex(4)]
        HRESULT InvokeCommand(CMINVOKECOMMANDINFO* pici);

        [VtblIndex(5)]
        HRESULT GetCommandString(
            [NativeTypeName("UINT_PTR")] nuint idCmd,
            uint uType,
            uint* pReserved,
            [NativeTypeName("CHAR *")] sbyte* pszName,
            uint cchMax
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

        [NativeTypeName("HRESULT (HMENU, UINT, UINT, UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HMENU, uint, uint, uint, uint, int> QueryContextMenu;

        [NativeTypeName("HRESULT (CMINVOKECOMMANDINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, CMINVOKECOMMANDINFO*, int> InvokeCommand;

        [NativeTypeName("HRESULT (UINT_PTR, UINT, UINT *, CHAR *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint, uint, uint*, sbyte*, uint, int> GetCommandString;
    }

    /// <summary>Initializes a new instance of the <see cref = "IContextMenu"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IContextMenu(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IContextMenu"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IContextMenu(Silk.NET.Windows.IUnknown value)
    {
        return new IContextMenu(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContextMenu"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IContextMenu"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IContextMenu value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
