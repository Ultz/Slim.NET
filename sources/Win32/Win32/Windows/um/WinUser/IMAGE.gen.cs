// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IMAGE
{
    [NativeTypeName("#define IMAGE_BITMAP 0")]
    public const int IMAGE_BITMAP = 0;

    [NativeTypeName("#define IMAGE_ICON 1")]
    public const int IMAGE_ICON = 1;

    [NativeTypeName("#define IMAGE_CURSOR 2")]
    public const int IMAGE_CURSOR = 2;

    [NativeTypeName("#define IMAGE_ENHMETAFILE 3")]
    public const int IMAGE_ENHMETAFILE = 3;
}
