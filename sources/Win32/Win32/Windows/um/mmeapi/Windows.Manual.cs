// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    public static uint MEVT_EVENTPARM(byte x) => ((uint)((x) & 0x00FFFFFFL));

    public static byte MEVT_EVENTTYPE(uint x) => ((byte)(((x) >> 24) & 0xFF));
}
