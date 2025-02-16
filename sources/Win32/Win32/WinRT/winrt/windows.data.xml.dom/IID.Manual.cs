// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.data.xml.dom.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IDtdEntity
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFC,
                0x5F,
                0x0B,
                0x6A,
                0xB4,
                0x63,
                0x0F,
                0x48,
                0x9E,
                0x6A,
                0x8A,
                0x92,
                0x81,
                0x6A,
                0xAD,
                0xE4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDtdNotation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4D,
                0xE0,
                0xB4,
                0x8C,
                0x46,
                0x6D,
                0xDB,
                0x4E,
                0xAB,
                0x73,
                0xDF,
                0x83,
                0xC5,
                0x1A,
                0xD3,
                0x97,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IXmlAttribute
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA4,
                0x4A,
                0x14,
                0xAC,
                0xF1,
                0xB4,
                0xB6,
                0x4D,
                0xB2,
                0x06,
                0x8A,
                0x22,
                0xC3,
                0x08,
                0xDB,
                0x0A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IXmlCDataSection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6F,
                0xB4,
                0x04,
                0x4D,
                0xBD,
                0xC8,
                0xB4,
                0x45,
                0x88,
                0x99,
                0x04,
                0x00,
                0xD7,
                0xC2,
                0xC6,
                0x0F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IXmlCharacterData
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0x42,
                0x2E,
                0x13,
                0x36,
                0x4E,
                0xF6,
                0x4D,
                0xB1,
                0xC8,
                0x0C,
                0xE6,
                0x2F,
                0xD8,
                0x8B,
                0x26,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IXmlComment
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD5,
                0x74,
                0xA4,
                0xBC,
                0x1F,
                0xB6,
                0x11,
                0x46,
                0x9C,
                0xAC,
                0x2E,
                0x92,
                0xE3,
                0x47,
                0x6D,
                0x47,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IXmlDocument
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x06,
                0xA5,
                0xF3,
                0xF7,
                0x87,
                0x1E,
                0xD6,
                0x42,
                0xBC,
                0xFB,
                0xB8,
                0xC8,
                0x09,
                0xFA,
                0x54,
                0x94,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IXmlDocumentFragment
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0x6A,
                0xEA,
                0xE2,
                0x21,
                0x0C,
                0xA5,
                0x44,
                0x8B,
                0xC9,
                0x9E,
                0x4A,
                0x26,
                0x27,
                0x08,
                0xEC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IXmlDocumentIO
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4E,
                0xE7,
                0xD0,
                0x6C,
                0x65,
                0xEE,
                0x89,
                0x44,
                0x9E,
                0xBF,
                0xCA,
                0x43,
                0xE8,
                0x7B,
                0xA6,
                0x37,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IXmlDocumentIO2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x61,
                0x46,
                0x03,
                0x5D,
                0xD8,
                0x7B,
                0xD5,
                0x4A,
                0x9E,
                0xBF,
                0x81,
                0xE6,
                0x34,
                0x72,
                0x63,
                0xB1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IXmlDocumentStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x54,
                0xD2,
                0x43,
                0x55,
                0x57,
                0xD7,
                0x79,
                0x4B,
                0x95,
                0x39,
                0x23,
                0x2B,
                0x18,
                0xF5,
                0x0B,
                0xF1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IXmlDocumentType
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x25,
                0x24,
                0x34,
                0xF7,
                0x81,
                0x97,
                0x64,
                0x49,
                0x8E,
                0x94,
                0x9B,
                0x1C,
                0x6D,
                0xFC,
                0x9B,
                0xC7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IXmlDomImplementation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x32,
                0x81,
                0xE5,
                0x6D,
                0x1D,
                0xF1,
                0xBB,
                0x4F,
                0x8C,
                0xC6,
                0x58,
                0x3C,
                0xBA,
                0x93,
                0x11,
                0x2F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IXmlElement
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1F,
                0x8A,
                0xFB,
                0x2D,
                0x10,
                0x6B,
                0xF8,
                0x4E,
                0x9F,
                0x83,
                0xEF,
                0xCC,
                0xE8,
                0xFA,
                0xEC,
                0x37,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IXmlEntityReference
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBC,
                0x47,
                0x2F,
                0x2E,
                0xD0,
                0xC3,
                0xCF,
                0x4C,
                0xBB,
                0x86,
                0x0A,
                0xB8,
                0xC3,
                0x6A,
                0x61,
                0xCF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IXmlLoadSettings
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA8,
                0x07,
                0xAA,
                0x58,
                0xD6,
                0xFE,
                0xF7,
                0x46,
                0xB4,
                0xC5,
                0xFB,
                0x1B,
                0xA7,
                0x21,
                0x08,
                0xD6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IXmlNamedNodeMap
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0x9E,
                0xA6,
                0xB3,
                0xB0,
                0xAA,
                0x82,
                0x4B,
                0xA6,
                0xFA,
                0xB1,
                0x45,
                0x3F,
                0x7C,
                0x02,
                0x1B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IXmlNode
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0x1D,
                0x74,
                0x1C,
                0x22,
                0x21,
                0xD5,
                0x47,
                0xA8,
                0x56,
                0x83,
                0xF3,
                0xD4,
                0x21,
                0x48,
                0x75,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IXmlNodeList
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x77,
                0xAD,
                0x60,
                0x8C,
                0xA4,
                0x83,
                0xC1,
                0x4E,
                0x9C,
                0x54,
                0x7B,
                0xA4,
                0x29,
                0xE1,
                0x3D,
                0xA6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IXmlNodeSelector
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0xBA,
                0xDB,
                0x63,
                0xDB,
                0xD0,
                0xE1,
                0x4F,
                0xB7,
                0x45,
                0xF9,
                0x43,
                0x3A,
                0xFD,
                0xC2,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IXmlNodeSerializer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x82,
                0xB3,
                0xC5,
                0x5C,
                0xDD,
                0xE6,
                0x91,
                0x49,
                0xAB,
                0xEF,
                0x06,
                0xD8,
                0xD2,
                0xE7,
                0xBD,
                0x0C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IXmlProcessingInstruction
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1E,
                0xFD,
                0x07,
                0x27,
                0x92,
                0x1E,
                0xCE,
                0x4E,
                0xB6,
                0xF4,
                0x26,
                0xF0,
                0x69,
                0x07,
                0x8D,
                0xDC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IXmlText
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCB,
                0xA4,
                0x31,
                0xF9,
                0x8D,
                0x30,
                0x60,
                0x47,
                0xA1,
                0xD5,
                0x43,
                0xB6,
                0x74,
                0x50,
                0xAC,
                0x7E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
