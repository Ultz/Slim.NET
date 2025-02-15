// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("B196B287-BAB4-101A-B69C-00AA00341D07")]
[NativeTypeName("struct IEnumConnections : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumConnections : IEnumConnections.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumConnections));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumConnections, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IEnumConnections, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumConnections, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next(
        [NativeTypeName("ULONG")] uint cConnections,
        [NativeTypeName("LPCONNECTDATA")] CONNECTDATA* rgcd,
        [NativeTypeName("ULONG *")] uint* pcFetched
    )
    {
        return (
            (delegate* unmanaged<IEnumConnections, uint, CONNECTDATA*, uint*, int>)((*lpVtbl)[3])
        )(this, cConnections, rgcd, pcFetched);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint cConnections)
    {
        return ((delegate* unmanaged<IEnumConnections, uint, int>)((*lpVtbl)[4]))(
            this,
            cConnections
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumConnections, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(IEnumConnections* ppEnum)
    {
        return ((delegate* unmanaged<IEnumConnections, IEnumConnections*, int>)((*lpVtbl)[6]))(
            this,
            ppEnum
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Next(
            [NativeTypeName("ULONG")] uint cConnections,
            [NativeTypeName("LPCONNECTDATA")] CONNECTDATA* rgcd,
            [NativeTypeName("ULONG *")] uint* pcFetched
        );

        [VtblIndex(4)]
        HRESULT Skip([NativeTypeName("ULONG")] uint cConnections);

        [VtblIndex(5)]
        HRESULT Reset();

        [VtblIndex(6)]
        HRESULT Clone(IEnumConnections* ppEnum);
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

        [NativeTypeName("HRESULT (ULONG, LPCONNECTDATA, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, CONNECTDATA*, uint*, int> Next;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (IEnumConnections **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumConnections*, int> Clone;
    }

    /// <summary>Initializes a new instance of the <see cref = "IEnumConnections"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IEnumConnections(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IEnumConnections"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IEnumConnections(Silk.NET.Windows.IUnknown value)
    {
        return new IEnumConnections(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEnumConnections"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IEnumConnections"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IEnumConnections value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
