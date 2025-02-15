// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Cplext.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class Windows
{
    [NativeTypeName("#define CPLPAGE_MOUSE_BUTTONS 1")]
    public const int CPLPAGE_MOUSE_BUTTONS = 1;

    [NativeTypeName("#define CPLPAGE_MOUSE_PTRMOTION 2")]
    public const int CPLPAGE_MOUSE_PTRMOTION = 2;

    [NativeTypeName("#define CPLPAGE_MOUSE_WHEEL 3")]
    public const int CPLPAGE_MOUSE_WHEEL = 3;

    [NativeTypeName("#define CPLPAGE_KEYBOARD_SPEED 1")]
    public const int CPLPAGE_KEYBOARD_SPEED = 1;

    [NativeTypeName("#define CPLPAGE_DISPLAY_BACKGROUND 1")]
    public const int CPLPAGE_DISPLAY_BACKGROUND = 1;
}
