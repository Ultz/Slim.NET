// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmsyscom.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    public static uint MAKEFOURCC(byte ch0, byte ch1, byte ch2, byte ch3)
    {
        return (
            (uint)(byte)(ch0)
            | ((uint)(byte)(ch1) << 8)
            | ((uint)(byte)(ch2) << 16)
            | ((uint)(byte)(ch3) << 24)
        );
    }
}
