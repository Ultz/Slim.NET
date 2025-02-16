// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/windowsx.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using static Silk.NET.Win32.CB;
using static Silk.NET.Win32.EM;
using static Silk.NET.Win32.GWL;
using static Silk.NET.Win32.GWLP;
using static Silk.NET.Win32.LB;
using static Silk.NET.Win32.MF;
using static Silk.NET.Win32.SB;
using static Silk.NET.Win32.SW;
using static Silk.NET.Win32.VK;
using static Silk.NET.Win32.WM;
using static Silk.NET.Win32.WS;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    /****** Button control message APIs ******************************************/
    public static BOOL Button_Enable(HWND hwndCtl, BOOL fEnable) =>
        EnableWindow((hwndCtl), (fEnable));

    [Transformed]
    /****** Button control message APIs ******************************************/
    public static MaybeBool<BOOL> Button_Enable(HWND hwndCtl, MaybeBool<BOOL> fEnable) =>
        (MaybeBool<BOOL>)(BOOL)Button_Enable(hwndCtl, (BOOL)fEnable);

    public static int Button_GetCheck(HWND hwndCtl) =>
        ((int)(uint)SNDMSG((hwndCtl), BM_GETCHECK, 0u, 0));

    public static int Button_GetState(HWND hwndCtl) =>
        ((int)(uint)SNDMSG((hwndCtl), BM_GETSTATE, 0u, 0));

    public static int Button_GetText(HWND hwndCtl, char* lpch, int cchMax) =>
        GetWindowText((hwndCtl), (lpch), (cchMax));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int Button_GetText(HWND hwndCtl, Ref<char> lpch, int cchMax)
    {
        fixed (char* __dsl_lpch = lpch)
        {
            return (int)Button_GetText(hwndCtl, __dsl_lpch, cchMax);
        }
    }

    public static int Button_GetTextLength(HWND hwndCtl) => GetWindowTextLength(hwndCtl);

    public static void Button_SetCheck(HWND hwndCtl, int check) =>
        SNDMSG((hwndCtl), BM_SETCHECK, (WPARAM)(int)(check), 0);

    public static uint Button_SetState(HWND hwndCtl, int state) =>
        ((uint)(uint)SNDMSG((hwndCtl), BM_SETSTATE, (WPARAM)(int)(state), 0));

    public static void Button_SetStyle(HWND hwndCtl, int style, BOOL fRedraw) =>
        SNDMSG(
            (hwndCtl),
            BM_SETSTYLE,
            (WPARAM)LOWORD(style),
            MAKELPARAM(((ushort)((fRedraw) ? TRUE : FALSE)), 0)
        );

    [Transformed]
    public static void Button_SetStyle(HWND hwndCtl, int style, MaybeBool<BOOL> fRedraw) =>
        Button_SetStyle(hwndCtl, style, (BOOL)fRedraw);

    public static BOOL Button_SetText(HWND hwndCtl, char* lpsz) => SetWindowText((hwndCtl), (lpsz));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<BOOL> Button_SetText(HWND hwndCtl, Ref<char> lpsz)
    {
        fixed (char* __dsl_lpsz = lpsz)
        {
            return (MaybeBool<BOOL>)(BOOL)Button_SetText(hwndCtl, __dsl_lpsz);
        }
    }

    public static BOOL CheckDefDlgRecursion(BOOL* pfRecursion)
    {
        if (*(pfRecursion))
        {
            *(pfRecursion) = FALSE;
            return FALSE;
        }
        return TRUE;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<BOOL> CheckDefDlgRecursion(Ref<BOOL> pfRecursion)
    {
        fixed (BOOL* __dsl_pfRecursion = pfRecursion)
        {
            return (MaybeBool<BOOL>)(BOOL)CheckDefDlgRecursion(__dsl_pfRecursion);
        }
    }

    public static int ComboBox_AddItemData(HWND hwndCtl, LPARAM data) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_ADDSTRING, 0u, (LPARAM)(data)));

    public static int ComboBox_AddString(HWND hwndCtl, char* lpsz) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_ADDSTRING, 0u, (LPARAM)(char*)(lpsz)));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ComboBox_AddString(HWND hwndCtl, Ref<char> lpsz)
    {
        fixed (char* __dsl_lpsz = lpsz)
        {
            return (int)ComboBox_AddString(hwndCtl, __dsl_lpsz);
        }
    }

    public static int ComboBox_DeleteString(HWND hwndCtl, int index) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_DELETESTRING, (WPARAM)(int)(index), 0));

    public static int ComboBox_Dir(HWND hwndCtl, uint attrs, char* lpszFileSpec) =>
        (
            (int)
                (uint)SNDMSG(
                    (hwndCtl),
                    CB_DIR,
                    (WPARAM)(uint)(attrs),
                    (LPARAM)(char*)(lpszFileSpec)
                )
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ComboBox_Dir(HWND hwndCtl, uint attrs, Ref<char> lpszFileSpec)
    {
        fixed (char* __dsl_lpszFileSpec = lpszFileSpec)
        {
            return (int)ComboBox_Dir(hwndCtl, attrs, __dsl_lpszFileSpec);
        }
    }

    /****** ComboBox control message APIs ****************************************/
    public static BOOL ComboBox_Enable(HWND hwndCtl, BOOL fEnable) =>
        EnableWindow((hwndCtl), (fEnable));

    [Transformed]
    /****** ComboBox control message APIs ****************************************/
    public static MaybeBool<BOOL> ComboBox_Enable(HWND hwndCtl, MaybeBool<BOOL> fEnable) =>
        (MaybeBool<BOOL>)(BOOL)ComboBox_Enable(hwndCtl, (BOOL)fEnable);

    public static int ComboBox_FindItemData(HWND hwndCtl, int indexStart, LPARAM data) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_FINDSTRING, (WPARAM)(int)(indexStart), (LPARAM)(data)));

    public static int ComboBox_FindString(HWND hwndCtl, int indexStart, char* lpszFind) =>
        (
            (int)
                (uint)SNDMSG(
                    (hwndCtl),
                    CB_FINDSTRING,
                    (WPARAM)(int)(indexStart),
                    (LPARAM)(char*)(lpszFind)
                )
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ComboBox_FindString(HWND hwndCtl, int indexStart, Ref<char> lpszFind)
    {
        fixed (char* __dsl_lpszFind = lpszFind)
        {
            return (int)ComboBox_FindString(hwndCtl, indexStart, __dsl_lpszFind);
        }
    }

    public static int ComboBox_FindStringExact(HWND hwndCtl, int indexStart, char* lpszFind) =>
        (
            (int)
                (uint)SNDMSG(
                    (hwndCtl),
                    CB_FINDSTRINGEXACT,
                    (WPARAM)(int)(indexStart),
                    (LPARAM)(char*)(lpszFind)
                )
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ComboBox_FindStringExact(HWND hwndCtl, int indexStart, Ref<char> lpszFind)
    {
        fixed (char* __dsl_lpszFind = lpszFind)
        {
            return (int)ComboBox_FindStringExact(hwndCtl, indexStart, __dsl_lpszFind);
        }
    }

    public static int ComboBox_GetCount(HWND hwndCtl) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_GETCOUNT, 0u, 0));

    public static int ComboBox_GetCurSel(HWND hwndCtl) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_GETCURSEL, 0u, 0));

    public static void ComboBox_GetDroppedControlRect(HWND hwndCtl, RECT* lprc) =>
        SNDMSG((hwndCtl), CB_GETDROPPEDCONTROLRECT, 0u, (LPARAM)(RECT*)(lprc));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void ComboBox_GetDroppedControlRect(HWND hwndCtl, Ref<RECT> lprc)
    {
        fixed (RECT* __dsl_lprc = lprc)
        {
            ComboBox_GetDroppedControlRect(hwndCtl, __dsl_lprc);
        }
    }

    [Transformed]
    public static MaybeBool<BOOL> ComboBox_GetDroppedState(HWND hwndCtl) =>
        (MaybeBool<BOOL>)(BOOL)ComboBox_GetDroppedStateRaw(hwndCtl);

    public static BOOL ComboBox_GetDroppedStateRaw(HWND hwndCtl) =>
        ((BOOL)(uint)SNDMSG((hwndCtl), CB_GETDROPPEDSTATE, 0u, 0));

    public static uint ComboBox_GetEditSel(HWND hwndCtl) =>
        ((uint)SNDMSG((hwndCtl), CB_GETEDITSEL, 0u, 0));

    public static uint ComboBox_GetExtendedUI(HWND hwndCtl) =>
        ((uint)(uint)SNDMSG((hwndCtl), CB_GETEXTENDEDUI, 0u, 0));

    public static LRESULT ComboBox_GetItemData(HWND hwndCtl, int index) =>
        ((LRESULT)(nuint)SNDMSG((hwndCtl), CB_GETITEMDATA, (WPARAM)(int)(index), 0));

    public static int ComboBox_GetItemHeight(HWND hwndCtl) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_GETITEMHEIGHT, 0u, 0));

    public static int ComboBox_GetLBText(HWND hwndCtl, int index, char* lpszBuffer) =>
        (
            (int)
                (uint)SNDMSG(
                    (hwndCtl),
                    CB_GETLBTEXT,
                    (WPARAM)(int)(index),
                    (LPARAM)(char*)(lpszBuffer)
                )
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ComboBox_GetLBText(HWND hwndCtl, int index, Ref<char> lpszBuffer)
    {
        fixed (char* __dsl_lpszBuffer = lpszBuffer)
        {
            return (int)ComboBox_GetLBText(hwndCtl, index, __dsl_lpszBuffer);
        }
    }

    public static int ComboBox_GetLBTextLen(HWND hwndCtl, int index) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_GETLBTEXTLEN, (WPARAM)(int)(index), 0));

    public static int ComboBox_GetText(HWND hwndCtl, char* lpch, int cchMax) =>
        GetWindowText((hwndCtl), (lpch), (cchMax));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ComboBox_GetText(HWND hwndCtl, Ref<char> lpch, int cchMax)
    {
        fixed (char* __dsl_lpch = lpch)
        {
            return (int)ComboBox_GetText(hwndCtl, __dsl_lpch, cchMax);
        }
    }

    public static int ComboBox_GetTextLength(HWND hwndCtl) => GetWindowTextLength(hwndCtl);

    public static int ComboBox_InsertItemData(HWND hwndCtl, int index, LPARAM data) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_INSERTSTRING, (WPARAM)(int)(index), (LPARAM)(data)));

    public static int ComboBox_InsertString(HWND hwndCtl, int index, char* lpsz) =>
        (
            (int)
                (uint)SNDMSG(
                    (hwndCtl),
                    CB_INSERTSTRING,
                    (WPARAM)(int)(index),
                    (LPARAM)(char*)(lpsz)
                )
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ComboBox_InsertString(HWND hwndCtl, int index, Ref<char> lpsz)
    {
        fixed (char* __dsl_lpsz = lpsz)
        {
            return (int)ComboBox_InsertString(hwndCtl, index, __dsl_lpsz);
        }
    }

    public static int ComboBox_LimitText(HWND hwndCtl, int cchLimit) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_LIMITTEXT, (WPARAM)(int)(cchLimit), 0));

    public static int ComboBox_ResetContent(HWND hwndCtl) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_RESETCONTENT, 0u, 0));

    public static int ComboBox_SelectItemData(HWND hwndCtl, int indexStart, LPARAM data) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_SELECTSTRING, (WPARAM)(int)(indexStart), (LPARAM)(data)));

    public static int ComboBox_SelectString(HWND hwndCtl, int indexStart, char* lpszSelect) =>
        (
            (int)
                (uint)SNDMSG(
                    (hwndCtl),
                    CB_SELECTSTRING,
                    (WPARAM)(int)(indexStart),
                    (LPARAM)(char*)(lpszSelect)
                )
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ComboBox_SelectString(HWND hwndCtl, int indexStart, Ref<char> lpszSelect)
    {
        fixed (char* __dsl_lpszSelect = lpszSelect)
        {
            return (int)ComboBox_SelectString(hwndCtl, indexStart, __dsl_lpszSelect);
        }
    }

    public static int ComboBox_SetCurSel(HWND hwndCtl, int index) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_SETCURSEL, (WPARAM)(int)(index), 0));

    public static int ComboBox_SetEditSel(HWND hwndCtl, ushort ichStart, ushort ichEnd) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_SETEDITSEL, 0u, MAKELPARAM((ichStart), (ichEnd))));

    public static int ComboBox_SetExtendedUI(HWND hwndCtl, uint flags) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_SETEXTENDEDUI, (WPARAM)(uint)(flags), 0));

    public static int ComboBox_SetItemData(HWND hwndCtl, int index, LPARAM data) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_SETITEMDATA, (WPARAM)(int)(index), (LPARAM)(data)));

    public static int ComboBox_SetItemHeight(HWND hwndCtl, int index, int cyItem) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_SETITEMHEIGHT, (WPARAM)(int)(index), (LPARAM)(int)cyItem));

    public static BOOL ComboBox_SetText(HWND hwndCtl, char* lpsz) =>
        SetWindowText((hwndCtl), (lpsz));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<BOOL> ComboBox_SetText(HWND hwndCtl, Ref<char> lpsz)
    {
        fixed (char* __dsl_lpsz = lpsz)
        {
            return (MaybeBool<BOOL>)(BOOL)ComboBox_SetText(hwndCtl, __dsl_lpsz);
        }
    }

    public static BOOL ComboBox_ShowDropdown(HWND hwndCtl, BOOL fShow) =>
        ((BOOL)(uint)SNDMSG((hwndCtl), CB_SHOWDROPDOWN, (WPARAM)(BOOL)(fShow), 0));

    [Transformed]
    public static MaybeBool<BOOL> ComboBox_ShowDropdown(HWND hwndCtl, MaybeBool<BOOL> fShow) =>
        (MaybeBool<BOOL>)(BOOL)ComboBox_ShowDropdown(hwndCtl, (BOOL)fShow);

    public static int CopyRgn(HRGN hrgnDst, HRGN hrgnSrc) =>
        CombineRgn(hrgnDst, hrgnSrc, HRGN.NULL, RGN_COPY);

    public static LRESULT DefDlgProcEx(
        HWND hwnd,
        uint msg,
        WPARAM wParam,
        LPARAM lParam,
        BOOL* pfRecursion
    )
    {
        *(pfRecursion) = TRUE;
        return DefDlgProc(hwnd, msg, wParam, lParam);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static LRESULT DefDlgProcEx(
        HWND hwnd,
        uint msg,
        WPARAM wParam,
        LPARAM lParam,
        Ref<BOOL> pfRecursion
    )
    {
        fixed (BOOL* __dsl_pfRecursion = pfRecursion)
        {
            return (LRESULT)DefDlgProcEx(hwnd, msg, wParam, lParam, __dsl_pfRecursion);
        }
    }

    [Transformed]
    public static MaybeBool<BOOL> DeleteBitmap(HBITMAP hbm) =>
        (MaybeBool<BOOL>)(BOOL)DeleteBitmapRaw(hbm);

    public static BOOL DeleteBitmapRaw(HBITMAP hbm) => DeleteObjectRaw((HGDIOBJ)(HBITMAP)(hbm));

    [Transformed]
    public static MaybeBool<BOOL> DeleteBrush(HBRUSH hbr) =>
        (MaybeBool<BOOL>)(BOOL)DeleteBrushRaw(hbr);

    public static BOOL DeleteBrushRaw(HBRUSH hbr) => DeleteObjectRaw((HGDIOBJ)(HBRUSH)(hbr));

    [Transformed]
    public static MaybeBool<BOOL> DeleteFont(HFONT hfont) =>
        (MaybeBool<BOOL>)(BOOL)DeleteFontRaw(hfont);

    public static BOOL DeleteFontRaw(HFONT hfont) => DeleteObjectRaw((HGDIOBJ)(HFONT)(hfont));

    [Transformed]
    public static MaybeBool<BOOL> DeletePalette(HPALETTE hpal) =>
        (MaybeBool<BOOL>)(BOOL)DeletePaletteRaw(hpal);

    public static BOOL DeletePaletteRaw(HPALETTE hpal) =>
        DeleteObjectRaw((HGDIOBJ)(HPALETTE)(hpal));

    [Transformed]
    /****** GDI Macro APIs *******************************************************/
    public static MaybeBool<BOOL> DeletePen(HPEN hpen) => (MaybeBool<BOOL>)(BOOL)DeletePenRaw(hpen);

    /****** GDI Macro APIs *******************************************************/
    public static BOOL DeletePenRaw(HPEN hpen) => DeleteObjectRaw((HGDIOBJ)(HPEN)(hpen));

    [Transformed]
    public static MaybeBool<BOOL> DeleteRgn(HRGN hrgn) => (MaybeBool<BOOL>)(BOOL)DeleteRgnRaw(hrgn);

    public static BOOL DeleteRgnRaw(HRGN hrgn) => DeleteObjectRaw((HGDIOBJ)(HRGN)(hrgn));

    [Transformed]
    public static MaybeBool<BOOL> Edit_CanUndo(HWND hwndCtl) =>
        (MaybeBool<BOOL>)(BOOL)Edit_CanUndoRaw(hwndCtl);

    public static BOOL Edit_CanUndoRaw(HWND hwndCtl) =>
        ((BOOL)(uint)SNDMSG((hwndCtl), EM_CANUNDO, 0u, 0));

    public static void Edit_EmptyUndoBuffer(HWND hwndCtl) =>
        SNDMSG((hwndCtl), EM_EMPTYUNDOBUFFER, 0u, 0);

    /****** Edit control message APIs ********************************************/
    public static BOOL Edit_Enable(HWND hwndCtl, BOOL fEnable) =>
        EnableWindow((hwndCtl), (fEnable));

    [Transformed]
    /****** Edit control message APIs ********************************************/
    public static MaybeBool<BOOL> Edit_Enable(HWND hwndCtl, MaybeBool<BOOL> fEnable) =>
        (MaybeBool<BOOL>)(BOOL)Edit_Enable(hwndCtl, (BOOL)fEnable);

    public static BOOL Edit_FmtLines(HWND hwndCtl, BOOL fAddEOL) =>
        ((BOOL)(uint)SNDMSG((hwndCtl), EM_FMTLINES, (WPARAM)(BOOL)(fAddEOL), 0));

    [Transformed]
    public static MaybeBool<BOOL> Edit_FmtLines(HWND hwndCtl, MaybeBool<BOOL> fAddEOL) =>
        (MaybeBool<BOOL>)(BOOL)Edit_FmtLines(hwndCtl, (BOOL)fAddEOL);

    public static int Edit_GetFirstVisibleLine(HWND hwndCtl) =>
        ((int)(uint)SNDMSG((hwndCtl), EM_GETFIRSTVISIBLELINE, 0u, 0));

    public static HLOCAL Edit_GetHandle(HWND hwndCtl) =>
        ((HLOCAL)(nuint)SNDMSG((hwndCtl), EM_GETHANDLE, 0u, 0));

    public static int Edit_GetLine(HWND hwndCtl, int line, char* lpch, int cchMax)
    {
        *((int*)(lpch)) = (cchMax);
        return (
            (int)(uint)SNDMSG((hwndCtl), EM_GETLINE, (WPARAM)(int)(line), (LPARAM)(char*)(lpch))
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int Edit_GetLine(HWND hwndCtl, int line, Ref<char> lpch, int cchMax)
    {
        fixed (char* __dsl_lpch = lpch)
        {
            return (int)Edit_GetLine(hwndCtl, line, __dsl_lpch, cchMax);
        }
    }

    public static int Edit_GetLineCount(HWND hwndCtl) =>
        ((int)(uint)SNDMSG((hwndCtl), EM_GETLINECOUNT, 0u, 0));

    [Transformed]
    public static MaybeBool<BOOL> Edit_GetModify(HWND hwndCtl) =>
        (MaybeBool<BOOL>)(BOOL)Edit_GetModifyRaw(hwndCtl);

    public static BOOL Edit_GetModifyRaw(HWND hwndCtl) =>
        ((BOOL)(uint)SNDMSG((hwndCtl), EM_GETMODIFY, 0u, 0));

    public static ushort Edit_GetPasswordChar(HWND hwndCtl) =>
        ((ushort)(uint)SNDMSG((hwndCtl), EM_GETPASSWORDCHAR, 0u, 0));

    public static void Edit_GetRect(HWND hwndCtl, RECT* lprc) =>
        SNDMSG((hwndCtl), EM_GETRECT, 0u, (LPARAM)(RECT*)(lprc));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Edit_GetRect(HWND hwndCtl, Ref<RECT> lprc)
    {
        fixed (RECT* __dsl_lprc = lprc)
        {
            Edit_GetRect(hwndCtl, __dsl_lprc);
        }
    }

    public static uint Edit_GetSel(HWND hwndCtl) => ((uint)SNDMSG((hwndCtl), EM_GETSEL, 0u, 0));

    public static int Edit_GetText(HWND hwndCtl, char* lpch, int cchMax) =>
        GetWindowText((hwndCtl), (lpch), (cchMax));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int Edit_GetText(HWND hwndCtl, Ref<char> lpch, int cchMax)
    {
        fixed (char* __dsl_lpch = lpch)
        {
            return (int)Edit_GetText(hwndCtl, __dsl_lpch, cchMax);
        }
    }

    public static int Edit_GetTextLength(HWND hwndCtl) => GetWindowTextLength(hwndCtl);

    public static delegate* unmanaged<char*, int, int, int, int> Edit_GetWordBreakProc(
        HWND hwndCtl
    ) =>
        (
            (delegate* unmanaged<char*, int, int, int, int>)SNDMSG(
                (hwndCtl),
                EM_GETWORDBREAKPROC,
                0u,
                0
            )
        );

    public static void Edit_LimitText(HWND hwndCtl, int cchMax) =>
        SNDMSG((hwndCtl), EM_LIMITTEXT, (WPARAM)(cchMax), 0);

    public static int Edit_LineFromChar(HWND hwndCtl, int ich) =>
        ((int)(uint)SNDMSG((hwndCtl), EM_LINEFROMCHAR, (WPARAM)(int)(ich), 0));

    public static int Edit_LineIndex(HWND hwndCtl, int line) =>
        ((int)(uint)SNDMSG((hwndCtl), EM_LINEINDEX, (WPARAM)(int)(line), 0));

    public static int Edit_LineLength(HWND hwndCtl, int line) =>
        ((int)(uint)SNDMSG((hwndCtl), EM_LINELENGTH, (WPARAM)(int)(line), 0));

    public static void Edit_ReplaceSel(HWND hwndCtl, char* lpszReplace) =>
        SNDMSG((hwndCtl), EM_REPLACESEL, 0u, (LPARAM)(char*)(lpszReplace));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Edit_ReplaceSel(HWND hwndCtl, Ref<char> lpszReplace)
    {
        fixed (char* __dsl_lpszReplace = lpszReplace)
        {
            Edit_ReplaceSel(hwndCtl, __dsl_lpszReplace);
        }
    }

    public static void Edit_Scroll(HWND hwndCtl, WPARAM dv, LPARAM dh) =>
        SNDMSG((hwndCtl), EM_LINESCROLL, (WPARAM)(dh), (LPARAM)(dv));

    [Transformed]
    public static MaybeBool<BOOL> Edit_ScrollCaret(HWND hwndCtl) =>
        (MaybeBool<BOOL>)(BOOL)Edit_ScrollCaretRaw(hwndCtl);

    public static BOOL Edit_ScrollCaretRaw(HWND hwndCtl) =>
        ((BOOL)(uint)SNDMSG((hwndCtl), EM_SCROLLCARET, 0u, 0));

    public static void Edit_SetHandle(HWND hwndCtl, HLOCAL h) =>
        SNDMSG((hwndCtl), EM_SETHANDLE, (WPARAM)(nuint)(HLOCAL)(h), 0);

    public static void Edit_SetModify(HWND hwndCtl, uint fModified) =>
        SNDMSG((hwndCtl), EM_SETMODIFY, (WPARAM)(uint)(fModified), 0);

    public static void Edit_SetPasswordChar(HWND hwndCtl, uint ch) =>
        SNDMSG((hwndCtl), EM_SETPASSWORDCHAR, (WPARAM)(uint)(ch), 0);

    public static BOOL Edit_SetReadOnly(HWND hwndCtl, BOOL fReadOnly) =>
        ((BOOL)(uint)SNDMSG((hwndCtl), EM_SETREADONLY, (WPARAM)(BOOL)(fReadOnly), 0));

    [Transformed]
    public static MaybeBool<BOOL> Edit_SetReadOnly(HWND hwndCtl, MaybeBool<BOOL> fReadOnly) =>
        (MaybeBool<BOOL>)(BOOL)Edit_SetReadOnly(hwndCtl, (BOOL)fReadOnly);

    public static void Edit_SetRect(HWND hwndCtl, RECT* lprc) =>
        SNDMSG((hwndCtl), EM_SETRECT, 0u, (LPARAM)(RECT*)(lprc));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Edit_SetRect(HWND hwndCtl, Ref<RECT> lprc)
    {
        fixed (RECT* __dsl_lprc = lprc)
        {
            Edit_SetRect(hwndCtl, __dsl_lprc);
        }
    }

    public static void Edit_SetRectNoPaint(HWND hwndCtl, RECT* lprc) =>
        SNDMSG((hwndCtl), EM_SETRECTNP, 0u, (LPARAM)(RECT*)(lprc));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Edit_SetRectNoPaint(HWND hwndCtl, Ref<RECT> lprc)
    {
        fixed (RECT* __dsl_lprc = lprc)
        {
            Edit_SetRectNoPaint(hwndCtl, __dsl_lprc);
        }
    }

    public static void Edit_SetSel(HWND hwndCtl, WPARAM ichStart, LPARAM ichEnd) =>
        SNDMSG((hwndCtl), EM_SETSEL, (ichStart), (ichEnd));

    public static void Edit_SetTabStops(HWND hwndCtl, int cTabs, int* lpTabs) =>
        SNDMSG((hwndCtl), EM_SETTABSTOPS, (WPARAM)(int)(cTabs), (LPARAM)(int*)(lpTabs));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Edit_SetTabStops(HWND hwndCtl, int cTabs, Ref<int> lpTabs)
    {
        fixed (int* __dsl_lpTabs = lpTabs)
        {
            Edit_SetTabStops(hwndCtl, cTabs, __dsl_lpTabs);
        }
    }

    public static BOOL Edit_SetText(HWND hwndCtl, char* lpsz) => SetWindowText((hwndCtl), (lpsz));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<BOOL> Edit_SetText(HWND hwndCtl, Ref<char> lpsz)
    {
        fixed (char* __dsl_lpsz = lpsz)
        {
            return (MaybeBool<BOOL>)(BOOL)Edit_SetText(hwndCtl, __dsl_lpsz);
        }
    }

    public static void Edit_SetWordBreakProc(
        HWND hwndCtl,
        delegate* unmanaged<char*, int, int, int, int> lpfnWordBreak
    ) =>
        SNDMSG(
            (hwndCtl),
            EM_SETWORDBREAKPROC,
            0u,
            (LPARAM)(delegate* unmanaged<char*, int, int, int, int>)(lpfnWordBreak)
        );

    [Transformed]
    public static MaybeBool<BOOL> Edit_Undo(HWND hwndCtl) =>
        (MaybeBool<BOOL>)(BOOL)Edit_UndoRaw(hwndCtl);

    public static BOOL Edit_UndoRaw(HWND hwndCtl) =>
        ((BOOL)(uint)SNDMSG((hwndCtl), EM_UNDO, 0u, 0));

    public static void FORWARD_WM_ACTIVATE(
        HWND hwnd,
        uint state,
        HWND hwndActDeact,
        BOOL fMinimized,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        fn(
            (hwnd),
            WM_ACTIVATE,
            MAKEWPARAM((state), (nuint)(fMinimized)),
            (LPARAM)(HWND)(hwndActDeact)
        );

    [Transformed]
    public static void FORWARD_WM_ACTIVATE(
        HWND hwnd,
        uint state,
        HWND hwndActDeact,
        MaybeBool<BOOL> fMinimized,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => FORWARD_WM_ACTIVATE(hwnd, state, hwndActDeact, (BOOL)fMinimized, fn);

    public static void FORWARD_WM_ACTIVATEAPP(
        HWND hwnd,
        BOOL fActivate,
        uint dwThreadId,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_ACTIVATEAPP, (WPARAM)(BOOL)(fActivate), (LPARAM)(dwThreadId));

    [Transformed]
    public static void FORWARD_WM_ACTIVATEAPP(
        HWND hwnd,
        MaybeBool<BOOL> fActivate,
        uint dwThreadId,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => FORWARD_WM_ACTIVATEAPP(hwnd, (BOOL)fActivate, dwThreadId, fn);

    public static void FORWARD_WM_ASKCBFORMATNAME(
        HWND hwnd,
        int cchMax,
        char* rgchName,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_ASKCBFORMATNAME, (WPARAM)(int)(cchMax), (LPARAM)(rgchName));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void FORWARD_WM_ASKCBFORMATNAME(
        HWND hwnd,
        int cchMax,
        Ref<char> rgchName,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    )
    {
        fixed (char* __dsl_rgchName = rgchName)
        {
            FORWARD_WM_ASKCBFORMATNAME(hwnd, cchMax, __dsl_rgchName, fn);
        }
    }

    public static void FORWARD_WM_CANCELMODE(
        HWND hwnd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_CANCELMODE, 0u, 0);

    public static void FORWARD_WM_CHANGECBCHAIN(
        HWND hwnd,
        HWND hwndRemove,
        HWND hwndNext,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_CHANGECBCHAIN, (WPARAM)(HWND)(hwndRemove), (LPARAM)(HWND)(hwndNext));

    public static void FORWARD_WM_CHAR(
        HWND hwnd,
        ushort ch,
        int cRepeat,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_CHAR, (WPARAM)(ushort)(ch), MAKELPARAM((cRepeat), 0));

    public static int FORWARD_WM_CHARTOITEM(
        HWND hwnd,
        uint ch,
        HWND hwndListBox,
        int iCaret,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        (int)
            (uint)fn(
                (hwnd),
                WM_CHARTOITEM,
                MAKEWPARAM((uint)(ch), (uint)(iCaret)),
                (LPARAM)(hwndListBox)
            );

    public static void FORWARD_WM_CHILDACTIVATE(
        HWND hwnd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_CHILDACTIVATE, 0u, 0);

    public static void FORWARD_WM_CLEAR(
        HWND hwnd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_CLEAR, 0u, 0);

    public static void FORWARD_WM_CLOSE(
        HWND hwnd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_CLOSE, 0u, 0);

    public static void FORWARD_WM_COMMAND(
        HWND hwnd,
        int id,
        HWND hwndCtl,
        uint codeNotify,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        fn((hwnd), WM_COMMAND, MAKEWPARAM((uint)(id), (uint)(codeNotify)), (LPARAM)(HWND)(hwndCtl));

    public static void FORWARD_WM_COMMNOTIFY(
        HWND hwnd,
        int cid,
        uint flags,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_COMMNOTIFY, (WPARAM)(cid), MAKELPARAM((flags), 0));

    public static void FORWARD_WM_COMPACTING(
        HWND hwnd,
        uint compactRatio,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_COMPACTING, (WPARAM)(uint)(compactRatio), 0);

    public static int FORWARD_WM_COMPAREITEM(
        HWND hwnd,
        COMPAREITEMSTRUCT* lpCompareItem,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        (int)
            (uint)fn(
                (hwnd),
                WM_COMPAREITEM,
                (WPARAM)(((COMPAREITEMSTRUCT*)(lpCompareItem))->CtlID),
                (LPARAM)(COMPAREITEMSTRUCT*)(lpCompareItem)
            );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int FORWARD_WM_COMPAREITEM(
        HWND hwnd,
        Ref<COMPAREITEMSTRUCT> lpCompareItem,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    )
    {
        fixed (COMPAREITEMSTRUCT* __dsl_lpCompareItem = lpCompareItem)
        {
            return (int)FORWARD_WM_COMPAREITEM(hwnd, __dsl_lpCompareItem, fn);
        }
    }

    public static void FORWARD_WM_CONTEXTMENU(
        HWND hwnd,
        HWND hwndContext,
        uint xPos,
        uint yPos,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        fn(
            (hwnd),
            WM_CONTEXTMENU,
            (WPARAM)(HWND)(hwndContext),
            MAKELPARAM((uint)(xPos), (uint)(yPos))
        );

    public static void FORWARD_WM_COPY(
        HWND hwnd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_COPY, 0u, 0);

    public static BOOL FORWARD_WM_COPYDATA(
        HWND hwnd,
        HWND hwndFrom,
        COPYDATASTRUCT* pcds,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (BOOL)(uint)(uint)fn((hwnd), WM_COPYDATA, (WPARAM)(hwndFrom), (LPARAM)(pcds));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<BOOL> FORWARD_WM_COPYDATA(
        HWND hwnd,
        HWND hwndFrom,
        Ref<COPYDATASTRUCT> pcds,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    )
    {
        fixed (COPYDATASTRUCT* __dsl_pcds = pcds)
        {
            return (MaybeBool<BOOL>)(BOOL)FORWARD_WM_COPYDATA(hwnd, hwndFrom, __dsl_pcds, fn);
        }
    }

    public static BOOL FORWARD_WM_CREATE(
        HWND hwnd,
        CREATESTRUCTW* lpCreateStruct,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (BOOL)(uint)fn((hwnd), WM_CREATE, 0u, (LPARAM)(CREATESTRUCTW*)(lpCreateStruct));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<BOOL> FORWARD_WM_CREATE(
        HWND hwnd,
        Ref<CREATESTRUCTW> lpCreateStruct,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    )
    {
        fixed (CREATESTRUCTW* __dsl_lpCreateStruct = lpCreateStruct)
        {
            return (MaybeBool<BOOL>)(BOOL)FORWARD_WM_CREATE(hwnd, __dsl_lpCreateStruct, fn);
        }
    }

    public static HBRUSH FORWARD_WM_CTLCOLORBTN(
        HWND hwnd,
        HDC hdc,
        HWND hwndChild,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (HBRUSH)(nuint)fn((hwnd), WM_CTLCOLORBTN, (WPARAM)(HDC)(hdc), (LPARAM)(HWND)(hwndChild));

    public static HBRUSH FORWARD_WM_CTLCOLORDLG(
        HWND hwnd,
        HDC hdc,
        HWND hwndChild,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (HBRUSH)(nuint)fn((hwnd), WM_CTLCOLORDLG, (WPARAM)(HDC)(hdc), (LPARAM)(HWND)(hwndChild));

    public static HBRUSH FORWARD_WM_CTLCOLOREDIT(
        HWND hwnd,
        HDC hdc,
        HWND hwndChild,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (HBRUSH)(nuint)fn((hwnd), WM_CTLCOLOREDIT, (WPARAM)(HDC)(hdc), (LPARAM)(HWND)(hwndChild));

    public static HBRUSH FORWARD_WM_CTLCOLORLISTBOX(
        HWND hwnd,
        HDC hdc,
        HWND hwndChild,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        (HBRUSH)
            (nuint)fn((hwnd), WM_CTLCOLORLISTBOX, (WPARAM)(HDC)(hdc), (LPARAM)(HWND)(hwndChild));

    public static HBRUSH FORWARD_WM_CTLCOLORMSGBOX(
        HWND hwnd,
        HDC hdc,
        HWND hwndChild,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        (HBRUSH)(nuint)fn((hwnd), WM_CTLCOLORMSGBOX, (WPARAM)(HDC)(hdc), (LPARAM)(HWND)(hwndChild));

    public static HBRUSH FORWARD_WM_CTLCOLORSCROLLBAR(
        HWND hwnd,
        HDC hdc,
        HWND hwndChild,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        (HBRUSH)
            (nuint)fn((hwnd), WM_CTLCOLORSCROLLBAR, (WPARAM)(HDC)(hdc), (LPARAM)(HWND)(hwndChild));

    public static HBRUSH FORWARD_WM_CTLCOLORSTATIC(
        HWND hwnd,
        HDC hdc,
        HWND hwndChild,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        (HBRUSH)(nuint)fn((hwnd), WM_CTLCOLORSTATIC, (WPARAM)(HDC)(hdc), (LPARAM)(HWND)(hwndChild));

    public static void FORWARD_WM_CUT(
        HWND hwnd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_CUT, 0u, 0);

    public static void FORWARD_WM_DEADCHAR(
        HWND hwnd,
        ushort ch,
        int cRepeat,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_DEADCHAR, (WPARAM)(ushort)(ch), MAKELPARAM((cRepeat), 0));

    public static void FORWARD_WM_DELETEITEM(
        HWND hwnd,
        DELETEITEMSTRUCT* lpDeleteItem,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        fn(
            (hwnd),
            WM_DELETEITEM,
            (WPARAM)(((DELETEITEMSTRUCT*)(lpDeleteItem))->CtlID),
            (LPARAM)(DELETEITEMSTRUCT*)(lpDeleteItem)
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void FORWARD_WM_DELETEITEM(
        HWND hwnd,
        Ref<DELETEITEMSTRUCT> lpDeleteItem,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    )
    {
        fixed (DELETEITEMSTRUCT* __dsl_lpDeleteItem = lpDeleteItem)
        {
            FORWARD_WM_DELETEITEM(hwnd, __dsl_lpDeleteItem, fn);
        }
    }

    public static void FORWARD_WM_DESTROY(
        HWND hwnd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_DESTROY, 0u, 0);

    public static void FORWARD_WM_DESTROYCLIPBOARD(
        HWND hwnd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_DESTROYCLIPBOARD, 0u, 0);

    [Transformed]
    public static MaybeBool<BOOL> FORWARD_WM_DEVICECHANGE(
        HWND hwnd,
        uint uEvent,
        uint dwEventData,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (MaybeBool<BOOL>)(BOOL)FORWARD_WM_DEVICECHANGERaw(hwnd, uEvent, dwEventData, fn);

    public static BOOL FORWARD_WM_DEVICECHANGERaw(
        HWND hwnd,
        uint uEvent,
        uint dwEventData,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        (BOOL)
            (uint)fn((hwnd), WM_DEVICECHANGE, (WPARAM)(uint)(uEvent), (LPARAM)(uint)(dwEventData));

    public static void FORWARD_WM_DEVMODECHANGE(
        HWND hwnd,
        char* lpszDeviceName,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_DEVMODECHANGE, 0u, (LPARAM)(char*)(lpszDeviceName));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void FORWARD_WM_DEVMODECHANGE(
        HWND hwnd,
        Ref<char> lpszDeviceName,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    )
    {
        fixed (char* __dsl_lpszDeviceName = lpszDeviceName)
        {
            FORWARD_WM_DEVMODECHANGE(hwnd, __dsl_lpszDeviceName, fn);
        }
    }

    public static void FORWARD_WM_DISPLAYCHANGE(
        HWND hwnd,
        uint bitsPerPixel,
        uint cxScreen,
        uint cyScreen,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        fn(
            (hwnd),
            WM_DISPLAYCHANGE,
            (WPARAM)(uint)(bitsPerPixel),
            (LPARAM)MAKELPARAM((uint)(cxScreen), (uint)(cyScreen))
        );

    public static void FORWARD_WM_DRAWCLIPBOARD(
        HWND hwnd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_DRAWCLIPBOARD, 0u, 0);

    public static void FORWARD_WM_DRAWITEM(
        HWND hwnd,
        DRAWITEMSTRUCT* lpDrawItem,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        fn(
            (hwnd),
            WM_DRAWITEM,
            (WPARAM)(((DRAWITEMSTRUCT*)lpDrawItem)->CtlID),
            (LPARAM)(DRAWITEMSTRUCT*)(lpDrawItem)
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void FORWARD_WM_DRAWITEM(
        HWND hwnd,
        Ref<DRAWITEMSTRUCT> lpDrawItem,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    )
    {
        fixed (DRAWITEMSTRUCT* __dsl_lpDrawItem = lpDrawItem)
        {
            FORWARD_WM_DRAWITEM(hwnd, __dsl_lpDrawItem, fn);
        }
    }

    public static void FORWARD_WM_DROPFILES(
        HWND hwnd,
        HDROP hdrop,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_DROPFILES, (WPARAM)(HDROP)(hdrop), 0);

    public static void FORWARD_WM_ENABLE(
        HWND hwnd,
        BOOL fEnable,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_ENABLE, (WPARAM)(BOOL)(fEnable), 0);

    [Transformed]
    public static void FORWARD_WM_ENABLE(
        HWND hwnd,
        MaybeBool<BOOL> fEnable,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => FORWARD_WM_ENABLE(hwnd, (BOOL)fEnable, fn);

    public static void FORWARD_WM_ENDSESSION(
        HWND hwnd,
        BOOL fEnding,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_ENDSESSION, (WPARAM)(BOOL)(fEnding), 0);

    [Transformed]
    public static void FORWARD_WM_ENDSESSION(
        HWND hwnd,
        MaybeBool<BOOL> fEnding,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => FORWARD_WM_ENDSESSION(hwnd, (BOOL)fEnding, fn);

    public static void FORWARD_WM_ENTERIDLE(
        HWND hwnd,
        uint source,
        HWND hwndSource,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_ENTERIDLE, (WPARAM)(uint)(source), (LPARAM)(HWND)(hwndSource));

    [Transformed]
    public static MaybeBool<BOOL> FORWARD_WM_ERASEBKGND(
        HWND hwnd,
        HDC hdc,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (MaybeBool<BOOL>)(BOOL)FORWARD_WM_ERASEBKGNDRaw(hwnd, hdc, fn);

    public static BOOL FORWARD_WM_ERASEBKGNDRaw(
        HWND hwnd,
        HDC hdc,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (BOOL)(uint)fn((hwnd), WM_ERASEBKGND, (WPARAM)(HDC)(hdc), 0);

    public static void FORWARD_WM_FONTCHANGE(
        HWND hwnd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_FONTCHANGE, 0u, 0);

    public static uint FORWARD_WM_GETDLGCODE(
        HWND hwnd,
        MSG* lpmsg,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        (uint)
            (uint)fn(
                (hwnd),
                WM_GETDLGCODE,
                ((lpmsg != null) ? lpmsg->wParam : 0u),
                (LPARAM)(MSG*)(lpmsg)
            );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint FORWARD_WM_GETDLGCODE(
        HWND hwnd,
        Ref<MSG> lpmsg,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    )
    {
        fixed (MSG* __dsl_lpmsg = lpmsg)
        {
            return (uint)FORWARD_WM_GETDLGCODE(hwnd, __dsl_lpmsg, fn);
        }
    }

    public static HFONT FORWARD_WM_GETFONT(
        HWND hwnd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (HFONT)(nuint)fn((hwnd), WM_GETFONT, 0u, 0);

    public static void FORWARD_WM_GETMINMAXINFO(
        HWND hwnd,
        MINMAXINFO* lpMinMaxInfo,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_GETMINMAXINFO, 0u, (LPARAM)(MINMAXINFO*)(lpMinMaxInfo));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void FORWARD_WM_GETMINMAXINFO(
        HWND hwnd,
        Ref<MINMAXINFO> lpMinMaxInfo,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    )
    {
        fixed (MINMAXINFO* __dsl_lpMinMaxInfo = lpMinMaxInfo)
        {
            FORWARD_WM_GETMINMAXINFO(hwnd, __dsl_lpMinMaxInfo, fn);
        }
    }

    public static int FORWARD_WM_GETTEXT(
        HWND hwnd,
        int cchTextMax,
        char* lpszText,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (int)(uint)fn((hwnd), WM_GETTEXT, (WPARAM)(int)(cchTextMax), (LPARAM)(char*)(lpszText));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int FORWARD_WM_GETTEXT(
        HWND hwnd,
        int cchTextMax,
        Ref<char> lpszText,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    )
    {
        fixed (char* __dsl_lpszText = lpszText)
        {
            return (int)FORWARD_WM_GETTEXT(hwnd, cchTextMax, __dsl_lpszText, fn);
        }
    }

    public static int FORWARD_WM_GETTEXTLENGTH(
        HWND hwnd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (int)(uint)fn((hwnd), WM_GETTEXTLENGTH, 0u, 0);

    public static void FORWARD_WM_HOTKEY(
        HWND hwnd,
        int idHotKey,
        uint fuModifiers,
        uint vk,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_HOTKEY, (WPARAM)(idHotKey), MAKELPARAM((fuModifiers), (vk)));

    public static void FORWARD_WM_HSCROLL(
        HWND hwnd,
        HWND hwndCtl,
        uint code,
        int pos,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        fn(
            (hwnd),
            WM_HSCROLL,
            MAKEWPARAM((uint)(int)(code), (uint)(int)(pos)),
            (LPARAM)(HWND)(hwndCtl)
        );

    public static void FORWARD_WM_HSCROLLCLIPBOARD(
        HWND hwnd,
        HWND hwndCBViewer,
        uint code,
        int pos,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        fn(
            (hwnd),
            WM_HSCROLLCLIPBOARD,
            (WPARAM)(HWND)(hwndCBViewer),
            MAKELPARAM((code), (nuint)(pos))
        );

    [Transformed]
    public static MaybeBool<BOOL> FORWARD_WM_ICONERASEBKGND(
        HWND hwnd,
        HDC hdc,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (MaybeBool<BOOL>)(BOOL)FORWARD_WM_ICONERASEBKGNDRaw(hwnd, hdc, fn);

    public static BOOL FORWARD_WM_ICONERASEBKGNDRaw(
        HWND hwnd,
        HDC hdc,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (BOOL)(uint)fn((hwnd), WM_ICONERASEBKGND, (WPARAM)(HDC)(hdc), 0);

    [Transformed]
    public static MaybeBool<BOOL> FORWARD_WM_INITDIALOG(
        HWND hwnd,
        HWND hwndFocus,
        LPARAM lParam,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (MaybeBool<BOOL>)(BOOL)FORWARD_WM_INITDIALOGRaw(hwnd, hwndFocus, lParam, fn);

    public static BOOL FORWARD_WM_INITDIALOGRaw(
        HWND hwnd,
        HWND hwndFocus,
        LPARAM lParam,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (BOOL)(uint)fn((hwnd), WM_INITDIALOG, (WPARAM)(HWND)(hwndFocus), (lParam));

    public static void FORWARD_WM_INITMENU(
        HWND hwnd,
        HMENU hMenu,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_INITMENU, (WPARAM)(HMENU)(hMenu), 0);

    public static void FORWARD_WM_INITMENUPOPUP(
        HWND hwnd,
        HMENU hMenu,
        uint item,
        BOOL fSystemMenu,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        fn(
            (hwnd),
            WM_INITMENUPOPUP,
            (WPARAM)(HMENU)(hMenu),
            MAKELPARAM((item), (nuint)(fSystemMenu))
        );

    [Transformed]
    public static void FORWARD_WM_INITMENUPOPUP(
        HWND hwnd,
        HMENU hMenu,
        uint item,
        MaybeBool<BOOL> fSystemMenu,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => FORWARD_WM_INITMENUPOPUP(hwnd, hMenu, item, (BOOL)fSystemMenu, fn);

    public static void FORWARD_WM_KEYDOWN(
        HWND hwnd,
        uint vk,
        int cRepeat,
        uint flags,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_KEYDOWN, (WPARAM)(uint)(vk), MAKELPARAM((nuint)(cRepeat), (flags)));

    public static void FORWARD_WM_KEYUP(
        HWND hwnd,
        uint vk,
        int cRepeat,
        uint flags,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_KEYUP, (WPARAM)(uint)(vk), MAKELPARAM((nuint)(cRepeat), (flags)));

    public static void FORWARD_WM_KILLFOCUS(
        HWND hwnd,
        HWND hwndNewFocus,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_KILLFOCUS, (WPARAM)(HWND)(hwndNewFocus), 0);

    public static void FORWARD_WM_LBUTTONDOWN(
        HWND hwnd,
        BOOL fDoubleClick,
        int x,
        int y,
        uint keyFlags,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        fn(
            (hwnd),
            (uint)((fDoubleClick) ? WM_LBUTTONDBLCLK : WM_LBUTTONDOWN),
            (WPARAM)(uint)(keyFlags),
            MAKELPARAM((x), (y))
        );

    [Transformed]
    public static void FORWARD_WM_LBUTTONDOWN(
        HWND hwnd,
        MaybeBool<BOOL> fDoubleClick,
        int x,
        int y,
        uint keyFlags,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => FORWARD_WM_LBUTTONDOWN(hwnd, (BOOL)fDoubleClick, x, y, keyFlags, fn);

    public static void FORWARD_WM_LBUTTONUP(
        HWND hwnd,
        int x,
        int y,
        uint keyFlags,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_LBUTTONUP, (WPARAM)(uint)(keyFlags), MAKELPARAM((x), (y)));

    public static void FORWARD_WM_MBUTTONDOWN(
        HWND hwnd,
        BOOL fDoubleClick,
        int x,
        int y,
        uint keyFlags,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        fn(
            (hwnd),
            (uint)((fDoubleClick) ? WM_MBUTTONDBLCLK : WM_MBUTTONDOWN),
            (WPARAM)(uint)(keyFlags),
            MAKELPARAM((x), (y))
        );

    [Transformed]
    public static void FORWARD_WM_MBUTTONDOWN(
        HWND hwnd,
        MaybeBool<BOOL> fDoubleClick,
        int x,
        int y,
        uint keyFlags,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => FORWARD_WM_MBUTTONDOWN(hwnd, (BOOL)fDoubleClick, x, y, keyFlags, fn);

    public static void FORWARD_WM_MBUTTONUP(
        HWND hwnd,
        int x,
        int y,
        uint keyFlags,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_MBUTTONUP, (WPARAM)(uint)(keyFlags), MAKELPARAM((x), (y)));

    public static void FORWARD_WM_MDIACTIVATE(
        HWND hwnd,
        BOOL fActive,
        HWND hwndActivate,
        HWND hwndDeactivate,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn(hwnd, WM_MDIACTIVATE, (WPARAM)(hwndDeactivate), (LPARAM)(hwndActivate));

    [Transformed]
    public static void FORWARD_WM_MDIACTIVATE(
        HWND hwnd,
        MaybeBool<BOOL> fActive,
        HWND hwndActivate,
        HWND hwndDeactivate,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => FORWARD_WM_MDIACTIVATE(hwnd, (BOOL)fActive, hwndActivate, hwndDeactivate, fn);

    [Transformed]
    public static MaybeBool<BOOL> FORWARD_WM_MDICASCADE(
        HWND hwnd,
        uint cmd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (MaybeBool<BOOL>)(BOOL)FORWARD_WM_MDICASCADERaw(hwnd, cmd, fn);

    public static BOOL FORWARD_WM_MDICASCADERaw(
        HWND hwnd,
        uint cmd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (BOOL)(uint)fn((hwnd), WM_MDICASCADE, (WPARAM)(cmd), 0);

    public static HWND FORWARD_WM_MDICREATE(
        HWND hwnd,
        MDICREATESTRUCTW* lpmcs,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (HWND)(uint)(uint)fn((hwnd), WM_MDICREATE, 0u, (LPARAM)(MDICREATESTRUCTW*)(lpmcs));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HWND FORWARD_WM_MDICREATE(
        HWND hwnd,
        Ref<MDICREATESTRUCTW> lpmcs,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    )
    {
        fixed (MDICREATESTRUCTW* __dsl_lpmcs = lpmcs)
        {
            return (HWND)FORWARD_WM_MDICREATE(hwnd, __dsl_lpmcs, fn);
        }
    }

    public static void FORWARD_WM_MDIDESTROY(
        HWND hwnd,
        HWND hwndDestroy,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_MDIDESTROY, (WPARAM)(hwndDestroy), 0);

    public static HWND FORWARD_WM_MDIGETACTIVE(
        HWND hwnd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (HWND)(nuint)fn((hwnd), WM_MDIGETACTIVE, 0u, 0);

    public static void FORWARD_WM_MDIICONARRANGE(
        HWND hwnd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_MDIICONARRANGE, 0u, 0);

    public static void FORWARD_WM_MDIMAXIMIZE(
        HWND hwnd,
        HWND hwndMaximize,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_MDIMAXIMIZE, (WPARAM)(hwndMaximize), 0);

    public static HWND FORWARD_WM_MDINEXT(
        HWND hwnd,
        HWND hwndCur,
        BOOL fPrev,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (HWND)(nuint)fn((hwnd), WM_MDINEXT, (WPARAM)(hwndCur), (LPARAM)(fPrev));

    [Transformed]
    public static HWND FORWARD_WM_MDINEXT(
        HWND hwnd,
        HWND hwndCur,
        MaybeBool<BOOL> fPrev,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (HWND)FORWARD_WM_MDINEXT(hwnd, hwndCur, (BOOL)fPrev, fn);

    public static void FORWARD_WM_MDIRESTORE(
        HWND hwnd,
        HWND hwndRestore,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_MDIRESTORE, (WPARAM)(hwndRestore), 0);

    public static HMENU FORWARD_WM_MDISETMENU(
        HWND hwnd,
        BOOL fRefresh,
        HMENU hmenuFrame,
        HMENU hmenuWindow,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        (HMENU)
            (nuint)fn(
                (hwnd),
                WM_MDISETMENU,
                (WPARAM)((fRefresh) ? (hmenuFrame) : HMENU.NULL),
                (LPARAM)(hmenuWindow)
            );

    [Transformed]
    public static HMENU FORWARD_WM_MDISETMENU(
        HWND hwnd,
        MaybeBool<BOOL> fRefresh,
        HMENU hmenuFrame,
        HMENU hmenuWindow,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (HMENU)FORWARD_WM_MDISETMENU(hwnd, (BOOL)fRefresh, hmenuFrame, hmenuWindow, fn);

    [Transformed]
    public static MaybeBool<BOOL> FORWARD_WM_MDITILE(
        HWND hwnd,
        uint cmd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (MaybeBool<BOOL>)(BOOL)FORWARD_WM_MDITILERaw(hwnd, cmd, fn);

    public static BOOL FORWARD_WM_MDITILERaw(
        HWND hwnd,
        uint cmd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (BOOL)(uint)fn((hwnd), WM_MDITILE, (WPARAM)(cmd), 0);

    public static void FORWARD_WM_MEASUREITEM(
        HWND hwnd,
        MEASUREITEMSTRUCT* lpMeasureItem,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        fn(
            (hwnd),
            WM_MEASUREITEM,
            (WPARAM)(((MEASUREITEMSTRUCT*)lpMeasureItem)->CtlID),
            (LPARAM)(MEASUREITEMSTRUCT*)(lpMeasureItem)
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void FORWARD_WM_MEASUREITEM(
        HWND hwnd,
        Ref<MEASUREITEMSTRUCT> lpMeasureItem,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    )
    {
        fixed (MEASUREITEMSTRUCT* __dsl_lpMeasureItem = lpMeasureItem)
        {
            FORWARD_WM_MEASUREITEM(hwnd, __dsl_lpMeasureItem, fn);
        }
    }

    public static uint FORWARD_WM_MENUCHAR(
        HWND hwnd,
        uint ch,
        uint flags,
        HMENU hmenu,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (uint)fn((hwnd), WM_MENUCHAR, MAKEWPARAM(flags, (ushort)(ch)), (LPARAM)(HMENU)(hmenu));

    public static void FORWARD_WM_MENUSELECT(
        HWND hwnd,
        HMENU hmenu,
        int item,
        HMENU hmenuPopup,
        uint flags,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        fn(
            (hwnd),
            WM_MENUSELECT,
            MAKEWPARAM((nuint)(item), (flags)),
            (LPARAM)(HMENU)((hmenu != HMENU.NULL) ? (hmenu) : (hmenuPopup))
        );

    public static int FORWARD_WM_MOUSEACTIVATE(
        HWND hwnd,
        HWND hwndTopLevel,
        uint codeHitTest,
        uint msg,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        (int)
            (uint)fn(
                (hwnd),
                WM_MOUSEACTIVATE,
                (WPARAM)(HWND)(hwndTopLevel),
                MAKELPARAM((codeHitTest), (msg))
            );

    public static void FORWARD_WM_MOUSEMOVE(
        HWND hwnd,
        int x,
        int y,
        uint keyFlags,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_MOUSEMOVE, (WPARAM)(uint)(keyFlags), MAKELPARAM((x), (y)));

    public static void FORWARD_WM_MOUSEWHEEL(
        HWND hwnd,
        int xPos,
        int yPos,
        int zDelta,
        uint fwKeys,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        fn(
            (hwnd),
            WM_MOUSEWHEEL,
            MAKEWPARAM((fwKeys), (nuint)(zDelta)),
            MAKELPARAM((xPos), (yPos))
        );

    public static void FORWARD_WM_MOVE(
        HWND hwnd,
        int x,
        int y,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_MOVE, 0u, MAKELPARAM((x), (y)));

    public static BOOL FORWARD_WM_NCACTIVATE(
        HWND hwnd,
        BOOL fActive,
        HWND hwndActDeact,
        BOOL fMinimized,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (BOOL)(uint)fn((hwnd), WM_NCACTIVATE, (WPARAM)(BOOL)(fActive), 0);

    [Transformed]
    public static MaybeBool<BOOL> FORWARD_WM_NCACTIVATE(
        HWND hwnd,
        MaybeBool<BOOL> fActive,
        HWND hwndActDeact,
        MaybeBool<BOOL> fMinimized,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        (MaybeBool<BOOL>)
            (BOOL)FORWARD_WM_NCACTIVATE(hwnd, (BOOL)fActive, hwndActDeact, (BOOL)fMinimized, fn);

    public static uint FORWARD_WM_NCCALCSIZE(
        HWND hwnd,
        BOOL fCalcValidRects,
        NCCALCSIZE_PARAMS* lpcsp,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        (uint)
            (uint)fn(
                (hwnd),
                WM_NCCALCSIZE,
                (WPARAM)(fCalcValidRects),
                (LPARAM)(NCCALCSIZE_PARAMS*)(lpcsp)
            );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint FORWARD_WM_NCCALCSIZE(
        HWND hwnd,
        MaybeBool<BOOL> fCalcValidRects,
        Ref<NCCALCSIZE_PARAMS> lpcsp,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    )
    {
        fixed (NCCALCSIZE_PARAMS* __dsl_lpcsp = lpcsp)
        {
            return (uint)FORWARD_WM_NCCALCSIZE(hwnd, (BOOL)fCalcValidRects, __dsl_lpcsp, fn);
        }
    }

    public static BOOL FORWARD_WM_NCCREATE(
        HWND hwnd,
        CREATESTRUCTW* lpCreateStruct,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (BOOL)(uint)fn((hwnd), WM_NCCREATE, 0u, (LPARAM)(CREATESTRUCTW*)(lpCreateStruct));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<BOOL> FORWARD_WM_NCCREATE(
        HWND hwnd,
        Ref<CREATESTRUCTW> lpCreateStruct,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    )
    {
        fixed (CREATESTRUCTW* __dsl_lpCreateStruct = lpCreateStruct)
        {
            return (MaybeBool<BOOL>)(BOOL)FORWARD_WM_NCCREATE(hwnd, __dsl_lpCreateStruct, fn);
        }
    }

    public static void FORWARD_WM_NCDESTROY(
        HWND hwnd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_NCDESTROY, 0u, 0);

    public static uint FORWARD_WM_NCHITTEST(
        HWND hwnd,
        int x,
        int y,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (uint)(uint)fn((hwnd), WM_NCHITTEST, 0u, MAKELPARAM((x), (y)));

    public static void FORWARD_WM_NCLBUTTONDOWN(
        HWND hwnd,
        BOOL fDoubleClick,
        int x,
        int y,
        uint codeHitTest,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        fn(
            (hwnd),
            (uint)((fDoubleClick) ? WM_NCLBUTTONDBLCLK : WM_NCLBUTTONDOWN),
            (WPARAM)(uint)(codeHitTest),
            MAKELPARAM((x), (y))
        );

    [Transformed]
    public static void FORWARD_WM_NCLBUTTONDOWN(
        HWND hwnd,
        MaybeBool<BOOL> fDoubleClick,
        int x,
        int y,
        uint codeHitTest,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => FORWARD_WM_NCLBUTTONDOWN(hwnd, (BOOL)fDoubleClick, x, y, codeHitTest, fn);

    public static void FORWARD_WM_NCLBUTTONUP(
        HWND hwnd,
        int x,
        int y,
        uint codeHitTest,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_NCLBUTTONUP, (WPARAM)(uint)(codeHitTest), MAKELPARAM((x), (y)));

    public static void FORWARD_WM_NCMBUTTONDOWN(
        HWND hwnd,
        BOOL fDoubleClick,
        int x,
        int y,
        uint codeHitTest,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        fn(
            (hwnd),
            (uint)((fDoubleClick) ? WM_NCMBUTTONDBLCLK : WM_NCMBUTTONDOWN),
            (WPARAM)(uint)(codeHitTest),
            MAKELPARAM((x), (y))
        );

    [Transformed]
    public static void FORWARD_WM_NCMBUTTONDOWN(
        HWND hwnd,
        MaybeBool<BOOL> fDoubleClick,
        int x,
        int y,
        uint codeHitTest,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => FORWARD_WM_NCMBUTTONDOWN(hwnd, (BOOL)fDoubleClick, x, y, codeHitTest, fn);

    public static void FORWARD_WM_NCMBUTTONUP(
        HWND hwnd,
        int x,
        int y,
        uint codeHitTest,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_NCMBUTTONUP, (WPARAM)(uint)(codeHitTest), MAKELPARAM((x), (y)));

    public static void FORWARD_WM_NCMOUSEMOVE(
        HWND hwnd,
        int x,
        int y,
        uint codeHitTest,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_NCMOUSEMOVE, (WPARAM)(uint)(codeHitTest), MAKELPARAM((x), (y)));

    public static void FORWARD_WM_NCPAINT(
        HWND hwnd,
        HRGN hrgn,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_NCPAINT, (WPARAM)(HRGN)(hrgn), 0);

    public static void FORWARD_WM_NCRBUTTONDOWN(
        HWND hwnd,
        BOOL fDoubleClick,
        int x,
        int y,
        uint codeHitTest,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        fn(
            (hwnd),
            (uint)((fDoubleClick) ? WM_NCRBUTTONDBLCLK : WM_NCRBUTTONDOWN),
            (WPARAM)(uint)(codeHitTest),
            MAKELPARAM((x), (y))
        );

    [Transformed]
    public static void FORWARD_WM_NCRBUTTONDOWN(
        HWND hwnd,
        MaybeBool<BOOL> fDoubleClick,
        int x,
        int y,
        uint codeHitTest,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => FORWARD_WM_NCRBUTTONDOWN(hwnd, (BOOL)fDoubleClick, x, y, codeHitTest, fn);

    public static void FORWARD_WM_NCRBUTTONUP(
        HWND hwnd,
        int x,
        int y,
        uint codeHitTest,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_NCRBUTTONUP, (WPARAM)(uint)(codeHitTest), MAKELPARAM((x), (y)));

    public static HWND FORWARD_WM_NEXTDLGCTL(
        HWND hwnd,
        HWND hwndSetFocus,
        BOOL fNext,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (HWND)(nuint)fn((hwnd), WM_NEXTDLGCTL, (WPARAM)(HWND)(hwndSetFocus), (LPARAM)(fNext));

    [Transformed]
    public static HWND FORWARD_WM_NEXTDLGCTL(
        HWND hwnd,
        HWND hwndSetFocus,
        MaybeBool<BOOL> fNext,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (HWND)FORWARD_WM_NEXTDLGCTL(hwnd, hwndSetFocus, (BOOL)fNext, fn);

    public static void FORWARD_WM_PAINT(
        HWND hwnd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_PAINT, 0u, 0);

    public static void FORWARD_WM_PAINTCLIPBOARD(
        HWND hwnd,
        HWND hwndCBViewer,
        PAINTSTRUCT* lpPaintStruct,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        fn(
            (hwnd),
            WM_PAINTCLIPBOARD,
            (WPARAM)(HWND)(hwndCBViewer),
            (LPARAM)(PAINTSTRUCT*)(lpPaintStruct)
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void FORWARD_WM_PAINTCLIPBOARD(
        HWND hwnd,
        HWND hwndCBViewer,
        Ref<PAINTSTRUCT> lpPaintStruct,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    )
    {
        fixed (PAINTSTRUCT* __dsl_lpPaintStruct = lpPaintStruct)
        {
            FORWARD_WM_PAINTCLIPBOARD(hwnd, hwndCBViewer, __dsl_lpPaintStruct, fn);
        }
    }

    public static void FORWARD_WM_PALETTECHANGED(
        HWND hwnd,
        HWND hwndPaletteChange,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_PALETTECHANGED, (WPARAM)(HWND)(hwndPaletteChange), 0);

    public static void FORWARD_WM_PALETTEISCHANGING(
        HWND hwnd,
        HWND hwndPaletteChange,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_PALETTEISCHANGING, (WPARAM)(HWND)(hwndPaletteChange), 0);

    public static void FORWARD_WM_PARENTNOTIFY(
        HWND hwnd,
        uint msg,
        HWND hwndChild,
        int idChild,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_PARENTNOTIFY, MAKEWPARAM(msg, (nuint)(idChild)), (LPARAM)(hwndChild));

    public static void FORWARD_WM_PASTE(
        HWND hwnd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_PASTE, 0u, 0);

    public static void FORWARD_WM_POWER(
        HWND hwnd,
        int code,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_POWER, (WPARAM)(int)(code), 0);

    public static HICON FORWARD_WM_QUERYDRAGICON(
        HWND hwnd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (HICON)(uint)(uint)fn((hwnd), WM_QUERYDRAGICON, 0u, 0);

    [Transformed]
    public static MaybeBool<BOOL> FORWARD_WM_QUERYENDSESSION(
        HWND hwnd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (MaybeBool<BOOL>)(BOOL)FORWARD_WM_QUERYENDSESSIONRaw(hwnd, fn);

    public static BOOL FORWARD_WM_QUERYENDSESSIONRaw(
        HWND hwnd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (BOOL)(uint)fn((hwnd), WM_QUERYENDSESSION, 0u, 0);

    [Transformed]
    public static MaybeBool<BOOL> FORWARD_WM_QUERYNEWPALETTE(
        HWND hwnd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (MaybeBool<BOOL>)(BOOL)FORWARD_WM_QUERYNEWPALETTERaw(hwnd, fn);

    public static BOOL FORWARD_WM_QUERYNEWPALETTERaw(
        HWND hwnd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (BOOL)(uint)fn((hwnd), WM_QUERYNEWPALETTE, 0u, 0);

    [Transformed]
    public static MaybeBool<BOOL> FORWARD_WM_QUERYOPEN(
        HWND hwnd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (MaybeBool<BOOL>)(BOOL)FORWARD_WM_QUERYOPENRaw(hwnd, fn);

    public static BOOL FORWARD_WM_QUERYOPENRaw(
        HWND hwnd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (BOOL)(uint)fn((hwnd), WM_QUERYOPEN, 0u, 0);

    public static void FORWARD_WM_QUEUESYNC(
        HWND hwnd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_QUEUESYNC, 0u, 0);

    public static void FORWARD_WM_QUIT(
        HWND hwnd,
        int exitCode,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_QUIT, (WPARAM)(exitCode), 0);

    public static void FORWARD_WM_RBUTTONDOWN(
        HWND hwnd,
        BOOL fDoubleClick,
        int x,
        int y,
        uint keyFlags,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        fn(
            (hwnd),
            (uint)((fDoubleClick) ? WM_RBUTTONDBLCLK : WM_RBUTTONDOWN),
            (WPARAM)(uint)(keyFlags),
            MAKELPARAM((x), (y))
        );

    [Transformed]
    public static void FORWARD_WM_RBUTTONDOWN(
        HWND hwnd,
        MaybeBool<BOOL> fDoubleClick,
        int x,
        int y,
        uint keyFlags,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => FORWARD_WM_RBUTTONDOWN(hwnd, (BOOL)fDoubleClick, x, y, keyFlags, fn);

    public static void FORWARD_WM_RBUTTONUP(
        HWND hwnd,
        int x,
        int y,
        uint keyFlags,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_RBUTTONUP, (WPARAM)(uint)(keyFlags), MAKELPARAM((x), (y)));

    public static void FORWARD_WM_RENDERALLFORMATS(
        HWND hwnd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_RENDERALLFORMATS, 0u, 0);

    public static HANDLE FORWARD_WM_RENDERFORMAT(
        HWND hwnd,
        uint fmt,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (HANDLE)(nuint)fn((hwnd), WM_RENDERFORMAT, (WPARAM)(uint)(fmt), 0);

    [Transformed]
    public static MaybeBool<BOOL> FORWARD_WM_SETCURSOR(
        HWND hwnd,
        HWND hwndCursor,
        uint codeHitTest,
        uint msg,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (MaybeBool<BOOL>)(BOOL)FORWARD_WM_SETCURSORRaw(hwnd, hwndCursor, codeHitTest, msg, fn);

    public static BOOL FORWARD_WM_SETCURSORRaw(
        HWND hwnd,
        HWND hwndCursor,
        uint codeHitTest,
        uint msg,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        (BOOL)
            (uint)fn(
                (hwnd),
                WM_SETCURSOR,
                (WPARAM)(HWND)(hwndCursor),
                MAKELPARAM((codeHitTest), (msg))
            );

    public static void FORWARD_WM_SETFOCUS(
        HWND hwnd,
        HWND hwndOldFocus,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_SETFOCUS, (WPARAM)(HWND)(hwndOldFocus), 0);

    public static void FORWARD_WM_SETFONT(
        HWND hwnd,
        HFONT hfont,
        BOOL fRedraw,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_SETFONT, (WPARAM)(HFONT)(hfont), (LPARAM)(BOOL)(fRedraw));

    [Transformed]
    public static void FORWARD_WM_SETFONT(
        HWND hwnd,
        HFONT hfont,
        MaybeBool<BOOL> fRedraw,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => FORWARD_WM_SETFONT(hwnd, hfont, (BOOL)fRedraw, fn);

    public static void FORWARD_WM_SETREDRAW(
        HWND hwnd,
        BOOL fRedraw,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_SETREDRAW, (WPARAM)(BOOL)(fRedraw), 0);

    [Transformed]
    public static void FORWARD_WM_SETREDRAW(
        HWND hwnd,
        MaybeBool<BOOL> fRedraw,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => FORWARD_WM_SETREDRAW(hwnd, (BOOL)fRedraw, fn);

    public static void FORWARD_WM_SETTEXT(
        HWND hwnd,
        char* lpszText,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_SETTEXT, 0u, (LPARAM)(char*)(lpszText));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void FORWARD_WM_SETTEXT(
        HWND hwnd,
        Ref<char> lpszText,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    )
    {
        fixed (char* __dsl_lpszText = lpszText)
        {
            FORWARD_WM_SETTEXT(hwnd, __dsl_lpszText, fn);
        }
    }

    public static void FORWARD_WM_SHOWWINDOW(
        HWND hwnd,
        BOOL fShow,
        uint status,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_SHOWWINDOW, (WPARAM)(BOOL)(fShow), (LPARAM)(uint)(status));

    [Transformed]
    public static void FORWARD_WM_SHOWWINDOW(
        HWND hwnd,
        MaybeBool<BOOL> fShow,
        uint status,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => FORWARD_WM_SHOWWINDOW(hwnd, (BOOL)fShow, status, fn);

    public static void FORWARD_WM_SIZE(
        HWND hwnd,
        uint state,
        int cx,
        int cy,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_SIZE, (WPARAM)(uint)(state), MAKELPARAM((cx), (cy)));

    public static void FORWARD_WM_SIZECLIPBOARD(
        HWND hwnd,
        HWND hwndCBViewer,
        RECT* lprc,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_SIZECLIPBOARD, (WPARAM)(HWND)(hwndCBViewer), (LPARAM)(RECT*)(lprc));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void FORWARD_WM_SIZECLIPBOARD(
        HWND hwnd,
        HWND hwndCBViewer,
        Ref<RECT> lprc,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    )
    {
        fixed (RECT* __dsl_lprc = lprc)
        {
            FORWARD_WM_SIZECLIPBOARD(hwnd, hwndCBViewer, __dsl_lprc, fn);
        }
    }

    public static void FORWARD_WM_SPOOLERSTATUS(
        HWND hwnd,
        uint status,
        ushort cJobInQueue,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_SPOOLERSTATUS, (WPARAM)(status), MAKELPARAM((cJobInQueue), 0));

    public static void FORWARD_WM_SYSCHAR(
        HWND hwnd,
        ushort ch,
        int cRepeat,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_SYSCHAR, (WPARAM)(ushort)(ch), MAKELPARAM((cRepeat), 0));

    public static void FORWARD_WM_SYSCOLORCHANGE(
        HWND hwnd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_SYSCOLORCHANGE, 0u, 0);

    public static void FORWARD_WM_SYSCOMMAND(
        HWND hwnd,
        uint cmd,
        int x,
        int y,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_SYSCOMMAND, (WPARAM)(uint)(cmd), MAKELPARAM((x), (y)));

    public static void FORWARD_WM_SYSDEADCHAR(
        HWND hwnd,
        ushort ch,
        int cRepeat,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_SYSDEADCHAR, (WPARAM)(ushort)(ch), MAKELPARAM((cRepeat), 0));

    public static void FORWARD_WM_SYSKEYDOWN(
        HWND hwnd,
        uint vk,
        int cRepeat,
        uint flags,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_SYSKEYDOWN, (WPARAM)(uint)(vk), MAKELPARAM((nuint)(cRepeat), (flags)));

    public static void FORWARD_WM_SYSKEYUP(
        HWND hwnd,
        uint vk,
        int cRepeat,
        uint flags,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_SYSKEYUP, (WPARAM)(uint)(vk), MAKELPARAM((nuint)(cRepeat), (flags)));

    public static void FORWARD_WM_SYSTEMERROR(
        HWND hwnd,
        int errCode,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) { }

    public static void FORWARD_WM_TIMECHANGE(
        HWND hwnd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_TIMECHANGE, 0u, 0);

    public static void FORWARD_WM_TIMER(
        HWND hwnd,
        uint id,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_TIMER, (WPARAM)(uint)(id), 0);

    public static void FORWARD_WM_UNDO(
        HWND hwnd,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_UNDO, 0u, 0);

    public static int FORWARD_WM_VKEYTOITEM(
        HWND hwnd,
        uint vk,
        HWND hwndListBox,
        int iCaret,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        (int)
            (uint)fn(
                (hwnd),
                WM_VKEYTOITEM,
                MAKEWPARAM((vk), (nuint)(iCaret)),
                (LPARAM)(hwndListBox)
            );

    public static void FORWARD_WM_VSCROLL(
        HWND hwnd,
        HWND hwndCtl,
        uint code,
        int pos,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        fn(
            (hwnd),
            WM_VSCROLL,
            MAKEWPARAM((uint)(int)(code), (uint)(int)(pos)),
            (LPARAM)(HWND)(hwndCtl)
        );

    public static void FORWARD_WM_VSCROLLCLIPBOARD(
        HWND hwnd,
        HWND hwndCBViewer,
        uint code,
        int pos,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) =>
        fn(
            (hwnd),
            WM_VSCROLLCLIPBOARD,
            (WPARAM)(HWND)(hwndCBViewer),
            MAKELPARAM((code), (nuint)(pos))
        );

    public static void FORWARD_WM_WINDOWPOSCHANGED(
        HWND hwnd,
        WINDOWPOS* lpwpos,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_WINDOWPOSCHANGED, 0u, (LPARAM)(WINDOWPOS*)(lpwpos));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void FORWARD_WM_WINDOWPOSCHANGED(
        HWND hwnd,
        Ref<WINDOWPOS> lpwpos,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    )
    {
        fixed (WINDOWPOS* __dsl_lpwpos = lpwpos)
        {
            FORWARD_WM_WINDOWPOSCHANGED(hwnd, __dsl_lpwpos, fn);
        }
    }

    public static BOOL FORWARD_WM_WINDOWPOSCHANGING(
        HWND hwnd,
        WINDOWPOS* lpwpos,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => (BOOL)(uint)fn((hwnd), WM_WINDOWPOSCHANGING, 0u, (LPARAM)(WINDOWPOS*)(lpwpos));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<BOOL> FORWARD_WM_WINDOWPOSCHANGING(
        HWND hwnd,
        Ref<WINDOWPOS> lpwpos,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    )
    {
        fixed (WINDOWPOS* __dsl_lpwpos = lpwpos)
        {
            return (MaybeBool<BOOL>)(BOOL)FORWARD_WM_WINDOWPOSCHANGING(hwnd, __dsl_lpwpos, fn);
        }
    }

    public static void FORWARD_WM_WININICHANGE(
        HWND hwnd,
        char* lpszSectionName,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    ) => fn((hwnd), WM_WININICHANGE, 0u, (LPARAM)(char*)(lpszSectionName));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void FORWARD_WM_WININICHANGE(
        HWND hwnd,
        Ref<char> lpszSectionName,
        delegate* <HWND, uint, WPARAM, LPARAM, LRESULT> fn
    )
    {
        fixed (char* __dsl_lpszSectionName = lpszSectionName)
        {
            FORWARD_WM_WININICHANGE(hwnd, __dsl_lpszSectionName, fn);
        }
    }

    public static (WPARAM wp, LPARAM lp) GET_EM_LINESCROLL_MPS(WPARAM vert, LPARAM horz) =>
        ((WPARAM)horz, (LPARAM)vert);

    public static LPARAM GET_EM_SETSEL_END(WPARAM wp, LPARAM lp) => (lp);

    public static (WPARAM wp, LPARAM lp) GET_EM_SETSEL_MPS(int iStart, LPARAM iEnd) =>
        ((WPARAM)(iStart), (LPARAM)(iEnd));

    public static int GET_EM_SETSEL_START(WPARAM wp, LPARAM lp) => (int)(wp);

    public static LPARAM GET_LPARAM(WPARAM wp, LPARAM lp) => (lp);

    [Transformed]
    public static MaybeBool<BOOL> GET_WM_ACTIVATE_FMINIMIZED(WPARAM wp, LPARAM lp) =>
        (MaybeBool<BOOL>)(BOOL)GET_WM_ACTIVATE_FMINIMIZEDRaw(wp, lp);

    public static BOOL GET_WM_ACTIVATE_FMINIMIZEDRaw(WPARAM wp, LPARAM lp) => (BOOL)HIWORD(wp);

    public static HWND GET_WM_ACTIVATE_HWND(WPARAM wp, LPARAM lp) => (HWND)(lp);

    public static (WPARAM wp, LPARAM lp) GET_WM_ACTIVATE_MPS(ushort s, BOOL fmin, HWND hwnd) =>
        ((WPARAM)MAKELONG((s), (fmin)), (LPARAM)(hwnd));

    [Transformed]
    public static (WPARAM wp, LPARAM lp) GET_WM_ACTIVATE_MPS(
        ushort s,
        MaybeBool<BOOL> fmin,
        HWND hwnd
    ) => ((WPARAM wp, LPARAM lp))GET_WM_ACTIVATE_MPS(s, (BOOL)fmin, hwnd);

    public static ushort GET_WM_ACTIVATE_STATE(WPARAM wp, LPARAM lp) => LOWORD(wp);

    public static HWND GET_WM_CHANGECBCHAIN_HWNDNEXT(WPARAM wp, LPARAM lp) => (HWND)(lp);

    public static ushort GET_WM_CHARTOITEM_CHAR(WPARAM wp, LPARAM lp) => (ushort)LOWORD(wp);

    public static HWND GET_WM_CHARTOITEM_HWND(WPARAM wp, LPARAM lp) => (HWND)(lp);

    public static (WPARAM wp, LPARAM lp) GET_WM_CHARTOITEM_MPS(ushort ch, ushort pos, HWND hwnd) =>
        ((WPARAM)MAKELONG((pos), (ch)), (LPARAM)(hwnd));

    public static ushort GET_WM_CHARTOITEM_POS(WPARAM wp, LPARAM lp) => HIWORD(wp);

    public static ushort GET_WM_COMMAND_CMD(WPARAM wp, LPARAM lp) => HIWORD(wp);

    public static HWND GET_WM_COMMAND_HWND(WPARAM wp, LPARAM lp) => (HWND)(lp);

    public static ushort GET_WM_COMMAND_ID(WPARAM wp, LPARAM lp) => LOWORD(wp);

    public static (WPARAM wp, LPARAM lp) GET_WM_COMMAND_MPS(ushort id, HWND hwnd, ushort cmd) =>
        ((WPARAM)MAKELONG(id, cmd), (LPARAM)(hwnd));

    public static HDC GET_WM_CTLCOLOR_HDC(WPARAM wp, LPARAM lp, uint msg) => (HDC)(wp);

    public static HWND GET_WM_CTLCOLOR_HWND(WPARAM wp, LPARAM lp, uint msg) => (HWND)(lp);

    public static (WPARAM wp, LPARAM lp) GET_WM_CTLCOLOR_MPS(HDC hdc, HWND hwnd, ushort type) =>
        ((WPARAM)(hdc), (LPARAM)(hwnd));

    public static ushort GET_WM_CTLCOLOR_MSG(ushort type) => (ushort)(WM_CTLCOLORMSGBOX + (type));

    public static ushort GET_WM_CTLCOLOR_TYPE(WPARAM wp, LPARAM lp, uint msg) =>
        (ushort)(msg - WM_CTLCOLORMSGBOX);

    public static ushort GET_WM_HSCROLL_CODE(WPARAM wp, LPARAM lp) => LOWORD(wp);

    public static HWND GET_WM_HSCROLL_HWND(WPARAM wp, LPARAM lp) => (HWND)(lp);

    public static (WPARAM wp, LPARAM lp) GET_WM_HSCROLL_MPS(ushort code, ushort pos, HWND hwnd) =>
        ((WPARAM)MAKELONG(code, pos), (LPARAM)(hwnd));

    public static ushort GET_WM_HSCROLL_POS(WPARAM wp, LPARAM lp) => HIWORD(wp);

    [Transformed]
    /* Note: the following are for interpreting MDIclient to MDI child messages. */
    public static MaybeBool<BOOL> GET_WM_MDIACTIVATE_FACTIVATE(HWND hwnd, WPARAM wp, LPARAM lp) =>
        (MaybeBool<BOOL>)(BOOL)GET_WM_MDIACTIVATE_FACTIVATERaw(hwnd, wp, lp);

    /* Note: the following are for interpreting MDIclient to MDI child messages. */
    public static BOOL GET_WM_MDIACTIVATE_FACTIVATERaw(HWND hwnd, WPARAM wp, LPARAM lp) =>
        (lp == (LPARAM)hwnd);

    public static HWND GET_WM_MDIACTIVATE_HWNDACTIVATE(WPARAM wp, LPARAM lp) => (HWND)(lp);

    public static HWND GET_WM_MDIACTIVATE_HWNDDEACT(WPARAM wp, LPARAM lp) => (HWND)(wp);

    /* Note: the following is for sending to the MDI client window. */
    public static (WPARAM wp, LPARAM lp) GET_WM_MDIACTIVATE_MPS(BOOL f, HWND hwndD, HWND hwndA) =>
        ((WPARAM)(hwndA), 0);

    [Transformed]
    /* Note: the following is for sending to the MDI client window. */
    public static (WPARAM wp, LPARAM lp) GET_WM_MDIACTIVATE_MPS(
        MaybeBool<BOOL> f,
        HWND hwndD,
        HWND hwndA
    ) => ((WPARAM wp, LPARAM lp))GET_WM_MDIACTIVATE_MPS((BOOL)f, hwndD, hwndA);

    public static (WPARAM wp, LPARAM lp) GET_WM_MDISETMENU_MPS(HMENU hmenuF, HMENU hmenuW) =>
        ((WPARAM)hmenuF, (LPARAM)hmenuW);

    public static ushort GET_WM_MENUCHAR_CHAR(WPARAM wp, LPARAM lp) => (ushort)LOWORD(wp);

    [Transformed]
    public static MaybeBool<BOOL> GET_WM_MENUCHAR_FMENU(WPARAM wp, LPARAM lp) =>
        (MaybeBool<BOOL>)(BOOL)GET_WM_MENUCHAR_FMENURaw(wp, lp);

    public static BOOL GET_WM_MENUCHAR_FMENURaw(WPARAM wp, LPARAM lp) => (BOOL)HIWORD(wp);

    public static HMENU GET_WM_MENUCHAR_HMENU(WPARAM wp, LPARAM lp) => (HMENU)(lp);

    public static (WPARAM wp, LPARAM lp) GET_WM_MENUCHAR_MPS(ushort ch, HMENU hmenu, BOOL f) =>
        ((WPARAM)MAKELONG(ch, f), (LPARAM)(hmenu));

    [Transformed]
    public static (WPARAM wp, LPARAM lp) GET_WM_MENUCHAR_MPS(
        ushort ch,
        HMENU hmenu,
        MaybeBool<BOOL> f
    ) => ((WPARAM wp, LPARAM lp))GET_WM_MENUCHAR_MPS(ch, hmenu, (BOOL)f);

    public static ushort GET_WM_MENUSELECT_CMD(WPARAM wp, LPARAM lp) => LOWORD(wp);

    public static uint GET_WM_MENUSELECT_FLAGS(WPARAM wp, LPARAM lp) =>
        (uint)(int)(short)HIWORD(wp);

    public static HMENU GET_WM_MENUSELECT_HMENU(WPARAM wp, LPARAM lp) => (HMENU)(lp);

    public static (WPARAM wp, LPARAM lp) GET_WM_MENUSELECT_MPS(ushort cmd, uint f, HMENU hmenu) =>
        ((WPARAM)MAKELONG(cmd, f), (LPARAM)(hmenu));

    public static HWND GET_WM_PARENTNOTIFY_HWNDCHILD(WPARAM wp, LPARAM lp) => (HWND)(lp);

    public static ushort GET_WM_PARENTNOTIFY_ID(WPARAM wp, LPARAM lp) => HIWORD(wp);

    public static (WPARAM wp, LPARAM lp) GET_WM_PARENTNOTIFY_MPS(
        ushort msg,
        ushort id,
        HWND hwnd
    ) => ((WPARAM)MAKELONG(id, msg), (LPARAM)(hwnd));

    public static ushort GET_WM_PARENTNOTIFY_MSG(WPARAM wp, LPARAM lp) => LOWORD(wp);

    public static int GET_WM_PARENTNOTIFY_X(WPARAM wp, LPARAM lp) => (int)(short)LOWORD(lp);

    public static int GET_WM_PARENTNOTIFY_Y(WPARAM wp, LPARAM lp) => (int)(short)HIWORD(lp);

    public static (WPARAM wp, LPARAM lp) GET_WM_PARENTNOTIFY2_MPS(ushort msg, int x, int y) =>
        ((WPARAM)MAKELONG(0, msg), MAKELONG(x, y));

    public static int GET_WM_VKEYTOITEM_CODE(WPARAM wp, LPARAM lp) => (int)(short)LOWORD(wp);

    public static HWND GET_WM_VKEYTOITEM_HWND(WPARAM wp, LPARAM lp) => (HWND)(lp);

    public static ushort GET_WM_VKEYTOITEM_ITEM(WPARAM wp, LPARAM lp) => HIWORD(wp);

    public static (WPARAM wp, LPARAM lp) GET_WM_VKEYTOITEM_MPS(int code, ushort item, HWND hwnd) =>
        ((WPARAM)MAKELONG(item, code), (LPARAM)(hwnd));

    public static ushort GET_WM_VSCROLL_CODE(WPARAM wp, LPARAM lp) => LOWORD(wp);

    public static HWND GET_WM_VSCROLL_HWND(WPARAM wp, LPARAM lp) => (HWND)(lp);

    public static (WPARAM wp, LPARAM lp) GET_WM_VSCROLL_MPS(ushort code, ushort pos, HWND hwnd) =>
        ((WPARAM)MAKELONG(code, pos), (LPARAM)(hwnd));

    public static ushort GET_WM_VSCROLL_POS(WPARAM wp, LPARAM lp) => HIWORD(wp);

    /****** Alternate porting layer macros ****************************************/
    /* USER MESSAGES: */
    public static WPARAM GET_WPARAM(WPARAM wp, LPARAM lp) => (wp);

    public static int GET_X_LPARAM(LPARAM lp) => ((int)(short)LOWORD(lp));

    public static int GET_Y_LPARAM(LPARAM lp) => ((int)(short)HIWORD(lp));

    public static HWND GetFirstChild(HWND hwnd) => GetTopWindow(hwnd);

    public static HWND GetFirstSibling(HWND hwnd) => GetWindow(hwnd, GW_HWNDFIRST);

    /****** KERNEL Macro APIs ****************************************************/
    public static HMODULE GetInstanceModule(HINSTANCE hInstance) => (HMODULE)(hInstance);

    public static HWND GetLastSibling(HWND hwnd) => GetWindow(hwnd, GW_HWNDLAST);

    public static HWND GetNextSibling(HWND hwnd) => GetWindow(hwnd, GW_HWNDNEXT);

    public static HWND GetPrevSibling(HWND hwnd) => GetWindow(hwnd, GW_HWNDPREV);

    public static HBRUSH GetStockBrush(int i) => ((HBRUSH)GetStockObject(i));

    public static HFONT GetStockFont(int i) => ((HFONT)GetStockObject(i));

    public static HPEN GetStockPen(int i) => ((HPEN)GetStockObject(i));

    public static uint GetWindowExStyle(HWND hwnd) => ((uint)GetWindowLong(hwnd, GWL_EXSTYLE));

    public static HFONT GetWindowFont(HWND hwnd) => FORWARD_WM_GETFONT((hwnd), SNDMSG);

    public static int GetWindowID(HWND hwnd) => GetDlgCtrlID(hwnd);

    /****** USER Macro APIs ******************************************************/
    public static HMODULE GetWindowInstance(HWND hwnd) =>
        ((HMODULE)GetWindowLongPtr(hwnd, GWLP_HINSTANCE));

    public static HWND GetWindowOwner(HWND hwnd) => GetWindow(hwnd, GW_OWNER);

    public static uint GetWindowStyle(HWND hwnd) => ((uint)GetWindowLong(hwnd, GWL_STYLE));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr GlobalAllocPtr(uint flags, nuint cb) => (void*)GlobalAllocPtrRaw(flags, cb);

    public static void* GlobalAllocPtrRaw(uint flags, nuint cb) =>
        (GlobalLockRaw(GlobalAlloc((flags), (cb))));

    public static BOOL GlobalFreePtr(void* lp)
    {
        _ = GlobalUnlockPtr(lp);
        return (BOOL)(nuint)GlobalFree(GlobalPtrHandle(lp));
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<BOOL> GlobalFreePtr(Ref lp)
    {
        fixed (void* __dsl_lp = lp)
        {
            return (MaybeBool<BOOL>)(BOOL)GlobalFreePtr(__dsl_lp);
        }
    }

    public static BOOL GlobalLockPtr(void* lp) => (BOOL)(nuint)GlobalLockRaw(GlobalPtrHandle(lp));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<BOOL> GlobalLockPtr(Ref lp)
    {
        fixed (void* __dsl_lp = lp)
        {
            return (MaybeBool<BOOL>)(BOOL)GlobalLockPtr(__dsl_lp);
        }
    }

    public static HGLOBAL GlobalPtrHandle(void* lp) => ((HGLOBAL)GlobalHandle(lp));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HGLOBAL GlobalPtrHandle(Ref lp)
    {
        fixed (void* __dsl_lp = lp)
        {
            return (HGLOBAL)GlobalPtrHandle(__dsl_lp);
        }
    }

    public static BOOL GlobalReAllocPtr(void* lp, nuint cbNew, uint flags)
    {
        _ = GlobalUnlockPtr(lp);
        return (BOOL)(nuint)GlobalLockRaw(GlobalReAlloc(GlobalPtrHandle(lp), (cbNew), (flags)));
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<BOOL> GlobalReAllocPtr(Ref lp, nuint cbNew, uint flags)
    {
        fixed (void* __dsl_lp = lp)
        {
            return (MaybeBool<BOOL>)(BOOL)GlobalReAllocPtr(__dsl_lp, cbNew, flags);
        }
    }

    public static BOOL GlobalUnlockPtr(void* lp) => GlobalUnlockRaw(GlobalPtrHandle(lp));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<BOOL> GlobalUnlockPtr(Ref lp)
    {
        fixed (void* __dsl_lp = lp)
        {
            return (MaybeBool<BOOL>)(BOOL)GlobalUnlockPtr(__dsl_lp);
        }
    }

    /* void Cls_OnActivate(HWND hwnd, UINT state, HWND hwndActDeact, BOOL fMinimized) */
    public static LRESULT HANDLE_WM_ACTIVATE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, uint, HWND, BOOL, void> fn
    )
    {
        fn((hwnd), (uint)LOWORD(wParam), (HWND)(lParam), (BOOL)HIWORD(wParam));
        return 0;
    }

    /* void Cls_OnActivateApp(HWND hwnd, BOOL fActivate, DWORD dwThreadId) */
    public static LRESULT HANDLE_WM_ACTIVATEAPP(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, BOOL, uint, void> fn
    )
    {
        fn((hwnd), (BOOL)(wParam), (uint)(lParam));
        return 0;
    }

    /* void Cls_OnAskCBFormatName(HWND hwnd, int cchMax, LPTSTR rgchName) */
    public static LRESULT HANDLE_WM_ASKCBFORMATNAME(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, int, char*, void> fn
    )
    {
        fn((hwnd), (int)(wParam), (char*)(lParam));
        return 0;
    }

    /* void Cls_OnCancelMode(HWND hwnd) */
    public static LRESULT HANDLE_WM_CANCELMODE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* void Cls_OnChangeCBChain(HWND hwnd, HWND hwndRemove, HWND hwndNext) */
    public static LRESULT HANDLE_WM_CHANGECBCHAIN(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HWND, HWND, void> fn
    )
    {
        fn((hwnd), (HWND)(wParam), (HWND)(lParam));
        return 0;
    }

    /* void Cls_OnChar(HWND hwnd, TCHAR ch, int cRepeat) */
    public static LRESULT HANDLE_WM_CHAR(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, ushort, int, void> fn
    )
    {
        fn((hwnd), (ushort)(wParam), (int)(short)LOWORD(lParam));
        return 0;
    }

    /* int Cls_OnCharToItem(HWND hwnd, UINT ch, HWND hwndListbox, int iCaret) */
    public static LRESULT HANDLE_WM_CHARTOITEM(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, uint, HWND, int, int> fn
    ) =>
        (LRESULT)
            (uint)(int)fn((hwnd), (uint)LOWORD(wParam), (HWND)(lParam), (int)(short)HIWORD(wParam));

    /* void Cls_OnChildActivate(HWND hwnd) */
    public static LRESULT HANDLE_WM_CHILDACTIVATE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* void Cls_OnClear(HWND hwnd) */
    public static LRESULT HANDLE_WM_CLEAR(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* void Cls_OnClose(HWND hwnd) */
    public static LRESULT HANDLE_WM_CLOSE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* void Cls_OnCommand(HWND hwnd, int id, HWND hwndCtl, UINT codeNotify) */
    public static LRESULT HANDLE_WM_COMMAND(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, int, HWND, uint, void> fn
    )
    {
        fn((hwnd), (int)(LOWORD(wParam)), (HWND)(lParam), (uint)HIWORD(wParam));
        return 0;
    }

    /* void Cls_OnCommNotify(HWND hwnd, int cid, UINT flags) */
    public static LRESULT HANDLE_WM_COMMNOTIFY(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, int, uint, void> fn
    )
    {
        fn((hwnd), (int)(wParam), (uint)LOWORD(lParam));
        return 0;
    }

    /****** Message crackers ****************************************************/
    /* void Cls_OnCompacting(HWND hwnd, UINT compactRatio) */
    public static LRESULT HANDLE_WM_COMPACTING(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, uint, void> fn
    )
    {
        fn((hwnd), (uint)(wParam));
        return 0;
    }

    /* int Cls_OnCompareItem(HWND hwnd, const COMPAREITEMSTRUCT * lpCompareItem) */
    public static LRESULT HANDLE_WM_COMPAREITEM(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, COMPAREITEMSTRUCT*, int> fn
    ) => (LRESULT)(uint)(int)fn((hwnd), (COMPAREITEMSTRUCT*)(lParam));

    /* void Cls_OnContextMenu(HWND hwnd, HWND hwndContext, UINT xPos, UINT yPos) */
    public static LRESULT HANDLE_WM_CONTEXTMENU(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HWND, uint, uint, void> fn
    )
    {
        fn(
            (hwnd),
            (HWND)(wParam),
            (uint)(int)(short)LOWORD(lParam),
            (uint)(int)(short)HIWORD(lParam)
        );
        return 0;
    }

    /* void Cls_OnCopy(HWND hwnd) */
    public static LRESULT HANDLE_WM_COPY(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    public static LRESULT HANDLE_WM_COPYDATA(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HWND, COPYDATASTRUCT*, BOOL> fn
    )
    {
        _ = fn((hwnd), (HWND)(wParam), (COPYDATASTRUCT*)lParam);
        return 0;
    }

    /* BOOL Cls_OnCreate(HWND hwnd, LPCREATESTRUCT lpCreateStruct) */
    public static LRESULT HANDLE_WM_CREATE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, CREATESTRUCTW*, BOOL> fn
    ) => fn((hwnd), (CREATESTRUCTW*)(lParam)) ? 0 : (LRESULT)(-1);

    public static LRESULT HANDLE_WM_CTLCOLORBTN(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HDC, HWND, int, HBRUSH> fn
    ) => (LRESULT)(nuint)(HBRUSH)fn((hwnd), (HDC)(wParam), (HWND)(lParam), CTLCOLOR_BTN);

    public static LRESULT HANDLE_WM_CTLCOLORDLG(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HDC, HWND, int, HBRUSH> fn
    ) => (LRESULT)(nuint)(HBRUSH)fn((hwnd), (HDC)(wParam), (HWND)(lParam), CTLCOLOR_DLG);

    public static LRESULT HANDLE_WM_CTLCOLOREDIT(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HDC, HWND, int, HBRUSH> fn
    ) => (LRESULT)(nuint)(HBRUSH)fn((hwnd), (HDC)(wParam), (HWND)(lParam), CTLCOLOR_EDIT);

    public static LRESULT HANDLE_WM_CTLCOLORLISTBOX(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HDC, HWND, int, HBRUSH> fn
    ) => (LRESULT)(nuint)(HBRUSH)fn((hwnd), (HDC)(wParam), (HWND)(lParam), CTLCOLOR_LISTBOX);

    /* HBRUSH Cls_OnCtlColor(HWND hwnd, HDC hdc, HWND hwndChild, int type) */
    public static LRESULT HANDLE_WM_CTLCOLORMSGBOX(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HDC, HWND, int, HBRUSH> fn
    ) => (LRESULT)(nuint)(HBRUSH)fn((hwnd), (HDC)(wParam), (HWND)(lParam), CTLCOLOR_MSGBOX);

    public static LRESULT HANDLE_WM_CTLCOLORSCROLLBAR(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HDC, HWND, int, HBRUSH> fn
    ) => (LRESULT)(nuint)(HBRUSH)fn((hwnd), (HDC)(wParam), (HWND)(lParam), CTLCOLOR_SCROLLBAR);

    public static LRESULT HANDLE_WM_CTLCOLORSTATIC(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HDC, HWND, int, HBRUSH> fn
    ) => (LRESULT)(nuint)(HBRUSH)fn((hwnd), (HDC)(wParam), (HWND)(lParam), CTLCOLOR_STATIC);

    /* void Cls_OnCut(HWND hwnd) */
    public static LRESULT HANDLE_WM_CUT(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* void Cls_OnDeadChar(HWND hwnd, TCHAR ch, int cRepeat) */
    public static LRESULT HANDLE_WM_DEADCHAR(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, ushort, int, void> fn
    )
    {
        fn((hwnd), (ushort)(wParam), (int)(short)LOWORD(lParam));
        return 0;
    }

    /* void Cls_OnDeleteItem(HWND hwnd, const DELETEITEMSTRUCT * lpDeleteItem) */
    public static LRESULT HANDLE_WM_DELETEITEM(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, DELETEITEMSTRUCT*, void> fn
    )
    {
        fn((hwnd), (DELETEITEMSTRUCT*)(lParam));
        return 0;
    }

    /* void Cls_OnDestroy(HWND hwnd) */
    public static LRESULT HANDLE_WM_DESTROY(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* void Cls_OnDestroyClipboard(HWND hwnd) */
    public static LRESULT HANDLE_WM_DESTROYCLIPBOARD(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* BOOL Cls_OnDeviceChange(HWND hwnd, UINT uEvent, DWORD dwEventData) */
    public static LRESULT HANDLE_WM_DEVICECHANGE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, uint, uint, BOOL> fn
    ) => (LRESULT)(uint)(BOOL)fn((hwnd), (uint)(wParam), (uint)(lParam));

    /* void Cls_OnDevModeChange(HWND hwnd, LPCTSTR lpszDeviceName) */
    public static LRESULT HANDLE_WM_DEVMODECHANGE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, char*, void> fn
    )
    {
        fn((hwnd), (char*)(lParam));
        return 0;
    }

    /* void Cls_OnDisplayChange(HWND hwnd, UINT bitsPerPixel, UINT cxScreen, UINT cyScreen) */
    public static LRESULT HANDLE_WM_DISPLAYCHANGE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, uint, uint, uint, void> fn
    )
    {
        fn((hwnd), (uint)(wParam), (uint)LOWORD(lParam), (uint)HIWORD(lParam));
        return 0;
    }

    /* void Cls_OnDrawClipboard(HWND hwnd) */
    public static LRESULT HANDLE_WM_DRAWCLIPBOARD(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* void Cls_OnDrawItem(HWND hwnd, const DRAWITEMSTRUCT * lpDrawItem) */
    public static LRESULT HANDLE_WM_DRAWITEM(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, DRAWITEMSTRUCT*, void> fn
    )
    {
        fn((hwnd), (DRAWITEMSTRUCT*)(lParam));
        return 0;
    }

    /* void Cls_OnDropFiles(HWND hwnd, HDROP hdrop) */
    public static LRESULT HANDLE_WM_DROPFILES(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HDROP, void> fn
    )
    {
        fn((hwnd), (HDROP)(wParam));
        return 0;
    }

    /* void Cls_OnEnable(HWND hwnd, BOOL fEnable) */
    public static LRESULT HANDLE_WM_ENABLE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, BOOL, void> fn
    )
    {
        fn((hwnd), (BOOL)(wParam));
        return 0;
    }

    /* void Cls_OnEndSession(HWND hwnd, BOOL fEnding) */
    public static LRESULT HANDLE_WM_ENDSESSION(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, BOOL, void> fn
    )
    {
        fn((hwnd), (BOOL)(wParam));
        return 0;
    }

    /* void Cls_OnEnterIdle(HWND hwnd, UINT source, HWND hwndSource) */
    public static LRESULT HANDLE_WM_ENTERIDLE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, uint, HWND, void> fn
    )
    {
        fn((hwnd), (uint)(wParam), (HWND)(lParam));
        return 0;
    }

    /* BOOL Cls_OnEraseBkgnd(HWND hwnd, HDC hdc) */
    public static LRESULT HANDLE_WM_ERASEBKGND(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HDC, BOOL> fn
    ) => (LRESULT)(uint)(BOOL)fn((hwnd), (HDC)(wParam));

    /* void Cls_OnFontChange(HWND hwnd) */
    public static LRESULT HANDLE_WM_FONTCHANGE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* UINT Cls_OnGetDlgCode(HWND hwnd, LPMSG lpmsg) */
    public static LRESULT HANDLE_WM_GETDLGCODE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, MSG*, uint> fn
    ) => (LRESULT)(uint)(uint)fn(hwnd, (MSG*)(lParam));

    /* HFONT Cls_OnGetFont(HWND hwnd) */
    public static LRESULT HANDLE_WM_GETFONT(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HFONT> fn
    ) => (LRESULT)(nuint)(HFONT)fn(hwnd);

    /* void Cls_OnGetMinMaxInfo(HWND hwnd, LPMINMAXINFO lpMinMaxInfo) */
    public static LRESULT HANDLE_WM_GETMINMAXINFO(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, MINMAXINFO*, void> fn
    )
    {
        fn((hwnd), (MINMAXINFO*)(lParam));
        return 0;
    }

    /* INT Cls_OnGetText(HWND hwnd, int cchTextMax, LPTSTR lpszText) */
    public static LRESULT HANDLE_WM_GETTEXT(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, int, char*, int> fn
    ) => (LRESULT)(uint)(int)fn((hwnd), (int)(wParam), (char*)(lParam));

    /* INT Cls_OnGetTextLength(HWND hwnd) */
    public static LRESULT HANDLE_WM_GETTEXTLENGTH(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, int> fn
    ) => (LRESULT)(uint)(int)fn(hwnd);

    /* void Cls_OnHotKey(HWND hwnd, int idHotKey, UINT fuModifiers, UINT vk) */
    public static LRESULT HANDLE_WM_HOTKEY(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, int, uint, uint, void> fn
    )
    {
        fn((hwnd), (int)(wParam), (uint)LOWORD(lParam), (uint)HIWORD(lParam));
        return 0;
    }

    /* void Cls_OnHScroll(HWND hwnd, HWND hwndCtl, UINT code, int pos) */
    public static LRESULT HANDLE_WM_HSCROLL(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HWND, uint, int, void> fn
    )
    {
        fn((hwnd), (HWND)(lParam), (uint)(LOWORD(wParam)), (int)(short)HIWORD(wParam));
        return 0;
    }

    /* void Cls_OnHScrollClipboard(HWND hwnd, HWND hwndCBViewer, UINT code, int pos) */
    public static LRESULT HANDLE_WM_HSCROLLCLIPBOARD(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HWND, uint, int, void> fn
    )
    {
        fn((hwnd), (HWND)(wParam), (uint)LOWORD(lParam), (int)(short)HIWORD(lParam));
        return 0;
    }

    /* BOOL Cls_OnIconEraseBkgnd(HWND hwnd, HDC hdc) */
    public static LRESULT HANDLE_WM_ICONERASEBKGND(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HDC, BOOL> fn
    ) => (LRESULT)(uint)(BOOL)fn((hwnd), (HDC)(wParam));

    /* BOOL Cls_OnInitDialog(HWND hwnd, HWND hwndFocus, LPARAM lParam) */
    public static LRESULT HANDLE_WM_INITDIALOG(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HWND, LPARAM, BOOL> fn
    ) => (LRESULT)(uint)(uint)(BOOL)fn((hwnd), (HWND)(wParam), lParam);

    /* void Cls_OnInitMenu(HWND hwnd, HMENU hMenu) */
    public static LRESULT HANDLE_WM_INITMENU(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HMENU, void> fn
    )
    {
        fn((hwnd), (HMENU)(wParam));
        return 0;
    }

    /* void Cls_OnInitMenuPopup(HWND hwnd, HMENU hMenu, UINT item, BOOL fSystemMenu) */
    public static LRESULT HANDLE_WM_INITMENUPOPUP(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HMENU, uint, BOOL, void> fn
    )
    {
        fn((hwnd), (HMENU)(wParam), (uint)LOWORD(lParam), (BOOL)HIWORD(lParam));
        return 0;
    }

    /* void Cls_OnKey(HWND hwnd, UINT vk, BOOL fDown, int cRepeat, UINT flags) */
    public static LRESULT HANDLE_WM_KEYDOWN(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, uint, BOOL, int, uint, void> fn
    )
    {
        fn((hwnd), (uint)(wParam), TRUE, (int)(short)LOWORD(lParam), (uint)HIWORD(lParam));
        return 0;
    }

    /* void Cls_OnKey(HWND hwnd, UINT vk, BOOL fDown, int cRepeat, UINT flags) */
    public static LRESULT HANDLE_WM_KEYUP(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, uint, BOOL, int, uint, void> fn
    )
    {
        fn((hwnd), (uint)(wParam), FALSE, (int)(short)LOWORD(lParam), (uint)HIWORD(lParam));
        return 0;
    }

    /* void Cls_OnKillFocus(HWND hwnd, HWND hwndNewFocus) */
    public static LRESULT HANDLE_WM_KILLFOCUS(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HWND, void> fn
    )
    {
        fn((hwnd), (HWND)(wParam));
        return 0;
    }

    /* void Cls_OnLButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT keyFlags) */
    public static LRESULT HANDLE_WM_LBUTTONDBLCLK(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, BOOL, int, int, uint, void> fn
    )
    {
        fn((hwnd), TRUE, (int)(short)LOWORD(lParam), (int)(short)HIWORD(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnLButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT keyFlags) */
    public static LRESULT HANDLE_WM_LBUTTONDOWN(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, BOOL, int, int, uint, void> fn
    )
    {
        fn((hwnd), FALSE, (int)(short)LOWORD(lParam), (int)(short)HIWORD(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnLButtonUp(HWND hwnd, int x, int y, UINT keyFlags) */
    public static LRESULT HANDLE_WM_LBUTTONUP(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, int, int, uint, void> fn
    )
    {
        fn((hwnd), (int)(short)LOWORD(lParam), (int)(short)HIWORD(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnMButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT keyFlags) */
    public static LRESULT HANDLE_WM_MBUTTONDBLCLK(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, BOOL, int, int, uint, void> fn
    )
    {
        fn((hwnd), TRUE, (int)(short)LOWORD(lParam), (int)(short)HIWORD(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnMButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT keyFlags) */
    public static LRESULT HANDLE_WM_MBUTTONDOWN(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, BOOL, int, int, uint, void> fn
    )
    {
        fn((hwnd), FALSE, (int)(short)LOWORD(lParam), (int)(short)HIWORD(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnMButtonUp(HWND hwnd, int x, int y, UINT flags) */
    public static LRESULT HANDLE_WM_MBUTTONUP(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, int, int, uint, void> fn
    )
    {
        fn((hwnd), (int)(short)LOWORD(lParam), (int)(short)HIWORD(lParam), (uint)(wParam));
        return 0;
    }

    /* NOTE: Usable only by MDI client windows */
    /* void Cls_MDIActivate(HWND hwnd, BOOL fActive, HWND hwndActivate, HWND hwndDeactivate) */
    public static LRESULT HANDLE_WM_MDIACTIVATE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, BOOL, HWND, HWND, void> fn
    )
    {
        fn((hwnd), (BOOL)(lParam == (LPARAM)hwnd), (HWND)(lParam), (HWND)(wParam));
        return 0;
    }

    /* BOOL Cls_MDICascade(HWND hwnd, UINT cmd) */
    public static LRESULT HANDLE_WM_MDICASCADE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, uint, BOOL> fn
    ) => (LRESULT)(uint)fn((hwnd), (uint)(wParam));

    /* HWND Cls_MDICreate(HWND hwnd, const LPMDICREATESTRUCT lpmcs) */
    public static LRESULT HANDLE_WM_MDICREATE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, MDICREATESTRUCTW*, HWND> fn
    ) => (LRESULT)(uint)(uint)fn((hwnd), (MDICREATESTRUCTW*)(lParam));

    /* void Cls_MDIDestroy(HWND hwnd, HWND hwndDestroy) */
    public static LRESULT HANDLE_WM_MDIDESTROY(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HWND, void> fn
    )
    {
        fn((hwnd), (HWND)(wParam));
        return 0;
    }

    /* HWND Cls_MDIGetActive(HWND hwnd) */
    public static LRESULT HANDLE_WM_MDIGETACTIVE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HWND> fn
    ) => (LRESULT)(nuint)fn(hwnd);

    /* void Cls_MDIIconArrange(HWND hwnd) */
    public static LRESULT HANDLE_WM_MDIICONARRANGE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* void Cls_MDIMaximize(HWND hwnd, HWND hwndMaximize) */
    public static LRESULT HANDLE_WM_MDIMAXIMIZE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HWND, void> fn
    )
    {
        fn((hwnd), (HWND)(wParam));
        return 0;
    }

    /* HWND Cls_MDINext(HWND hwnd, HWND hwndCur, BOOL fPrev) */
    public static LRESULT HANDLE_WM_MDINEXT(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HWND, BOOL, HWND> fn
    ) => (LRESULT)(HWND)fn((hwnd), (HWND)(wParam), (BOOL)lParam);

    /* void Cls_MDIRestore(HWND hwnd, HWND hwndRestore) */
    public static LRESULT HANDLE_WM_MDIRESTORE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HWND, void> fn
    )
    {
        fn((hwnd), (HWND)(wParam));
        return 0;
    }

    /* HMENU Cls_MDISetMenu(HWND hwnd, BOOL fRefresh, HMENU hmenuFrame, HMENU hmenuWindow) */
    public static LRESULT HANDLE_WM_MDISETMENU(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, BOOL, HMENU, HMENU, HMENU> fn
    ) => (LRESULT)(nuint)fn((hwnd), (BOOL)(wParam), (HMENU)(wParam), (HMENU)(lParam));

    /* BOOL Cls_MDITile(HWND hwnd, UINT cmd) */
    public static LRESULT HANDLE_WM_MDITILE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, uint, BOOL> fn
    ) => (LRESULT)(uint)fn((hwnd), (uint)(wParam));

    /* void Cls_OnMeasureItem(HWND hwnd, MEASUREITEMSTRUCT * lpMeasureItem) */
    public static LRESULT HANDLE_WM_MEASUREITEM(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, MEASUREITEMSTRUCT*, void> fn
    )
    {
        fn((hwnd), (MEASUREITEMSTRUCT*)(lParam));
        return 0;
    }

    /* DWORD Cls_OnMenuChar(HWND hwnd, UINT ch, UINT flags, HMENU hmenu) */
    public static LRESULT HANDLE_WM_MENUCHAR(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, uint, uint, HMENU, uint> fn
    ) => (LRESULT)(uint)fn((hwnd), (uint)(LOWORD(wParam)), (uint)HIWORD(wParam), (HMENU)(lParam));

    /* void Cls_OnMenuSelect(HWND hwnd, HMENU hmenu, int item, HMENU hmenuPopup, UINT flags) */
    public static LRESULT HANDLE_WM_MENUSELECT(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HMENU, int, HMENU, uint, void> fn
    )
    {
        fn(
            (hwnd),
            (HMENU)(lParam),
            ((HIWORD(wParam) & MF_POPUP) != 0) ? 0 : (int)(LOWORD(wParam)),
            ((HIWORD(wParam) & MF_POPUP) != 0)
                ? GetSubMenu((HMENU)lParam, LOWORD(wParam))
                : HMENU.NULL,
            (uint)(((short)HIWORD(wParam) == -1) ? 0xFFFFFFFF : HIWORD(wParam))
        );
        return 0;
    }

    /* int Cls_OnMouseActivate(HWND hwnd, HWND hwndTopLevel, UINT codeHitTest, UINT msg) */
    public static LRESULT HANDLE_WM_MOUSEACTIVATE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HWND, uint, uint, int> fn
    ) => (LRESULT)(uint)(int)fn((hwnd), (HWND)(wParam), (uint)LOWORD(lParam), (uint)HIWORD(lParam));

    /* void Cls_OnMouseMove(HWND hwnd, int x, int y, UINT keyFlags) */
    public static LRESULT HANDLE_WM_MOUSEMOVE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, int, int, uint, void> fn
    )
    {
        fn((hwnd), (int)(short)LOWORD(lParam), (int)(short)HIWORD(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnMouseWheel(HWND hwnd, int xPos, int yPos, int zDelta, UINT fwKeys) */
    public static LRESULT HANDLE_WM_MOUSEWHEEL(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, int, int, int, uint, void> fn
    )
    {
        fn(
            (hwnd),
            (int)(short)LOWORD(lParam),
            (int)(short)HIWORD(lParam),
            (int)(short)HIWORD(wParam),
            (uint)(short)LOWORD(wParam)
        );
        return 0;
    }

    /* void Cls_OnMove(HWND hwnd, int x, int y) */
    public static LRESULT HANDLE_WM_MOVE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, int, int, void> fn
    )
    {
        fn((hwnd), (int)(short)LOWORD(lParam), (int)(short)HIWORD(lParam));
        return 0;
    }

    /* BOOL Cls_OnNCActivate(HWND hwnd, BOOL fActive, HWND hwndActDeact, BOOL fMinimized) */
    public static LRESULT HANDLE_WM_NCACTIVATE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, BOOL, HWND, BOOL, BOOL> fn
    ) => (LRESULT)(uint)(BOOL)fn((hwnd), (BOOL)(wParam), HWND.NULL, 0);

    /* UINT Cls_OnNCCalcSize(HWND hwnd, BOOL fCalcValidRects, NCCALCSIZE_PARAMS * lpcsp) */
    public static LRESULT HANDLE_WM_NCCALCSIZE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, BOOL, NCCALCSIZE_PARAMS*, uint> fn
    ) => (LRESULT)(uint)(uint)fn((hwnd), (BOOL)(wParam), (NCCALCSIZE_PARAMS*)(lParam));

    /* BOOL Cls_OnNCCreate(HWND hwnd, LPCREATESTRUCT lpCreateStruct) */
    public static LRESULT HANDLE_WM_NCCREATE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, CREATESTRUCTW*, BOOL> fn
    ) => (LRESULT)(uint)(BOOL)fn((hwnd), (CREATESTRUCTW*)(lParam));

    /* void Cls_OnNCDestroy(HWND hwnd) */
    public static LRESULT HANDLE_WM_NCDESTROY(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* UINT Cls_OnNCHitTest(HWND hwnd, int x, int y) */
    public static LRESULT HANDLE_WM_NCHITTEST(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, int, int, uint> fn
    ) => (LRESULT)(uint)(uint)fn((hwnd), (int)(short)LOWORD(lParam), (int)(short)HIWORD(lParam));

    /* void Cls_OnNCLButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT codeHitTest) */
    public static LRESULT HANDLE_WM_NCLBUTTONDBLCLK(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, BOOL, int, int, uint, void> fn
    )
    {
        fn((hwnd), TRUE, (int)(short)LOWORD(lParam), (int)(short)HIWORD(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnNCLButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT codeHitTest) */
    public static LRESULT HANDLE_WM_NCLBUTTONDOWN(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, BOOL, int, int, uint, void> fn
    )
    {
        fn((hwnd), FALSE, (int)(short)LOWORD(lParam), (int)(short)HIWORD(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnNCLButtonUp(HWND hwnd, int x, int y, UINT codeHitTest) */
    public static LRESULT HANDLE_WM_NCLBUTTONUP(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, int, int, uint, void> fn
    )
    {
        fn((hwnd), (int)(short)LOWORD(lParam), (int)(short)HIWORD(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnNCMButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT codeHitTest) */
    public static LRESULT HANDLE_WM_NCMBUTTONDBLCLK(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, BOOL, int, int, uint, void> fn
    )
    {
        fn((hwnd), TRUE, (int)(short)LOWORD(lParam), (int)(short)HIWORD(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnNCMButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT codeHitTest) */
    public static LRESULT HANDLE_WM_NCMBUTTONDOWN(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, BOOL, int, int, uint, void> fn
    )
    {
        fn((hwnd), FALSE, (int)(short)LOWORD(lParam), (int)(short)HIWORD(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnNCMButtonUp(HWND hwnd, int x, int y, UINT codeHitTest) */
    public static LRESULT HANDLE_WM_NCMBUTTONUP(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, int, int, uint, void> fn
    )
    {
        fn((hwnd), (int)(short)LOWORD(lParam), (int)(short)HIWORD(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnNCMouseMove(HWND hwnd, int x, int y, UINT codeHitTest) */
    public static LRESULT HANDLE_WM_NCMOUSEMOVE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, int, int, uint, void> fn
    )
    {
        fn((hwnd), (int)(short)LOWORD(lParam), (int)(short)HIWORD(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnNCPaint(HWND hwnd, HRGN hrgn) */
    public static LRESULT HANDLE_WM_NCPAINT(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HRGN, void> fn
    )
    {
        fn((hwnd), (HRGN)(wParam));
        return 0;
    }

    /* void Cls_OnNCRButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT codeHitTest) */
    public static LRESULT HANDLE_WM_NCRBUTTONDBLCLK(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, BOOL, int, int, uint, void> fn
    )
    {
        fn((hwnd), TRUE, (int)(short)LOWORD(lParam), (int)(short)HIWORD(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnNCRButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT codeHitTest) */
    public static LRESULT HANDLE_WM_NCRBUTTONDOWN(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, BOOL, int, int, uint, void> fn
    )
    {
        fn((hwnd), FALSE, (int)(short)LOWORD(lParam), (int)(short)HIWORD(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnNCRButtonUp(HWND hwnd, int x, int y, UINT codeHitTest) */
    public static LRESULT HANDLE_WM_NCRBUTTONUP(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, int, int, uint, void> fn
    )
    {
        fn((hwnd), (int)(short)LOWORD(lParam), (int)(short)HIWORD(lParam), (uint)(wParam));
        return 0;
    }

    /* HWND Cls_OnNextDlgCtl(HWND hwnd, HWND hwndSetFocus, BOOL fNext) */
    public static LRESULT HANDLE_WM_NEXTDLGCTL(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HWND, BOOL, HWND> fn
    ) => (LRESULT)(nuint)(HWND)fn((hwnd), (HWND)(wParam), (BOOL)(lParam));

    /* void Cls_OnPaint(HWND hwnd) */
    public static LRESULT HANDLE_WM_PAINT(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* void Cls_OnPaintClipboard(HWND hwnd, HWND hwndCBViewer, const LPPAINTSTRUCT lpPaintStruct) */
    public static LRESULT HANDLE_WM_PAINTCLIPBOARD(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HWND, PAINTSTRUCT*, void> fn
    )
    {
        fn((hwnd), (HWND)(wParam), (PAINTSTRUCT*)GlobalLockRaw((HGLOBAL)(lParam)));
        _ = GlobalUnlockRaw((HGLOBAL)(lParam));
        return 0;
    }

    /* void Cls_OnPaletteChanged(HWND hwnd, HWND hwndPaletteChange) */
    public static LRESULT HANDLE_WM_PALETTECHANGED(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HWND, void> fn
    )
    {
        fn((hwnd), (HWND)(wParam));
        return 0;
    }

    /* void Cls_OnPaletteIsChanging(HWND hwnd, HWND hwndPaletteChange) */
    public static LRESULT HANDLE_WM_PALETTEISCHANGING(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HWND, void> fn
    )
    {
        fn((hwnd), (HWND)(wParam));
        return 0;
    }

    /* void Cls_OnParentNotify(HWND hwnd, UINT msg, HWND hwndChild, int idChild) */
    public static LRESULT HANDLE_WM_PARENTNOTIFY(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, uint, HWND, int, void> fn
    )
    {
        fn((hwnd), (uint)LOWORD(wParam), (HWND)(lParam), (int)(uint)HIWORD(wParam));
        return 0;
    }

    /* void Cls_OnPaste(HWND hwnd) */
    public static LRESULT HANDLE_WM_PASTE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* void Cls_OnPower(HWND hwnd, int code) */
    public static LRESULT HANDLE_WM_POWER(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, int, void> fn
    )
    {
        fn((hwnd), (int)(wParam));
        return 0;
    }

    /* HICON Cls_OnQueryDragIcon(HWND hwnd) */
    public static LRESULT HANDLE_WM_QUERYDRAGICON(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HICON> fn
    ) => (LRESULT)(uint)(uint)fn(hwnd);

    /* BOOL Cls_OnQueryEndSession(HWND hwnd) */
    public static LRESULT HANDLE_WM_QUERYENDSESSION(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, BOOL> fn
    ) => MAKELRESULT((ushort)(BOOL)fn(hwnd), 0);

    /* BOOL Cls_OnQueryNewPalette(HWND hwnd) */
    public static LRESULT HANDLE_WM_QUERYNEWPALETTE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, BOOL> fn
    ) => MAKELRESULT((ushort)(BOOL)fn(hwnd), 0);

    /* BOOL Cls_OnQueryOpen(HWND hwnd) */
    public static LRESULT HANDLE_WM_QUERYOPEN(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, BOOL> fn
    ) => MAKELRESULT((BOOL)fn(hwnd), 0);

    /* void Cls_OnQueueSync(HWND hwnd) */
    public static LRESULT HANDLE_WM_QUEUESYNC(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* void Cls_OnQuit(HWND hwnd, int exitCode) */
    public static LRESULT HANDLE_WM_QUIT(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, int, void> fn
    )
    {
        fn((hwnd), (int)(wParam));
        return 0;
    }

    /* void Cls_OnRButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT keyFlags) */
    public static LRESULT HANDLE_WM_RBUTTONDBLCLK(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, BOOL, int, int, uint, void> fn
    )
    {
        fn((hwnd), TRUE, (int)(short)LOWORD(lParam), (int)(short)HIWORD(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnRButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT keyFlags) */
    public static LRESULT HANDLE_WM_RBUTTONDOWN(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, BOOL, int, int, uint, void> fn
    )
    {
        fn((hwnd), FALSE, (int)(short)LOWORD(lParam), (int)(short)HIWORD(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnRButtonUp(HWND hwnd, int x, int y, UINT flags) */
    public static LRESULT HANDLE_WM_RBUTTONUP(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, int, int, uint, void> fn
    )
    {
        fn((hwnd), (int)(short)LOWORD(lParam), (int)(short)HIWORD(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnRenderAllFormats(HWND hwnd) */
    public static LRESULT HANDLE_WM_RENDERALLFORMATS(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* HANDLE Cls_OnRenderFormat(HWND hwnd, UINT fmt) */
    public static LRESULT HANDLE_WM_RENDERFORMAT(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, uint, HANDLE> fn
    ) => (LRESULT)(nuint)(HANDLE)fn((hwnd), (uint)(wParam));

    /* BOOL Cls_OnSetCursor(HWND hwnd, HWND hwndCursor, UINT codeHitTest, UINT msg) */
    public static LRESULT HANDLE_WM_SETCURSOR(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HWND, uint, uint, BOOL> fn
    ) =>
        (LRESULT)(uint)(BOOL)fn((hwnd), (HWND)(wParam), (uint)LOWORD(lParam), (uint)HIWORD(lParam));

    /* void Cls_OnSetFocus(HWND hwnd, HWND hwndOldFocus) */
    public static LRESULT HANDLE_WM_SETFOCUS(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HWND, void> fn
    )
    {
        fn((hwnd), (HWND)(wParam));
        return 0;
    }

    /* void Cls_OnSetFont(HWND hwndCtl, HFONT hfont, BOOL fRedraw) */
    public static LRESULT HANDLE_WM_SETFONT(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HFONT, BOOL, void> fn
    )
    {
        fn((hwnd), (HFONT)(wParam), (BOOL)(lParam));
        return 0;
    }

    /* void Cls_OnSetRedraw(HWND hwnd, BOOL fRedraw) */
    public static LRESULT HANDLE_WM_SETREDRAW(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, BOOL, void> fn
    )
    {
        fn((hwnd), (BOOL)(wParam));
        return 0;
    }

    /* void Cls_OnSetText(HWND hwnd, LPCTSTR lpszText) */
    public static LRESULT HANDLE_WM_SETTEXT(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, char*, void> fn
    )
    {
        fn((hwnd), (char*)(lParam));
        return 0;
    }

    /* void Cls_OnShowWindow(HWND hwnd, BOOL fShow, UINT status) */
    public static LRESULT HANDLE_WM_SHOWWINDOW(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, BOOL, uint, void> fn
    )
    {
        fn((hwnd), (BOOL)(wParam), (uint)(lParam));
        return 0;
    }

    /* void Cls_OnSize(HWND hwnd, UINT state, int cx, int cy) */
    public static LRESULT HANDLE_WM_SIZE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, uint, int, int, void> fn
    )
    {
        fn((hwnd), (uint)(wParam), (int)(short)LOWORD(lParam), (int)(short)HIWORD(lParam));
        return 0;
    }

    /* void Cls_OnSizeClipboard(HWND hwnd, HWND hwndCBViewer, const LPRECT lprc) */
    public static LRESULT HANDLE_WM_SIZECLIPBOARD(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HWND, RECT*, void> fn
    )
    {
        fn((hwnd), (HWND)(wParam), (RECT*)GlobalLockRaw((HGLOBAL)(lParam)));
        _ = GlobalUnlockRaw((HGLOBAL)(lParam));
        return 0;
    }

    /* void Cls_OnSpoolerStatus(HWND hwnd, UINT status, int cJobInQueue) */
    public static LRESULT HANDLE_WM_SPOOLERSTATUS(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, uint, int, void> fn
    )
    {
        fn((hwnd), (uint)(wParam), (int)(short)LOWORD(lParam));
        return 0;
    }

    /* void Cls_OnSysChar(HWND hwnd, TCHAR ch, int cRepeat) */
    public static LRESULT HANDLE_WM_SYSCHAR(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, ushort, int, void> fn
    )
    {
        fn((hwnd), (ushort)(wParam), (int)(short)LOWORD(lParam));
        return 0;
    }

    /* void Cls_OnSysColorChange(HWND hwnd) */
    public static LRESULT HANDLE_WM_SYSCOLORCHANGE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* void Cls_OnSysCommand(HWND hwnd, UINT cmd, int x, int y) */
    public static LRESULT HANDLE_WM_SYSCOMMAND(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, uint, int, int, void> fn
    )
    {
        fn((hwnd), (uint)(wParam), (int)(short)LOWORD(lParam), (int)(short)HIWORD(lParam));
        return 0;
    }

    /* void Cls_OnSysDeadChar(HWND hwnd, TCHAR ch, int cRepeat) */
    public static LRESULT HANDLE_WM_SYSDEADCHAR(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, ushort, int, void> fn
    )
    {
        fn((hwnd), (ushort)(wParam), (int)(short)LOWORD(lParam));
        return 0;
    }

    /* void Cls_OnSysKey(HWND hwnd, UINT vk, BOOL fDown, int cRepeat, UINT flags) */
    public static LRESULT HANDLE_WM_SYSKEYDOWN(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, uint, BOOL, int, uint, void> fn
    )
    {
        fn((hwnd), (uint)(wParam), TRUE, (int)(short)LOWORD(lParam), (uint)HIWORD(lParam));
        return 0;
    }

    /* void Cls_OnSysKey(HWND hwnd, UINT vk, BOOL fDown, int cRepeat, UINT flags) */
    public static LRESULT HANDLE_WM_SYSKEYUP(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, uint, BOOL, int, uint, void> fn
    )
    {
        fn((hwnd), (uint)(wParam), FALSE, (int)(short)LOWORD(lParam), (uint)HIWORD(lParam));
        return 0;
    }

    /* This message is in Windows 3.1 only */
    /* void Cls_OnSystemError(HWND hwnd, int errCode) */
    public static LRESULT HANDLE_WM_SYSTEMERROR(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, int, void> fn
    ) => 0;

    /* void Cls_OnTimeChange(HWND hwnd) */
    public static LRESULT HANDLE_WM_TIMECHANGE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* void Cls_OnTimer(HWND hwnd, UINT id) */
    public static LRESULT HANDLE_WM_TIMER(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, uint, void> fn
    )
    {
        fn((hwnd), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnUndo(HWND hwnd) */
    public static LRESULT HANDLE_WM_UNDO(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* int Cls_OnVkeyToItem(HWND hwnd, UINT vk, HWND hwndListbox, int iCaret) */
    public static LRESULT HANDLE_WM_VKEYTOITEM(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, uint, HWND, int, int> fn
    ) =>
        (LRESULT)
            (uint)(int)fn((hwnd), (uint)LOWORD(wParam), (HWND)(lParam), (int)(short)HIWORD(wParam));

    /* void Cls_OnVScroll(HWND hwnd, HWND hwndCtl, UINT code, int pos) */
    public static LRESULT HANDLE_WM_VSCROLL(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HWND, uint, int, void> fn
    )
    {
        fn((hwnd), (HWND)(lParam), (uint)(LOWORD(wParam)), (int)(short)HIWORD(wParam));
        return 0;
    }

    /* void Cls_OnVScrollClipboard(HWND hwnd, HWND hwndCBViewer, UINT code, int pos) */
    public static LRESULT HANDLE_WM_VSCROLLCLIPBOARD(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, HWND, uint, int, void> fn
    )
    {
        fn((hwnd), (HWND)(wParam), (uint)LOWORD(lParam), (int)(short)HIWORD(lParam));
        return 0;
    }

    /* void Cls_OnWindowPosChanged(HWND hwnd, const LPWINDOWPOS lpwpos) */
    public static LRESULT HANDLE_WM_WINDOWPOSCHANGED(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, WINDOWPOS*, void> fn
    )
    {
        fn((hwnd), (WINDOWPOS*)(lParam));
        return 0;
    }

    /* BOOL Cls_OnWindowPosChanging(HWND hwnd, LPWINDOWPOS lpwpos) */
    public static LRESULT HANDLE_WM_WINDOWPOSCHANGING(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, WINDOWPOS*, BOOL> fn
    ) => (LRESULT)(uint)(BOOL)fn((hwnd), (WINDOWPOS*)(lParam));

    /* void Cls_OnWinIniChange(HWND hwnd, LPCTSTR lpszSectionName) */
    public static LRESULT HANDLE_WM_WININICHANGE(
        HWND hwnd,
        WPARAM wParam,
        LPARAM lParam,
        delegate* <HWND, char*, void> fn
    )
    {
        fn((hwnd), (char*)(lParam));
        return 0;
    }

    public static BOOL InsetRect(RECT* lprc, int dx, int dy) => InflateRect((lprc), -(dx), -(dy));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<BOOL> InsetRect(Ref<RECT> lprc, int dx, int dy)
    {
        fixed (RECT* __dsl_lprc = lprc)
        {
            return (MaybeBool<BOOL>)(BOOL)InsetRect(__dsl_lprc, dx, dy);
        }
    }

    public static int IntersectRgn(HRGN hrgnResult, HRGN hrgnA, HRGN hrgnB) =>
        CombineRgn(hrgnResult, hrgnA, hrgnB, RGN_AND);

    [Transformed]
    public static MaybeBool<BOOL> IsLButtonDown() => (MaybeBool<BOOL>)(BOOL)IsLButtonDownRaw();

    public static BOOL IsLButtonDownRaw() => (GetKeyState(VK_LBUTTON) < 0);

    [Transformed]
    public static MaybeBool<BOOL> IsMaximized(HWND hwnd) =>
        (MaybeBool<BOOL>)(BOOL)IsMaximizedRaw(hwnd);

    public static BOOL IsMaximizedRaw(HWND hwnd) => IsZoomedRaw(hwnd);

    [Transformed]
    public static MaybeBool<BOOL> IsMButtonDown() => (MaybeBool<BOOL>)(BOOL)IsMButtonDownRaw();

    public static BOOL IsMButtonDownRaw() => (GetKeyState(VK_MBUTTON) < 0);

    [Transformed]
    public static MaybeBool<BOOL> IsMinimized(HWND hwnd) =>
        (MaybeBool<BOOL>)(BOOL)IsMinimizedRaw(hwnd);

    public static BOOL IsMinimizedRaw(HWND hwnd) => IsIconicRaw(hwnd);

    [Transformed]
    public static MaybeBool<BOOL> IsRButtonDown() => (MaybeBool<BOOL>)(BOOL)IsRButtonDownRaw();

    public static BOOL IsRButtonDownRaw() => (GetKeyState(VK_RBUTTON) < 0);

    [Transformed]
    public static MaybeBool<BOOL> IsRestored(HWND hwnd) =>
        (MaybeBool<BOOL>)(BOOL)IsRestoredRaw(hwnd);

    public static BOOL IsRestoredRaw(HWND hwnd) =>
        ((GetWindowStyle(hwnd) & (WS_MINIMIZE | WS_MAXIMIZE)) == 0);

    public static int ListBox_AddItemData(HWND hwndCtl, LPARAM data) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_ADDSTRING, 0u, (LPARAM)(data)));

    public static int ListBox_AddString(HWND hwndCtl, char* lpsz) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_ADDSTRING, 0u, (LPARAM)(char*)(lpsz)));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ListBox_AddString(HWND hwndCtl, Ref<char> lpsz)
    {
        fixed (char* __dsl_lpsz = lpsz)
        {
            return (int)ListBox_AddString(hwndCtl, __dsl_lpsz);
        }
    }

    public static int ListBox_DeleteString(HWND hwndCtl, int index) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_DELETESTRING, (WPARAM)(int)(index), 0));

    public static int ListBox_Dir(HWND hwndCtl, uint attrs, char* lpszFileSpec) =>
        (
            (int)
                (uint)SNDMSG(
                    (hwndCtl),
                    LB_DIR,
                    (WPARAM)(uint)(attrs),
                    (LPARAM)(char*)(lpszFileSpec)
                )
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ListBox_Dir(HWND hwndCtl, uint attrs, Ref<char> lpszFileSpec)
    {
        fixed (char* __dsl_lpszFileSpec = lpszFileSpec)
        {
            return (int)ListBox_Dir(hwndCtl, attrs, __dsl_lpszFileSpec);
        }
    }

    /****** ListBox control message APIs *****************************************/
    public static BOOL ListBox_Enable(HWND hwndCtl, BOOL fEnable) =>
        EnableWindow((hwndCtl), (fEnable));

    [Transformed]
    /****** ListBox control message APIs *****************************************/
    public static MaybeBool<BOOL> ListBox_Enable(HWND hwndCtl, MaybeBool<BOOL> fEnable) =>
        (MaybeBool<BOOL>)(BOOL)ListBox_Enable(hwndCtl, (BOOL)fEnable);

    public static int ListBox_FindItemData(HWND hwndCtl, int indexStart, LPARAM data) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_FINDSTRING, (WPARAM)(int)(indexStart), (LPARAM)(data)));

    public static int ListBox_FindString(HWND hwndCtl, int indexStart, char* lpszFind) =>
        (
            (int)
                (uint)SNDMSG(
                    (hwndCtl),
                    LB_FINDSTRING,
                    (WPARAM)(int)(indexStart),
                    (LPARAM)(char*)(lpszFind)
                )
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ListBox_FindString(HWND hwndCtl, int indexStart, Ref<char> lpszFind)
    {
        fixed (char* __dsl_lpszFind = lpszFind)
        {
            return (int)ListBox_FindString(hwndCtl, indexStart, __dsl_lpszFind);
        }
    }

    public static int ListBox_FindStringExact(HWND hwndCtl, int indexStart, char* lpszFind) =>
        (
            (int)
                (uint)SNDMSG(
                    (hwndCtl),
                    LB_FINDSTRINGEXACT,
                    (WPARAM)(int)(indexStart),
                    (LPARAM)(char*)(lpszFind)
                )
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ListBox_FindStringExact(HWND hwndCtl, int indexStart, Ref<char> lpszFind)
    {
        fixed (char* __dsl_lpszFind = lpszFind)
        {
            return (int)ListBox_FindStringExact(hwndCtl, indexStart, __dsl_lpszFind);
        }
    }

    public static int ListBox_GetCaretIndex(HWND hwndCtl) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_GETCARETINDEX, 0u, 0));

    public static int ListBox_GetCount(HWND hwndCtl) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_GETCOUNT, 0u, 0));

    public static int ListBox_GetCurSel(HWND hwndCtl) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_GETCURSEL, 0u, 0));

    public static int ListBox_GetHorizontalExtent(HWND hwndCtl) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_GETHORIZONTALEXTENT, 0u, 0));

    public static LRESULT ListBox_GetItemData(HWND hwndCtl, int index) =>
        ((LRESULT)(nuint)SNDMSG((hwndCtl), LB_GETITEMDATA, (WPARAM)(int)(index), 0));

    public static int ListBox_GetItemHeight(HWND hwndCtl, int index) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_GETITEMHEIGHT, (WPARAM)(int)(index), 0));

    public static int ListBox_GetItemRect(HWND hwndCtl, int index, RECT* lprc) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_GETITEMRECT, (WPARAM)(int)(index), (LPARAM)(RECT*)(lprc)));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ListBox_GetItemRect(HWND hwndCtl, int index, Ref<RECT> lprc)
    {
        fixed (RECT* __dsl_lprc = lprc)
        {
            return (int)ListBox_GetItemRect(hwndCtl, index, __dsl_lprc);
        }
    }

    public static int ListBox_GetSel(HWND hwndCtl, int index) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_GETSEL, (WPARAM)(int)(index), 0));

    public static int ListBox_GetSelCount(HWND hwndCtl) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_GETSELCOUNT, 0u, 0));

    public static int ListBox_GetSelItems(HWND hwndCtl, int cItems, int* lpItems) =>
        (
            (int)
                (uint)SNDMSG(
                    (hwndCtl),
                    LB_GETSELITEMS,
                    (WPARAM)(int)(cItems),
                    (LPARAM)(int*)(lpItems)
                )
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ListBox_GetSelItems(HWND hwndCtl, int cItems, Ref<int> lpItems)
    {
        fixed (int* __dsl_lpItems = lpItems)
        {
            return (int)ListBox_GetSelItems(hwndCtl, cItems, __dsl_lpItems);
        }
    }

    public static int ListBox_GetText(HWND hwndCtl, int index, char* lpszBuffer) =>
        (
            (int)
                (uint)SNDMSG(
                    (hwndCtl),
                    LB_GETTEXT,
                    (WPARAM)(int)(index),
                    (LPARAM)(char*)(lpszBuffer)
                )
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ListBox_GetText(HWND hwndCtl, int index, Ref<char> lpszBuffer)
    {
        fixed (char* __dsl_lpszBuffer = lpszBuffer)
        {
            return (int)ListBox_GetText(hwndCtl, index, __dsl_lpszBuffer);
        }
    }

    public static int ListBox_GetTextLen(HWND hwndCtl, int index) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_GETTEXTLEN, (WPARAM)(int)(index), 0));

    public static int ListBox_GetTopIndex(HWND hwndCtl) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_GETTOPINDEX, 0u, 0));

    public static int ListBox_InsertItemData(HWND hwndCtl, int index, LPARAM data) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_INSERTSTRING, (WPARAM)(int)(index), (LPARAM)(data)));

    public static int ListBox_InsertString(HWND hwndCtl, int index, char* lpsz) =>
        (
            (int)
                (uint)SNDMSG(
                    (hwndCtl),
                    LB_INSERTSTRING,
                    (WPARAM)(int)(index),
                    (LPARAM)(char*)(lpsz)
                )
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ListBox_InsertString(HWND hwndCtl, int index, Ref<char> lpsz)
    {
        fixed (char* __dsl_lpsz = lpsz)
        {
            return (int)ListBox_InsertString(hwndCtl, index, __dsl_lpsz);
        }
    }

    [Transformed]
    public static MaybeBool<BOOL> ListBox_ResetContent(HWND hwndCtl) =>
        (MaybeBool<BOOL>)(BOOL)ListBox_ResetContentRaw(hwndCtl);

    public static BOOL ListBox_ResetContentRaw(HWND hwndCtl) =>
        ((BOOL)(uint)SNDMSG((hwndCtl), LB_RESETCONTENT, 0u, 0));

    public static int ListBox_SelectItemData(HWND hwndCtl, int indexStart, LPARAM data) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_SELECTSTRING, (WPARAM)(int)(indexStart), (LPARAM)(data)));

    public static int ListBox_SelectString(HWND hwndCtl, int indexStart, char* lpszFind) =>
        (
            (int)
                (uint)SNDMSG(
                    (hwndCtl),
                    LB_SELECTSTRING,
                    (WPARAM)(int)(indexStart),
                    (LPARAM)(char*)(lpszFind)
                )
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ListBox_SelectString(HWND hwndCtl, int indexStart, Ref<char> lpszFind)
    {
        fixed (char* __dsl_lpszFind = lpszFind)
        {
            return (int)ListBox_SelectString(hwndCtl, indexStart, __dsl_lpszFind);
        }
    }

    public static int ListBox_SelItemRange(HWND hwndCtl, BOOL fSelect, ushort first, ushort last) =>
        (
            (int)
                (uint)SNDMSG(
                    (hwndCtl),
                    LB_SELITEMRANGE,
                    (WPARAM)(BOOL)(fSelect),
                    MAKELPARAM((first), (last))
                )
        );

    [Transformed]
    public static int ListBox_SelItemRange(
        HWND hwndCtl,
        MaybeBool<BOOL> fSelect,
        ushort first,
        ushort last
    ) => (int)ListBox_SelItemRange(hwndCtl, (BOOL)fSelect, first, last);

    public static int ListBox_SetCaretIndex(HWND hwndCtl, int index) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_SETCARETINDEX, (WPARAM)(int)(index), 0));

    public static void ListBox_SetColumnWidth(HWND hwndCtl, int cxColumn) =>
        SNDMSG((hwndCtl), LB_SETCOLUMNWIDTH, (WPARAM)(int)(cxColumn), 0);

    public static int ListBox_SetCurSel(HWND hwndCtl, int index) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_SETCURSEL, (WPARAM)(int)(index), 0));

    public static void ListBox_SetHorizontalExtent(HWND hwndCtl, int cxExtent) =>
        SNDMSG((hwndCtl), LB_SETHORIZONTALEXTENT, (WPARAM)(int)(cxExtent), 0);

    public static int ListBox_SetItemData(HWND hwndCtl, int index, LPARAM data) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_SETITEMDATA, (WPARAM)(int)(index), (LPARAM)(data)));

    public static int ListBox_SetItemHeight(HWND hwndCtl, int index, ushort cy) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_SETITEMHEIGHT, (WPARAM)(int)(index), MAKELPARAM((cy), 0)));

    public static int ListBox_SetSel(HWND hwndCtl, BOOL fSelect, LPARAM index) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_SETSEL, (WPARAM)(BOOL)(fSelect), (LPARAM)(index)));

    [Transformed]
    public static int ListBox_SetSel(HWND hwndCtl, MaybeBool<BOOL> fSelect, LPARAM index) =>
        (int)ListBox_SetSel(hwndCtl, (BOOL)fSelect, index);

    public static BOOL ListBox_SetTabStops(HWND hwndCtl, int cTabs, int* lpTabs) =>
        (
            (BOOL)
                (uint)SNDMSG(
                    (hwndCtl),
                    LB_SETTABSTOPS,
                    (WPARAM)(int)(cTabs),
                    (LPARAM)(int*)(lpTabs)
                )
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<BOOL> ListBox_SetTabStops(HWND hwndCtl, int cTabs, Ref<int> lpTabs)
    {
        fixed (int* __dsl_lpTabs = lpTabs)
        {
            return (MaybeBool<BOOL>)(BOOL)ListBox_SetTabStops(hwndCtl, cTabs, __dsl_lpTabs);
        }
    }

    public static int ListBox_SetTopIndex(HWND hwndCtl, int indexTop) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_SETTOPINDEX, (WPARAM)(int)(indexTop), 0));

    public static int MapWindowRect(HWND hwndFrom, HWND hwndTo, POINT* lprc) =>
        MapWindowPoints((hwndFrom), (hwndTo), (POINT*)(lprc), 2);

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int MapWindowRect(HWND hwndFrom, HWND hwndTo, Ref<POINT> lprc)
    {
        fixed (POINT* __dsl_lprc = lprc)
        {
            return (int)MapWindowRect(hwndFrom, hwndTo, __dsl_lprc);
        }
    }

    [Transformed]
    /****** ScrollBar control message APIs ***************************************/
    /* NOTE: flags parameter is a collection of ESB_* values, NOT a boolean! */
    public static MaybeBool<BOOL> ScrollBar_Enable(HWND hwndCtl, uint flags) =>
        (MaybeBool<BOOL>)(BOOL)ScrollBar_EnableRaw(hwndCtl, flags);

    /****** ScrollBar control message APIs ***************************************/
    /* NOTE: flags parameter is a collection of ESB_* values, NOT a boolean! */
    public static BOOL ScrollBar_EnableRaw(HWND hwndCtl, uint flags) =>
        EnableScrollBarRaw((hwndCtl), SB_CTL, (flags));

    public static int ScrollBar_GetPos(HWND hwndCtl) => GetScrollPos((hwndCtl), SB_CTL);

    public static BOOL ScrollBar_GetRange(HWND hwndCtl, int* lpposMin, int* lpposMax) =>
        GetScrollRange((hwndCtl), SB_CTL, (lpposMin), (lpposMax));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<BOOL> ScrollBar_GetRange(
        HWND hwndCtl,
        Ref<int> lpposMin,
        Ref<int> lpposMax
    )
    {
        fixed (int* __dsl_lpposMax = lpposMax)
        fixed (int* __dsl_lpposMin = lpposMin)
        {
            return (MaybeBool<BOOL>)
                (BOOL)ScrollBar_GetRange(hwndCtl, __dsl_lpposMin, __dsl_lpposMax);
        }
    }

    public static int ScrollBar_SetPos(HWND hwndCtl, int pos, BOOL fRedraw) =>
        SetScrollPos((hwndCtl), SB_CTL, (pos), (fRedraw));

    [Transformed]
    public static int ScrollBar_SetPos(HWND hwndCtl, int pos, MaybeBool<BOOL> fRedraw) =>
        (int)ScrollBar_SetPos(hwndCtl, pos, (BOOL)fRedraw);

    public static BOOL ScrollBar_SetRange(HWND hwndCtl, int posMin, int posMax, BOOL fRedraw) =>
        SetScrollRange((hwndCtl), SB_CTL, (posMin), (posMax), (fRedraw));

    [Transformed]
    public static MaybeBool<BOOL> ScrollBar_SetRange(
        HWND hwndCtl,
        int posMin,
        int posMax,
        MaybeBool<BOOL> fRedraw
    ) => (MaybeBool<BOOL>)(BOOL)ScrollBar_SetRange(hwndCtl, posMin, posMax, (BOOL)fRedraw);

    public static BOOL ScrollBar_Show(HWND hwndCtl, BOOL fShow) =>
        ShowWindowRaw((hwndCtl), (fShow) ? SW_SHOWNORMAL : SW_HIDE);

    [Transformed]
    public static MaybeBool<BOOL> ScrollBar_Show(HWND hwndCtl, MaybeBool<BOOL> fShow) =>
        (MaybeBool<BOOL>)(BOOL)ScrollBar_Show(hwndCtl, (BOOL)fShow);

    public static HBITMAP SelectBitmap(HDC hdc, HBITMAP hbm) =>
        ((HBITMAP)SelectObject((hdc), (HGDIOBJ)(HBITMAP)(hbm)));

    public static HBRUSH SelectBrush(HDC hdc, HBRUSH hbr) =>
        ((HBRUSH)SelectObject((hdc), (HGDIOBJ)(HBRUSH)(hbr)));

    public static HFONT SelectFont(HDC hdc, HFONT hfont) =>
        ((HFONT)SelectObject((hdc), (HGDIOBJ)(HFONT)(hfont)));

    public static HPEN SelectPen(HDC hdc, HPEN hpen) =>
        ((HPEN)SelectObject((hdc), (HGDIOBJ)(HPEN)(hpen)));

    public static BOOL SetDlgMsgResult(HWND hwnd, uint msg, BOOL result)
    {
        if (
            (msg) == WM_CTLCOLORMSGBOX
            || (msg) == WM_CTLCOLOREDIT
            || (msg) == WM_CTLCOLORLISTBOX
            || (msg) == WM_CTLCOLORBTN
            || (msg) == WM_CTLCOLORDLG
            || (msg) == WM_CTLCOLORSCROLLBAR
            || (msg) == WM_CTLCOLORSTATIC
            || (msg) == WM_COMPAREITEM
            || (msg) == WM_VKEYTOITEM
            || (msg) == WM_CHARTOITEM
            || (msg) == WM_QUERYDRAGICON
            || (msg) == WM_INITDIALOG
        )
        {
            return (BOOL)(result);
        }
        else
        {
            _ = SetWindowLongPtr((hwnd), DWLP_MSGRESULT, (LPARAM)(LRESULT)(result));
            return TRUE;
        }
    }

    [Transformed]
    public static MaybeBool<BOOL> SetDlgMsgResult(HWND hwnd, uint msg, MaybeBool<BOOL> result) =>
        (MaybeBool<BOOL>)(BOOL)SetDlgMsgResult(hwnd, msg, (BOOL)result);

    public static void SetWindowFont(HWND hwnd, HFONT hfont, BOOL fRedraw) =>
        FORWARD_WM_SETFONT((hwnd), (hfont), (fRedraw), SNDMSG);

    [Transformed]
    public static void SetWindowFont(HWND hwnd, HFONT hfont, MaybeBool<BOOL> fRedraw) =>
        SetWindowFont(hwnd, hfont, (BOOL)fRedraw);

    public static LRESULT SetWindowRedraw(HWND hwnd, BOOL fRedraw) =>
        SNDMSG(hwnd, WM_SETREDRAW, (WPARAM)(BOOL)(fRedraw), 0);

    [Transformed]
    public static LRESULT SetWindowRedraw(HWND hwnd, MaybeBool<BOOL> fRedraw) =>
        (LRESULT)SetWindowRedraw(hwnd, (BOOL)fRedraw);

    /****** Static control message APIs ******************************************/
    public static BOOL Static_Enable(HWND hwndCtl, BOOL fEnable) =>
        EnableWindow((hwndCtl), (fEnable));

    [Transformed]
    /****** Static control message APIs ******************************************/
    public static MaybeBool<BOOL> Static_Enable(HWND hwndCtl, MaybeBool<BOOL> fEnable) =>
        (MaybeBool<BOOL>)(BOOL)Static_Enable(hwndCtl, (BOOL)fEnable);

    public static HICON Static_GetIcon(HWND hwndCtl, HICON hIcon) =>
        ((HICON)(nuint)SNDMSG((hwndCtl), STM_GETICON, 0u, 0));

    public static int Static_GetText(HWND hwndCtl, char* lpch, int cchMax) =>
        GetWindowText((hwndCtl), (lpch), (cchMax));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int Static_GetText(HWND hwndCtl, Ref<char> lpch, int cchMax)
    {
        fixed (char* __dsl_lpch = lpch)
        {
            return (int)Static_GetText(hwndCtl, __dsl_lpch, cchMax);
        }
    }

    public static int Static_GetTextLength(HWND hwndCtl) => GetWindowTextLength(hwndCtl);

    public static HICON Static_SetIcon(HWND hwndCtl, HICON hIcon) =>
        ((HICON)(nuint)SNDMSG((hwndCtl), STM_SETICON, (WPARAM)(HICON)(hIcon), 0));

    public static BOOL Static_SetText(HWND hwndCtl, char* lpsz) => SetWindowText((hwndCtl), (lpsz));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<BOOL> Static_SetText(HWND hwndCtl, Ref<char> lpsz)
    {
        fixed (char* __dsl_lpsz = lpsz)
        {
            return (MaybeBool<BOOL>)(BOOL)Static_SetText(hwndCtl, __dsl_lpsz);
        }
    }

    public static nint SubclassDialog(
        HWND hwndDlg,
        delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpfn
    ) => (SetWindowLongPtr(hwndDlg, (int)(DWLP_DLGPROC), (LPARAM)(lpfn)));

    public static delegate* unmanaged<HWND, uint, WPARAM, LPARAM, LRESULT> SubclassWindow(
        HWND hwnd,
        delegate* unmanaged<HWND, uint, WPARAM, LPARAM, LRESULT> lpfn
    ) =>
        (
            (delegate* unmanaged<HWND, uint, WPARAM, LPARAM, LRESULT>)SetWindowLongPtr(
                (hwnd),
                GWLP_WNDPROC,
                (LPARAM)(delegate* unmanaged<HWND, uint, WPARAM, LPARAM, LRESULT>)(lpfn)
            )
        );

    public static int SubtractRgn(HRGN hrgnResult, HRGN hrgnA, HRGN hrgnB) =>
        CombineRgn(hrgnResult, hrgnA, hrgnB, RGN_DIFF);

    public static int UnionRgn(HRGN hrgnResult, HRGN hrgnA, HRGN hrgnB) =>
        CombineRgn(hrgnResult, hrgnA, hrgnB, RGN_OR);

    public static int XorRgn(HRGN hrgnResult, HRGN hrgnA, HRGN hrgnB) =>
        CombineRgn(hrgnResult, hrgnA, hrgnB, RGN_XOR);
}
