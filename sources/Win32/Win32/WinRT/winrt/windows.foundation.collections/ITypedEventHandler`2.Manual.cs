// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("9DE1C534-6AE1-11E0-84E1-18A905BCC53F")]
public unsafe partial struct ITypedEventHandler<TSender, TArgs>
    where TSender : unmanaged
    where TArgs : unmanaged
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITypedEventHandler<TSender, TArgs>*, uint>)(lpVtbl[1]))(
            (ITypedEventHandler<TSender, TArgs>*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT Invoke(
        [NativeTypeName("TSender_abi")] TSender sender,
        [NativeTypeName("TArgs_abi")] TArgs args
    )
    {
        return (
            (delegate* unmanaged<ITypedEventHandler<TSender, TArgs>*, TSender, TArgs, int>)(
                lpVtbl[3]
            )
        )((ITypedEventHandler<TSender, TArgs>*)Unsafe.AsPointer(ref this), sender, args);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT QueryInterface(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("void **")] void** ppvObject
    )
    {
        return (
            (delegate* unmanaged<ITypedEventHandler<TSender, TArgs>*, Guid*, void**, int>)(
                lpVtbl[0]
            )
        )((ITypedEventHandler<TSender, TArgs>*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT QueryInterface(
        [NativeTypeName("const IID &")] Ref<Guid> riid,
        [NativeTypeName("void **")] Ref2D ppvObject
    )
    {
        fixed (void** __dsl_ppvObject = ppvObject)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HRESULT)QueryInterface(__dsl_riid, __dsl_ppvObject);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT QueryInterface<TCom>([NativeTypeName("void **")] out TCom ppvObject)
        where TCom : unmanaged, IComInterface
    {
        ppvObject = default;
        return QueryInterface(TCom.NativeGuid, ppvObject.GetAddressOf());
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITypedEventHandler<TSender, TArgs>*, uint>)(lpVtbl[2]))(
            (ITypedEventHandler<TSender, TArgs>*)Unsafe.AsPointer(ref this)
        );
    }
}
