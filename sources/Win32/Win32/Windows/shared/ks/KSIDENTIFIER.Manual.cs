// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ks.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public partial struct KSIDENTIFIER
{
    [NativeTypeName(
        "KSIDENTIFIER::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.26100.0/shared/ks.h:107:5)"
    )]
    internal _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref Guid Set
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Set; }
    }

    [UnscopedRef]
    public ref uint Id
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Id; }
    }

    [UnscopedRef]
    public ref uint Flags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Flags; }
    }

    [UnscopedRef]
    public ref long Alignment
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Alignment; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName(
            "KSIDENTIFIER::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.26100.0/shared/ks.h:111:9)"
        )]
        internal _Anonymous_e__Struct Anonymous;

        [FieldOffset(0)]
        [NativeTypeName("LONGLONG")]
        public long Alignment;

        public partial struct _Anonymous_e__Struct
        {
            public Guid Set;

            [NativeTypeName("ULONG")]
            public uint Id;

            [NativeTypeName("ULONG")]
            public uint Flags;
        }
    }
}
