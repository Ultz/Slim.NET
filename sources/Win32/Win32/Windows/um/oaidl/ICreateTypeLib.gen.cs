// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00020406-0000-0000-C000-000000000046")]
[NativeTypeName("struct ICreateTypeLib : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICreateTypeLib : ICreateTypeLib.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICreateTypeLib));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICreateTypeLib, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICreateTypeLib, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICreateTypeLib, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateTypeInfo(
        [NativeTypeName("LPOLESTR")] ushort* szName,
        TYPEKIND tkind,
        ICreateTypeInfo* ppCTInfo
    )
    {
        return (
            (delegate* unmanaged<ICreateTypeLib, ushort*, TYPEKIND, ICreateTypeInfo*, int>)(
                (*lpVtbl)[3]
            )
        )(this, szName, tkind, ppCTInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetName([NativeTypeName("LPOLESTR")] ushort* szName)
    {
        return ((delegate* unmanaged<ICreateTypeLib, ushort*, int>)((*lpVtbl)[4]))(this, szName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetVersion(
        [NativeTypeName("WORD")] ushort wMajorVerNum,
        [NativeTypeName("WORD")] ushort wMinorVerNum
    )
    {
        return ((delegate* unmanaged<ICreateTypeLib, ushort, ushort, int>)((*lpVtbl)[5]))(
            this,
            wMajorVerNum,
            wMinorVerNum
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetGuid([NativeTypeName("const GUID &")] Guid* guid)
    {
        return ((delegate* unmanaged<ICreateTypeLib, Guid*, int>)((*lpVtbl)[6]))(this, guid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetDocString([NativeTypeName("LPOLESTR")] ushort* szDoc)
    {
        return ((delegate* unmanaged<ICreateTypeLib, ushort*, int>)((*lpVtbl)[7]))(this, szDoc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetHelpFileName([NativeTypeName("LPOLESTR")] ushort* szHelpFileName)
    {
        return ((delegate* unmanaged<ICreateTypeLib, ushort*, int>)((*lpVtbl)[8]))(
            this,
            szHelpFileName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetHelpContext([NativeTypeName("DWORD")] uint dwHelpContext)
    {
        return ((delegate* unmanaged<ICreateTypeLib, uint, int>)((*lpVtbl)[9]))(
            this,
            dwHelpContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetLcid([NativeTypeName("LCID")] uint lcid)
    {
        return ((delegate* unmanaged<ICreateTypeLib, uint, int>)((*lpVtbl)[10]))(this, lcid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetLibFlags(uint uLibFlags)
    {
        return ((delegate* unmanaged<ICreateTypeLib, uint, int>)((*lpVtbl)[11]))(this, uLibFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SaveAllChanges()
    {
        return ((delegate* unmanaged<ICreateTypeLib, int>)((*lpVtbl)[12]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateTypeInfo(
            [NativeTypeName("LPOLESTR")] ushort* szName,
            TYPEKIND tkind,
            ICreateTypeInfo* ppCTInfo
        );

        [VtblIndex(4)]
        HRESULT SetName([NativeTypeName("LPOLESTR")] ushort* szName);

        [VtblIndex(5)]
        HRESULT SetVersion(
            [NativeTypeName("WORD")] ushort wMajorVerNum,
            [NativeTypeName("WORD")] ushort wMinorVerNum
        );

        [VtblIndex(6)]
        HRESULT SetGuid([NativeTypeName("const GUID &")] Guid* guid);

        [VtblIndex(7)]
        HRESULT SetDocString([NativeTypeName("LPOLESTR")] ushort* szDoc);

        [VtblIndex(8)]
        HRESULT SetHelpFileName([NativeTypeName("LPOLESTR")] ushort* szHelpFileName);

        [VtblIndex(9)]
        HRESULT SetHelpContext([NativeTypeName("DWORD")] uint dwHelpContext);

        [VtblIndex(10)]
        HRESULT SetLcid([NativeTypeName("LCID")] uint lcid);

        [VtblIndex(11)]
        HRESULT SetLibFlags(uint uLibFlags);

        [VtblIndex(12)]
        HRESULT SaveAllChanges();
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
            "HRESULT (LPOLESTR, TYPEKIND, ICreateTypeInfo **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, TYPEKIND, ICreateTypeInfo*, int> CreateTypeInfo;

        [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetName;

        [NativeTypeName("HRESULT (WORD, WORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, ushort, int> SetVersion;

        [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> SetGuid;

        [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetDocString;

        [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetHelpFileName;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetHelpContext;

        [NativeTypeName("HRESULT (LCID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetLcid;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetLibFlags;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SaveAllChanges;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICreateTypeLib"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICreateTypeLib(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICreateTypeLib"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICreateTypeLib(Silk.NET.Windows.IUnknown value)
    {
        return new ICreateTypeLib(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICreateTypeLib"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICreateTypeLib"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICreateTypeLib value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
