// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("F9C665D6-C2F2-4C19-BF33-8322D7352F51")]
[NativeTypeName("struct INameSpaceTreeControlDropHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct INameSpaceTreeControlDropHandler
    : INameSpaceTreeControlDropHandler.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INameSpaceTreeControlDropHandler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<INameSpaceTreeControlDropHandler, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<INameSpaceTreeControlDropHandler, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<INameSpaceTreeControlDropHandler, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnDragEnter(
        IShellItem psiOver,
        IShellItemArray psiaData,
        BOOL fOutsideSource,
        [NativeTypeName("DWORD")] uint grfKeyState,
        [NativeTypeName("DWORD *")] uint* pdwEffect
    )
    {
        return (
            (delegate* unmanaged<
                INameSpaceTreeControlDropHandler,
                IShellItem,
                IShellItemArray,
                BOOL,
                uint,
                uint*,
                int>)((*lpVtbl)[3])
        )(this, psiOver, psiaData, fOutsideSource, grfKeyState, pdwEffect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnDragOver(
        IShellItem psiOver,
        IShellItemArray psiaData,
        [NativeTypeName("DWORD")] uint grfKeyState,
        [NativeTypeName("DWORD *")] uint* pdwEffect
    )
    {
        return (
            (delegate* unmanaged<
                INameSpaceTreeControlDropHandler,
                IShellItem,
                IShellItemArray,
                uint,
                uint*,
                int>)((*lpVtbl)[4])
        )(this, psiOver, psiaData, grfKeyState, pdwEffect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnDragPosition(
        IShellItem psiOver,
        IShellItemArray psiaData,
        int iNewPosition,
        int iOldPosition
    )
    {
        return (
            (delegate* unmanaged<
                INameSpaceTreeControlDropHandler,
                IShellItem,
                IShellItemArray,
                int,
                int,
                int>)((*lpVtbl)[5])
        )(this, psiOver, psiaData, iNewPosition, iOldPosition);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnDrop(
        IShellItem psiOver,
        IShellItemArray psiaData,
        int iPosition,
        [NativeTypeName("DWORD")] uint grfKeyState,
        [NativeTypeName("DWORD *")] uint* pdwEffect
    )
    {
        return (
            (delegate* unmanaged<
                INameSpaceTreeControlDropHandler,
                IShellItem,
                IShellItemArray,
                int,
                uint,
                uint*,
                int>)((*lpVtbl)[6])
        )(this, psiOver, psiaData, iPosition, grfKeyState, pdwEffect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnDropPosition(
        IShellItem psiOver,
        IShellItemArray psiaData,
        int iNewPosition,
        int iOldPosition
    )
    {
        return (
            (delegate* unmanaged<
                INameSpaceTreeControlDropHandler,
                IShellItem,
                IShellItemArray,
                int,
                int,
                int>)((*lpVtbl)[7])
        )(this, psiOver, psiaData, iNewPosition, iOldPosition);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT OnDragLeave(IShellItem psiOver)
    {
        return (
            (delegate* unmanaged<INameSpaceTreeControlDropHandler, IShellItem, int>)((*lpVtbl)[8])
        )(this, psiOver);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnDragEnter(
            IShellItem psiOver,
            IShellItemArray psiaData,
            BOOL fOutsideSource,
            [NativeTypeName("DWORD")] uint grfKeyState,
            [NativeTypeName("DWORD *")] uint* pdwEffect
        );

        [VtblIndex(4)]
        HRESULT OnDragOver(
            IShellItem psiOver,
            IShellItemArray psiaData,
            [NativeTypeName("DWORD")] uint grfKeyState,
            [NativeTypeName("DWORD *")] uint* pdwEffect
        );

        [VtblIndex(5)]
        HRESULT OnDragPosition(
            IShellItem psiOver,
            IShellItemArray psiaData,
            int iNewPosition,
            int iOldPosition
        );

        [VtblIndex(6)]
        HRESULT OnDrop(
            IShellItem psiOver,
            IShellItemArray psiaData,
            int iPosition,
            [NativeTypeName("DWORD")] uint grfKeyState,
            [NativeTypeName("DWORD *")] uint* pdwEffect
        );

        [VtblIndex(7)]
        HRESULT OnDropPosition(
            IShellItem psiOver,
            IShellItemArray psiaData,
            int iNewPosition,
            int iOldPosition
        );

        [VtblIndex(8)]
        HRESULT OnDragLeave(IShellItem psiOver);
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
            "HRESULT (IShellItem *, IShellItemArray *, BOOL, DWORD, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IShellItem,
            IShellItemArray,
            BOOL,
            uint,
            uint*,
            int> OnDragEnter;

        [NativeTypeName(
            "HRESULT (IShellItem *, IShellItemArray *, DWORD, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IShellItem,
            IShellItemArray,
            uint,
            uint*,
            int> OnDragOver;

        [NativeTypeName(
            "HRESULT (IShellItem *, IShellItemArray *, int, int) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IShellItem,
            IShellItemArray,
            int,
            int,
            int> OnDragPosition;

        [NativeTypeName(
            "HRESULT (IShellItem *, IShellItemArray *, int, DWORD, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IShellItem,
            IShellItemArray,
            int,
            uint,
            uint*,
            int> OnDrop;

        [NativeTypeName(
            "HRESULT (IShellItem *, IShellItemArray *, int, int) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IShellItem,
            IShellItemArray,
            int,
            int,
            int> OnDropPosition;

        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, int> OnDragLeave;
    }

    /// <summary>Initializes a new instance of the <see cref = "INameSpaceTreeControlDropHandler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public INameSpaceTreeControlDropHandler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "INameSpaceTreeControlDropHandler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator INameSpaceTreeControlDropHandler(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new INameSpaceTreeControlDropHandler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "INameSpaceTreeControlDropHandler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "INameSpaceTreeControlDropHandler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        INameSpaceTreeControlDropHandler value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
