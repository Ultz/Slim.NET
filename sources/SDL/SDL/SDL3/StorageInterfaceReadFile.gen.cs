// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[Transformed]
public readonly unsafe struct StorageInterfaceReadFile : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<void*, sbyte*, void*, ulong, byte> Handle =>
        (delegate* unmanaged<void*, sbyte*, void*, ulong, byte>)Pointer;

    public StorageInterfaceReadFile(delegate* unmanaged<void*, sbyte*, void*, ulong, byte> ptr) =>
        Pointer = ptr;

    public StorageInterfaceReadFile(StorageInterfaceReadFileDelegate proc) =>
        Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator StorageInterfaceReadFile(
        delegate* unmanaged<void*, sbyte*, void*, ulong, byte> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<void*, sbyte*, void*, ulong, byte>(
        StorageInterfaceReadFile pfn
    ) => (delegate* unmanaged<void*, sbyte*, void*, ulong, byte>)pfn.Pointer;
}
