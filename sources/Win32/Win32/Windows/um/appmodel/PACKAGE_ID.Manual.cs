// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public unsafe partial struct PACKAGE_ID
{
    [NativeTypeName("UINT32")]
    public uint reserved;

    [NativeTypeName("UINT32")]
    public uint processorArchitecture;
    public PACKAGE_VERSION version;

    [NativeTypeName("PWSTR")]
    public char* name;

    [NativeTypeName("PWSTR")]
    public char* publisher;

    [NativeTypeName("PWSTR")]
    public char* resourceId;

    [NativeTypeName("PWSTR")]
    public char* publisherId;
}
