// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public unsafe partial struct XSTATE_CONTEXT_AMD64
{
    [NativeTypeName("DWORD64")]
    public ulong Mask;

    [NativeTypeName("DWORD")]
    public uint Length;

    [NativeTypeName("DWORD")]
    public uint Reserved1;

    [NativeTypeName("PXSAVE_AREA")]
    public XSAVE_AREA* Area;

    [NativeTypeName("PVOID")]
    public void* Buffer;
}
