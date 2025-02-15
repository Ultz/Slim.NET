// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("AE2CD79F-CC22-453F-9B6B-B124E7A5204C")]
[NativeTypeName("struct IDxcOptimizerPass : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcOptimizerPass : IDxcOptimizerPass.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcOptimizerPass));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDxcOptimizerPass, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDxcOptimizerPass, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDxcOptimizerPass, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetOptionName([NativeTypeName("LPWSTR *")] ushort** ppResult)
    {
        return ((delegate* unmanaged<IDxcOptimizerPass, ushort**, int>)((*lpVtbl)[3]))(
            this,
            ppResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDescription([NativeTypeName("LPWSTR *")] ushort** ppResult)
    {
        return ((delegate* unmanaged<IDxcOptimizerPass, ushort**, int>)((*lpVtbl)[4]))(
            this,
            ppResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetOptionArgCount([NativeTypeName("UINT32 *")] uint* pCount)
    {
        return ((delegate* unmanaged<IDxcOptimizerPass, uint*, int>)((*lpVtbl)[5]))(this, pCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetOptionArgName(
        [NativeTypeName("UINT32")] uint argIndex,
        [NativeTypeName("LPWSTR *")] ushort** ppResult
    )
    {
        return ((delegate* unmanaged<IDxcOptimizerPass, uint, ushort**, int>)((*lpVtbl)[6]))(
            this,
            argIndex,
            ppResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetOptionArgDescription(
        [NativeTypeName("UINT32")] uint argIndex,
        [NativeTypeName("LPWSTR *")] ushort** ppResult
    )
    {
        return ((delegate* unmanaged<IDxcOptimizerPass, uint, ushort**, int>)((*lpVtbl)[7]))(
            this,
            argIndex,
            ppResult
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetOptionName([NativeTypeName("LPWSTR *")] ushort** ppResult);

        [VtblIndex(4)]
        HRESULT GetDescription([NativeTypeName("LPWSTR *")] ushort** ppResult);

        [VtblIndex(5)]
        HRESULT GetOptionArgCount([NativeTypeName("UINT32 *")] uint* pCount);

        [VtblIndex(6)]
        HRESULT GetOptionArgName(
            [NativeTypeName("UINT32")] uint argIndex,
            [NativeTypeName("LPWSTR *")] ushort** ppResult
        );

        [VtblIndex(7)]
        HRESULT GetOptionArgDescription(
            [NativeTypeName("UINT32")] uint argIndex,
            [NativeTypeName("LPWSTR *")] ushort** ppResult
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

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetOptionName;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDescription;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetOptionArgCount;

        [NativeTypeName("HRESULT (UINT32, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> GetOptionArgName;

        [NativeTypeName("HRESULT (UINT32, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> GetOptionArgDescription;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDxcOptimizerPass"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDxcOptimizerPass(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDxcOptimizerPass"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDxcOptimizerPass(Silk.NET.Windows.IUnknown value)
    {
        return new IDxcOptimizerPass(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDxcOptimizerPass"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDxcOptimizerPass"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDxcOptimizerPass value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
