// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public unsafe partial struct HIDP_LINK_COLLECTION_NODE
{
    [NativeTypeName("USAGE")]
    public ushort LinkUsage;

    [NativeTypeName("USAGE")]
    public ushort LinkUsagePage;
    public ushort Parent;
    public ushort NumberOfChildren;
    public ushort NextSibling;
    public ushort FirstChild;
    public uint _bitfield;

    [NativeTypeName("ULONG : 8")]
    public uint CollectionType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return _bitfield & 0xFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~0xFFu) | (value & 0xFFu); }
    }

    [NativeTypeName("ULONG : 1")]
    public uint IsAlias
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 8) & 0x1u; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x1u << 8)) | ((value & 0x1u) << 8); }
    }

    [NativeTypeName("ULONG : 23")]
    public uint Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (_bitfield >> 9) & 0x7FFFFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { _bitfield = (_bitfield & ~(0x7FFFFFu << 9)) | ((value & 0x7FFFFFu) << 9); }
    }

    [NativeTypeName("PVOID")]
    public void* UserContext;
}
