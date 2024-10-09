// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
namespace Silk.NET.SDL;

public partial struct TouchFingerEvent
{
    public EventType Type;

    [NativeTypeName("Uint32")]
    public uint Reserved;

    [NativeTypeName("Uint64")]
    public ulong Timestamp;

    [NativeTypeName("SDL_TouchID")]
    public ulong TouchID;

    [NativeTypeName("SDL_FingerID")]
    public ulong FingerID;
    public float X;
    public float Y;
    public float Dx;
    public float Dy;
    public float Pressure;

    [NativeTypeName("SDL_WindowID")]
    public uint WindowID;
}
