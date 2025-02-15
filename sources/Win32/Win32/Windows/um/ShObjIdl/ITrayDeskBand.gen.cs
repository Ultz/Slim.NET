// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("6D67E846-5B9C-4DB8-9CBC-DDE12F4254F1")]
[NativeTypeName("struct ITrayDeskBand : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITrayDeskBand : ITrayDeskBand.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITrayDeskBand));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITrayDeskBand, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITrayDeskBand, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITrayDeskBand, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ShowDeskBand([NativeTypeName("const IID &")] Guid* clsid)
    {
        return ((delegate* unmanaged<ITrayDeskBand, Guid*, int>)((*lpVtbl)[3]))(this, clsid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT HideDeskBand([NativeTypeName("const IID &")] Guid* clsid)
    {
        return ((delegate* unmanaged<ITrayDeskBand, Guid*, int>)((*lpVtbl)[4]))(this, clsid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT IsDeskBandShown([NativeTypeName("const IID &")] Guid* clsid)
    {
        return ((delegate* unmanaged<ITrayDeskBand, Guid*, int>)((*lpVtbl)[5]))(this, clsid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT DeskBandRegistrationChanged()
    {
        return ((delegate* unmanaged<ITrayDeskBand, int>)((*lpVtbl)[6]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ShowDeskBand([NativeTypeName("const IID &")] Guid* clsid);

        [VtblIndex(4)]
        HRESULT HideDeskBand([NativeTypeName("const IID &")] Guid* clsid);

        [VtblIndex(5)]
        HRESULT IsDeskBandShown([NativeTypeName("const IID &")] Guid* clsid);

        [VtblIndex(6)]
        HRESULT DeskBandRegistrationChanged();
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

        [NativeTypeName("HRESULT (const IID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> ShowDeskBand;

        [NativeTypeName("HRESULT (const IID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> HideDeskBand;

        [NativeTypeName("HRESULT (const IID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> IsDeskBandShown;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DeskBandRegistrationChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITrayDeskBand"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITrayDeskBand(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITrayDeskBand"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITrayDeskBand(Silk.NET.Windows.IUnknown value)
    {
        return new ITrayDeskBand(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITrayDeskBand"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITrayDeskBand"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITrayDeskBand value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
