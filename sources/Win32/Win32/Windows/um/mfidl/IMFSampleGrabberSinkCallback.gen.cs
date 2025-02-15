// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("8C7B80BF-EE42-4B59-B1DF-55668E1BDCA8")]
[NativeTypeName("struct IMFSampleGrabberSinkCallback : IMFClockStateSink")]
[NativeInheritance("IMFClockStateSink")]
public unsafe partial struct IMFSampleGrabberSinkCallback
    : IMFSampleGrabberSinkCallback.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSampleGrabberSinkCallback));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMFSampleGrabberSinkCallback, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFSampleGrabberSinkCallback, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSampleGrabberSinkCallback, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnClockStart(
        [NativeTypeName("MFTIME")] long hnsSystemTime,
        [NativeTypeName("LONGLONG")] long llClockStartOffset
    )
    {
        return ((delegate* unmanaged<IMFSampleGrabberSinkCallback, long, long, int>)((*lpVtbl)[3]))(
            this,
            hnsSystemTime,
            llClockStartOffset
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnClockStop([NativeTypeName("MFTIME")] long hnsSystemTime)
    {
        return ((delegate* unmanaged<IMFSampleGrabberSinkCallback, long, int>)((*lpVtbl)[4]))(
            this,
            hnsSystemTime
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnClockPause([NativeTypeName("MFTIME")] long hnsSystemTime)
    {
        return ((delegate* unmanaged<IMFSampleGrabberSinkCallback, long, int>)((*lpVtbl)[5]))(
            this,
            hnsSystemTime
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnClockRestart([NativeTypeName("MFTIME")] long hnsSystemTime)
    {
        return ((delegate* unmanaged<IMFSampleGrabberSinkCallback, long, int>)((*lpVtbl)[6]))(
            this,
            hnsSystemTime
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnClockSetRate([NativeTypeName("MFTIME")] long hnsSystemTime, float flRate)
    {
        return (
            (delegate* unmanaged<IMFSampleGrabberSinkCallback, long, float, int>)((*lpVtbl)[7])
        )(this, hnsSystemTime, flRate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT OnSetPresentationClock(IMFPresentationClock pPresentationClock)
    {
        return (
            (delegate* unmanaged<IMFSampleGrabberSinkCallback, IMFPresentationClock, int>)(
                (*lpVtbl)[8]
            )
        )(this, pPresentationClock);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT OnProcessSample(
        [NativeTypeName("const GUID &")] Guid* guidMajorMediaType,
        [NativeTypeName("DWORD")] uint dwSampleFlags,
        [NativeTypeName("LONGLONG")] long llSampleTime,
        [NativeTypeName("LONGLONG")] long llSampleDuration,
        [NativeTypeName("const BYTE *")] byte* pSampleBuffer,
        [NativeTypeName("DWORD")] uint dwSampleSize
    )
    {
        return (
            (delegate* unmanaged<
                IMFSampleGrabberSinkCallback,
                Guid*,
                uint,
                long,
                long,
                byte*,
                uint,
                int>)((*lpVtbl)[9])
        )(
            this,
            guidMajorMediaType,
            dwSampleFlags,
            llSampleTime,
            llSampleDuration,
            pSampleBuffer,
            dwSampleSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT OnShutdown()
    {
        return ((delegate* unmanaged<IMFSampleGrabberSinkCallback, int>)((*lpVtbl)[10]))(this);
    }

    public interface Interface : IMFClockStateSink.Interface
    {
        [VtblIndex(8)]
        HRESULT OnSetPresentationClock(IMFPresentationClock pPresentationClock);

        [VtblIndex(9)]
        HRESULT OnProcessSample(
            [NativeTypeName("const GUID &")] Guid* guidMajorMediaType,
            [NativeTypeName("DWORD")] uint dwSampleFlags,
            [NativeTypeName("LONGLONG")] long llSampleTime,
            [NativeTypeName("LONGLONG")] long llSampleDuration,
            [NativeTypeName("const BYTE *")] byte* pSampleBuffer,
            [NativeTypeName("DWORD")] uint dwSampleSize
        );

        [VtblIndex(10)]
        HRESULT OnShutdown();
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

        [NativeTypeName("HRESULT (MFTIME, LONGLONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, long, int> OnClockStart;

        [NativeTypeName("HRESULT (MFTIME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, int> OnClockStop;

        [NativeTypeName("HRESULT (MFTIME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, int> OnClockPause;

        [NativeTypeName("HRESULT (MFTIME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, int> OnClockRestart;

        [NativeTypeName("HRESULT (MFTIME, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, float, int> OnClockSetRate;

        [NativeTypeName("HRESULT (IMFPresentationClock *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFPresentationClock, int> OnSetPresentationClock;

        [NativeTypeName(
            "HRESULT (const GUID &, DWORD, LONGLONG, LONGLONG, const BYTE *, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            uint,
            long,
            long,
            byte*,
            uint,
            int> OnProcessSample;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnShutdown;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFSampleGrabberSinkCallback"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFSampleGrabberSinkCallback(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMFClockStateSink"/> to <see cref = "IMFSampleGrabberSinkCallback"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMFClockStateSink"/> instance to be converted </param>
    public static explicit operator IMFSampleGrabberSinkCallback(
        Silk.NET.Windows.IMFClockStateSink value
    )
    {
        return new IMFSampleGrabberSinkCallback(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFSampleGrabberSinkCallback"/> to <see cref = "Silk.NET.Windows.IMFClockStateSink"/>.</summary>
    /// <param name = "value">The <see cref = "IMFSampleGrabberSinkCallback"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMFClockStateSink(
        IMFSampleGrabberSinkCallback value
    )
    {
        return new Silk.NET.Windows.IMFClockStateSink(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFSampleGrabberSinkCallback"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFSampleGrabberSinkCallback(Silk.NET.Windows.IUnknown value)
    {
        return new IMFSampleGrabberSinkCallback(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFSampleGrabberSinkCallback"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFSampleGrabberSinkCallback"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFSampleGrabberSinkCallback value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
