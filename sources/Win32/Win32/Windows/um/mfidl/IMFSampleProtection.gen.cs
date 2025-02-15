// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("8E36395F-C7B9-43C4-A54D-512B4AF63C95")]
[NativeTypeName("struct IMFSampleProtection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFSampleProtection : IMFSampleProtection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSampleProtection));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSampleProtection, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFSampleProtection, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSampleProtection, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetInputProtectionVersion([NativeTypeName("DWORD *")] uint* pdwVersion)
    {
        return ((delegate* unmanaged<IMFSampleProtection, uint*, int>)((*lpVtbl)[3]))(
            this,
            pdwVersion
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetOutputProtectionVersion([NativeTypeName("DWORD *")] uint* pdwVersion)
    {
        return ((delegate* unmanaged<IMFSampleProtection, uint*, int>)((*lpVtbl)[4]))(
            this,
            pdwVersion
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetProtectionCertificate(
        [NativeTypeName("DWORD")] uint dwVersion,
        byte** ppCert,
        [NativeTypeName("DWORD *")] uint* pcbCert
    )
    {
        return ((delegate* unmanaged<IMFSampleProtection, uint, byte**, uint*, int>)((*lpVtbl)[5]))(
            this,
            dwVersion,
            ppCert,
            pcbCert
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT InitOutputProtection(
        [NativeTypeName("DWORD")] uint dwVersion,
        [NativeTypeName("DWORD")] uint dwOutputId,
        byte* pbCert,
        [NativeTypeName("DWORD")] uint cbCert,
        byte** ppbSeed,
        [NativeTypeName("DWORD *")] uint* pcbSeed
    )
    {
        return (
            (delegate* unmanaged<IMFSampleProtection, uint, uint, byte*, uint, byte**, uint*, int>)(
                (*lpVtbl)[6]
            )
        )(this, dwVersion, dwOutputId, pbCert, cbCert, ppbSeed, pcbSeed);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT InitInputProtection(
        [NativeTypeName("DWORD")] uint dwVersion,
        [NativeTypeName("DWORD")] uint dwInputId,
        byte* pbSeed,
        [NativeTypeName("DWORD")] uint cbSeed
    )
    {
        return (
            (delegate* unmanaged<IMFSampleProtection, uint, uint, byte*, uint, int>)((*lpVtbl)[7])
        )(this, dwVersion, dwInputId, pbSeed, cbSeed);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetInputProtectionVersion([NativeTypeName("DWORD *")] uint* pdwVersion);

        [VtblIndex(4)]
        HRESULT GetOutputProtectionVersion([NativeTypeName("DWORD *")] uint* pdwVersion);

        [VtblIndex(5)]
        HRESULT GetProtectionCertificate(
            [NativeTypeName("DWORD")] uint dwVersion,
            byte** ppCert,
            [NativeTypeName("DWORD *")] uint* pcbCert
        );

        [VtblIndex(6)]
        HRESULT InitOutputProtection(
            [NativeTypeName("DWORD")] uint dwVersion,
            [NativeTypeName("DWORD")] uint dwOutputId,
            byte* pbCert,
            [NativeTypeName("DWORD")] uint cbCert,
            byte** ppbSeed,
            [NativeTypeName("DWORD *")] uint* pcbSeed
        );

        [VtblIndex(7)]
        HRESULT InitInputProtection(
            [NativeTypeName("DWORD")] uint dwVersion,
            [NativeTypeName("DWORD")] uint dwInputId,
            byte* pbSeed,
            [NativeTypeName("DWORD")] uint cbSeed
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetInputProtectionVersion;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetOutputProtectionVersion;

        [NativeTypeName("HRESULT (DWORD, BYTE **, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte**, uint*, int> GetProtectionCertificate;

        [NativeTypeName(
            "HRESULT (DWORD, DWORD, BYTE *, DWORD, BYTE **, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            byte*,
            uint,
            byte**,
            uint*,
            int> InitOutputProtection;

        [NativeTypeName("HRESULT (DWORD, DWORD, BYTE *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, byte*, uint, int> InitInputProtection;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFSampleProtection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFSampleProtection(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFSampleProtection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFSampleProtection(Silk.NET.Windows.IUnknown value)
    {
        return new IMFSampleProtection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFSampleProtection"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFSampleProtection"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFSampleProtection value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
