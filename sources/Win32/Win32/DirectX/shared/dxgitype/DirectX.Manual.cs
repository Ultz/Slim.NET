// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Win32;
using static Silk.NET.Win32.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DirectX
{
    public static HRESULT MAKE_DXGI_HRESULT(int code) => MAKE_HRESULT(1, _FACDXGI, code);

    public static HRESULT MAKE_DXGI_STATUS(int code) => MAKE_HRESULT(0, _FACDXGI, code);
}
