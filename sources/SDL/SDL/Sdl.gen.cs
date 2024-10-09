// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Core.Loader;
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

partial class Sdl(INativeContext nativeContext) : IDisposable
{
    public partial class DllImport
    {
        static DllImport() => LoaderInterface.RegisterHook(Assembly.GetExecutingAssembly());
    }

    public partial class ThisThread : ISdl.Static
    {
        public static ThreadLocal<ISdl> Underlying { get; } =
            new(static () => new StaticWrapper<DllImport>());

        public static void MakeCurrent(ISdl ctx) => Underlying.Value = ctx;
    }

    public static ISdl Instance { get; } = new StaticWrapper<DllImport>();

    public static ISdl Create() => Instance;

    public static ISdl Create(INativeContext ctx) => new Sdl(ctx);

    /// <inheritdoc/>
    public void Dispose() => nativeContext.Dispose();
}
