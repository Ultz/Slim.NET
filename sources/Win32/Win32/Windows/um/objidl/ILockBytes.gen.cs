// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0000000A-0000-0000-C000-000000000046")]
[NativeTypeName("struct ILockBytes : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ILockBytes : ILockBytes.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILockBytes));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ILockBytes, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ILockBytes, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ILockBytes, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ReadAt(
        ULARGE_INTEGER ulOffset,
        void* pv,
        [NativeTypeName("ULONG")] uint cb,
        [NativeTypeName("ULONG *")] uint* pcbRead
    )
    {
        return (
            (delegate* unmanaged<ILockBytes, ULARGE_INTEGER, void*, uint, uint*, int>)((*lpVtbl)[3])
        )(this, ulOffset, pv, cb, pcbRead);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT WriteAt(
        ULARGE_INTEGER ulOffset,
        [NativeTypeName("const void *")] void* pv,
        [NativeTypeName("ULONG")] uint cb,
        [NativeTypeName("ULONG *")] uint* pcbWritten
    )
    {
        return (
            (delegate* unmanaged<ILockBytes, ULARGE_INTEGER, void*, uint, uint*, int>)((*lpVtbl)[4])
        )(this, ulOffset, pv, cb, pcbWritten);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Flush()
    {
        return ((delegate* unmanaged<ILockBytes, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetSize(ULARGE_INTEGER cb)
    {
        return ((delegate* unmanaged<ILockBytes, ULARGE_INTEGER, int>)((*lpVtbl)[6]))(this, cb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT LockRegion(
        ULARGE_INTEGER libOffset,
        ULARGE_INTEGER cb,
        [NativeTypeName("DWORD")] uint dwLockType
    )
    {
        return (
            (delegate* unmanaged<ILockBytes, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(
                (*lpVtbl)[7]
            )
        )(this, libOffset, cb, dwLockType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT UnlockRegion(
        ULARGE_INTEGER libOffset,
        ULARGE_INTEGER cb,
        [NativeTypeName("DWORD")] uint dwLockType
    )
    {
        return (
            (delegate* unmanaged<ILockBytes, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(
                (*lpVtbl)[8]
            )
        )(this, libOffset, cb, dwLockType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Stat(STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
    {
        return ((delegate* unmanaged<ILockBytes, STATSTG*, uint, int>)((*lpVtbl)[9]))(
            this,
            pstatstg,
            grfStatFlag
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ReadAt(
            ULARGE_INTEGER ulOffset,
            void* pv,
            [NativeTypeName("ULONG")] uint cb,
            [NativeTypeName("ULONG *")] uint* pcbRead
        );

        [VtblIndex(4)]
        HRESULT WriteAt(
            ULARGE_INTEGER ulOffset,
            [NativeTypeName("const void *")] void* pv,
            [NativeTypeName("ULONG")] uint cb,
            [NativeTypeName("ULONG *")] uint* pcbWritten
        );

        [VtblIndex(5)]
        HRESULT Flush();

        [VtblIndex(6)]
        HRESULT SetSize(ULARGE_INTEGER cb);

        [VtblIndex(7)]
        HRESULT LockRegion(
            ULARGE_INTEGER libOffset,
            ULARGE_INTEGER cb,
            [NativeTypeName("DWORD")] uint dwLockType
        );

        [VtblIndex(8)]
        HRESULT UnlockRegion(
            ULARGE_INTEGER libOffset,
            ULARGE_INTEGER cb,
            [NativeTypeName("DWORD")] uint dwLockType
        );

        [VtblIndex(9)]
        HRESULT Stat(STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag);
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
            "HRESULT (ULARGE_INTEGER, void *, ULONG, ULONG *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ULARGE_INTEGER, void*, uint, uint*, int> ReadAt;

        [NativeTypeName(
            "HRESULT (ULARGE_INTEGER, const void *, ULONG, ULONG *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ULARGE_INTEGER, void*, uint, uint*, int> WriteAt;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Flush;

        [NativeTypeName("HRESULT (ULARGE_INTEGER) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ULARGE_INTEGER, int> SetSize;

        [NativeTypeName("HRESULT (ULARGE_INTEGER, ULARGE_INTEGER, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int> LockRegion;

        [NativeTypeName("HRESULT (ULARGE_INTEGER, ULARGE_INTEGER, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int> UnlockRegion;

        [NativeTypeName("HRESULT (STATSTG *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, STATSTG*, uint, int> Stat;
    }

    /// <summary>Initializes a new instance of the <see cref = "ILockBytes"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ILockBytes(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ILockBytes"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ILockBytes(Silk.NET.Windows.IUnknown value)
    {
        return new ILockBytes(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ILockBytes"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ILockBytes"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ILockBytes value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
