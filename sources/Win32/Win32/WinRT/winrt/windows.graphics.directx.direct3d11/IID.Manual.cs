// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.directx.direct3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IDirect3DDevice
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0x24,
                0x76,
                0xA3,
                0x5F,
                0x8D,
                0x50,
                0x46,
                0x9D,
                0x3E,
                0x9E,
                0xAE,
                0x3D,
                0x9B,
                0xC6,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDirect3DSurface
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x46,
                0xA1,
                0xF4,
                0x0B,
                0xC1,
                0x13,
                0x94,
                0x46,
                0xBE,
                0xE3,
                0x7A,
                0xBF,
                0x15,
                0xEA,
                0xF5,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
