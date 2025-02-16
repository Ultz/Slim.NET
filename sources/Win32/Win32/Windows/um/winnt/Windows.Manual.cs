// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    public static int MEMORY_ALLOCATION_ALIGNMENT
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return 8;
            }
            else
            {
                return 16;
            }
        }
    }
    public static int MAXIMUM_PROC_PER_GROUP
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return 32;
            }
            else
            {
                return 64;
            }
        }
    }

    [NativeTypeName("#define MAXIMUM_PROCESSORS MAXIMUM_PROC_PER_GROUP")]
    public static int MAXIMUM_PROCESSORS => MAXIMUM_PROC_PER_GROUP;

    [NativeTypeName("#define MAXIMUM_SUPPORTED_EXTENSION 512")]
    public const int MAXIMUM_SUPPORTED_EXTENSION = 512;

    [NativeTypeName("#define INITIAL_MXCSR 0x1f80")]
    public const int INITIAL_MXCSR = 0x1f80;

    [NativeTypeName("#define INITIAL_FPCSR 0x027f")]
    public const int INITIAL_FPCSR = 0x027f;

    [NativeTypeName("#define RUNTIME_FUNCTION_INDIRECT 0x1")]
    public const int RUNTIME_FUNCTION_INDIRECT = 0x1;

    [NativeTypeName("#define UNW_FLAG_NHANDLER 0x0")]
    public const int UNW_FLAG_NHANDLER = 0x0;

    [NativeTypeName("#define UNW_FLAG_EHANDLER 0x1")]
    public const int UNW_FLAG_EHANDLER = 0x1;

    [NativeTypeName("#define UNW_FLAG_UHANDLER 0x2")]
    public const int UNW_FLAG_UHANDLER = 0x2;

    [NativeTypeName("#define UNW_FLAG_CHAININFO 0x4")]
    public const int UNW_FLAG_CHAININFO = 0x4;

    [NativeTypeName("#define UNW_FLAG_NO_EPILOGUE 0x80000000UL")]
    public const uint UNW_FLAG_NO_EPILOGUE = 0x80000000U;

    [NativeTypeName("#define UNWIND_CHAIN_LIMIT 32")]
    public const int UNWIND_CHAIN_LIMIT = 32;

    [NativeTypeName(
        "#define OUT_OF_PROCESS_FUNCTION_TABLE_CALLBACK_EXPORT_NAME \"OutOfProcessFunctionTableCallback\""
    )]
    public static ReadOnlySpan<byte> OUT_OF_PROCESS_FUNCTION_TABLE_CALLBACK_EXPORT_NAME =>
        "OutOfProcessFunctionTableCallback"u8;

    [NativeTypeName("#define ARM64_MAX_BREAKPOINTS 8")]
    public const int ARM64_MAX_BREAKPOINTS = 8;

    [NativeTypeName("#define ARM64_MAX_WATCHPOINTS 2")]
    public const int ARM64_MAX_WATCHPOINTS = 2;

    [NativeTypeName("#define NONVOL_INT_NUMREG_ARM64 (11)")]
    public const int NONVOL_INT_NUMREG_ARM64 = (11);

    [NativeTypeName("#define NONVOL_FP_NUMREG_ARM64 (8)")]
    public const int NONVOL_FP_NUMREG_ARM64 = (8);

    [NativeTypeName("#define NONVOL_INT_SIZE_ARM64 (NONVOL_INT_NUMREG_ARM64 * sizeof(DWORD64))")]
    public const uint NONVOL_INT_SIZE_ARM64 = ((11) * 8);

    [NativeTypeName("#define NONVOL_FP_SIZE_ARM64 (NONVOL_FP_NUMREG_ARM64 * sizeof(double))")]
    public const uint NONVOL_FP_SIZE_ARM64 = ((8) * 8);

    [NativeTypeName("#define SIZE_OF_80387_REGISTERS 80")]
    public const int SIZE_OF_80387_REGISTERS = 80;

    [NativeTypeName("#define MEMORY_CURRENT_PARTITION_HANDLE ((HANDLE) (LONG_PTR) -1)")]
    public static HANDLE MEMORY_CURRENT_PARTITION_HANDLE => unchecked((HANDLE)((nint)(-1)));

    [NativeTypeName("#define MEMORY_SYSTEM_PARTITION_HANDLE ((HANDLE) (LONG_PTR) -2)")]
    public static HANDLE MEMORY_SYSTEM_PARTITION_HANDLE => unchecked((HANDLE)((nint)(-2)));

    [NativeTypeName("#define MEMORY_EXISTING_VAD_PARTITION_HANDLE ((HANDLE) (LONG_PTR) -3)")]
    public static HANDLE MEMORY_EXISTING_VAD_PARTITION_HANDLE => unchecked((HANDLE)((nint)(-3)));
}
