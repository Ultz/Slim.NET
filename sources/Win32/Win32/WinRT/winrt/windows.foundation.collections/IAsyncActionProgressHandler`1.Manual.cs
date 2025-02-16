// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("6D844858-0CFF-4590-AE89-95A5A5C8B4B8")]
public unsafe partial struct IAsyncActionProgressHandler<TProgress>
    where TProgress : unmanaged
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAsyncActionProgressHandler<TProgress>*, uint>)(lpVtbl[1]))(
            (IAsyncActionProgressHandler<TProgress>*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT Invoke(
        [NativeTypeName("IAsyncActionWithProgress<TProgress_logical> *")]
            IAsyncActionWithProgress<TProgress>* asyncInfo,
        [NativeTypeName("TProgress_abi")] TProgress progressInfo
    )
    {
        return (
            (delegate* unmanaged<
                IAsyncActionProgressHandler<TProgress>*,
                IAsyncActionWithProgress<TProgress>*,
                TProgress,
                int>)(lpVtbl[3])
        )(
            (IAsyncActionProgressHandler<TProgress>*)Unsafe.AsPointer(ref this),
            asyncInfo,
            progressInfo
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT Invoke(
        [NativeTypeName("IAsyncActionWithProgress<TProgress_logical> *")]
            Ref<IAsyncActionWithProgress<TProgress>> asyncInfo,
        [NativeTypeName("TProgress_abi")] TProgress progressInfo
    )
    {
        fixed (IAsyncActionWithProgress<TProgress>* __dsl_asyncInfo = asyncInfo)
        {
            return (HRESULT)Invoke(__dsl_asyncInfo, progressInfo);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT QueryInterface(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("void **")] void** ppvObject
    )
    {
        return (
            (delegate* unmanaged<IAsyncActionProgressHandler<TProgress>*, Guid*, void**, int>)(
                lpVtbl[0]
            )
        )((IAsyncActionProgressHandler<TProgress>*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
        return ((delegate* unmanaged<IAsyncActionProgressHandler<TProgress>*, uint>)(lpVtbl[2]))(
            (IAsyncActionProgressHandler<TProgress>*)Unsafe.AsPointer(ref this)
        );
    }
}
