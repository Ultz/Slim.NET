// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/x3daudio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    [NativeTypeName("const X3DAUDIO_DISTANCE_CURVE_POINT[2]")]
    public static ReadOnlySpan<X3DAUDIO_DISTANCE_CURVE_POINT> X3DAudioDefault_LinearCurvePoints
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
                0x80,
                0x3F,
                0x00,
                0x00,
                0x80,
                0x3F,
                0x00,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == (Unsafe.SizeOf<X3DAUDIO_DISTANCE_CURVE_POINT>() * 2));
            return MemoryMarshal.CreateReadOnlySpan<X3DAUDIO_DISTANCE_CURVE_POINT>(
                ref Unsafe.As<byte, X3DAUDIO_DISTANCE_CURVE_POINT>(
                    ref MemoryMarshal.GetReference(data)
                ),
                2
            );
        }
    }
    // public static ref readonly X3DAUDIO_DISTANCE_CURVE X3DAudioDefault_LinearCurve => new X3DAUDIO_DISTANCE_CURVE {
    //    pPoints = &X3DAudioDefault_LinearCurvePoints[0],
    //    PointsCount = 2,
    // };
}
