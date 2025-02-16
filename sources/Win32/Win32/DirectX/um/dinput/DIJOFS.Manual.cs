// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DIJOFS
{
    [NativeTypeName("#define DIJOFS_X FIELD_OFFSET(DIJOYSTATE, lX)")]
    public static uint DIJOFS_X
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out DIJOYSTATE tmp);
            return (uint)(&tmp.lX) - (uint)(&tmp);
        }
    }

    [NativeTypeName("#define DIJOFS_Y FIELD_OFFSET(DIJOYSTATE, lY)")]
    public static uint DIJOFS_Y
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out DIJOYSTATE tmp);
            return (uint)(&tmp.lY) - (uint)(&tmp);
        }
    }

    [NativeTypeName("#define DIJOFS_Z FIELD_OFFSET(DIJOYSTATE, lZ)")]
    public static uint DIJOFS_Z
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out DIJOYSTATE tmp);
            return (uint)(&tmp.lZ) - (uint)(&tmp);
        }
    }

    [NativeTypeName("#define DIJOFS_RX FIELD_OFFSET(DIJOYSTATE, lRx)")]
    public static uint DIJOFS_RX
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out DIJOYSTATE tmp);
            return (uint)(&tmp.lRx) - (uint)(&tmp);
        }
    }

    [NativeTypeName("#define DIJOFS_RY FIELD_OFFSET(DIJOYSTATE, lRy)")]
    public static uint DIJOFS_RY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out DIJOYSTATE tmp);
            return (uint)(&tmp.lRy) - (uint)(&tmp);
        }
    }

    [NativeTypeName("#define DIJOFS_RZ FIELD_OFFSET(DIJOYSTATE, lRz)")]
    public static uint DIJOFS_RZ
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out DIJOYSTATE tmp);
            return (uint)(&tmp.lRz) - (uint)(&tmp);
        }
    }

    [NativeTypeName("#define DIJOFS_BUTTON0 DIJOFS_BUTTON(0)")]
    public static uint DIJOFS_BUTTON0 => DIJOFS_BUTTON(0);

    [NativeTypeName("#define DIJOFS_BUTTON1 DIJOFS_BUTTON(1)")]
    public static uint DIJOFS_BUTTON1 => DIJOFS_BUTTON(1);

    [NativeTypeName("#define DIJOFS_BUTTON2 DIJOFS_BUTTON(2)")]
    public static uint DIJOFS_BUTTON2 => DIJOFS_BUTTON(2);

    [NativeTypeName("#define DIJOFS_BUTTON3 DIJOFS_BUTTON(3)")]
    public static uint DIJOFS_BUTTON3 => DIJOFS_BUTTON(3);

    [NativeTypeName("#define DIJOFS_BUTTON4 DIJOFS_BUTTON(4)")]
    public static uint DIJOFS_BUTTON4 => DIJOFS_BUTTON(4);

    [NativeTypeName("#define DIJOFS_BUTTON5 DIJOFS_BUTTON(5)")]
    public static uint DIJOFS_BUTTON5 => DIJOFS_BUTTON(5);

    [NativeTypeName("#define DIJOFS_BUTTON6 DIJOFS_BUTTON(6)")]
    public static uint DIJOFS_BUTTON6 => DIJOFS_BUTTON(6);

    [NativeTypeName("#define DIJOFS_BUTTON7 DIJOFS_BUTTON(7)")]
    public static uint DIJOFS_BUTTON7 => DIJOFS_BUTTON(7);

    [NativeTypeName("#define DIJOFS_BUTTON8 DIJOFS_BUTTON(8)")]
    public static uint DIJOFS_BUTTON8 => DIJOFS_BUTTON(8);

    [NativeTypeName("#define DIJOFS_BUTTON9 DIJOFS_BUTTON(9)")]
    public static uint DIJOFS_BUTTON9 => DIJOFS_BUTTON(9);

    [NativeTypeName("#define DIJOFS_BUTTON10 DIJOFS_BUTTON(10)")]
    public static uint DIJOFS_BUTTON10 => DIJOFS_BUTTON(10);

    [NativeTypeName("#define DIJOFS_BUTTON11 DIJOFS_BUTTON(11)")]
    public static uint DIJOFS_BUTTON11 => DIJOFS_BUTTON(11);

    [NativeTypeName("#define DIJOFS_BUTTON12 DIJOFS_BUTTON(12)")]
    public static uint DIJOFS_BUTTON12 => DIJOFS_BUTTON(12);

    [NativeTypeName("#define DIJOFS_BUTTON13 DIJOFS_BUTTON(13)")]
    public static uint DIJOFS_BUTTON13 => DIJOFS_BUTTON(13);

    [NativeTypeName("#define DIJOFS_BUTTON14 DIJOFS_BUTTON(14)")]
    public static uint DIJOFS_BUTTON14 => DIJOFS_BUTTON(14);

    [NativeTypeName("#define DIJOFS_BUTTON15 DIJOFS_BUTTON(15)")]
    public static uint DIJOFS_BUTTON15 => DIJOFS_BUTTON(15);

    [NativeTypeName("#define DIJOFS_BUTTON16 DIJOFS_BUTTON(16)")]
    public static uint DIJOFS_BUTTON16 => DIJOFS_BUTTON(16);

    [NativeTypeName("#define DIJOFS_BUTTON17 DIJOFS_BUTTON(17)")]
    public static uint DIJOFS_BUTTON17 => DIJOFS_BUTTON(17);

    [NativeTypeName("#define DIJOFS_BUTTON18 DIJOFS_BUTTON(18)")]
    public static uint DIJOFS_BUTTON18 => DIJOFS_BUTTON(18);

    [NativeTypeName("#define DIJOFS_BUTTON19 DIJOFS_BUTTON(19)")]
    public static uint DIJOFS_BUTTON19 => DIJOFS_BUTTON(19);

    [NativeTypeName("#define DIJOFS_BUTTON20 DIJOFS_BUTTON(20)")]
    public static uint DIJOFS_BUTTON20 => DIJOFS_BUTTON(20);

    [NativeTypeName("#define DIJOFS_BUTTON21 DIJOFS_BUTTON(21)")]
    public static uint DIJOFS_BUTTON21 => DIJOFS_BUTTON(21);

    [NativeTypeName("#define DIJOFS_BUTTON22 DIJOFS_BUTTON(22)")]
    public static uint DIJOFS_BUTTON22 => DIJOFS_BUTTON(22);

    [NativeTypeName("#define DIJOFS_BUTTON23 DIJOFS_BUTTON(23)")]
    public static uint DIJOFS_BUTTON23 => DIJOFS_BUTTON(23);

    [NativeTypeName("#define DIJOFS_BUTTON24 DIJOFS_BUTTON(24)")]
    public static uint DIJOFS_BUTTON24 => DIJOFS_BUTTON(24);

    [NativeTypeName("#define DIJOFS_BUTTON25 DIJOFS_BUTTON(25)")]
    public static uint DIJOFS_BUTTON25 => DIJOFS_BUTTON(25);

    [NativeTypeName("#define DIJOFS_BUTTON26 DIJOFS_BUTTON(26)")]
    public static uint DIJOFS_BUTTON26 => DIJOFS_BUTTON(26);

    [NativeTypeName("#define DIJOFS_BUTTON27 DIJOFS_BUTTON(27)")]
    public static uint DIJOFS_BUTTON27 => DIJOFS_BUTTON(27);

    [NativeTypeName("#define DIJOFS_BUTTON28 DIJOFS_BUTTON(28)")]
    public static uint DIJOFS_BUTTON28 => DIJOFS_BUTTON(28);

    [NativeTypeName("#define DIJOFS_BUTTON29 DIJOFS_BUTTON(29)")]
    public static uint DIJOFS_BUTTON29 => DIJOFS_BUTTON(29);

    [NativeTypeName("#define DIJOFS_BUTTON30 DIJOFS_BUTTON(30)")]
    public static uint DIJOFS_BUTTON30 => DIJOFS_BUTTON(30);

    [NativeTypeName("#define DIJOFS_BUTTON31 DIJOFS_BUTTON(31)")]
    public static uint DIJOFS_BUTTON31 => DIJOFS_BUTTON(31);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint DIJOFS_BUTTON(uint n)
    {
        Unsafe.SkipInit(out DIJOYSTATE tmp);
        return ((uint)(&tmp.rgbButtons) - (uint)(&tmp)) + n;
    }
}
