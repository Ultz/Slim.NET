// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct STREAM_EXTENT_ENTRY
{
    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("__AnonymousRecord_winioctl_L15686_C5")]
    public _ExtentInformation_e__Union ExtentInformation;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _ExtentInformation_e__Union
    {
        [FieldOffset(0)]
        public RETRIEVAL_POINTERS_BUFFER RetrievalPointers;
    }
}
