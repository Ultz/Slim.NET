// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("B5D036D7-E297-498F-BA60-0289E76E23DD")]
public unsafe partial struct IAsyncOperationWithProgress<TResult, TProgress>
    where TResult : unmanaged
    where TProgress : unmanaged
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IAsyncOperationWithProgress<TResult, TProgress>*, uint>)(lpVtbl[1])
        )((IAsyncOperationWithProgress<TResult, TProgress>*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT get_Completed(
        [NativeTypeName(
            "IAsyncOperationWithProgressCompletedHandler<TResult_logical, TProgress_logical> **"
        )]
            IAsyncOperationWithProgressCompletedHandler<TResult, TProgress>** handler
    )
    {
        return (
            (delegate* unmanaged<
                IAsyncOperationWithProgress<TResult, TProgress>*,
                IAsyncOperationWithProgressCompletedHandler<TResult, TProgress>**,
                int>)(lpVtbl[9])
        )((IAsyncOperationWithProgress<TResult, TProgress>*)Unsafe.AsPointer(ref this), handler);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT get_Completed(
        [NativeTypeName(
            "IAsyncOperationWithProgressCompletedHandler<TResult_logical, TProgress_logical> **"
        )]
            Ref2D<IAsyncOperationWithProgressCompletedHandler<TResult, TProgress>> handler
    )
    {
        fixed (
            IAsyncOperationWithProgressCompletedHandler<TResult, TProgress>** __dsl_handler =
                handler
        )
        {
            return (HRESULT)get_Completed(__dsl_handler);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT get_Progress(
        [NativeTypeName("IAsyncOperationProgressHandler<TResult_logical, TProgress_logical> **")]
            IAsyncOperationProgressHandler<TResult, TProgress>** handler
    )
    {
        return (
            (delegate* unmanaged<
                IAsyncOperationWithProgress<TResult, TProgress>*,
                IAsyncOperationProgressHandler<TResult, TProgress>**,
                int>)(lpVtbl[7])
        )((IAsyncOperationWithProgress<TResult, TProgress>*)Unsafe.AsPointer(ref this), handler);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT get_Progress(
        [NativeTypeName("IAsyncOperationProgressHandler<TResult_logical, TProgress_logical> **")]
            Ref2D<IAsyncOperationProgressHandler<TResult, TProgress>> handler
    )
    {
        fixed (IAsyncOperationProgressHandler<TResult, TProgress>** __dsl_handler = handler)
        {
            return (HRESULT)get_Progress(__dsl_handler);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<
                IAsyncOperationWithProgress<TResult, TProgress>*,
                uint*,
                Guid**,
                int>)(lpVtbl[3])
        )(
            (IAsyncOperationWithProgress<TResult, TProgress>*)Unsafe.AsPointer(ref this),
            iidCount,
            iids
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] Ref<uint> iidCount,
        [NativeTypeName("IID **")] Ref2D<Guid> iids
    )
    {
        fixed (Guid** __dsl_iids = iids)
        fixed (uint* __dsl_iidCount = iidCount)
        {
            return (HRESULT)GetIids(__dsl_iidCount, __dsl_iids);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetResults([NativeTypeName("TResult_abi *")] TResult* results)
    {
        return (
            (delegate* unmanaged<IAsyncOperationWithProgress<TResult, TProgress>*, TResult*, int>)(
                lpVtbl[10]
            )
        )((IAsyncOperationWithProgress<TResult, TProgress>*)Unsafe.AsPointer(ref this), results);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT GetResults([NativeTypeName("TResult_abi *")] Ref<TResult> results)
    {
        fixed (TResult* __dsl_results = results)
        {
            return (HRESULT)GetResults(__dsl_results);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IAsyncOperationWithProgress<TResult, TProgress>*, HSTRING*, int>)(
                lpVtbl[4]
            )
        )((IAsyncOperationWithProgress<TResult, TProgress>*)Unsafe.AsPointer(ref this), className);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT GetRuntimeClassName(Ref<HSTRING> className)
    {
        fixed (HSTRING* __dsl_className = className)
        {
            return (HRESULT)GetRuntimeClassName(__dsl_className);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<
                IAsyncOperationWithProgress<TResult, TProgress>*,
                TrustLevel*,
                int>)(lpVtbl[5])
        )((IAsyncOperationWithProgress<TResult, TProgress>*)Unsafe.AsPointer(ref this), trustLevel);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT GetTrustLevel([NativeTypeName("TrustLevel *")] Ref<TrustLevel> trustLevel)
    {
        fixed (TrustLevel* __dsl_trustLevel = trustLevel)
        {
            return (HRESULT)GetTrustLevel(__dsl_trustLevel);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT put_Completed(
        [NativeTypeName(
            "IAsyncOperationWithProgressCompletedHandler<TResult_logical, TProgress_logical> *"
        )]
            IAsyncOperationWithProgressCompletedHandler<TResult, TProgress>* handler
    )
    {
        return (
            (delegate* unmanaged<
                IAsyncOperationWithProgress<TResult, TProgress>*,
                IAsyncOperationWithProgressCompletedHandler<TResult, TProgress>*,
                int>)(lpVtbl[8])
        )((IAsyncOperationWithProgress<TResult, TProgress>*)Unsafe.AsPointer(ref this), handler);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT put_Completed(
        [NativeTypeName(
            "IAsyncOperationWithProgressCompletedHandler<TResult_logical, TProgress_logical> *"
        )]
            Ref<IAsyncOperationWithProgressCompletedHandler<TResult, TProgress>> handler
    )
    {
        fixed (
            IAsyncOperationWithProgressCompletedHandler<TResult, TProgress>* __dsl_handler = handler
        )
        {
            return (HRESULT)put_Completed(__dsl_handler);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT put_Progress(
        [NativeTypeName("IAsyncOperationProgressHandler<TResult_logical, TProgress_logical> *")]
            IAsyncOperationProgressHandler<TResult, TProgress>* handler
    )
    {
        return (
            (delegate* unmanaged<
                IAsyncOperationWithProgress<TResult, TProgress>*,
                IAsyncOperationProgressHandler<TResult, TProgress>*,
                int>)(lpVtbl[6])
        )((IAsyncOperationWithProgress<TResult, TProgress>*)Unsafe.AsPointer(ref this), handler);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT put_Progress(
        [NativeTypeName("IAsyncOperationProgressHandler<TResult_logical, TProgress_logical> *")]
            Ref<IAsyncOperationProgressHandler<TResult, TProgress>> handler
    )
    {
        fixed (IAsyncOperationProgressHandler<TResult, TProgress>* __dsl_handler = handler)
        {
            return (HRESULT)put_Progress(__dsl_handler);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT QueryInterface(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("void **")] void** ppvObject
    )
    {
        return (
            (delegate* unmanaged<
                IAsyncOperationWithProgress<TResult, TProgress>*,
                Guid*,
                void**,
                int>)(lpVtbl[0])
        )(
            (IAsyncOperationWithProgress<TResult, TProgress>*)Unsafe.AsPointer(ref this),
            riid,
            ppvObject
        );
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
        return (
            (delegate* unmanaged<IAsyncOperationWithProgress<TResult, TProgress>*, uint>)(lpVtbl[2])
        )((IAsyncOperationWithProgress<TResult, TProgress>*)Unsafe.AsPointer(ref this));
    }
}
