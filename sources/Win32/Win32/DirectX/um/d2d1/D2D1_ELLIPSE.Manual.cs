// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.DirectX.DirectX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D2D1_ELLIPSE
{
    public D2D1_ELLIPSE(
        [NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F center,
        float radiusX,
        float radiusY
    )
    {
        this = Ellipse(center, radiusX, radiusY);
    }
}
