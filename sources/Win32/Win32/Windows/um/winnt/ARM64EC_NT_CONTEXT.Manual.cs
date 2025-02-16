// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public unsafe partial struct ARM64EC_NT_CONTEXT
{
    [NativeTypeName(
        "_ARM64EC_NT_CONTEXT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.26100.0/um/winnt.h:7016:5)"
    )]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref ulong AMD64_P1Home
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.AMD64_P1Home; }
    }

    [UnscopedRef]
    public ref ulong AMD64_P2Home
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.AMD64_P2Home; }
    }

    [UnscopedRef]
    public ref ulong AMD64_P3Home
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.AMD64_P3Home; }
    }

    [UnscopedRef]
    public ref ulong AMD64_P4Home
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.AMD64_P4Home; }
    }

    [UnscopedRef]
    public ref ulong AMD64_P5Home
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.AMD64_P5Home; }
    }

    [UnscopedRef]
    public ref ulong AMD64_P6Home
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.AMD64_P6Home; }
    }

    [UnscopedRef]
    public ref uint ContextFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.ContextFlags; }
    }

    [UnscopedRef]
    public ref uint AMD64_MxCsr_copy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.AMD64_MxCsr_copy; }
    }

    [UnscopedRef]
    public ref ushort AMD64_SegCs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.AMD64_SegCs; }
    }

    [UnscopedRef]
    public ref ushort AMD64_SegDs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.AMD64_SegDs; }
    }

    [UnscopedRef]
    public ref ushort AMD64_SegEs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.AMD64_SegEs; }
    }

    [UnscopedRef]
    public ref ushort AMD64_SegFs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.AMD64_SegFs; }
    }

    [UnscopedRef]
    public ref ushort AMD64_SegGs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.AMD64_SegGs; }
    }

    [UnscopedRef]
    public ref ushort AMD64_SegSs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.AMD64_SegSs; }
    }

    [UnscopedRef]
    public ref uint AMD64_EFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.AMD64_EFlags; }
    }

    [UnscopedRef]
    public ref ulong AMD64_Dr0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.AMD64_Dr0; }
    }

    [UnscopedRef]
    public ref ulong AMD64_Dr1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.AMD64_Dr1; }
    }

    [UnscopedRef]
    public ref ulong AMD64_Dr2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.AMD64_Dr2; }
    }

    [UnscopedRef]
    public ref ulong AMD64_Dr3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.AMD64_Dr3; }
    }

    [UnscopedRef]
    public ref ulong AMD64_Dr6
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.AMD64_Dr6; }
    }

    [UnscopedRef]
    public ref ulong AMD64_Dr7
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.AMD64_Dr7; }
    }

    [UnscopedRef]
    public ref ulong X8
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X8; }
    }

    [UnscopedRef]
    public ref ulong X0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X0; }
    }

    [UnscopedRef]
    public ref ulong X1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X1; }
    }

    [UnscopedRef]
    public ref ulong X27
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X27; }
    }

    [UnscopedRef]
    public ref ulong Sp
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Sp; }
    }

    [UnscopedRef]
    public ref ulong Fp
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Fp; }
    }

    [UnscopedRef]
    public ref ulong X25
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X25; }
    }

    [UnscopedRef]
    public ref ulong X26
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X26; }
    }

    [UnscopedRef]
    public ref ulong X2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X2; }
    }

    [UnscopedRef]
    public ref ulong X3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X3; }
    }

    [UnscopedRef]
    public ref ulong X4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X4; }
    }

    [UnscopedRef]
    public ref ulong X5
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X5; }
    }

    [UnscopedRef]
    public ref ulong X19
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X19; }
    }

    [UnscopedRef]
    public ref ulong X20
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X20; }
    }

    [UnscopedRef]
    public ref ulong X21
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X21; }
    }

    [UnscopedRef]
    public ref ulong X22
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.X22; }
    }

    [UnscopedRef]
    public ref ulong Pc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Pc; }
    }

    [UnscopedRef]
    public ref ushort AMD64_ControlWord
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.AMD64_ControlWord; }
    }

    [UnscopedRef]
    public ref ushort AMD64_StatusWord
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.AMD64_StatusWord; }
    }

    [UnscopedRef]
    public ref byte AMD64_TagWord
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.AMD64_TagWord; }
    }

    [UnscopedRef]
    public ref byte AMD64_Reserved1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.AMD64_Reserved1; }
    }

    [UnscopedRef]
    public ref ushort AMD64_ErrorOpcode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.AMD64_ErrorOpcode; }
    }

    [UnscopedRef]
    public ref uint AMD64_ErrorOffset
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.AMD64_ErrorOffset; }
    }

    [UnscopedRef]
    public ref ushort AMD64_ErrorSelector
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.AMD64_ErrorSelector; }
    }

    [UnscopedRef]
    public ref ushort AMD64_Reserved2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.AMD64_Reserved2; }
    }

    [UnscopedRef]
    public ref uint AMD64_DataOffset
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.AMD64_DataOffset; }
    }

    [UnscopedRef]
    public ref ushort AMD64_DataSelector
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.AMD64_DataSelector; }
    }

    [UnscopedRef]
    public ref ushort AMD64_Reserved3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.AMD64_Reserved3; }
    }

    [UnscopedRef]
    public ref uint AMD64_MxCsr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.AMD64_MxCsr; }
    }

    [UnscopedRef]
    public ref uint AMD64_MxCsr_Mask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.AMD64_MxCsr_Mask; }
    }

    [UnscopedRef]
    public ref ulong Lr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.Lr; }
    }

    [UnscopedRef]
    public ref ushort X16_0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.X16_0; }
    }

    [UnscopedRef]
    public ref ushort AMD64_St0_Reserved1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.AMD64_St0_Reserved1; }
    }

    [UnscopedRef]
    public ref uint AMD64_St0_Reserved2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.AMD64_St0_Reserved2; }
    }

    [UnscopedRef]
    public ref ulong X6
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.X6; }
    }

    [UnscopedRef]
    public ref ushort X16_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.X16_1; }
    }

    [UnscopedRef]
    public ref ushort AMD64_St1_Reserved1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.AMD64_St1_Reserved1; }
    }

    [UnscopedRef]
    public ref uint AMD64_St1_Reserved2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.AMD64_St1_Reserved2; }
    }

    [UnscopedRef]
    public ref ulong X7
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.X7; }
    }

    [UnscopedRef]
    public ref ushort X16_2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.X16_2; }
    }

    [UnscopedRef]
    public ref ushort AMD64_St2_Reserved1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.AMD64_St2_Reserved1; }
    }

    [UnscopedRef]
    public ref uint AMD64_St2_Reserved2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.AMD64_St2_Reserved2; }
    }

    [UnscopedRef]
    public ref ulong X9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.X9; }
    }

    [UnscopedRef]
    public ref ushort X16_3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.X16_3; }
    }

    [UnscopedRef]
    public ref ushort AMD64_St3_Reserved1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.AMD64_St3_Reserved1; }
    }

    [UnscopedRef]
    public ref uint AMD64_St3_Reserved2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.AMD64_St3_Reserved2; }
    }

    [UnscopedRef]
    public ref ulong X10
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.X10; }
    }

    [UnscopedRef]
    public ref ushort X17_0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.X17_0; }
    }

    [UnscopedRef]
    public ref ushort AMD64_St4_Reserved1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.AMD64_St4_Reserved1; }
    }

    [UnscopedRef]
    public ref uint AMD64_St4_Reserved2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.AMD64_St4_Reserved2; }
    }

    [UnscopedRef]
    public ref ulong X11
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.X11; }
    }

    [UnscopedRef]
    public ref ushort X17_1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.X17_1; }
    }

    [UnscopedRef]
    public ref ushort AMD64_St5_Reserved1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.AMD64_St5_Reserved1; }
    }

    [UnscopedRef]
    public ref uint AMD64_St5_Reserved2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.AMD64_St5_Reserved2; }
    }

    [UnscopedRef]
    public ref ulong X12
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.X12; }
    }

    [UnscopedRef]
    public ref ushort X17_2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.X17_2; }
    }

    [UnscopedRef]
    public ref ushort AMD64_St6_Reserved1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.AMD64_St6_Reserved1; }
    }

    [UnscopedRef]
    public ref uint AMD64_St6_Reserved2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.AMD64_St6_Reserved2; }
    }

    [UnscopedRef]
    public ref ulong X15
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.X15; }
    }

    [UnscopedRef]
    public ref ushort X17_3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.X17_3; }
    }

    [UnscopedRef]
    public ref ushort AMD64_St7_Reserved1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.AMD64_St7_Reserved1; }
    }

    [UnscopedRef]
    public ref uint AMD64_St7_Reserved2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Anonymous.AMD64_St7_Reserved2; }
    }

    [UnscopedRef]
    public Span<ARM64_NT_NEON128> V
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Anonymous.Anonymous.Anonymous.V; }
    }

    [UnscopedRef]
    public Span<byte> AMD64_XSAVE_FORMAT_Reserved4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return MemoryMarshal.CreateSpan(
                ref Anonymous.Anonymous.Anonymous.AMD64_XSAVE_FORMAT_Reserved4[0],
                96
            );
        }
    }

    [UnscopedRef]
    public Span<ARM64_NT_NEON128> AMD64_VectorRegister
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Anonymous.Anonymous.AMD64_VectorRegister; }
    }

    [UnscopedRef]
    public ref ulong AMD64_VectorControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.AMD64_VectorControl; }
    }

    [UnscopedRef]
    public ref ulong AMD64_DebugControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.AMD64_DebugControl; }
    }

    [UnscopedRef]
    public ref ulong AMD64_LastBranchToRip
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.AMD64_LastBranchToRip; }
    }

    [UnscopedRef]
    public ref ulong AMD64_LastBranchFromRip
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.AMD64_LastBranchFromRip; }
    }

    [UnscopedRef]
    public ref ulong AMD64_LastExceptionToRip
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.AMD64_LastExceptionToRip; }
    }

    [UnscopedRef]
    public ref ulong AMD64_LastExceptionFromRip
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.AMD64_LastExceptionFromRip; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName(
            "_ARM64EC_NT_CONTEXT::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.26100.0/um/winnt.h:7017:9)"
        )]
        public _Anonymous_e__Struct Anonymous;

        public unsafe partial struct _Anonymous_e__Struct
        {
            [NativeTypeName("DWORD64")]
            public ulong AMD64_P1Home;

            [NativeTypeName("DWORD64")]
            public ulong AMD64_P2Home;

            [NativeTypeName("DWORD64")]
            public ulong AMD64_P3Home;

            [NativeTypeName("DWORD64")]
            public ulong AMD64_P4Home;

            [NativeTypeName("DWORD64")]
            public ulong AMD64_P5Home;

            [NativeTypeName("DWORD64")]
            public ulong AMD64_P6Home;

            [NativeTypeName("DWORD")]
            public uint ContextFlags;

            [NativeTypeName("DWORD")]
            public uint AMD64_MxCsr_copy;

            [NativeTypeName("WORD")]
            public ushort AMD64_SegCs;

            [NativeTypeName("WORD")]
            public ushort AMD64_SegDs;

            [NativeTypeName("WORD")]
            public ushort AMD64_SegEs;

            [NativeTypeName("WORD")]
            public ushort AMD64_SegFs;

            [NativeTypeName("WORD")]
            public ushort AMD64_SegGs;

            [NativeTypeName("WORD")]
            public ushort AMD64_SegSs;

            [NativeTypeName("DWORD")]
            public uint AMD64_EFlags;

            [NativeTypeName("DWORD64")]
            public ulong AMD64_Dr0;

            [NativeTypeName("DWORD64")]
            public ulong AMD64_Dr1;

            [NativeTypeName("DWORD64")]
            public ulong AMD64_Dr2;

            [NativeTypeName("DWORD64")]
            public ulong AMD64_Dr3;

            [NativeTypeName("DWORD64")]
            public ulong AMD64_Dr6;

            [NativeTypeName("DWORD64")]
            public ulong AMD64_Dr7;

            [NativeTypeName("DWORD64")]
            public ulong X8;

            [NativeTypeName("DWORD64")]
            public ulong X0;

            [NativeTypeName("DWORD64")]
            public ulong X1;

            [NativeTypeName("DWORD64")]
            public ulong X27;

            [NativeTypeName("DWORD64")]
            public ulong Sp;

            [NativeTypeName("DWORD64")]
            public ulong Fp;

            [NativeTypeName("DWORD64")]
            public ulong X25;

            [NativeTypeName("DWORD64")]
            public ulong X26;

            [NativeTypeName("DWORD64")]
            public ulong X2;

            [NativeTypeName("DWORD64")]
            public ulong X3;

            [NativeTypeName("DWORD64")]
            public ulong X4;

            [NativeTypeName("DWORD64")]
            public ulong X5;

            [NativeTypeName("DWORD64")]
            public ulong X19;

            [NativeTypeName("DWORD64")]
            public ulong X20;

            [NativeTypeName("DWORD64")]
            public ulong X21;

            [NativeTypeName("DWORD64")]
            public ulong X22;

            [NativeTypeName("DWORD64")]
            public ulong Pc;

            [NativeTypeName(
                "_ARM64EC_NT_CONTEXT::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.26100.0/um/winnt.h:7098:13)"
            )]
            public _Anonymous1_e__Struct Anonymous;

            [NativeTypeName("ARM64_NT_NEON128[26]")]
            public _AMD64_VectorRegister_e__FixedBuffer AMD64_VectorRegister;

            [NativeTypeName("DWORD64")]
            public ulong AMD64_VectorControl;

            [NativeTypeName("DWORD64")]
            public ulong AMD64_DebugControl;

            [NativeTypeName("DWORD64")]
            public ulong AMD64_LastBranchToRip;

            [NativeTypeName("DWORD64")]
            public ulong AMD64_LastBranchFromRip;

            [NativeTypeName("DWORD64")]
            public ulong AMD64_LastExceptionToRip;

            [NativeTypeName("DWORD64")]
            public ulong AMD64_LastExceptionFromRip;

            public unsafe partial struct _Anonymous1_e__Struct
            {
                [NativeTypeName("WORD")]
                public ushort AMD64_ControlWord;

                [NativeTypeName("WORD")]
                public ushort AMD64_StatusWord;
                public byte AMD64_TagWord;
                public byte AMD64_Reserved1;

                [NativeTypeName("WORD")]
                public ushort AMD64_ErrorOpcode;

                [NativeTypeName("DWORD")]
                public uint AMD64_ErrorOffset;

                [NativeTypeName("WORD")]
                public ushort AMD64_ErrorSelector;

                [NativeTypeName("WORD")]
                public ushort AMD64_Reserved2;

                [NativeTypeName("DWORD")]
                public uint AMD64_DataOffset;

                [NativeTypeName("WORD")]
                public ushort AMD64_DataSelector;

                [NativeTypeName("WORD")]
                public ushort AMD64_Reserved3;

                [NativeTypeName("DWORD")]
                public uint AMD64_MxCsr;

                [NativeTypeName("DWORD")]
                public uint AMD64_MxCsr_Mask;

                [NativeTypeName("DWORD64")]
                public ulong Lr;

                [NativeTypeName("WORD")]
                public ushort X16_0;

                [NativeTypeName("WORD")]
                public ushort AMD64_St0_Reserved1;

                [NativeTypeName("DWORD")]
                public uint AMD64_St0_Reserved2;

                [NativeTypeName("DWORD64")]
                public ulong X6;

                [NativeTypeName("WORD")]
                public ushort X16_1;

                [NativeTypeName("WORD")]
                public ushort AMD64_St1_Reserved1;

                [NativeTypeName("DWORD")]
                public uint AMD64_St1_Reserved2;

                [NativeTypeName("DWORD64")]
                public ulong X7;

                [NativeTypeName("WORD")]
                public ushort X16_2;

                [NativeTypeName("WORD")]
                public ushort AMD64_St2_Reserved1;

                [NativeTypeName("DWORD")]
                public uint AMD64_St2_Reserved2;

                [NativeTypeName("DWORD64")]
                public ulong X9;

                [NativeTypeName("WORD")]
                public ushort X16_3;

                [NativeTypeName("WORD")]
                public ushort AMD64_St3_Reserved1;

                [NativeTypeName("DWORD")]
                public uint AMD64_St3_Reserved2;

                [NativeTypeName("DWORD64")]
                public ulong X10;

                [NativeTypeName("WORD")]
                public ushort X17_0;

                [NativeTypeName("WORD")]
                public ushort AMD64_St4_Reserved1;

                [NativeTypeName("DWORD")]
                public uint AMD64_St4_Reserved2;

                [NativeTypeName("DWORD64")]
                public ulong X11;

                [NativeTypeName("WORD")]
                public ushort X17_1;

                [NativeTypeName("WORD")]
                public ushort AMD64_St5_Reserved1;

                [NativeTypeName("DWORD")]
                public uint AMD64_St5_Reserved2;

                [NativeTypeName("DWORD64")]
                public ulong X12;

                [NativeTypeName("WORD")]
                public ushort X17_2;

                [NativeTypeName("WORD")]
                public ushort AMD64_St6_Reserved1;

                [NativeTypeName("DWORD")]
                public uint AMD64_St6_Reserved2;

                [NativeTypeName("DWORD64")]
                public ulong X15;

                [NativeTypeName("WORD")]
                public ushort X17_3;

                [NativeTypeName("WORD")]
                public ushort AMD64_St7_Reserved1;

                [NativeTypeName("DWORD")]
                public uint AMD64_St7_Reserved2;

                [NativeTypeName("ARM64_NT_NEON128[16]")]
                public _V_e__FixedBuffer V;

                [NativeTypeName("BYTE[96]")]
                public _AMD64_XSAVE_FORMAT_Reserved4_e__FixedBuffer AMD64_XSAVE_FORMAT_Reserved4;

                [InlineArray(16)]
                public partial struct _V_e__FixedBuffer
                {
                    public ARM64_NT_NEON128 e0;
                }

                [InlineArray(96)]
                public partial struct _AMD64_XSAVE_FORMAT_Reserved4_e__FixedBuffer
                {
                    public byte e0;
                }
            }

            [InlineArray(26)]
            public partial struct _AMD64_VectorRegister_e__FixedBuffer
            {
                public ARM64_NT_NEON128 e0;
            }
        }
    }
}
