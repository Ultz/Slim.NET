// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class SET
{
    [NativeTypeName("#define SET_TAPE_MEDIA_INFORMATION 0")]
    public const int SET_TAPE_MEDIA_INFORMATION = 0;

    [NativeTypeName("#define SET_TAPE_DRIVE_INFORMATION 1")]
    public const int SET_TAPE_DRIVE_INFORMATION = 1;
}
