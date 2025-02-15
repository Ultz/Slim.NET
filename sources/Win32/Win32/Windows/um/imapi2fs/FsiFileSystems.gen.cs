// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum FsiFileSystems
{
    FsiFileSystemNone = 0,
    FsiFileSystemISO9660 = 1,
    FsiFileSystemJoliet = 2,
    FsiFileSystemUDF = 4,
    FsiFileSystemUnknown = 0x40000000,
}
