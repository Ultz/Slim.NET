// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_3helper.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.DirectX.DirectX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D2D1_SIMPLE_COLOR_PROFILE
{
    public D2D1_SIMPLE_COLOR_PROFILE(
        [NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F redPrimary,
        [NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F greenPrimary,
        [NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F bluePrimary,
        [NativeTypeName("const D2D1_GAMMA1")] D2D1_GAMMA1 gamma,
        [NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F whitePointXZ
    )
    {
        this = SimpleColorProfile(redPrimary, greenPrimary, bluePrimary, gamma, whitePointXZ);
    }
}
