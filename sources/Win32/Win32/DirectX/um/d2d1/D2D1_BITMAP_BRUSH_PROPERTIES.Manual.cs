// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.DirectX.D2D1_BITMAP_INTERPOLATION_MODE;
using static Silk.NET.DirectX.D2D1_EXTEND_MODE;
using static Silk.NET.DirectX.DirectX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D2D1_BITMAP_BRUSH_PROPERTIES
{
    public static ref readonly D2D1_BITMAP_BRUSH_PROPERTIES DEFAULT
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
                0x01,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<D2D1_BITMAP_BRUSH_PROPERTIES>());
            return ref Unsafe.As<byte, D2D1_BITMAP_BRUSH_PROPERTIES>(
                ref MemoryMarshal.GetReference(data)
            );
        }
    }

    public D2D1_BITMAP_BRUSH_PROPERTIES(
        D2D1_EXTEND_MODE extendModeX = D2D1_EXTEND_MODE_CLAMP,
        D2D1_EXTEND_MODE extendModeY = D2D1_EXTEND_MODE_CLAMP,
        D2D1_BITMAP_INTERPOLATION_MODE interpolationMode = D2D1_BITMAP_INTERPOLATION_MODE_LINEAR
    )
    {
        this = BitmapBrushProperties(extendModeX, extendModeY, interpolationMode);
    }
}
