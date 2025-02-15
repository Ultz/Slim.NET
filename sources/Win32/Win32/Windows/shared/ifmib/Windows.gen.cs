// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ifmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class Windows
{
    [NativeTypeName("#define ANY_SIZE 1")]
    public const int ANY_SIZE = 1;

    [NativeTypeName("#define MAXLEN_PHYSADDR 8")]
    public const int MAXLEN_PHYSADDR = 8;

    [NativeTypeName("#define MAXLEN_IFDESCR 256")]
    public const int MAXLEN_IFDESCR = 256;
}
