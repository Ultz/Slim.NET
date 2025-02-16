// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("E480CE40-A338-4ADA-ADCF-272272E48CB9")]
public unsafe partial struct IMapView<K, V>
    where K : unmanaged
    where V : unmanaged
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMapView<K, V>*, uint>)(lpVtbl[1]))(
            (IMapView<K, V>*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT get_Size([NativeTypeName("unsigned int *")] uint* size)
    {
        return ((delegate* unmanaged<IMapView<K, V>*, uint*, int>)(lpVtbl[7]))(
            (IMapView<K, V>*)Unsafe.AsPointer(ref this),
            size
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT get_Size([NativeTypeName("unsigned int *")] Ref<uint> size)
    {
        fixed (uint* __dsl_size = size)
        {
            return (HRESULT)get_Size(__dsl_size);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMapView<K, V>*, uint*, Guid**, int>)(lpVtbl[3]))(
            (IMapView<K, V>*)Unsafe.AsPointer(ref this),
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
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMapView<K, V>*, HSTRING*, int>)(lpVtbl[4]))(
            (IMapView<K, V>*)Unsafe.AsPointer(ref this),
            className
        );
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
        return ((delegate* unmanaged<IMapView<K, V>*, TrustLevel*, int>)(lpVtbl[5]))(
            (IMapView<K, V>*)Unsafe.AsPointer(ref this),
            trustLevel
        );
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
    public HRESULT HasKey(
        [NativeTypeName("T_abi")] K key,
        [NativeTypeName("boolean *")] byte* found
    )
    {
        return ((delegate* unmanaged<IMapView<K, V>*, K, byte*, int>)(lpVtbl[8]))(
            (IMapView<K, V>*)Unsafe.AsPointer(ref this),
            key,
            found
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT HasKey(
        [NativeTypeName("T_abi")] K key,
        [NativeTypeName("boolean *")] Ref<byte> found
    )
    {
        fixed (byte* __dsl_found = found)
        {
            return (HRESULT)HasKey(key, __dsl_found);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT Lookup([NativeTypeName("K_abi")] K key, [NativeTypeName("V_abi *")] V* value)
    {
        return ((delegate* unmanaged<IMapView<K, V>*, K, V*, int>)(lpVtbl[6]))(
            (IMapView<K, V>*)Unsafe.AsPointer(ref this),
            key,
            value
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT Lookup([NativeTypeName("K_abi")] K key, [NativeTypeName("V_abi *")] Ref<V> value)
    {
        fixed (V* __dsl_value = value)
        {
            return (HRESULT)Lookup(key, __dsl_value);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT QueryInterface(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("void **")] void** ppvObject
    )
    {
        return ((delegate* unmanaged<IMapView<K, V>*, Guid*, void**, int>)(lpVtbl[0]))(
            (IMapView<K, V>*)Unsafe.AsPointer(ref this),
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
        return ((delegate* unmanaged<IMapView<K, V>*, uint>)(lpVtbl[2]))(
            (IMapView<K, V>*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT Split(
        [NativeTypeName("IMapView<K_logical, V_logical> **")] IMapView<K, V>** firstPartition,
        [NativeTypeName("IMapView<K_logical, V_logical> **")] IMapView<K, V>** secondPartition
    )
    {
        return (
            (delegate* unmanaged<IMapView<K, V>*, IMapView<K, V>**, IMapView<K, V>**, int>)(
                lpVtbl[9]
            )
        )((IMapView<K, V>*)Unsafe.AsPointer(ref this), firstPartition, secondPartition);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT Split(
        [NativeTypeName("IMapView<K_logical, V_logical> **")] Ref2D<IMapView<K, V>> firstPartition,
        [NativeTypeName("IMapView<K_logical, V_logical> **")] Ref2D<IMapView<K, V>> secondPartition
    )
    {
        fixed (IMapView<K, V>** __dsl_secondPartition = secondPartition)
        fixed (IMapView<K, V>** __dsl_firstPartition = firstPartition)
        {
            return (HRESULT)Split(__dsl_firstPartition, __dsl_secondPartition);
        }
    }
}
