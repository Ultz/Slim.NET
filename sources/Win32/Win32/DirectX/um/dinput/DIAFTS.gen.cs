// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DIAFTS
{
    [NativeTypeName("#define DIAFTS_NEWDEVICELOW 0xFFFFFFFF")]
    public const uint DIAFTS_NEWDEVICELOW = 0xFFFFFFFF;

    [NativeTypeName("#define DIAFTS_NEWDEVICEHIGH 0xFFFFFFFF")]
    public const uint DIAFTS_NEWDEVICEHIGH = 0xFFFFFFFF;

    [NativeTypeName("#define DIAFTS_UNUSEDDEVICELOW 0x00000000")]
    public const int DIAFTS_UNUSEDDEVICELOW = 0x00000000;

    [NativeTypeName("#define DIAFTS_UNUSEDDEVICEHIGH 0x00000000")]
    public const int DIAFTS_UNUSEDDEVICEHIGH = 0x00000000;
}
