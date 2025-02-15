// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class DEFAULT
{
    [NativeTypeName("#define DEFAULT_TLS_SSP_NAME_A \"Default TLS SSP\"")]
    public static ReadOnlySpan<byte> DEFAULT_TLS_SSP_NAME_A => "Default TLS SSP"u8;

    [NativeTypeName("#define DEFAULT_TLS_SSP_NAME_W L\"Default TLS SSP\"")]
    public const string DEFAULT_TLS_SSP_NAME_W = "Default TLS SSP";

    [NativeTypeName("#define DEFAULT_TLS_SSP_NAME DEFAULT_TLS_SSP_NAME_W")]
    public const string DEFAULT_TLS_SSP_NAME = "Default TLS SSP";
}
