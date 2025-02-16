// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public partial struct AMD64_NT_CONTEXT
{
    [NativeTypeName("DWORD64")]
    public ulong P1Home;

    [NativeTypeName("DWORD64")]
    public ulong P2Home;

    [NativeTypeName("DWORD64")]
    public ulong P3Home;

    [NativeTypeName("DWORD64")]
    public ulong P4Home;

    [NativeTypeName("DWORD64")]
    public ulong P5Home;

    [NativeTypeName("DWORD64")]
    public ulong P6Home;

    [NativeTypeName("DWORD")]
    public uint ContextFlags;

    [NativeTypeName("DWORD")]
    public uint MxCsr;

    [NativeTypeName("WORD")]
    public ushort SegCs;

    [NativeTypeName("WORD")]
    public ushort SegDs;

    [NativeTypeName("WORD")]
    public ushort SegEs;

    [NativeTypeName("WORD")]
    public ushort SegFs;

    [NativeTypeName("WORD")]
    public ushort SegGs;

    [NativeTypeName("WORD")]
    public ushort SegSs;

    [NativeTypeName("DWORD")]
    public uint EFlags;

    [NativeTypeName("DWORD64")]
    public ulong Dr0;

    [NativeTypeName("DWORD64")]
    public ulong Dr1;

    [NativeTypeName("DWORD64")]
    public ulong Dr2;

    [NativeTypeName("DWORD64")]
    public ulong Dr3;

    [NativeTypeName("DWORD64")]
    public ulong Dr6;

    [NativeTypeName("DWORD64")]
    public ulong Dr7;

    [NativeTypeName("DWORD64")]
    public ulong Rax;

    [NativeTypeName("DWORD64")]
    public ulong Rcx;

    [NativeTypeName("DWORD64")]
    public ulong Rdx;

    [NativeTypeName("DWORD64")]
    public ulong Rbx;

    [NativeTypeName("DWORD64")]
    public ulong Rsp;

    [NativeTypeName("DWORD64")]
    public ulong Rbp;

    [NativeTypeName("DWORD64")]
    public ulong Rsi;

    [NativeTypeName("DWORD64")]
    public ulong Rdi;

    [NativeTypeName("DWORD64")]
    public ulong R8;

    [NativeTypeName("DWORD64")]
    public ulong R9;

    [NativeTypeName("DWORD64")]
    public ulong R10;

    [NativeTypeName("DWORD64")]
    public ulong R11;

    [NativeTypeName("DWORD64")]
    public ulong R12;

    [NativeTypeName("DWORD64")]
    public ulong R13;

    [NativeTypeName("DWORD64")]
    public ulong R14;

    [NativeTypeName("DWORD64")]
    public ulong R15;

    [NativeTypeName("DWORD64")]
    public ulong Rip;

    [NativeTypeName(
        "_CONTEXT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.26100.0/um/winnt.h:4242:5)"
    )]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("M128A [26]")]
    public _VectorRegister_e__FixedBuffer VectorRegister;

    [NativeTypeName("DWORD64")]
    public ulong VectorControl;

    [NativeTypeName("DWORD64")]
    public ulong DebugControl;

    [NativeTypeName("DWORD64")]
    public ulong LastBranchToRip;

    [NativeTypeName("DWORD64")]
    public ulong LastBranchFromRip;

    [NativeTypeName("DWORD64")]
    public ulong LastExceptionToRip;

    [NativeTypeName("DWORD64")]
    public ulong LastExceptionFromRip;

    [UnscopedRef]
    public ref XSAVE_FORMAT FltSave
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.FltSave; }
    }

    [UnscopedRef]
    public Span<M128A> Header
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Anonymous.Anonymous.Header.AsSpan(); }
    }

    [UnscopedRef]
    public Span<M128A> Legacy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Anonymous.Anonymous.Legacy.AsSpan(); }
    }

    [UnscopedRef]
    public ref M128A Xmm0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Xmm0; }
    }

    [UnscopedRef]
    public ref M128A Xmm1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Xmm1; }
    }

    [UnscopedRef]
    public ref M128A Xmm2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Xmm2; }
    }

    [UnscopedRef]
    public ref M128A Xmm3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Xmm3; }
    }

    [UnscopedRef]
    public ref M128A Xmm4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Xmm4; }
    }

    [UnscopedRef]
    public ref M128A Xmm5
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Xmm5; }
    }

    [UnscopedRef]
    public ref M128A Xmm6
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Xmm6; }
    }

    [UnscopedRef]
    public ref M128A Xmm7
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Xmm7; }
    }

    [UnscopedRef]
    public ref M128A Xmm8
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Xmm8; }
    }

    [UnscopedRef]
    public ref M128A Xmm9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Xmm9; }
    }

    [UnscopedRef]
    public ref M128A Xmm10
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Xmm10; }
    }

    [UnscopedRef]
    public ref M128A Xmm11
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Xmm11; }
    }

    [UnscopedRef]
    public ref M128A Xmm12
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Xmm12; }
    }

    [UnscopedRef]
    public ref M128A Xmm13
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Xmm13; }
    }

    [UnscopedRef]
    public ref M128A Xmm14
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Xmm14; }
    }

    [UnscopedRef]
    public ref M128A Xmm15
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Xmm15; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("XMM_SAVE_AREA32")]
        public XSAVE_FORMAT FltSave;

        [FieldOffset(0)]
        [NativeTypeName(
            "_CONTEXT::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.26100.0/um/winnt.h:4244:9)"
        )]
        public _Anonymous_e__Struct Anonymous;

        public partial struct _Anonymous_e__Struct
        {
            [NativeTypeName("M128A [2]")]
            public _Header_e__FixedBuffer Header;

            [NativeTypeName("M128A [8]")]
            public _Legacy_e__FixedBuffer Legacy;
            public M128A Xmm0;
            public M128A Xmm1;
            public M128A Xmm2;
            public M128A Xmm3;
            public M128A Xmm4;
            public M128A Xmm5;
            public M128A Xmm6;
            public M128A Xmm7;
            public M128A Xmm8;
            public M128A Xmm9;
            public M128A Xmm10;
            public M128A Xmm11;
            public M128A Xmm12;
            public M128A Xmm13;
            public M128A Xmm14;
            public M128A Xmm15;

            public partial struct _Header_e__FixedBuffer
            {
                public M128A e0;
                public M128A e1;

                [UnscopedRef]
                public ref M128A this[int index]
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get { return ref AsSpan()[index]; }
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                [UnscopedRef]
                public Span<M128A> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 2);
            }

            public partial struct _Legacy_e__FixedBuffer
            {
                public M128A e0;
                public M128A e1;
                public M128A e2;
                public M128A e3;
                public M128A e4;
                public M128A e5;
                public M128A e6;
                public M128A e7;

                [UnscopedRef]
                public ref M128A this[int index]
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get { return ref AsSpan()[index]; }
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                [UnscopedRef]
                public Span<M128A> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 8);
            }
        }
    }

    public partial struct _VectorRegister_e__FixedBuffer
    {
        public M128A e0;
        public M128A e1;
        public M128A e2;
        public M128A e3;
        public M128A e4;
        public M128A e5;
        public M128A e6;
        public M128A e7;
        public M128A e8;
        public M128A e9;
        public M128A e10;
        public M128A e11;
        public M128A e12;
        public M128A e13;
        public M128A e14;
        public M128A e15;
        public M128A e16;
        public M128A e17;
        public M128A e18;
        public M128A e19;
        public M128A e20;
        public M128A e21;
        public M128A e22;
        public M128A e23;
        public M128A e24;
        public M128A e25;

        [UnscopedRef]
        public ref M128A this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref AsSpan()[index]; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<M128A> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 26);
    }
}
