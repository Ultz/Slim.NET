// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/minwindef.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    public const int NULL = 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte HIBYTE([NativeTypeName("DWORD_PTR")] nuint w) =>
        ((byte)((((nuint)(w)) >> 8) & 0xff));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte HIBYTE(nint w) => unchecked(HIBYTE((nuint)(w)));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("WORD")]
    public static ushort HIWORD([NativeTypeName("DWORD_PTR")] nuint l) =>
        ((ushort)((((nuint)(l)) >> 16) & 0xffff));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort HIWORD(nint l) => unchecked(HIWORD((nuint)(l)));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte LOBYTE([NativeTypeName("DWORD_PTR")] nuint w) =>
        ((byte)(((nuint)(w)) & 0xff));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte LOBYTE(nint w) => unchecked(LOBYTE((nuint)(w)));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("WORD")]
    public static ushort LOWORD([NativeTypeName("DWORD_PTR")] nuint l) =>
        unchecked((ushort)(((nuint)(l)) & 0xffff));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort LOWORD(nint l) => unchecked(LOWORD((nuint)(l)));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("LONG")]
    public static int MAKELONG(
        [NativeTypeName("DWORD_PTR")] nuint a,
        [NativeTypeName("DWORD_PTR")] nuint b
    ) =>
        unchecked(
            (int)(
                ((ushort)(((nuint)(a)) & 0xffff)) | ((uint)((ushort)(((nuint)(b)) & 0xffff))) << 16
            )
        );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int MAKELONG(nint a, nint b) => unchecked(MAKEWORD((nuint)(a), (nuint)(b)));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("WORD")]
    public static ushort MAKEWORD(
        [NativeTypeName("DWORD_PTR")] nuint a,
        [NativeTypeName("DWORD_PTR")] nuint b
    ) =>
        unchecked(
            (ushort)(((byte)(((nuint)(a)) & 0xff)) | ((ushort)((byte)(((nuint)(b)) & 0xff))) << 8)
        );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort MAKEWORD(nint a, nint b) => unchecked(MAKEWORD((nuint)(a), (nuint)(b)));
}
