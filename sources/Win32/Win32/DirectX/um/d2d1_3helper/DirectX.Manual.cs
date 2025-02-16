// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_3helper.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    public static D2D_RECT_U InfiniteRectU
    {
        [return: NativeTypeName("D2D1_RECT_U")]
        get
        {
            D2D_RECT_U rect = new D2D_RECT_U
            {
                left = 0u,
                top = 0u,
                right = uint.MaxValue,
                bottom = uint.MaxValue,
            };
            return rect;
        }
    }

    [SupportedOSPlatform("windows10.0")]
    public static D2D1_GRADIENT_MESH_PATCH GradientMeshPatch(
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point00,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point01,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point02,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point03,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point10,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point11,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point12,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point13,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point20,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point21,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point22,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point23,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point30,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point31,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point32,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point33,
        [NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA color00,
        [NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA color03,
        [NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA color30,
        [NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA color33,
        D2D1_PATCH_EDGE_MODE topEdgeMode,
        D2D1_PATCH_EDGE_MODE leftEdgeMode,
        D2D1_PATCH_EDGE_MODE bottomEdgeMode,
        D2D1_PATCH_EDGE_MODE rightEdgeMode
    )
    {
        D2D1_GRADIENT_MESH_PATCH newPatch;
        newPatch.point00 = point00;
        newPatch.point01 = point01;
        newPatch.point02 = point02;
        newPatch.point03 = point03;
        newPatch.point10 = point10;
        newPatch.point11 = point11;
        newPatch.point12 = point12;
        newPatch.point13 = point13;
        newPatch.point20 = point20;
        newPatch.point21 = point21;
        newPatch.point22 = point22;
        newPatch.point23 = point23;
        newPatch.point30 = point30;
        newPatch.point31 = point31;
        newPatch.point32 = point32;
        newPatch.point33 = point33;
        newPatch.color00 = color00;
        newPatch.color03 = color03;
        newPatch.color30 = color30;
        newPatch.color33 = color33;
        newPatch.topEdgeMode = topEdgeMode;
        newPatch.leftEdgeMode = leftEdgeMode;
        newPatch.bottomEdgeMode = bottomEdgeMode;
        newPatch.rightEdgeMode = rightEdgeMode;
        return newPatch;
    }

    [SupportedOSPlatform("windows10.0")]
    public static D2D1_GRADIENT_MESH_PATCH GradientMeshPatchFromCoonsPatch(
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point0,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point1,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point2,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point3,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point4,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point5,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point6,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point7,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point8,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point9,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point10,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point11,
        [NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA color0,
        [NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA color1,
        [NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA color2,
        [NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA color3,
        D2D1_PATCH_EDGE_MODE topEdgeMode,
        D2D1_PATCH_EDGE_MODE leftEdgeMode,
        D2D1_PATCH_EDGE_MODE bottomEdgeMode,
        D2D1_PATCH_EDGE_MODE rightEdgeMode
    )
    {
        D2D1_GRADIENT_MESH_PATCH newPatch;
        newPatch.point00 = point0;
        newPatch.point01 = point1;
        newPatch.point02 = point2;
        newPatch.point03 = point3;
        newPatch.point13 = point4;
        newPatch.point23 = point5;
        newPatch.point33 = point6;
        newPatch.point32 = point7;
        newPatch.point31 = point8;
        newPatch.point30 = point9;
        newPatch.point20 = point10;
        newPatch.point10 = point11;
        D2D1GetGradientMeshInteriorPointsFromCoonsPatch(
            &point0,
            &point1,
            &point2,
            &point3,
            &point4,
            &point5,
            &point6,
            &point7,
            &point8,
            &point9,
            &point10,
            &point11,
            &newPatch.point11,
            &newPatch.point12,
            &newPatch.point21,
            &newPatch.point22
        );
        newPatch.color00 = color0;
        newPatch.color03 = color1;
        newPatch.color33 = color2;
        newPatch.color30 = color3;
        newPatch.topEdgeMode = topEdgeMode;
        newPatch.leftEdgeMode = leftEdgeMode;
        newPatch.bottomEdgeMode = bottomEdgeMode;
        newPatch.rightEdgeMode = rightEdgeMode;
        return newPatch;
    }

    public static D2D1_INK_BEZIER_SEGMENT InkBezierSegment(
        [NativeTypeName("const D2D1_INK_POINT &")] in D2D1_INK_POINT point1,
        [NativeTypeName("const D2D1_INK_POINT &")] in D2D1_INK_POINT point2,
        [NativeTypeName("const D2D1_INK_POINT &")] in D2D1_INK_POINT point3
    )
    {
        D2D1_INK_BEZIER_SEGMENT inkBezierSegment;
        inkBezierSegment.point1 = point1;
        inkBezierSegment.point2 = point2;
        inkBezierSegment.point3 = point3;
        return inkBezierSegment;
    }

    public static D2D1_INK_POINT InkPoint(
        [NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F point,
        float radius
    )
    {
        D2D1_INK_POINT inkPoint;
        inkPoint.x = point.x;
        inkPoint.y = point.y;
        inkPoint.radius = radius;
        return inkPoint;
    }

    public static D2D1_INK_STYLE_PROPERTIES InkStyleProperties(
        D2D1_INK_NIB_SHAPE nibShape,
        [NativeTypeName("const D2D1_MATRIX_3X2_F &")] in D2D_MATRIX_3X2_F nibTransform
    )
    {
        D2D1_INK_STYLE_PROPERTIES inkStyleProperties;
        inkStyleProperties.nibShape = nibShape;
        inkStyleProperties.nibTransform = nibTransform;
        return inkStyleProperties;
    }

    public static D2D1_SIMPLE_COLOR_PROFILE SimpleColorProfile(
        [NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F redPrimary,
        [NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F greenPrimary,
        [NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F bluePrimary,
        [NativeTypeName("const D2D1_GAMMA1")] D2D1_GAMMA1 gamma,
        [NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F whitePointXZ
    )
    {
        D2D1_SIMPLE_COLOR_PROFILE simpleColorProfile;
        simpleColorProfile.redPrimary = redPrimary;
        simpleColorProfile.greenPrimary = greenPrimary;
        simpleColorProfile.bluePrimary = bluePrimary;
        simpleColorProfile.gamma = gamma;
        simpleColorProfile.whitePointXZ = whitePointXZ;
        return simpleColorProfile;
    }
}
