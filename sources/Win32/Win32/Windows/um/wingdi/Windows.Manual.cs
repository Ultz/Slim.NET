// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    public static HANDLE HGDI_ERROR => (HANDLE)(-1);
    public const int GDIREGISTERDDRAWPACKETVERSION = 0x1;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static COLORREF CMYK(byte c, byte m, byte y, byte k) =>
        k | ((uint)y << 8) | (((uint)m) << 16) | (((uint)c) << 24);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint GDI__DIBSIZE(BITMAPINFOHEADER bi) =>
        GDI_DIBWIDTHBYTES(bi) * (uint)bi.biHeight;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint GDI_DIBSIZE(BITMAPINFOHEADER bi) =>
        bi.biHeight < 0 ? unchecked((uint)-1) * GDI__DIBSIZE(bi) : GDI__DIBSIZE(bi);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint GDI_DIBWIDTHBYTES(BITMAPINFOHEADER bi) =>
        GDI_WIDTHBYTES((uint)bi.biWidth * bi.biBitCount);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint GDI_WIDTHBYTES(uint bits) => ((bits + 31) & ~31u) / 8;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte GetBValue(COLORREF rgb) => LOBYTE((ushort)(rgb >> 16));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte GetCValue(COLORREF cmyk) => (byte)(cmyk >> 24);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte GetGValue(COLORREF rgb) => LOBYTE((ushort)(rgb >> 8));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte GetKValue(COLORREF cmyk) => (byte)cmyk;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte GetMValue(COLORREF cmyk) => (byte)(cmyk >> 16);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte GetRValue(COLORREF rgb) => LOBYTE((ushort)rgb);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte GetYValue(COLORREF cmyk) => (byte)(cmyk >> 8);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static POINTS MAKEPOINTS(int l) => *(POINTS*)&l;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint MAKEROP4(uint fore, uint back) => ((back << 8) & 0xFF000000) | fore;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static COLORREF PALETTEINDEX(ushort i) => 0x01000000 | (uint)i;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static COLORREF PALETTERGB(byte r, byte g, byte b) => 0x02000000 | RGB(r, g, b);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static COLORREF RGB(byte r, byte g, byte b) => r | ((uint)g << 8) | (((uint)b) << 16);
}
