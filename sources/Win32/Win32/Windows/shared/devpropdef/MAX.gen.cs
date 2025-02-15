// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/devpropdef.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class MAX
{
    [NativeTypeName("#define MAX_DEVPROP_TYPE 0x00000019")]
    public const int MAX_DEVPROP_TYPE = 0x00000019;

    [NativeTypeName("#define MAX_DEVPROP_TYPEMOD 0x00002000")]
    public const int MAX_DEVPROP_TYPEMOD = 0x00002000;
}
