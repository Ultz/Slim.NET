// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class FR
{
    [NativeTypeName("#define FR_PRIVATE 0x10")]
    public const int FR_PRIVATE = 0x10;

    [NativeTypeName("#define FR_NOT_ENUM 0x20")]
    public const int FR_NOT_ENUM = 0x20;
}
