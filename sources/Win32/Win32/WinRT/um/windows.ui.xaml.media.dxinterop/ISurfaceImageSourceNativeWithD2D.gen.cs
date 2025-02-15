// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("54298223-41E1-4A41-9C08-02E8256864A1")]
[NativeTypeName("struct ISurfaceImageSourceNativeWithD2D : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct ISurfaceImageSourceNativeWithD2D
    : ISurfaceImageSourceNativeWithD2D.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISurfaceImageSourceNativeWithD2D));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISurfaceImageSourceNativeWithD2D, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISurfaceImageSourceNativeWithD2D, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISurfaceImageSourceNativeWithD2D, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetDevice(IUnknown device)
    {
        return (
            (delegate* unmanaged<ISurfaceImageSourceNativeWithD2D, IUnknown, int>)((*lpVtbl)[3])
        )(this, device);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT BeginDraw(
        [NativeTypeName("const RECT &")] RECT* updateRect,
        [NativeTypeName("const IID &")] Guid* iid,
        void** updateObject,
        POINT* offset
    )
    {
        return (
            (delegate* unmanaged<
                ISurfaceImageSourceNativeWithD2D,
                RECT*,
                Guid*,
                void**,
                POINT*,
                int>)((*lpVtbl)[4])
        )(this, updateRect, iid, updateObject, offset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EndDraw()
    {
        return ((delegate* unmanaged<ISurfaceImageSourceNativeWithD2D, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SuspendDraw()
    {
        return ((delegate* unmanaged<ISurfaceImageSourceNativeWithD2D, int>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ResumeDraw()
    {
        return ((delegate* unmanaged<ISurfaceImageSourceNativeWithD2D, int>)((*lpVtbl)[7]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetDevice(IUnknown device);

        [VtblIndex(4)]
        HRESULT BeginDraw(
            [NativeTypeName("const RECT &")] RECT* updateRect,
            [NativeTypeName("const IID &")] Guid* iid,
            void** updateObject,
            POINT* offset
        );

        [VtblIndex(5)]
        HRESULT EndDraw();

        [VtblIndex(6)]
        HRESULT SuspendDraw();

        [VtblIndex(7)]
        HRESULT ResumeDraw();
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

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> SetDevice;

        [NativeTypeName(
            "HRESULT (const RECT &, const IID &, void **, POINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, RECT*, Guid*, void**, POINT*, int> BeginDraw;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EndDraw;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SuspendDraw;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ResumeDraw;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISurfaceImageSourceNativeWithD2D"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISurfaceImageSourceNativeWithD2D(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISurfaceImageSourceNativeWithD2D"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISurfaceImageSourceNativeWithD2D(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ISurfaceImageSourceNativeWithD2D(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISurfaceImageSourceNativeWithD2D"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISurfaceImageSourceNativeWithD2D"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ISurfaceImageSourceNativeWithD2D value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
