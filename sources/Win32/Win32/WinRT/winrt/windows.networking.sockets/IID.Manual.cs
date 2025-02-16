// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IControlChannelTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA7,
                0x31,
                0x14,
                0x7D,
                0x96,
                0xEE,
                0xE8,
                0x40,
                0xA1,
                0x99,
                0x87,
                0x03,
                0xCD,
                0x96,
                0x9E,
                0xC3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IControlChannelTrigger2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x37,
                0xD2,
                0x00,
                0xAF,
                0xBE,
                0x51,
                0x14,
                0x45,
                0x97,
                0x25,
                0x35,
                0x56,
                0xE1,
                0x87,
                0x95,
                0x80,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IControlChannelTriggerEventDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x47,
                0xE0,
                0x36,
                0x1B,
                0xBB,
                0x89,
                0x36,
                0x42,
                0x96,
                0xAC,
                0x71,
                0xD0,
                0x12,
                0xBB,
                0x48,
                0x69,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IControlChannelTriggerFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF0,
                0x7C,
                0x4B,
                0xDA,
                0x71,
                0x8D,
                0x6F,
                0x44,
                0x88,
                0xC3,
                0xB9,
                0x51,
                0x84,
                0xA2,
                0xD6,
                0xCD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IControlChannelTriggerResetEventDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8E,
                0x03,
                0x51,
                0x68,
                0xC4,
                0x8E,
                0xFE,
                0x42,
                0x9B,
                0xB2,
                0x21,
                0xE9,
                0x1B,
                0x7B,
                0xFC,
                0xB1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDatagramSocket
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBB,
                0x5B,
                0xE2,
                0x7F,
                0xBC,
                0xC3,
                0x77,
                0x46,
                0x84,
                0x46,
                0xCA,
                0x28,
                0xA4,
                0x65,
                0xA3,
                0xAF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDatagramSocket2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x54,
                0xA3,
                0x3B,
                0xD8,
                0x9D,
                0x9A,
                0x85,
                0x41,
                0xA2,
                0x0A,
                0x14,
                0x24,
                0xC9,
                0xC2,
                0xA7,
                0xCD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDatagramSocket3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x09,
                0x4F,
                0x54,
                0x37,
                0x92,
                0xAB,
                0x06,
                0x43,
                0x9A,
                0xC1,
                0x0C,
                0x38,
                0x12,
                0x83,
                0xD9,
                0xC6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDatagramSocketControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2E,
                0x3F,
                0xAC,
                0x52,
                0x9A,
                0x34,
                0x35,
                0x41,
                0xBB,
                0x58,
                0xB7,
                0x9B,
                0x26,
                0x47,
                0xD3,
                0x90,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDatagramSocketControl2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC2,
                0xD5,
                0xEA,
                0x33,
                0x9C,
                0x97,
                0x15,
                0x44,
                0x82,
                0xA1,
                0x3C,
                0xFA,
                0xF6,
                0x46,
                0xC1,
                0x92,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDatagramSocketControl3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x56,
                0x82,
                0xEB,
                0xD4,
                0x6D,
                0x1F,
                0x98,
                0x45,
                0x9B,
                0x57,
                0xD4,
                0x2A,
                0x00,
                0x1D,
                0xF3,
                0x49,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDatagramSocketInformation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9A,
                0x56,
                0x1A,
                0x5F,
                0xFB,
                0x55,
                0xCD,
                0x48,
                0x97,
                0x06,
                0x7A,
                0x97,
                0x4F,
                0x7B,
                0x15,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDatagramSocketMessageReceivedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA2,
                0xDC,
                0x2D,
                0x9E,
                0x12,
                0x17,
                0xE4,
                0x4C,
                0xB1,
                0x79,
                0x8C,
                0x65,
                0x2C,
                0x6D,
                0x10,
                0x7E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDatagramSocketStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEE,
                0x2A,
                0xC6,
                0xE9,
                0x94,
                0x14,
                0x21,
                0x4A,
                0xBB,
                0x7E,
                0x85,
                0x89,
                0xFC,
                0x75,
                0x1D,
                0x9D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMessageWebSocket
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x08,
                0x7D,
                0x72,
                0x33,
                0xD5,
                0x34,
                0x46,
                0x47,
                0xAD,
                0x7B,
                0x8D,
                0xDE,
                0x5B,
                0xC2,
                0xEF,
                0x88,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMessageWebSocket2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE7,
                0xCE,
                0xD0,
                0xBE,
                0xC8,
                0xF9,
                0x0A,
                0x44,
                0x9A,
                0xD5,
                0x73,
                0x72,
                0x81,
                0xD9,
                0x74,
                0x2E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMessageWebSocket3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFB,
                0xDE,
                0xD9,
                0x59,
                0xAF,
                0x71,
                0x49,
                0x43,
                0x84,
                0x87,
                0x91,
                0x1F,
                0xCF,
                0x68,
                0x15,
                0x97,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMessageWebSocketControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8A,
                0x38,
                0x18,
                0x81,
                0x29,
                0xC6,
                0x0A,
                0x4F,
                0x80,
                0xFB,
                0x81,
                0xFC,
                0x05,
                0x53,
                0x88,
                0x62,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMessageWebSocketControl2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0xD7,
                0x0F,
                0xE3,
                0x0C,
                0x08,
                0x0A,
                0x40,
                0xA7,
                0x12,
                0x27,
                0xDF,
                0xA9,
                0xE7,
                0x44,
                0xD8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMessageWebSocketMessageReceivedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAC,
                0x22,
                0x8C,
                0x47,
                0x4B,
                0x4C,
                0xED,
                0x42,
                0x9E,
                0xD7,
                0x1E,
                0xF9,
                0xF9,
                0x4F,
                0xA3,
                0xD5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMessageWebSocketMessageReceivedEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFD,
                0x06,
                0xCE,
                0x89,
                0x6F,
                0xDD,
                0x07,
                0x4A,
                0x87,
                0xF9,
                0xF9,
                0xEB,
                0x4D,
                0x89,
                0xD8,
                0x3D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IServerMessageWebSocket
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0x92,
                0xAC,
                0xE3,
                0x3B,
                0x81,
                0xFD,
                0x5E,
                0x7E,
                0x11,
                0xAE,
                0x23,
                0x05,
                0xFC,
                0x77,
                0xF1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IServerMessageWebSocketControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x51,
                0xF0,
                0xC2,
                0x69,
                0x1F,
                0x1C,
                0x7A,
                0x58,
                0x45,
                0x19,
                0x21,
                0x81,
                0x61,
                0x01,
                0x92,
                0xB7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IServerMessageWebSocketInformation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5F,
                0xB4,
                0x32,
                0xFC,
                0x48,
                0x44,
                0x05,
                0x55,
                0x6C,
                0xC9,
                0x09,
                0xAF,
                0xA8,
                0x91,
                0x5F,
                0x5D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IServerStreamWebSocket
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBF,
                0x5B,
                0xED,
                0x2C,
                0xF6,
                0x74,
                0xE4,
                0x55,
                0x79,
                0xDF,
                0x91,
                0x32,
                0x68,
                0x0D,
                0xFE,
                0xE8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IServerStreamWebSocketInformation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5F,
                0xB4,
                0x32,
                0xFC,
                0x48,
                0x44,
                0x05,
                0x55,
                0x6C,
                0xC9,
                0x09,
                0xAB,
                0xA8,
                0x91,
                0x5F,
                0x5D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISocketActivityContext
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x64,
                0x4D,
                0xB0,
                0x43,
                0x85,
                0x4C,
                0x96,
                0x43,
                0xA6,
                0x37,
                0x1D,
                0x97,
                0x3F,
                0x6E,
                0xBD,
                0x49,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISocketActivityContextFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC3,
                0xC3,
                0x9F,
                0xB9,
                0x8C,
                0x08,
                0x88,
                0x43,
                0x83,
                0xAE,
                0x25,
                0x25,
                0x13,
                0x8E,
                0x04,
                0x9A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISocketActivityInformation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE4,
                0x42,
                0x8A,
                0x8D,
                0x7E,
                0xA8,
                0x74,
                0x4B,
                0x99,
                0x68,
                0x18,
                0x5B,
                0x25,
                0x11,
                0xDE,
                0xFE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISocketActivityInformationStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7A,
                0xB4,
                0x70,
                0x85,
                0x7D,
                0x7E,
                0x36,
                0x47,
                0x80,
                0x41,
                0x13,
                0x27,
                0xA6,
                0x54,
                0x3C,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISocketActivityTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA7,
                0x06,
                0xF4,
                0x45,
                0x9F,
                0xFC,
                0x81,
                0x4F,
                0xAC,
                0xAD,
                0x35,
                0x5F,
                0xEF,
                0x51,
                0xE6,
                0x7B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISocketErrorStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0x37,
                0x83,
                0x82,
                0x56,
                0x7D,
                0x8E,
                0x4D,
                0xB7,
                0xB4,
                0xA0,
                0x7D,
                0xD7,
                0xC1,
                0xBC,
                0xA9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStreamSocket
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF3,
                0x2C,
                0xA2,
                0x69,
                0x7B,
                0xFC,
                0x57,
                0x48,
                0xAF,
                0x38,
                0xF6,
                0xE7,
                0xDE,
                0x6A,
                0x5B,
                0x49,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStreamSocket2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x75,
                0xE5,
                0xD0,
                0x29,
                0x14,
                0xF3,
                0x09,
                0x4D,
                0xAD,
                0xF0,
                0x0F,
                0xBD,
                0x96,
                0x7F,
                0xBD,
                0x9F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStreamSocket3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x0B,
                0x43,
                0x3F,
                0x28,
                0x9D,
                0x54,
                0x48,
                0xBA,
                0xC3,
                0x23,
                0x01,
                0x94,
                0x1E,
                0xC2,
                0x23,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStreamSocketControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF1,
                0xAD,
                0x25,
                0xFE,
                0xAB,
                0x92,
                0xF3,
                0x4A,
                0x99,
                0x92,
                0x0F,
                0x4C,
                0x85,
                0xE3,
                0x6C,
                0xC4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStreamSocketControl2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x56,
                0x9A,
                0xD0,
                0xC2,
                0x0F,
                0x06,
                0xC1,
                0x44,
                0xB8,
                0xE2,
                0x1F,
                0xBF,
                0x60,
                0xBD,
                0x62,
                0xC5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStreamSocketControl3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x44,
                0x6A,
                0xC5,
                0x74,
                0x4E,
                0x3E,
                0x40,
                0x89,
                0x4C,
                0xB3,
                0x1C,
                0xAE,
                0x5C,
                0x73,
                0x42,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStreamSocketControl4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3D,
                0x2B,
                0x4E,
                0x96,
                0x27,
                0xEC,
                0x88,
                0x48,
                0xB3,
                0xCE,
                0xC7,
                0x4B,
                0x41,
                0x84,
                0x23,
                0xAD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStreamSocketInformation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0xAE,
                0x80,
                0x3B,
                0x68,
                0x5E,
                0x05,
                0x42,
                0x88,
                0xF0,
                0xDC,
                0x85,
                0xD2,
                0xE2,
                0x5D,
                0xED,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStreamSocketInformation2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x52,
                0x84,
                0xC2,
                0x12,
                0xDC,
                0x4B,
                0xE4,
                0x4E,
                0x97,
                0x6A,
                0xCF,
                0x13,
                0x0E,
                0x9D,
                0x92,
                0xE3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStreamSocketListener
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x37,
                0x34,
                0x51,
                0xFF,
                0x9F,
                0xDF,
                0xF0,
                0x4D,
                0xBF,
                0x82,
                0x0E,
                0xC5,
                0xD7,
                0xB3,
                0x5A,
                0xAE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStreamSocketListener2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0xC1,
                0x8D,
                0x65,
                0x3E,
                0xBB,
                0x58,
                0x44,
                0xB2,
                0x32,
                0xED,
                0x10,
                0x88,
                0x69,
                0x4B,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStreamSocketListener3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1C,
                0x20,
                0x98,
                0x47,
                0xF8,
                0xBD,
                0x19,
                0x49,
                0x85,
                0x42,
                0x28,
                0xD4,
                0x50,
                0xE7,
                0x45,
                0x07,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStreamSocketListenerConnectionReceivedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0x2E,
                0x47,
                0x0C,
                0x3F,
                0x37,
                0x7B,
                0x44,
                0x85,
                0xB1,
                0xDD,
                0xD4,
                0x54,
                0x88,
                0x03,
                0xBA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStreamSocketListenerControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0xC5,
                0xD8,
                0x20,
                0x8A,
                0x8D,
                0xBA,
                0x4D,
                0x97,
                0x22,
                0xA1,
                0x6C,
                0x4D,
                0x98,
                0x49,
                0x80,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStreamSocketListenerControl2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x65,
                0xB6,
                0x8B,
                0x94,
                0x3E,
                0x2C,
                0x4B,
                0x40,
                0xB8,
                0xB0,
                0x8E,
                0xB2,
                0x49,
                0xA2,
                0xB0,
                0xA1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStreamSocketListenerInformation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2F,
                0xA8,
                0x2B,
                0xE6,
                0x3A,
                0xA6,
                0x0B,
                0x43,
                0xBF,
                0x62,
                0x29,
                0xE9,
                0x3E,
                0x56,
                0x33,
                0xB4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStreamSocketStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4A,
                0xBC,
                0x20,
                0xA4,
                0x2E,
                0x6E,
                0xF5,
                0x4A,
                0xB5,
                0x56,
                0x35,
                0x5A,
                0xE0,
                0xCD,
                0x4F,
                0x29,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStreamWebSocket
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x49,
                0x4A,
                0xBD,
                0x89,
                0xB2,
                0xBB,
                0x45,
                0x97,
                0xEB,
                0xC7,
                0x52,
                0x52,
                0x05,
                0xA8,
                0x43,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStreamWebSocket2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCB,
                0x08,
                0x4D,
                0xAA,
                0xF5,
                0x93,
                0x78,
                0x46,
                0x82,
                0x36,
                0x57,
                0xCC,
                0xE5,
                0x41,
                0x7E,
                0xD5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStreamWebSocketControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB1,
                0x78,
                0xF4,
                0xB4,
                0x5A,
                0xA4,
                0xDB,
                0x48,
                0x95,
                0x3A,
                0x64,
                0x5B,
                0x7D,
                0x96,
                0x4C,
                0x07,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStreamWebSocketControl2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x9F,
                0x5D,
                0x21,
                0x58,
                0xFA,
                0xDA,
                0x40,
                0x9F,
                0x11,
                0xA4,
                0x8D,
                0xAF,
                0xE9,
                0x50,
                0x37,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebSocket
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6F,
                0x39,
                0x77,
                0xF8,
                0xB1,
                0x99,
                0x18,
                0x4E,
                0xBC,
                0x08,
                0x85,
                0x0C,
                0x9A,
                0xDF,
                0x15,
                0x6E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebSocketClosedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x07,
                0x8D,
                0xB7,
                0xCE,
                0xA8,
                0xD0,
                0x03,
                0x47,
                0xA0,
                0x91,
                0xC8,
                0xC2,
                0xC0,
                0x91,
                0x5B,
                0xC3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebSocketControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC3,
                0xBD,
                0xC4,
                0x2E,
                0xA5,
                0xD9,
                0x5A,
                0x45,
                0x98,
                0x11,
                0xDE,
                0x24,
                0xD4,
                0x53,
                0x37,
                0xE9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebSocketControl2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x03,
                0xBE,
                0xC3,
                0x79,
                0xCA,
                0xF2,
                0x1E,
                0x46,
                0xAF,
                0x4E,
                0x96,
                0x65,
                0xBC,
                0x2D,
                0x06,
                0x20,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebSocketErrorStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5B,
                0xF3,
                0xCD,
                0x27,
                0x61,
                0x1F,
                0x09,
                0x47,
                0x8E,
                0x02,
                0x61,
                0x28,
                0x3A,
                0xDA,
                0x4E,
                0x9D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebSocketInformation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x16,
                0xE3,
                0x01,
                0x5E,
                0x2A,
                0xC9,
                0xA5,
                0x47,
                0xB2,
                0x5F,
                0x07,
                0x84,
                0x76,
                0x39,
                0xD1,
                0x81,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebSocketInformation2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCE,
                0x39,
                0x1D,
                0xCE,
                0xB7,
                0xA1,
                0x43,
                0x4D,
                0x82,
                0x69,
                0x8D,
                0x5B,
                0x98,
                0x1B,
                0xD4,
                0x7A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebSocketServerCustomValidationRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0xFE,
                0xEF,
                0xFF,
                0x2A,
                0x02,
                0xB7,
                0x4A,
                0x8B,
                0x36,
                0xE1,
                0x0A,
                0xF4,
                0x64,
                0x0E,
                0x6B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
