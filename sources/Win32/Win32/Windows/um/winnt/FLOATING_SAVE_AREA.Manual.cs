// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public unsafe partial struct FLOATING_SAVE_AREA
{
    [NativeTypeName("DWORD")]
    public uint ControlWord;

    [NativeTypeName("DWORD")]
    public uint StatusWord;

    [NativeTypeName("DWORD")]
    public uint TagWord;

    [NativeTypeName("DWORD")]
    public uint ErrorOffset;

    [NativeTypeName("DWORD")]
    public uint ErrorSelector;

    [NativeTypeName("DWORD")]
    public uint DataOffset;

    [NativeTypeName("DWORD")]
    public uint DataSelector;

    [NativeTypeName("BYTE[80]")]
    public _RegisterArea_e__FixedBuffer RegisterArea;

    [NativeTypeName("DWORD")]
    public uint Spare0;

    [InlineArray(80)]
    public partial struct _RegisterArea_e__FixedBuffer
    {
        public byte e0;
    }
}
