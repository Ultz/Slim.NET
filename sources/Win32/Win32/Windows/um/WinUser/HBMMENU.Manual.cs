// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winuser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public unsafe partial struct HBMMENU
{
    [NativeTypeName("#define HBMMENU_CALLBACK ((HBITMAP) -1)")]
    public static HBITMAP HBMMENU_CALLBACK => ((HBITMAP)(-1));

    [NativeTypeName("#define HBMMENU_SYSTEM ((HBITMAP)  1)")]
    public static HBITMAP HBMMENU_SYSTEM => ((HBITMAP)(1));

    [NativeTypeName("#define HBMMENU_MBAR_RESTORE ((HBITMAP)  2)")]
    public static HBITMAP HBMMENU_MBAR_RESTORE => ((HBITMAP)(2));

    [NativeTypeName("#define HBMMENU_MBAR_MINIMIZE ((HBITMAP)  3)")]
    public static HBITMAP HBMMENU_MBAR_MINIMIZE => ((HBITMAP)(3));

    [NativeTypeName("#define HBMMENU_MBAR_CLOSE ((HBITMAP)  5)")]
    public static HBITMAP HBMMENU_MBAR_CLOSE => ((HBITMAP)(5));

    [NativeTypeName("#define HBMMENU_MBAR_CLOSE_D ((HBITMAP)  6)")]
    public static HBITMAP HBMMENU_MBAR_CLOSE_D => ((HBITMAP)(6));

    [NativeTypeName("#define HBMMENU_MBAR_MINIMIZE_D ((HBITMAP)  7)")]
    public static HBITMAP HBMMENU_MBAR_MINIMIZE_D => ((HBITMAP)(7));

    [NativeTypeName("#define HBMMENU_POPUP_CLOSE ((HBITMAP)  8)")]
    public static HBITMAP HBMMENU_POPUP_CLOSE => ((HBITMAP)(8));

    [NativeTypeName("#define HBMMENU_POPUP_RESTORE ((HBITMAP)  9)")]
    public static HBITMAP HBMMENU_POPUP_RESTORE => ((HBITMAP)(9));

    [NativeTypeName("#define HBMMENU_POPUP_MAXIMIZE ((HBITMAP) 10)")]
    public static HBITMAP HBMMENU_POPUP_MAXIMIZE => ((HBITMAP)(10));

    [NativeTypeName("#define HBMMENU_POPUP_MINIMIZE ((HBITMAP) 11)")]
    public static HBITMAP HBMMENU_POPUP_MINIMIZE => ((HBITMAP)(11));
}
