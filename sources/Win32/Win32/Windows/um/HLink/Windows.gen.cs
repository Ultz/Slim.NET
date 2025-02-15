// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/HLink.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("hlink", ExactSpelling = true)]
    public static extern HRESULT HlinkCreateFromMoniker(
        IMoniker pimkTrgt,
        [NativeTypeName("LPCWSTR")] ushort* pwzLocation,
        [NativeTypeName("LPCWSTR")] ushort* pwzFriendlyName,
        IHlinkSite pihlsite,
        [NativeTypeName("DWORD")] uint dwSiteData,
        IUnknown piunkOuter,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvObj
    );

    [DllImport("hlink", ExactSpelling = true)]
    public static extern HRESULT HlinkCreateFromString(
        [NativeTypeName("LPCWSTR")] ushort* pwzTarget,
        [NativeTypeName("LPCWSTR")] ushort* pwzLocation,
        [NativeTypeName("LPCWSTR")] ushort* pwzFriendlyName,
        IHlinkSite pihlsite,
        [NativeTypeName("DWORD")] uint dwSiteData,
        IUnknown piunkOuter,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvObj
    );

    [DllImport("hlink", ExactSpelling = true)]
    public static extern HRESULT HlinkCreateFromData(
        IDataObject piDataObj,
        IHlinkSite pihlsite,
        [NativeTypeName("DWORD")] uint dwSiteData,
        IUnknown piunkOuter,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvObj
    );

    [DllImport("hlink", ExactSpelling = true)]
    public static extern HRESULT HlinkQueryCreateFromData(IDataObject piDataObj);

    [DllImport("hlink", ExactSpelling = true)]
    public static extern HRESULT HlinkClone(
        IHlink pihl,
        [NativeTypeName("const IID &")] Guid* riid,
        IHlinkSite pihlsiteForClone,
        [NativeTypeName("DWORD")] uint dwSiteData,
        void** ppvObj
    );

    [DllImport("hlink", ExactSpelling = true)]
    public static extern HRESULT HlinkCreateBrowseContext(
        IUnknown piunkOuter,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvObj
    );

    [DllImport("hlink", ExactSpelling = true)]
    public static extern HRESULT HlinkNavigateToStringReference(
        [NativeTypeName("LPCWSTR")] ushort* pwzTarget,
        [NativeTypeName("LPCWSTR")] ushort* pwzLocation,
        IHlinkSite pihlsite,
        [NativeTypeName("DWORD")] uint dwSiteData,
        IHlinkFrame pihlframe,
        [NativeTypeName("DWORD")] uint grfHLNF,
        [NativeTypeName("LPBC")] IBindCtx pibc,
        IBindStatusCallback pibsc,
        IHlinkBrowseContext pihlbc
    );

    [DllImport("hlink", ExactSpelling = true)]
    public static extern HRESULT HlinkNavigate(
        IHlink pihl,
        IHlinkFrame pihlframe,
        [NativeTypeName("DWORD")] uint grfHLNF,
        [NativeTypeName("LPBC")] IBindCtx pbc,
        IBindStatusCallback pibsc,
        IHlinkBrowseContext pihlbc
    );

    [DllImport("hlink", ExactSpelling = true)]
    public static extern HRESULT HlinkOnNavigate(
        IHlinkFrame pihlframe,
        IHlinkBrowseContext pihlbc,
        [NativeTypeName("DWORD")] uint grfHLNF,
        IMoniker pimkTarget,
        [NativeTypeName("LPCWSTR")] ushort* pwzLocation,
        [NativeTypeName("LPCWSTR")] ushort* pwzFriendlyName,
        [NativeTypeName("ULONG *")] uint* puHLID
    );

    [DllImport("hlink", ExactSpelling = true)]
    public static extern HRESULT HlinkUpdateStackItem(
        IHlinkFrame pihlframe,
        IHlinkBrowseContext pihlbc,
        [NativeTypeName("ULONG")] uint uHLID,
        IMoniker pimkTrgt,
        [NativeTypeName("LPCWSTR")] ushort* pwzLocation,
        [NativeTypeName("LPCWSTR")] ushort* pwzFriendlyName
    );

    [DllImport("hlink", ExactSpelling = true)]
    public static extern HRESULT HlinkOnRenameDocument(
        [NativeTypeName("DWORD")] uint dwReserved,
        IHlinkBrowseContext pihlbc,
        IMoniker pimkOld,
        IMoniker pimkNew
    );

    [DllImport("hlink", ExactSpelling = true)]
    public static extern HRESULT HlinkResolveMonikerForData(
        [NativeTypeName("LPMONIKER")] IMoniker pimkReference,
        [NativeTypeName("DWORD")] uint reserved,
        [NativeTypeName("LPBC")] IBindCtx pibc,
        [NativeTypeName("ULONG")] uint cFmtetc,
        FORMATETC* rgFmtetc,
        IBindStatusCallback pibsc,
        [NativeTypeName("LPMONIKER")] IMoniker pimkBase
    );

    [DllImport("hlink", ExactSpelling = true)]
    public static extern HRESULT HlinkResolveStringForData(
        [NativeTypeName("LPCWSTR")] ushort* pwzReference,
        [NativeTypeName("DWORD")] uint reserved,
        [NativeTypeName("LPBC")] IBindCtx pibc,
        [NativeTypeName("ULONG")] uint cFmtetc,
        FORMATETC* rgFmtetc,
        IBindStatusCallback pibsc,
        [NativeTypeName("LPMONIKER")] IMoniker pimkBase
    );

    [DllImport("hlink", ExactSpelling = true)]
    public static extern HRESULT HlinkParseDisplayName(
        [NativeTypeName("LPBC")] IBindCtx pibc,
        [NativeTypeName("LPCWSTR")] ushort* pwzDisplayName,
        BOOL fNoForceAbs,
        [NativeTypeName("ULONG *")] uint* pcchEaten,
        IMoniker* ppimk
    );

    [DllImport("hlink", ExactSpelling = true)]
    public static extern HRESULT HlinkCreateExtensionServices(
        [NativeTypeName("LPCWSTR")] ushort* pwzAdditionalHeaders,
        HWND phwnd,
        [NativeTypeName("LPCWSTR")] ushort* pszUsername,
        [NativeTypeName("LPCWSTR")] ushort* pszPassword,
        IUnknown piunkOuter,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvObj
    );

    [DllImport("hlink", ExactSpelling = true)]
    public static extern HRESULT HlinkPreprocessMoniker(
        [NativeTypeName("LPBC")] IBindCtx pibc,
        IMoniker pimkIn,
        IMoniker* ppimkOut
    );

    [DllImport("hlink", ExactSpelling = true)]
    public static extern HRESULT OleSaveToStreamEx(IUnknown piunk, IStream pistm, BOOL fClearDirty);

    [DllImport("hlink", ExactSpelling = true)]
    public static extern HRESULT HlinkSetSpecialReference(
        [NativeTypeName("ULONG")] uint uReference,
        [NativeTypeName("LPCWSTR")] ushort* pwzReference
    );

    [DllImport("hlink", ExactSpelling = true)]
    public static extern HRESULT HlinkGetSpecialReference(
        [NativeTypeName("ULONG")] uint uReference,
        [NativeTypeName("LPWSTR *")] ushort** ppwzReference
    );

    [DllImport("hlink", ExactSpelling = true)]
    public static extern HRESULT HlinkCreateShortcut(
        [NativeTypeName("DWORD")] uint grfHLSHORTCUTF,
        IHlink pihl,
        [NativeTypeName("LPCWSTR")] ushort* pwzDir,
        [NativeTypeName("LPCWSTR")] ushort* pwzFileName,
        [NativeTypeName("LPWSTR *")] ushort** ppwzShortcutFile,
        [NativeTypeName("DWORD")] uint dwReserved
    );

    [DllImport("hlink", ExactSpelling = true)]
    public static extern HRESULT HlinkCreateShortcutFromMoniker(
        [NativeTypeName("DWORD")] uint grfHLSHORTCUTF,
        IMoniker pimkTarget,
        [NativeTypeName("LPCWSTR")] ushort* pwzLocation,
        [NativeTypeName("LPCWSTR")] ushort* pwzDir,
        [NativeTypeName("LPCWSTR")] ushort* pwzFileName,
        [NativeTypeName("LPWSTR *")] ushort** ppwzShortcutFile,
        [NativeTypeName("DWORD")] uint dwReserved
    );

    [DllImport("hlink", ExactSpelling = true)]
    public static extern HRESULT HlinkCreateShortcutFromString(
        [NativeTypeName("DWORD")] uint grfHLSHORTCUTF,
        [NativeTypeName("LPCWSTR")] ushort* pwzTarget,
        [NativeTypeName("LPCWSTR")] ushort* pwzLocation,
        [NativeTypeName("LPCWSTR")] ushort* pwzDir,
        [NativeTypeName("LPCWSTR")] ushort* pwzFileName,
        [NativeTypeName("LPWSTR *")] ushort** ppwzShortcutFile,
        [NativeTypeName("DWORD")] uint dwReserved
    );

    [DllImport("hlink", ExactSpelling = true)]
    public static extern HRESULT HlinkResolveShortcut(
        [NativeTypeName("LPCWSTR")] ushort* pwzShortcutFileName,
        IHlinkSite pihlsite,
        [NativeTypeName("DWORD")] uint dwSiteData,
        IUnknown piunkOuter,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvObj
    );

    [DllImport("hlink", ExactSpelling = true)]
    public static extern HRESULT HlinkResolveShortcutToMoniker(
        [NativeTypeName("LPCWSTR")] ushort* pwzShortcutFileName,
        IMoniker* ppimkTarget,
        [NativeTypeName("LPWSTR *")] ushort** ppwzLocation
    );

    [DllImport("hlink", ExactSpelling = true)]
    public static extern HRESULT HlinkResolveShortcutToString(
        [NativeTypeName("LPCWSTR")] ushort* pwzShortcutFileName,
        [NativeTypeName("LPWSTR *")] ushort** ppwzTarget,
        [NativeTypeName("LPWSTR *")] ushort** ppwzLocation
    );

    [DllImport("hlink", ExactSpelling = true)]
    public static extern HRESULT HlinkIsShortcut([NativeTypeName("LPCWSTR")] ushort* pwzFileName);

    [DllImport("hlink", ExactSpelling = true)]
    public static extern HRESULT HlinkGetValueFromParams(
        [NativeTypeName("LPCWSTR")] ushort* pwzParams,
        [NativeTypeName("LPCWSTR")] ushort* pwzName,
        [NativeTypeName("LPWSTR *")] ushort** ppwzValue
    );

    [DllImport("hlink", ExactSpelling = true)]
    public static extern HRESULT HlinkTranslateURL(
        [NativeTypeName("LPCWSTR")] ushort* pwzURL,
        [NativeTypeName("DWORD")] uint grfFlags,
        [NativeTypeName("LPWSTR *")] ushort** ppwzTranslatedURL
    );

    [NativeTypeName("#define HLINK_E_FIRST (OLE_E_LAST+1)")]
    public const int HLINK_E_FIRST = unchecked(((int)(0x800400FF)) + 1);

    [NativeTypeName("#define HLINK_S_FIRST (OLE_S_LAST+1)")]
    public const int HLINK_S_FIRST = (((int)(0x000400FF)) + 1);

    [NativeTypeName("#define HLINK_S_DONTHIDE (HLINK_S_FIRST)")]
    public const int HLINK_S_DONTHIDE = ((((int)(0x000400FF)) + 1));
}
