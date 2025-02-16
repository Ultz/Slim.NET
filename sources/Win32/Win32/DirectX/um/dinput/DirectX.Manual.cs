// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.DirectX.DIMOFS;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    [NativeTypeName("#define DIMOUSE_XAXISAB (0x82000200 |DIMOFS_X )")]
    public static uint DIMOUSE_XAXISAB => 0x82000200u | DIMOFS_X;

    [NativeTypeName("#define DIMOUSE_YAXISAB (0x82000200 |DIMOFS_Y )")]
    public static uint DIMOUSE_YAXISAB => 0x82000200u | DIMOFS_Y;

    [NativeTypeName("#define DIMOUSE_XAXIS (0x82000300 |DIMOFS_X )")]
    public static uint DIMOUSE_XAXIS => 0x82000300u | DIMOFS_X;

    [NativeTypeName("#define DIMOUSE_YAXIS (0x82000300 |DIMOFS_Y )")]
    public static uint DIMOUSE_YAXIS => 0x82000300u | DIMOFS_Y;

    [NativeTypeName("#define DIMOUSE_WHEEL (0x82000300 |DIMOFS_Z )")]
    public static uint DIMOUSE_WHEEL => 0x82000300u | DIMOFS_Z;

    [NativeTypeName("#define DIMOUSE_BUTTON0 (0x82000400 |DIMOFS_BUTTON0)")]
    public static uint DIMOUSE_BUTTON0 => 0x82000400u | DIMOFS_BUTTON0;

    [NativeTypeName("#define DIMOUSE_BUTTON1 (0x82000400 |DIMOFS_BUTTON1)")]
    public static uint DIMOUSE_BUTTON1 => 0x82000400u | DIMOFS_BUTTON1;

    [NativeTypeName("#define DIMOUSE_BUTTON2 (0x82000400 |DIMOFS_BUTTON2)")]
    public static uint DIMOUSE_BUTTON2 => 0x82000400u | DIMOFS_BUTTON2;

    [NativeTypeName("#define DIMOUSE_BUTTON3 (0x82000400 |DIMOFS_BUTTON3)")]
    public static uint DIMOUSE_BUTTON3 => 0x82000400u | DIMOFS_BUTTON3;

    [NativeTypeName("#define DIMOUSE_BUTTON4 (0x82000400 |DIMOFS_BUTTON4)")]
    public static uint DIMOUSE_BUTTON4 => 0x82000400u | DIMOFS_BUTTON4;

    [NativeTypeName("#define DIMOUSE_BUTTON5 (0x82000400 |DIMOFS_BUTTON5)")]
    public static uint DIMOUSE_BUTTON5 => 0x82000400u | DIMOFS_BUTTON5;

    [NativeTypeName("#define DIMOUSE_BUTTON6 (0x82000400 |DIMOFS_BUTTON6)")]
    public static uint DIMOUSE_BUTTON6 => 0x82000400u | DIMOFS_BUTTON6;

    [NativeTypeName("#define DIMOUSE_BUTTON7 (0x82000400 |DIMOFS_BUTTON7)")]
    public static uint DIMOUSE_BUTTON7 => 0x82000400u | DIMOFS_BUTTON7;
}
