// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("49FF1173-EADC-446D-9285-156453A6431C")]
[NativeTypeName("struct IActionProgress : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IActionProgress : IActionProgress.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IActionProgress));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IActionProgress, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IActionProgress, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IActionProgress, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Begin(SPACTION action, [NativeTypeName("SPBEGINF")] uint flags)
    {
        return ((delegate* unmanaged<IActionProgress, SPACTION, uint, int>)((*lpVtbl)[3]))(
            this,
            action,
            flags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UpdateProgress(
        [NativeTypeName("ULONGLONG")] ulong ulCompleted,
        [NativeTypeName("ULONGLONG")] ulong ulTotal
    )
    {
        return ((delegate* unmanaged<IActionProgress, ulong, ulong, int>)((*lpVtbl)[4]))(
            this,
            ulCompleted,
            ulTotal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT UpdateText(
        SPTEXT sptext,
        [NativeTypeName("LPCWSTR")] ushort* pszText,
        BOOL fMayCompact
    )
    {
        return ((delegate* unmanaged<IActionProgress, SPTEXT, ushort*, BOOL, int>)((*lpVtbl)[5]))(
            this,
            sptext,
            pszText,
            fMayCompact
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT QueryCancel(BOOL* pfCancelled)
    {
        return ((delegate* unmanaged<IActionProgress, BOOL*, int>)((*lpVtbl)[6]))(
            this,
            pfCancelled
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ResetCancel()
    {
        return ((delegate* unmanaged<IActionProgress, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT End()
    {
        return ((delegate* unmanaged<IActionProgress, int>)((*lpVtbl)[8]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Begin(SPACTION action, [NativeTypeName("SPBEGINF")] uint flags);

        [VtblIndex(4)]
        HRESULT UpdateProgress(
            [NativeTypeName("ULONGLONG")] ulong ulCompleted,
            [NativeTypeName("ULONGLONG")] ulong ulTotal
        );

        [VtblIndex(5)]
        HRESULT UpdateText(
            SPTEXT sptext,
            [NativeTypeName("LPCWSTR")] ushort* pszText,
            BOOL fMayCompact
        );

        [VtblIndex(6)]
        HRESULT QueryCancel(BOOL* pfCancelled);

        [VtblIndex(7)]
        HRESULT ResetCancel();

        [VtblIndex(8)]
        HRESULT End();
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

        [NativeTypeName("HRESULT (SPACTION, SPBEGINF) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPACTION, uint, int> Begin;

        [NativeTypeName("HRESULT (ULONGLONG, ULONGLONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, ulong, int> UpdateProgress;

        [NativeTypeName("HRESULT (SPTEXT, LPCWSTR, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPTEXT, ushort*, BOOL, int> UpdateText;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> QueryCancel;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ResetCancel;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> End;
    }

    /// <summary>Initializes a new instance of the <see cref = "IActionProgress"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IActionProgress(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IActionProgress"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IActionProgress(Silk.NET.Windows.IUnknown value)
    {
        return new IActionProgress(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IActionProgress"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IActionProgress"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IActionProgress value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
