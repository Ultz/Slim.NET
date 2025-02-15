// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DirectX
{
    public static uint D3D10CalcSubresource(uint MipSlice, uint ArraySlice, uint MipLevels)
    {
        return MipSlice + ArraySlice * MipLevels;
    }

    [NativeTypeName("#define _FACD3D10 ( 0x879 )")]
    public const int _FACD3D10 = (0x879);

    [NativeTypeName("#define _FACD3D10DEBUG ( ( _FACD3D10 + 1 )  )")]
    public const int _FACD3D10DEBUG = (((0x879) + 1));
}
