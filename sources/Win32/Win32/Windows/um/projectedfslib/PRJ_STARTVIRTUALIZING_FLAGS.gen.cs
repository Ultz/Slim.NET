// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
[SupportedOSPlatform("windows10.0.17763.0")]
public enum PRJ_STARTVIRTUALIZING_FLAGS
{
    PRJ_FLAG_NONE = 0x00000000,
    PRJ_FLAG_USE_NEGATIVE_PATH_CACHE = 0x00000001,
}
