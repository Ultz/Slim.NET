// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("DA20D8EF-812A-4C43-9802-62EC4ABD7ADF")]
[NativeTypeName("struct IDWriteFontFamily1 : IDWriteFontFamily")]
[NativeInheritance("IDWriteFontFamily")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IDWriteFontFamily1 : IDWriteFontFamily1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFamily1));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFontFamily1, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDWriteFontFamily1, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFontFamily1, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFontCollection(IDWriteFontCollection* fontCollection)
    {
        return (
            (delegate* unmanaged<IDWriteFontFamily1, IDWriteFontCollection*, int>)((*lpVtbl)[3])
        )(this, fontCollection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontCount()
    {
        return ((delegate* unmanaged<IDWriteFontFamily1, uint>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetFont([NativeTypeName("UINT32")] uint index, IDWriteFont* font)
    {
        return ((delegate* unmanaged<IDWriteFontFamily1, uint, IDWriteFont*, int>)((*lpVtbl)[5]))(
            this,
            index,
            font
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFamilyNames(IDWriteLocalizedStrings* names)
    {
        return (
            (delegate* unmanaged<IDWriteFontFamily1, IDWriteLocalizedStrings*, int>)((*lpVtbl)[6])
        )(this, names);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFirstMatchingFont(
        DWRITE_FONT_WEIGHT weight,
        DWRITE_FONT_STRETCH stretch,
        DWRITE_FONT_STYLE style,
        IDWriteFont* matchingFont
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontFamily1,
                DWRITE_FONT_WEIGHT,
                DWRITE_FONT_STRETCH,
                DWRITE_FONT_STYLE,
                IDWriteFont*,
                int>)((*lpVtbl)[7])
        )(this, weight, stretch, style, matchingFont);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetMatchingFonts(
        DWRITE_FONT_WEIGHT weight,
        DWRITE_FONT_STRETCH stretch,
        DWRITE_FONT_STYLE style,
        IDWriteFontList* matchingFonts
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontFamily1,
                DWRITE_FONT_WEIGHT,
                DWRITE_FONT_STRETCH,
                DWRITE_FONT_STYLE,
                IDWriteFontList*,
                int>)((*lpVtbl)[8])
        )(this, weight, stretch, style, matchingFonts);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public DWRITE_LOCALITY GetFontLocality([NativeTypeName("UINT32")] uint listIndex)
    {
        return ((delegate* unmanaged<IDWriteFontFamily1, uint, DWRITE_LOCALITY>)((*lpVtbl)[9]))(
            this,
            listIndex
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetFont([NativeTypeName("UINT32")] uint listIndex, IDWriteFont3* font)
    {
        return ((delegate* unmanaged<IDWriteFontFamily1, uint, IDWriteFont3*, int>)((*lpVtbl)[10]))(
            this,
            listIndex,
            font
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetFontFaceReference(
        [NativeTypeName("UINT32")] uint listIndex,
        IDWriteFontFaceReference* fontFaceReference
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontFamily1, uint, IDWriteFontFaceReference*, int>)(
                (*lpVtbl)[11]
            )
        )(this, listIndex, fontFaceReference);
    }

    public interface Interface : IDWriteFontFamily.Interface
    {
        [VtblIndex(9)]
        DWRITE_LOCALITY GetFontLocality([NativeTypeName("UINT32")] uint listIndex);

        [VtblIndex(10)]
        HRESULT GetFont([NativeTypeName("UINT32")] uint listIndex, IDWriteFont3* font);

        [VtblIndex(11)]
        HRESULT GetFontFaceReference(
            [NativeTypeName("UINT32")] uint listIndex,
            IDWriteFontFaceReference* fontFaceReference
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

        [NativeTypeName(
            "HRESULT (IDWriteFontCollection **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteFontCollection*, int> GetFontCollection;

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetFontCount;

        [NativeTypeName(
            "HRESULT (UINT32, IDWriteFont **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IDWriteFont*, int> GetFont;

        [NativeTypeName(
            "HRESULT (IDWriteLocalizedStrings **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteLocalizedStrings*, int> GetFamilyNames;

        [NativeTypeName(
            "HRESULT (DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, IDWriteFont **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_FONT_WEIGHT,
            DWRITE_FONT_STRETCH,
            DWRITE_FONT_STYLE,
            IDWriteFont*,
            int> GetFirstMatchingFont;

        [NativeTypeName(
            "HRESULT (DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, IDWriteFontList **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_FONT_WEIGHT,
            DWRITE_FONT_STRETCH,
            DWRITE_FONT_STYLE,
            IDWriteFontList*,
            int> GetMatchingFonts;

        [NativeTypeName(
            "DWRITE_LOCALITY (UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, DWRITE_LOCALITY> GetFontLocality;

        [NativeTypeName(
            "HRESULT (UINT32, IDWriteFont3 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IDWriteFont3*, int> GetFont1;

        [NativeTypeName(
            "HRESULT (UINT32, IDWriteFontFaceReference **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IDWriteFontFaceReference*,
            int> GetFontFaceReference;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDWriteFontFamily1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDWriteFontFamily1(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteFontFamily"/> to <see cref = "IDWriteFontFamily1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteFontFamily"/> instance to be converted </param>
    public static explicit operator IDWriteFontFamily1(Silk.NET.DirectX.IDWriteFontFamily value)
    {
        return new IDWriteFontFamily1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontFamily1"/> to <see cref = "Silk.NET.DirectX.IDWriteFontFamily"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontFamily1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteFontFamily(IDWriteFontFamily1 value)
    {
        return new Silk.NET.DirectX.IDWriteFontFamily(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteFontList"/> to <see cref = "IDWriteFontFamily1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteFontList"/> instance to be converted </param>
    public static explicit operator IDWriteFontFamily1(Silk.NET.DirectX.IDWriteFontList value)
    {
        return new IDWriteFontFamily1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontFamily1"/> to <see cref = "Silk.NET.DirectX.IDWriteFontList"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontFamily1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteFontList(IDWriteFontFamily1 value)
    {
        return new Silk.NET.DirectX.IDWriteFontList(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDWriteFontFamily1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDWriteFontFamily1(Silk.NET.Windows.IUnknown value)
    {
        return new IDWriteFontFamily1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontFamily1"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontFamily1"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDWriteFontFamily1 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
