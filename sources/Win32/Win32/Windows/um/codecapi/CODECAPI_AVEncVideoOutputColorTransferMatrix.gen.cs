// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A9B90444-AF40-4310-8FBE-ED6D933F892B")]
public unsafe partial struct CODECAPI_AVEncVideoOutputColorTransferMatrix : INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncVideoOutputColorTransferMatrix));
}
