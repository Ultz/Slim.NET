// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/documenttarget.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static partial class LIBID
{
    public static ref readonly Guid LIBID_PrintDocumentTargetLib
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF7,
                0x76,
                0x0D,
                0x41,
                0xB5,
                0x8B,
                0x7D,
                0x4A,
                0x9D,
                0x37,
                0x9C,
                0x71,
                0xB1,
                0xB1,
                0x4D,
                0x14,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
