// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.DirectX.D2D1_CAP_STYLE;
using static Silk.NET.DirectX.D2D1_DASH_STYLE;
using static Silk.NET.DirectX.D2D1_LINE_JOIN;
using static Silk.NET.DirectX.DirectX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D2D1_STROKE_STYLE_PROPERTIES
{
    public static ref readonly D2D1_STROKE_STYLE_PROPERTIES DEFAULT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x20,
                0x41,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<D2D1_STROKE_STYLE_PROPERTIES>());
            return ref Unsafe.As<byte, D2D1_STROKE_STYLE_PROPERTIES>(
                ref MemoryMarshal.GetReference(data)
            );
        }
    }

    public D2D1_STROKE_STYLE_PROPERTIES(
        D2D1_CAP_STYLE startCap = D2D1_CAP_STYLE_FLAT,
        D2D1_CAP_STYLE endCap = D2D1_CAP_STYLE_FLAT,
        D2D1_CAP_STYLE dashCap = D2D1_CAP_STYLE_FLAT,
        D2D1_LINE_JOIN lineJoin = D2D1_LINE_JOIN_MITER,
        float miterLimit = 10.0f,
        D2D1_DASH_STYLE dashStyle = D2D1_DASH_STYLE_SOLID,
        float dashOffset = 0.0f
    )
    {
        this = StrokeStyleProperties(
            startCap,
            endCap,
            dashCap,
            lineJoin,
            miterLimit,
            dashStyle,
            dashOffset
        );
    }
}
