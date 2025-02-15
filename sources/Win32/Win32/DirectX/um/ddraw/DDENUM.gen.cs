// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DDENUM
{
    [NativeTypeName("#define DDENUM_ATTACHEDSECONDARYDEVICES 0x00000001L")]
    public const int DDENUM_ATTACHEDSECONDARYDEVICES = 0x00000001;

    [NativeTypeName("#define DDENUM_DETACHEDSECONDARYDEVICES 0x00000002L")]
    public const int DDENUM_DETACHEDSECONDARYDEVICES = 0x00000002;

    [NativeTypeName("#define DDENUM_NONDISPLAYDEVICES 0x00000004L")]
    public const int DDENUM_NONDISPLAYDEVICES = 0x00000004;
}
