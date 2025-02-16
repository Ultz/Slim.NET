// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.DirectX.D2D1_ANTIALIAS_MODE;
using static Silk.NET.DirectX.D2D1_TEXT_ANTIALIAS_MODE;
using static Silk.NET.DirectX.DirectX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D2D1_DRAWING_STATE_DESCRIPTION
{
    public static ref readonly D2D1_DRAWING_STATE_DESCRIPTION DEFAULT
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
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x80,
                0x3F,
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
                0x80,
                0x3F,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<D2D1_DRAWING_STATE_DESCRIPTION>());
            return ref Unsafe.As<byte, D2D1_DRAWING_STATE_DESCRIPTION>(
                ref MemoryMarshal.GetReference(data)
            );
        }
    }

    public D2D1_DRAWING_STATE_DESCRIPTION(
        D2D1_ANTIALIAS_MODE antialiasMode = D2D1_ANTIALIAS_MODE_PER_PRIMITIVE,
        D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode = D2D1_TEXT_ANTIALIAS_MODE_DEFAULT,
        [NativeTypeName("D2D1_TAG")] ulong tag1 = 0,
        [NativeTypeName("D2D1_TAG")] ulong tag2 = 0
    )
        : this(antialiasMode, textAntialiasMode, tag1, tag2, IdentityMatrix) { }

    public D2D1_DRAWING_STATE_DESCRIPTION(
        [Optional] D2D1_ANTIALIAS_MODE antialiasMode,
        [Optional] D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode,
        [NativeTypeName("D2D1_TAG"), Optional] ulong tag1,
        [NativeTypeName("D2D1_TAG"), Optional] ulong tag2,
        [NativeTypeName("const D2D1_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F transform
    )
    {
        this = DrawingStateDescription(antialiasMode, textAntialiasMode, tag1, tag2, transform);
    }
}
