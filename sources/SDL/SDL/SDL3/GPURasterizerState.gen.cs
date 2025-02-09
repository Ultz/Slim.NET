// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public partial struct GPURasterizerState
{
    public GPUFillMode FillMode;
    public GPUCullMode CullMode;
    public GPUFrontFace FrontFace;
    public float DepthBiasConstantFactor;
    public float DepthBiasClamp;
    public float DepthBiasSlopeFactor;

    [NativeTypeName("bool")]
    public byte EnableDepthBias;

    [NativeTypeName("bool")]
    public byte EnableDepthClip;

    [NativeTypeName("Uint8")]
    public byte Padding1;

    [NativeTypeName("Uint8")]
    public byte Padding2;
}
