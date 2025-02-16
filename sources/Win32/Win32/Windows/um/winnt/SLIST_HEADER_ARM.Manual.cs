// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

[StructLayout(LayoutKind.Explicit)]
public partial struct SLIST_HEADER_ARM
{
    [FieldOffset(0)]
    [NativeTypeName("ULONGLONG")]
    public ulong Alignment;

    [FieldOffset(0)]
    [NativeTypeName(
        "_SLIST_HEADER::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.26100.0/um/winnt.h:21266:5)"
    )]
    public _Anonymous_e__Struct Anonymous;

    [UnscopedRef]
    public ref SLIST_ENTRY Next
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Next; }
    }

    [UnscopedRef]
    public ref ushort Depth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Depth; }
    }

    [UnscopedRef]
    public ref ushort Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Reserved; }
    }

    public partial struct _Anonymous_e__Struct
    {
        public SLIST_ENTRY Next;

        [NativeTypeName("WORD")]
        public ushort Depth;

        [NativeTypeName("WORD")]
        public ushort Reserved;
    }
}
