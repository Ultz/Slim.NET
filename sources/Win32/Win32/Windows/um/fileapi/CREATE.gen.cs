// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/fileapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class CREATE
{
    [NativeTypeName("#define CREATE_NEW 1")]
    public const int CREATE_NEW = 1;

    [NativeTypeName("#define CREATE_ALWAYS 2")]
    public const int CREATE_ALWAYS = 2;
}
