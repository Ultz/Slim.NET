// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.data.pdf.interop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [SupportedOSPlatform("windows6.3")]
    public static unsafe PDF_RENDER_PARAMS PdfRenderParams(
        [NativeTypeName("const D2D_RECT_F &")] D2D_RECT_F* srcRect,
        [NativeTypeName("UINT32")] uint destinationWidth,
        [NativeTypeName("UINT32")] uint destinationHeight,
        [NativeTypeName("const D2D_COLOR_F &")] DXGI_RGBA* bkColor,
        [NativeTypeName("BOOLEAN")] byte ignoreHighContrast
    )
    {
        PDF_RENDER_PARAMS p = new PDF_RENDER_PARAMS
        {
            SourceRect = *srcRect,
            DestinationWidth = destinationWidth,
            DestinationHeight = destinationHeight,
            BackgroundColor = *bkColor,
            IgnoreHighContrast = ignoreHighContrast,
        };
        return p;
    }

    [SupportedOSPlatform("windows6.3")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe PDF_RENDER_PARAMS PdfRenderParams(
        [NativeTypeName("const D2D_RECT_F &")] Ref<D2D_RECT_F> srcRect,
        [NativeTypeName("UINT32")] uint destinationWidth,
        [NativeTypeName("UINT32")] uint destinationHeight,
        [NativeTypeName("const D2D_COLOR_F &")] Ref<DXGI_RGBA> bkColor,
        [NativeTypeName("BOOLEAN")] byte ignoreHighContrast
    )
    {
        fixed (DXGI_RGBA* __dsl_bkColor = bkColor)
        fixed (D2D_RECT_F* __dsl_srcRect = srcRect)
        {
            return (PDF_RENDER_PARAMS)PdfRenderParams(
                __dsl_srcRect,
                destinationWidth,
                destinationHeight,
                __dsl_bkColor,
                ignoreHighContrast
            );
        }
    }
}
