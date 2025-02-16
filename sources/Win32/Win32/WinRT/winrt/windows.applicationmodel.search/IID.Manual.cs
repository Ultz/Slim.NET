// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.search.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_ILocalContentSuggestionSettings
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x62,
                0xB0,
                0xAE,
                0xEE,
                0x3D,
                0x74,
                0x6E,
                0x45,
                0x84,
                0xA3,
                0x23,
                0xF0,
                0x6F,
                0x2D,
                0x15,
                0xD7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISearchPane
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x38,
                0xEC,
                0xAC,
                0xFD,
                0x00,
                0x37,
                0x73,
                0x4D,
                0x91,
                0xA1,
                0x2F,
                0x99,
                0x86,
                0x74,
                0x23,
                0x8A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISearchPaneQueryChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE9,
                0x4F,
                0x06,
                0x3C,
                0x51,
                0x23,
                0x48,
                0x42,
                0xA5,
                0x29,
                0x71,
                0x10,
                0xF4,
                0x64,
                0xA7,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISearchPaneQueryLinguisticDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0E,
                0x46,
                0xFB,
                0x82,
                0x40,
                0x09,
                0x6D,
                0x4B,
                0xB8,
                0xD0,
                0x64,
                0x2B,
                0x30,
                0x98,
                0x9E,
                0x15,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISearchPaneQuerySubmittedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFC,
                0xA4,
                0x3B,
                0x14,
                0xC5,
                0xE9,
                0x36,
                0x47,
                0x91,
                0xB2,
                0xE8,
                0xEB,
                0x9C,
                0xB8,
                0x83,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE5,
                0x92,
                0x0C,
                0x46,
                0x32,
                0x4C,
                0x38,
                0x45,
                0xA4,
                0xD4,
                0xB6,
                0xB4,
                0x40,
                0x0D,
                0x14,
                0x0F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISearchPaneResultSuggestionChosenEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0x6C,
                0x31,
                0xC8,
                0xD2,
                0xAE,
                0xE0,
                0x41,
                0xBC,
                0xE0,
                0xC2,
                0x6C,
                0xA7,
                0x4F,
                0x85,
                0xEC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISearchPaneStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF1,
                0xAD,
                0x72,
                0x95,
                0x1D,
                0x8F,
                0x1F,
                0x48,
                0xA1,
                0x5B,
                0xC6,
                0x16,
                0x55,
                0xF1,
                0x6A,
                0x0E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISearchPaneStaticsWithHideThisApplication
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0x28,
                0x73,
                0x00,
                0xF1,
                0x50,
                0x03,
                0x4D,
                0x99,
                0xAC,
                0xC6,
                0x64,
                0x4C,
                0x8E,
                0xD8,
                0xB5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISearchPaneSuggestionsRequest
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1C,
                0x0B,
                0xB1,
                0x81,
                0x61,
                0xE5,
                0x93,
                0x40,
                0x9B,
                0x4D,
                0x2A,
                0xD4,
                0x82,
                0x79,
                0x4A,
                0x53,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISearchPaneSuggestionsRequestDeferral
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF7,
                0x09,
                0xD0,
                0xA0,
                0x48,
                0x87,
                0xE2,
                0x4E,
                0xAD,
                0x44,
                0xAF,
                0xA6,
                0xBE,
                0x99,
                0x7C,
                0x51,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISearchPaneSuggestionsRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2F,
                0x8A,
                0x9B,
                0xC8,
                0x56,
                0xAC,
                0x60,
                0x44,
                0x8D,
                0x2F,
                0x80,
                0x02,
                0x3B,
                0xEC,
                0x4F,
                0xC5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISearchPaneVisibilityChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x46,
                0x30,
                0x4D,
                0x3C,
                0x4B,
                0xAC,
                0xF2,
                0x49,
                0x97,
                0xD6,
                0x02,
                0x0E,
                0x61,
                0x82,
                0xCB,
                0x9C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISearchQueryLinguisticDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5B,
                0x20,
                0xA1,
                0x46,
                0xC9,
                0x69,
                0x45,
                0x47,
                0xB7,
                0x2F,
                0xA8,
                0xA4,
                0xFC,
                0x8F,
                0x24,
                0xAE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISearchQueryLinguisticDetailsFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB8,
                0xC3,
                0xC6,
                0xCA,
                0x64,
                0x3C,
                0xFD,
                0x4D,
                0xAD,
                0x9F,
                0x47,
                0x9E,
                0x4D,
                0x40,
                0x65,
                0xA4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISearchSuggestionCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4B,
                0x8A,
                0x3A,
                0x32,
                0xEA,
                0xFB,
                0x46,
                0x44,
                0xAB,
                0xBC,
                0x3D,
                0xA7,
                0x91,
                0x5F,
                0xDD,
                0x3A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISearchSuggestionsRequest
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA7,
                0x26,
                0x4E,
                0x4E,
                0xE5,
                0x44,
                0x39,
                0x40,
                0x90,
                0x99,
                0x60,
                0x00,
                0xEA,
                0xD1,
                0xF0,
                0xC6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISearchSuggestionsRequestDeferral
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0x98,
                0x15,
                0xB7,
                0x65,
                0xC0,
                0x6D,
                0x45,
                0xA8,
                0x45,
                0x1E,
                0xCC,
                0xEC,
                0x5D,
                0xC2,
                0x8B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
