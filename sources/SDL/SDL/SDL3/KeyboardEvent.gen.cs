// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public partial struct KeyboardEvent
{
    public EventType Type;

    [NativeTypeName("Uint32")]
    public uint Reserved;

    [NativeTypeName("Uint64")]
    public ulong Timestamp;

    [NativeTypeName("SDL_WindowID")]
    public uint WindowID;

    [NativeTypeName("SDL_KeyboardID")]
    public uint Which;
    public Scancode Scancode;

    [NativeTypeName("SDL_Keycode")]
    public uint Key;

    [NativeTypeName("SDL_Keymod")]
    public ushort Mod;

    [NativeTypeName("Uint16")]
    public ushort Raw;

    [NativeTypeName("bool")]
    public byte Down;

    [NativeTypeName("bool")]
    public byte Repeat;
}
