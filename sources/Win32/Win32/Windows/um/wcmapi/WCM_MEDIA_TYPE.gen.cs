// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wcmapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public enum WCM_MEDIA_TYPE
{
    wcm_media_unknown,
    wcm_media_ethernet,
    wcm_media_wlan,
    wcm_media_mbn,
    wcm_media_invalid,
    wcm_media_max,
}
