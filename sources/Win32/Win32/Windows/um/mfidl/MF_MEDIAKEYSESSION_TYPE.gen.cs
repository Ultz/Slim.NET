// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0.19041.0")]
public enum MF_MEDIAKEYSESSION_TYPE
{
    MF_MEDIAKEYSESSION_TYPE_TEMPORARY = 0,
    MF_MEDIAKEYSESSION_TYPE_PERSISTENT_LICENSE = (MF_MEDIAKEYSESSION_TYPE_TEMPORARY + 1),
    MF_MEDIAKEYSESSION_TYPE_PERSISTENT_RELEASE_MESSAGE =
        (MF_MEDIAKEYSESSION_TYPE_PERSISTENT_LICENSE + 1),
    MF_MEDIAKEYSESSION_TYPE_PERSISTENT_USAGE_RECORD =
        (MF_MEDIAKEYSESSION_TYPE_PERSISTENT_RELEASE_MESSAGE + 1),
}
