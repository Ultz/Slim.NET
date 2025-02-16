// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public unsafe partial struct KNONVOLATILE_CONTEXT_POINTERS_AMD64
{
    [NativeTypeName(
        "_KNONVOLATILE_CONTEXT_POINTERS::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.26100.0/um/winnt.h:4397:5)"
    )]
    public _Anonymous1_e__Union Anonymous1;

    [NativeTypeName(
        "_KNONVOLATILE_CONTEXT_POINTERS::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.26100.0/um/winnt.h:4419:5)"
    )]
    public _Anonymous2_e__Union Anonymous2;

    [UnscopedRef]
    public ref M128A* Xmm0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Anonymous.Xmm0; }
    }

    [UnscopedRef]
    public ref M128A* Xmm1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Anonymous.Xmm1; }
    }

    [UnscopedRef]
    public ref M128A* Xmm2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Anonymous.Xmm2; }
    }

    [UnscopedRef]
    public ref M128A* Xmm3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Anonymous.Xmm3; }
    }

    [UnscopedRef]
    public ref M128A* Xmm4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Anonymous.Xmm4; }
    }

    [UnscopedRef]
    public ref M128A* Xmm5
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Anonymous.Xmm5; }
    }

    [UnscopedRef]
    public ref M128A* Xmm6
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Anonymous.Xmm6; }
    }

    [UnscopedRef]
    public ref M128A* Xmm7
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Anonymous.Xmm7; }
    }

    [UnscopedRef]
    public ref M128A* Xmm8
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Anonymous.Xmm8; }
    }

    [UnscopedRef]
    public ref M128A* Xmm9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Anonymous.Xmm9; }
    }

    [UnscopedRef]
    public ref M128A* Xmm10
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Anonymous.Xmm10; }
    }

    [UnscopedRef]
    public ref M128A* Xmm11
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Anonymous.Xmm11; }
    }

    [UnscopedRef]
    public ref M128A* Xmm12
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Anonymous.Xmm12; }
    }

    [UnscopedRef]
    public ref M128A* Xmm13
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Anonymous.Xmm13; }
    }

    [UnscopedRef]
    public ref M128A* Xmm14
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Anonymous.Xmm14; }
    }

    [UnscopedRef]
    public ref M128A* Xmm15
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.Anonymous.Xmm15; }
    }

    [UnscopedRef]
    public ref ulong* Rax
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.Anonymous.Rax; }
    }

    [UnscopedRef]
    public ref ulong* Rcx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.Anonymous.Rcx; }
    }

    [UnscopedRef]
    public ref ulong* Rdx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.Anonymous.Rdx; }
    }

    [UnscopedRef]
    public ref ulong* Rbx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.Anonymous.Rbx; }
    }

    [UnscopedRef]
    public ref ulong* Rsp
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.Anonymous.Rsp; }
    }

    [UnscopedRef]
    public ref ulong* Rbp
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.Anonymous.Rbp; }
    }

    [UnscopedRef]
    public ref ulong* Rsi
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.Anonymous.Rsi; }
    }

    [UnscopedRef]
    public ref ulong* Rdi
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.Anonymous.Rdi; }
    }

    [UnscopedRef]
    public ref ulong* R8
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.Anonymous.R8; }
    }

    [UnscopedRef]
    public ref ulong* R9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.Anonymous.R9; }
    }

    [UnscopedRef]
    public ref ulong* R10
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.Anonymous.R10; }
    }

    [UnscopedRef]
    public ref ulong* R11
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.Anonymous.R11; }
    }

    [UnscopedRef]
    public ref ulong* R12
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.Anonymous.R12; }
    }

    [UnscopedRef]
    public ref ulong* R13
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.Anonymous.R13; }
    }

    [UnscopedRef]
    public ref ulong* R14
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.Anonymous.R14; }
    }

    [UnscopedRef]
    public ref ulong* R15
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.Anonymous.R15; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("PM128A[16]")]
        public _FloatingContext_e__FixedBuffer FloatingContext;

        [FieldOffset(0)]
        [NativeTypeName(
            "_KNONVOLATILE_CONTEXT_POINTERS::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.26100.0/um/winnt.h:4399:9)"
        )]
        public _Anonymous_e__Struct Anonymous;

        public unsafe partial struct _Anonymous_e__Struct
        {
            [NativeTypeName("PM128A")]
            public M128A* Xmm0;

            [NativeTypeName("PM128A")]
            public M128A* Xmm1;

            [NativeTypeName("PM128A")]
            public M128A* Xmm2;

            [NativeTypeName("PM128A")]
            public M128A* Xmm3;

            [NativeTypeName("PM128A")]
            public M128A* Xmm4;

            [NativeTypeName("PM128A")]
            public M128A* Xmm5;

            [NativeTypeName("PM128A")]
            public M128A* Xmm6;

            [NativeTypeName("PM128A")]
            public M128A* Xmm7;

            [NativeTypeName("PM128A")]
            public M128A* Xmm8;

            [NativeTypeName("PM128A")]
            public M128A* Xmm9;

            [NativeTypeName("PM128A")]
            public M128A* Xmm10;

            [NativeTypeName("PM128A")]
            public M128A* Xmm11;

            [NativeTypeName("PM128A")]
            public M128A* Xmm12;

            [NativeTypeName("PM128A")]
            public M128A* Xmm13;

            [NativeTypeName("PM128A")]
            public M128A* Xmm14;

            [NativeTypeName("PM128A")]
            public M128A* Xmm15;
        }

        public unsafe partial struct _FloatingContext_e__FixedBuffer
        {
            public M128A* e0;
            public M128A* e1;
            public M128A* e2;
            public M128A* e3;
            public M128A* e4;
            public M128A* e5;
            public M128A* e6;
            public M128A* e7;
            public M128A* e8;
            public M128A* e9;
            public M128A* e10;
            public M128A* e11;
            public M128A* e12;
            public M128A* e13;
            public M128A* e14;
            public M128A* e15;
            public ref M128A* this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed (M128A** pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("PDWORD64[16]")]
        public _IntegerContext_e__FixedBuffer IntegerContext;

        [FieldOffset(0)]
        [NativeTypeName(
            "_KNONVOLATILE_CONTEXT_POINTERS::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.26100.0/um/winnt.h:4421:9)"
        )]
        public _Anonymous_e__Struct Anonymous;

        public unsafe partial struct _Anonymous_e__Struct
        {
            [NativeTypeName("PDWORD64")]
            public ulong* Rax;

            [NativeTypeName("PDWORD64")]
            public ulong* Rcx;

            [NativeTypeName("PDWORD64")]
            public ulong* Rdx;

            [NativeTypeName("PDWORD64")]
            public ulong* Rbx;

            [NativeTypeName("PDWORD64")]
            public ulong* Rsp;

            [NativeTypeName("PDWORD64")]
            public ulong* Rbp;

            [NativeTypeName("PDWORD64")]
            public ulong* Rsi;

            [NativeTypeName("PDWORD64")]
            public ulong* Rdi;

            [NativeTypeName("PDWORD64")]
            public ulong* R8;

            [NativeTypeName("PDWORD64")]
            public ulong* R9;

            [NativeTypeName("PDWORD64")]
            public ulong* R10;

            [NativeTypeName("PDWORD64")]
            public ulong* R11;

            [NativeTypeName("PDWORD64")]
            public ulong* R12;

            [NativeTypeName("PDWORD64")]
            public ulong* R13;

            [NativeTypeName("PDWORD64")]
            public ulong* R14;

            [NativeTypeName("PDWORD64")]
            public ulong* R15;
        }

        public unsafe partial struct _IntegerContext_e__FixedBuffer
        {
            public ulong* e0;
            public ulong* e1;
            public ulong* e2;
            public ulong* e3;
            public ulong* e4;
            public ulong* e5;
            public ulong* e6;
            public ulong* e7;
            public ulong* e8;
            public ulong* e9;
            public ulong* e10;
            public ulong* e11;
            public ulong* e12;
            public ulong* e13;
            public ulong* e14;
            public ulong* e15;
            public ref ulong* this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed (ulong** pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }
}
