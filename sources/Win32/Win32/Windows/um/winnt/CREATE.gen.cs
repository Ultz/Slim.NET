// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class CREATE
{
    [NativeTypeName("#define CREATE_BOUNDARY_DESCRIPTOR_ADD_APPCONTAINER_SID 0x1")]
    public const int CREATE_BOUNDARY_DESCRIPTOR_ADD_APPCONTAINER_SID = 0x1;
}
