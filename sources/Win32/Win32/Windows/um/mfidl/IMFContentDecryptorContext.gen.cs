// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("7EC4B1BD-43FB-4763-85D2-64FCB5C5F4CB")]
[NativeTypeName("struct IMFContentDecryptorContext : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IMFContentDecryptorContext
    : IMFContentDecryptorContext.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFContentDecryptorContext));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMFContentDecryptorContext, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFContentDecryptorContext, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFContentDecryptorContext, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT InitializeHardwareKey(
        uint InputPrivateDataByteCount,
        [NativeTypeName("const void *")] void* InputPrivateData,
        [NativeTypeName("UINT64 *")] ulong* OutputPrivateData
    )
    {
        return (
            (delegate* unmanaged<IMFContentDecryptorContext, uint, void*, ulong*, int>)(
                (*lpVtbl)[3]
            )
        )(this, InputPrivateDataByteCount, InputPrivateData, OutputPrivateData);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT InitializeHardwareKey(
            uint InputPrivateDataByteCount,
            [NativeTypeName("const void *")] void* InputPrivateData,
            [NativeTypeName("UINT64 *")] ulong* OutputPrivateData
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

        [NativeTypeName("HRESULT (UINT, const void *, UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, ulong*, int> InitializeHardwareKey;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFContentDecryptorContext"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFContentDecryptorContext(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFContentDecryptorContext"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFContentDecryptorContext(Silk.NET.Windows.IUnknown value)
    {
        return new IMFContentDecryptorContext(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFContentDecryptorContext"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFContentDecryptorContext"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFContentDecryptorContext value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
