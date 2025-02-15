// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DVD_TIMECODE
{
    public uint _bitfield;

    [NativeTypeName("ULONG : 4")]
    public uint Hours1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return _bitfield & 0xFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~0xFu) | (value & 0xFu); }
    }

    [NativeTypeName("ULONG : 4")]
    public uint Hours10
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 4) & 0xFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0xFu << 4)) | ((value & 0xFu) << 4); }
    }

    [NativeTypeName("ULONG : 4")]
    public uint Minutes1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 8) & 0xFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0xFu << 8)) | ((value & 0xFu) << 8); }
    }

    [NativeTypeName("ULONG : 4")]
    public uint Minutes10
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 12) & 0xFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0xFu << 12)) | ((value & 0xFu) << 12); }
    }

    [NativeTypeName("ULONG : 4")]
    public uint Seconds1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 16) & 0xFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0xFu << 16)) | ((value & 0xFu) << 16); }
    }

    [NativeTypeName("ULONG : 4")]
    public uint Seconds10
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 20) & 0xFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0xFu << 20)) | ((value & 0xFu) << 20); }
    }

    [NativeTypeName("ULONG : 4")]
    public uint Frames1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 24) & 0xFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0xFu << 24)) | ((value & 0xFu) << 24); }
    }

    [NativeTypeName("ULONG : 2")]
    public uint Frames10
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 28) & 0x3u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x3u << 28)) | ((value & 0x3u) << 28); }
    }

    [NativeTypeName("ULONG : 2")]
    public uint FrameRateCode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 30) & 0x3u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x3u << 30)) | ((value & 0x3u) << 30); }
    }
}
