// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public partial struct GamepadBinding
{
    public GamepadBindingType InputType;

    [NativeTypeName("__AnonymousRecord_SDL_gamepad_L196_C5")]
    public GamepadBindingInput Input;
    public GamepadBindingType OutputType;

    [NativeTypeName("__AnonymousRecord_SDL_gamepad_L216_C5")]
    public GamepadBindingOutput Output;
}
