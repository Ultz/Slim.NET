// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.DirectX.D2D1_FEATURE_LEVEL;
using static Silk.NET.DirectX.D2D1_RENDER_TARGET_TYPE;
using static Silk.NET.DirectX.D2D1_RENDER_TARGET_USAGE;
using static Silk.NET.DirectX.DirectX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D2D1_RENDER_TARGET_PROPERTIES
{
    public static ref readonly D2D1_RENDER_TARGET_PROPERTIES DEFAULT
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
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<D2D1_RENDER_TARGET_PROPERTIES>());
            return ref Unsafe.As<byte, D2D1_RENDER_TARGET_PROPERTIES>(
                ref MemoryMarshal.GetReference(data)
            );
        }
    }

    public D2D1_RENDER_TARGET_PROPERTIES(
        D2D1_RENDER_TARGET_TYPE type = D2D1_RENDER_TARGET_TYPE_DEFAULT,
        [NativeTypeName("const D2D1_PIXEL_FORMAT &")] in D2D1_PIXEL_FORMAT pixelFormat = default,
        float dpiX = 0.0f,
        float dpiY = 0.0f,
        D2D1_RENDER_TARGET_USAGE usage = D2D1_RENDER_TARGET_USAGE_NONE,
        D2D1_FEATURE_LEVEL minLevel = D2D1_FEATURE_LEVEL_DEFAULT
    )
    {
        this = RenderTargetProperties(type, pixelFormat, dpiX, dpiY, usage, minLevel);
    }
}
