// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public unsafe partial struct WPARAM
{
    public static explicit operator WPARAM(void* value) => new WPARAM((nuint)(value));

    public static implicit operator void*(WPARAM value) => (void*)(value.Value);

    public static explicit operator WPARAM(BOOL value) => new WPARAM((nuint)(value.Value));

    public static explicit operator BOOL(WPARAM value) => new BOOL((int)(value.Value));

    public static explicit operator WPARAM(HANDLE value) => new WPARAM((nuint)(value.Value));

    public static explicit operator HANDLE(WPARAM value) => new HANDLE((void*)(value.Value));

    public static explicit operator WPARAM(HBRUSH value) => new WPARAM((nuint)(value.Value));

    public static explicit operator HBRUSH(WPARAM value) => new HBRUSH((void*)(value.Value));

    public static explicit operator WPARAM(HCURSOR value) => new WPARAM((nuint)(value.Value));

    public static explicit operator HCURSOR(WPARAM value) => new HCURSOR((void*)(value.Value));

    public static explicit operator WPARAM(HDC value) => new WPARAM((nuint)(value.Value));

    public static explicit operator HDC(WPARAM value) => new HDC((void*)(value.Value));

    public static explicit operator WPARAM(HDROP value) => new WPARAM((nuint)(value.Value));

    public static explicit operator HDROP(WPARAM value) => new HDROP((void*)(value.Value));

    public static explicit operator WPARAM(HFONT value) => new WPARAM((nuint)(value.Value));

    public static explicit operator HFONT(WPARAM value) => new HFONT((void*)(value.Value));

    public static explicit operator WPARAM(HGDIOBJ value) => new WPARAM((nuint)(value.Value));

    public static explicit operator HGDIOBJ(WPARAM value) => new HGDIOBJ((void*)(value.Value));

    public static explicit operator WPARAM(HGLOBAL value) => new WPARAM((nuint)(value.Value));

    public static explicit operator HGLOBAL(WPARAM value) => new HGLOBAL((void*)(value.Value));

    public static explicit operator WPARAM(HICON value) => new WPARAM((nuint)(value.Value));

    public static explicit operator HICON(WPARAM value) => new HICON((void*)(value.Value));

    public static explicit operator WPARAM(HINSTANCE value) => new WPARAM((nuint)(value.Value));

    public static explicit operator HINSTANCE(WPARAM value) => new HINSTANCE((void*)(value.Value));

    public static explicit operator WPARAM(HLOCAL value) => new WPARAM((nuint)(value.Value));

    public static explicit operator HLOCAL(WPARAM value) => new HLOCAL((void*)(value.Value));

    public static explicit operator WPARAM(HMENU value) => new WPARAM((nuint)(value.Value));

    public static explicit operator HMENU(WPARAM value) => new HMENU((void*)(value.Value));

    public static explicit operator WPARAM(HMODULE value) => new WPARAM((nuint)(value.Value));

    public static explicit operator HMODULE(WPARAM value) => new HMODULE((void*)(value.Value));

    public static explicit operator WPARAM(HPALETTE value) => new WPARAM((nuint)(value.Value));

    public static explicit operator HPALETTE(WPARAM value) => new HPALETTE((void*)(value.Value));

    public static explicit operator WPARAM(HPEN value) => new WPARAM((nuint)(value.Value));

    public static explicit operator HPEN(WPARAM value) => new HPEN((void*)(value.Value));

    public static explicit operator WPARAM(HRGN value) => new WPARAM((nuint)(value.Value));

    public static explicit operator HRGN(WPARAM value) => new HRGN((void*)(value.Value));

    public static explicit operator WPARAM(HWND value) => new WPARAM((nuint)(value.Value));

    public static explicit operator HWND(WPARAM value) => new HWND((void*)(value.Value));

    public static explicit operator WPARAM(LPARAM value) => new WPARAM((nuint)(value.Value));

    public static explicit operator WPARAM(LRESULT value) => new WPARAM((nuint)(value.Value));
}
