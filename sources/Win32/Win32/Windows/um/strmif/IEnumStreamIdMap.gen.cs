// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("945C1566-6202-46FC-96C7-D87F289C6534")]
[NativeTypeName("struct IEnumStreamIdMap : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumStreamIdMap : IEnumStreamIdMap.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumStreamIdMap));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumStreamIdMap, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IEnumStreamIdMap, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumStreamIdMap, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next(
        [NativeTypeName("ULONG")] uint cRequest,
        STREAM_ID_MAP* pStreamIdMap,
        [NativeTypeName("ULONG *")] uint* pcReceived
    )
    {
        return (
            (delegate* unmanaged<IEnumStreamIdMap, uint, STREAM_ID_MAP*, uint*, int>)((*lpVtbl)[3])
        )(this, cRequest, pStreamIdMap, pcReceived);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint cRecords)
    {
        return ((delegate* unmanaged<IEnumStreamIdMap, uint, int>)((*lpVtbl)[4]))(this, cRecords);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumStreamIdMap, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(IEnumStreamIdMap* ppIEnumStreamIdMap)
    {
        return ((delegate* unmanaged<IEnumStreamIdMap, IEnumStreamIdMap*, int>)((*lpVtbl)[6]))(
            this,
            ppIEnumStreamIdMap
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Next(
            [NativeTypeName("ULONG")] uint cRequest,
            STREAM_ID_MAP* pStreamIdMap,
            [NativeTypeName("ULONG *")] uint* pcReceived
        );

        [VtblIndex(4)]
        HRESULT Skip([NativeTypeName("ULONG")] uint cRecords);

        [VtblIndex(5)]
        HRESULT Reset();

        [VtblIndex(6)]
        HRESULT Clone(IEnumStreamIdMap* ppIEnumStreamIdMap);
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

        [NativeTypeName("HRESULT (ULONG, STREAM_ID_MAP *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, STREAM_ID_MAP*, uint*, int> Next;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (IEnumStreamIdMap **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumStreamIdMap*, int> Clone;
    }

    /// <summary>Initializes a new instance of the <see cref = "IEnumStreamIdMap"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IEnumStreamIdMap(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IEnumStreamIdMap"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IEnumStreamIdMap(Silk.NET.Windows.IUnknown value)
    {
        return new IEnumStreamIdMap(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEnumStreamIdMap"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IEnumStreamIdMap"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IEnumStreamIdMap value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
