// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using static Silk.NET.Win32.WINDOWTHEMEATTRIBUTETYPE;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    public static HRESULT BufferedPaintMakeOpaque(HPAINTBUFFER hBufferedPaint, RECT* prc) =>
        BufferedPaintSetAlpha(hBufferedPaint, prc, 255);

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT BufferedPaintMakeOpaque(HPAINTBUFFER hBufferedPaint, Ref<RECT> prc)
    {
        fixed (RECT* __dsl_prc = prc)
        {
            return (HRESULT)BufferedPaintMakeOpaque(hBufferedPaint, __dsl_prc);
        }
    }

    public static HRESULT SetWindowThemeNonClientAttributes(
        HWND hwnd,
        uint dwMask,
        uint dwAttributes
    )
    {
        var wta = new WTA_OPTIONS { dwFlags = dwAttributes, dwMask = dwMask };
        return SetWindowThemeAttribute(
            hwnd,
            WTA_NONCLIENT,
            (void*)&(wta),
            (uint)sizeof(WTA_OPTIONS)
        );
    }
}
