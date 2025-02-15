// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("526C7776-40E9-459B-B711-F32AD76DFC28")]
[NativeTypeName("struct IDXCoreAdapterList : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct IDXCoreAdapterList : IDXCoreAdapterList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXCoreAdapterList));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXCoreAdapterList, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDXCoreAdapterList, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXCoreAdapterList, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAdapter(
        [NativeTypeName("uint32_t")] uint index,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvAdapter
    )
    {
        return ((delegate* unmanaged<IDXCoreAdapterList, uint, Guid*, void**, int>)((*lpVtbl)[3]))(
            this,
            index,
            riid,
            ppvAdapter
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("uint32_t")]
    public uint GetAdapterCount()
    {
        return ((delegate* unmanaged<IDXCoreAdapterList, uint>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public bool IsStale()
    {
        return ((delegate* unmanaged<IDXCoreAdapterList, byte>)((*lpVtbl)[5]))(this) != 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFactory([NativeTypeName("const IID &")] Guid* riid, void** ppvFactory)
    {
        return ((delegate* unmanaged<IDXCoreAdapterList, Guid*, void**, int>)((*lpVtbl)[6]))(
            this,
            riid,
            ppvFactory
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Sort(
        [NativeTypeName("uint32_t")] uint numPreferences,
        [NativeTypeName("const DXCoreAdapterPreference *")] DXCoreAdapterPreference* preferences
    )
    {
        return (
            (delegate* unmanaged<IDXCoreAdapterList, uint, DXCoreAdapterPreference*, int>)(
                (*lpVtbl)[7]
            )
        )(this, numPreferences, preferences);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public bool IsAdapterPreferenceSupported(DXCoreAdapterPreference preference)
    {
        return (
                (delegate* unmanaged<IDXCoreAdapterList, DXCoreAdapterPreference, byte>)(
                    (*lpVtbl)[8]
                )
            )(this, preference) != 0;
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetAdapter(
            [NativeTypeName("uint32_t")] uint index,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppvAdapter
        );

        [VtblIndex(4)]
        [return: NativeTypeName("uint32_t")]
        uint GetAdapterCount();

        [VtblIndex(5)]
        bool IsStale();

        [VtblIndex(6)]
        HRESULT GetFactory([NativeTypeName("const IID &")] Guid* riid, void** ppvFactory);

        [VtblIndex(7)]
        HRESULT Sort(
            [NativeTypeName("uint32_t")] uint numPreferences,
            [NativeTypeName("const DXCoreAdapterPreference *")] DXCoreAdapterPreference* preferences
        );

        [VtblIndex(8)]
        bool IsAdapterPreferenceSupported(DXCoreAdapterPreference preference);
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

        [NativeTypeName("HRESULT (uint32_t, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, void**, int> GetAdapter;

        [NativeTypeName("uint32_t () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetAdapterCount;

        [NativeTypeName("bool () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte> IsStale;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetFactory;

        [NativeTypeName(
            "HRESULT (uint32_t, const DXCoreAdapterPreference *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, DXCoreAdapterPreference*, int> Sort;

        [NativeTypeName("bool (DXCoreAdapterPreference) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            DXCoreAdapterPreference,
            byte> IsAdapterPreferenceSupported;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDXCoreAdapterList"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDXCoreAdapterList(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDXCoreAdapterList"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDXCoreAdapterList(Silk.NET.Windows.IUnknown value)
    {
        return new IDXCoreAdapterList(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXCoreAdapterList"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDXCoreAdapterList"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDXCoreAdapterList value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
