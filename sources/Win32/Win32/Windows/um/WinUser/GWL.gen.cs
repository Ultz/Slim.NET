// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class GWL
{
    [NativeTypeName("#define GWL_WNDPROC (-4)")]
    public const int GWL_WNDPROC = (-4);

    [NativeTypeName("#define GWL_HINSTANCE (-6)")]
    public const int GWL_HINSTANCE = (-6);

    [NativeTypeName("#define GWL_HWNDPARENT (-8)")]
    public const int GWL_HWNDPARENT = (-8);

    [NativeTypeName("#define GWL_STYLE (-16)")]
    public const int GWL_STYLE = (-16);

    [NativeTypeName("#define GWL_EXSTYLE (-20)")]
    public const int GWL_EXSTYLE = (-20);

    [NativeTypeName("#define GWL_USERDATA (-21)")]
    public const int GWL_USERDATA = (-21);

    [NativeTypeName("#define GWL_ID (-12)")]
    public const int GWL_ID = (-12);
}
