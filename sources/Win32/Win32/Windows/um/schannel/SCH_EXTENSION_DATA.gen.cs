// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct SCH_EXTENSION_DATA
{
    [NativeTypeName("WORD")]
    public ushort ExtensionType;

    [NativeTypeName("const BYTE *")]
    public byte* pExtData;

    [NativeTypeName("DWORD")]
    public uint cbExtData;
}
