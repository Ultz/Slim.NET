// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("56A868A0-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IOverlayNotify : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IOverlayNotify : IOverlayNotify.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOverlayNotify));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOverlayNotify, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IOverlayNotify, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOverlayNotify, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnPaletteChange(
        [NativeTypeName("DWORD")] uint dwColors,
        [NativeTypeName("const PALETTEENTRY *")] PALETTEENTRY* pPalette
    )
    {
        return ((delegate* unmanaged<IOverlayNotify, uint, PALETTEENTRY*, int>)((*lpVtbl)[3]))(
            this,
            dwColors,
            pPalette
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnClipChange(
        [NativeTypeName("const RECT *")] RECT* pSourceRect,
        [NativeTypeName("const RECT *")] RECT* pDestinationRect,
        [NativeTypeName("const RGNDATA *")] RGNDATA* pRgnData
    )
    {
        return ((delegate* unmanaged<IOverlayNotify, RECT*, RECT*, RGNDATA*, int>)((*lpVtbl)[4]))(
            this,
            pSourceRect,
            pDestinationRect,
            pRgnData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnColorKeyChange([NativeTypeName("const COLORKEY *")] COLORKEY* pColorKey)
    {
        return ((delegate* unmanaged<IOverlayNotify, COLORKEY*, int>)((*lpVtbl)[5]))(
            this,
            pColorKey
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnPositionChange(
        [NativeTypeName("const RECT *")] RECT* pSourceRect,
        [NativeTypeName("const RECT *")] RECT* pDestinationRect
    )
    {
        return ((delegate* unmanaged<IOverlayNotify, RECT*, RECT*, int>)((*lpVtbl)[6]))(
            this,
            pSourceRect,
            pDestinationRect
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnPaletteChange(
            [NativeTypeName("DWORD")] uint dwColors,
            [NativeTypeName("const PALETTEENTRY *")] PALETTEENTRY* pPalette
        );

        [VtblIndex(4)]
        HRESULT OnClipChange(
            [NativeTypeName("const RECT *")] RECT* pSourceRect,
            [NativeTypeName("const RECT *")] RECT* pDestinationRect,
            [NativeTypeName("const RGNDATA *")] RGNDATA* pRgnData
        );

        [VtblIndex(5)]
        HRESULT OnColorKeyChange([NativeTypeName("const COLORKEY *")] COLORKEY* pColorKey);

        [VtblIndex(6)]
        HRESULT OnPositionChange(
            [NativeTypeName("const RECT *")] RECT* pSourceRect,
            [NativeTypeName("const RECT *")] RECT* pDestinationRect
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

        [NativeTypeName("HRESULT (DWORD, const PALETTEENTRY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, PALETTEENTRY*, int> OnPaletteChange;

        [NativeTypeName(
            "HRESULT (const RECT *, const RECT *, const RGNDATA *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, RECT*, RECT*, RGNDATA*, int> OnClipChange;

        [NativeTypeName("HRESULT (const COLORKEY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, COLORKEY*, int> OnColorKeyChange;

        [NativeTypeName("HRESULT (const RECT *, const RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, RECT*, int> OnPositionChange;
    }

    /// <summary>Initializes a new instance of the <see cref = "IOverlayNotify"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IOverlayNotify(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IOverlayNotify"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IOverlayNotify(Silk.NET.Windows.IUnknown value)
    {
        return new IOverlayNotify(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOverlayNotify"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IOverlayNotify"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IOverlayNotify value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
