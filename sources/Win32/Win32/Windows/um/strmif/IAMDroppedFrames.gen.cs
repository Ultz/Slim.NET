// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C6E13344-30AC-11D0-A18C-00A0C9118956")]
[NativeTypeName("struct IAMDroppedFrames : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMDroppedFrames : IAMDroppedFrames.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMDroppedFrames));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMDroppedFrames, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAMDroppedFrames, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMDroppedFrames, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetNumDropped([NativeTypeName("long *")] int* plDropped)
    {
        return ((delegate* unmanaged<IAMDroppedFrames, int*, int>)((*lpVtbl)[3]))(this, plDropped);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetNumNotDropped([NativeTypeName("long *")] int* plNotDropped)
    {
        return ((delegate* unmanaged<IAMDroppedFrames, int*, int>)((*lpVtbl)[4]))(
            this,
            plNotDropped
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDroppedInfo(
        [NativeTypeName("long")] int lSize,
        [NativeTypeName("long *")] int* plArray,
        [NativeTypeName("long *")] int* plNumCopied
    )
    {
        return ((delegate* unmanaged<IAMDroppedFrames, int, int*, int*, int>)((*lpVtbl)[5]))(
            this,
            lSize,
            plArray,
            plNumCopied
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAverageFrameSize([NativeTypeName("long *")] int* plAverageSize)
    {
        return ((delegate* unmanaged<IAMDroppedFrames, int*, int>)((*lpVtbl)[6]))(
            this,
            plAverageSize
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetNumDropped([NativeTypeName("long *")] int* plDropped);

        [VtblIndex(4)]
        HRESULT GetNumNotDropped([NativeTypeName("long *")] int* plNotDropped);

        [VtblIndex(5)]
        HRESULT GetDroppedInfo(
            [NativeTypeName("long")] int lSize,
            [NativeTypeName("long *")] int* plArray,
            [NativeTypeName("long *")] int* plNumCopied
        );

        [VtblIndex(6)]
        HRESULT GetAverageFrameSize([NativeTypeName("long *")] int* plAverageSize);
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

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetNumDropped;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetNumNotDropped;

        [NativeTypeName("HRESULT (long, long *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int*, int*, int> GetDroppedInfo;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetAverageFrameSize;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAMDroppedFrames"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAMDroppedFrames(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAMDroppedFrames"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAMDroppedFrames(Silk.NET.Windows.IUnknown value)
    {
        return new IAMDroppedFrames(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAMDroppedFrames"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAMDroppedFrames"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAMDroppedFrames value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
