// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IOCTL
{
    [NativeTypeName("#define IOCTL_STORAGE_BASE FILE_DEVICE_MASS_STORAGE")]
    public const int IOCTL_STORAGE_BASE = 0x0000002d;

    [NativeTypeName(
        "#define IOCTL_STORAGE_CHECK_VERIFY CTL_CODE(IOCTL_STORAGE_BASE, 0x0200, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_STORAGE_CHECK_VERIFY = (
        ((0x0000002d) << 16) | (((0x0001)) << 14) | ((0x0200) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_CHECK_VERIFY2 CTL_CODE(IOCTL_STORAGE_BASE, 0x0200, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_STORAGE_CHECK_VERIFY2 = (
        ((0x0000002d) << 16) | ((0) << 14) | ((0x0200) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_MEDIA_REMOVAL CTL_CODE(IOCTL_STORAGE_BASE, 0x0201, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_STORAGE_MEDIA_REMOVAL = (
        ((0x0000002d) << 16) | (((0x0001)) << 14) | ((0x0201) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_EJECT_MEDIA CTL_CODE(IOCTL_STORAGE_BASE, 0x0202, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_STORAGE_EJECT_MEDIA = (
        ((0x0000002d) << 16) | (((0x0001)) << 14) | ((0x0202) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_LOAD_MEDIA CTL_CODE(IOCTL_STORAGE_BASE, 0x0203, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_STORAGE_LOAD_MEDIA = (
        ((0x0000002d) << 16) | (((0x0001)) << 14) | ((0x0203) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_LOAD_MEDIA2 CTL_CODE(IOCTL_STORAGE_BASE, 0x0203, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_STORAGE_LOAD_MEDIA2 = (
        ((0x0000002d) << 16) | ((0) << 14) | ((0x0203) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_RESERVE CTL_CODE(IOCTL_STORAGE_BASE, 0x0204, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_STORAGE_RESERVE = (
        ((0x0000002d) << 16) | (((0x0001)) << 14) | ((0x0204) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_RELEASE CTL_CODE(IOCTL_STORAGE_BASE, 0x0205, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_STORAGE_RELEASE = (
        ((0x0000002d) << 16) | (((0x0001)) << 14) | ((0x0205) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_FIND_NEW_DEVICES CTL_CODE(IOCTL_STORAGE_BASE, 0x0206, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_STORAGE_FIND_NEW_DEVICES = (
        ((0x0000002d) << 16) | (((0x0001)) << 14) | ((0x0206) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_EJECTION_CONTROL CTL_CODE(IOCTL_STORAGE_BASE, 0x0250, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_STORAGE_EJECTION_CONTROL = (
        ((0x0000002d) << 16) | ((0) << 14) | ((0x0250) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_MCN_CONTROL CTL_CODE(IOCTL_STORAGE_BASE, 0x0251, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_STORAGE_MCN_CONTROL = (
        ((0x0000002d) << 16) | ((0) << 14) | ((0x0251) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_GET_MEDIA_TYPES CTL_CODE(IOCTL_STORAGE_BASE, 0x0300, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_STORAGE_GET_MEDIA_TYPES = (
        ((0x0000002d) << 16) | ((0) << 14) | ((0x0300) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_GET_MEDIA_TYPES_EX CTL_CODE(IOCTL_STORAGE_BASE, 0x0301, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_STORAGE_GET_MEDIA_TYPES_EX = (
        ((0x0000002d) << 16) | ((0) << 14) | ((0x0301) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_GET_MEDIA_SERIAL_NUMBER CTL_CODE(IOCTL_STORAGE_BASE, 0x0304, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_STORAGE_GET_MEDIA_SERIAL_NUMBER = (
        ((0x0000002d) << 16) | ((0) << 14) | ((0x0304) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_GET_HOTPLUG_INFO CTL_CODE(IOCTL_STORAGE_BASE, 0x0305, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_STORAGE_GET_HOTPLUG_INFO = (
        ((0x0000002d) << 16) | ((0) << 14) | ((0x0305) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_SET_HOTPLUG_INFO CTL_CODE(IOCTL_STORAGE_BASE, 0x0306, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_STORAGE_SET_HOTPLUG_INFO = (
        ((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0306) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_RESET_BUS CTL_CODE(IOCTL_STORAGE_BASE, 0x0400, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_STORAGE_RESET_BUS = (
        ((0x0000002d) << 16) | (((0x0001)) << 14) | ((0x0400) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_RESET_DEVICE CTL_CODE(IOCTL_STORAGE_BASE, 0x0401, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_STORAGE_RESET_DEVICE = (
        ((0x0000002d) << 16) | (((0x0001)) << 14) | ((0x0401) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_BREAK_RESERVATION CTL_CODE(IOCTL_STORAGE_BASE, 0x0405, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_STORAGE_BREAK_RESERVATION = (
        ((0x0000002d) << 16) | (((0x0001)) << 14) | ((0x0405) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_PERSISTENT_RESERVE_IN CTL_CODE(IOCTL_STORAGE_BASE, 0x0406, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_STORAGE_PERSISTENT_RESERVE_IN = (
        ((0x0000002d) << 16) | (((0x0001)) << 14) | ((0x0406) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_PERSISTENT_RESERVE_OUT CTL_CODE(IOCTL_STORAGE_BASE, 0x0407, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_STORAGE_PERSISTENT_RESERVE_OUT = (
        ((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0407) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_GET_DEVICE_NUMBER CTL_CODE(IOCTL_STORAGE_BASE, 0x0420, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_STORAGE_GET_DEVICE_NUMBER = (
        ((0x0000002d) << 16) | ((0) << 14) | ((0x0420) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_GET_DEVICE_NUMBER_EX CTL_CODE(IOCTL_STORAGE_BASE, 0x0421, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_STORAGE_GET_DEVICE_NUMBER_EX = (
        ((0x0000002d) << 16) | ((0) << 14) | ((0x0421) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_PREDICT_FAILURE CTL_CODE(IOCTL_STORAGE_BASE, 0x0440, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_STORAGE_PREDICT_FAILURE = (
        ((0x0000002d) << 16) | ((0) << 14) | ((0x0440) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_FAILURE_PREDICTION_CONFIG CTL_CODE(IOCTL_STORAGE_BASE, 0x0441, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_STORAGE_FAILURE_PREDICTION_CONFIG = (
        ((0x0000002d) << 16) | ((0) << 14) | ((0x0441) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_GET_COUNTERS CTL_CODE(IOCTL_STORAGE_BASE, 0x442, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_STORAGE_GET_COUNTERS = (
        ((0x0000002d) << 16) | ((0) << 14) | ((0x442) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_READ_CAPACITY CTL_CODE(IOCTL_STORAGE_BASE, 0x0450, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_STORAGE_READ_CAPACITY = (
        ((0x0000002d) << 16) | (((0x0001)) << 14) | ((0x0450) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_GET_DEVICE_TELEMETRY CTL_CODE(IOCTL_STORAGE_BASE, 0x0470, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_STORAGE_GET_DEVICE_TELEMETRY = (
        ((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0470) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_DEVICE_TELEMETRY_NOTIFY CTL_CODE(IOCTL_STORAGE_BASE, 0x0471, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_STORAGE_DEVICE_TELEMETRY_NOTIFY = (
        ((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0471) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_DEVICE_TELEMETRY_QUERY_CAPS CTL_CODE(IOCTL_STORAGE_BASE, 0x0472, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_STORAGE_DEVICE_TELEMETRY_QUERY_CAPS = (
        ((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0472) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_GET_DEVICE_TELEMETRY_RAW CTL_CODE(IOCTL_STORAGE_BASE, 0x0473, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_STORAGE_GET_DEVICE_TELEMETRY_RAW = (
        ((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0473) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_SET_TEMPERATURE_THRESHOLD CTL_CODE(IOCTL_STORAGE_BASE, 0x0480, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    [SupportedOSPlatform("windows10.0")]
    public const int IOCTL_STORAGE_SET_TEMPERATURE_THRESHOLD = (
        ((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0480) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_PROTOCOL_COMMAND CTL_CODE(IOCTL_STORAGE_BASE, 0x04F0, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_STORAGE_PROTOCOL_COMMAND = (
        ((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x04F0) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_SET_PROPERTY CTL_CODE(IOCTL_STORAGE_BASE, 0x04FF, METHOD_BUFFERED, FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_STORAGE_SET_PROPERTY = (
        ((0x0000002d) << 16) | (((0x0002)) << 14) | ((0x04FF) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_QUERY_PROPERTY CTL_CODE(IOCTL_STORAGE_BASE, 0x0500, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    [SupportedOSPlatform("windows10.0")]
    public const int IOCTL_STORAGE_QUERY_PROPERTY = (
        ((0x0000002d) << 16) | ((0) << 14) | ((0x0500) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_MANAGE_DATA_SET_ATTRIBUTES CTL_CODE(IOCTL_STORAGE_BASE, 0x0501, METHOD_BUFFERED, FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_STORAGE_MANAGE_DATA_SET_ATTRIBUTES = (
        ((0x0000002d) << 16) | (((0x0002)) << 14) | ((0x0501) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_GET_LB_PROVISIONING_MAP_RESOURCES CTL_CODE(IOCTL_STORAGE_BASE, 0x0502, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_STORAGE_GET_LB_PROVISIONING_MAP_RESOURCES = (
        ((0x0000002d) << 16) | (((0x0001)) << 14) | ((0x0502) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_REINITIALIZE_MEDIA CTL_CODE(IOCTL_STORAGE_BASE, 0x0590, METHOD_BUFFERED, FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_STORAGE_REINITIALIZE_MEDIA = (
        ((0x0000002d) << 16) | (((0x0002)) << 14) | ((0x0590) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_GET_BC_PROPERTIES CTL_CODE(IOCTL_STORAGE_BASE, 0x0600, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_STORAGE_GET_BC_PROPERTIES = (
        ((0x0000002d) << 16) | (((0x0001)) << 14) | ((0x0600) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_ALLOCATE_BC_STREAM CTL_CODE(IOCTL_STORAGE_BASE, 0x0601, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_STORAGE_ALLOCATE_BC_STREAM = (
        ((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0601) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_FREE_BC_STREAM CTL_CODE(IOCTL_STORAGE_BASE, 0x0602, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_STORAGE_FREE_BC_STREAM = (
        ((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0602) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_CHECK_PRIORITY_HINT_SUPPORT CTL_CODE(IOCTL_STORAGE_BASE, 0x0620, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_STORAGE_CHECK_PRIORITY_HINT_SUPPORT = (
        ((0x0000002d) << 16) | ((0) << 14) | ((0x0620) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_START_DATA_INTEGRITY_CHECK CTL_CODE(IOCTL_STORAGE_BASE, 0x0621, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_STORAGE_START_DATA_INTEGRITY_CHECK = (
        ((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0621) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_STOP_DATA_INTEGRITY_CHECK CTL_CODE(IOCTL_STORAGE_BASE, 0x0622, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_STORAGE_STOP_DATA_INTEGRITY_CHECK = (
        ((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0622) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_FIRMWARE_GET_INFO CTL_CODE(IOCTL_STORAGE_BASE, 0x0700, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    [SupportedOSPlatform("windows10.0")]
    public const int IOCTL_STORAGE_FIRMWARE_GET_INFO = (
        ((0x0000002d) << 16) | ((0) << 14) | ((0x0700) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_FIRMWARE_DOWNLOAD CTL_CODE(IOCTL_STORAGE_BASE, 0x0701, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    [SupportedOSPlatform("windows10.0")]
    public const int IOCTL_STORAGE_FIRMWARE_DOWNLOAD = (
        ((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0701) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_FIRMWARE_ACTIVATE CTL_CODE(IOCTL_STORAGE_BASE, 0x0702, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    [SupportedOSPlatform("windows10.0")]
    public const int IOCTL_STORAGE_FIRMWARE_ACTIVATE = (
        ((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0702) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_ENABLE_IDLE_POWER CTL_CODE(IOCTL_STORAGE_BASE, 0x0720, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_STORAGE_ENABLE_IDLE_POWER = (
        ((0x0000002d) << 16) | ((0) << 14) | ((0x0720) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_GET_IDLE_POWERUP_REASON CTL_CODE(IOCTL_STORAGE_BASE, 0x0721, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_STORAGE_GET_IDLE_POWERUP_REASON = (
        ((0x0000002d) << 16) | ((0) << 14) | ((0x0721) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_POWER_ACTIVE CTL_CODE(IOCTL_STORAGE_BASE, 0x0722, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_STORAGE_POWER_ACTIVE = (
        ((0x0000002d) << 16) | ((0) << 14) | ((0x0722) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_POWER_IDLE CTL_CODE(IOCTL_STORAGE_BASE, 0x0723, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_STORAGE_POWER_IDLE = (
        ((0x0000002d) << 16) | ((0) << 14) | ((0x0723) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_EVENT_NOTIFICATION CTL_CODE(IOCTL_STORAGE_BASE, 0x0724, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_STORAGE_EVENT_NOTIFICATION = (
        ((0x0000002d) << 16) | ((0) << 14) | ((0x0724) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_DEVICE_POWER_CAP CTL_CODE(IOCTL_STORAGE_BASE, 0x0725, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    [SupportedOSPlatform("windows10.0")]
    public const int IOCTL_STORAGE_DEVICE_POWER_CAP = (
        ((0x0000002d) << 16) | ((0) << 14) | ((0x0725) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_RPMB_COMMAND CTL_CODE(IOCTL_STORAGE_BASE, 0x0726, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_STORAGE_RPMB_COMMAND = (
        ((0x0000002d) << 16) | ((0) << 14) | ((0x0726) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_ATTRIBUTE_MANAGEMENT CTL_CODE(IOCTL_STORAGE_BASE, 0x0727, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_STORAGE_ATTRIBUTE_MANAGEMENT = (
        ((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0727) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_DIAGNOSTIC CTL_CODE(IOCTL_STORAGE_BASE, 0x0728, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_STORAGE_DIAGNOSTIC = (
        ((0x0000002d) << 16) | ((0) << 14) | ((0x0728) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_GET_PHYSICAL_ELEMENT_STATUS CTL_CODE(IOCTL_STORAGE_BASE, 0x0729, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_STORAGE_GET_PHYSICAL_ELEMENT_STATUS = (
        ((0x0000002d) << 16) | ((0) << 14) | ((0x0729) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_REMOVE_ELEMENT_AND_TRUNCATE CTL_CODE(IOCTL_STORAGE_BASE, 0x0730, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_STORAGE_REMOVE_ELEMENT_AND_TRUNCATE = (
        ((0x0000002d) << 16) | ((0) << 14) | ((0x0730) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_STORAGE_GET_DEVICE_INTERNAL_LOG CTL_CODE(IOCTL_STORAGE_BASE, 0x0731, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_STORAGE_GET_DEVICE_INTERNAL_LOG = (
        ((0x0000002d) << 16) | ((0) << 14) | ((0x0731) << 2) | (0)
    );

    [NativeTypeName("#define IOCTL_STORAGE_BC_VERSION 1")]
    public const int IOCTL_STORAGE_BC_VERSION = 1;

    [NativeTypeName("#define IOCTL_SCMBUS_BASE FILE_DEVICE_PERSISTENT_MEMORY")]
    public const int IOCTL_SCMBUS_BASE = 0x00000059;

    [NativeTypeName("#define IOCTL_SCMBUS_DEVICE_FUNCTION_BASE 0x0")]
    public const int IOCTL_SCMBUS_DEVICE_FUNCTION_BASE = 0x0;

    [NativeTypeName("#define IOCTL_SCM_LOGICAL_DEVICE_FUNCTION_BASE 0x300")]
    public const int IOCTL_SCM_LOGICAL_DEVICE_FUNCTION_BASE = 0x300;

    [NativeTypeName("#define IOCTL_SCM_PHYSICAL_DEVICE_FUNCTION_BASE 0x600")]
    public const int IOCTL_SCM_PHYSICAL_DEVICE_FUNCTION_BASE = 0x600;

    [NativeTypeName(
        "#define IOCTL_SCM_BUS_GET_LOGICAL_DEVICES CTL_CODE(IOCTL_SCMBUS_BASE, SCMBUS_FUNCTION(0x00), METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_SCM_BUS_GET_LOGICAL_DEVICES = (
        ((0x00000059) << 16) | ((0) << 14) | (((0x0 + 0x00)) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_SCM_BUS_GET_PHYSICAL_DEVICES CTL_CODE(IOCTL_SCMBUS_BASE, SCMBUS_FUNCTION(0x01), METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_SCM_BUS_GET_PHYSICAL_DEVICES = (
        ((0x00000059) << 16) | ((0) << 14) | (((0x0 + 0x01)) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_SCM_BUS_GET_REGIONS CTL_CODE(IOCTL_SCMBUS_BASE, SCMBUS_FUNCTION(0x02), METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_SCM_BUS_GET_REGIONS = (
        ((0x00000059) << 16) | ((0) << 14) | (((0x0 + 0x02)) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_SCM_BUS_QUERY_PROPERTY CTL_CODE(IOCTL_SCMBUS_BASE, SCMBUS_FUNCTION(0x03), METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_SCM_BUS_QUERY_PROPERTY = (
        ((0x00000059) << 16) | ((0) << 14) | (((0x0 + 0x03)) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_SCM_BUS_SET_PROPERTY CTL_CODE(IOCTL_SCMBUS_BASE, SCMBUS_FUNCTION(0x05), METHOD_BUFFERED, FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_SCM_BUS_SET_PROPERTY = (
        ((0x00000059) << 16) | (((0x0002)) << 14) | (((0x0 + 0x05)) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_SCM_BUS_RUNTIME_FW_ACTIVATE CTL_CODE(IOCTL_SCMBUS_BASE, SCMBUS_FUNCTION(0x04), METHOD_BUFFERED, FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_SCM_BUS_RUNTIME_FW_ACTIVATE = (
        ((0x00000059) << 16) | (((0x0002)) << 14) | (((0x0 + 0x04)) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_SCM_BUS_REFRESH_NAMESPACE CTL_CODE(IOCTL_SCMBUS_BASE, SCMBUS_FUNCTION(0x06), METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_SCM_BUS_REFRESH_NAMESPACE = (
        ((0x00000059) << 16) | ((0) << 14) | (((0x0 + 0x06)) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_SCM_LD_GET_INTERLEAVE_SET CTL_CODE(IOCTL_SCMBUS_BASE, SCM_LOGICAL_DEVICE_FUNCTION(0x00), METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_SCM_LD_GET_INTERLEAVE_SET = (
        ((0x00000059) << 16) | ((0) << 14) | (((0x300 + 0x00)) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_SCM_PD_QUERY_PROPERTY CTL_CODE(IOCTL_SCMBUS_BASE, SCM_PHYSICAL_DEVICE_FUNCTION(0x00), METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_SCM_PD_QUERY_PROPERTY = (
        ((0x00000059) << 16) | ((0) << 14) | (((0x600 + 0x00)) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_SCM_PD_FIRMWARE_DOWNLOAD CTL_CODE(IOCTL_SCMBUS_BASE, SCM_PHYSICAL_DEVICE_FUNCTION(0x01), METHOD_BUFFERED, FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_SCM_PD_FIRMWARE_DOWNLOAD = (
        ((0x00000059) << 16) | (((0x0002)) << 14) | (((0x600 + 0x01)) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_SCM_PD_FIRMWARE_ACTIVATE CTL_CODE(IOCTL_SCMBUS_BASE, SCM_PHYSICAL_DEVICE_FUNCTION(0x02), METHOD_BUFFERED, FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_SCM_PD_FIRMWARE_ACTIVATE = (
        ((0x00000059) << 16) | (((0x0002)) << 14) | (((0x600 + 0x02)) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_SCM_PD_PASSTHROUGH CTL_CODE(IOCTL_SCMBUS_BASE, SCM_PHYSICAL_DEVICE_FUNCTION(0x03), METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_SCM_PD_PASSTHROUGH = (
        ((0x00000059) << 16) | (((0x0001) | (0x0002)) << 14) | (((0x600 + 0x03)) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_SCM_PD_UPDATE_MANAGEMENT_STATUS CTL_CODE(IOCTL_SCMBUS_BASE, SCM_PHYSICAL_DEVICE_FUNCTION(0x04), METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_SCM_PD_UPDATE_MANAGEMENT_STATUS = (
        ((0x00000059) << 16) | ((0) << 14) | (((0x600 + 0x04)) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_SCM_PD_REINITIALIZE_MEDIA CTL_CODE(IOCTL_SCMBUS_BASE, SCM_PHYSICAL_DEVICE_FUNCTION(0x05), METHOD_BUFFERED, FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_SCM_PD_REINITIALIZE_MEDIA = (
        ((0x00000059) << 16) | (((0x0002)) << 14) | (((0x600 + 0x05)) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_SCM_PD_SET_PROPERTY CTL_CODE(IOCTL_SCMBUS_BASE, SCM_PHYSICAL_DEVICE_FUNCTION(0x06), METHOD_BUFFERED, FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_SCM_PD_SET_PROPERTY = (
        ((0x00000059) << 16) | (((0x0002)) << 14) | (((0x600 + 0x06)) << 2) | (0)
    );

    [NativeTypeName("#define IOCTL_DISK_BASE FILE_DEVICE_DISK")]
    public const int IOCTL_DISK_BASE = 0x00000007;

    [NativeTypeName(
        "#define IOCTL_DISK_GET_DRIVE_GEOMETRY CTL_CODE(IOCTL_DISK_BASE, 0x0000, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_DISK_GET_DRIVE_GEOMETRY = (
        ((0x00000007) << 16) | ((0) << 14) | ((0x0000) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_GET_PARTITION_INFO CTL_CODE(IOCTL_DISK_BASE, 0x0001, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_DISK_GET_PARTITION_INFO = (
        ((0x00000007) << 16) | (((0x0001)) << 14) | ((0x0001) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_SET_PARTITION_INFO CTL_CODE(IOCTL_DISK_BASE, 0x0002, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_DISK_SET_PARTITION_INFO = (
        ((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0002) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_GET_DRIVE_LAYOUT CTL_CODE(IOCTL_DISK_BASE, 0x0003, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_DISK_GET_DRIVE_LAYOUT = (
        ((0x00000007) << 16) | (((0x0001)) << 14) | ((0x0003) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_SET_DRIVE_LAYOUT CTL_CODE(IOCTL_DISK_BASE, 0x0004, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_DISK_SET_DRIVE_LAYOUT = (
        ((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0004) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_VERIFY CTL_CODE(IOCTL_DISK_BASE, 0x0005, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_DISK_VERIFY = (
        ((0x00000007) << 16) | ((0) << 14) | ((0x0005) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_FORMAT_TRACKS CTL_CODE(IOCTL_DISK_BASE, 0x0006, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_DISK_FORMAT_TRACKS = (
        ((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0006) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_REASSIGN_BLOCKS CTL_CODE(IOCTL_DISK_BASE, 0x0007, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_DISK_REASSIGN_BLOCKS = (
        ((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0007) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_PERFORMANCE CTL_CODE(IOCTL_DISK_BASE, 0x0008, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_DISK_PERFORMANCE = (
        ((0x00000007) << 16) | ((0) << 14) | ((0x0008) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_IS_WRITABLE CTL_CODE(IOCTL_DISK_BASE, 0x0009, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_DISK_IS_WRITABLE = (
        ((0x00000007) << 16) | ((0) << 14) | ((0x0009) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_LOGGING CTL_CODE(IOCTL_DISK_BASE, 0x000a, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_DISK_LOGGING = (
        ((0x00000007) << 16) | ((0) << 14) | ((0x000a) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_FORMAT_TRACKS_EX CTL_CODE(IOCTL_DISK_BASE, 0x000b, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_DISK_FORMAT_TRACKS_EX = (
        ((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x000b) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_HISTOGRAM_STRUCTURE CTL_CODE(IOCTL_DISK_BASE, 0x000c, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_DISK_HISTOGRAM_STRUCTURE = (
        ((0x00000007) << 16) | ((0) << 14) | ((0x000c) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_HISTOGRAM_DATA CTL_CODE(IOCTL_DISK_BASE, 0x000d, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_DISK_HISTOGRAM_DATA = (
        ((0x00000007) << 16) | ((0) << 14) | ((0x000d) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_HISTOGRAM_RESET CTL_CODE(IOCTL_DISK_BASE, 0x000e, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_DISK_HISTOGRAM_RESET = (
        ((0x00000007) << 16) | ((0) << 14) | ((0x000e) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_REQUEST_STRUCTURE CTL_CODE(IOCTL_DISK_BASE, 0x000f, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_DISK_REQUEST_STRUCTURE = (
        ((0x00000007) << 16) | ((0) << 14) | ((0x000f) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_REQUEST_DATA CTL_CODE(IOCTL_DISK_BASE, 0x0010, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_DISK_REQUEST_DATA = (
        ((0x00000007) << 16) | ((0) << 14) | ((0x0010) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_PERFORMANCE_OFF CTL_CODE(IOCTL_DISK_BASE, 0x0018, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_DISK_PERFORMANCE_OFF = (
        ((0x00000007) << 16) | ((0) << 14) | ((0x0018) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_CONTROLLER_NUMBER CTL_CODE(IOCTL_DISK_BASE, 0x0011, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_DISK_CONTROLLER_NUMBER = (
        ((0x00000007) << 16) | ((0) << 14) | ((0x0011) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_GET_PARTITION_INFO_EX CTL_CODE(IOCTL_DISK_BASE, 0x0012, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_DISK_GET_PARTITION_INFO_EX = (
        ((0x00000007) << 16) | ((0) << 14) | ((0x0012) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_SET_PARTITION_INFO_EX CTL_CODE(IOCTL_DISK_BASE, 0x0013, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_DISK_SET_PARTITION_INFO_EX = (
        ((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0013) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_GET_DRIVE_LAYOUT_EX CTL_CODE(IOCTL_DISK_BASE, 0x0014, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_DISK_GET_DRIVE_LAYOUT_EX = (
        ((0x00000007) << 16) | ((0) << 14) | ((0x0014) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_SET_DRIVE_LAYOUT_EX CTL_CODE(IOCTL_DISK_BASE, 0x0015, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_DISK_SET_DRIVE_LAYOUT_EX = (
        ((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0015) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_CREATE_DISK CTL_CODE(IOCTL_DISK_BASE, 0x0016, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_DISK_CREATE_DISK = (
        ((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0016) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_GET_LENGTH_INFO CTL_CODE(IOCTL_DISK_BASE, 0x0017, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_DISK_GET_LENGTH_INFO = (
        ((0x00000007) << 16) | (((0x0001)) << 14) | ((0x0017) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_GET_DRIVE_GEOMETRY_EX CTL_CODE(IOCTL_DISK_BASE, 0x0028, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_DISK_GET_DRIVE_GEOMETRY_EX = (
        ((0x00000007) << 16) | ((0) << 14) | ((0x0028) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_REASSIGN_BLOCKS_EX CTL_CODE(IOCTL_DISK_BASE, 0x0029, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_DISK_REASSIGN_BLOCKS_EX = (
        ((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0029) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_UPDATE_DRIVE_SIZE CTL_CODE(IOCTL_DISK_BASE, 0x0032, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_DISK_UPDATE_DRIVE_SIZE = (
        ((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0032) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_GROW_PARTITION CTL_CODE(IOCTL_DISK_BASE, 0x0034, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_DISK_GROW_PARTITION = (
        ((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0034) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_GET_CACHE_INFORMATION CTL_CODE(IOCTL_DISK_BASE, 0x0035, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_DISK_GET_CACHE_INFORMATION = (
        ((0x00000007) << 16) | (((0x0001)) << 14) | ((0x0035) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_SET_CACHE_INFORMATION CTL_CODE(IOCTL_DISK_BASE, 0x0036, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_DISK_SET_CACHE_INFORMATION = (
        ((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0036) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_DELETE_DRIVE_LAYOUT CTL_CODE(IOCTL_DISK_BASE, 0x0040, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_DISK_DELETE_DRIVE_LAYOUT = (
        ((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0040) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_UPDATE_PROPERTIES CTL_CODE(IOCTL_DISK_BASE, 0x0050, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_DISK_UPDATE_PROPERTIES = (
        ((0x00000007) << 16) | ((0) << 14) | ((0x0050) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_FORMAT_DRIVE CTL_CODE(IOCTL_DISK_BASE, 0x00f3, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_DISK_FORMAT_DRIVE = (
        ((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x00f3) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_SENSE_DEVICE CTL_CODE(IOCTL_DISK_BASE, 0x00f8, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_DISK_SENSE_DEVICE = (
        ((0x00000007) << 16) | ((0) << 14) | ((0x00f8) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_CHECK_VERIFY CTL_CODE(IOCTL_DISK_BASE, 0x0200, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_DISK_CHECK_VERIFY = (
        ((0x00000007) << 16) | (((0x0001)) << 14) | ((0x0200) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_MEDIA_REMOVAL CTL_CODE(IOCTL_DISK_BASE, 0x0201, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_DISK_MEDIA_REMOVAL = (
        ((0x00000007) << 16) | (((0x0001)) << 14) | ((0x0201) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_EJECT_MEDIA CTL_CODE(IOCTL_DISK_BASE, 0x0202, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_DISK_EJECT_MEDIA = (
        ((0x00000007) << 16) | (((0x0001)) << 14) | ((0x0202) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_LOAD_MEDIA CTL_CODE(IOCTL_DISK_BASE, 0x0203, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_DISK_LOAD_MEDIA = (
        ((0x00000007) << 16) | (((0x0001)) << 14) | ((0x0203) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_RESERVE CTL_CODE(IOCTL_DISK_BASE, 0x0204, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_DISK_RESERVE = (
        ((0x00000007) << 16) | (((0x0001)) << 14) | ((0x0204) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_RELEASE CTL_CODE(IOCTL_DISK_BASE, 0x0205, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_DISK_RELEASE = (
        ((0x00000007) << 16) | (((0x0001)) << 14) | ((0x0205) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_FIND_NEW_DEVICES CTL_CODE(IOCTL_DISK_BASE, 0x0206, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_DISK_FIND_NEW_DEVICES = (
        ((0x00000007) << 16) | (((0x0001)) << 14) | ((0x0206) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_GET_MEDIA_TYPES CTL_CODE(IOCTL_DISK_BASE, 0x0300, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_DISK_GET_MEDIA_TYPES = (
        ((0x00000007) << 16) | ((0) << 14) | ((0x0300) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_GET_DISK_ATTRIBUTES CTL_CODE(IOCTL_DISK_BASE, 0x003c, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_DISK_GET_DISK_ATTRIBUTES = (
        ((0x00000007) << 16) | ((0) << 14) | ((0x003c) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_SET_DISK_ATTRIBUTES CTL_CODE(IOCTL_DISK_BASE, 0x003d, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_DISK_SET_DISK_ATTRIBUTES = (
        ((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x003d) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_DISK_RESET_SNAPSHOT_INFO CTL_CODE(IOCTL_DISK_BASE, 0x0084, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_DISK_RESET_SNAPSHOT_INFO = (
        ((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0084) << 2) | (0)
    );

    [NativeTypeName("#define IOCTL_CHANGER_BASE FILE_DEVICE_CHANGER")]
    public const int IOCTL_CHANGER_BASE = 0x00000030;

    [NativeTypeName(
        "#define IOCTL_CHANGER_GET_PARAMETERS CTL_CODE(IOCTL_CHANGER_BASE, 0x0000, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_CHANGER_GET_PARAMETERS = (
        ((0x00000030) << 16) | (((0x0001)) << 14) | ((0x0000) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_CHANGER_GET_STATUS CTL_CODE(IOCTL_CHANGER_BASE, 0x0001, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_CHANGER_GET_STATUS = (
        ((0x00000030) << 16) | (((0x0001)) << 14) | ((0x0001) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_CHANGER_GET_PRODUCT_DATA CTL_CODE(IOCTL_CHANGER_BASE, 0x0002, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_CHANGER_GET_PRODUCT_DATA = (
        ((0x00000030) << 16) | (((0x0001)) << 14) | ((0x0002) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_CHANGER_SET_ACCESS CTL_CODE(IOCTL_CHANGER_BASE, 0x0004, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_CHANGER_SET_ACCESS = (
        ((0x00000030) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0004) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_CHANGER_GET_ELEMENT_STATUS CTL_CODE(IOCTL_CHANGER_BASE, 0x0005, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_CHANGER_GET_ELEMENT_STATUS = (
        ((0x00000030) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0005) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_CHANGER_INITIALIZE_ELEMENT_STATUS CTL_CODE(IOCTL_CHANGER_BASE, 0x0006, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_CHANGER_INITIALIZE_ELEMENT_STATUS = (
        ((0x00000030) << 16) | (((0x0001)) << 14) | ((0x0006) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_CHANGER_SET_POSITION CTL_CODE(IOCTL_CHANGER_BASE, 0x0007, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_CHANGER_SET_POSITION = (
        ((0x00000030) << 16) | (((0x0001)) << 14) | ((0x0007) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_CHANGER_EXCHANGE_MEDIUM CTL_CODE(IOCTL_CHANGER_BASE, 0x0008, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_CHANGER_EXCHANGE_MEDIUM = (
        ((0x00000030) << 16) | (((0x0001)) << 14) | ((0x0008) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_CHANGER_MOVE_MEDIUM CTL_CODE(IOCTL_CHANGER_BASE, 0x0009, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_CHANGER_MOVE_MEDIUM = (
        ((0x00000030) << 16) | (((0x0001)) << 14) | ((0x0009) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_CHANGER_REINITIALIZE_TRANSPORT CTL_CODE(IOCTL_CHANGER_BASE, 0x000A, METHOD_BUFFERED, FILE_READ_ACCESS)"
    )]
    public const int IOCTL_CHANGER_REINITIALIZE_TRANSPORT = (
        ((0x00000030) << 16) | (((0x0001)) << 14) | ((0x000A) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_CHANGER_QUERY_VOLUME_TAGS CTL_CODE(IOCTL_CHANGER_BASE, 0x000B, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_CHANGER_QUERY_VOLUME_TAGS = (
        ((0x00000030) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x000B) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_SERIAL_LSRMST_INSERT CTL_CODE(FILE_DEVICE_SERIAL_PORT,31,METHOD_BUFFERED,FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_SERIAL_LSRMST_INSERT = (
        ((0x0000001b) << 16) | ((0) << 14) | ((31) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_SERENUM_EXPOSE_HARDWARE CTL_CODE(FILE_DEVICE_SERENUM,128,METHOD_BUFFERED,FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_SERENUM_EXPOSE_HARDWARE = (
        ((0x00000037) << 16) | ((0) << 14) | ((128) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_SERENUM_REMOVE_HARDWARE CTL_CODE(FILE_DEVICE_SERENUM,129,METHOD_BUFFERED,FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_SERENUM_REMOVE_HARDWARE = (
        ((0x00000037) << 16) | ((0) << 14) | ((129) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_SERENUM_PORT_DESC CTL_CODE(FILE_DEVICE_SERENUM,130,METHOD_BUFFERED,FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_SERENUM_PORT_DESC = (
        ((0x00000037) << 16) | ((0) << 14) | ((130) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_SERENUM_GET_PORT_NAME CTL_CODE(FILE_DEVICE_SERENUM,131,METHOD_BUFFERED,FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_SERENUM_GET_PORT_NAME = (
        ((0x00000037) << 16) | ((0) << 14) | ((131) << 2) | (0)
    );

    [NativeTypeName("#define IOCTL_VOLUME_BASE 0x00000056")]
    public const int IOCTL_VOLUME_BASE = 0x00000056;

    [NativeTypeName(
        "#define IOCTL_VOLUME_GET_VOLUME_DISK_EXTENTS CTL_CODE(IOCTL_VOLUME_BASE, 0, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_VOLUME_GET_VOLUME_DISK_EXTENTS = (
        ((0x00000056) << 16) | ((0) << 14) | ((0) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_VOLUME_ONLINE CTL_CODE(IOCTL_VOLUME_BASE, 2, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_VOLUME_ONLINE = (
        ((0x00000056) << 16) | (((0x0001) | (0x0002)) << 14) | ((2) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_VOLUME_OFFLINE CTL_CODE(IOCTL_VOLUME_BASE, 3, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)"
    )]
    public const int IOCTL_VOLUME_OFFLINE = (
        ((0x00000056) << 16) | (((0x0001) | (0x0002)) << 14) | ((3) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_VOLUME_IS_CLUSTERED CTL_CODE(IOCTL_VOLUME_BASE, 12, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_VOLUME_IS_CLUSTERED = (
        ((0x00000056) << 16) | ((0) << 14) | ((12) << 2) | (0)
    );

    [NativeTypeName(
        "#define IOCTL_VOLUME_GET_GPT_ATTRIBUTES CTL_CODE(IOCTL_VOLUME_BASE, 14, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public const int IOCTL_VOLUME_GET_GPT_ATTRIBUTES = (
        ((0x00000056) << 16) | ((0) << 14) | ((14) << 2) | (0)
    );
}
