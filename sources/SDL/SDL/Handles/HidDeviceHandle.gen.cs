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

public readonly unsafe partial struct HidDeviceHandle
{
    public readonly void* Handle;

    public bool Equals(HidDeviceHandle other) => Handle == other.Handle;

    public override bool Equals(object? obj) => obj is HidDeviceHandle other && Equals(other);

    public override int GetHashCode() => HashCode.Combine((nuint)Handle);

    public static bool operator ==(HidDeviceHandle left, HidDeviceHandle right) =>
        left.Equals(right);

    public static bool operator !=(HidDeviceHandle left, HidDeviceHandle right) =>
        !left.Equals(right);

    public bool Equals(NullPtr _) => Handle is null;

    public static bool operator ==(HidDeviceHandle left, NullPtr right) => left.Equals(right);

    public static bool operator !=(HidDeviceHandle left, NullPtr right) => !left.Equals(right);

    public static implicit operator HidDeviceHandle(NullPtr _) => default;
}
