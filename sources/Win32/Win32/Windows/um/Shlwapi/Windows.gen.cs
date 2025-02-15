// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PSTR")]
    public static extern sbyte* StrChrA(
        [NativeTypeName("PCSTR")] sbyte* pszStart,
        [NativeTypeName("WORD")] ushort wMatch
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern ushort* StrChrW(
        [NativeTypeName("PCWSTR")] ushort* pszStart,
        [NativeTypeName("WCHAR")] ushort wMatch
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PSTR")]
    public static extern sbyte* StrChrIA(
        [NativeTypeName("PCSTR")] sbyte* pszStart,
        [NativeTypeName("WORD")] ushort wMatch
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern ushort* StrChrIW(
        [NativeTypeName("PCWSTR")] ushort* pszStart,
        [NativeTypeName("WCHAR")] ushort wMatch
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern ushort* StrChrNW(
        [NativeTypeName("PCWSTR")] ushort* pszStart,
        [NativeTypeName("WCHAR")] ushort wMatch,
        uint cchMax
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern ushort* StrChrNIW(
        [NativeTypeName("PCWSTR")] ushort* pszStart,
        [NativeTypeName("WCHAR")] ushort wMatch,
        uint cchMax
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCmpNA(
        [NativeTypeName("PCSTR")] sbyte* psz1,
        [NativeTypeName("PCSTR")] sbyte* psz2,
        int nChar
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCmpNW(
        [NativeTypeName("PCWSTR")] ushort* psz1,
        [NativeTypeName("PCWSTR")] ushort* psz2,
        int nChar
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCmpNIA(
        [NativeTypeName("PCSTR")] sbyte* psz1,
        [NativeTypeName("PCSTR")] sbyte* psz2,
        int nChar
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCmpNIW(
        [NativeTypeName("PCWSTR")] ushort* psz1,
        [NativeTypeName("PCWSTR")] ushort* psz2,
        int nChar
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCSpnA(
        [NativeTypeName("PCSTR")] sbyte* pszStr,
        [NativeTypeName("PCSTR")] sbyte* pszSet
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCSpnW(
        [NativeTypeName("PCWSTR")] ushort* pszStr,
        [NativeTypeName("PCWSTR")] ushort* pszSet
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCSpnIA(
        [NativeTypeName("PCSTR")] sbyte* pszStr,
        [NativeTypeName("PCSTR")] sbyte* pszSet
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCSpnIW(
        [NativeTypeName("PCWSTR")] ushort* pszStr,
        [NativeTypeName("PCWSTR")] ushort* pszSet
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PSTR")]
    public static extern sbyte* StrDupA([NativeTypeName("PCSTR")] sbyte* pszSrch);

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern ushort* StrDupW([NativeTypeName("PCWSTR")] ushort* pszSrch);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT StrFormatByteSizeEx(
        [NativeTypeName("ULONGLONG")] ulong ull,
        [NativeTypeName("SFBS_FLAGS")] int flags,
        [NativeTypeName("PWSTR")] ushort* pszBuf,
        uint cchBuf
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PSTR")]
    public static extern sbyte* StrFormatByteSizeA(
        [NativeTypeName("DWORD")] uint dw,
        [NativeTypeName("PSTR")] sbyte* pszBuf,
        uint cchBuf
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PSTR")]
    public static extern sbyte* StrFormatByteSize64A(
        [NativeTypeName("LONGLONG")] long qdw,
        [NativeTypeName("PSTR")] sbyte* pszBuf,
        uint cchBuf
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern ushort* StrFormatByteSizeW(
        [NativeTypeName("LONGLONG")] long qdw,
        [NativeTypeName("PWSTR")] ushort* pszBuf,
        uint cchBuf
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern ushort* StrFormatKBSizeW(
        [NativeTypeName("LONGLONG")] long qdw,
        [NativeTypeName("PWSTR")] ushort* pszBuf,
        uint cchBuf
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PSTR")]
    public static extern sbyte* StrFormatKBSizeA(
        [NativeTypeName("LONGLONG")] long qdw,
        [NativeTypeName("PSTR")] sbyte* pszBuf,
        uint cchBuf
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrFromTimeIntervalA(
        [NativeTypeName("PSTR")] sbyte* pszOut,
        uint cchMax,
        [NativeTypeName("DWORD")] uint dwTimeMS,
        int digits
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrFromTimeIntervalW(
        [NativeTypeName("PWSTR")] ushort* pszOut,
        uint cchMax,
        [NativeTypeName("DWORD")] uint dwTimeMS,
        int digits
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL StrIsIntlEqualA(
        BOOL fCaseSens,
        [NativeTypeName("PCSTR")] sbyte* pszString1,
        [NativeTypeName("PCSTR")] sbyte* pszString2,
        int nChar
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL StrIsIntlEqualW(
        BOOL fCaseSens,
        [NativeTypeName("PCWSTR")] ushort* pszString1,
        [NativeTypeName("PCWSTR")] ushort* pszString2,
        int nChar
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PSTR")]
    public static extern sbyte* StrNCatA(
        [NativeTypeName("PSTR")] sbyte* psz1,
        [NativeTypeName("PCSTR")] sbyte* psz2,
        int cchMax
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern ushort* StrNCatW(
        [NativeTypeName("PWSTR")] ushort* psz1,
        [NativeTypeName("PCWSTR")] ushort* psz2,
        int cchMax
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PSTR")]
    public static extern sbyte* StrPBrkA(
        [NativeTypeName("PCSTR")] sbyte* psz,
        [NativeTypeName("PCSTR")] sbyte* pszSet
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern ushort* StrPBrkW(
        [NativeTypeName("PCWSTR")] ushort* psz,
        [NativeTypeName("PCWSTR")] ushort* pszSet
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PSTR")]
    public static extern sbyte* StrRChrA(
        [NativeTypeName("PCSTR")] sbyte* pszStart,
        [NativeTypeName("PCSTR")] sbyte* pszEnd,
        [NativeTypeName("WORD")] ushort wMatch
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern ushort* StrRChrW(
        [NativeTypeName("PCWSTR")] ushort* pszStart,
        [NativeTypeName("PCWSTR")] ushort* pszEnd,
        [NativeTypeName("WCHAR")] ushort wMatch
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PSTR")]
    public static extern sbyte* StrRChrIA(
        [NativeTypeName("PCSTR")] sbyte* pszStart,
        [NativeTypeName("PCSTR")] sbyte* pszEnd,
        [NativeTypeName("WORD")] ushort wMatch
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern ushort* StrRChrIW(
        [NativeTypeName("PCWSTR")] ushort* pszStart,
        [NativeTypeName("PCWSTR")] ushort* pszEnd,
        [NativeTypeName("WCHAR")] ushort wMatch
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PSTR")]
    public static extern sbyte* StrRStrIA(
        [NativeTypeName("PCSTR")] sbyte* pszSource,
        [NativeTypeName("PCSTR")] sbyte* pszLast,
        [NativeTypeName("PCSTR")] sbyte* pszSrch
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern ushort* StrRStrIW(
        [NativeTypeName("PCWSTR")] ushort* pszSource,
        [NativeTypeName("PCWSTR")] ushort* pszLast,
        [NativeTypeName("PCWSTR")] ushort* pszSrch
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrSpnA(
        [NativeTypeName("PCSTR")] sbyte* psz,
        [NativeTypeName("PCSTR")] sbyte* pszSet
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrSpnW(
        [NativeTypeName("PCWSTR")] ushort* psz,
        [NativeTypeName("PCWSTR")] ushort* pszSet
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PSTR")]
    public static extern sbyte* StrStrA(
        [NativeTypeName("PCSTR")] sbyte* pszFirst,
        [NativeTypeName("PCSTR")] sbyte* pszSrch
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern ushort* StrStrW(
        [NativeTypeName("PCWSTR")] ushort* pszFirst,
        [NativeTypeName("PCWSTR")] ushort* pszSrch
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PSTR")]
    public static extern sbyte* StrStrIA(
        [NativeTypeName("PCSTR")] sbyte* pszFirst,
        [NativeTypeName("PCSTR")] sbyte* pszSrch
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern ushort* StrStrIW(
        [NativeTypeName("PCWSTR")] ushort* pszFirst,
        [NativeTypeName("PCWSTR")] ushort* pszSrch
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern ushort* StrStrNW(
        [NativeTypeName("PCWSTR")] ushort* pszFirst,
        [NativeTypeName("PCWSTR")] ushort* pszSrch,
        uint cchMax
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern ushort* StrStrNIW(
        [NativeTypeName("PCWSTR")] ushort* pszFirst,
        [NativeTypeName("PCWSTR")] ushort* pszSrch,
        uint cchMax
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrToIntA([NativeTypeName("PCSTR")] sbyte* pszSrc);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrToIntW([NativeTypeName("PCWSTR")] ushort* pszSrc);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL StrToIntExA(
        [NativeTypeName("PCSTR")] sbyte* pszString,
        [NativeTypeName("STIF_FLAGS")] int dwFlags,
        int* piRet
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL StrToIntExW(
        [NativeTypeName("PCWSTR")] ushort* pszString,
        [NativeTypeName("STIF_FLAGS")] int dwFlags,
        int* piRet
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL StrToInt64ExA(
        [NativeTypeName("PCSTR")] sbyte* pszString,
        [NativeTypeName("STIF_FLAGS")] int dwFlags,
        [NativeTypeName("LONGLONG *")] long* pllRet
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL StrToInt64ExW(
        [NativeTypeName("PCWSTR")] ushort* pszString,
        [NativeTypeName("STIF_FLAGS")] int dwFlags,
        [NativeTypeName("LONGLONG *")] long* pllRet
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL StrTrimA(
        [NativeTypeName("PSTR")] sbyte* psz,
        [NativeTypeName("PCSTR")] sbyte* pszTrimChars
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL StrTrimW(
        [NativeTypeName("PWSTR")] ushort* psz,
        [NativeTypeName("PCWSTR")] ushort* pszTrimChars
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern ushort* StrCatW(
        [NativeTypeName("PWSTR")] ushort* psz1,
        [NativeTypeName("PCWSTR")] ushort* psz2
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCmpW(
        [NativeTypeName("PCWSTR")] ushort* psz1,
        [NativeTypeName("PCWSTR")] ushort* psz2
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCmpIW(
        [NativeTypeName("PCWSTR")] ushort* psz1,
        [NativeTypeName("PCWSTR")] ushort* psz2
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern ushort* StrCpyW(
        [NativeTypeName("PWSTR")] ushort* psz1,
        [NativeTypeName("PCWSTR")] ushort* psz2
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern ushort* StrCpyNW(
        [NativeTypeName("PWSTR")] ushort* pszDst,
        [NativeTypeName("PCWSTR")] ushort* pszSrc,
        int cchMax
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern ushort* StrCatBuffW(
        [NativeTypeName("PWSTR")] ushort* pszDest,
        [NativeTypeName("PCWSTR")] ushort* pszSrc,
        int cchDestBuffSize
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PSTR")]
    public static extern sbyte* StrCatBuffA(
        [NativeTypeName("PSTR")] sbyte* pszDest,
        [NativeTypeName("PCSTR")] sbyte* pszSrc,
        int cchDestBuffSize
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL ChrCmpIA(
        [NativeTypeName("WORD")] ushort w1,
        [NativeTypeName("WORD")] ushort w2
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL ChrCmpIW(
        [NativeTypeName("WCHAR")] ushort w1,
        [NativeTypeName("WCHAR")] ushort w2
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int wvnsprintfA(
        [NativeTypeName("PSTR")] sbyte* pszDest,
        int cchDest,
        [NativeTypeName("PCSTR")] sbyte* pszFmt,
        [NativeTypeName("va_list")] sbyte* arglist
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int wvnsprintfW(
        [NativeTypeName("PWSTR")] ushort* pszDest,
        int cchDest,
        [NativeTypeName("PCWSTR")] ushort* pszFmt,
        [NativeTypeName("va_list")] sbyte* arglist
    );

    [DllImport("shlwapi", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int wnsprintfA(
        [NativeTypeName("PSTR")] sbyte* pszDest,
        int cchDest,
        [NativeTypeName("PCSTR")] sbyte* pszFmt,
        __arglist
    );

    [DllImport("shlwapi", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int wnsprintfW(
        [NativeTypeName("PWSTR")] ushort* pszDest,
        int cchDest,
        [NativeTypeName("PCWSTR")] ushort* pszFmt,
        __arglist
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT StrRetToStrA(
        STRRET* pstr,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
        [NativeTypeName("LPSTR *")] sbyte** ppsz
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT StrRetToStrW(
        STRRET* pstr,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
        [NativeTypeName("LPWSTR *")] ushort** ppsz
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT StrRetToBufA(
        STRRET* pstr,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
        [NativeTypeName("LPSTR")] sbyte* pszBuf,
        uint cchBuf
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT StrRetToBufW(
        STRRET* pstr,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
        [NativeTypeName("LPWSTR")] ushort* pszBuf,
        uint cchBuf
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT SHStrDupA(
        [NativeTypeName("LPCSTR")] sbyte* psz,
        [NativeTypeName("LPWSTR *")] ushort** ppwsz
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT SHStrDupW(
        [NativeTypeName("LPCWSTR")] ushort* psz,
        [NativeTypeName("LPWSTR *")] ushort** ppwsz
    );

    public static HRESULT SHLocalStrDupW(
        [NativeTypeName("PCWSTR")] ushort* psz,
        [NativeTypeName("PWSTR *")] ushort** ppsz
    )
    {
        *ppsz = StrDupW(psz);
        return (*ppsz) != null ? ((HRESULT)(0)) : ((HRESULT)(0x8007000E));
    }

    public static HRESULT SHLocalStrDupA(
        [NativeTypeName("PCSTR")] sbyte* psz,
        [NativeTypeName("PSTR *")] sbyte** ppsz
    )
    {
        *ppsz = StrDupA(psz);
        return (*ppsz) != null ? ((HRESULT)(0)) : ((HRESULT)(0x8007000E));
    }

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCmpLogicalW(
        [NativeTypeName("PCWSTR")] ushort* psz1,
        [NativeTypeName("PCWSTR")] ushort* psz2
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint StrCatChainW(
        [NativeTypeName("PWSTR")] ushort* pszDst,
        [NativeTypeName("DWORD")] uint cchDst,
        [NativeTypeName("DWORD")] uint ichAt,
        [NativeTypeName("PCWSTR")] ushort* pszSrc
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT StrRetToBSTR(
        STRRET* pstr,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
        [NativeTypeName("BSTR *")] ushort** pbstr
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT SHLoadIndirectString(
        [NativeTypeName("PCWSTR")] ushort* pszSource,
        [NativeTypeName("PWSTR")] ushort* pszOutBuf,
        uint cchOutBuf,
        void** ppvReserved
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL IsCharSpaceA([NativeTypeName("CHAR")] sbyte wch);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL IsCharSpaceW([NativeTypeName("WCHAR")] ushort wch);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCmpCA(
        [NativeTypeName("LPCSTR")] sbyte* pszStr1,
        [NativeTypeName("LPCSTR")] sbyte* pszStr2
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCmpCW(
        [NativeTypeName("LPCWSTR")] ushort* pszStr1,
        [NativeTypeName("LPCWSTR")] ushort* pszStr2
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCmpICA(
        [NativeTypeName("LPCSTR")] sbyte* pszStr1,
        [NativeTypeName("LPCSTR")] sbyte* pszStr2
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCmpICW(
        [NativeTypeName("LPCWSTR")] ushort* pszStr1,
        [NativeTypeName("LPCWSTR")] ushort* pszStr2
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCmpNCA(
        [NativeTypeName("LPCSTR")] sbyte* pszStr1,
        [NativeTypeName("LPCSTR")] sbyte* pszStr2,
        int nChar
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCmpNCW(
        [NativeTypeName("LPCWSTR")] ushort* pszStr1,
        [NativeTypeName("LPCWSTR")] ushort* pszStr2,
        int nChar
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCmpNICA(
        [NativeTypeName("LPCSTR")] sbyte* pszStr1,
        [NativeTypeName("LPCSTR")] sbyte* pszStr2,
        int nChar
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCmpNICW(
        [NativeTypeName("LPCWSTR")] ushort* pszStr1,
        [NativeTypeName("LPCWSTR")] ushort* pszStr2,
        int nChar
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL IntlStrEqWorkerA(
        BOOL fCaseSens,
        [NativeTypeName("LPCSTR")] sbyte* lpString1,
        [NativeTypeName("LPCSTR")] sbyte* lpString2,
        int nChar
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL IntlStrEqWorkerW(
        BOOL fCaseSens,
        [NativeTypeName("LPCWSTR")] ushort* lpString1,
        [NativeTypeName("LPCWSTR")] ushort* lpString2,
        int nChar
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* PathAddBackslashA([NativeTypeName("LPSTR")] sbyte* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPWSTR")]
    public static extern ushort* PathAddBackslashW([NativeTypeName("LPWSTR")] ushort* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathAddExtensionA(
        [NativeTypeName("LPSTR")] sbyte* pszPath,
        [NativeTypeName("LPCSTR")] sbyte* pszExt
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathAddExtensionW(
        [NativeTypeName("LPWSTR")] ushort* pszPath,
        [NativeTypeName("LPCWSTR")] ushort* pszExt
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathAppendA(
        [NativeTypeName("LPSTR")] sbyte* pszPath,
        [NativeTypeName("LPCSTR")] sbyte* pszMore
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathAppendW(
        [NativeTypeName("LPWSTR")] ushort* pszPath,
        [NativeTypeName("LPCWSTR")] ushort* pszMore
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* PathBuildRootA(
        [NativeTypeName("LPSTR")] sbyte* pszRoot,
        int iDrive
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPWSTR")]
    public static extern ushort* PathBuildRootW(
        [NativeTypeName("LPWSTR")] ushort* pszRoot,
        int iDrive
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PathCanonicalizeA(
        [NativeTypeName("LPSTR")] sbyte* pszBuf,
        [NativeTypeName("LPCSTR")] sbyte* pszPath
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PathCanonicalizeW(
        [NativeTypeName("LPWSTR")] ushort* pszBuf,
        [NativeTypeName("LPCWSTR")] ushort* pszPath
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* PathCombineA(
        [NativeTypeName("LPSTR")] sbyte* pszDest,
        [NativeTypeName("LPCSTR")] sbyte* pszDir,
        [NativeTypeName("LPCSTR")] sbyte* pszFile
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPWSTR")]
    public static extern ushort* PathCombineW(
        [NativeTypeName("LPWSTR")] ushort* pszDest,
        [NativeTypeName("LPCWSTR")] ushort* pszDir,
        [NativeTypeName("LPCWSTR")] ushort* pszFile
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathCompactPathA(
        HDC hDC,
        [NativeTypeName("LPSTR")] sbyte* pszPath,
        uint dx
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathCompactPathW(
        HDC hDC,
        [NativeTypeName("LPWSTR")] ushort* pszPath,
        uint dx
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathCompactPathExA(
        [NativeTypeName("LPSTR")] sbyte* pszOut,
        [NativeTypeName("LPCSTR")] sbyte* pszSrc,
        uint cchMax,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathCompactPathExW(
        [NativeTypeName("LPWSTR")] ushort* pszOut,
        [NativeTypeName("LPCWSTR")] ushort* pszSrc,
        uint cchMax,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int PathCommonPrefixA(
        [NativeTypeName("LPCSTR")] sbyte* pszFile1,
        [NativeTypeName("LPCSTR")] sbyte* pszFile2,
        [NativeTypeName("LPSTR")] sbyte* achPath
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int PathCommonPrefixW(
        [NativeTypeName("LPCWSTR")] ushort* pszFile1,
        [NativeTypeName("LPCWSTR")] ushort* pszFile2,
        [NativeTypeName("LPWSTR")] ushort* achPath
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PathFileExistsA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PathFileExistsW([NativeTypeName("LPCWSTR")] ushort* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* PathFindExtensionA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPWSTR")]
    public static extern ushort* PathFindExtensionW([NativeTypeName("LPCWSTR")] ushort* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* PathFindFileNameA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPWSTR")]
    public static extern ushort* PathFindFileNameW([NativeTypeName("LPCWSTR")] ushort* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* PathFindNextComponentA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPWSTR")]
    public static extern ushort* PathFindNextComponentW(
        [NativeTypeName("LPCWSTR")] ushort* pszPath
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathFindOnPathA(
        [NativeTypeName("LPSTR")] sbyte* pszPath,
        [NativeTypeName("PZPCSTR")] sbyte** ppszOtherDirs
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathFindOnPathW(
        [NativeTypeName("LPWSTR")] ushort* pszPath,
        [NativeTypeName("PZPCWSTR")] ushort** ppszOtherDirs
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPCSTR")]
    public static extern sbyte* PathFindSuffixArrayA(
        [NativeTypeName("LPCSTR")] sbyte* pszPath,
        [NativeTypeName("const LPCSTR *")] sbyte** apszSuffix,
        int iArraySize
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPCWSTR")]
    public static extern ushort* PathFindSuffixArrayW(
        [NativeTypeName("LPCWSTR")] ushort* pszPath,
        [NativeTypeName("const LPCWSTR *")] ushort** apszSuffix,
        int iArraySize
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* PathGetArgsA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPWSTR")]
    public static extern ushort* PathGetArgsW([NativeTypeName("LPCWSTR")] ushort* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsLFNFileSpecA([NativeTypeName("LPCSTR")] sbyte* pszName);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsLFNFileSpecW([NativeTypeName("LPCWSTR")] ushort* pszName);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern uint PathGetCharTypeA([NativeTypeName("UCHAR")] byte ch);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern uint PathGetCharTypeW([NativeTypeName("WCHAR")] ushort ch);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int PathGetDriveNumberA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int PathGetDriveNumberW([NativeTypeName("LPCWSTR")] ushort* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsDirectoryA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsDirectoryW([NativeTypeName("LPCWSTR")] ushort* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsDirectoryEmptyA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsDirectoryEmptyW([NativeTypeName("LPCWSTR")] ushort* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsFileSpecA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsFileSpecW([NativeTypeName("LPCWSTR")] ushort* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsPrefixA(
        [NativeTypeName("LPCSTR")] sbyte* pszPrefix,
        [NativeTypeName("LPCSTR")] sbyte* pszPath
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsPrefixW(
        [NativeTypeName("LPCWSTR")] ushort* pszPrefix,
        [NativeTypeName("LPCWSTR")] ushort* pszPath
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsRelativeA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsRelativeW([NativeTypeName("LPCWSTR")] ushort* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsRootA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsRootW([NativeTypeName("LPCWSTR")] ushort* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsSameRootA(
        [NativeTypeName("LPCSTR")] sbyte* pszPath1,
        [NativeTypeName("LPCSTR")] sbyte* pszPath2
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsSameRootW(
        [NativeTypeName("LPCWSTR")] ushort* pszPath1,
        [NativeTypeName("LPCWSTR")] ushort* pszPath2
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsUNCA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsUNCW([NativeTypeName("LPCWSTR")] ushort* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsNetworkPathA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsNetworkPathW([NativeTypeName("LPCWSTR")] ushort* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsUNCServerA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsUNCServerW([NativeTypeName("LPCWSTR")] ushort* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsUNCServerShareA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsUNCServerShareW([NativeTypeName("LPCWSTR")] ushort* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsContentTypeA(
        [NativeTypeName("LPCSTR")] sbyte* pszPath,
        [NativeTypeName("LPCSTR")] sbyte* pszContentType
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsContentTypeW(
        [NativeTypeName("LPCWSTR")] ushort* pszPath,
        [NativeTypeName("LPCWSTR")] ushort* pszContentType
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsURLA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsURLW([NativeTypeName("LPCWSTR")] ushort* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathMakePrettyA([NativeTypeName("LPSTR")] sbyte* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathMakePrettyW([NativeTypeName("LPWSTR")] ushort* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathMatchSpecA(
        [NativeTypeName("LPCSTR")] sbyte* pszFile,
        [NativeTypeName("LPCSTR")] sbyte* pszSpec
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathMatchSpecW(
        [NativeTypeName("LPCWSTR")] ushort* pszFile,
        [NativeTypeName("LPCWSTR")] ushort* pszSpec
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT PathMatchSpecExA(
        [NativeTypeName("LPCSTR")] sbyte* pszFile,
        [NativeTypeName("LPCSTR")] sbyte* pszSpec,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT PathMatchSpecExW(
        [NativeTypeName("LPCWSTR")] ushort* pszFile,
        [NativeTypeName("LPCWSTR")] ushort* pszSpec,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int PathParseIconLocationA([NativeTypeName("LPSTR")] sbyte* pszIconFile);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int PathParseIconLocationW([NativeTypeName("LPWSTR")] ushort* pszIconFile);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathQuoteSpacesA([NativeTypeName("LPSTR")] sbyte* lpsz);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathQuoteSpacesW([NativeTypeName("LPWSTR")] ushort* lpsz);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathRelativePathToA(
        [NativeTypeName("LPSTR")] sbyte* pszPath,
        [NativeTypeName("LPCSTR")] sbyte* pszFrom,
        [NativeTypeName("DWORD")] uint dwAttrFrom,
        [NativeTypeName("LPCSTR")] sbyte* pszTo,
        [NativeTypeName("DWORD")] uint dwAttrTo
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathRelativePathToW(
        [NativeTypeName("LPWSTR")] ushort* pszPath,
        [NativeTypeName("LPCWSTR")] ushort* pszFrom,
        [NativeTypeName("DWORD")] uint dwAttrFrom,
        [NativeTypeName("LPCWSTR")] ushort* pszTo,
        [NativeTypeName("DWORD")] uint dwAttrTo
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void PathRemoveArgsA([NativeTypeName("LPSTR")] sbyte* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void PathRemoveArgsW([NativeTypeName("LPWSTR")] ushort* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* PathRemoveBackslashA([NativeTypeName("LPSTR")] sbyte* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPWSTR")]
    public static extern ushort* PathRemoveBackslashW([NativeTypeName("LPWSTR")] ushort* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void PathRemoveBlanksA([NativeTypeName("LPSTR")] sbyte* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void PathRemoveBlanksW([NativeTypeName("LPWSTR")] ushort* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void PathRemoveExtensionA([NativeTypeName("LPSTR")] sbyte* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void PathRemoveExtensionW([NativeTypeName("LPWSTR")] ushort* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathRemoveFileSpecA([NativeTypeName("LPSTR")] sbyte* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathRemoveFileSpecW([NativeTypeName("LPWSTR")] ushort* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathRenameExtensionA(
        [NativeTypeName("LPSTR")] sbyte* pszPath,
        [NativeTypeName("LPCSTR")] sbyte* pszExt
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathRenameExtensionW(
        [NativeTypeName("LPWSTR")] ushort* pszPath,
        [NativeTypeName("LPCWSTR")] ushort* pszExt
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathSearchAndQualifyA(
        [NativeTypeName("LPCSTR")] sbyte* pszPath,
        [NativeTypeName("LPSTR")] sbyte* pszBuf,
        uint cchBuf
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathSearchAndQualifyW(
        [NativeTypeName("LPCWSTR")] ushort* pszPath,
        [NativeTypeName("LPWSTR")] ushort* pszBuf,
        uint cchBuf
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void PathSetDlgItemPathA(
        HWND hDlg,
        int id,
        [NativeTypeName("LPCSTR")] sbyte* pszPath
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void PathSetDlgItemPathW(
        HWND hDlg,
        int id,
        [NativeTypeName("LPCWSTR")] ushort* pszPath
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* PathSkipRootA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPWSTR")]
    public static extern ushort* PathSkipRootW([NativeTypeName("LPCWSTR")] ushort* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void PathStripPathA([NativeTypeName("LPSTR")] sbyte* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void PathStripPathW([NativeTypeName("LPWSTR")] ushort* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathStripToRootA([NativeTypeName("LPSTR")] sbyte* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathStripToRootW([NativeTypeName("LPWSTR")] ushort* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathUnquoteSpacesA([NativeTypeName("LPSTR")] sbyte* lpsz);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathUnquoteSpacesW([NativeTypeName("LPWSTR")] ushort* lpsz);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathMakeSystemFolderA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathMakeSystemFolderW([NativeTypeName("LPCWSTR")] ushort* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathUnmakeSystemFolderA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathUnmakeSystemFolderW([NativeTypeName("LPCWSTR")] ushort* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsSystemFolderA(
        [NativeTypeName("LPCSTR")] sbyte* pszPath,
        [NativeTypeName("DWORD")] uint dwAttrb
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsSystemFolderW(
        [NativeTypeName("LPCWSTR")] ushort* pszPath,
        [NativeTypeName("DWORD")] uint dwAttrb
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void PathUndecorateA([NativeTypeName("LPSTR")] sbyte* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void PathUndecorateW([NativeTypeName("LPWSTR")] ushort* pszPath);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathUnExpandEnvStringsA(
        [NativeTypeName("LPCSTR")] sbyte* pszPath,
        [NativeTypeName("LPSTR")] sbyte* pszBuf,
        uint cchBuf
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathUnExpandEnvStringsW(
        [NativeTypeName("LPCWSTR")] ushort* pszPath,
        [NativeTypeName("LPWSTR")] ushort* pszBuf,
        uint cchBuf
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int UrlCompareA(
        [NativeTypeName("PCSTR")] sbyte* psz1,
        [NativeTypeName("PCSTR")] sbyte* psz2,
        BOOL fIgnoreSlash
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int UrlCompareW(
        [NativeTypeName("PCWSTR")] ushort* psz1,
        [NativeTypeName("PCWSTR")] ushort* psz2,
        BOOL fIgnoreSlash
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlCombineA(
        [NativeTypeName("PCSTR")] sbyte* pszBase,
        [NativeTypeName("PCSTR")] sbyte* pszRelative,
        [NativeTypeName("PSTR")] sbyte* pszCombined,
        [NativeTypeName("DWORD *")] uint* pcchCombined,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlCombineW(
        [NativeTypeName("PCWSTR")] ushort* pszBase,
        [NativeTypeName("PCWSTR")] ushort* pszRelative,
        [NativeTypeName("PWSTR")] ushort* pszCombined,
        [NativeTypeName("DWORD *")] uint* pcchCombined,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlCanonicalizeA(
        [NativeTypeName("PCSTR")] sbyte* pszUrl,
        [NativeTypeName("PSTR")] sbyte* pszCanonicalized,
        [NativeTypeName("DWORD *")] uint* pcchCanonicalized,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlCanonicalizeW(
        [NativeTypeName("PCWSTR")] ushort* pszUrl,
        [NativeTypeName("PWSTR")] ushort* pszCanonicalized,
        [NativeTypeName("DWORD *")] uint* pcchCanonicalized,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL UrlIsOpaqueA([NativeTypeName("PCSTR")] sbyte* pszURL);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL UrlIsOpaqueW([NativeTypeName("PCWSTR")] ushort* pszURL);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL UrlIsNoHistoryA([NativeTypeName("PCSTR")] sbyte* pszURL);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL UrlIsNoHistoryW([NativeTypeName("PCWSTR")] ushort* pszURL);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL UrlIsA([NativeTypeName("PCSTR")] sbyte* pszUrl, URLIS UrlIs);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL UrlIsW([NativeTypeName("PCWSTR")] ushort* pszUrl, URLIS UrlIs);

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPCSTR")]
    public static extern sbyte* UrlGetLocationA([NativeTypeName("PCSTR")] sbyte* pszURL);

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPCWSTR")]
    public static extern ushort* UrlGetLocationW([NativeTypeName("PCWSTR")] ushort* pszURL);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlUnescapeA(
        [NativeTypeName("PSTR")] sbyte* pszUrl,
        [NativeTypeName("PSTR")] sbyte* pszUnescaped,
        [NativeTypeName("DWORD *")] uint* pcchUnescaped,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlUnescapeW(
        [NativeTypeName("PWSTR")] ushort* pszUrl,
        [NativeTypeName("PWSTR")] ushort* pszUnescaped,
        [NativeTypeName("DWORD *")] uint* pcchUnescaped,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlEscapeA(
        [NativeTypeName("PCSTR")] sbyte* pszUrl,
        [NativeTypeName("PSTR")] sbyte* pszEscaped,
        [NativeTypeName("DWORD *")] uint* pcchEscaped,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlEscapeW(
        [NativeTypeName("PCWSTR")] ushort* pszUrl,
        [NativeTypeName("PWSTR")] ushort* pszEscaped,
        [NativeTypeName("DWORD *")] uint* pcchEscaped,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlCreateFromPathA(
        [NativeTypeName("PCSTR")] sbyte* pszPath,
        [NativeTypeName("PSTR")] sbyte* pszUrl,
        [NativeTypeName("DWORD *")] uint* pcchUrl,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlCreateFromPathW(
        [NativeTypeName("PCWSTR")] ushort* pszPath,
        [NativeTypeName("PWSTR")] ushort* pszUrl,
        [NativeTypeName("DWORD *")] uint* pcchUrl,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT PathCreateFromUrlA(
        [NativeTypeName("PCSTR")] sbyte* pszUrl,
        [NativeTypeName("PSTR")] sbyte* pszPath,
        [NativeTypeName("DWORD *")] uint* pcchPath,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT PathCreateFromUrlW(
        [NativeTypeName("PCWSTR")] ushort* pszUrl,
        [NativeTypeName("PWSTR")] ushort* pszPath,
        [NativeTypeName("DWORD *")] uint* pcchPath,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT PathCreateFromUrlAlloc(
        [NativeTypeName("PCWSTR")] ushort* pszIn,
        [NativeTypeName("PWSTR *")] ushort** ppszOut,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlHashA(
        [NativeTypeName("PCSTR")] sbyte* pszUrl,
        byte* pbHash,
        [NativeTypeName("DWORD")] uint cbHash
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlHashW(
        [NativeTypeName("PCWSTR")] ushort* pszUrl,
        byte* pbHash,
        [NativeTypeName("DWORD")] uint cbHash
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlGetPartW(
        [NativeTypeName("PCWSTR")] ushort* pszIn,
        [NativeTypeName("PWSTR")] ushort* pszOut,
        [NativeTypeName("DWORD *")] uint* pcchOut,
        [NativeTypeName("DWORD")] uint dwPart,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlGetPartA(
        [NativeTypeName("PCSTR")] sbyte* pszIn,
        [NativeTypeName("PSTR")] sbyte* pszOut,
        [NativeTypeName("DWORD *")] uint* pcchOut,
        [NativeTypeName("DWORD")] uint dwPart,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlApplySchemeA(
        [NativeTypeName("PCSTR")] sbyte* pszIn,
        [NativeTypeName("PSTR")] sbyte* pszOut,
        [NativeTypeName("DWORD *")] uint* pcchOut,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlApplySchemeW(
        [NativeTypeName("PCWSTR")] ushort* pszIn,
        [NativeTypeName("PWSTR")] ushort* pszOut,
        [NativeTypeName("DWORD *")] uint* pcchOut,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT HashData(
        byte* pbData,
        [NativeTypeName("DWORD")] uint cbData,
        byte* pbHash,
        [NativeTypeName("DWORD")] uint cbHash
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlFixupW(
        [NativeTypeName("PCWSTR")] ushort* pcszUrl,
        [NativeTypeName("PWSTR")] ushort* pszTranslatedUrl,
        [NativeTypeName("DWORD")] uint cchMax
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT ParseURLA(
        [NativeTypeName("LPCSTR")] sbyte* pcszURL,
        PARSEDURLA* ppu
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT ParseURLW(
        [NativeTypeName("LPCWSTR")] ushort* pcszURL,
        PARSEDURLW* ppu
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHDeleteEmptyKeyA(
        HKEY hkey,
        [NativeTypeName("LPCSTR")] sbyte* pszSubKey
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHDeleteEmptyKeyW(
        HKEY hkey,
        [NativeTypeName("LPCWSTR")] ushort* pszSubKey
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHDeleteKeyA(HKEY hkey, [NativeTypeName("LPCSTR")] sbyte* pszSubKey);

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHDeleteKeyW(HKEY hkey, [NativeTypeName("LPCWSTR")] ushort* pszSubKey);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HKEY SHRegDuplicateHKey(HKEY hkey);

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHDeleteValueA(
        HKEY hkey,
        [NativeTypeName("LPCSTR")] sbyte* pszSubKey,
        [NativeTypeName("LPCSTR")] sbyte* pszValue
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHDeleteValueW(
        HKEY hkey,
        [NativeTypeName("LPCWSTR")] ushort* pszSubKey,
        [NativeTypeName("LPCWSTR")] ushort* pszValue
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHGetValueA(
        HKEY hkey,
        [NativeTypeName("LPCSTR")] sbyte* pszSubKey,
        [NativeTypeName("LPCSTR")] sbyte* pszValue,
        [NativeTypeName("DWORD *")] uint* pdwType,
        void* pvData,
        [NativeTypeName("DWORD *")] uint* pcbData
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHGetValueW(
        HKEY hkey,
        [NativeTypeName("LPCWSTR")] ushort* pszSubKey,
        [NativeTypeName("LPCWSTR")] ushort* pszValue,
        [NativeTypeName("DWORD *")] uint* pdwType,
        void* pvData,
        [NativeTypeName("DWORD *")] uint* pcbData
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHSetValueA(
        HKEY hkey,
        [NativeTypeName("LPCSTR")] sbyte* pszSubKey,
        [NativeTypeName("LPCSTR")] sbyte* pszValue,
        [NativeTypeName("DWORD")] uint dwType,
        [NativeTypeName("LPCVOID")] void* pvData,
        [NativeTypeName("DWORD")] uint cbData
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHSetValueW(
        HKEY hkey,
        [NativeTypeName("LPCWSTR")] ushort* pszSubKey,
        [NativeTypeName("LPCWSTR")] ushort* pszValue,
        [NativeTypeName("DWORD")] uint dwType,
        [NativeTypeName("LPCVOID")] void* pvData,
        [NativeTypeName("DWORD")] uint cbData
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegGetValueA(
        HKEY hkey,
        [NativeTypeName("LPCSTR")] sbyte* pszSubKey,
        [NativeTypeName("LPCSTR")] sbyte* pszValue,
        [NativeTypeName("SRRF")] int srrfFlags,
        [NativeTypeName("DWORD *")] uint* pdwType,
        void* pvData,
        [NativeTypeName("DWORD *")] uint* pcbData
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegGetValueW(
        HKEY hkey,
        [NativeTypeName("LPCWSTR")] ushort* pszSubKey,
        [NativeTypeName("LPCWSTR")] ushort* pszValue,
        [NativeTypeName("SRRF")] int srrfFlags,
        [NativeTypeName("DWORD *")] uint* pdwType,
        void* pvData,
        [NativeTypeName("DWORD *")] uint* pcbData
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegGetValueFromHKCUHKLM(
        [NativeTypeName("PCWSTR")] ushort* pwszKey,
        [NativeTypeName("PCWSTR")] ushort* pwszValue,
        [NativeTypeName("SRRF")] int srrfFlags,
        [NativeTypeName("DWORD *")] uint* pdwType,
        void* pvData,
        [NativeTypeName("DWORD *")] uint* pcbData
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL SHRegGetBoolValueFromHKCUHKLM(
        [NativeTypeName("PCWSTR")] ushort* pszKey,
        [NativeTypeName("PCWSTR")] ushort* pszValue,
        BOOL fDefault
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHQueryValueExA(
        HKEY hkey,
        [NativeTypeName("LPCSTR")] sbyte* pszValue,
        [NativeTypeName("DWORD *")] uint* pdwReserved,
        [NativeTypeName("DWORD *")] uint* pdwType,
        void* pvData,
        [NativeTypeName("DWORD *")] uint* pcbData
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHQueryValueExW(
        HKEY hkey,
        [NativeTypeName("LPCWSTR")] ushort* pszValue,
        [NativeTypeName("DWORD *")] uint* pdwReserved,
        [NativeTypeName("DWORD *")] uint* pdwType,
        void* pvData,
        [NativeTypeName("DWORD *")] uint* pcbData
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHEnumKeyExA(
        HKEY hkey,
        [NativeTypeName("DWORD")] uint dwIndex,
        [NativeTypeName("LPSTR")] sbyte* pszName,
        [NativeTypeName("LPDWORD")] uint* pcchName
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHEnumKeyExW(
        HKEY hkey,
        [NativeTypeName("DWORD")] uint dwIndex,
        [NativeTypeName("LPWSTR")] ushort* pszName,
        [NativeTypeName("LPDWORD")] uint* pcchName
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHEnumValueA(
        HKEY hkey,
        [NativeTypeName("DWORD")] uint dwIndex,
        [NativeTypeName("PSTR")] sbyte* pszValueName,
        [NativeTypeName("LPDWORD")] uint* pcchValueName,
        [NativeTypeName("LPDWORD")] uint* pdwType,
        void* pvData,
        [NativeTypeName("LPDWORD")] uint* pcbData
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHEnumValueW(
        HKEY hkey,
        [NativeTypeName("DWORD")] uint dwIndex,
        [NativeTypeName("PWSTR")] ushort* pszValueName,
        [NativeTypeName("LPDWORD")] uint* pcchValueName,
        [NativeTypeName("LPDWORD")] uint* pdwType,
        void* pvData,
        [NativeTypeName("LPDWORD")] uint* pcbData
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHQueryInfoKeyA(
        HKEY hkey,
        [NativeTypeName("LPDWORD")] uint* pcSubKeys,
        [NativeTypeName("LPDWORD")] uint* pcchMaxSubKeyLen,
        [NativeTypeName("LPDWORD")] uint* pcValues,
        [NativeTypeName("LPDWORD")] uint* pcchMaxValueNameLen
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHQueryInfoKeyW(
        HKEY hkey,
        [NativeTypeName("LPDWORD")] uint* pcSubKeys,
        [NativeTypeName("LPDWORD")] uint* pcchMaxSubKeyLen,
        [NativeTypeName("LPDWORD")] uint* pcValues,
        [NativeTypeName("LPDWORD")] uint* pcchMaxValueNameLen
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHCopyKeyA(
        HKEY hkeySrc,
        [NativeTypeName("LPCSTR")] sbyte* pszSrcSubKey,
        HKEY hkeyDest,
        [NativeTypeName("DWORD")] uint fReserved
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHCopyKeyW(
        HKEY hkeySrc,
        [NativeTypeName("LPCWSTR")] ushort* pszSrcSubKey,
        HKEY hkeyDest,
        [NativeTypeName("DWORD")] uint fReserved
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegGetPathA(
        HKEY hKey,
        [NativeTypeName("LPCSTR")] sbyte* pcszSubKey,
        [NativeTypeName("LPCSTR")] sbyte* pcszValue,
        [NativeTypeName("LPSTR")] sbyte* pszPath,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegGetPathW(
        HKEY hKey,
        [NativeTypeName("LPCWSTR")] ushort* pcszSubKey,
        [NativeTypeName("LPCWSTR")] ushort* pcszValue,
        [NativeTypeName("LPWSTR")] ushort* pszPath,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegSetPathA(
        HKEY hKey,
        [NativeTypeName("LPCSTR")] sbyte* pcszSubKey,
        [NativeTypeName("LPCSTR")] sbyte* pcszValue,
        [NativeTypeName("LPCSTR")] sbyte* pcszPath,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegSetPathW(
        HKEY hKey,
        [NativeTypeName("LPCWSTR")] ushort* pcszSubKey,
        [NativeTypeName("LPCWSTR")] ushort* pcszValue,
        [NativeTypeName("LPCWSTR")] ushort* pcszPath,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegCreateUSKeyA(
        [NativeTypeName("LPCSTR")] sbyte* pszPath,
        [NativeTypeName("REGSAM")] uint samDesired,
        HUSKEY hRelativeUSKey,
        [NativeTypeName("PHUSKEY")] HUSKEY* phNewUSKey,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegCreateUSKeyW(
        [NativeTypeName("LPCWSTR")] ushort* pwzPath,
        [NativeTypeName("REGSAM")] uint samDesired,
        HUSKEY hRelativeUSKey,
        [NativeTypeName("PHUSKEY")] HUSKEY* phNewUSKey,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegOpenUSKeyA(
        [NativeTypeName("LPCSTR")] sbyte* pszPath,
        [NativeTypeName("REGSAM")] uint samDesired,
        HUSKEY hRelativeUSKey,
        [NativeTypeName("PHUSKEY")] HUSKEY* phNewUSKey,
        BOOL fIgnoreHKCU
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegOpenUSKeyW(
        [NativeTypeName("LPCWSTR")] ushort* pwzPath,
        [NativeTypeName("REGSAM")] uint samDesired,
        HUSKEY hRelativeUSKey,
        [NativeTypeName("PHUSKEY")] HUSKEY* phNewUSKey,
        BOOL fIgnoreHKCU
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegQueryUSValueA(
        HUSKEY hUSKey,
        [NativeTypeName("LPCSTR")] sbyte* pszValue,
        [NativeTypeName("DWORD *")] uint* pdwType,
        void* pvData,
        [NativeTypeName("DWORD *")] uint* pcbData,
        BOOL fIgnoreHKCU,
        void* pvDefaultData,
        [NativeTypeName("DWORD")] uint dwDefaultDataSize
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegQueryUSValueW(
        HUSKEY hUSKey,
        [NativeTypeName("LPCWSTR")] ushort* pszValue,
        [NativeTypeName("DWORD *")] uint* pdwType,
        void* pvData,
        [NativeTypeName("DWORD *")] uint* pcbData,
        BOOL fIgnoreHKCU,
        void* pvDefaultData,
        [NativeTypeName("DWORD")] uint dwDefaultDataSize
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegWriteUSValueA(
        HUSKEY hUSKey,
        [NativeTypeName("LPCSTR")] sbyte* pszValue,
        [NativeTypeName("DWORD")] uint dwType,
        [NativeTypeName("const void *")] void* pvData,
        [NativeTypeName("DWORD")] uint cbData,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegWriteUSValueW(
        HUSKEY hUSKey,
        [NativeTypeName("LPCWSTR")] ushort* pwzValue,
        [NativeTypeName("DWORD")] uint dwType,
        [NativeTypeName("const void *")] void* pvData,
        [NativeTypeName("DWORD")] uint cbData,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegDeleteUSValueA(
        HUSKEY hUSKey,
        [NativeTypeName("LPCSTR")] sbyte* pszValue,
        SHREGDEL_FLAGS delRegFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegDeleteUSValueW(
        HUSKEY hUSKey,
        [NativeTypeName("LPCWSTR")] ushort* pwzValue,
        SHREGDEL_FLAGS delRegFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegDeleteEmptyUSKeyW(
        HUSKEY hUSKey,
        [NativeTypeName("LPCWSTR")] ushort* pwzSubKey,
        SHREGDEL_FLAGS delRegFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegDeleteEmptyUSKeyA(
        HUSKEY hUSKey,
        [NativeTypeName("LPCSTR")] sbyte* pszSubKey,
        SHREGDEL_FLAGS delRegFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegEnumUSKeyA(
        HUSKEY hUSKey,
        [NativeTypeName("DWORD")] uint dwIndex,
        [NativeTypeName("LPSTR")] sbyte* pszName,
        [NativeTypeName("LPDWORD")] uint* pcchName,
        SHREGENUM_FLAGS enumRegFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegEnumUSKeyW(
        HUSKEY hUSKey,
        [NativeTypeName("DWORD")] uint dwIndex,
        [NativeTypeName("LPWSTR")] ushort* pwzName,
        [NativeTypeName("LPDWORD")] uint* pcchName,
        SHREGENUM_FLAGS enumRegFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegEnumUSValueA(
        HUSKEY hUSkey,
        [NativeTypeName("DWORD")] uint dwIndex,
        [NativeTypeName("LPSTR")] sbyte* pszValueName,
        [NativeTypeName("LPDWORD")] uint* pcchValueName,
        [NativeTypeName("LPDWORD")] uint* pdwType,
        void* pvData,
        [NativeTypeName("LPDWORD")] uint* pcbData,
        SHREGENUM_FLAGS enumRegFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegEnumUSValueW(
        HUSKEY hUSkey,
        [NativeTypeName("DWORD")] uint dwIndex,
        [NativeTypeName("LPWSTR")] ushort* pszValueName,
        [NativeTypeName("LPDWORD")] uint* pcchValueName,
        [NativeTypeName("LPDWORD")] uint* pdwType,
        void* pvData,
        [NativeTypeName("LPDWORD")] uint* pcbData,
        SHREGENUM_FLAGS enumRegFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegQueryInfoUSKeyA(
        HUSKEY hUSKey,
        [NativeTypeName("LPDWORD")] uint* pcSubKeys,
        [NativeTypeName("LPDWORD")] uint* pcchMaxSubKeyLen,
        [NativeTypeName("LPDWORD")] uint* pcValues,
        [NativeTypeName("LPDWORD")] uint* pcchMaxValueNameLen,
        SHREGENUM_FLAGS enumRegFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegQueryInfoUSKeyW(
        HUSKEY hUSKey,
        [NativeTypeName("LPDWORD")] uint* pcSubKeys,
        [NativeTypeName("LPDWORD")] uint* pcchMaxSubKeyLen,
        [NativeTypeName("LPDWORD")] uint* pcValues,
        [NativeTypeName("LPDWORD")] uint* pcchMaxValueNameLen,
        SHREGENUM_FLAGS enumRegFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegCloseUSKey(HUSKEY hUSKey);

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegGetUSValueA(
        [NativeTypeName("LPCSTR")] sbyte* pszSubKey,
        [NativeTypeName("LPCSTR")] sbyte* pszValue,
        [NativeTypeName("DWORD *")] uint* pdwType,
        void* pvData,
        [NativeTypeName("DWORD *")] uint* pcbData,
        BOOL fIgnoreHKCU,
        void* pvDefaultData,
        [NativeTypeName("DWORD")] uint dwDefaultDataSize
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegGetUSValueW(
        [NativeTypeName("LPCWSTR")] ushort* pszSubKey,
        [NativeTypeName("LPCWSTR")] ushort* pszValue,
        [NativeTypeName("DWORD *")] uint* pdwType,
        void* pvData,
        [NativeTypeName("DWORD *")] uint* pcbData,
        BOOL fIgnoreHKCU,
        void* pvDefaultData,
        [NativeTypeName("DWORD")] uint dwDefaultDataSize
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegSetUSValueA(
        [NativeTypeName("LPCSTR")] sbyte* pszSubKey,
        [NativeTypeName("LPCSTR")] sbyte* pszValue,
        [NativeTypeName("DWORD")] uint dwType,
        [NativeTypeName("const void *")] void* pvData,
        [NativeTypeName("DWORD")] uint cbData,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegSetUSValueW(
        [NativeTypeName("LPCWSTR")] ushort* pwzSubKey,
        [NativeTypeName("LPCWSTR")] ushort* pwzValue,
        [NativeTypeName("DWORD")] uint dwType,
        [NativeTypeName("const void *")] void* pvData,
        [NativeTypeName("DWORD")] uint cbData,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int SHRegGetIntW(
        HKEY hk,
        [NativeTypeName("PCWSTR")] ushort* pwzKey,
        int iDefault
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL SHRegGetBoolUSValueA(
        [NativeTypeName("LPCSTR")] sbyte* pszSubKey,
        [NativeTypeName("LPCSTR")] sbyte* pszValue,
        BOOL fIgnoreHKCU,
        BOOL fDefault
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL SHRegGetBoolUSValueW(
        [NativeTypeName("LPCWSTR")] ushort* pszSubKey,
        [NativeTypeName("LPCWSTR")] ushort* pszValue,
        BOOL fIgnoreHKCU,
        BOOL fDefault
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT AssocCreate(
        [NativeTypeName("CLSID")] Guid clsid,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("windows.storage", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint SHGetAssocKeys(
        IQueryAssociations pqa,
        HKEY* rgKeys,
        [NativeTypeName("DWORD")] uint cKeys
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT AssocQueryStringA(
        [NativeTypeName("ASSOCF")] uint flags,
        ASSOCSTR str,
        [NativeTypeName("LPCSTR")] sbyte* pszAssoc,
        [NativeTypeName("LPCSTR")] sbyte* pszExtra,
        [NativeTypeName("LPSTR")] sbyte* pszOut,
        [NativeTypeName("DWORD *")] uint* pcchOut
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT AssocQueryStringW(
        [NativeTypeName("ASSOCF")] uint flags,
        ASSOCSTR str,
        [NativeTypeName("LPCWSTR")] ushort* pszAssoc,
        [NativeTypeName("LPCWSTR")] ushort* pszExtra,
        [NativeTypeName("LPWSTR")] ushort* pszOut,
        [NativeTypeName("DWORD *")] uint* pcchOut
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT AssocQueryStringByKeyA(
        [NativeTypeName("ASSOCF")] uint flags,
        ASSOCSTR str,
        HKEY hkAssoc,
        [NativeTypeName("LPCSTR")] sbyte* pszExtra,
        [NativeTypeName("LPSTR")] sbyte* pszOut,
        [NativeTypeName("DWORD *")] uint* pcchOut
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT AssocQueryStringByKeyW(
        [NativeTypeName("ASSOCF")] uint flags,
        ASSOCSTR str,
        HKEY hkAssoc,
        [NativeTypeName("LPCWSTR")] ushort* pszExtra,
        [NativeTypeName("LPWSTR")] ushort* pszOut,
        [NativeTypeName("DWORD *")] uint* pcchOut
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT AssocQueryKeyA(
        [NativeTypeName("ASSOCF")] uint flags,
        ASSOCKEY key,
        [NativeTypeName("LPCSTR")] sbyte* pszAssoc,
        [NativeTypeName("LPCSTR")] sbyte* pszExtra,
        HKEY* phkeyOut
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT AssocQueryKeyW(
        [NativeTypeName("ASSOCF")] uint flags,
        ASSOCKEY key,
        [NativeTypeName("LPCWSTR")] ushort* pszAssoc,
        [NativeTypeName("LPCWSTR")] ushort* pszExtra,
        HKEY* phkeyOut
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL AssocIsDangerous([NativeTypeName("PCWSTR")] ushort* pszAssoc);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT AssocGetPerceivedType(
        [NativeTypeName("PCWSTR")] ushort* pszExt,
        PERCEIVED* ptype,
        [NativeTypeName("PERCEIVEDFLAG *")] uint* pflag,
        [NativeTypeName("PWSTR *")] ushort** ppszType
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern IStream SHOpenRegStreamA(
        HKEY hkey,
        [NativeTypeName("LPCSTR")] sbyte* pszSubkey,
        [NativeTypeName("LPCSTR")] sbyte* pszValue,
        [NativeTypeName("DWORD")] uint grfMode
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern IStream SHOpenRegStreamW(
        HKEY hkey,
        [NativeTypeName("LPCWSTR")] ushort* pszSubkey,
        [NativeTypeName("LPCWSTR")] ushort* pszValue,
        [NativeTypeName("DWORD")] uint grfMode
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern IStream SHOpenRegStream2A(
        HKEY hkey,
        [NativeTypeName("LPCSTR")] sbyte* pszSubkey,
        [NativeTypeName("LPCSTR")] sbyte* pszValue,
        [NativeTypeName("DWORD")] uint grfMode
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern IStream SHOpenRegStream2W(
        HKEY hkey,
        [NativeTypeName("LPCWSTR")] ushort* pszSubkey,
        [NativeTypeName("LPCWSTR")] ushort* pszValue,
        [NativeTypeName("DWORD")] uint grfMode
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT SHCreateStreamOnFileA(
        [NativeTypeName("LPCSTR")] sbyte* pszFile,
        [NativeTypeName("DWORD")] uint grfMode,
        IStream* ppstm
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT SHCreateStreamOnFileW(
        [NativeTypeName("LPCWSTR")] ushort* pszFile,
        [NativeTypeName("DWORD")] uint grfMode,
        IStream* ppstm
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT SHCreateStreamOnFileEx(
        [NativeTypeName("LPCWSTR")] ushort* pszFile,
        [NativeTypeName("DWORD")] uint grfMode,
        [NativeTypeName("DWORD")] uint dwAttributes,
        BOOL fCreate,
        IStream pstmTemplate,
        IStream* ppstm
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern IStream SHCreateMemStream(
        [NativeTypeName("const BYTE *")] byte* pInit,
        uint cbInit
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT GetAcceptLanguagesA(
        [NativeTypeName("LPSTR")] sbyte* pszLanguages,
        [NativeTypeName("DWORD *")] uint* pcchLanguages
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT GetAcceptLanguagesW(
        [NativeTypeName("LPWSTR")] ushort* pszLanguages,
        [NativeTypeName("DWORD *")] uint* pcchLanguages
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void IUnknown_Set(IUnknown* ppunk, IUnknown punk);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void IUnknown_AtomicRelease(void** ppunk);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT IUnknown_GetWindow(IUnknown punk, HWND* phwnd);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT IUnknown_SetSite(IUnknown punk, IUnknown punkSite);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT IUnknown_GetSite(
        IUnknown punk,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT IUnknown_QueryService(
        IUnknown punk,
        [NativeTypeName("const GUID &")] Guid* guidService,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvOut
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT IStream_Read(
        IStream pstm,
        void* pv,
        [NativeTypeName("ULONG")] uint cb
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT IStream_Write(
        IStream pstm,
        [NativeTypeName("const void *")] void* pv,
        [NativeTypeName("ULONG")] uint cb
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT IStream_Reset(IStream pstm);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT IStream_Size(IStream pstm, ULARGE_INTEGER* pui);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT ConnectToConnectionPoint(
        IUnknown punk,
        [NativeTypeName("const IID &")] Guid* riidEvent,
        BOOL fConnect,
        IUnknown punkTarget,
        [NativeTypeName("DWORD *")] uint* pdwCookie,
        IConnectionPoint* ppcpOut
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT IStream_ReadPidl(
        IStream pstm,
        [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlOut
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT IStream_WritePidl(
        IStream pstm,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlWrite
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT IStream_ReadStr(
        IStream pstm,
        [NativeTypeName("PWSTR *")] ushort** ppsz
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT IStream_WriteStr(
        IStream pstm,
        [NativeTypeName("PCWSTR")] ushort* psz
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT IStream_Copy(
        IStream pstmFrom,
        IStream pstmTo,
        [NativeTypeName("DWORD")] uint cb
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT SHGetViewStatePropertyBag(
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
        [NativeTypeName("PCWSTR")] ushort* pszBagName,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int SHFormatDateTimeA(
        [NativeTypeName("const __unaligned FILETIME *")] FILETIME* pft,
        [NativeTypeName("DWORD *")] uint* pdwFlags,
        [NativeTypeName("LPSTR")] sbyte* pszBuf,
        uint cchBuf
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int SHFormatDateTimeW(
        [NativeTypeName("const __unaligned FILETIME *")] FILETIME* pft,
        [NativeTypeName("DWORD *")] uint* pdwFlags,
        [NativeTypeName("LPWSTR")] ushort* pszBuf,
        uint cchBuf
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int SHAnsiToUnicode(
        [NativeTypeName("PCSTR")] sbyte* pszSrc,
        [NativeTypeName("PWSTR")] ushort* pwszDst,
        int cwchBuf
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int SHAnsiToAnsi(
        [NativeTypeName("PCSTR")] sbyte* pszSrc,
        [NativeTypeName("PSTR")] sbyte* pszDst,
        int cchBuf
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int SHUnicodeToAnsi(
        [NativeTypeName("PCWSTR")] ushort* pwszSrc,
        [NativeTypeName("PSTR")] sbyte* pszDst,
        int cchBuf
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int SHUnicodeToUnicode(
        [NativeTypeName("PCWSTR")] ushort* pwzSrc,
        [NativeTypeName("PWSTR")] ushort* pwzDst,
        int cwchBuf
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int SHMessageBoxCheckA(
        HWND hwnd,
        [NativeTypeName("LPCSTR")] sbyte* pszText,
        [NativeTypeName("LPCSTR")] sbyte* pszCaption,
        uint uType,
        int iDefault,
        [NativeTypeName("LPCSTR")] sbyte* pszRegVal
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int SHMessageBoxCheckW(
        HWND hwnd,
        [NativeTypeName("LPCWSTR")] ushort* pszText,
        [NativeTypeName("LPCWSTR")] ushort* pszCaption,
        uint uType,
        int iDefault,
        [NativeTypeName("LPCWSTR")] ushort* pszRegVal
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern LRESULT SHSendMessageBroadcastA(uint uMsg, WPARAM wParam, LPARAM lParam);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern LRESULT SHSendMessageBroadcastW(uint uMsg, WPARAM wParam, LPARAM lParam);

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("CHAR")]
    public static extern sbyte SHStripMneumonicA([NativeTypeName("LPSTR")] sbyte* pszMenu);

    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("WCHAR")]
    public static extern ushort SHStripMneumonicW([NativeTypeName("LPWSTR")] ushort* pszMenu);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL IsOS([NativeTypeName("DWORD")] uint dwOS);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HANDLE SHAllocShared(
        [NativeTypeName("const void *")] void* pvData,
        [NativeTypeName("DWORD")] uint dwSize,
        [NativeTypeName("DWORD")] uint dwProcessId
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SHFreeShared(
        HANDLE hData,
        [NativeTypeName("DWORD")] uint dwProcessId
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void* SHLockShared(
        HANDLE hData,
        [NativeTypeName("DWORD")] uint dwProcessId
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SHUnlockShared(void* pvData);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern uint WhichPlatform();

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT QISearch(
        void* that,
        [NativeTypeName("LPCQITAB")] QITAB* pqit,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL SHIsLowMemoryMachine([NativeTypeName("DWORD")] uint dwType);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int GetMenuPosFromID(HMENU hmenu, uint id);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT SHGetInverseCMAP(
        byte* pbMap,
        [NativeTypeName("ULONG")] uint cbMap
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT SHAutoComplete(
        HWND hwndEdit,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT SHCreateThreadRef(
        [NativeTypeName("LONG *")] int* pcRef,
        IUnknown* ppunk
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT SHSetThreadRef(IUnknown punk);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT SHGetThreadRef(IUnknown* ppunk);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL SHSkipJunction(
        IBindCtx pbc,
        [NativeTypeName("const CLSID *")] Guid* pclsid
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SHCreateThread(
        [NativeTypeName("LPTHREAD_START_ROUTINE")] delegate* unmanaged<void*, uint> pfnThreadProc,
        void* pData,
        [NativeTypeName("SHCT_FLAGS")] uint flags,
        [NativeTypeName("LPTHREAD_START_ROUTINE")] delegate* unmanaged<void*, uint> pfnCallback
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL SHCreateThreadWithHandle(
        [NativeTypeName("LPTHREAD_START_ROUTINE")] delegate* unmanaged<void*, uint> pfnThreadProc,
        void* pData,
        [NativeTypeName("SHCT_FLAGS")] uint flags,
        [NativeTypeName("LPTHREAD_START_ROUTINE")] delegate* unmanaged<void*, uint> pfnCallback,
        HANDLE* pHandle
    );

    [DllImport("api-ms-win-shcore-thread-l1-1-0", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern void SetProcessReference(IUnknown punk);

    [DllImport("api-ms-win-shcore-thread-l1-1-0", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT GetProcessReference(IUnknown* punk);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT SHReleaseThreadRef();

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HPALETTE SHCreateShellPalette(HDC hdc);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void ColorRGBToHLS(
        COLORREF clrRGB,
        [NativeTypeName("WORD *")] ushort* pwHue,
        [NativeTypeName("WORD *")] ushort* pwLuminance,
        [NativeTypeName("WORD *")] ushort* pwSaturation
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern COLORREF ColorHLSToRGB(
        [NativeTypeName("WORD")] ushort wHue,
        [NativeTypeName("WORD")] ushort wLuminance,
        [NativeTypeName("WORD")] ushort wSaturation
    );

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern COLORREF ColorAdjustLuma(COLORREF clrRGB, int n, BOOL fScale);

    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL IsInternetESCEnabled();

    [NativeTypeName("#define STIF_DEFAULT 0x00000000L")]
    public const int STIF_DEFAULT = 0x00000000;

    [NativeTypeName("#define STIF_SUPPORT_HEX 0x00000001L")]
    public const int STIF_SUPPORT_HEX = 0x00000001;

    [NativeTypeName("#define StrRetToStr StrRetToStrW")]
    public static delegate* <STRRET*, ITEMIDLIST*, ushort**, HRESULT> StrRetToStr => &StrRetToStrW;

    [NativeTypeName("#define StrRetToBuf StrRetToBufW")]
    public static delegate* <STRRET*, ITEMIDLIST*, ushort*, uint, HRESULT> StrRetToBuf =>
        &StrRetToBufW;

    [NativeTypeName("#define SHStrDup SHStrDupW")]
    public static delegate* <ushort*, ushort**, HRESULT> SHStrDup => &SHStrDupW;

    [NativeTypeName("#define SHLocalStrDup SHLocalStrDupW")]
    public static delegate* <ushort*, ushort**, HRESULT> SHLocalStrDup => &SHLocalStrDupW;

    [NativeTypeName("#define IsCharSpace IsCharSpaceW")]
    public static delegate* <ushort, BOOL> IsCharSpace => &IsCharSpaceW;

    [NativeTypeName("#define StrCmpC StrCmpCW")]
    public static delegate* <ushort*, ushort*, int> StrCmpC => &StrCmpCW;

    [NativeTypeName("#define StrCmpIC StrCmpICW")]
    public static delegate* <ushort*, ushort*, int> StrCmpIC => &StrCmpICW;

    [NativeTypeName("#define StrChr StrChrW")]
    public static delegate* <ushort*, ushort, ushort*> StrChr => &StrChrW;

    [NativeTypeName("#define StrRChr StrRChrW")]
    public static delegate* <ushort*, ushort*, ushort, ushort*> StrRChr => &StrRChrW;

    [NativeTypeName("#define StrChrI StrChrIW")]
    public static delegate* <ushort*, ushort, ushort*> StrChrI => &StrChrIW;

    [NativeTypeName("#define StrRChrI StrRChrIW")]
    public static delegate* <ushort*, ushort*, ushort, ushort*> StrRChrI => &StrRChrIW;

    [NativeTypeName("#define StrCmpN StrCmpNW")]
    public static delegate* <ushort*, ushort*, int, int> StrCmpN => &StrCmpNW;

    [NativeTypeName("#define StrCmpNI StrCmpNIW")]
    public static delegate* <ushort*, ushort*, int, int> StrCmpNI => &StrCmpNIW;

    [NativeTypeName("#define StrStr StrStrW")]
    public static delegate* <ushort*, ushort*, ushort*> StrStr => &StrStrW;

    [NativeTypeName("#define StrStrI StrStrIW")]
    public static delegate* <ushort*, ushort*, ushort*> StrStrI => &StrStrIW;

    [NativeTypeName("#define StrDup StrDupW")]
    public static delegate* <ushort*, ushort*> StrDup => &StrDupW;

    [NativeTypeName("#define StrRStrI StrRStrIW")]
    public static delegate* <ushort*, ushort*, ushort*, ushort*> StrRStrI => &StrRStrIW;

    [NativeTypeName("#define StrCSpn StrCSpnW")]
    public static delegate* <ushort*, ushort*, int> StrCSpn => &StrCSpnW;

    [NativeTypeName("#define StrCSpnI StrCSpnIW")]
    public static delegate* <ushort*, ushort*, int> StrCSpnI => &StrCSpnIW;

    [NativeTypeName("#define StrSpn StrSpnW")]
    public static delegate* <ushort*, ushort*, int> StrSpn => &StrSpnW;

    [NativeTypeName("#define StrToInt StrToIntW")]
    public static delegate* <ushort*, int> StrToInt => &StrToIntW;

    [NativeTypeName("#define StrPBrk StrPBrkW")]
    public static delegate* <ushort*, ushort*, ushort*> StrPBrk => &StrPBrkW;

    [NativeTypeName("#define StrToIntEx StrToIntExW")]
    public static delegate* <ushort*, int, int*, BOOL> StrToIntEx => &StrToIntExW;

    [NativeTypeName("#define StrToInt64Ex StrToInt64ExW")]
    public static delegate* <ushort*, int, long*, BOOL> StrToInt64Ex => &StrToInt64ExW;

    [NativeTypeName("#define StrFromTimeInterval StrFromTimeIntervalW")]
    public static delegate* <ushort*, uint, uint, int, int> StrFromTimeInterval =>
        &StrFromTimeIntervalW;

    [NativeTypeName("#define StrFormatByteSize StrFormatByteSizeW")]
    public static delegate* <long, ushort*, uint, ushort*> StrFormatByteSize => &StrFormatByteSizeW;

    [NativeTypeName("#define StrFormatByteSize64 StrFormatByteSizeW")]
    public static delegate* <long, ushort*, uint, ushort*> StrFormatByteSize64 =>
        &StrFormatByteSizeW;

    [NativeTypeName("#define StrFormatKBSize StrFormatKBSizeW")]
    public static delegate* <long, ushort*, uint, ushort*> StrFormatKBSize => &StrFormatKBSizeW;

    [NativeTypeName("#define StrNCat StrNCatW")]
    public static delegate* <ushort*, ushort*, int, ushort*> StrNCat => &StrNCatW;

    [NativeTypeName("#define StrTrim StrTrimW")]
    public static delegate* <ushort*, ushort*, BOOL> StrTrim => &StrTrimW;

    [NativeTypeName("#define StrCatBuff StrCatBuffW")]
    public static delegate* <ushort*, ushort*, int, ushort*> StrCatBuff => &StrCatBuffW;

    [NativeTypeName("#define ChrCmpI ChrCmpIW")]
    public static delegate* <ushort, ushort, BOOL> ChrCmpI => &ChrCmpIW;

    [NativeTypeName("#define wvnsprintf wvnsprintfW")]
    public static delegate* <ushort*, int, ushort*, sbyte*, int> wvnsprintf => &wvnsprintfW;

    [NativeTypeName("#define StrIsIntlEqual StrIsIntlEqualW")]
    public static delegate* <BOOL, ushort*, ushort*, int, BOOL> StrIsIntlEqual => &StrIsIntlEqualW;

    [NativeTypeName("#define StrCmpNC StrCmpNCW")]
    public static delegate* <ushort*, ushort*, int, int> StrCmpNC => &StrCmpNCW;

    [NativeTypeName("#define StrCmpNIC StrCmpNICW")]
    public static delegate* <ushort*, ushort*, int, int> StrCmpNIC => &StrCmpNICW;

    [NativeTypeName("#define StrCatA lstrcatA")]
    public static delegate* <sbyte*, sbyte*, sbyte*> StrCatA => &lstrcatA;

    [NativeTypeName("#define StrCmpA lstrcmpA")]
    public static delegate* <sbyte*, sbyte*, int> StrCmpA => &lstrcmpA;

    [NativeTypeName("#define StrCmpIA lstrcmpiA")]
    public static delegate* <sbyte*, sbyte*, int> StrCmpIA => &lstrcmpiA;

    [NativeTypeName("#define StrCpyA lstrcpyA")]
    public static delegate* <sbyte*, sbyte*, sbyte*> StrCpyA => &lstrcpyA;

    [NativeTypeName("#define StrCpyNA lstrcpynA")]
    public static delegate* <sbyte*, sbyte*, int, sbyte*> StrCpyNA => &lstrcpynA;

    [NativeTypeName("#define StrToLong StrToInt")]
    public static delegate* <ushort*, int> StrToLong => &StrToIntW;

    [NativeTypeName("#define StrNCmp StrCmpN")]
    public static delegate* <ushort*, ushort*, int, int> StrNCmp => &StrCmpNW;

    [NativeTypeName("#define StrNCmpI StrCmpNI")]
    public static delegate* <ushort*, ushort*, int, int> StrNCmpI => &StrCmpNIW;

    [NativeTypeName("#define StrNCpy StrCpyN")]
    public static delegate* <ushort*, ushort*, int, ushort*> StrNCpy => &StrCpyNW;

    [NativeTypeName("#define StrCatN StrNCat")]
    public static delegate* <ushort*, ushort*, int, ushort*> StrCatN => &StrNCatW;

    [NativeTypeName("#define StrCat StrCatW")]
    public static delegate* <ushort*, ushort*, ushort*> StrCat => &StrCatW;

    [NativeTypeName("#define StrCmp StrCmpW")]
    public static delegate* <ushort*, ushort*, int> StrCmp => &StrCmpW;

    [NativeTypeName("#define StrCmpI StrCmpIW")]
    public static delegate* <ushort*, ushort*, int> StrCmpI => &StrCmpIW;

    [NativeTypeName("#define StrCpy StrCpyW")]
    public static delegate* <ushort*, ushort*, ushort*> StrCpy => &StrCpyW;

    [NativeTypeName("#define StrCpyN StrCpyNW")]
    public static delegate* <ushort*, ushort*, int, ushort*> StrCpyN => &StrCpyNW;

    [NativeTypeName("#define PathAddBackslash PathAddBackslashW")]
    public static delegate* <ushort*, ushort*> PathAddBackslash => &PathAddBackslashW;

    [NativeTypeName("#define PathAddExtension PathAddExtensionW")]
    public static delegate* <ushort*, ushort*, BOOL> PathAddExtension => &PathAddExtensionW;

    [NativeTypeName("#define PathBuildRoot PathBuildRootW")]
    public static delegate* <ushort*, int, ushort*> PathBuildRoot => &PathBuildRootW;

    [NativeTypeName("#define PathCombine PathCombineW")]
    public static delegate* <ushort*, ushort*, ushort*, ushort*> PathCombine => &PathCombineW;

    [NativeTypeName("#define PathFileExists PathFileExistsW")]
    public static delegate* <ushort*, BOOL> PathFileExists => &PathFileExistsW;

    [NativeTypeName("#define PathFindExtension PathFindExtensionW")]
    public static delegate* <ushort*, ushort*> PathFindExtension => &PathFindExtensionW;

    [NativeTypeName("#define PathFindFileName PathFindFileNameW")]
    public static delegate* <ushort*, ushort*> PathFindFileName => &PathFindFileNameW;

    [NativeTypeName("#define PathFindNextComponent PathFindNextComponentW")]
    public static delegate* <ushort*, ushort*> PathFindNextComponent => &PathFindNextComponentW;

    [NativeTypeName("#define PathFindSuffixArray PathFindSuffixArrayW")]
    public static delegate* <ushort*, ushort**, int, ushort*> PathFindSuffixArray =>
        &PathFindSuffixArrayW;

    [NativeTypeName("#define PathGetArgs PathGetArgsW")]
    public static delegate* <ushort*, ushort*> PathGetArgs => &PathGetArgsW;

    [NativeTypeName("#define PathIsLFNFileSpec PathIsLFNFileSpecW")]
    public static delegate* <ushort*, BOOL> PathIsLFNFileSpec => &PathIsLFNFileSpecW;

    [NativeTypeName("#define GCT_INVALID 0x0000")]
    public const int GCT_INVALID = 0x0000;

    [NativeTypeName("#define GCT_LFNCHAR 0x0001")]
    public const int GCT_LFNCHAR = 0x0001;

    [NativeTypeName("#define GCT_SHORTCHAR 0x0002")]
    public const int GCT_SHORTCHAR = 0x0002;

    [NativeTypeName("#define GCT_WILD 0x0004")]
    public const int GCT_WILD = 0x0004;

    [NativeTypeName("#define GCT_SEPARATOR 0x0008")]
    public const int GCT_SEPARATOR = 0x0008;

    [NativeTypeName("#define PathGetDriveNumber PathGetDriveNumberW")]
    public static delegate* <ushort*, int> PathGetDriveNumber => &PathGetDriveNumberW;

    [NativeTypeName("#define PathIsDirectory PathIsDirectoryW")]
    public static delegate* <ushort*, BOOL> PathIsDirectory => &PathIsDirectoryW;

    [NativeTypeName("#define PathIsDirectoryEmpty PathIsDirectoryEmptyW")]
    public static delegate* <ushort*, BOOL> PathIsDirectoryEmpty => &PathIsDirectoryEmptyW;

    [NativeTypeName("#define PathIsFileSpec PathIsFileSpecW")]
    public static delegate* <ushort*, BOOL> PathIsFileSpec => &PathIsFileSpecW;

    [NativeTypeName("#define PathIsPrefix PathIsPrefixW")]
    public static delegate* <ushort*, ushort*, BOOL> PathIsPrefix => &PathIsPrefixW;

    [NativeTypeName("#define PathIsRelative PathIsRelativeW")]
    public static delegate* <ushort*, BOOL> PathIsRelative => &PathIsRelativeW;

    [NativeTypeName("#define PathIsRoot PathIsRootW")]
    public static delegate* <ushort*, BOOL> PathIsRoot => &PathIsRootW;

    [NativeTypeName("#define PathIsSameRoot PathIsSameRootW")]
    public static delegate* <ushort*, ushort*, BOOL> PathIsSameRoot => &PathIsSameRootW;

    [NativeTypeName("#define PathIsUNC PathIsUNCW")]
    public static delegate* <ushort*, BOOL> PathIsUNC => &PathIsUNCW;

    [NativeTypeName("#define PathIsNetworkPath PathIsNetworkPathW")]
    public static delegate* <ushort*, BOOL> PathIsNetworkPath => &PathIsNetworkPathW;

    [NativeTypeName("#define PathIsUNCServer PathIsUNCServerW")]
    public static delegate* <ushort*, BOOL> PathIsUNCServer => &PathIsUNCServerW;

    [NativeTypeName("#define PathIsUNCServerShare PathIsUNCServerShareW")]
    public static delegate* <ushort*, BOOL> PathIsUNCServerShare => &PathIsUNCServerShareW;

    [NativeTypeName("#define PathIsURL PathIsURLW")]
    public static delegate* <ushort*, BOOL> PathIsURL => &PathIsURLW;

    [NativeTypeName("#define PMSF_NORMAL 0x00000000")]
    public const int PMSF_NORMAL = 0x00000000;

    [NativeTypeName("#define PMSF_MULTIPLE 0x00000001")]
    public const int PMSF_MULTIPLE = 0x00000001;

    [NativeTypeName("#define PMSF_DONT_STRIP_SPACES 0x00010000")]
    public const int PMSF_DONT_STRIP_SPACES = 0x00010000;

    [NativeTypeName("#define PathRemoveBackslash PathRemoveBackslashW")]
    public static delegate* <ushort*, ushort*> PathRemoveBackslash => &PathRemoveBackslashW;

    [NativeTypeName("#define PathSkipRoot PathSkipRootW")]
    public static delegate* <ushort*, ushort*> PathSkipRoot => &PathSkipRootW;

    [NativeTypeName("#define PathStripPath PathStripPathW")]
    public static delegate* <ushort*, void> PathStripPath => &PathStripPathW;

    [NativeTypeName("#define PathStripToRoot PathStripToRootW")]
    public static delegate* <ushort*, BOOL> PathStripToRoot => &PathStripToRootW;

    [NativeTypeName("#define PathMakeSystemFolder PathMakeSystemFolderW")]
    public static delegate* <ushort*, BOOL> PathMakeSystemFolder => &PathMakeSystemFolderW;

    [NativeTypeName("#define PathUnmakeSystemFolder PathUnmakeSystemFolderW")]
    public static delegate* <ushort*, BOOL> PathUnmakeSystemFolder => &PathUnmakeSystemFolderW;

    [NativeTypeName("#define PathIsSystemFolder PathIsSystemFolderW")]
    public static delegate* <ushort*, uint, BOOL> PathIsSystemFolder => &PathIsSystemFolderW;

    [NativeTypeName("#define PathUndecorate PathUndecorateW")]
    public static delegate* <ushort*, void> PathUndecorate => &PathUndecorateW;

    [NativeTypeName("#define PathUnExpandEnvStrings PathUnExpandEnvStringsW")]
    public static delegate* <ushort*, ushort*, uint, BOOL> PathUnExpandEnvStrings =>
        &PathUnExpandEnvStringsW;

    [NativeTypeName("#define PathAppend PathAppendW")]
    public static delegate* <ushort*, ushort*, BOOL> PathAppend => &PathAppendW;

    [NativeTypeName("#define PathCanonicalize PathCanonicalizeW")]
    public static delegate* <ushort*, ushort*, BOOL> PathCanonicalize => &PathCanonicalizeW;

    [NativeTypeName("#define PathCompactPath PathCompactPathW")]
    public static delegate* <HDC, ushort*, uint, BOOL> PathCompactPath => &PathCompactPathW;

    [NativeTypeName("#define PathCompactPathEx PathCompactPathExW")]
    public static delegate* <ushort*, ushort*, uint, uint, BOOL> PathCompactPathEx =>
        &PathCompactPathExW;

    [NativeTypeName("#define PathCommonPrefix PathCommonPrefixW")]
    public static delegate* <ushort*, ushort*, ushort*, int> PathCommonPrefix => &PathCommonPrefixW;

    [NativeTypeName("#define PathFindOnPath PathFindOnPathW")]
    public static delegate* <ushort*, ushort**, BOOL> PathFindOnPath => &PathFindOnPathW;

    [NativeTypeName("#define PathGetCharType PathGetCharTypeW")]
    public static delegate* <ushort, uint> PathGetCharType => &PathGetCharTypeW;

    [NativeTypeName("#define PathIsContentType PathIsContentTypeW")]
    public static delegate* <ushort*, ushort*, BOOL> PathIsContentType => &PathIsContentTypeW;

    [NativeTypeName("#define PathMakePretty PathMakePrettyW")]
    public static delegate* <ushort*, BOOL> PathMakePretty => &PathMakePrettyW;

    [NativeTypeName("#define PathMatchSpec PathMatchSpecW")]
    public static delegate* <ushort*, ushort*, BOOL> PathMatchSpec => &PathMatchSpecW;

    [NativeTypeName("#define PathMatchSpecEx PathMatchSpecExW")]
    public static delegate* <ushort*, ushort*, uint, HRESULT> PathMatchSpecEx => &PathMatchSpecExW;

    [NativeTypeName("#define PathParseIconLocation PathParseIconLocationW")]
    public static delegate* <ushort*, int> PathParseIconLocation => &PathParseIconLocationW;

    [NativeTypeName("#define PathQuoteSpaces PathQuoteSpacesW")]
    public static delegate* <ushort*, BOOL> PathQuoteSpaces => &PathQuoteSpacesW;

    [NativeTypeName("#define PathRelativePathTo PathRelativePathToW")]
    public static delegate* <ushort*, ushort*, uint, ushort*, uint, BOOL> PathRelativePathTo =>
        &PathRelativePathToW;

    [NativeTypeName("#define PathRemoveArgs PathRemoveArgsW")]
    public static delegate* <ushort*, void> PathRemoveArgs => &PathRemoveArgsW;

    [NativeTypeName("#define PathRemoveBlanks PathRemoveBlanksW")]
    public static delegate* <ushort*, void> PathRemoveBlanks => &PathRemoveBlanksW;

    [NativeTypeName("#define PathRemoveExtension PathRemoveExtensionW")]
    public static delegate* <ushort*, void> PathRemoveExtension => &PathRemoveExtensionW;

    [NativeTypeName("#define PathRemoveFileSpec PathRemoveFileSpecW")]
    public static delegate* <ushort*, BOOL> PathRemoveFileSpec => &PathRemoveFileSpecW;

    [NativeTypeName("#define PathRenameExtension PathRenameExtensionW")]
    public static delegate* <ushort*, ushort*, BOOL> PathRenameExtension => &PathRenameExtensionW;

    [NativeTypeName("#define PathSearchAndQualify PathSearchAndQualifyW")]
    public static delegate* <ushort*, ushort*, uint, BOOL> PathSearchAndQualify =>
        &PathSearchAndQualifyW;

    [NativeTypeName("#define PathSetDlgItemPath PathSetDlgItemPathW")]
    public static delegate* <HWND, int, ushort*, void> PathSetDlgItemPath => &PathSetDlgItemPathW;

    [NativeTypeName("#define PathUnquoteSpaces PathUnquoteSpacesW")]
    public static delegate* <ushort*, BOOL> PathUnquoteSpaces => &PathUnquoteSpacesW;

    [NativeTypeName("#define UrlCompare UrlCompareW")]
    public static delegate* <ushort*, ushort*, BOOL, int> UrlCompare => &UrlCompareW;

    [NativeTypeName("#define UrlCombine UrlCombineW")]
    public static delegate* <ushort*, ushort*, ushort*, uint*, uint, HRESULT> UrlCombine =>
        &UrlCombineW;

    [NativeTypeName("#define UrlCanonicalize UrlCanonicalizeW")]
    public static delegate* <ushort*, ushort*, uint*, uint, HRESULT> UrlCanonicalize =>
        &UrlCanonicalizeW;

    [NativeTypeName("#define UrlIsOpaque UrlIsOpaqueW")]
    public static delegate* <ushort*, BOOL> UrlIsOpaque => &UrlIsOpaqueW;

    [NativeTypeName("#define UrlGetLocation UrlGetLocationW")]
    public static delegate* <ushort*, ushort*> UrlGetLocation => &UrlGetLocationW;

    [NativeTypeName("#define UrlUnescape UrlUnescapeW")]
    public static delegate* <ushort*, ushort*, uint*, uint, HRESULT> UrlUnescape => &UrlUnescapeW;

    [NativeTypeName("#define UrlEscape UrlEscapeW")]
    public static delegate* <ushort*, ushort*, uint*, uint, HRESULT> UrlEscape => &UrlEscapeW;

    [NativeTypeName("#define UrlCreateFromPath UrlCreateFromPathW")]
    public static delegate* <ushort*, ushort*, uint*, uint, HRESULT> UrlCreateFromPath =>
        &UrlCreateFromPathW;

    [NativeTypeName("#define PathCreateFromUrl PathCreateFromUrlW")]
    public static delegate* <ushort*, ushort*, uint*, uint, HRESULT> PathCreateFromUrl =>
        &PathCreateFromUrlW;

    [NativeTypeName("#define UrlHash UrlHashW")]
    public static delegate* <ushort*, byte*, uint, HRESULT> UrlHash => &UrlHashW;

    [NativeTypeName("#define UrlGetPart UrlGetPartW")]
    public static delegate* <ushort*, ushort*, uint*, uint, uint, HRESULT> UrlGetPart =>
        &UrlGetPartW;

    [NativeTypeName("#define UrlApplyScheme UrlApplySchemeW")]
    public static delegate* <ushort*, ushort*, uint*, uint, HRESULT> UrlApplyScheme =>
        &UrlApplySchemeW;

    [NativeTypeName("#define UrlIs UrlIsW")]
    public static delegate* <ushort*, URLIS, BOOL> UrlIs => &UrlIsW;

    [NativeTypeName("#define UrlFixup UrlFixupW")]
    public static delegate* <ushort*, ushort*, uint, HRESULT> UrlFixup => &UrlFixupW;

    [NativeTypeName("#define ParseURL ParseURLW")]
    public static delegate* <ushort*, PARSEDURLW*, HRESULT> ParseURL => &ParseURLW;

    [NativeTypeName("#define SHDeleteEmptyKey SHDeleteEmptyKeyW")]
    public static delegate* <HKEY, ushort*, int> SHDeleteEmptyKey => &SHDeleteEmptyKeyW;

    [NativeTypeName("#define SHDeleteKey SHDeleteKeyW")]
    public static delegate* <HKEY, ushort*, int> SHDeleteKey => &SHDeleteKeyW;

    [NativeTypeName("#define SHDeleteValue SHDeleteValueW")]
    public static delegate* <HKEY, ushort*, ushort*, int> SHDeleteValue => &SHDeleteValueW;

    [NativeTypeName("#define SHGetValue SHGetValueW")]
    public static delegate* <HKEY, ushort*, ushort*, uint*, void*, uint*, int> SHGetValue =>
        &SHGetValueW;

    [NativeTypeName("#define SHSetValue SHSetValueW")]
    public static delegate* <HKEY, ushort*, ushort*, uint, void*, uint, int> SHSetValue =>
        &SHSetValueW;

    [NativeTypeName("#define SHRegGetValue SHRegGetValueW")]
    public static delegate* <HKEY, ushort*, ushort*, int, uint*, void*, uint*, int> SHRegGetValue =>
        &SHRegGetValueW;

    [NativeTypeName("#define SHQueryValueEx SHQueryValueExW")]
    public static delegate* <HKEY, ushort*, uint*, uint*, void*, uint*, int> SHQueryValueEx =>
        &SHQueryValueExW;

    [NativeTypeName("#define SHEnumKeyEx SHEnumKeyExW")]
    public static delegate* <HKEY, uint, ushort*, uint*, int> SHEnumKeyEx => &SHEnumKeyExW;

    [NativeTypeName("#define SHEnumValue SHEnumValueW")]
    public static delegate* <HKEY, uint, ushort*, uint*, uint*, void*, uint*, int> SHEnumValue =>
        &SHEnumValueW;

    [NativeTypeName("#define SHQueryInfoKey SHQueryInfoKeyW")]
    public static delegate* <HKEY, uint*, uint*, uint*, uint*, int> SHQueryInfoKey =>
        &SHQueryInfoKeyW;

    [NativeTypeName("#define SHCopyKey SHCopyKeyW")]
    public static delegate* <HKEY, ushort*, HKEY, uint, int> SHCopyKey => &SHCopyKeyW;

    [NativeTypeName("#define SHRegGetPath SHRegGetPathW")]
    public static delegate* <HKEY, ushort*, ushort*, ushort*, uint, int> SHRegGetPath =>
        &SHRegGetPathW;

    [NativeTypeName("#define SHRegSetPath SHRegSetPathW")]
    public static delegate* <HKEY, ushort*, ushort*, ushort*, uint, int> SHRegSetPath =>
        &SHRegSetPathW;

    [NativeTypeName("#define SHREGSET_HKCU 0x00000001")]
    public const int SHREGSET_HKCU = 0x00000001;

    [NativeTypeName("#define SHREGSET_FORCE_HKCU 0x00000002")]
    public const int SHREGSET_FORCE_HKCU = 0x00000002;

    [NativeTypeName("#define SHREGSET_HKLM 0x00000004")]
    public const int SHREGSET_HKLM = 0x00000004;

    [NativeTypeName("#define SHREGSET_FORCE_HKLM 0x00000008")]
    public const int SHREGSET_FORCE_HKLM = 0x00000008;

    [NativeTypeName("#define SHREGSET_DEFAULT (SHREGSET_FORCE_HKCU | SHREGSET_HKLM)")]
    public const int SHREGSET_DEFAULT = (0x00000002 | 0x00000004);

    [NativeTypeName("#define SHRegCreateUSKey SHRegCreateUSKeyW")]
    public static delegate* <ushort*, uint, HUSKEY, HUSKEY*, uint, int> SHRegCreateUSKey =>
        &SHRegCreateUSKeyW;

    [NativeTypeName("#define SHRegOpenUSKey SHRegOpenUSKeyW")]
    public static delegate* <ushort*, uint, HUSKEY, HUSKEY*, BOOL, int> SHRegOpenUSKey =>
        &SHRegOpenUSKeyW;

    [NativeTypeName("#define SHRegQueryUSValue SHRegQueryUSValueW")]
    public static delegate* <
        HUSKEY,
        ushort*,
        uint*,
        void*,
        uint*,
        BOOL,
        void*,
        uint,
        int> SHRegQueryUSValue => &SHRegQueryUSValueW;

    [NativeTypeName("#define SHRegWriteUSValue SHRegWriteUSValueW")]
    public static delegate* <HUSKEY, ushort*, uint, void*, uint, uint, int> SHRegWriteUSValue =>
        &SHRegWriteUSValueW;

    [NativeTypeName("#define SHRegDeleteUSValue SHRegDeleteUSValueW")]
    public static delegate* <HUSKEY, ushort*, SHREGDEL_FLAGS, int> SHRegDeleteUSValue =>
        &SHRegDeleteUSValueW;

    [NativeTypeName("#define SHRegDeleteEmptyUSKey SHRegDeleteEmptyUSKeyW")]
    public static delegate* <HUSKEY, ushort*, SHREGDEL_FLAGS, int> SHRegDeleteEmptyUSKey =>
        &SHRegDeleteEmptyUSKeyW;

    [NativeTypeName("#define SHRegEnumUSKey SHRegEnumUSKeyW")]
    public static delegate* <HUSKEY, uint, ushort*, uint*, SHREGENUM_FLAGS, int> SHRegEnumUSKey =>
        &SHRegEnumUSKeyW;

    [NativeTypeName("#define SHRegEnumUSValue SHRegEnumUSValueW")]
    public static delegate* <
        HUSKEY,
        uint,
        ushort*,
        uint*,
        uint*,
        void*,
        uint*,
        SHREGENUM_FLAGS,
        int> SHRegEnumUSValue => &SHRegEnumUSValueW;

    [NativeTypeName("#define SHRegQueryInfoUSKey SHRegQueryInfoUSKeyW")]
    public static delegate* <
        HUSKEY,
        uint*,
        uint*,
        uint*,
        uint*,
        SHREGENUM_FLAGS,
        int> SHRegQueryInfoUSKey => &SHRegQueryInfoUSKeyW;

    [NativeTypeName("#define SHRegGetUSValue SHRegGetUSValueW")]
    public static delegate* <
        ushort*,
        ushort*,
        uint*,
        void*,
        uint*,
        BOOL,
        void*,
        uint,
        int> SHRegGetUSValue => &SHRegGetUSValueW;

    [NativeTypeName("#define SHRegSetUSValue SHRegSetUSValueW")]
    public static delegate* <ushort*, ushort*, uint, void*, uint, uint, int> SHRegSetUSValue =>
        &SHRegSetUSValueW;

    [NativeTypeName("#define SHRegGetInt SHRegGetIntW")]
    public static delegate* <HKEY, ushort*, int, int> SHRegGetInt => &SHRegGetIntW;

    [NativeTypeName("#define SHRegGetBoolUSValue SHRegGetBoolUSValueW")]
    public static delegate* <ushort*, ushort*, BOOL, BOOL, BOOL> SHRegGetBoolUSValue =>
        &SHRegGetBoolUSValueW;

    [NativeTypeName("#define AssocQueryString AssocQueryStringW")]
    public static delegate* <
        uint,
        ASSOCSTR,
        ushort*,
        ushort*,
        ushort*,
        uint*,
        HRESULT> AssocQueryString => &AssocQueryStringW;

    [NativeTypeName("#define AssocQueryStringByKey AssocQueryStringByKeyW")]
    public static delegate* <
        uint,
        ASSOCSTR,
        HKEY,
        ushort*,
        ushort*,
        uint*,
        HRESULT> AssocQueryStringByKey => &AssocQueryStringByKeyW;

    [NativeTypeName("#define AssocQueryKey AssocQueryKeyW")]
    public static delegate* <uint, ASSOCKEY, ushort*, ushort*, HKEY*, HRESULT> AssocQueryKey =>
        &AssocQueryKeyW;

    [NativeTypeName("#define SHOpenRegStream SHOpenRegStreamW")]
    public static delegate* <HKEY, ushort*, ushort*, uint, IStream> SHOpenRegStream =>
        &SHOpenRegStreamW;

    [NativeTypeName("#define SHOpenRegStream2 SHOpenRegStream2W")]
    public static delegate* <HKEY, ushort*, ushort*, uint, IStream> SHOpenRegStream2 =>
        &SHOpenRegStream2W;

    [NativeTypeName("#define SHCreateStreamOnFile SHCreateStreamOnFileW")]
    public static delegate* <ushort*, uint, IStream*, HRESULT> SHCreateStreamOnFile =>
        &SHCreateStreamOnFileW;

    [NativeTypeName("#define GetAcceptLanguages GetAcceptLanguagesW")]
    public static delegate* <ushort*, uint*, HRESULT> GetAcceptLanguages => &GetAcceptLanguagesW;

    [NativeTypeName("#define FDTF_SHORTTIME 0x00000001")]
    public const int FDTF_SHORTTIME = 0x00000001;

    [NativeTypeName("#define FDTF_SHORTDATE 0x00000002")]
    public const int FDTF_SHORTDATE = 0x00000002;

    [NativeTypeName("#define FDTF_DEFAULT (FDTF_SHORTDATE | FDTF_SHORTTIME)")]
    public const int FDTF_DEFAULT = (0x00000002 | 0x00000001);

    [NativeTypeName("#define FDTF_LONGDATE 0x00000004")]
    public const int FDTF_LONGDATE = 0x00000004;

    [NativeTypeName("#define FDTF_LONGTIME 0x00000008")]
    public const int FDTF_LONGTIME = 0x00000008;

    [NativeTypeName("#define FDTF_RELATIVE 0x00000010")]
    public const int FDTF_RELATIVE = 0x00000010;

    [NativeTypeName("#define FDTF_LTRDATE 0x00000100")]
    public const int FDTF_LTRDATE = 0x00000100;

    [NativeTypeName("#define FDTF_RTLDATE 0x00000200")]
    public const int FDTF_RTLDATE = 0x00000200;

    [NativeTypeName("#define FDTF_NOAUTOREADINGORDER 0x00000400")]
    public const int FDTF_NOAUTOREADINGORDER = 0x00000400;

    [NativeTypeName("#define SHFormatDateTime SHFormatDateTimeW")]
    public static delegate* <FILETIME*, uint*, ushort*, uint, int> SHFormatDateTime =>
        &SHFormatDateTimeW;

    [NativeTypeName("#define SHMessageBoxCheck SHMessageBoxCheckW")]
    public static delegate* <HWND, ushort*, ushort*, uint, int, ushort*, int> SHMessageBoxCheck =>
        &SHMessageBoxCheckW;

    [NativeTypeName("#define SHSendMessageBroadcast SHSendMessageBroadcastW")]
    public static delegate* <uint, WPARAM, LPARAM, LRESULT> SHSendMessageBroadcast =>
        &SHSendMessageBroadcastW;

    [NativeTypeName("#define SHStripMneumonic SHStripMneumonicW")]
    public static delegate* <ushort*, ushort> SHStripMneumonic => &SHStripMneumonicW;

    [NativeTypeName("#define PLATFORM_UNKNOWN 0")]
    public const int PLATFORM_UNKNOWN = 0;

    [NativeTypeName("#define PLATFORM_IE3 1")]
    public const int PLATFORM_IE3 = 1;

    [NativeTypeName("#define PLATFORM_BROWSERONLY 1")]
    public const int PLATFORM_BROWSERONLY = 1;

    [NativeTypeName("#define PLATFORM_INTEGRATED 2")]
    public const int PLATFORM_INTEGRATED = 2;

    [NativeTypeName("#define ILMM_IE4 0")]
    public const int ILMM_IE4 = 0;

    [NativeTypeName("#define DLLVER_PLATFORM_WINDOWS 0x00000001")]
    public const int DLLVER_PLATFORM_WINDOWS = 0x00000001;

    [NativeTypeName("#define DLLVER_PLATFORM_NT 0x00000002")]
    public const int DLLVER_PLATFORM_NT = 0x00000002;

    [NativeTypeName("#define DLLVER_MAJOR_MASK 0xFFFF000000000000")]
    public const ulong DLLVER_MAJOR_MASK = 0xFFFF000000000000;

    [NativeTypeName("#define DLLVER_MINOR_MASK 0x0000FFFF00000000")]
    public const long DLLVER_MINOR_MASK = 0x0000FFFF00000000;

    [NativeTypeName("#define DLLVER_BUILD_MASK 0x00000000FFFF0000")]
    public const uint DLLVER_BUILD_MASK = 0x00000000FFFF0000;

    [NativeTypeName("#define DLLVER_QFE_MASK 0x000000000000FFFF")]
    public const int DLLVER_QFE_MASK = 0x000000000000FFFF;
}
