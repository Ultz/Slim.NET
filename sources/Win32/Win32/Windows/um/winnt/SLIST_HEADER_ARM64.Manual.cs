// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

[StructLayout(LayoutKind.Explicit)]
public partial struct SLIST_HEADER_ARM64
{
    [FieldOffset(0)]
    [NativeTypeName(
        "_SLIST_HEADER::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.26100.0/um/winnt.h:21239:5)"
    )]
    public _Anonymous_e__Struct Anonymous;

    [FieldOffset(0)]
    [NativeTypeName(
        "struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.26100.0/um/winnt.h:21243:5)"
    )]
    public _HeaderArm64_e__Struct HeaderArm64;

    [UnscopedRef]
    public ref ulong Alignment
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Alignment; }
    }

    [UnscopedRef]
    public ref ulong Region
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Region; }
    }

    public partial struct _Anonymous_e__Struct
    {
        [NativeTypeName("ULONGLONG")]
        public ulong Alignment;

        [NativeTypeName("ULONGLONG")]
        public ulong Region;
    }

    public partial struct _HeaderArm64_e__Struct
    {
        public ulong _bitfield1;

        [NativeTypeName("ULONGLONG : 16")]
        public ulong Depth
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return _bitfield1 & 0xFFFFUL; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield1 = (_bitfield1 & ~0xFFFFUL) | (value & 0xFFFFUL); }
        }

        [NativeTypeName("ULONGLONG : 48")]
        public ulong Sequence
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield1 >> 16) & 0xFFFFUL; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield1 = (_bitfield1 & ~(0xFFFFUL << 16)) | ((value & 0xFFFFUL) << 16); }
        }
        public ulong _bitfield2;

        [NativeTypeName("ULONGLONG : 4")]
        public ulong Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return _bitfield2 & 0xFUL; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield2 = (_bitfield2 & ~0xFUL) | (value & 0xFUL); }
        }

        [NativeTypeName("ULONGLONG : 60")]
        public ulong NextEntry
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield2 >> 4) & 0xFFFFFFFUL; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield2 = (_bitfield2 & ~(0xFFFFFFFUL << 4)) | ((value & 0xFFFFFFFUL) << 4); }
        }
    }
}
