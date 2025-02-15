// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("D19F8E98-B126-4446-890C-5DCB7AD71453")]
[NativeTypeName("struct IMFInputTrustAuthority : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFInputTrustAuthority : IMFInputTrustAuthority.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFInputTrustAuthority));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFInputTrustAuthority, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFInputTrustAuthority, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFInputTrustAuthority, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDecrypter([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IMFInputTrustAuthority, Guid*, void**, int>)((*lpVtbl)[3]))(
            this,
            riid,
            ppv
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RequestAccess(
        MFPOLICYMANAGER_ACTION Action,
        IMFActivate* ppContentEnablerActivate
    )
    {
        return (
            (delegate* unmanaged<
                IMFInputTrustAuthority,
                MFPOLICYMANAGER_ACTION,
                IMFActivate*,
                int>)((*lpVtbl)[4])
        )(this, Action, ppContentEnablerActivate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPolicy(MFPOLICYMANAGER_ACTION Action, IMFOutputPolicy* ppPolicy)
    {
        return (
            (delegate* unmanaged<
                IMFInputTrustAuthority,
                MFPOLICYMANAGER_ACTION,
                IMFOutputPolicy*,
                int>)((*lpVtbl)[5])
        )(this, Action, ppPolicy);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT BindAccess(MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS* pParam)
    {
        return (
            (delegate* unmanaged<
                IMFInputTrustAuthority,
                MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS*,
                int>)((*lpVtbl)[6])
        )(this, pParam);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UpdateAccess(MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS* pParam)
    {
        return (
            (delegate* unmanaged<
                IMFInputTrustAuthority,
                MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS*,
                int>)((*lpVtbl)[7])
        )(this, pParam);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IMFInputTrustAuthority, int>)((*lpVtbl)[8]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDecrypter([NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [VtblIndex(4)]
        HRESULT RequestAccess(MFPOLICYMANAGER_ACTION Action, IMFActivate* ppContentEnablerActivate);

        [VtblIndex(5)]
        HRESULT GetPolicy(MFPOLICYMANAGER_ACTION Action, IMFOutputPolicy* ppPolicy);

        [VtblIndex(6)]
        HRESULT BindAccess(MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS* pParam);

        [VtblIndex(7)]
        HRESULT UpdateAccess(MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS* pParam);

        [VtblIndex(8)]
        HRESULT Reset();
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

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetDecrypter;

        [NativeTypeName(
            "HRESULT (MFPOLICYMANAGER_ACTION, IMFActivate **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MFPOLICYMANAGER_ACTION, IMFActivate*, int> RequestAccess;

        [NativeTypeName(
            "HRESULT (MFPOLICYMANAGER_ACTION, IMFOutputPolicy **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MFPOLICYMANAGER_ACTION, IMFOutputPolicy*, int> GetPolicy;

        [NativeTypeName("HRESULT (MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS*, int> BindAccess;

        [NativeTypeName("HRESULT (MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS*, int> UpdateAccess;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFInputTrustAuthority"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFInputTrustAuthority(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFInputTrustAuthority"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFInputTrustAuthority(Silk.NET.Windows.IUnknown value)
    {
        return new IMFInputTrustAuthority(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFInputTrustAuthority"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFInputTrustAuthority"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFInputTrustAuthority value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
