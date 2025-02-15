// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class TRUST_ATTRIBUTE
{
    [NativeTypeName("#define TRUST_ATTRIBUTES_VALID 0xFF03FFFF")]
    public const uint TRUST_ATTRIBUTES_VALID = 0xFF03FFFF;

    [NativeTypeName("#define TRUST_ATTRIBUTES_USER 0xFF000000")]
    public const uint TRUST_ATTRIBUTES_USER = 0xFF000000;
}
