// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winuser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class OCR
{
    public const int OCR_NORMAL = 32512;
    public const int OCR_IBEAM = 32513;
    public const int OCR_WAIT = 32514;
    public const int OCR_CROSS = 32515;
    public const int OCR_UP = 32516;

    [Obsolete("use OCR_SIZEALL")]
    public const int OCR_SIZE = 32640;

    [Obsolete("use OCR_NORMAL")]
    public const int OCR_ICON = 32641;
    public const int OCR_SIZENWSE = 32642;
    public const int OCR_SIZENESW = 32643;
    public const int OCR_SIZEWE = 32644;
    public const int OCR_SIZENS = 32645;
    public const int OCR_SIZEALL = 32646;

    [Obsolete("use OIC_WINLOGO")]
    public const int OCR_ICOCUR = 32647;
    public const int OCR_NO = 32648;
    public const int OCR_HAND = 32649;
    public const int OCR_APPSTARTING = 32650;
}
