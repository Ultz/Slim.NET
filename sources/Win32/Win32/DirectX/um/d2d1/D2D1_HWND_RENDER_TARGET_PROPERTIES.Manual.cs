// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Win32;
using static Silk.NET.DirectX.D2D1_PRESENT_OPTIONS;
using static Silk.NET.DirectX.DirectX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D2D1_HWND_RENDER_TARGET_PROPERTIES
{
    public D2D1_HWND_RENDER_TARGET_PROPERTIES(
        HWND hwnd,
        [NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U pixelSize = default,
        D2D1_PRESENT_OPTIONS presentOptions = D2D1_PRESENT_OPTIONS_NONE
    )
    {
        this = HwndRenderTargetProperties(hwnd, pixelSize, presentOptions);
    }
}
