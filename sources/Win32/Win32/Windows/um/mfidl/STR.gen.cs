// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class STR
{
    [NativeTypeName("#define STR_HASH_LEN (SHA_HASH_LEN*2 + 3)")]
    public const int STR_HASH_LEN = (20 * 2 + 3);
}
