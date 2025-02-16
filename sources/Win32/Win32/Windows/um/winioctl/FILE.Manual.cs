// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class FILE
{
    [NativeTypeName("#define FILE_REGION_USAGE_HUGE_PAGE_ALIGNMENT 0x00000010")]
    public static int FILE_REGION_USAGE_HUGE_PAGE_ALIGNMENT
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return 0;
            }
            else
            {
                return 0x00000010;
            }
        }
    }

    [NativeTypeName(
        "#define FILE_REGION_USAGE_QUERY_ALIGNMENT (FILE_REGION_USAGE_LARGE_PAGE_ALIGNMENT   |\\\r\n                                                 FILE_REGION_USAGE_HUGE_PAGE_ALIGNMENT)"
    )]
    public static readonly int FILE_REGION_USAGE_QUERY_ALIGNMENT =
        FILE_REGION_USAGE_LARGE_PAGE_ALIGNMENT | FILE_REGION_USAGE_HUGE_PAGE_ALIGNMENT;
    public static ref readonly Guid FILE_TYPE_NOTIFICATION_GUID_PAGE_FILE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x64,
                0x0A,
                0x0D,
                0xFC,
                0x38,
                0xB8,
                0x4D,
                0x9F,
                0xE7,
                0x3F,
                0x43,
                0x52,
                0xCD,
                0x7C,
                0x5C,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid FILE_TYPE_NOTIFICATION_GUID_HIBERNATION_FILE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x64,
                0x4D,
                0x62,
                0xB7,
                0xA3,
                0xB9,
                0xF8,
                0x4C,
                0x80,
                0x11,
                0x5B,
                0x86,
                0xC9,
                0x40,
                0xE7,
                0xB7,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid FILE_TYPE_NOTIFICATION_GUID_CRASHDUMP_FILE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB7,
                0x3E,
                0x45,
                0x9D,
                0xA6,
                0xD2,
                0xBD,
                0x4D,
                0xA2,
                0xE3,
                0xFB,
                0xD0,
                0xED,
                0x91,
                0x09,
                0xA9,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
