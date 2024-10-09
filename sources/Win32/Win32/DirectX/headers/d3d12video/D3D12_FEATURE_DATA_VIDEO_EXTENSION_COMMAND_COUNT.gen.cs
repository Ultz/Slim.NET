// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_COUNT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_COUNT"]/*'/>
[SupportedOSPlatform("windows10.0.19041.0")]
public partial struct D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_COUNT
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_COUNT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_COUNT.NodeIndex"]/*'/>

    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_COUNT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_COUNT.CommandCount"]/*'/>

    public uint CommandCount;
}
