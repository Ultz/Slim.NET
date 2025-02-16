// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Win32;
using static Silk.NET.Win32.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    public static HRESULT MAKE_D3DHRESULT(int code)
    {
        return MAKE_HRESULT(1, _FACD3D, code);
    }

    public static HRESULT MAKE_D3DSTATUS(int code)
    {
        return MAKE_HRESULT(0, _FACD3D, code);
    }
}
