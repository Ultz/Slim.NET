// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.search.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IRequestingFocusOnKeyboardInputEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x27,
                0x5F,
                0x19,
                0xA1,
                0xA7,
                0xB1,
                0xA2,
                0x41,
                0x87,
                0x9D,
                0x6A,
                0x68,
                0x68,
                0x7E,
                0x59,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISearchSuggestion
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0x54,
                0x55,
                0x5B,
                0x27,
                0x15,
                0x7B,
                0x43,
                0x95,
                0xC5,
                0x8D,
                0x18,
                0xD2,
                0xB8,
                0xAF,
                0x55,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISearchSuggestionManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x50,
                0x0C,
                0x3F,
                0x9D,
                0xCB,
                0x7B,
                0x49,
                0xB5,
                0x00,
                0x3C,
                0x04,
                0xAC,
                0x95,
                0x9A,
                0xD2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISearchSuggestionsRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE5,
                0x19,
                0xD5,
                0x6F,
                0x7E,
                0x9E,
                0xB4,
                0x4A,
                0x8B,
                0xE3,
                0xC7,
                0x6B,
                0x1B,
                0xD4,
                0x34,
                0x4A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
