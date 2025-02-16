// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winuser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public unsafe partial struct HWND
{
    [NativeTypeName("#define HWND_BROADCAST ((HWND)0xffff)")]
    public static HWND HWND_BROADCAST => ((HWND)(0xffff));

    [NativeTypeName("#define HWND_MESSAGE ((HWND)-3)")]
    public static HWND HWND_MESSAGE => ((HWND)(-3));

    [NativeTypeName("#define HWND_DESKTOP ((HWND)0)")]
    public static HWND HWND_DESKTOP => ((HWND)(0));

    [NativeTypeName("#define HWND_TOP ((HWND)0)")]
    public static HWND HWND_TOP => ((HWND)(0));

    [NativeTypeName("#define HWND_BOTTOM ((HWND)1)")]
    public static HWND HWND_BOTTOM => ((HWND)(1));

    [NativeTypeName("#define HWND_TOPMOST ((HWND)-1)")]
    public static HWND HWND_TOPMOST => ((HWND)(-1));

    [NativeTypeName("#define HWND_NOTOPMOST ((HWND)-2)")]
    public static HWND HWND_NOTOPMOST => ((HWND)(-2));
}
