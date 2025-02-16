// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msports.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    [NativeTypeName("#define HCOMDB_INVALID_HANDLE_VALUE ((HCOMDB) INVALID_HANDLE_VALUE)")]
    public static HCOMDB HCOMDB_INVALID_HANDLE_VALUE => ((HCOMDB)(INVALID_HANDLE_VALUE));
}
