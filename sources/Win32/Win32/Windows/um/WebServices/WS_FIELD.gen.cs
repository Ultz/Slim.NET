// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class WS_FIELD
{
    public const int WS_FIELD_POINTER = 0x1;
    public const int WS_FIELD_OPTIONAL = 0x2;
    public const int WS_FIELD_NILLABLE = 0x4;
    public const int WS_FIELD_NILLABLE_ITEM = 0x8;
    public const int WS_FIELD_OTHER_NAMESPACE = 0x10;
}
