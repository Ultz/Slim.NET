// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DXGI_RGBA
{
    public DXGI_RGBA([NativeTypeName("UINT32")] uint rgb, float a = 1.0f)
    {
        r = (float)((rgb & sc_redMask) >> (int)sc_redShift) / 255.0f;
        g = (float)((rgb & sc_greenMask) >> (int)sc_greenShift) / 255.0f;
        b = (float)((rgb & sc_blueMask) >> (int)sc_blueShift) / 255.0f;
        this.a = a;
    }

    public DXGI_RGBA(ColorF knownColor, float a = 1.0f)
        : this((uint)knownColor, a) { }

    public DXGI_RGBA(float red, float green, float blue, float alpha = 1.0f)
    {
        r = red;
        g = green;
        b = blue;
        a = alpha;
    }

    private const uint sc_redShift = 16;
    private const uint sc_greenShift = 8;
    private const uint sc_blueShift = 0;
    private const uint sc_redMask = 0xff << (int)sc_redShift;
    private const uint sc_greenMask = 0xff << (int)sc_greenShift;
    private const uint sc_blueMask = 0xff << (int)sc_blueShift;
}
