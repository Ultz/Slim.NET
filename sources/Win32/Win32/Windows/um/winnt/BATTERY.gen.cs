// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class BATTERY
{
    [NativeTypeName("#define BATTERY_DISCHARGE_FLAGS_EVENTCODE_MASK 0x00000007")]
    public const int BATTERY_DISCHARGE_FLAGS_EVENTCODE_MASK = 0x00000007;

    [NativeTypeName("#define BATTERY_DISCHARGE_FLAGS_ENABLE 0x80000000")]
    public const uint BATTERY_DISCHARGE_FLAGS_ENABLE = 0x80000000;
}
