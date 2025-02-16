// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using static Silk.NET.Win32.FILE;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int HID_BUFFER_CTL_CODE(int id) =>
        CTL_CODE(FILE_DEVICE_KEYBOARD, id, METHOD_BUFFERED, FILE_ANY_ACCESS);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int HID_CTL_CODE(int id) =>
        CTL_CODE(FILE_DEVICE_KEYBOARD, id, METHOD_NEITHER, FILE_ANY_ACCESS);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int HID_IN_CTL_CODE(int id) =>
        CTL_CODE(FILE_DEVICE_KEYBOARD, id, METHOD_IN_DIRECT, FILE_ANY_ACCESS);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int HID_OUT_CTL_CODE(int id) =>
        CTL_CODE(FILE_DEVICE_KEYBOARD, id, METHOD_OUT_DIRECT, FILE_ANY_ACCESS);
}
