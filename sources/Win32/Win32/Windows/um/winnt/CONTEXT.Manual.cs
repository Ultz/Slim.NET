// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Intrinsics.Arm;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class SYSTEM
{
    [NativeTypeName("#define CONTEXT_AMD64 0x00100000L")]
    public const int CONTEXT_AMD64 = 0x00100000;

    [NativeTypeName("#define CONTEXT_CONTROL (CONTEXT_AMD64 | 0x00000001L)")]
    public const int CONTEXT_AMD64_CONTROL = (0x00100000 | 0x00000001);

    [NativeTypeName("#define CONTEXT_INTEGER (CONTEXT_AMD64 | 0x00000002L)")]
    public const int CONTEXT_AMD64_INTEGER = (0x00100000 | 0x00000002);

    [NativeTypeName("#define CONTEXT_SEGMENTS (CONTEXT_AMD64 | 0x00000004L)")]
    public const int CONTEXT_AMD64_SEGMENTS = (0x00100000 | 0x00000004);

    [NativeTypeName("#define CONTEXT_FLOATING_POINT (CONTEXT_AMD64 | 0x00000008L)")]
    public const int CONTEXT_AMD64_FLOATING_POINT = (0x00100000 | 0x00000008);

    [NativeTypeName("#define CONTEXT_DEBUG_REGISTERS (CONTEXT_AMD64 | 0x00000010L)")]
    public const int CONTEXT_AMD64_DEBUG_REGISTERS = (0x00100000 | 0x00000010);

    [NativeTypeName(
        "#define CONTEXT_FULL (CONTEXT_CONTROL | CONTEXT_INTEGER | \\\r\n                                 CONTEXT_FLOATING_POINT)"
    )]
    public const int CONTEXT_AMD64_FULL = (
        (0x00100000 | 0x00000001) | (0x00100000 | 0x00000002) | (0x00100000 | 0x00000008)
    );

    [NativeTypeName(
        "#define CONTEXT_ALL (CONTEXT_CONTROL | CONTEXT_INTEGER | \\\r\n                                 CONTEXT_SEGMENTS | CONTEXT_FLOATING_POINT | \\\r\n                                 CONTEXT_DEBUG_REGISTERS)"
    )]
    public const int CONTEXT_AMD64_ALL = (
        (0x00100000 | 0x00000001)
        | (0x00100000 | 0x00000002)
        | (0x00100000 | 0x00000004)
        | (0x00100000 | 0x00000008)
        | (0x00100000 | 0x00000010)
    );

    [NativeTypeName("#define CONTEXT_XSTATE (CONTEXT_AMD64 | 0x00000040L)")]
    public const int CONTEXT_AMD64_XSTATE = (0x00100000 | 0x00000040);

    [NativeTypeName("#define CONTEXT_KERNEL_CET (CONTEXT_AMD64 | 0x00000080L)")]
    public const int CONTEXT_AMD64_KERNEL_CET = (0x00100000 | 0x00000080);

    [NativeTypeName("#define CONTEXT_UNWOUND_TO_CALL 0x20000000")]
    public const int CONTEXT_AMD64_UNWOUND_TO_CALL = 0x20000000;

    [NativeTypeName("#define CONTEXT_ARM64 0x00400000L")]
    public const int CONTEXT_ARM64 = 0x00400000;

    [NativeTypeName("#define CONTEXT_ARM64_CONTROL (CONTEXT_ARM64 | 0x1L)")]
    public const int CONTEXT_ARM64_CONTROL = (0x00400000 | 0x1);

    [NativeTypeName("#define CONTEXT_ARM64_INTEGER (CONTEXT_ARM64 | 0x2L)")]
    public const int CONTEXT_ARM64_INTEGER = (0x00400000 | 0x2);

    [NativeTypeName("#define CONTEXT_ARM64_FLOATING_POINT (CONTEXT_ARM64 | 0x4L)")]
    public const int CONTEXT_ARM64_FLOATING_POINT = (0x00400000 | 0x4);

    [NativeTypeName("#define CONTEXT_ARM64_DEBUG_REGISTERS (CONTEXT_ARM64 | 0x8L)")]
    public const int CONTEXT_ARM64_DEBUG_REGISTERS = (0x00400000 | 0x8);

    [NativeTypeName("#define CONTEXT_ARM64_X18 (CONTEXT_ARM64 | 0x10L)")]
    public const int CONTEXT_ARM64_X18 = (0x00400000 | 0x10);

    [NativeTypeName(
        "#define CONTEXT_ARM64_FULL (CONTEXT_ARM64_CONTROL | CONTEXT_ARM64_INTEGER | CONTEXT_ARM64_FLOATING_POINT)"
    )]
    public const int CONTEXT_ARM64_FULL = (
        (0x00400000 | 0x1) | (0x00400000 | 0x2) | (0x00400000 | 0x4)
    );

    [NativeTypeName(
        "#define CONTEXT_ARM64_ALL (CONTEXT_ARM64_CONTROL | CONTEXT_ARM64_INTEGER | CONTEXT_ARM64_FLOATING_POINT | CONTEXT_ARM64_DEBUG_REGISTERS | CONTEXT_ARM64_X18)"
    )]
    public const int CONTEXT_ARM64_ALL = (
        (0x00400000 | 0x1)
        | (0x00400000 | 0x2)
        | (0x00400000 | 0x4)
        | (0x00400000 | 0x8)
        | (0x00400000 | 0x10)
    );

    [NativeTypeName("#define CONTEXT_ARM64_UNWOUND_TO_CALL 0x20000000")]
    public const int CONTEXT_ARM64_UNWOUND_TO_CALL = 0x20000000;

    [NativeTypeName("#define CONTEXT_ARM64_RET_TO_GUEST 0x04000000")]
    public const int CONTEXT_ARM64_RET_TO_GUEST = 0x04000000;

    [NativeTypeName("#define CONTEXT_UNWOUND_TO_CALL CONTEXT_ARM64_UNWOUND_TO_CALL")]
    public static int CONTEXT_UNWOUND_TO_CALL
    {
        get
        {
            if (ArmBase.Arm64.IsSupported)
            {
                return CONTEXT_ARM64_UNWOUND_TO_CALL;
            }
            else
            {
                return 0;
            }
        }
    }

    [NativeTypeName("#define CONTEXT_RET_TO_GUEST CONTEXT_ARM64_RET_TO_GUEST")]
    public static int CONTEXT_RET_TO_GUEST
    {
        get
        {
            if (ArmBase.Arm64.IsSupported)
            {
                return 0x04000000;
            }
            else
            {
                return 0;
            }
        }
    }

    [NativeTypeName("#define CONTEXT_i386 0x00010000L")]
    public const int CONTEXT_i386 = 0x00010000;

    [NativeTypeName("#define CONTEXT_i486 0x00010000L")]
    public const int CONTEXT_i486 = 0x00010000;

    [NativeTypeName("#define CONTEXT_CONTROL (CONTEXT_i386 | 0x00000001L)")]
    public const int CONTEXT_i386_CONTROL = (0x00010000 | 0x00000001);

    [NativeTypeName("#define CONTEXT_INTEGER (CONTEXT_i386 | 0x00000002L)")]
    public const int CONTEXT_i386_INTEGER = (0x00010000 | 0x00000002);

    [NativeTypeName("#define CONTEXT_SEGMENTS (CONTEXT_i386 | 0x00000004L)")]
    public const int CONTEXT_i386_SEGMENTS = (0x00010000 | 0x00000004);

    [NativeTypeName("#define CONTEXT_FLOATING_POINT (CONTEXT_i386 | 0x00000008L)")]
    public const int CONTEXT_i386_FLOATING_POINT = (0x00010000 | 0x00000008);

    [NativeTypeName("#define CONTEXT_DEBUG_REGISTERS (CONTEXT_i386 | 0x00000010L)")]
    public const int CONTEXT_i386_DEBUG_REGISTERS = (0x00010000 | 0x00000010);

    [NativeTypeName("#define CONTEXT_EXTENDED_REGISTERS (CONTEXT_i386 | 0x00000020L)")]
    public const int CONTEXT_i386_EXTENDED_REGISTERS = (0x00010000 | 0x00000020);

    [NativeTypeName(
        "#define CONTEXT_FULL (CONTEXT_CONTROL | CONTEXT_INTEGER |\\\r\n                      CONTEXT_SEGMENTS)"
    )]
    public const int CONTEXT_i386_FULL = (
        (0x00010000 | 0x00000001) | (0x00010000 | 0x00000002) | (0x00010000 | 0x00000004)
    );

    [NativeTypeName(
        "#define CONTEXT_ALL (CONTEXT_CONTROL | CONTEXT_INTEGER | CONTEXT_SEGMENTS | \\\r\n                                 CONTEXT_FLOATING_POINT | CONTEXT_DEBUG_REGISTERS | \\\r\n                                 CONTEXT_EXTENDED_REGISTERS)"
    )]
    public const int CONTEXT_i386_ALL = (
        (0x00010000 | 0x00000001)
        | (0x00010000 | 0x00000002)
        | (0x00010000 | 0x00000004)
        | (0x00010000 | 0x00000008)
        | (0x00010000 | 0x00000010)
        | (0x00010000 | 0x00000020)
    );

    [NativeTypeName("#define CONTEXT_XSTATE (CONTEXT_i386 | 0x00000040L)")]
    public const int CONTEXT_i386_XSTATE = (0x00010000 | 0x00000040);
}
