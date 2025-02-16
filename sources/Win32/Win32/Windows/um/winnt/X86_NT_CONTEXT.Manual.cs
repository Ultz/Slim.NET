// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public unsafe partial struct X86_NT_CONTEXT
{
    [NativeTypeName("DWORD")]
    public uint ContextFlags;

    [NativeTypeName("DWORD")]
    public uint Dr0;

    [NativeTypeName("DWORD")]
    public uint Dr1;

    [NativeTypeName("DWORD")]
    public uint Dr2;

    [NativeTypeName("DWORD")]
    public uint Dr3;

    [NativeTypeName("DWORD")]
    public uint Dr6;

    [NativeTypeName("DWORD")]
    public uint Dr7;
    public FLOATING_SAVE_AREA FloatSave;

    [NativeTypeName("DWORD")]
    public uint SegGs;

    [NativeTypeName("DWORD")]
    public uint SegFs;

    [NativeTypeName("DWORD")]
    public uint SegEs;

    [NativeTypeName("DWORD")]
    public uint SegDs;

    [NativeTypeName("DWORD")]
    public uint Edi;

    [NativeTypeName("DWORD")]
    public uint Esi;

    [NativeTypeName("DWORD")]
    public uint Ebx;

    [NativeTypeName("DWORD")]
    public uint Edx;

    [NativeTypeName("DWORD")]
    public uint Ecx;

    [NativeTypeName("DWORD")]
    public uint Eax;

    [NativeTypeName("DWORD")]
    public uint Ebp;

    [NativeTypeName("DWORD")]
    public uint Eip;

    [NativeTypeName("DWORD")]
    public uint SegCs;

    [NativeTypeName("DWORD")]
    public uint EFlags;

    [NativeTypeName("DWORD")]
    public uint Esp;

    [NativeTypeName("DWORD")]
    public uint SegSs;

    [NativeTypeName("BYTE[512]")]
    public _ExtendedRegisters_e__FixedBuffer ExtendedRegisters;

    [InlineArray(512)]
    public partial struct _ExtendedRegisters_e__FixedBuffer
    {
        public byte e0;
    }
}
