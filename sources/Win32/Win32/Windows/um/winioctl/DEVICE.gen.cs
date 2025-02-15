// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class DEVICE
{
    [NativeTypeName("#define DEVICE_DSM_FLAG_ENTIRE_DATA_SET_RANGE 0x00000001")]
    public const int DEVICE_DSM_FLAG_ENTIRE_DATA_SET_RANGE = 0x00000001;

    [NativeTypeName("#define DEVICE_DSM_FLAG_TRIM_NOT_FS_ALLOCATED 0x80000000")]
    public const uint DEVICE_DSM_FLAG_TRIM_NOT_FS_ALLOCATED = 0x80000000;

    [NativeTypeName("#define DEVICE_DSM_FLAG_TRIM_BYPASS_RZAT 0x40000000")]
    public const int DEVICE_DSM_FLAG_TRIM_BYPASS_RZAT = 0x40000000;

    [NativeTypeName("#define DEVICE_DSM_NOTIFY_FLAG_BEGIN 0x00000001")]
    public const int DEVICE_DSM_NOTIFY_FLAG_BEGIN = 0x00000001;

    [NativeTypeName("#define DEVICE_DSM_NOTIFY_FLAG_END 0x00000002")]
    public const int DEVICE_DSM_NOTIFY_FLAG_END = 0x00000002;

    [NativeTypeName("#define DEVICE_DSM_FLAG_ALLOCATION_CONSOLIDATEABLE_ONLY 0x40000000")]
    public const int DEVICE_DSM_FLAG_ALLOCATION_CONSOLIDATEABLE_ONLY = 0x40000000;

    [NativeTypeName("#define DEVICE_DSM_PARAMETERS_V1 1")]
    public const int DEVICE_DSM_PARAMETERS_V1 = 1;

    [NativeTypeName(
        "#define DEVICE_DATA_SET_LBP_STATE_PARAMETERS_VERSION_V1 DEVICE_DSM_PARAMETERS_V1"
    )]
    public const int DEVICE_DATA_SET_LBP_STATE_PARAMETERS_VERSION_V1 = 1;

    [NativeTypeName(
        "#define DEVICE_DSM_ALLOCATION_OUTPUT_V1 (sizeof(DEVICE_DSM_ALLOCATION_OUTPUT))"
    )]
    public const uint DEVICE_DSM_ALLOCATION_OUTPUT_V1 = (32);

    [NativeTypeName(
        "#define DEVICE_DATA_SET_LB_PROVISIONING_STATE_VERSION_V1 DEVICE_DSM_ALLOCATION_OUTPUT_V1"
    )]
    public const uint DEVICE_DATA_SET_LB_PROVISIONING_STATE_VERSION_V1 = (32);

    [NativeTypeName(
        "#define DEVICE_DSM_ALLOCATION_OUTPUT_V2 (sizeof(DEVICE_DSM_ALLOCATION_OUTPUT2))"
    )]
    public const uint DEVICE_DSM_ALLOCATION_OUTPUT_V2 = (40);

    [NativeTypeName(
        "#define DEVICE_DATA_SET_LB_PROVISIONING_STATE_VERSION_V2 DEVICE_DSM_ALLOCATION_OUTPUT_V2"
    )]
    public const uint DEVICE_DATA_SET_LB_PROVISIONING_STATE_VERSION_V2 = (40);

    [NativeTypeName("#define DEVICE_DSM_FLAG_REPAIR_INPUT_TOPOLOGY_ID_PRESENT 0x40000000")]
    public const int DEVICE_DSM_FLAG_REPAIR_INPUT_TOPOLOGY_ID_PRESENT = 0x40000000;

    [NativeTypeName("#define DEVICE_DSM_FLAG_REPAIR_OUTPUT_PARITY_EXTENT 0x20000000")]
    public const int DEVICE_DSM_FLAG_REPAIR_OUTPUT_PARITY_EXTENT = 0x20000000;

    [NativeTypeName("#define DEVICE_DSM_FLAG_SCRUB_SKIP_IN_SYNC 0x10000000")]
    public const int DEVICE_DSM_FLAG_SCRUB_SKIP_IN_SYNC = 0x10000000;

    [NativeTypeName("#define DEVICE_DSM_FLAG_SCRUB_OUTPUT_PARITY_EXTENT 0x20000000")]
    public const int DEVICE_DSM_FLAG_SCRUB_OUTPUT_PARITY_EXTENT = 0x20000000;

    [NativeTypeName("#define DEVICE_DSM_FLAG_PHYSICAL_ADDRESSES_OMIT_TOTAL_RANGES 0x10000000")]
    public const int DEVICE_DSM_FLAG_PHYSICAL_ADDRESSES_OMIT_TOTAL_RANGES = 0x10000000;

    [NativeTypeName("#define DEVICE_DSM_PHYSICAL_ADDRESS_HAS_MEMORY_ERROR ((LONGLONG)-1)")]
    public const long DEVICE_DSM_PHYSICAL_ADDRESS_HAS_MEMORY_ERROR = ((long)(-1));

    [NativeTypeName("#define DEVICE_DSM_PHYSICAL_ADDRESSES_OUTPUT_V1 1")]
    public const int DEVICE_DSM_PHYSICAL_ADDRESSES_OUTPUT_V1 = 1;

    [NativeTypeName(
        "#define DEVICE_DSM_PHYSICAL_ADDRESSES_OUTPUT_VERSION_V1 DEVICE_DSM_PHYSICAL_ADDRESSES_OUTPUT_V1"
    )]
    public const int DEVICE_DSM_PHYSICAL_ADDRESSES_OUTPUT_VERSION_V1 = 1;

    [NativeTypeName("#define DEVICE_STORAGE_NO_ERRORS 0x1")]
    public const int DEVICE_STORAGE_NO_ERRORS = 0x1;

    [NativeTypeName("#define DEVICE_DSM_RANGE_ERROR_OUTPUT_V1 1")]
    public const int DEVICE_DSM_RANGE_ERROR_OUTPUT_V1 = 1;

    [NativeTypeName(
        "#define DEVICE_DSM_RANGE_ERROR_INFO_VERSION_V1 DEVICE_DSM_RANGE_ERROR_OUTPUT_V1"
    )]
    public const int DEVICE_DSM_RANGE_ERROR_INFO_VERSION_V1 = 1;
}
