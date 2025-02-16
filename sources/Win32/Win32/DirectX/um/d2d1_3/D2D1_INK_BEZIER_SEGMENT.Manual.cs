// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_3helper.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.DirectX.DirectX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D2D1_INK_BEZIER_SEGMENT
{
    public D2D1_INK_BEZIER_SEGMENT(
        [NativeTypeName("const D2D1_INK_POINT &")] in D2D1_INK_POINT point1,
        [NativeTypeName("const D2D1_INK_POINT &")] in D2D1_INK_POINT point2,
        [NativeTypeName("const D2D1_INK_POINT &")] in D2D1_INK_POINT point3
    )
    {
        this = InkBezierSegment(point1, point2, point3);
    }
}
