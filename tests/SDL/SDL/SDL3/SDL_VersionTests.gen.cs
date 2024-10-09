// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.SDL.UnitTests;

/// <summary>Provides validation of the <see cref = "SDL_Version"/> struct.</summary>
public static unsafe partial class SDL_VersionTests
{
    /// <summary>Validates that the <see cref = "SDL_Version"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<Version>(), Is.EqualTo(sizeof(Version)));
    }

    /// <summary>Validates that the <see cref = "SDL_Version"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(Version).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SDL_Version"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(Version), Is.EqualTo(3));
    }
}
