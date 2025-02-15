// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/roerrorapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.WinRT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class MAX
{
    [NativeTypeName("#define MAX_ERROR_MESSAGE_CHARS 512")]
    public const int MAX_ERROR_MESSAGE_CHARS = 512;
}
