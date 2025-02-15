// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/tlogstg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("7EBFDD85-AD18-11D3-A4C5-00C04F72D6B8")]
[NativeTypeName("struct IEnumTravelLogEntry : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumTravelLogEntry : IEnumTravelLogEntry.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumTravelLogEntry));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumTravelLogEntry, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IEnumTravelLogEntry, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumTravelLogEntry, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next(
        [NativeTypeName("ULONG")] uint cElt,
        ITravelLogEntry* rgElt,
        [NativeTypeName("ULONG *")] uint* pcEltFetched
    )
    {
        return (
            (delegate* unmanaged<IEnumTravelLogEntry, uint, ITravelLogEntry*, uint*, int>)(
                (*lpVtbl)[3]
            )
        )(this, cElt, rgElt, pcEltFetched);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint cElt)
    {
        return ((delegate* unmanaged<IEnumTravelLogEntry, uint, int>)((*lpVtbl)[4]))(this, cElt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumTravelLogEntry, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(IEnumTravelLogEntry* ppEnum)
    {
        return (
            (delegate* unmanaged<IEnumTravelLogEntry, IEnumTravelLogEntry*, int>)((*lpVtbl)[6])
        )(this, ppEnum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Next(
            [NativeTypeName("ULONG")] uint cElt,
            ITravelLogEntry* rgElt,
            [NativeTypeName("ULONG *")] uint* pcEltFetched
        );

        [VtblIndex(4)]
        HRESULT Skip([NativeTypeName("ULONG")] uint cElt);

        [VtblIndex(5)]
        HRESULT Reset();

        [VtblIndex(6)]
        HRESULT Clone(IEnumTravelLogEntry* ppEnum);
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

        [NativeTypeName("HRESULT (ULONG, ITravelLogEntry **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITravelLogEntry*, uint*, int> Next;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (IEnumTravelLogEntry **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumTravelLogEntry*, int> Clone;
    }

    /// <summary>Initializes a new instance of the <see cref = "IEnumTravelLogEntry"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IEnumTravelLogEntry(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IEnumTravelLogEntry"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IEnumTravelLogEntry(Silk.NET.Windows.IUnknown value)
    {
        return new IEnumTravelLogEntry(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEnumTravelLogEntry"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IEnumTravelLogEntry"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IEnumTravelLogEntry value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
