// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.Win32.STATUS;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static partial class EXCEPTION
{
    public const uint EXCEPTION_POSSIBLE_DEADLOCK = unchecked((uint)(STATUS_POSSIBLE_DEADLOCK));
}
