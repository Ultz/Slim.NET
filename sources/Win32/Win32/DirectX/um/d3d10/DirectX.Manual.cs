// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Win32;
using static Silk.NET.DirectX.D3D10_FILTER_TYPE;
using static Silk.NET.Win32.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DirectX
{
    public static bool D3D10_DECODE_IS_ANISOTROPIC_FILTER(D3D10_FILTER d3d10Filter)
    {
        return (
            ((int)(d3d10Filter) & (0x40)) != 0
            && (D3D10_FILTER_TYPE_LINEAR == D3D10_DECODE_MIN_FILTER(d3d10Filter))
            && (D3D10_FILTER_TYPE_LINEAR == D3D10_DECODE_MAG_FILTER(d3d10Filter))
            && (D3D10_FILTER_TYPE_LINEAR == D3D10_DECODE_MIP_FILTER(d3d10Filter))
        );
    }

    public static bool D3D10_DECODE_IS_COMPARISON_FILTER(D3D10_FILTER d3d10Filter)
    {
        return ((int)(d3d10Filter) & (0x80)) != 0;
    }

    public static bool D3D10_DECODE_IS_TEXT_1BIT_FILTER(D3D10_FILTER d3d10Filter)
    {
        return ((uint)(d3d10Filter) == (0x80000000));
    }

    public static D3D10_FILTER_TYPE D3D10_DECODE_MAG_FILTER(D3D10_FILTER d3d10Filter)
    {
        return ((D3D10_FILTER_TYPE)(((int)(d3d10Filter) >> (2)) & (0x3)));
    }

    public static D3D10_FILTER_TYPE D3D10_DECODE_MIN_FILTER(D3D10_FILTER d3d10Filter)
    {
        return ((D3D10_FILTER_TYPE)(((int)(d3d10Filter) >> (4)) & (0x3)));
    }

    public static D3D10_FILTER_TYPE D3D10_DECODE_MIP_FILTER(D3D10_FILTER d3d10Filter)
    {
        return ((D3D10_FILTER_TYPE)(((int)(d3d10Filter) >> (0)) & (0x3)));
    }

    public static D3D10_FILTER D3D10_ENCODE_ANISOTROPIC_FILTER(bool bComparison)
    {
        return (
            (D3D10_FILTER)(
                (
                    (0x40)
                    | (int)D3D10_ENCODE_BASIC_FILTER(
                        (int)(D3D10_FILTER_TYPE_LINEAR),
                        (int)(D3D10_FILTER_TYPE_LINEAR),
                        (int)(D3D10_FILTER_TYPE_LINEAR),
                        bComparison
                    )
                )
            )
        );
    }

    public static D3D10_FILTER D3D10_ENCODE_BASIC_FILTER(
        int min,
        int mag,
        int mip,
        bool bComparison
    )
    {
        return (
            (D3D10_FILTER)(
                ((bComparison) ? (0x80) : 0)
                | (((min) & (0x3)) << (4))
                | (((mag) & (0x3)) << (2))
                | (((mip) & (0x3)) << (0))
            )
        );
    }

    public static HRESULT MAKE_D3D10_HRESULT(int code) => MAKE_HRESULT(1, _FACD3D10, code);

    public static HRESULT MAKE_D3D10_STATUS(int code) => MAKE_HRESULT(0, _FACD3D10, code);
}
