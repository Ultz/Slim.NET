// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class STATEREPOSITORY
{
    [NativeTypeName(
        "#define STATEREPOSITORY_E_CONCURRENCY_LOCKING_FAILURE _HRESULT_TYPEDEF_(0x80670001L)"
    )]
    public const int STATEREPOSITORY_E_CONCURRENCY_LOCKING_FAILURE = unchecked((int)(0x80670001));

    [NativeTypeName(
        "#define STATEREPOSITORY_E_STATEMENT_INPROGRESS _HRESULT_TYPEDEF_(0x80670002L)"
    )]
    public const int STATEREPOSITORY_E_STATEMENT_INPROGRESS = unchecked((int)(0x80670002));

    [NativeTypeName(
        "#define STATEREPOSITORY_E_CONFIGURATION_INVALID _HRESULT_TYPEDEF_(0x80670003L)"
    )]
    public const int STATEREPOSITORY_E_CONFIGURATION_INVALID = unchecked((int)(0x80670003));

    [NativeTypeName(
        "#define STATEREPOSITORY_E_UNKNOWN_SCHEMA_VERSION _HRESULT_TYPEDEF_(0x80670004L)"
    )]
    public const int STATEREPOSITORY_E_UNKNOWN_SCHEMA_VERSION = unchecked((int)(0x80670004));

    [NativeTypeName(
        "#define STATEREPOSITORY_ERROR_DICTIONARY_CORRUPTED _HRESULT_TYPEDEF_(0x80670005L)"
    )]
    public const int STATEREPOSITORY_ERROR_DICTIONARY_CORRUPTED = unchecked((int)(0x80670005));

    [NativeTypeName("#define STATEREPOSITORY_E_BLOCKED _HRESULT_TYPEDEF_(0x80670006L)")]
    public const int STATEREPOSITORY_E_BLOCKED = unchecked((int)(0x80670006));

    [NativeTypeName("#define STATEREPOSITORY_E_BUSY_RETRY _HRESULT_TYPEDEF_(0x80670007L)")]
    public const int STATEREPOSITORY_E_BUSY_RETRY = unchecked((int)(0x80670007));

    [NativeTypeName("#define STATEREPOSITORY_E_BUSY_RECOVERY_RETRY _HRESULT_TYPEDEF_(0x80670008L)")]
    public const int STATEREPOSITORY_E_BUSY_RECOVERY_RETRY = unchecked((int)(0x80670008));

    [NativeTypeName("#define STATEREPOSITORY_E_LOCKED_RETRY _HRESULT_TYPEDEF_(0x80670009L)")]
    public const int STATEREPOSITORY_E_LOCKED_RETRY = unchecked((int)(0x80670009));

    [NativeTypeName(
        "#define STATEREPOSITORY_E_LOCKED_SHAREDCACHE_RETRY _HRESULT_TYPEDEF_(0x8067000AL)"
    )]
    public const int STATEREPOSITORY_E_LOCKED_SHAREDCACHE_RETRY = unchecked((int)(0x8067000A));

    [NativeTypeName(
        "#define STATEREPOSITORY_E_TRANSACTION_REQUIRED _HRESULT_TYPEDEF_(0x8067000BL)"
    )]
    public const int STATEREPOSITORY_E_TRANSACTION_REQUIRED = unchecked((int)(0x8067000B));

    [NativeTypeName(
        "#define STATEREPOSITORY_E_BUSY_TIMEOUT_EXCEEDED _HRESULT_TYPEDEF_(0x8067000CL)"
    )]
    public const int STATEREPOSITORY_E_BUSY_TIMEOUT_EXCEEDED = unchecked((int)(0x8067000C));

    [NativeTypeName(
        "#define STATEREPOSITORY_E_BUSY_RECOVERY_TIMEOUT_EXCEEDED _HRESULT_TYPEDEF_(0x8067000DL)"
    )]
    public const int STATEREPOSITORY_E_BUSY_RECOVERY_TIMEOUT_EXCEEDED = unchecked(
        (int)(0x8067000D)
    );

    [NativeTypeName(
        "#define STATEREPOSITORY_E_LOCKED_TIMEOUT_EXCEEDED _HRESULT_TYPEDEF_(0x8067000EL)"
    )]
    public const int STATEREPOSITORY_E_LOCKED_TIMEOUT_EXCEEDED = unchecked((int)(0x8067000E));

    [NativeTypeName(
        "#define STATEREPOSITORY_E_LOCKED_SHAREDCACHE_TIMEOUT_EXCEEDED _HRESULT_TYPEDEF_(0x8067000FL)"
    )]
    public const int STATEREPOSITORY_E_LOCKED_SHAREDCACHE_TIMEOUT_EXCEEDED = unchecked(
        (int)(0x8067000F)
    );

    [NativeTypeName(
        "#define STATEREPOSITORY_E_SERVICE_STOP_IN_PROGRESS _HRESULT_TYPEDEF_(0x80670010L)"
    )]
    public const int STATEREPOSITORY_E_SERVICE_STOP_IN_PROGRESS = unchecked((int)(0x80670010));

    [NativeTypeName("#define STATEREPOSITORY_ERROR_CACHE_CORRUPTED _HRESULT_TYPEDEF_(0x80670012L)")]
    public const int STATEREPOSITORY_ERROR_CACHE_CORRUPTED = unchecked((int)(0x80670012));

    [NativeTypeName(
        "#define STATEREPOSITORY_TRANSACTION_CALLER_ID_CHANGED _HRESULT_TYPEDEF_(0x00670013L)"
    )]
    public const int STATEREPOSITORY_TRANSACTION_CALLER_ID_CHANGED = ((int)(0x00670013));

    [NativeTypeName(
        "#define STATEREPOSITORY_TRANSACTION_IN_PROGRESS _HRESULT_TYPEDEF_(0x80670014L)"
    )]
    public const int STATEREPOSITORY_TRANSACTION_IN_PROGRESS = unchecked((int)(0x80670014));

    [NativeTypeName(
        "#define STATEREPOSITORY_E_CACHE_NOT_INIITALIZED _HRESULT_TYPEDEF_(0x80670015L)"
    )]
    public const int STATEREPOSITORY_E_CACHE_NOT_INIITALIZED = unchecked((int)(0x80670015));

    [NativeTypeName(
        "#define STATEREPOSITORY_E_DEPENDENCY_NOT_RESOLVED _HRESULT_TYPEDEF_(0x80670016L)"
    )]
    public const int STATEREPOSITORY_E_DEPENDENCY_NOT_RESOLVED = unchecked((int)(0x80670016));
}
