// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/immdev.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class UI
{
    [NativeTypeName("#define UI_CAP_SOFTKBD 0x00010000")]
    public const int UI_CAP_SOFTKBD = 0x00010000;
}
