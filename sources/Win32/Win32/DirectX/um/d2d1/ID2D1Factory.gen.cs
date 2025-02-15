// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("06152247-6F50-465A-9245-118BFD3B6007")]
[NativeTypeName("struct ID2D1Factory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID2D1Factory : ID2D1Factory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1Factory));
    public void*** lpVtbl;

    public HRESULT CreateDrawingStateBlock(
        [NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION &")]
            D2D1_DRAWING_STATE_DESCRIPTION* drawingStateDescription,
        ID2D1DrawingStateBlock* drawingStateBlock
    )
    {
        return CreateDrawingStateBlock(drawingStateDescription, default, drawingStateBlock);
    }

    public HRESULT CreateDrawingStateBlock(ID2D1DrawingStateBlock* drawingStateBlock)
    {
        return CreateDrawingStateBlock(null, default, drawingStateBlock);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1Factory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID2D1Factory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1Factory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ReloadSystemMetrics()
    {
        return ((delegate* unmanaged<ID2D1Factory, int>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [Obsolete(
        "Deprecated. Use DisplayInformation::LogicalDpi for Windows Store Apps or GetDpiForWindow for desktop apps."
    )]
    public void GetDesktopDpi(float* dpiX, float* dpiY)
    {
        ((delegate* unmanaged<ID2D1Factory, float*, float*, void>)((*lpVtbl)[4]))(this, dpiX, dpiY);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateRectangleGeometry(
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rectangle,
        ID2D1RectangleGeometry* rectangleGeometry
    )
    {
        return (
            (delegate* unmanaged<ID2D1Factory, D2D_RECT_F*, ID2D1RectangleGeometry*, int>)(
                (*lpVtbl)[5]
            )
        )(this, rectangle, rectangleGeometry);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateRoundedRectangleGeometry(
        [NativeTypeName("const D2D1_ROUNDED_RECT *")] D2D1_ROUNDED_RECT* roundedRectangle,
        ID2D1RoundedRectangleGeometry* roundedRectangleGeometry
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1Factory,
                D2D1_ROUNDED_RECT*,
                ID2D1RoundedRectangleGeometry*,
                int>)((*lpVtbl)[6])
        )(this, roundedRectangle, roundedRectangleGeometry);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateEllipseGeometry(
        [NativeTypeName("const D2D1_ELLIPSE *")] D2D1_ELLIPSE* ellipse,
        ID2D1EllipseGeometry* ellipseGeometry
    )
    {
        return (
            (delegate* unmanaged<ID2D1Factory, D2D1_ELLIPSE*, ID2D1EllipseGeometry*, int>)(
                (*lpVtbl)[7]
            )
        )(this, ellipse, ellipseGeometry);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateGeometryGroup(
        D2D1_FILL_MODE fillMode,
        ID2D1Geometry* geometries,
        [NativeTypeName("UINT32")] uint geometriesCount,
        ID2D1GeometryGroup* geometryGroup
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1Factory,
                D2D1_FILL_MODE,
                ID2D1Geometry*,
                uint,
                ID2D1GeometryGroup*,
                int>)((*lpVtbl)[8])
        )(this, fillMode, geometries, geometriesCount, geometryGroup);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateTransformedGeometry(
        ID2D1Geometry sourceGeometry,
        [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform,
        ID2D1TransformedGeometry* transformedGeometry
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1Factory,
                ID2D1Geometry,
                D2D_MATRIX_3X2_F*,
                ID2D1TransformedGeometry*,
                int>)((*lpVtbl)[9])
        )(this, sourceGeometry, transform, transformedGeometry);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreatePathGeometry(ID2D1PathGeometry* pathGeometry)
    {
        return ((delegate* unmanaged<ID2D1Factory, ID2D1PathGeometry*, int>)((*lpVtbl)[10]))(
            this,
            pathGeometry
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateStrokeStyle(
        [NativeTypeName("const D2D1_STROKE_STYLE_PROPERTIES *")]
            D2D1_STROKE_STYLE_PROPERTIES* strokeStyleProperties,
        [NativeTypeName("const FLOAT *")] float* dashes,
        [NativeTypeName("UINT32")] uint dashesCount,
        ID2D1StrokeStyle* strokeStyle
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1Factory,
                D2D1_STROKE_STYLE_PROPERTIES*,
                float*,
                uint,
                ID2D1StrokeStyle*,
                int>)((*lpVtbl)[11])
        )(this, strokeStyleProperties, dashes, dashesCount, strokeStyle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateDrawingStateBlock(
        [NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION *")]
            D2D1_DRAWING_STATE_DESCRIPTION* drawingStateDescription,
        IDWriteRenderingParams textRenderingParams,
        ID2D1DrawingStateBlock* drawingStateBlock
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1Factory,
                D2D1_DRAWING_STATE_DESCRIPTION*,
                IDWriteRenderingParams,
                ID2D1DrawingStateBlock*,
                int>)((*lpVtbl)[12])
        )(this, drawingStateDescription, textRenderingParams, drawingStateBlock);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateWicBitmapRenderTarget(
        IWICBitmap target,
        [NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")]
            D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties,
        ID2D1RenderTarget* renderTarget
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1Factory,
                IWICBitmap,
                D2D1_RENDER_TARGET_PROPERTIES*,
                ID2D1RenderTarget*,
                int>)((*lpVtbl)[13])
        )(this, target, renderTargetProperties, renderTarget);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateHwndRenderTarget(
        [NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")]
            D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties,
        [NativeTypeName("const D2D1_HWND_RENDER_TARGET_PROPERTIES *")]
            D2D1_HWND_RENDER_TARGET_PROPERTIES* hwndRenderTargetProperties,
        ID2D1HwndRenderTarget* hwndRenderTarget
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1Factory,
                D2D1_RENDER_TARGET_PROPERTIES*,
                D2D1_HWND_RENDER_TARGET_PROPERTIES*,
                ID2D1HwndRenderTarget*,
                int>)((*lpVtbl)[14])
        )(this, renderTargetProperties, hwndRenderTargetProperties, hwndRenderTarget);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateDxgiSurfaceRenderTarget(
        IDXGISurface dxgiSurface,
        [NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")]
            D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties,
        ID2D1RenderTarget* renderTarget
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1Factory,
                IDXGISurface,
                D2D1_RENDER_TARGET_PROPERTIES*,
                ID2D1RenderTarget*,
                int>)((*lpVtbl)[15])
        )(this, dxgiSurface, renderTargetProperties, renderTarget);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateDCRenderTarget(
        [NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")]
            D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties,
        ID2D1DCRenderTarget* dcRenderTarget
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1Factory,
                D2D1_RENDER_TARGET_PROPERTIES*,
                ID2D1DCRenderTarget*,
                int>)((*lpVtbl)[16])
        )(this, renderTargetProperties, dcRenderTarget);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ReloadSystemMetrics();

        [VtblIndex(4)]
        [Obsolete(
            "Deprecated. Use DisplayInformation::LogicalDpi for Windows Store Apps or GetDpiForWindow for desktop apps."
        )]
        void GetDesktopDpi(float* dpiX, float* dpiY);

        [VtblIndex(5)]
        HRESULT CreateRectangleGeometry(
            [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rectangle,
            ID2D1RectangleGeometry* rectangleGeometry
        );

        [VtblIndex(6)]
        HRESULT CreateRoundedRectangleGeometry(
            [NativeTypeName("const D2D1_ROUNDED_RECT *")] D2D1_ROUNDED_RECT* roundedRectangle,
            ID2D1RoundedRectangleGeometry* roundedRectangleGeometry
        );

        [VtblIndex(7)]
        HRESULT CreateEllipseGeometry(
            [NativeTypeName("const D2D1_ELLIPSE *")] D2D1_ELLIPSE* ellipse,
            ID2D1EllipseGeometry* ellipseGeometry
        );

        [VtblIndex(8)]
        HRESULT CreateGeometryGroup(
            D2D1_FILL_MODE fillMode,
            ID2D1Geometry* geometries,
            [NativeTypeName("UINT32")] uint geometriesCount,
            ID2D1GeometryGroup* geometryGroup
        );

        [VtblIndex(9)]
        HRESULT CreateTransformedGeometry(
            ID2D1Geometry sourceGeometry,
            [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform,
            ID2D1TransformedGeometry* transformedGeometry
        );

        [VtblIndex(10)]
        HRESULT CreatePathGeometry(ID2D1PathGeometry* pathGeometry);

        [VtblIndex(11)]
        HRESULT CreateStrokeStyle(
            [NativeTypeName("const D2D1_STROKE_STYLE_PROPERTIES *")]
                D2D1_STROKE_STYLE_PROPERTIES* strokeStyleProperties,
            [NativeTypeName("const FLOAT *")] float* dashes,
            [NativeTypeName("UINT32")] uint dashesCount,
            ID2D1StrokeStyle* strokeStyle
        );

        [VtblIndex(12)]
        HRESULT CreateDrawingStateBlock(
            [NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION *")]
                D2D1_DRAWING_STATE_DESCRIPTION* drawingStateDescription,
            IDWriteRenderingParams textRenderingParams,
            ID2D1DrawingStateBlock* drawingStateBlock
        );

        [VtblIndex(13)]
        HRESULT CreateWicBitmapRenderTarget(
            IWICBitmap target,
            [NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")]
                D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties,
            ID2D1RenderTarget* renderTarget
        );

        [VtblIndex(14)]
        HRESULT CreateHwndRenderTarget(
            [NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")]
                D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties,
            [NativeTypeName("const D2D1_HWND_RENDER_TARGET_PROPERTIES *")]
                D2D1_HWND_RENDER_TARGET_PROPERTIES* hwndRenderTargetProperties,
            ID2D1HwndRenderTarget* hwndRenderTarget
        );

        [VtblIndex(15)]
        HRESULT CreateDxgiSurfaceRenderTarget(
            IDXGISurface dxgiSurface,
            [NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")]
                D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties,
            ID2D1RenderTarget* renderTarget
        );

        [VtblIndex(16)]
        HRESULT CreateDCRenderTarget(
            [NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")]
                D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties,
            ID2D1DCRenderTarget* dcRenderTarget
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

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ReloadSystemMetrics;

        [NativeTypeName(
            "void (FLOAT *, FLOAT *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        [Obsolete(
            "Deprecated. Use DisplayInformation::LogicalDpi for Windows Store Apps or GetDpiForWindow for desktop apps."
        )]
        public delegate* unmanaged<TSelf*, float*, float*, void> GetDesktopDpi;

        [NativeTypeName(
            "HRESULT (const D2D1_RECT_F *, ID2D1RectangleGeometry **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D_RECT_F*,
            ID2D1RectangleGeometry*,
            int> CreateRectangleGeometry;

        [NativeTypeName(
            "HRESULT (const D2D1_ROUNDED_RECT *, ID2D1RoundedRectangleGeometry **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D1_ROUNDED_RECT*,
            ID2D1RoundedRectangleGeometry*,
            int> CreateRoundedRectangleGeometry;

        [NativeTypeName(
            "HRESULT (const D2D1_ELLIPSE *, ID2D1EllipseGeometry **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D1_ELLIPSE*,
            ID2D1EllipseGeometry*,
            int> CreateEllipseGeometry;

        [NativeTypeName(
            "HRESULT (D2D1_FILL_MODE, ID2D1Geometry **, UINT32, ID2D1GeometryGroup **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D1_FILL_MODE,
            ID2D1Geometry*,
            uint,
            ID2D1GeometryGroup*,
            int> CreateGeometryGroup;

        [NativeTypeName(
            "HRESULT (ID2D1Geometry *, const D2D1_MATRIX_3X2_F *, ID2D1TransformedGeometry **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1Geometry,
            D2D_MATRIX_3X2_F*,
            ID2D1TransformedGeometry*,
            int> CreateTransformedGeometry;

        [NativeTypeName(
            "HRESULT (ID2D1PathGeometry **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1PathGeometry*, int> CreatePathGeometry;

        [NativeTypeName(
            "HRESULT (const D2D1_STROKE_STYLE_PROPERTIES *, const FLOAT *, UINT32, ID2D1StrokeStyle **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D1_STROKE_STYLE_PROPERTIES*,
            float*,
            uint,
            ID2D1StrokeStyle*,
            int> CreateStrokeStyle;

        [NativeTypeName(
            "HRESULT (const D2D1_DRAWING_STATE_DESCRIPTION *, IDWriteRenderingParams *, ID2D1DrawingStateBlock **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D1_DRAWING_STATE_DESCRIPTION*,
            IDWriteRenderingParams,
            ID2D1DrawingStateBlock*,
            int> CreateDrawingStateBlock2;

        [NativeTypeName(
            "HRESULT (IWICBitmap *, const D2D1_RENDER_TARGET_PROPERTIES *, ID2D1RenderTarget **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWICBitmap,
            D2D1_RENDER_TARGET_PROPERTIES*,
            ID2D1RenderTarget*,
            int> CreateWicBitmapRenderTarget;

        [NativeTypeName(
            "HRESULT (const D2D1_RENDER_TARGET_PROPERTIES *, const D2D1_HWND_RENDER_TARGET_PROPERTIES *, ID2D1HwndRenderTarget **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D1_RENDER_TARGET_PROPERTIES*,
            D2D1_HWND_RENDER_TARGET_PROPERTIES*,
            ID2D1HwndRenderTarget*,
            int> CreateHwndRenderTarget;

        [NativeTypeName(
            "HRESULT (IDXGISurface *, const D2D1_RENDER_TARGET_PROPERTIES *, ID2D1RenderTarget **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDXGISurface,
            D2D1_RENDER_TARGET_PROPERTIES*,
            ID2D1RenderTarget*,
            int> CreateDxgiSurfaceRenderTarget;

        [NativeTypeName(
            "HRESULT (const D2D1_RENDER_TARGET_PROPERTIES *, ID2D1DCRenderTarget **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D1_RENDER_TARGET_PROPERTIES*,
            ID2D1DCRenderTarget*,
            int> CreateDCRenderTarget;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1Factory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1Factory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1Factory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1Factory(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1Factory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1Factory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1Factory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1Factory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
