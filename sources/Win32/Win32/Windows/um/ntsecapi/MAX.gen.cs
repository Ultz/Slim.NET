// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class MAX
{
    [NativeTypeName("#define MAX_FOREST_TRUST_BINARY_DATA_SIZE ( 128 * 1024 )")]
    public const int MAX_FOREST_TRUST_BINARY_DATA_SIZE = (128 * 1024);

    [NativeTypeName("#define MAX_RECORDS_IN_FOREST_TRUST_INFO 4000")]
    public const int MAX_RECORDS_IN_FOREST_TRUST_INFO = 4000;
}
