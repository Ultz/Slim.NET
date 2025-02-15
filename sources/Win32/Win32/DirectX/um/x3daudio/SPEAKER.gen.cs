// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/x3daudio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.DirectX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class SPEAKER
{
    [NativeTypeName("#define SPEAKER_MONO SPEAKER_FRONT_CENTER")]
    public const int SPEAKER_MONO = 0x00000004;

    [NativeTypeName("#define SPEAKER_STEREO (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT)")]
    public const int SPEAKER_STEREO = (0x00000001 | 0x00000002);

    [NativeTypeName(
        "#define SPEAKER_2POINT1 (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_LOW_FREQUENCY)"
    )]
    public const int SPEAKER_2POINT1 = (0x00000001 | 0x00000002 | 0x00000008);

    [NativeTypeName(
        "#define SPEAKER_SURROUND (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_BACK_CENTER)"
    )]
    public const int SPEAKER_SURROUND = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000100);

    [NativeTypeName(
        "#define SPEAKER_QUAD (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_BACK_LEFT | SPEAKER_BACK_RIGHT)"
    )]
    public const int SPEAKER_QUAD = (0x00000001 | 0x00000002 | 0x00000010 | 0x00000020);

    [NativeTypeName(
        "#define SPEAKER_4POINT1 (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_LOW_FREQUENCY | SPEAKER_BACK_LEFT | SPEAKER_BACK_RIGHT)"
    )]
    public const int SPEAKER_4POINT1 = (
        0x00000001 | 0x00000002 | 0x00000008 | 0x00000010 | 0x00000020
    );

    [NativeTypeName(
        "#define SPEAKER_5POINT1 (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_LOW_FREQUENCY | SPEAKER_BACK_LEFT | SPEAKER_BACK_RIGHT)"
    )]
    public const int SPEAKER_5POINT1 = (
        0x00000001 | 0x00000002 | 0x00000004 | 0x00000008 | 0x00000010 | 0x00000020
    );

    [NativeTypeName(
        "#define SPEAKER_7POINT1 (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_LOW_FREQUENCY | SPEAKER_BACK_LEFT | SPEAKER_BACK_RIGHT | SPEAKER_FRONT_LEFT_OF_CENTER | SPEAKER_FRONT_RIGHT_OF_CENTER)"
    )]
    public const int SPEAKER_7POINT1 = (
        0x00000001
        | 0x00000002
        | 0x00000004
        | 0x00000008
        | 0x00000010
        | 0x00000020
        | 0x00000040
        | 0x00000080
    );

    [NativeTypeName(
        "#define SPEAKER_5POINT1_SURROUND (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_LOW_FREQUENCY | SPEAKER_SIDE_LEFT  | SPEAKER_SIDE_RIGHT)"
    )]
    public const int SPEAKER_5POINT1_SURROUND = (
        0x00000001 | 0x00000002 | 0x00000004 | 0x00000008 | 0x00000200 | 0x00000400
    );

    [NativeTypeName(
        "#define SPEAKER_7POINT1_SURROUND (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_LOW_FREQUENCY | SPEAKER_BACK_LEFT | SPEAKER_BACK_RIGHT | SPEAKER_SIDE_LEFT  | SPEAKER_SIDE_RIGHT)"
    )]
    public const int SPEAKER_7POINT1_SURROUND = (
        0x00000001
        | 0x00000002
        | 0x00000004
        | 0x00000008
        | 0x00000010
        | 0x00000020
        | 0x00000200
        | 0x00000400
    );
}
