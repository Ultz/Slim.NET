// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ks.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

[StructLayout(LayoutKind.Explicit)]
public partial struct KSDATAFORMAT
{
    [FieldOffset(0)]
    [NativeTypeName(
        "KSDATAFORMAT::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.26100.0/shared/ks.h:1096:5)"
    )]
    internal _Anonymous_e__Struct Anonymous;

    [UnscopedRef]
    public ref uint FormatSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.FormatSize; }
    }

    [UnscopedRef]
    public ref uint Flags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Flags; }
    }

    [UnscopedRef]
    public ref uint SampleSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.SampleSize; }
    }

    [UnscopedRef]
    public ref uint Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Reserved; }
    }

    [UnscopedRef]
    public ref Guid MajorFormat
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.MajorFormat; }
    }

    [UnscopedRef]
    public ref Guid SubFormat
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.SubFormat; }
    }

    [UnscopedRef]
    public ref Guid Specifier
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Specifier; }
    }

    [FieldOffset(0)]
    [NativeTypeName("LONGLONG")]
    public long Alignment;

    public partial struct _Anonymous_e__Struct
    {
        [NativeTypeName("ULONG")]
        public uint FormatSize;

        [NativeTypeName("ULONG")]
        public uint Flags;

        [NativeTypeName("ULONG")]
        public uint SampleSize;

        [NativeTypeName("ULONG")]
        public uint Reserved;
        public Guid MajorFormat;
        public Guid SubFormat;
        public Guid Specifier;
    }
}
