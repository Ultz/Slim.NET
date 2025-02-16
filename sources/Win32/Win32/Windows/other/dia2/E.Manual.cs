// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static partial class E
{
    public const int E_PDB_OK = unchecked((int)((1u << 31) | (0x6Du << 16) | 1));
    public const int E_PDB_USAGE = E_PDB_OK + 1;
    public const int E_PDB_OUT_OF_MEMORY = E_PDB_USAGE + 1;
    public const int E_PDB_FILE_SYSTEM = E_PDB_OUT_OF_MEMORY + 1;
    public const int E_PDB_NOT_FOUND = E_PDB_FILE_SYSTEM + 1;
    public const int E_PDB_INVALID_SIG = E_PDB_NOT_FOUND + 1;
    public const int E_PDB_INVALID_AGE = E_PDB_INVALID_SIG + 1;
    public const int E_PDB_PRECOMP_REQUIRED = E_PDB_INVALID_AGE + 1;
    public const int E_PDB_OUT_OF_TI = E_PDB_PRECOMP_REQUIRED + 1;
    public const int E_PDB_NOT_IMPLEMENTED = E_PDB_OUT_OF_TI + 1;
    public const int E_PDB_V1_PDB = E_PDB_NOT_IMPLEMENTED + 1;
    public const int E_PDB_FORMAT = E_PDB_V1_PDB + 1;
    public const int E_PDB_LIMIT = E_PDB_FORMAT + 1;
    public const int E_PDB_CORRUPT = E_PDB_LIMIT + 1;
    public const int E_PDB_TI16 = E_PDB_CORRUPT + 1;
    public const int E_PDB_ACCESS_DENIED = E_PDB_TI16 + 1;
    public const int E_PDB_ILLEGAL_TYPE_EDIT = E_PDB_ACCESS_DENIED + 1;
    public const int E_PDB_INVALID_EXECUTABLE = E_PDB_ILLEGAL_TYPE_EDIT + 1;
    public const int E_PDB_DBG_NOT_FOUND = E_PDB_INVALID_EXECUTABLE + 1;
    public const int E_PDB_NO_DEBUG_INFO = E_PDB_DBG_NOT_FOUND + 1;
    public const int E_PDB_INVALID_EXE_TIMESTAMP = E_PDB_NO_DEBUG_INFO + 1;
    public const int E_PDB_RESERVED = E_PDB_INVALID_EXE_TIMESTAMP + 1;
    public const int E_PDB_DEBUG_INFO_NOT_IN_PDB = E_PDB_RESERVED + 1;
    public const int E_PDB_SYMSRV_BAD_CACHE_PATH = E_PDB_DEBUG_INFO_NOT_IN_PDB + 1;
    public const int E_PDB_SYMSRV_CACHE_FULL = E_PDB_SYMSRV_BAD_CACHE_PATH + 1;
    public const int E_PDB_OBJECT_DISPOSED = E_PDB_SYMSRV_CACHE_FULL + 1;
    public const int E_PDB_MAX = E_PDB_OBJECT_DISPOSED + 1;
    public const int E_DIA_INPROLOG = unchecked((int)((1u << 31) | (0x6Du << 16) | 100));
    public const int E_DIA_SYNTAX = E_DIA_INPROLOG + 1;
    public const int E_DIA_FRAME_ACCESS = E_DIA_SYNTAX + 1;
    public const int E_DIA_VALUE = E_DIA_FRAME_ACCESS + 1;
}
