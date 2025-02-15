// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class EXCEPTION
{
    [NativeTypeName(
        "#define EXCEPTION_SPAPI_UNRECOVERABLE_STACK_OVERFLOW ERROR_UNRECOVERABLE_STACK_OVERFLOW"
    )]
    public const uint EXCEPTION_SPAPI_UNRECOVERABLE_STACK_OVERFLOW = (
        0x20000000 | 0xC0000000 | 0x300
    );
}
