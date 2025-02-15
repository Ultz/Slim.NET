// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class WS_STRUCT
{
    public const int WS_STRUCT_ABSTRACT = 0x1;
    public const int WS_STRUCT_IGNORE_TRAILING_ELEMENT_CONTENT = 0x2;
    public const int WS_STRUCT_IGNORE_UNHANDLED_ATTRIBUTES = 0x4;
}
