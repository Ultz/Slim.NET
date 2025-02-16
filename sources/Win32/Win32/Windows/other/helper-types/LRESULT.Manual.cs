// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public unsafe partial struct LRESULT
{
    public static explicit operator LRESULT(void* value) => new LRESULT((nint)(value));

    public static implicit operator void*(LRESULT value) => (void*)(value.Value);

    public static explicit operator LRESULT(BOOL value) => new LRESULT(value.Value);

    public static explicit operator BOOL(LRESULT value) => new BOOL((int)(value.Value));

    public static explicit operator LRESULT(HANDLE value) => new LRESULT((nint)(value.Value));

    public static explicit operator HANDLE(LRESULT value) => new HANDLE((void*)(value.Value));

    public static explicit operator LRESULT(HBRUSH value) => new LRESULT((nint)(value.Value));

    public static explicit operator HBRUSH(LRESULT value) => new HBRUSH((void*)(value.Value));

    public static explicit operator LRESULT(HCURSOR value) => new LRESULT((nint)(value.Value));

    public static explicit operator HCURSOR(LRESULT value) => new HCURSOR((void*)(value.Value));

    public static explicit operator LRESULT(HDC value) => new LRESULT((nint)(value.Value));

    public static explicit operator HDC(LRESULT value) => new HDC((void*)(value.Value));

    public static explicit operator LRESULT(HDROP value) => new LRESULT((nint)(value.Value));

    public static explicit operator HDROP(LRESULT value) => new HDROP((void*)(value.Value));

    public static explicit operator LRESULT(HFONT value) => new LRESULT((nint)(value.Value));

    public static explicit operator HFONT(LRESULT value) => new HFONT((void*)(value.Value));

    public static explicit operator LRESULT(HGDIOBJ value) => new LRESULT((nint)(value.Value));

    public static explicit operator HGDIOBJ(LRESULT value) => new HGDIOBJ((void*)(value.Value));

    public static explicit operator LRESULT(HGLOBAL value) => new LRESULT((nint)(value.Value));

    public static explicit operator HGLOBAL(LRESULT value) => new HGLOBAL((void*)(value.Value));

    public static explicit operator LRESULT(HICON value) => new LRESULT((nint)(value.Value));

    public static explicit operator HICON(LRESULT value) => new HICON((void*)(value.Value));

    public static explicit operator LRESULT(HINSTANCE value) => new LRESULT((nint)(value.Value));

    public static explicit operator HINSTANCE(LRESULT value) => new HINSTANCE((void*)(value.Value));

    public static explicit operator LRESULT(HLOCAL value) => new LRESULT((nint)(value.Value));

    public static explicit operator HLOCAL(LRESULT value) => new HLOCAL((void*)(value.Value));

    public static explicit operator LRESULT(HMENU value) => new LRESULT((nint)(value.Value));

    public static explicit operator HMENU(LRESULT value) => new HMENU((void*)(value.Value));

    public static explicit operator LRESULT(HMODULE value) => new LRESULT((nint)(value.Value));

    public static explicit operator HMODULE(LRESULT value) => new HMODULE((void*)(value.Value));

    public static explicit operator LRESULT(HPALETTE value) => new LRESULT((nint)(value.Value));

    public static explicit operator HPALETTE(LRESULT value) => new HPALETTE((void*)(value.Value));

    public static explicit operator LRESULT(HPEN value) => new LRESULT((nint)(value.Value));

    public static explicit operator HPEN(LRESULT value) => new HPEN((void*)(value.Value));

    public static explicit operator LRESULT(HRGN value) => new LRESULT((nint)(value.Value));

    public static explicit operator HRGN(LRESULT value) => new HRGN((void*)(value.Value));

    public static explicit operator LRESULT(HWND value) => new LRESULT((nint)(value.Value));

    public static explicit operator HWND(LRESULT value) => new HWND((void*)(value.Value));

    public static explicit operator LRESULT(LPARAM value) => new LRESULT(value.Value);

    public static explicit operator LRESULT(WPARAM value) => new LRESULT((nint)(value.Value));
}
