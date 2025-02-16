// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_3helper.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.DirectX.DirectX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D2D1_GRADIENT_MESH_PATCH
{
    public D2D1_GRADIENT_MESH_PATCH(
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
        this = GradientMeshPatch(
            point00,
            point01,
            point02,
            point03,
            point10,
            point11,
            point12,
            point13,
            point20,
            point21,
            point22,
            point23,
            point30,
            point31,
            point32,
            point33,
            color00,
            color03,
            color30,
            color33,
            topEdgeMode,
            leftEdgeMode,
            bottomEdgeMode,
            rightEdgeMode
        );
    }

    public static D2D1_GRADIENT_MESH_PATCH FromCoonsPatch(
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
        return GradientMeshPatchFromCoonsPatch(
            point0,
            point1,
            point2,
            point3,
            point4,
            point5,
            point6,
            point7,
            point8,
            point9,
            point10,
            point11,
            color0,
            color1,
            color2,
            color3,
            topEdgeMode,
            leftEdgeMode,
            bottomEdgeMode,
            rightEdgeMode
        );
    }
}
