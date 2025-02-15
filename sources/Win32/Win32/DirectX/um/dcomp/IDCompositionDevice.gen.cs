// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("C37EA93A-E7AA-450D-B16F-9746CB0407F3")]
[NativeTypeName("struct IDCompositionDevice : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDCompositionDevice : IDCompositionDevice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionDevice));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDCompositionDevice, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDCompositionDevice, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionDevice, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Commit()
    {
        return ((delegate* unmanaged<IDCompositionDevice, int>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT WaitForCommitCompletion()
    {
        return ((delegate* unmanaged<IDCompositionDevice, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetFrameStatistics(DCOMPOSITION_FRAME_STATISTICS* statistics)
    {
        return (
            (delegate* unmanaged<IDCompositionDevice, DCOMPOSITION_FRAME_STATISTICS*, int>)(
                (*lpVtbl)[5]
            )
        )(this, statistics);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateTargetForHwnd(HWND hwnd, BOOL topmost, IDCompositionTarget* target)
    {
        return (
            (delegate* unmanaged<IDCompositionDevice, HWND, BOOL, IDCompositionTarget*, int>)(
                (*lpVtbl)[6]
            )
        )(this, hwnd, topmost, target);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateVisual(IDCompositionVisual* visual)
    {
        return (
            (delegate* unmanaged<IDCompositionDevice, IDCompositionVisual*, int>)((*lpVtbl)[7])
        )(this, visual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateSurface(
        uint width,
        uint height,
        DXGI_FORMAT pixelFormat,
        DXGI_ALPHA_MODE alphaMode,
        IDCompositionSurface* surface
    )
    {
        return (
            (delegate* unmanaged<
                IDCompositionDevice,
                uint,
                uint,
                DXGI_FORMAT,
                DXGI_ALPHA_MODE,
                IDCompositionSurface*,
                int>)((*lpVtbl)[8])
        )(this, width, height, pixelFormat, alphaMode, surface);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateVirtualSurface(
        uint initialWidth,
        uint initialHeight,
        DXGI_FORMAT pixelFormat,
        DXGI_ALPHA_MODE alphaMode,
        IDCompositionVirtualSurface* virtualSurface
    )
    {
        return (
            (delegate* unmanaged<
                IDCompositionDevice,
                uint,
                uint,
                DXGI_FORMAT,
                DXGI_ALPHA_MODE,
                IDCompositionVirtualSurface*,
                int>)((*lpVtbl)[9])
        )(this, initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurface);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateSurfaceFromHandle(HANDLE handle, IUnknown* surface)
    {
        return ((delegate* unmanaged<IDCompositionDevice, HANDLE, IUnknown*, int>)((*lpVtbl)[10]))(
            this,
            handle,
            surface
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateSurfaceFromHwnd(HWND hwnd, IUnknown* surface)
    {
        return ((delegate* unmanaged<IDCompositionDevice, HWND, IUnknown*, int>)((*lpVtbl)[11]))(
            this,
            hwnd,
            surface
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateTranslateTransform(IDCompositionTranslateTransform* translateTransform)
    {
        return (
            (delegate* unmanaged<IDCompositionDevice, IDCompositionTranslateTransform*, int>)(
                (*lpVtbl)[12]
            )
        )(this, translateTransform);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateScaleTransform(IDCompositionScaleTransform* scaleTransform)
    {
        return (
            (delegate* unmanaged<IDCompositionDevice, IDCompositionScaleTransform*, int>)(
                (*lpVtbl)[13]
            )
        )(this, scaleTransform);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateRotateTransform(IDCompositionRotateTransform* rotateTransform)
    {
        return (
            (delegate* unmanaged<IDCompositionDevice, IDCompositionRotateTransform*, int>)(
                (*lpVtbl)[14]
            )
        )(this, rotateTransform);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateSkewTransform(IDCompositionSkewTransform* skewTransform)
    {
        return (
            (delegate* unmanaged<IDCompositionDevice, IDCompositionSkewTransform*, int>)(
                (*lpVtbl)[15]
            )
        )(this, skewTransform);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateMatrixTransform(IDCompositionMatrixTransform* matrixTransform)
    {
        return (
            (delegate* unmanaged<IDCompositionDevice, IDCompositionMatrixTransform*, int>)(
                (*lpVtbl)[16]
            )
        )(this, matrixTransform);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CreateTransformGroup(
        IDCompositionTransform* transforms,
        uint elements,
        IDCompositionTransform* transformGroup
    )
    {
        return (
            (delegate* unmanaged<
                IDCompositionDevice,
                IDCompositionTransform*,
                uint,
                IDCompositionTransform*,
                int>)((*lpVtbl)[17])
        )(this, transforms, elements, transformGroup);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreateTranslateTransform3D(
        IDCompositionTranslateTransform3D* translateTransform3D
    )
    {
        return (
            (delegate* unmanaged<IDCompositionDevice, IDCompositionTranslateTransform3D*, int>)(
                (*lpVtbl)[18]
            )
        )(this, translateTransform3D);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT CreateScaleTransform3D(IDCompositionScaleTransform3D* scaleTransform3D)
    {
        return (
            (delegate* unmanaged<IDCompositionDevice, IDCompositionScaleTransform3D*, int>)(
                (*lpVtbl)[19]
            )
        )(this, scaleTransform3D);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT CreateRotateTransform3D(IDCompositionRotateTransform3D* rotateTransform3D)
    {
        return (
            (delegate* unmanaged<IDCompositionDevice, IDCompositionRotateTransform3D*, int>)(
                (*lpVtbl)[20]
            )
        )(this, rotateTransform3D);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT CreateMatrixTransform3D(IDCompositionMatrixTransform3D* matrixTransform3D)
    {
        return (
            (delegate* unmanaged<IDCompositionDevice, IDCompositionMatrixTransform3D*, int>)(
                (*lpVtbl)[21]
            )
        )(this, matrixTransform3D);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT CreateTransform3DGroup(
        IDCompositionTransform3D* transforms3D,
        uint elements,
        IDCompositionTransform3D* transform3DGroup
    )
    {
        return (
            (delegate* unmanaged<
                IDCompositionDevice,
                IDCompositionTransform3D*,
                uint,
                IDCompositionTransform3D*,
                int>)((*lpVtbl)[22])
        )(this, transforms3D, elements, transform3DGroup);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT CreateEffectGroup(IDCompositionEffectGroup* effectGroup)
    {
        return (
            (delegate* unmanaged<IDCompositionDevice, IDCompositionEffectGroup*, int>)(
                (*lpVtbl)[23]
            )
        )(this, effectGroup);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT CreateRectangleClip(IDCompositionRectangleClip* clip)
    {
        return (
            (delegate* unmanaged<IDCompositionDevice, IDCompositionRectangleClip*, int>)(
                (*lpVtbl)[24]
            )
        )(this, clip);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT CreateAnimation(IDCompositionAnimation* animation)
    {
        return (
            (delegate* unmanaged<IDCompositionDevice, IDCompositionAnimation*, int>)((*lpVtbl)[25])
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT CheckDeviceState(BOOL* pfValid)
    {
        return ((delegate* unmanaged<IDCompositionDevice, BOOL*, int>)((*lpVtbl)[26]))(
            this,
            pfValid
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Commit();

        [VtblIndex(4)]
        HRESULT WaitForCommitCompletion();

        [VtblIndex(5)]
        HRESULT GetFrameStatistics(DCOMPOSITION_FRAME_STATISTICS* statistics);

        [VtblIndex(6)]
        HRESULT CreateTargetForHwnd(HWND hwnd, BOOL topmost, IDCompositionTarget* target);

        [VtblIndex(7)]
        HRESULT CreateVisual(IDCompositionVisual* visual);

        [VtblIndex(8)]
        HRESULT CreateSurface(
            uint width,
            uint height,
            DXGI_FORMAT pixelFormat,
            DXGI_ALPHA_MODE alphaMode,
            IDCompositionSurface* surface
        );

        [VtblIndex(9)]
        HRESULT CreateVirtualSurface(
            uint initialWidth,
            uint initialHeight,
            DXGI_FORMAT pixelFormat,
            DXGI_ALPHA_MODE alphaMode,
            IDCompositionVirtualSurface* virtualSurface
        );

        [VtblIndex(10)]
        HRESULT CreateSurfaceFromHandle(HANDLE handle, IUnknown* surface);

        [VtblIndex(11)]
        HRESULT CreateSurfaceFromHwnd(HWND hwnd, IUnknown* surface);

        [VtblIndex(12)]
        HRESULT CreateTranslateTransform(IDCompositionTranslateTransform* translateTransform);

        [VtblIndex(13)]
        HRESULT CreateScaleTransform(IDCompositionScaleTransform* scaleTransform);

        [VtblIndex(14)]
        HRESULT CreateRotateTransform(IDCompositionRotateTransform* rotateTransform);

        [VtblIndex(15)]
        HRESULT CreateSkewTransform(IDCompositionSkewTransform* skewTransform);

        [VtblIndex(16)]
        HRESULT CreateMatrixTransform(IDCompositionMatrixTransform* matrixTransform);

        [VtblIndex(17)]
        HRESULT CreateTransformGroup(
            IDCompositionTransform* transforms,
            uint elements,
            IDCompositionTransform* transformGroup
        );

        [VtblIndex(18)]
        HRESULT CreateTranslateTransform3D(IDCompositionTranslateTransform3D* translateTransform3D);

        [VtblIndex(19)]
        HRESULT CreateScaleTransform3D(IDCompositionScaleTransform3D* scaleTransform3D);

        [VtblIndex(20)]
        HRESULT CreateRotateTransform3D(IDCompositionRotateTransform3D* rotateTransform3D);

        [VtblIndex(21)]
        HRESULT CreateMatrixTransform3D(IDCompositionMatrixTransform3D* matrixTransform3D);

        [VtblIndex(22)]
        HRESULT CreateTransform3DGroup(
            IDCompositionTransform3D* transforms3D,
            uint elements,
            IDCompositionTransform3D* transform3DGroup
        );

        [VtblIndex(23)]
        HRESULT CreateEffectGroup(IDCompositionEffectGroup* effectGroup);

        [VtblIndex(24)]
        HRESULT CreateRectangleClip(IDCompositionRectangleClip* clip);

        [VtblIndex(25)]
        HRESULT CreateAnimation(IDCompositionAnimation* animation);

        [VtblIndex(26)]
        HRESULT CheckDeviceState(BOOL* pfValid);
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

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Commit;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> WaitForCommitCompletion;

        [NativeTypeName(
            "HRESULT (DCOMPOSITION_FRAME_STATISTICS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DCOMPOSITION_FRAME_STATISTICS*, int> GetFrameStatistics;

        [NativeTypeName(
            "HRESULT (HWND, BOOL, IDCompositionTarget **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HWND,
            BOOL,
            IDCompositionTarget*,
            int> CreateTargetForHwnd;

        [NativeTypeName(
            "HRESULT (IDCompositionVisual **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionVisual*, int> CreateVisual;

        [NativeTypeName(
            "HRESULT (UINT, UINT, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionSurface **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            DXGI_FORMAT,
            DXGI_ALPHA_MODE,
            IDCompositionSurface*,
            int> CreateSurface;

        [NativeTypeName(
            "HRESULT (UINT, UINT, DXGI_FORMAT, DXGI_ALPHA_MODE, IDCompositionVirtualSurface **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            DXGI_FORMAT,
            DXGI_ALPHA_MODE,
            IDCompositionVirtualSurface*,
            int> CreateVirtualSurface;

        [NativeTypeName(
            "HRESULT (HANDLE, IUnknown **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HANDLE, IUnknown*, int> CreateSurfaceFromHandle;

        [NativeTypeName(
            "HRESULT (HWND, IUnknown **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HWND, IUnknown*, int> CreateSurfaceFromHwnd;

        [NativeTypeName(
            "HRESULT (IDCompositionTranslateTransform **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDCompositionTranslateTransform*,
            int> CreateTranslateTransform;

        [NativeTypeName(
            "HRESULT (IDCompositionScaleTransform **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionScaleTransform*, int> CreateScaleTransform;

        [NativeTypeName(
            "HRESULT (IDCompositionRotateTransform **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDCompositionRotateTransform*,
            int> CreateRotateTransform;

        [NativeTypeName(
            "HRESULT (IDCompositionSkewTransform **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionSkewTransform*, int> CreateSkewTransform;

        [NativeTypeName(
            "HRESULT (IDCompositionMatrixTransform **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDCompositionMatrixTransform*,
            int> CreateMatrixTransform;

        [NativeTypeName(
            "HRESULT (IDCompositionTransform **, UINT, IDCompositionTransform **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDCompositionTransform*,
            uint,
            IDCompositionTransform*,
            int> CreateTransformGroup;

        [NativeTypeName(
            "HRESULT (IDCompositionTranslateTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDCompositionTranslateTransform3D*,
            int> CreateTranslateTransform3D;

        [NativeTypeName(
            "HRESULT (IDCompositionScaleTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDCompositionScaleTransform3D*,
            int> CreateScaleTransform3D;

        [NativeTypeName(
            "HRESULT (IDCompositionRotateTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDCompositionRotateTransform3D*,
            int> CreateRotateTransform3D;

        [NativeTypeName(
            "HRESULT (IDCompositionMatrixTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDCompositionMatrixTransform3D*,
            int> CreateMatrixTransform3D;

        [NativeTypeName(
            "HRESULT (IDCompositionTransform3D **, UINT, IDCompositionTransform3D **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDCompositionTransform3D*,
            uint,
            IDCompositionTransform3D*,
            int> CreateTransform3DGroup;

        [NativeTypeName(
            "HRESULT (IDCompositionEffectGroup **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionEffectGroup*, int> CreateEffectGroup;

        [NativeTypeName(
            "HRESULT (IDCompositionRectangleClip **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionRectangleClip*, int> CreateRectangleClip;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> CreateAnimation;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> CheckDeviceState;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDCompositionDevice"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDCompositionDevice(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDCompositionDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDCompositionDevice(Silk.NET.Windows.IUnknown value)
    {
        return new IDCompositionDevice(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionDevice"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionDevice"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDCompositionDevice value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
