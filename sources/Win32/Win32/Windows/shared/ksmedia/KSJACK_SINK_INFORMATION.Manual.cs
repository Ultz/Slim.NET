// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ksmedia.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public unsafe partial struct KSJACK_SINK_INFORMATION
{
    public KSJACK_SINK_CONNECTIONTYPE ConnType;

    [NativeTypeName("WORD")]
    public ushort ManufacturerId;

    [NativeTypeName("WORD")]
    public ushort ProductId;

    [NativeTypeName("WORD")]
    public ushort AudioLatency;
    public BOOL HDCPCapable;
    public BOOL AICapable;

    [NativeTypeName("UCHAR")]
    public byte SinkDescriptionLength;

    [NativeTypeName("WCHAR[32]")]
    public _SinkDescription_e__FixedBuffer SinkDescription;
    public LUID PortId;

    [InlineArray(32)]
    public partial struct _SinkDescription_e__FixedBuffer
    {
        public char e0;
    }
}
