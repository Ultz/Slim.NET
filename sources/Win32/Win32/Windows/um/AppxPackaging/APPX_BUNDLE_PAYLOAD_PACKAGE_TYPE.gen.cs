// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.3")]
public enum APPX_BUNDLE_PAYLOAD_PACKAGE_TYPE
{
    APPX_BUNDLE_PAYLOAD_PACKAGE_TYPE_APPLICATION = 0,
    APPX_BUNDLE_PAYLOAD_PACKAGE_TYPE_RESOURCE = 1,
}
