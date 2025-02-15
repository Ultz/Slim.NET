// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class ERROR
{
    [NativeTypeName("#define ERROR_IMAGE_NOT_STRIPPED 0x8800")]
    public const int ERROR_IMAGE_NOT_STRIPPED = 0x8800;

    [NativeTypeName("#define ERROR_NO_DBG_POINTER 0x8801")]
    public const int ERROR_NO_DBG_POINTER = 0x8801;

    [NativeTypeName("#define ERROR_NO_PDB_POINTER 0x8802")]
    public const int ERROR_NO_PDB_POINTER = 0x8802;
}
