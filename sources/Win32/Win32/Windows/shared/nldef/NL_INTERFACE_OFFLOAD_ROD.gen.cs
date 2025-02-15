// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/nldef.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct NL_INTERFACE_OFFLOAD_ROD
{
    public byte _bitfield;

    [NativeTypeName("BOOLEAN : 1")]
    public byte NlChecksumSupported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)(_bitfield & 0x1u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (byte)((_bitfield & ~0x1u) | (value & 0x1u)); }
    }

    [NativeTypeName("BOOLEAN : 1")]
    public byte NlOptionsSupported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)((_bitfield >> 1) & 0x1u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (byte)((_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1)); }
    }

    [NativeTypeName("BOOLEAN : 1")]
    public byte TlDatagramChecksumSupported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)((_bitfield >> 2) & 0x1u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (byte)((_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2)); }
    }

    [NativeTypeName("BOOLEAN : 1")]
    public byte TlStreamChecksumSupported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)((_bitfield >> 3) & 0x1u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (byte)((_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3)); }
    }

    [NativeTypeName("BOOLEAN : 1")]
    public byte TlStreamOptionsSupported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)((_bitfield >> 4) & 0x1u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (byte)((_bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4)); }
    }

    [NativeTypeName("BOOLEAN : 1")]
    public byte FastPathCompatible
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)((_bitfield >> 5) & 0x1u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (byte)((_bitfield & ~(0x1u << 5)) | ((value & 0x1u) << 5)); }
    }

    [NativeTypeName("BOOLEAN : 1")]
    public byte TlLargeSendOffloadSupported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)((_bitfield >> 6) & 0x1u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (byte)((_bitfield & ~(0x1u << 6)) | ((value & 0x1u) << 6)); }
    }

    [NativeTypeName("BOOLEAN : 1")]
    public byte TlGiantSendOffloadSupported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (byte)((_bitfield >> 7) & 0x1u); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (byte)((_bitfield & ~(0x1u << 7)) | ((value & 0x1u) << 7)); }
    }
}
