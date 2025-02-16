// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using Silk.NET.Win32;
using static Silk.NET.DirectX.D2D1_ALPHA_MODE;
using static Silk.NET.DirectX.D2D1_ANTIALIAS_MODE;
using static Silk.NET.DirectX.D2D1_BITMAP_INTERPOLATION_MODE;
using static Silk.NET.DirectX.D2D1_CAP_STYLE;
using static Silk.NET.DirectX.D2D1_DASH_STYLE;
using static Silk.NET.DirectX.D2D1_EXTEND_MODE;
using static Silk.NET.DirectX.D2D1_FEATURE_LEVEL;
using static Silk.NET.DirectX.D2D1_LAYER_OPTIONS;
using static Silk.NET.DirectX.D2D1_LINE_JOIN;
using static Silk.NET.DirectX.D2D1_PRESENT_OPTIONS;
using static Silk.NET.DirectX.D2D1_RENDER_TARGET_TYPE;
using static Silk.NET.DirectX.D2D1_RENDER_TARGET_USAGE;
using static Silk.NET.DirectX.D2D1_TEXT_ANTIALIAS_MODE;
using static Silk.NET.DirectX.DXGI_FORMAT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    public const float FloatMax = float.MaxValue;

    [NativeTypeName("D2D1_RECT_F")]
    public static ref readonly D2D_RECT_F InfiniteRect => ref D2D_RECT_F.Infinite;

    [NativeTypeName("D2D1_MATRIX_3X2_F")]
    public static ref readonly D2D_MATRIX_3X2_F IdentityMatrix => ref D2D_MATRIX_3X2_F.Identity;

    public static D2D1_ARC_SEGMENT ArcSegment(
        [NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F point,
        [NativeTypeName("const D2D1_SIZE_F &")] in D2D_SIZE_F size,
        float rotationAngle,
        D2D1_SWEEP_DIRECTION sweepDirection,
        D2D1_ARC_SIZE arcSize
    )
    {
        D2D1_ARC_SEGMENT arcSegment = new D2D1_ARC_SEGMENT
        {
            point = point,
            size = size,
            rotationAngle = rotationAngle,
            sweepDirection = sweepDirection,
            arcSize = arcSize,
        };
        return arcSegment;
    }

    public static D2D1_BEZIER_SEGMENT BezierSegment(
        [NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F point1,
        [NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F point2,
        [NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F point3
    )
    {
        D2D1_BEZIER_SEGMENT bezierSegment = new D2D1_BEZIER_SEGMENT
        {
            point1 = point1,
            point2 = point2,
            point3 = point3,
        };
        return bezierSegment;
    }

    public static D2D1_BITMAP_BRUSH_PROPERTIES BitmapBrushProperties(
        D2D1_EXTEND_MODE extendModeX = D2D1_EXTEND_MODE_CLAMP,
        D2D1_EXTEND_MODE extendModeY = D2D1_EXTEND_MODE_CLAMP,
        D2D1_BITMAP_INTERPOLATION_MODE interpolationMode = D2D1_BITMAP_INTERPOLATION_MODE_LINEAR
    )
    {
        D2D1_BITMAP_BRUSH_PROPERTIES bitmapBrushProperties;
        bitmapBrushProperties.extendModeX = extendModeX;
        bitmapBrushProperties.extendModeY = extendModeY;
        bitmapBrushProperties.interpolationMode = interpolationMode;
        return bitmapBrushProperties;
    }

    public static D2D1_BITMAP_PROPERTIES BitmapProperties(
        [NativeTypeName("const D2D1_PIXEL_FORMAT &")] in D2D1_PIXEL_FORMAT pixelFormat = default,
        float dpiX = 96.0f,
        float dpiY = 96.0f
    )
    {
        D2D1_BITMAP_PROPERTIES bitmapProperties;
        bitmapProperties.pixelFormat = pixelFormat;
        bitmapProperties.dpiX = dpiX;
        bitmapProperties.dpiY = dpiY;
        return bitmapProperties;
    }

    public static D2D1_BRUSH_PROPERTIES BrushProperties(float opacity = 1.0f)
    {
        return BrushProperties(opacity, IdentityMatrix);
    }

    public static D2D1_BRUSH_PROPERTIES BrushProperties(
        [Optional, DefaultParameterValue(1.0f)] float opacity,
        [NativeTypeName("const D2D1_MATRIX_3X2_F &")] in D2D_MATRIX_3X2_F transform
    )
    {
        D2D1_BRUSH_PROPERTIES brushProperties;
        brushProperties.opacity = opacity;
        brushProperties.transform = transform;
        return brushProperties;
    }

    public static D2D1_DRAWING_STATE_DESCRIPTION DrawingStateDescription(
        D2D1_ANTIALIAS_MODE antialiasMode = D2D1_ANTIALIAS_MODE_PER_PRIMITIVE,
        D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode = D2D1_TEXT_ANTIALIAS_MODE_DEFAULT,
        [NativeTypeName("D2D1_TAG")] ulong tag1 = 0,
        [NativeTypeName("D2D1_TAG")] ulong tag2 = 0
    )
    {
        return DrawingStateDescription(
            antialiasMode,
            textAntialiasMode,
            tag1,
            tag2,
            IdentityMatrix
        );
    }

    public static D2D1_DRAWING_STATE_DESCRIPTION DrawingStateDescription(
        [Optional] D2D1_ANTIALIAS_MODE antialiasMode,
        [Optional] D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode,
        [NativeTypeName("D2D1_TAG"), Optional] ulong tag1,
        [NativeTypeName("D2D1_TAG"), Optional] ulong tag2,
        [NativeTypeName("const D2D1_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F transform
    )
    {
        D2D1_DRAWING_STATE_DESCRIPTION drawingStateDescription;
        drawingStateDescription.antialiasMode = antialiasMode;
        drawingStateDescription.textAntialiasMode = textAntialiasMode;
        drawingStateDescription.tag1 = tag1;
        drawingStateDescription.tag2 = tag2;
        drawingStateDescription.transform = transform;
        return drawingStateDescription;
    }

    public static D2D1_ELLIPSE Ellipse(
        [NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F center,
        float radiusX,
        float radiusY
    )
    {
        D2D1_ELLIPSE ellipse;
        ellipse.point = center;
        ellipse.radiusX = radiusX;
        ellipse.radiusY = radiusY;
        return ellipse;
    }

    public static D2D1_GRADIENT_STOP GradientStop(
        float position,
        [NativeTypeName("const D2D1_COLOR_F &")] in DXGI_RGBA color
    )
    {
        D2D1_GRADIENT_STOP gradientStop = new D2D1_GRADIENT_STOP
        {
            position = position,
            color = color,
        };
        return gradientStop;
    }

    public static D2D1_HWND_RENDER_TARGET_PROPERTIES HwndRenderTargetProperties(
        HWND hwnd,
        [NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U pixelSize = default,
        D2D1_PRESENT_OPTIONS presentOptions = D2D1_PRESENT_OPTIONS_NONE
    )
    {
        D2D1_HWND_RENDER_TARGET_PROPERTIES hwndRenderTargetProperties;
        hwndRenderTargetProperties.hwnd = hwnd;
        hwndRenderTargetProperties.pixelSize = pixelSize;
        hwndRenderTargetProperties.presentOptions = presentOptions;
        return hwndRenderTargetProperties;
    }

    public static D2D1_LAYER_PARAMETERS LayerParameters(
        [Optional] ID2D1Geometry geometricMask,
        [Optional] D2D1_ANTIALIAS_MODE maskAntialiasMode,
        float opacity = 1.0f,
        ID2D1Brush opacityBrush = default,
        D2D1_LAYER_OPTIONS layerOptions = D2D1_LAYER_OPTIONS_NONE
    )
    {
        return LayerParameters(
            InfiniteRect,
            geometricMask,
            maskAntialiasMode,
            IdentityMatrix,
            opacity,
            opacityBrush,
            layerOptions
        );
    }

    public static D2D1_LAYER_PARAMETERS LayerParameters(
        [NativeTypeName("const D2D1_RECT_F")] in D2D_RECT_F contentBounds,
        [Optional] ID2D1Geometry geometricMask,
        [Optional] D2D1_ANTIALIAS_MODE maskAntialiasMode,
        float opacity = 1.0f,
        ID2D1Brush opacityBrush = default,
        D2D1_LAYER_OPTIONS layerOptions = D2D1_LAYER_OPTIONS_NONE
    )
    {
        return LayerParameters(
            contentBounds,
            geometricMask,
            maskAntialiasMode,
            IdentityMatrix,
            opacity,
            opacityBrush,
            layerOptions
        );
    }

    public static D2D1_LAYER_PARAMETERS LayerParameters(
        [Optional] ID2D1Geometry geometricMask,
        [Optional] D2D1_ANTIALIAS_MODE maskAntialiasMode,
        [NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F maskTransform,
        float opacity = 1.0f,
        ID2D1Brush opacityBrush = default,
        D2D1_LAYER_OPTIONS layerOptions = D2D1_LAYER_OPTIONS_NONE
    )
    {
        return LayerParameters(
            InfiniteRect,
            geometricMask,
            maskAntialiasMode,
            maskTransform,
            opacity,
            opacityBrush,
            layerOptions
        );
    }

    public static D2D1_LAYER_PARAMETERS LayerParameters(
        [NativeTypeName("const D2D1_RECT_F")] in D2D_RECT_F contentBounds,
        [Optional] ID2D1Geometry geometricMask,
        [Optional] D2D1_ANTIALIAS_MODE maskAntialiasMode,
        [NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F maskTransform,
        float opacity = 1.0f,
        ID2D1Brush opacityBrush = default,
        D2D1_LAYER_OPTIONS layerOptions = D2D1_LAYER_OPTIONS_NONE
    )
    {
        D2D1_LAYER_PARAMETERS layerParameters = default;
        layerParameters.contentBounds = contentBounds;
        layerParameters.geometricMask = geometricMask;
        layerParameters.maskAntialiasMode = maskAntialiasMode;
        layerParameters.maskTransform = maskTransform;
        layerParameters.opacity = opacity;
        layerParameters.opacityBrush = opacityBrush;
        layerParameters.layerOptions = layerOptions;
        return layerParameters;
    }

    public static D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES LinearGradientBrushProperties(
        [NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F startPoint,
        [NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F endPoint
    )
    {
        D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES linearGradientBrushProperties;
        linearGradientBrushProperties.startPoint = startPoint;
        linearGradientBrushProperties.endPoint = endPoint;
        return linearGradientBrushProperties;
    }

    public static D2D1_PIXEL_FORMAT PixelFormat(
        DXGI_FORMAT dxgiFormat = DXGI_FORMAT_UNKNOWN,
        D2D1_ALPHA_MODE alphaMode = D2D1_ALPHA_MODE_UNKNOWN
    )
    {
        D2D1_PIXEL_FORMAT pixelFormat;
        pixelFormat.format = dxgiFormat;
        pixelFormat.alphaMode = alphaMode;
        return pixelFormat;
    }

    [return: NativeTypeName("D2D1_POINT_2F")]
    public static D2D_POINT_2F Point2F(float x = 0.0f, float y = 0.0f)
    {
        D2D_POINT_2F point = new D2D_POINT_2F { x = x, y = y };
        return point;
    }

    [return: NativeTypeName("D2D1_POINT_2U")]
    public static D2D_POINT_2U Point2U(
        [NativeTypeName("UINT32")] uint x = 0,
        [NativeTypeName("UINT32")] uint y = 0
    )
    {
        D2D_POINT_2U point = new D2D_POINT_2U { x = x, y = y };
        return point;
    }

    public static D2D1_QUADRATIC_BEZIER_SEGMENT QuadraticBezierSegment(
        [NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F point1,
        [NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F point2
    )
    {
        D2D1_QUADRATIC_BEZIER_SEGMENT quadraticBezier = new D2D1_QUADRATIC_BEZIER_SEGMENT
        {
            point1 = point1,
            point2 = point2,
        };
        return quadraticBezier;
    }

    public static D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES RadialGradientBrushProperties(
        [NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F center,
        [NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F gradientOriginOffset,
        float radiusX,
        float radiusY
    )
    {
        D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES radialGradientBrushProperties;
        radialGradientBrushProperties.center = center;
        radialGradientBrushProperties.gradientOriginOffset = gradientOriginOffset;
        radialGradientBrushProperties.radiusX = radiusX;
        radialGradientBrushProperties.radiusY = radiusY;
        return radialGradientBrushProperties;
    }

    [return: NativeTypeName("D2D1_RECT_F")]
    public static D2D_RECT_F RectF(
        float left = 0.0f,
        float top = 0.0f,
        float right = 0.0f,
        float bottom = 0.0f
    )
    {
        D2D_RECT_F rect = new D2D_RECT_F
        {
            left = left,
            top = top,
            right = right,
            bottom = bottom,
        };
        return rect;
    }

    [return: NativeTypeName("D2D1_RECT_U")]
    public static D2D_RECT_U RectU(
        [NativeTypeName("UINT32")] uint left = 0,
        [NativeTypeName("UINT32")] uint top = 0,
        [NativeTypeName("UINT32")] uint right = 0,
        [NativeTypeName("UINT32")] uint bottom = 0
    )
    {
        D2D_RECT_U rect = new D2D_RECT_U
        {
            left = left,
            top = top,
            right = right,
            bottom = bottom,
        };
        return rect;
    }

    public static D2D1_RENDER_TARGET_PROPERTIES RenderTargetProperties(
        D2D1_RENDER_TARGET_TYPE type = D2D1_RENDER_TARGET_TYPE_DEFAULT,
        [NativeTypeName("const D2D1_PIXEL_FORMAT &")] in D2D1_PIXEL_FORMAT pixelFormat = default,
        float dpiX = 0.0f,
        float dpiY = 0.0f,
        D2D1_RENDER_TARGET_USAGE usage = D2D1_RENDER_TARGET_USAGE_NONE,
        D2D1_FEATURE_LEVEL minLevel = D2D1_FEATURE_LEVEL_DEFAULT
    )
    {
        D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties;
        renderTargetProperties.type = type;
        renderTargetProperties.pixelFormat = pixelFormat;
        renderTargetProperties.dpiX = dpiX;
        renderTargetProperties.dpiY = dpiY;
        renderTargetProperties.usage = usage;
        renderTargetProperties.minLevel = minLevel;
        return renderTargetProperties;
    }

    public static D2D1_ROUNDED_RECT RoundedRect(
        [NativeTypeName("const D2D1_RECT_F")] in D2D_RECT_F rect,
        float radiusX,
        float radiusY
    )
    {
        D2D1_ROUNDED_RECT roundedRect;
        roundedRect.rect = rect;
        roundedRect.radiusX = radiusX;
        roundedRect.radiusY = radiusY;
        return roundedRect;
    }

    [return: NativeTypeName("D2D1_SIZE_F")]
    public static D2D_SIZE_F SizeF(float width = 0.0f, float height = 0.0f)
    {
        D2D_SIZE_F size = new D2D_SIZE_F { width = width, height = height };
        return size;
    }

    [return: NativeTypeName("D2D1_SIZE_U")]
    public static D2D_SIZE_U SizeU(
        [NativeTypeName("UINT32")] uint width = 0,
        [NativeTypeName("UINT32")] uint height = 0
    )
    {
        D2D_SIZE_U size = new D2D_SIZE_U { width = width, height = height };
        return size;
    }

    public static D2D1_STROKE_STYLE_PROPERTIES StrokeStyleProperties(
        D2D1_CAP_STYLE startCap = D2D1_CAP_STYLE_FLAT,
        D2D1_CAP_STYLE endCap = D2D1_CAP_STYLE_FLAT,
        D2D1_CAP_STYLE dashCap = D2D1_CAP_STYLE_FLAT,
        D2D1_LINE_JOIN lineJoin = D2D1_LINE_JOIN_MITER,
        float miterLimit = 10.0f,
        D2D1_DASH_STYLE dashStyle = D2D1_DASH_STYLE_SOLID,
        float dashOffset = 0.0f
    )
    {
        D2D1_STROKE_STYLE_PROPERTIES strokeStyleProperties;
        strokeStyleProperties.startCap = startCap;
        strokeStyleProperties.endCap = endCap;
        strokeStyleProperties.dashCap = dashCap;
        strokeStyleProperties.lineJoin = lineJoin;
        strokeStyleProperties.miterLimit = miterLimit;
        strokeStyleProperties.dashStyle = dashStyle;
        strokeStyleProperties.dashOffset = dashOffset;
        return strokeStyleProperties;
    }
}
