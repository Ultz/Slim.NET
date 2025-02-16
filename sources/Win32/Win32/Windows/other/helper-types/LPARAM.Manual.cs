// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public unsafe partial struct LPARAM
{
    public static explicit operator LPARAM(void* value) => new LPARAM((nint)(value));

    public static implicit operator void*(LPARAM value) => (void*)(value.Value);

    public static explicit operator LPARAM(BOOL value) => new LPARAM(value.Value);

    public static explicit operator BOOL(LPARAM value) => new BOOL((int)(value.Value));

    public static explicit operator LPARAM(HANDLE value) => new LPARAM((nint)(value.Value));

    public static explicit operator HANDLE(LPARAM value) => new HANDLE((void*)(value.Value));

    public static explicit operator LPARAM(HBRUSH value) => new LPARAM((nint)(value.Value));

    public static explicit operator HBRUSH(LPARAM value) => new HBRUSH((void*)(value.Value));

    public static explicit operator LPARAM(HCURSOR value) => new LPARAM((nint)(value.Value));

    public static explicit operator HCURSOR(LPARAM value) => new HCURSOR((void*)(value.Value));

    public static explicit operator LPARAM(HDC value) => new LPARAM((nint)(value.Value));

    public static explicit operator HDC(LPARAM value) => new HDC((void*)(value.Value));

    public static explicit operator LPARAM(HDROP value) => new LPARAM((nint)(value.Value));

    public static explicit operator HDROP(LPARAM value) => new HDROP((void*)(value.Value));

    public static explicit operator LPARAM(HFONT value) => new LPARAM((nint)(value.Value));

    public static explicit operator HFONT(LPARAM value) => new HFONT((void*)(value.Value));

    public static explicit operator LPARAM(HGDIOBJ value) => new LPARAM((nint)(value.Value));

    public static explicit operator HGDIOBJ(LPARAM value) => new HGDIOBJ((void*)(value.Value));

    public static explicit operator LPARAM(HGLOBAL value) => new LPARAM((nint)(value.Value));

    public static explicit operator HGLOBAL(LPARAM value) => new HGLOBAL((void*)(value.Value));

    public static explicit operator LPARAM(HICON value) => new LPARAM((nint)(value.Value));

    public static explicit operator HICON(LPARAM value) => new HICON((void*)(value.Value));

    public static explicit operator LPARAM(HINSTANCE value) => new LPARAM((nint)(value.Value));

    public static explicit operator HINSTANCE(LPARAM value) => new HINSTANCE((void*)(value.Value));

    public static explicit operator LPARAM(HLOCAL value) => new LPARAM((nint)(value.Value));

    public static explicit operator HLOCAL(LPARAM value) => new HLOCAL((void*)(value.Value));

    public static explicit operator LPARAM(HMENU value) => new LPARAM((nint)(value.Value));

    public static explicit operator HMENU(LPARAM value) => new HMENU((void*)(value.Value));

    public static explicit operator LPARAM(HMODULE value) => new LPARAM((nint)(value.Value));

    public static explicit operator HMODULE(LPARAM value) => new HMODULE((void*)(value.Value));

    public static explicit operator LPARAM(HPALETTE value) => new LPARAM((nint)(value.Value));

    public static explicit operator HPALETTE(LPARAM value) => new HPALETTE((void*)(value.Value));

    public static explicit operator LPARAM(HPEN value) => new LPARAM((nint)(value.Value));

    public static explicit operator HPEN(LPARAM value) => new HPEN((void*)(value.Value));

    public static explicit operator LPARAM(HRGN value) => new LPARAM((nint)(value.Value));

    public static explicit operator HRGN(LPARAM value) => new HRGN((void*)(value.Value));

    public static explicit operator LPARAM(HWND value) => new LPARAM((nint)(value.Value));

    public static explicit operator HWND(LPARAM value) => new HWND((void*)(value.Value));

    public static explicit operator LPARAM(LRESULT value) => new LPARAM(value.Value);

    public static explicit operator LPARAM(WPARAM value) => new LPARAM((nint)(value.Value));
}
