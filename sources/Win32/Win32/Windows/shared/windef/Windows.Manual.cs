// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/windef.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    public static DPI_AWARENESS_CONTEXT DPI_AWARENESS_CONTEXT_UNAWARE =>
        unchecked((DPI_AWARENESS_CONTEXT)(-1));
    public static DPI_AWARENESS_CONTEXT DPI_AWARENESS_CONTEXT_SYSTEM_AWARE =>
        unchecked((DPI_AWARENESS_CONTEXT)(-2));
    public static DPI_AWARENESS_CONTEXT DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE =>
        unchecked((DPI_AWARENESS_CONTEXT)(-3));
    public static DPI_AWARENESS_CONTEXT DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2 =>
        unchecked((DPI_AWARENESS_CONTEXT)(-4));
    public static DPI_AWARENESS_CONTEXT DPI_AWARENESS_CONTEXT_UNAWARE_GDISCALED =>
        unchecked((DPI_AWARENESS_CONTEXT)(-5));
}
