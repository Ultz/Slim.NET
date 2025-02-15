// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("winhttp", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("WINHTTP_STATUS_CALLBACK")]
    public static extern delegate* unmanaged<
        HINTERNET,
        nuint,
        uint,
        void*,
        uint,
        void> WinHttpSetStatusCallback(
        HINTERNET hInternet,
        [NativeTypeName("WINHTTP_STATUS_CALLBACK")]
            delegate* unmanaged<HINTERNET, nuint, uint, void*, uint, void> lpfnInternetCallback,
        [NativeTypeName("DWORD")] uint dwNotificationFlags,
        [NativeTypeName("DWORD_PTR")] nuint dwReserved
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WinHttpTimeFromSystemTime(
        [NativeTypeName("const SYSTEMTIME *")] SYSTEMTIME* pst,
        [NativeTypeName("LPWSTR")] ushort* pwszTime
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WinHttpTimeToSystemTime(
        [NativeTypeName("LPCWSTR")] ushort* pwszTime,
        SYSTEMTIME* pst
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WinHttpCrackUrl(
        [NativeTypeName("LPCWSTR")] ushort* pwszUrl,
        [NativeTypeName("DWORD")] uint dwUrlLength,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPURL_COMPONENTS")] URL_COMPONENTS* lpUrlComponents
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WinHttpCreateUrl(
        [NativeTypeName("LPURL_COMPONENTS")] URL_COMPONENTS* lpUrlComponents,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPWSTR")] ushort* pwszUrl,
        [NativeTypeName("LPDWORD")] uint* pdwUrlLength
    );

    [DllImport("winhttp", ExactSpelling = true)]
    public static extern BOOL WinHttpCheckPlatform();

    [DllImport("winhttp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WinHttpGetDefaultProxyConfiguration(WINHTTP_PROXY_INFO* pProxyInfo);

    [DllImport("winhttp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WinHttpSetDefaultProxyConfiguration(WINHTTP_PROXY_INFO* pProxyInfo);

    [DllImport("winhttp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HINTERNET WinHttpOpen(
        [NativeTypeName("LPCWSTR")] ushort* pszAgentW,
        [NativeTypeName("DWORD")] uint dwAccessType,
        [NativeTypeName("LPCWSTR")] ushort* pszProxyW,
        [NativeTypeName("LPCWSTR")] ushort* pszProxyBypassW,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WinHttpCloseHandle(HINTERNET hInternet);

    [DllImport("winhttp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HINTERNET WinHttpConnect(
        HINTERNET hSession,
        [NativeTypeName("LPCWSTR")] ushort* pswzServerName,
        [NativeTypeName("INTERNET_PORT")] ushort nServerPort,
        [NativeTypeName("DWORD")] uint dwReserved
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WinHttpReadData(
        HINTERNET hRequest,
        [NativeTypeName("LPVOID")] void* lpBuffer,
        [NativeTypeName("DWORD")] uint dwNumberOfBytesToRead,
        [NativeTypeName("LPDWORD")] uint* lpdwNumberOfBytesRead
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern uint WinHttpReadDataEx(
        HINTERNET hRequest,
        [NativeTypeName("LPVOID")] void* lpBuffer,
        [NativeTypeName("DWORD")] uint dwNumberOfBytesToRead,
        [NativeTypeName("LPDWORD")] uint* lpdwNumberOfBytesRead,
        [NativeTypeName("ULONGLONG")] ulong ullFlags,
        [NativeTypeName("DWORD")] uint cbProperty,
        [NativeTypeName("PVOID")] void* pvProperty
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WinHttpWriteData(
        HINTERNET hRequest,
        [NativeTypeName("LPCVOID")] void* lpBuffer,
        [NativeTypeName("DWORD")] uint dwNumberOfBytesToWrite,
        [NativeTypeName("LPDWORD")] uint* lpdwNumberOfBytesWritten
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WinHttpQueryDataAvailable(
        HINTERNET hRequest,
        [NativeTypeName("LPDWORD")] uint* lpdwNumberOfBytesAvailable
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WinHttpQueryOption(
        HINTERNET hInternet,
        [NativeTypeName("DWORD")] uint dwOption,
        [NativeTypeName("LPVOID")] void* lpBuffer,
        [NativeTypeName("LPDWORD")] uint* lpdwBufferLength
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WinHttpSetOption(
        HINTERNET hInternet,
        [NativeTypeName("DWORD")] uint dwOption,
        [NativeTypeName("LPVOID")] void* lpBuffer,
        [NativeTypeName("DWORD")] uint dwBufferLength
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WinHttpSetTimeouts(
        HINTERNET hInternet,
        int nResolveTimeout,
        int nConnectTimeout,
        int nSendTimeout,
        int nReceiveTimeout
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HINTERNET WinHttpOpenRequest(
        HINTERNET hConnect,
        [NativeTypeName("LPCWSTR")] ushort* pwszVerb,
        [NativeTypeName("LPCWSTR")] ushort* pwszObjectName,
        [NativeTypeName("LPCWSTR")] ushort* pwszVersion,
        [NativeTypeName("LPCWSTR")] ushort* pwszReferrer,
        [NativeTypeName("LPCWSTR *")] ushort** ppwszAcceptTypes,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WinHttpAddRequestHeaders(
        HINTERNET hRequest,
        [NativeTypeName("LPCWSTR")] ushort* lpszHeaders,
        [NativeTypeName("DWORD")] uint dwHeadersLength,
        [NativeTypeName("DWORD")] uint dwModifiers
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern uint WinHttpAddRequestHeadersEx(
        HINTERNET hRequest,
        [NativeTypeName("DWORD")] uint dwModifiers,
        [NativeTypeName("ULONGLONG")] ulong ullFlags,
        [NativeTypeName("ULONGLONG")] ulong ullExtra,
        [NativeTypeName("DWORD")] uint cHeaders,
        WINHTTP_EXTENDED_HEADER* pHeaders
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WinHttpSendRequest(
        HINTERNET hRequest,
        [NativeTypeName("LPCWSTR")] ushort* lpszHeaders,
        [NativeTypeName("DWORD")] uint dwHeadersLength,
        [NativeTypeName("LPVOID")] void* lpOptional,
        [NativeTypeName("DWORD")] uint dwOptionalLength,
        [NativeTypeName("DWORD")] uint dwTotalLength,
        [NativeTypeName("DWORD_PTR")] nuint dwContext
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WinHttpSetCredentials(
        HINTERNET hRequest,
        [NativeTypeName("DWORD")] uint AuthTargets,
        [NativeTypeName("DWORD")] uint AuthScheme,
        [NativeTypeName("LPCWSTR")] ushort* pwszUserName,
        [NativeTypeName("LPCWSTR")] ushort* pwszPassword,
        [NativeTypeName("LPVOID")] void* pAuthParams
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WinHttpQueryAuthSchemes(
        HINTERNET hRequest,
        [NativeTypeName("LPDWORD")] uint* lpdwSupportedSchemes,
        [NativeTypeName("LPDWORD")] uint* lpdwFirstScheme,
        [NativeTypeName("LPDWORD")] uint* pdwAuthTarget
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WinHttpReceiveResponse(
        HINTERNET hRequest,
        [NativeTypeName("LPVOID")] void* lpReserved
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WinHttpQueryHeaders(
        HINTERNET hRequest,
        [NativeTypeName("DWORD")] uint dwInfoLevel,
        [NativeTypeName("LPCWSTR")] ushort* pwszName,
        [NativeTypeName("LPVOID")] void* lpBuffer,
        [NativeTypeName("LPDWORD")] uint* lpdwBufferLength,
        [NativeTypeName("LPDWORD")] uint* lpdwIndex
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern uint WinHttpQueryHeadersEx(
        HINTERNET hRequest,
        [NativeTypeName("DWORD")] uint dwInfoLevel,
        [NativeTypeName("ULONGLONG")] ulong ullFlags,
        uint uiCodePage,
        [NativeTypeName("PDWORD")] uint* pdwIndex,
        [NativeTypeName("PWINHTTP_HEADER_NAME")] WINHTTP_HEADER_NAME* pHeaderName,
        [NativeTypeName("PVOID")] void* pBuffer,
        [NativeTypeName("PDWORD")] uint* pdwBufferLength,
        [NativeTypeName("PWINHTTP_EXTENDED_HEADER *")] WINHTTP_EXTENDED_HEADER** ppHeaders,
        [NativeTypeName("PDWORD")] uint* pdwHeadersCount
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows10.0.22000.0")]
    public static extern uint WinHttpQueryConnectionGroup(
        HINTERNET hInternet,
        [NativeTypeName("const GUID *")] Guid* pGuidConnection,
        [NativeTypeName("ULONGLONG")] ulong ullFlags,
        [NativeTypeName("PWINHTTP_QUERY_CONNECTION_GROUP_RESULT *")]
            WINHTTP_QUERY_CONNECTION_GROUP_RESULT** ppResult
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.22000.0")]
    public static extern void WinHttpFreeQueryConnectionGroupResult(
        WINHTTP_QUERY_CONNECTION_GROUP_RESULT* pResult
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WinHttpDetectAutoProxyConfigUrl(
        [NativeTypeName("DWORD")] uint dwAutoDetectFlags,
        [NativeTypeName("LPWSTR *")] ushort** ppwstrAutoConfigUrl
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WinHttpGetProxyForUrl(
        HINTERNET hSession,
        [NativeTypeName("LPCWSTR")] ushort* lpcwszUrl,
        WINHTTP_AUTOPROXY_OPTIONS* pAutoProxyOptions,
        WINHTTP_PROXY_INFO* pProxyInfo
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint WinHttpCreateProxyResolver(HINTERNET hSession, HINTERNET* phResolver);

    [DllImport("winhttp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint WinHttpGetProxyForUrlEx(
        HINTERNET hResolver,
        [NativeTypeName("PCWSTR")] ushort* pcwszUrl,
        WINHTTP_AUTOPROXY_OPTIONS* pAutoProxyOptions,
        [NativeTypeName("DWORD_PTR")] nuint pContext
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WinHttpGetProxyForUrlEx2(
        HINTERNET hResolver,
        [NativeTypeName("PCWSTR")] ushort* pcwszUrl,
        WINHTTP_AUTOPROXY_OPTIONS* pAutoProxyOptions,
        [NativeTypeName("DWORD")] uint cbInterfaceSelectionContext,
        byte* pInterfaceSelectionContext,
        [NativeTypeName("DWORD_PTR")] nuint pContext
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint WinHttpGetProxyResult(
        HINTERNET hResolver,
        WINHTTP_PROXY_RESULT* pProxyResult
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WinHttpGetProxyResultEx(
        HINTERNET hResolver,
        WINHTTP_PROXY_RESULT_EX* pProxyResultEx
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern void WinHttpFreeProxyResult(WINHTTP_PROXY_RESULT* pProxyResult);

    [DllImport("winhttp", ExactSpelling = true)]
    public static extern void WinHttpFreeProxyResultEx(WINHTTP_PROXY_RESULT_EX* pProxyResultEx);

    [DllImport("winhttp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint WinHttpResetAutoProxy(
        HINTERNET hSession,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WinHttpGetIEProxyConfigForCurrentUser(
        WINHTTP_CURRENT_USER_IE_PROXY_CONFIG* pProxyConfig
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WinHttpWriteProxySettings(
        HINTERNET hSession,
        BOOL fForceUpdate,
        WINHTTP_PROXY_SETTINGS* pWinHttpProxySettings
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WinHttpReadProxySettings(
        HINTERNET hSession,
        [NativeTypeName("PCWSTR")] ushort* pcwszConnectionName,
        BOOL fFallBackToDefaultSettings,
        BOOL fSetAutoDiscoverForDefaultSettings,
        [NativeTypeName("DWORD *")] uint* pdwSettingsVersion,
        BOOL* pfDefaultSettingsAreReturned,
        WINHTTP_PROXY_SETTINGS* pWinHttpProxySettings
    );

    [DllImport("winhttp", ExactSpelling = true)]
    public static extern void WinHttpFreeProxySettings(
        WINHTTP_PROXY_SETTINGS* pWinHttpProxySettings
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WinHttpGetProxySettingsVersion(
        HINTERNET hSession,
        [NativeTypeName("DWORD *")] uint* pdwProxySettingsVersion
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WinHttpSetProxySettingsPerUser(BOOL fProxySettingsPerUser);

    [DllImport("winhttp", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern HINTERNET WinHttpWebSocketCompleteUpgrade(
        HINTERNET hRequest,
        [NativeTypeName("DWORD_PTR")] nuint pContext
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint WinHttpWebSocketSend(
        HINTERNET hWebSocket,
        WINHTTP_WEB_SOCKET_BUFFER_TYPE eBufferType,
        [NativeTypeName("PVOID")] void* pvBuffer,
        [NativeTypeName("DWORD")] uint dwBufferLength
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint WinHttpWebSocketReceive(
        HINTERNET hWebSocket,
        [NativeTypeName("PVOID")] void* pvBuffer,
        [NativeTypeName("DWORD")] uint dwBufferLength,
        [NativeTypeName("DWORD *")] uint* pdwBytesRead,
        WINHTTP_WEB_SOCKET_BUFFER_TYPE* peBufferType
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint WinHttpWebSocketShutdown(
        HINTERNET hWebSocket,
        ushort usStatus,
        [NativeTypeName("PVOID")] void* pvReason,
        [NativeTypeName("DWORD")] uint dwReasonLength
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint WinHttpWebSocketClose(
        HINTERNET hWebSocket,
        ushort usStatus,
        [NativeTypeName("PVOID")] void* pvReason,
        [NativeTypeName("DWORD")] uint dwReasonLength
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint WinHttpWebSocketQueryCloseStatus(
        HINTERNET hWebSocket,
        ushort* pusStatus,
        [NativeTypeName("PVOID")] void* pvReason,
        [NativeTypeName("DWORD")] uint dwReasonLength,
        [NativeTypeName("DWORD *")] uint* pdwReasonLengthConsumed
    );

    [DllImport("winhttp", ExactSpelling = true)]
    public static extern HINTERNET WinHttpProtocolCompleteUpgrade(
        HINTERNET hRequest,
        [NativeTypeName("DWORD_PTR")] nuint dwContext
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WinHttpProtocolSend(
        HINTERNET ProtocolHandle,
        [NativeTypeName("ULONGLONG")] ulong Flags,
        [NativeTypeName("PVOID")] void* pvBuffer,
        [NativeTypeName("DWORD")] uint dwBufferLength
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WinHttpProtocolReceive(
        HINTERNET ProtocolHandle,
        [NativeTypeName("ULONGLONG")] ulong Flags,
        [NativeTypeName("PVOID")] void* pvBuffer,
        [NativeTypeName("DWORD")] uint dwBufferLength,
        [NativeTypeName("DWORD *")] uint* pdwBytesRead
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows10.0.22621.0")]
    public static extern uint WinHttpRegisterProxyChangeNotification(
        [NativeTypeName("ULONGLONG")] ulong ullFlags,
        [NativeTypeName("WINHTTP_PROXY_CHANGE_CALLBACK")]
            delegate* unmanaged<ulong, void*, void> pfnCallback,
        [NativeTypeName("PVOID")] void* pvContext,
        [NativeTypeName("WINHTTP_PROXY_CHANGE_REGISTRATION_HANDLE *")] void** hRegistration
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows10.0.22621.0")]
    public static extern uint WinHttpUnregisterProxyChangeNotification(
        [NativeTypeName("WINHTTP_PROXY_CHANGE_REGISTRATION_HANDLE")] void* hRegistration
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows10.0.22621.0")]
    public static extern uint WinHttpGetProxySettingsEx(
        HINTERNET hResolver,
        WINHTTP_PROXY_SETTINGS_TYPE ProxySettingsType,
        [NativeTypeName("PWINHTTP_PROXY_SETTINGS_PARAM")]
            WINHTTP_PROXY_SETTINGS_PARAM* pProxySettingsParam,
        [NativeTypeName("DWORD_PTR")] nuint pContext
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows10.0.22621.0")]
    public static extern uint WinHttpGetProxySettingsResultEx(
        HINTERNET hResolver,
        [NativeTypeName("PVOID")] void* pProxySettingsEx
    );

    [DllImport("winhttp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows10.0.22621.0")]
    public static extern uint WinHttpFreeProxySettingsEx(
        WINHTTP_PROXY_SETTINGS_TYPE ProxySettingsType,
        [NativeTypeName("PVOID")] void* pProxySettingsEx
    );

    [NativeTypeName("#define NETWORKING_KEY_BUFSIZE 128")]
    public const int NETWORKING_KEY_BUFSIZE = 128;

    [NativeTypeName("#define API_RECEIVE_RESPONSE (1)")]
    public const int API_RECEIVE_RESPONSE = (1);

    [NativeTypeName("#define API_QUERY_DATA_AVAILABLE (2)")]
    public const int API_QUERY_DATA_AVAILABLE = (2);

    [NativeTypeName("#define API_READ_DATA (3)")]
    public const int API_READ_DATA = (3);

    [NativeTypeName("#define API_WRITE_DATA (4)")]
    public const int API_WRITE_DATA = (4);

    [NativeTypeName("#define API_SEND_REQUEST (5)")]
    public const int API_SEND_REQUEST = (5);

    [NativeTypeName("#define API_GET_PROXY_FOR_URL (6)")]
    public const int API_GET_PROXY_FOR_URL = (6);

    [NativeTypeName("#define API_GET_PROXY_SETTINGS (7)")]
    public const int API_GET_PROXY_SETTINGS = (7);

    [NativeTypeName("#define ICU_NO_ENCODE 0x20000000")]
    public const int ICU_NO_ENCODE = 0x20000000;

    [NativeTypeName("#define ICU_DECODE 0x10000000")]
    public const int ICU_DECODE = 0x10000000;

    [NativeTypeName("#define ICU_NO_META 0x08000000")]
    public const int ICU_NO_META = 0x08000000;

    [NativeTypeName("#define ICU_ENCODE_SPACES_ONLY 0x04000000")]
    public const int ICU_ENCODE_SPACES_ONLY = 0x04000000;

    [NativeTypeName("#define ICU_BROWSER_MODE 0x02000000")]
    public const int ICU_BROWSER_MODE = 0x02000000;

    [NativeTypeName("#define ICU_ENCODE_PERCENT 0x00001000")]
    public const int ICU_ENCODE_PERCENT = 0x00001000;

    [NativeTypeName("#define ICU_ESCAPE 0x80000000")]
    public const uint ICU_ESCAPE = 0x80000000;

    [NativeTypeName("#define ICU_INCLUDE_DEFAULT_PORT 0x00008000")]
    public const int ICU_INCLUDE_DEFAULT_PORT = 0x00008000;

    [NativeTypeName("#define ICU_REJECT_USERPWD 0x00004000")]
    public const int ICU_REJECT_USERPWD = 0x00004000;

    [NativeTypeName("#define ICU_ESCAPE_AUTHORITY 0x00002000")]
    public const int ICU_ESCAPE_AUTHORITY = 0x00002000;
}
