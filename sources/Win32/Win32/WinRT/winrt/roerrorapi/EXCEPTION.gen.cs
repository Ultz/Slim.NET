// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/roerrorapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.WinRT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class EXCEPTION
{
    [NativeTypeName(
        "#define EXCEPTION_RO_ORIGINATEERROR ((DWORD)((0x1 << 30) | (FACILITY_WINDOWS << 16) | 0x201))"
    )]
    public const uint EXCEPTION_RO_ORIGINATEERROR = ((uint)((0x1 << 30) | (8 << 16) | 0x201));

    [NativeTypeName(
        "#define EXCEPTION_RO_TRANSFORMERROR ((DWORD)((0x1 << 30) | (FACILITY_WINDOWS << 16) | 0x202))"
    )]
    public const uint EXCEPTION_RO_TRANSFORMERROR = ((uint)((0x1 << 30) | (8 << 16) | 0x202));
}
