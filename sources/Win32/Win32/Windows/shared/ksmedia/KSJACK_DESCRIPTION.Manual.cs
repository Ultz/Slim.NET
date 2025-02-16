// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ksmedia.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public partial struct KSJACK_DESCRIPTION
{
    [NativeTypeName("DWORD")]
    public uint ChannelMapping;

    [NativeTypeName("DWORD")]
    public uint Color;
    public EPcxConnectionType ConnectionType;
    public EPcxGeoLocation GeoLocation;
    public EPcxGenLocation GenLocation;
    public EPxcPortConnection PortConnection;
    public BOOL IsConnected;
}
