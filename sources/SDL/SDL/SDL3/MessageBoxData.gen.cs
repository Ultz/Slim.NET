// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.SDL.ArrayOrder;
using static Silk.NET.SDL.BitmapOrder;
using static Silk.NET.SDL.ChromaLocation;
using static Silk.NET.SDL.ColorPrimaries;
using static Silk.NET.SDL.ColorRange;
using static Silk.NET.SDL.ColorType;
using static Silk.NET.SDL.MatrixCoefficients;
using static Silk.NET.SDL.PackedLayout;
using static Silk.NET.SDL.PackedOrder;
using static Silk.NET.SDL.PenAxis;
using static Silk.NET.SDL.PixelType;
using static Silk.NET.SDL.Scancode;
using static Silk.NET.SDL.TransferCharacteristics;

namespace Silk.NET.SDL;

public unsafe partial struct MessageBoxData
{
    [NativeTypeName("Uint32")]
    public uint Flags;
    public WindowHandle Window;

    [NativeTypeName("const char *")]
    public sbyte* Title;

    [NativeTypeName("const char *")]
    public sbyte* Message;
    public int Numbuttons;

    [NativeTypeName("const SDL_MessageBoxButtonData *")]
    public MessageBoxButtonData* Buttons;

    [NativeTypeName("const SDL_MessageBoxColorScheme *")]
    public MessageBoxColorScheme* ColorScheme;
}
