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

[Guid("53585141-D9F8-4095-8321-D73CF6BD116B")]
[NativeTypeName("struct IDWriteFontSet : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IDWriteFontSet : IDWriteFontSet.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontSet));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFontSet, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDWriteFontSet, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFontSet, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontCount()
    {
        return ((delegate* unmanaged<IDWriteFontSet, uint>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFontFaceReference(
        [NativeTypeName("UINT32")] uint listIndex,
        IDWriteFontFaceReference* fontFaceReference
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontSet, uint, IDWriteFontFaceReference*, int>)(
                (*lpVtbl)[4]
            )
        )(this, listIndex, fontFaceReference);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT FindFontFaceReference(
        IDWriteFontFaceReference fontFaceReference,
        [NativeTypeName("UINT32 *")] uint* listIndex,
        BOOL* exists
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontSet, IDWriteFontFaceReference, uint*, BOOL*, int>)(
                (*lpVtbl)[5]
            )
        )(this, fontFaceReference, listIndex, exists);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindFontFace(
        IDWriteFontFace fontFace,
        [NativeTypeName("UINT32 *")] uint* listIndex,
        BOOL* exists
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontSet, IDWriteFontFace, uint*, BOOL*, int>)((*lpVtbl)[6])
        )(this, fontFace, listIndex, exists);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetPropertyValues(DWRITE_FONT_PROPERTY_ID propertyID, IDWriteStringList* values)
    {
        return (
            (delegate* unmanaged<IDWriteFontSet, DWRITE_FONT_PROPERTY_ID, IDWriteStringList*, int>)(
                (*lpVtbl)[7]
            )
        )(this, propertyID, values);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetPropertyValues(
        DWRITE_FONT_PROPERTY_ID propertyID,
        [NativeTypeName("const WCHAR *")] ushort* preferredLocaleNames,
        IDWriteStringList* values
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontSet,
                DWRITE_FONT_PROPERTY_ID,
                ushort*,
                IDWriteStringList*,
                int>)((*lpVtbl)[8])
        )(this, propertyID, preferredLocaleNames, values);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetPropertyValues(
        [NativeTypeName("UINT32")] uint listIndex,
        DWRITE_FONT_PROPERTY_ID propertyId,
        BOOL* exists,
        IDWriteLocalizedStrings* values
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontSet,
                uint,
                DWRITE_FONT_PROPERTY_ID,
                BOOL*,
                IDWriteLocalizedStrings*,
                int>)((*lpVtbl)[9])
        )(this, listIndex, propertyId, exists, values);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetPropertyOccurrenceCount(
        [NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* property,
        [NativeTypeName("UINT32 *")] uint* propertyOccurrenceCount
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontSet, DWRITE_FONT_PROPERTY*, uint*, int>)((*lpVtbl)[10])
        )(this, property, propertyOccurrenceCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetMatchingFonts(
        [NativeTypeName("const WCHAR *")] ushort* familyName,
        DWRITE_FONT_WEIGHT fontWeight,
        DWRITE_FONT_STRETCH fontStretch,
        DWRITE_FONT_STYLE fontStyle,
        IDWriteFontSet* filteredSet
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontSet,
                ushort*,
                DWRITE_FONT_WEIGHT,
                DWRITE_FONT_STRETCH,
                DWRITE_FONT_STYLE,
                IDWriteFontSet*,
                int>)((*lpVtbl)[11])
        )(this, familyName, fontWeight, fontStretch, fontStyle, filteredSet);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetMatchingFonts(
        [NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties,
        [NativeTypeName("UINT32")] uint propertyCount,
        IDWriteFontSet* filteredSet
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontSet,
                DWRITE_FONT_PROPERTY*,
                uint,
                IDWriteFontSet*,
                int>)((*lpVtbl)[12])
        )(this, properties, propertyCount, filteredSet);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("UINT32")]
        uint GetFontCount();

        [VtblIndex(4)]
        HRESULT GetFontFaceReference(
            [NativeTypeName("UINT32")] uint listIndex,
            IDWriteFontFaceReference* fontFaceReference
        );

        [VtblIndex(5)]
        HRESULT FindFontFaceReference(
            IDWriteFontFaceReference fontFaceReference,
            [NativeTypeName("UINT32 *")] uint* listIndex,
            BOOL* exists
        );

        [VtblIndex(6)]
        HRESULT FindFontFace(
            IDWriteFontFace fontFace,
            [NativeTypeName("UINT32 *")] uint* listIndex,
            BOOL* exists
        );

        [VtblIndex(7)]
        HRESULT GetPropertyValues(DWRITE_FONT_PROPERTY_ID propertyID, IDWriteStringList* values);

        [VtblIndex(8)]
        HRESULT GetPropertyValues(
            DWRITE_FONT_PROPERTY_ID propertyID,
            [NativeTypeName("const WCHAR *")] ushort* preferredLocaleNames,
            IDWriteStringList* values
        );

        [VtblIndex(9)]
        HRESULT GetPropertyValues(
            [NativeTypeName("UINT32")] uint listIndex,
            DWRITE_FONT_PROPERTY_ID propertyId,
            BOOL* exists,
            IDWriteLocalizedStrings* values
        );

        [VtblIndex(10)]
        HRESULT GetPropertyOccurrenceCount(
            [NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* property,
            [NativeTypeName("UINT32 *")] uint* propertyOccurrenceCount
        );

        [VtblIndex(11)]
        HRESULT GetMatchingFonts(
            [NativeTypeName("const WCHAR *")] ushort* familyName,
            DWRITE_FONT_WEIGHT fontWeight,
            DWRITE_FONT_STRETCH fontStretch,
            DWRITE_FONT_STYLE fontStyle,
            IDWriteFontSet* filteredSet
        );

        [VtblIndex(12)]
        HRESULT GetMatchingFonts(
            [NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties,
            [NativeTypeName("UINT32")] uint propertyCount,
            IDWriteFontSet* filteredSet
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

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetFontCount;

        [NativeTypeName(
            "HRESULT (UINT32, IDWriteFontFaceReference **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IDWriteFontFaceReference*,
            int> GetFontFaceReference;

        [NativeTypeName(
            "HRESULT (IDWriteFontFaceReference *, UINT32 *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDWriteFontFaceReference,
            uint*,
            BOOL*,
            int> FindFontFaceReference;

        [NativeTypeName(
            "HRESULT (IDWriteFontFace *, UINT32 *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteFontFace, uint*, BOOL*, int> FindFontFace;

        [NativeTypeName(
            "HRESULT (DWRITE_FONT_PROPERTY_ID, IDWriteStringList **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_FONT_PROPERTY_ID,
            IDWriteStringList*,
            int> GetPropertyValues;

        [NativeTypeName(
            "HRESULT (DWRITE_FONT_PROPERTY_ID, const WCHAR *, IDWriteStringList **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_FONT_PROPERTY_ID,
            ushort*,
            IDWriteStringList*,
            int> GetPropertyValues1;

        [NativeTypeName(
            "HRESULT (UINT32, DWRITE_FONT_PROPERTY_ID, BOOL *, IDWriteLocalizedStrings **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            DWRITE_FONT_PROPERTY_ID,
            BOOL*,
            IDWriteLocalizedStrings*,
            int> GetPropertyValues2;

        [NativeTypeName(
            "HRESULT (const DWRITE_FONT_PROPERTY *, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_FONT_PROPERTY*,
            uint*,
            int> GetPropertyOccurrenceCount;

        [NativeTypeName(
            "HRESULT (const WCHAR *, DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, IDWriteFontSet **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            DWRITE_FONT_WEIGHT,
            DWRITE_FONT_STRETCH,
            DWRITE_FONT_STYLE,
            IDWriteFontSet*,
            int> GetMatchingFonts;

        [NativeTypeName(
            "HRESULT (const DWRITE_FONT_PROPERTY *, UINT32, IDWriteFontSet **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_FONT_PROPERTY*,
            uint,
            IDWriteFontSet*,
            int> GetMatchingFonts1;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDWriteFontSet"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDWriteFontSet(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDWriteFontSet"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDWriteFontSet(Silk.NET.Windows.IUnknown value)
    {
        return new IDWriteFontSet(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontSet"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontSet"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDWriteFontSet value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
