// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum MF_TOPONODE_DRAIN_MODE
{
    MF_TOPONODE_DRAIN_DEFAULT = 0,
    MF_TOPONODE_DRAIN_ALWAYS = (MF_TOPONODE_DRAIN_DEFAULT + 1),
    MF_TOPONODE_DRAIN_NEVER = (MF_TOPONODE_DRAIN_ALWAYS + 1),
}
