// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("913337E9-11A1-4345-A3A2-4E7F956E222D")]
public unsafe partial struct IVector<T>
    where T : unmanaged
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVector<T>*, uint>)(lpVtbl[1]))(
            (IVector<T>*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT Append([NativeTypeName("T_abi")] T item)
    {
        return ((delegate* unmanaged<IVector<T>*, T, int>)(lpVtbl[13]))(
            (IVector<T>*)Unsafe.AsPointer(ref this),
            item
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT Clear()
    {
        return ((delegate* unmanaged<IVector<T>*, int>)(lpVtbl[15]))(
            (IVector<T>*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT get_Size([NativeTypeName("unsigned *")] uint* size)
    {
        return ((delegate* unmanaged<IVector<T>*, uint*, int>)(lpVtbl[7]))(
            (IVector<T>*)Unsafe.AsPointer(ref this),
            size
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT get_Size([NativeTypeName("unsigned *")] Ref<uint> size)
    {
        fixed (uint* __dsl_size = size)
        {
            return (HRESULT)get_Size(__dsl_size);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetAt(
        [NativeTypeName("unsigned")] uint index,
        [NativeTypeName("T_abi *")] T* item
    )
    {
        return ((delegate* unmanaged<IVector<T>*, uint, T*, int>)(lpVtbl[6]))(
            (IVector<T>*)Unsafe.AsPointer(ref this),
            index,
            item
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT GetAt(
        [NativeTypeName("unsigned")] uint index,
        [NativeTypeName("T_abi *")] Ref<T> item
    )
    {
        fixed (T* __dsl_item = item)
        {
            return (HRESULT)GetAt(index, __dsl_item);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IVector<T>*, uint*, Guid**, int>)(lpVtbl[3]))(
            (IVector<T>*)Unsafe.AsPointer(ref this),
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
    public HRESULT GetMany(
        [NativeTypeName("unsigned")] uint startIndex,
        [NativeTypeName("unsigned")] uint capacity,
        [NativeTypeName("T_abi *")] T* value,
        [NativeTypeName("unsigned *")] uint* actual
    )
    {
        return ((delegate* unmanaged<IVector<T>*, uint, uint, T*, uint*, int>)(lpVtbl[16]))(
            (IVector<T>*)Unsafe.AsPointer(ref this),
            startIndex,
            capacity,
            value,
            actual
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT GetMany(
        [NativeTypeName("unsigned")] uint startIndex,
        [NativeTypeName("unsigned")] uint capacity,
        [NativeTypeName("T_abi *")] Ref<T> value,
        [NativeTypeName("unsigned *")] Ref<uint> actual
    )
    {
        fixed (uint* __dsl_actual = actual)
        fixed (T* __dsl_value = value)
        {
            return (HRESULT)GetMany(startIndex, capacity, __dsl_value, __dsl_actual);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IVector<T>*, HSTRING*, int>)(lpVtbl[4]))(
            (IVector<T>*)Unsafe.AsPointer(ref this),
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
        return ((delegate* unmanaged<IVector<T>*, TrustLevel*, int>)(lpVtbl[5]))(
            (IVector<T>*)Unsafe.AsPointer(ref this),
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
    public HRESULT GetView([NativeTypeName("IVectorView<T_logical> **")] IVectorView<T>** view)
    {
        return ((delegate* unmanaged<IVector<T>*, IVectorView<T>**, int>)(lpVtbl[8]))(
            (IVector<T>*)Unsafe.AsPointer(ref this),
            view
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT GetView([NativeTypeName("IVectorView<T_logical> **")] Ref2D<IVectorView<T>> view)
    {
        fixed (IVectorView<T>** __dsl_view = view)
        {
            return (HRESULT)GetView(__dsl_view);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT IndexOf(
        [NativeTypeName("T_abi")] T value,
        [NativeTypeName("unsigned *")] uint* index,
        [NativeTypeName("boolean *")] byte* found
    )
    {
        return ((delegate* unmanaged<IVector<T>*, T, uint*, byte*, int>)(lpVtbl[9]))(
            (IVector<T>*)Unsafe.AsPointer(ref this),
            value,
            index,
            found
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT IndexOf(
        [NativeTypeName("T_abi")] T value,
        [NativeTypeName("unsigned *")] Ref<uint> index,
        [NativeTypeName("boolean *")] Ref<byte> found
    )
    {
        fixed (byte* __dsl_found = found)
        fixed (uint* __dsl_index = index)
        {
            return (HRESULT)IndexOf(value, __dsl_index, __dsl_found);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT InsertAt(
        [NativeTypeName("unsigned")] uint index,
        [NativeTypeName("T_abi")] T item
    )
    {
        return ((delegate* unmanaged<IVector<T>*, uint, T, int>)(lpVtbl[11]))(
            (IVector<T>*)Unsafe.AsPointer(ref this),
            index,
            item
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT QueryInterface(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("void **")] void** ppvObject
    )
    {
        return ((delegate* unmanaged<IVector<T>*, Guid*, void**, int>)(lpVtbl[0]))(
            (IVector<T>*)Unsafe.AsPointer(ref this),
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
        return ((delegate* unmanaged<IVector<T>*, uint>)(lpVtbl[2]))(
            (IVector<T>*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT RemoveAt([NativeTypeName("unsigned")] uint index)
    {
        return ((delegate* unmanaged<IVector<T>*, uint, int>)(lpVtbl[12]))(
            (IVector<T>*)Unsafe.AsPointer(ref this),
            index
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT RemoveAtEnd()
    {
        return ((delegate* unmanaged<IVector<T>*, int>)(lpVtbl[14]))(
            (IVector<T>*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT ReplaceAll(
        [NativeTypeName("unsigned")] uint count,
        [NativeTypeName("T_abi *")] T* value
    )
    {
        return ((delegate* unmanaged<IVector<T>*, uint, T*, int>)(lpVtbl[17]))(
            (IVector<T>*)Unsafe.AsPointer(ref this),
            count,
            value
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT ReplaceAll(
        [NativeTypeName("unsigned")] uint count,
        [NativeTypeName("T_abi *")] Ref<T> value
    )
    {
        fixed (T* __dsl_value = value)
        {
            return (HRESULT)ReplaceAll(count, __dsl_value);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT SetAt([NativeTypeName("unsigned")] uint index, [NativeTypeName("T_abi")] T item)
    {
        return ((delegate* unmanaged<IVector<T>*, uint, T, int>)(lpVtbl[10]))(
            (IVector<T>*)Unsafe.AsPointer(ref this),
            index,
            item
        );
    }
}
