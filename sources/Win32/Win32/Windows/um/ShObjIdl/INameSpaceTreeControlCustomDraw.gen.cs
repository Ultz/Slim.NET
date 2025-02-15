// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("2D3BA758-33EE-42D5-BB7B-5F3431D86C78")]
[NativeTypeName("struct INameSpaceTreeControlCustomDraw : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct INameSpaceTreeControlCustomDraw
    : INameSpaceTreeControlCustomDraw.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INameSpaceTreeControlCustomDraw));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<INameSpaceTreeControlCustomDraw, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<INameSpaceTreeControlCustomDraw, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<INameSpaceTreeControlCustomDraw, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT PrePaint(HDC hdc, RECT* prc, LRESULT* plres)
    {
        return (
            (delegate* unmanaged<INameSpaceTreeControlCustomDraw, HDC, RECT*, LRESULT*, int>)(
                (*lpVtbl)[3]
            )
        )(this, hdc, prc, plres);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT PostPaint(HDC hdc, RECT* prc)
    {
        return (
            (delegate* unmanaged<INameSpaceTreeControlCustomDraw, HDC, RECT*, int>)((*lpVtbl)[4])
        )(this, hdc, prc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ItemPrePaint(
        HDC hdc,
        RECT* prc,
        NSTCCUSTOMDRAW* pnstccdItem,
        COLORREF* pclrText,
        COLORREF* pclrTextBk,
        LRESULT* plres
    )
    {
        return (
            (delegate* unmanaged<
                INameSpaceTreeControlCustomDraw,
                HDC,
                RECT*,
                NSTCCUSTOMDRAW*,
                COLORREF*,
                COLORREF*,
                LRESULT*,
                int>)((*lpVtbl)[5])
        )(this, hdc, prc, pnstccdItem, pclrText, pclrTextBk, plres);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ItemPostPaint(HDC hdc, RECT* prc, NSTCCUSTOMDRAW* pnstccdItem)
    {
        return (
            (delegate* unmanaged<
                INameSpaceTreeControlCustomDraw,
                HDC,
                RECT*,
                NSTCCUSTOMDRAW*,
                int>)((*lpVtbl)[6])
        )(this, hdc, prc, pnstccdItem);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT PrePaint(HDC hdc, RECT* prc, LRESULT* plres);

        [VtblIndex(4)]
        HRESULT PostPaint(HDC hdc, RECT* prc);

        [VtblIndex(5)]
        HRESULT ItemPrePaint(
            HDC hdc,
            RECT* prc,
            NSTCCUSTOMDRAW* pnstccdItem,
            COLORREF* pclrText,
            COLORREF* pclrTextBk,
            LRESULT* plres
        );

        [VtblIndex(6)]
        HRESULT ItemPostPaint(HDC hdc, RECT* prc, NSTCCUSTOMDRAW* pnstccdItem);
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

        [NativeTypeName("HRESULT (HDC, RECT *, LRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HDC, RECT*, LRESULT*, int> PrePaint;

        [NativeTypeName("HRESULT (HDC, RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HDC, RECT*, int> PostPaint;

        [NativeTypeName(
            "HRESULT (HDC, RECT *, NSTCCUSTOMDRAW *, COLORREF *, COLORREF *, LRESULT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HDC,
            RECT*,
            NSTCCUSTOMDRAW*,
            COLORREF*,
            COLORREF*,
            LRESULT*,
            int> ItemPrePaint;

        [NativeTypeName("HRESULT (HDC, RECT *, NSTCCUSTOMDRAW *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HDC, RECT*, NSTCCUSTOMDRAW*, int> ItemPostPaint;
    }

    /// <summary>Initializes a new instance of the <see cref = "INameSpaceTreeControlCustomDraw"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public INameSpaceTreeControlCustomDraw(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "INameSpaceTreeControlCustomDraw"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator INameSpaceTreeControlCustomDraw(Silk.NET.Windows.IUnknown value)
    {
        return new INameSpaceTreeControlCustomDraw(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "INameSpaceTreeControlCustomDraw"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "INameSpaceTreeControlCustomDraw"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(INameSpaceTreeControlCustomDraw value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
