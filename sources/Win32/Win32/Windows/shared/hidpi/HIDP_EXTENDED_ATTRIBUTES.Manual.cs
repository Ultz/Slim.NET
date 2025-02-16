// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public unsafe partial struct HIDP_EXTENDED_ATTRIBUTES
{
    [NativeTypeName("UCHAR")]
    public byte NumGlobalUnknowns;

    [NativeTypeName("UCHAR[3]")]
    public _Reserved_e__FixedBuffer Reserved;

    [NativeTypeName("PHIDP_UNKNOWN_TOKEN")]
    public HIDP_UNKNOWN_TOKEN* GlobalUnknowns;

    [NativeTypeName("ULONG[1]")]
    public _Data_e__FixedBuffer Data;

    [InlineArray(3)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public byte e0;
    }

    public partial struct _Data_e__FixedBuffer
    {
        public uint e0;

        [UnscopedRef]
        public ref uint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
