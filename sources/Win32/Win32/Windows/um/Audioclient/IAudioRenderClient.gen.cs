// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("F294ACFC-3146-4483-A7BF-ADDCA7C260E2")]
[NativeTypeName("struct IAudioRenderClient : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioRenderClient : IAudioRenderClient.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioRenderClient));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioRenderClient, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAudioRenderClient, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioRenderClient, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetBuffer([NativeTypeName("UINT32")] uint NumFramesRequested, byte** ppData)
    {
        return ((delegate* unmanaged<IAudioRenderClient, uint, byte**, int>)((*lpVtbl)[3]))(
            this,
            NumFramesRequested,
            ppData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ReleaseBuffer(
        [NativeTypeName("UINT32")] uint NumFramesWritten,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        return ((delegate* unmanaged<IAudioRenderClient, uint, uint, int>)((*lpVtbl)[4]))(
            this,
            NumFramesWritten,
            dwFlags
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetBuffer([NativeTypeName("UINT32")] uint NumFramesRequested, byte** ppData);

        [VtblIndex(4)]
        HRESULT ReleaseBuffer(
            [NativeTypeName("UINT32")] uint NumFramesWritten,
            [NativeTypeName("DWORD")] uint dwFlags
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

        [NativeTypeName("HRESULT (UINT32, BYTE **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte**, int> GetBuffer;

        [NativeTypeName("HRESULT (UINT32, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> ReleaseBuffer;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioRenderClient"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioRenderClient(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioRenderClient"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioRenderClient(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioRenderClient(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioRenderClient"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioRenderClient"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioRenderClient value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
