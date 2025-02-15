// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptAcquireContextA(
        HCRYPTPROV* phProv,
        [NativeTypeName("LPCSTR")] sbyte* szContainer,
        [NativeTypeName("LPCSTR")] sbyte* szProvider,
        [NativeTypeName("DWORD")] uint dwProvType,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptAcquireContextW(
        HCRYPTPROV* phProv,
        [NativeTypeName("LPCWSTR")] ushort* szContainer,
        [NativeTypeName("LPCWSTR")] ushort* szProvider,
        [NativeTypeName("DWORD")] uint dwProvType,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptReleaseContext(
        HCRYPTPROV hProv,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptGenKey(
        HCRYPTPROV hProv,
        [NativeTypeName("ALG_ID")] uint Algid,
        [NativeTypeName("DWORD")] uint dwFlags,
        HCRYPTKEY* phKey
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptDeriveKey(
        HCRYPTPROV hProv,
        [NativeTypeName("ALG_ID")] uint Algid,
        HCRYPTHASH hBaseData,
        [NativeTypeName("DWORD")] uint dwFlags,
        HCRYPTKEY* phKey
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptDestroyKey(HCRYPTKEY hKey);

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptSetKeyParam(
        HCRYPTKEY hKey,
        [NativeTypeName("DWORD")] uint dwParam,
        [NativeTypeName("const BYTE *")] byte* pbData,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptGetKeyParam(
        HCRYPTKEY hKey,
        [NativeTypeName("DWORD")] uint dwParam,
        byte* pbData,
        [NativeTypeName("DWORD *")] uint* pdwDataLen,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptSetHashParam(
        HCRYPTHASH hHash,
        [NativeTypeName("DWORD")] uint dwParam,
        [NativeTypeName("const BYTE *")] byte* pbData,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptGetHashParam(
        HCRYPTHASH hHash,
        [NativeTypeName("DWORD")] uint dwParam,
        byte* pbData,
        [NativeTypeName("DWORD *")] uint* pdwDataLen,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptSetProvParam(
        HCRYPTPROV hProv,
        [NativeTypeName("DWORD")] uint dwParam,
        [NativeTypeName("const BYTE *")] byte* pbData,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptGetProvParam(
        HCRYPTPROV hProv,
        [NativeTypeName("DWORD")] uint dwParam,
        byte* pbData,
        [NativeTypeName("DWORD *")] uint* pdwDataLen,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptGenRandom(
        HCRYPTPROV hProv,
        [NativeTypeName("DWORD")] uint dwLen,
        byte* pbBuffer
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptGetUserKey(
        HCRYPTPROV hProv,
        [NativeTypeName("DWORD")] uint dwKeySpec,
        HCRYPTKEY* phUserKey
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptExportKey(
        HCRYPTKEY hKey,
        HCRYPTKEY hExpKey,
        [NativeTypeName("DWORD")] uint dwBlobType,
        [NativeTypeName("DWORD")] uint dwFlags,
        byte* pbData,
        [NativeTypeName("DWORD *")] uint* pdwDataLen
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptImportKey(
        HCRYPTPROV hProv,
        [NativeTypeName("const BYTE *")] byte* pbData,
        [NativeTypeName("DWORD")] uint dwDataLen,
        HCRYPTKEY hPubKey,
        [NativeTypeName("DWORD")] uint dwFlags,
        HCRYPTKEY* phKey
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptEncrypt(
        HCRYPTKEY hKey,
        HCRYPTHASH hHash,
        BOOL Final,
        [NativeTypeName("DWORD")] uint dwFlags,
        byte* pbData,
        [NativeTypeName("DWORD *")] uint* pdwDataLen,
        [NativeTypeName("DWORD")] uint dwBufLen
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptDecrypt(
        HCRYPTKEY hKey,
        HCRYPTHASH hHash,
        BOOL Final,
        [NativeTypeName("DWORD")] uint dwFlags,
        byte* pbData,
        [NativeTypeName("DWORD *")] uint* pdwDataLen
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptCreateHash(
        HCRYPTPROV hProv,
        [NativeTypeName("ALG_ID")] uint Algid,
        HCRYPTKEY hKey,
        [NativeTypeName("DWORD")] uint dwFlags,
        HCRYPTHASH* phHash
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptHashData(
        HCRYPTHASH hHash,
        [NativeTypeName("const BYTE *")] byte* pbData,
        [NativeTypeName("DWORD")] uint dwDataLen,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptHashSessionKey(
        HCRYPTHASH hHash,
        HCRYPTKEY hKey,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptDestroyHash(HCRYPTHASH hHash);

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptSignHashA(
        HCRYPTHASH hHash,
        [NativeTypeName("DWORD")] uint dwKeySpec,
        [NativeTypeName("LPCSTR")] sbyte* szDescription,
        [NativeTypeName("DWORD")] uint dwFlags,
        byte* pbSignature,
        [NativeTypeName("DWORD *")] uint* pdwSigLen
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptSignHashW(
        HCRYPTHASH hHash,
        [NativeTypeName("DWORD")] uint dwKeySpec,
        [NativeTypeName("LPCWSTR")] ushort* szDescription,
        [NativeTypeName("DWORD")] uint dwFlags,
        byte* pbSignature,
        [NativeTypeName("DWORD *")] uint* pdwSigLen
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptVerifySignatureA(
        HCRYPTHASH hHash,
        [NativeTypeName("const BYTE *")] byte* pbSignature,
        [NativeTypeName("DWORD")] uint dwSigLen,
        HCRYPTKEY hPubKey,
        [NativeTypeName("LPCSTR")] sbyte* szDescription,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptVerifySignatureW(
        HCRYPTHASH hHash,
        [NativeTypeName("const BYTE *")] byte* pbSignature,
        [NativeTypeName("DWORD")] uint dwSigLen,
        HCRYPTKEY hPubKey,
        [NativeTypeName("LPCWSTR")] ushort* szDescription,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptSetProviderA(
        [NativeTypeName("LPCSTR")] sbyte* pszProvName,
        [NativeTypeName("DWORD")] uint dwProvType
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptSetProviderW(
        [NativeTypeName("LPCWSTR")] ushort* pszProvName,
        [NativeTypeName("DWORD")] uint dwProvType
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptSetProviderExA(
        [NativeTypeName("LPCSTR")] sbyte* pszProvName,
        [NativeTypeName("DWORD")] uint dwProvType,
        [NativeTypeName("DWORD *")] uint* pdwReserved,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptSetProviderExW(
        [NativeTypeName("LPCWSTR")] ushort* pszProvName,
        [NativeTypeName("DWORD")] uint dwProvType,
        [NativeTypeName("DWORD *")] uint* pdwReserved,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptGetDefaultProviderA(
        [NativeTypeName("DWORD")] uint dwProvType,
        [NativeTypeName("DWORD *")] uint* pdwReserved,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPSTR")] sbyte* pszProvName,
        [NativeTypeName("DWORD *")] uint* pcbProvName
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptGetDefaultProviderW(
        [NativeTypeName("DWORD")] uint dwProvType,
        [NativeTypeName("DWORD *")] uint* pdwReserved,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPWSTR")] ushort* pszProvName,
        [NativeTypeName("DWORD *")] uint* pcbProvName
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptEnumProviderTypesA(
        [NativeTypeName("DWORD")] uint dwIndex,
        [NativeTypeName("DWORD *")] uint* pdwReserved,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD *")] uint* pdwProvType,
        [NativeTypeName("LPSTR")] sbyte* szTypeName,
        [NativeTypeName("DWORD *")] uint* pcbTypeName
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptEnumProviderTypesW(
        [NativeTypeName("DWORD")] uint dwIndex,
        [NativeTypeName("DWORD *")] uint* pdwReserved,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD *")] uint* pdwProvType,
        [NativeTypeName("LPWSTR")] ushort* szTypeName,
        [NativeTypeName("DWORD *")] uint* pcbTypeName
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptEnumProvidersA(
        [NativeTypeName("DWORD")] uint dwIndex,
        [NativeTypeName("DWORD *")] uint* pdwReserved,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD *")] uint* pdwProvType,
        [NativeTypeName("LPSTR")] sbyte* szProvName,
        [NativeTypeName("DWORD *")] uint* pcbProvName
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptEnumProvidersW(
        [NativeTypeName("DWORD")] uint dwIndex,
        [NativeTypeName("DWORD *")] uint* pdwReserved,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD *")] uint* pdwProvType,
        [NativeTypeName("LPWSTR")] ushort* szProvName,
        [NativeTypeName("DWORD *")] uint* pcbProvName
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptContextAddRef(
        HCRYPTPROV hProv,
        [NativeTypeName("DWORD *")] uint* pdwReserved,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptDuplicateKey(
        HCRYPTKEY hKey,
        [NativeTypeName("DWORD *")] uint* pdwReserved,
        [NativeTypeName("DWORD")] uint dwFlags,
        HCRYPTKEY* phKey
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptDuplicateHash(
        HCRYPTHASH hHash,
        [NativeTypeName("DWORD *")] uint* pdwReserved,
        [NativeTypeName("DWORD")] uint dwFlags,
        HCRYPTHASH* phHash
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptFormatObject(
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("DWORD")] uint dwFormatType,
        [NativeTypeName("DWORD")] uint dwFormatStrType,
        void* pFormatStruct,
        [NativeTypeName("LPCSTR")] sbyte* lpszStructType,
        [NativeTypeName("const BYTE *")] byte* pbEncoded,
        [NativeTypeName("DWORD")] uint cbEncoded,
        void* pbFormat,
        [NativeTypeName("DWORD *")] uint* pcbFormat
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptEncodeObjectEx(
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("LPCSTR")] sbyte* lpszStructType,
        [NativeTypeName("const void *")] void* pvStructInfo,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("PCRYPT_ENCODE_PARA")] CRYPT_ENCODE_PARA* pEncodePara,
        void* pvEncoded,
        [NativeTypeName("DWORD *")] uint* pcbEncoded
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptEncodeObject(
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("LPCSTR")] sbyte* lpszStructType,
        [NativeTypeName("const void *")] void* pvStructInfo,
        byte* pbEncoded,
        [NativeTypeName("DWORD *")] uint* pcbEncoded
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptDecodeObjectEx(
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("LPCSTR")] sbyte* lpszStructType,
        [NativeTypeName("const BYTE *")] byte* pbEncoded,
        [NativeTypeName("DWORD")] uint cbEncoded,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("PCRYPT_DECODE_PARA")] CRYPT_DECODE_PARA* pDecodePara,
        void* pvStructInfo,
        [NativeTypeName("DWORD *")] uint* pcbStructInfo
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptDecodeObject(
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("LPCSTR")] sbyte* lpszStructType,
        [NativeTypeName("const BYTE *")] byte* pbEncoded,
        [NativeTypeName("DWORD")] uint cbEncoded,
        [NativeTypeName("DWORD")] uint dwFlags,
        void* pvStructInfo,
        [NativeTypeName("DWORD *")] uint* pcbStructInfo
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CryptInstallOIDFunctionAddress(
        HMODULE hModule,
        [NativeTypeName("DWORD")] uint dwEncodingType,
        [NativeTypeName("LPCSTR")] sbyte* pszFuncName,
        [NativeTypeName("DWORD")] uint cFuncEntry,
        [NativeTypeName("const CRYPT_OID_FUNC_ENTRY[]")] CRYPT_OID_FUNC_ENTRY* rgFuncEntry,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern HCRYPTOIDFUNCSET CryptInitOIDFunctionSet(
        [NativeTypeName("LPCSTR")] sbyte* pszFuncName,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptGetOIDFunctionAddress(
        HCRYPTOIDFUNCSET hFuncSet,
        [NativeTypeName("DWORD")] uint dwEncodingType,
        [NativeTypeName("LPCSTR")] sbyte* pszOID,
        [NativeTypeName("DWORD")] uint dwFlags,
        void** ppvFuncAddr,
        HCRYPTOIDFUNCADDR* phFuncAddr
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptGetDefaultOIDDllList(
        HCRYPTOIDFUNCSET hFuncSet,
        [NativeTypeName("DWORD")] uint dwEncodingType,
        [NativeTypeName("WCHAR *")] ushort* pwszDllList,
        [NativeTypeName("DWORD *")] uint* pcchDllList
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CryptGetDefaultOIDFunctionAddress(
        HCRYPTOIDFUNCSET hFuncSet,
        [NativeTypeName("DWORD")] uint dwEncodingType,
        [NativeTypeName("LPCWSTR")] ushort* pwszDll,
        [NativeTypeName("DWORD")] uint dwFlags,
        void** ppvFuncAddr,
        HCRYPTOIDFUNCADDR* phFuncAddr
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CryptFreeOIDFunctionAddress(
        HCRYPTOIDFUNCADDR hFuncAddr,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CryptRegisterOIDFunction(
        [NativeTypeName("DWORD")] uint dwEncodingType,
        [NativeTypeName("LPCSTR")] sbyte* pszFuncName,
        [NativeTypeName("LPCSTR")] sbyte* pszOID,
        [NativeTypeName("LPCWSTR")] ushort* pwszDll,
        [NativeTypeName("LPCSTR")] sbyte* pszOverrideFuncName
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CryptUnregisterOIDFunction(
        [NativeTypeName("DWORD")] uint dwEncodingType,
        [NativeTypeName("LPCSTR")] sbyte* pszFuncName,
        [NativeTypeName("LPCSTR")] sbyte* pszOID
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CryptRegisterDefaultOIDFunction(
        [NativeTypeName("DWORD")] uint dwEncodingType,
        [NativeTypeName("LPCSTR")] sbyte* pszFuncName,
        [NativeTypeName("DWORD")] uint dwIndex,
        [NativeTypeName("LPCWSTR")] ushort* pwszDll
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CryptUnregisterDefaultOIDFunction(
        [NativeTypeName("DWORD")] uint dwEncodingType,
        [NativeTypeName("LPCSTR")] sbyte* pszFuncName,
        [NativeTypeName("LPCWSTR")] ushort* pwszDll
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CryptSetOIDFunctionValue(
        [NativeTypeName("DWORD")] uint dwEncodingType,
        [NativeTypeName("LPCSTR")] sbyte* pszFuncName,
        [NativeTypeName("LPCSTR")] sbyte* pszOID,
        [NativeTypeName("LPCWSTR")] ushort* pwszValueName,
        [NativeTypeName("DWORD")] uint dwValueType,
        [NativeTypeName("const BYTE *")] byte* pbValueData,
        [NativeTypeName("DWORD")] uint cbValueData
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptGetOIDFunctionValue(
        [NativeTypeName("DWORD")] uint dwEncodingType,
        [NativeTypeName("LPCSTR")] sbyte* pszFuncName,
        [NativeTypeName("LPCSTR")] sbyte* pszOID,
        [NativeTypeName("LPCWSTR")] ushort* pwszValueName,
        [NativeTypeName("DWORD *")] uint* pdwValueType,
        byte* pbValueData,
        [NativeTypeName("DWORD *")] uint* pcbValueData
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptEnumOIDFunction(
        [NativeTypeName("DWORD")] uint dwEncodingType,
        [NativeTypeName("LPCSTR")] sbyte* pszFuncName,
        [NativeTypeName("LPCSTR")] sbyte* pszOID,
        [NativeTypeName("DWORD")] uint dwFlags,
        void* pvArg,
        [NativeTypeName("PFN_CRYPT_ENUM_OID_FUNC")]
            delegate* unmanaged<
            uint,
            sbyte*,
            sbyte*,
            uint,
            uint*,
            ushort**,
            byte**,
            uint*,
            void*,
            BOOL> pfnEnumOIDFunc
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [return: NativeTypeName("PCCRYPT_OID_INFO")]
    public static extern CRYPT_OID_INFO* CryptFindOIDInfo(
        [NativeTypeName("DWORD")] uint dwKeyType,
        void* pvKey,
        [NativeTypeName("DWORD")] uint dwGroupId
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CryptRegisterOIDInfo(
        [NativeTypeName("PCCRYPT_OID_INFO")] CRYPT_OID_INFO* pInfo,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CryptUnregisterOIDInfo(
        [NativeTypeName("PCCRYPT_OID_INFO")] CRYPT_OID_INFO* pInfo
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CryptEnumOIDInfo(
        [NativeTypeName("DWORD")] uint dwGroupId,
        [NativeTypeName("DWORD")] uint dwFlags,
        void* pvArg,
        [NativeTypeName("PFN_CRYPT_ENUM_OID_INFO")]
            delegate* unmanaged<CRYPT_OID_INFO*, void*, BOOL> pfnEnumOIDInfo
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [return: NativeTypeName("LPCWSTR")]
    public static extern ushort* CryptFindLocalizedName(
        [NativeTypeName("LPCWSTR")] ushort* pwszCryptName
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HCRYPTMSG CryptMsgOpenToEncode(
        [NativeTypeName("DWORD")] uint dwMsgEncodingType,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD")] uint dwMsgType,
        [NativeTypeName("const void *")] void* pvMsgEncodeInfo,
        [NativeTypeName("LPSTR")] sbyte* pszInnerContentObjID,
        [NativeTypeName("PCMSG_STREAM_INFO")] CMSG_STREAM_INFO* pStreamInfo
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint CryptMsgCalculateEncodedLength(
        [NativeTypeName("DWORD")] uint dwMsgEncodingType,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD")] uint dwMsgType,
        [NativeTypeName("const void *")] void* pvMsgEncodeInfo,
        [NativeTypeName("LPSTR")] sbyte* pszInnerContentObjID,
        [NativeTypeName("DWORD")] uint cbData
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HCRYPTMSG CryptMsgOpenToDecode(
        [NativeTypeName("DWORD")] uint dwMsgEncodingType,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD")] uint dwMsgType,
        HCRYPTPROV_LEGACY hCryptProv,
        [NativeTypeName("PCERT_INFO")] CERT_INFO* pRecipientInfo,
        [NativeTypeName("PCMSG_STREAM_INFO")] CMSG_STREAM_INFO* pStreamInfo
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern HCRYPTMSG CryptMsgDuplicate(HCRYPTMSG hCryptMsg);

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptMsgClose(HCRYPTMSG hCryptMsg);

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptMsgUpdate(
        HCRYPTMSG hCryptMsg,
        [NativeTypeName("const BYTE *")] byte* pbData,
        [NativeTypeName("DWORD")] uint cbData,
        BOOL fFinal
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptMsgGetParam(
        HCRYPTMSG hCryptMsg,
        [NativeTypeName("DWORD")] uint dwParamType,
        [NativeTypeName("DWORD")] uint dwIndex,
        void* pvData,
        [NativeTypeName("DWORD *")] uint* pcbData
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptMsgControl(
        HCRYPTMSG hCryptMsg,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD")] uint dwCtrlType,
        [NativeTypeName("const void *")] void* pvCtrlPara
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptMsgVerifyCountersignatureEncoded(
        HCRYPTPROV_LEGACY hCryptProv,
        [NativeTypeName("DWORD")] uint dwEncodingType,
        [NativeTypeName("PBYTE")] byte* pbSignerInfo,
        [NativeTypeName("DWORD")] uint cbSignerInfo,
        [NativeTypeName("PBYTE")] byte* pbSignerInfoCountersignature,
        [NativeTypeName("DWORD")] uint cbSignerInfoCountersignature,
        [NativeTypeName("PCERT_INFO")] CERT_INFO* pciCountersigner
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptMsgVerifyCountersignatureEncodedEx(
        HCRYPTPROV_LEGACY hCryptProv,
        [NativeTypeName("DWORD")] uint dwEncodingType,
        [NativeTypeName("PBYTE")] byte* pbSignerInfo,
        [NativeTypeName("DWORD")] uint cbSignerInfo,
        [NativeTypeName("PBYTE")] byte* pbSignerInfoCountersignature,
        [NativeTypeName("DWORD")] uint cbSignerInfoCountersignature,
        [NativeTypeName("DWORD")] uint dwSignerType,
        void* pvSigner,
        [NativeTypeName("DWORD")] uint dwFlags,
        void* pvExtra
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptMsgCountersign(
        HCRYPTMSG hCryptMsg,
        [NativeTypeName("DWORD")] uint dwIndex,
        [NativeTypeName("DWORD")] uint cCountersigners,
        [NativeTypeName("PCMSG_SIGNER_ENCODE_INFO")] CMSG_SIGNER_ENCODE_INFO* rgCountersigners
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptMsgCountersignEncoded(
        [NativeTypeName("DWORD")] uint dwEncodingType,
        [NativeTypeName("PBYTE")] byte* pbSignerInfo,
        [NativeTypeName("DWORD")] uint cbSignerInfo,
        [NativeTypeName("DWORD")] uint cCountersigners,
        [NativeTypeName("PCMSG_SIGNER_ENCODE_INFO")] CMSG_SIGNER_ENCODE_INFO* rgCountersigners,
        [NativeTypeName("PBYTE")] byte* pbCountersignature,
        [NativeTypeName("PDWORD")] uint* pcbCountersignature
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HCERTSTORE CertOpenStore(
        [NativeTypeName("LPCSTR")] sbyte* lpszStoreProvider,
        [NativeTypeName("DWORD")] uint dwEncodingType,
        HCRYPTPROV_LEGACY hCryptProv,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("const void *")] void* pvPara
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern HCERTSTORE CertDuplicateStore(HCERTSTORE hCertStore);

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertSaveStore(
        HCERTSTORE hCertStore,
        [NativeTypeName("DWORD")] uint dwEncodingType,
        [NativeTypeName("DWORD")] uint dwSaveAs,
        [NativeTypeName("DWORD")] uint dwSaveTo,
        void* pvSaveToPara,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertCloseStore(
        HCERTSTORE hCertStore,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PCCERT_CONTEXT")]
    public static extern CERT_CONTEXT* CertGetSubjectCertificateFromStore(
        HCERTSTORE hCertStore,
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("PCERT_INFO")] CERT_INFO* pCertId
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PCCERT_CONTEXT")]
    public static extern CERT_CONTEXT* CertEnumCertificatesInStore(
        HCERTSTORE hCertStore,
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pPrevCertContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PCCERT_CONTEXT")]
    public static extern CERT_CONTEXT* CertFindCertificateInStore(
        HCERTSTORE hCertStore,
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("DWORD")] uint dwFindFlags,
        [NativeTypeName("DWORD")] uint dwFindType,
        [NativeTypeName("const void *")] void* pvFindPara,
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pPrevCertContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PCCERT_CONTEXT")]
    public static extern CERT_CONTEXT* CertGetIssuerCertificateFromStore(
        HCERTSTORE hCertStore,
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pSubjectContext,
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pPrevIssuerContext,
        [NativeTypeName("DWORD *")] uint* pdwFlags
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertVerifySubjectCertificateContext(
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pSubject,
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pIssuer,
        [NativeTypeName("DWORD *")] uint* pdwFlags
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [return: NativeTypeName("PCCERT_CONTEXT")]
    public static extern CERT_CONTEXT* CertDuplicateCertificateContext(
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PCCERT_CONTEXT")]
    public static extern CERT_CONTEXT* CertCreateCertificateContext(
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("const BYTE *")] byte* pbCertEncoded,
        [NativeTypeName("DWORD")] uint cbCertEncoded
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CertFreeCertificateContext(
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertSetCertificateContextProperty(
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext,
        [NativeTypeName("DWORD")] uint dwPropId,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("const void *")] void* pvData
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertGetCertificateContextProperty(
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext,
        [NativeTypeName("DWORD")] uint dwPropId,
        void* pvData,
        [NativeTypeName("DWORD *")] uint* pcbData
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CertEnumCertificateContextProperties(
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext,
        [NativeTypeName("DWORD")] uint dwPropId
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertCreateCTLEntryFromCertificateContextProperties(
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext,
        [NativeTypeName("DWORD")] uint cOptAttr,
        [NativeTypeName("PCRYPT_ATTRIBUTE")] CRYPT_ATTRIBUTE* rgOptAttr,
        [NativeTypeName("DWORD")] uint dwFlags,
        void* pvReserved,
        [NativeTypeName("PCTL_ENTRY")] CTL_ENTRY* pCtlEntry,
        [NativeTypeName("DWORD *")] uint* pcbCtlEntry
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertSetCertificateContextPropertiesFromCTLEntry(
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext,
        [NativeTypeName("PCTL_ENTRY")] CTL_ENTRY* pCtlEntry,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PCCRL_CONTEXT")]
    public static extern CRL_CONTEXT* CertGetCRLFromStore(
        HCERTSTORE hCertStore,
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pIssuerContext,
        [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pPrevCrlContext,
        [NativeTypeName("DWORD *")] uint* pdwFlags
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PCCRL_CONTEXT")]
    public static extern CRL_CONTEXT* CertEnumCRLsInStore(
        HCERTSTORE hCertStore,
        [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pPrevCrlContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PCCRL_CONTEXT")]
    public static extern CRL_CONTEXT* CertFindCRLInStore(
        HCERTSTORE hCertStore,
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("DWORD")] uint dwFindFlags,
        [NativeTypeName("DWORD")] uint dwFindType,
        [NativeTypeName("const void *")] void* pvFindPara,
        [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pPrevCrlContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [return: NativeTypeName("PCCRL_CONTEXT")]
    public static extern CRL_CONTEXT* CertDuplicateCRLContext(
        [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PCCRL_CONTEXT")]
    public static extern CRL_CONTEXT* CertCreateCRLContext(
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("const BYTE *")] byte* pbCrlEncoded,
        [NativeTypeName("DWORD")] uint cbCrlEncoded
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CertFreeCRLContext(
        [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertSetCRLContextProperty(
        [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext,
        [NativeTypeName("DWORD")] uint dwPropId,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("const void *")] void* pvData
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertGetCRLContextProperty(
        [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext,
        [NativeTypeName("DWORD")] uint dwPropId,
        void* pvData,
        [NativeTypeName("DWORD *")] uint* pcbData
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CertEnumCRLContextProperties(
        [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext,
        [NativeTypeName("DWORD")] uint dwPropId
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CertFindCertificateInCRL(
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCert,
        [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext,
        [NativeTypeName("DWORD")] uint dwFlags,
        void* pvReserved,
        [NativeTypeName("PCRL_ENTRY *")] CRL_ENTRY** ppCrlEntry
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CertIsValidCRLForCertificate(
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCert,
        [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrl,
        [NativeTypeName("DWORD")] uint dwFlags,
        void* pvReserved
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertAddEncodedCertificateToStore(
        HCERTSTORE hCertStore,
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("const BYTE *")] byte* pbCertEncoded,
        [NativeTypeName("DWORD")] uint cbCertEncoded,
        [NativeTypeName("DWORD")] uint dwAddDisposition,
        [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppCertContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertAddCertificateContextToStore(
        HCERTSTORE hCertStore,
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext,
        [NativeTypeName("DWORD")] uint dwAddDisposition,
        [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppStoreContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertAddSerializedElementToStore(
        HCERTSTORE hCertStore,
        [NativeTypeName("const BYTE *")] byte* pbElement,
        [NativeTypeName("DWORD")] uint cbElement,
        [NativeTypeName("DWORD")] uint dwAddDisposition,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD")] uint dwContextTypeFlags,
        [NativeTypeName("DWORD *")] uint* pdwContextType,
        [NativeTypeName("const void **")] void** ppvContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertDeleteCertificateFromStore(
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertAddEncodedCRLToStore(
        HCERTSTORE hCertStore,
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("const BYTE *")] byte* pbCrlEncoded,
        [NativeTypeName("DWORD")] uint cbCrlEncoded,
        [NativeTypeName("DWORD")] uint dwAddDisposition,
        [NativeTypeName("PCCRL_CONTEXT *")] CRL_CONTEXT** ppCrlContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertAddCRLContextToStore(
        HCERTSTORE hCertStore,
        [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext,
        [NativeTypeName("DWORD")] uint dwAddDisposition,
        [NativeTypeName("PCCRL_CONTEXT *")] CRL_CONTEXT** ppStoreContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertDeleteCRLFromStore(
        [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertSerializeCertificateStoreElement(
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext,
        [NativeTypeName("DWORD")] uint dwFlags,
        byte* pbElement,
        [NativeTypeName("DWORD *")] uint* pcbElement
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertSerializeCRLStoreElement(
        [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext,
        [NativeTypeName("DWORD")] uint dwFlags,
        byte* pbElement,
        [NativeTypeName("DWORD *")] uint* pcbElement
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [return: NativeTypeName("PCCTL_CONTEXT")]
    public static extern CTL_CONTEXT* CertDuplicateCTLContext(
        [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PCCTL_CONTEXT")]
    public static extern CTL_CONTEXT* CertCreateCTLContext(
        [NativeTypeName("DWORD")] uint dwMsgAndCertEncodingType,
        [NativeTypeName("const BYTE *")] byte* pbCtlEncoded,
        [NativeTypeName("DWORD")] uint cbCtlEncoded
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CertFreeCTLContext(
        [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertSetCTLContextProperty(
        [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext,
        [NativeTypeName("DWORD")] uint dwPropId,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("const void *")] void* pvData
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertGetCTLContextProperty(
        [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext,
        [NativeTypeName("DWORD")] uint dwPropId,
        void* pvData,
        [NativeTypeName("DWORD *")] uint* pcbData
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CertEnumCTLContextProperties(
        [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext,
        [NativeTypeName("DWORD")] uint dwPropId
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PCCTL_CONTEXT")]
    public static extern CTL_CONTEXT* CertEnumCTLsInStore(
        HCERTSTORE hCertStore,
        [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pPrevCtlContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PCTL_ENTRY")]
    public static extern CTL_ENTRY* CertFindSubjectInCTL(
        [NativeTypeName("DWORD")] uint dwEncodingType,
        [NativeTypeName("DWORD")] uint dwSubjectType,
        void* pvSubject,
        [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PCCTL_CONTEXT")]
    public static extern CTL_CONTEXT* CertFindCTLInStore(
        HCERTSTORE hCertStore,
        [NativeTypeName("DWORD")] uint dwMsgAndCertEncodingType,
        [NativeTypeName("DWORD")] uint dwFindFlags,
        [NativeTypeName("DWORD")] uint dwFindType,
        [NativeTypeName("const void *")] void* pvFindPara,
        [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pPrevCtlContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertAddEncodedCTLToStore(
        HCERTSTORE hCertStore,
        [NativeTypeName("DWORD")] uint dwMsgAndCertEncodingType,
        [NativeTypeName("const BYTE *")] byte* pbCtlEncoded,
        [NativeTypeName("DWORD")] uint cbCtlEncoded,
        [NativeTypeName("DWORD")] uint dwAddDisposition,
        [NativeTypeName("PCCTL_CONTEXT *")] CTL_CONTEXT** ppCtlContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertAddCTLContextToStore(
        HCERTSTORE hCertStore,
        [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext,
        [NativeTypeName("DWORD")] uint dwAddDisposition,
        [NativeTypeName("PCCTL_CONTEXT *")] CTL_CONTEXT** ppStoreContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertSerializeCTLStoreElement(
        [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext,
        [NativeTypeName("DWORD")] uint dwFlags,
        byte* pbElement,
        [NativeTypeName("DWORD *")] uint* pcbElement
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertDeleteCTLFromStore(
        [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertAddCertificateLinkToStore(
        HCERTSTORE hCertStore,
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext,
        [NativeTypeName("DWORD")] uint dwAddDisposition,
        [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppStoreContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertAddCRLLinkToStore(
        HCERTSTORE hCertStore,
        [NativeTypeName("PCCRL_CONTEXT")] CRL_CONTEXT* pCrlContext,
        [NativeTypeName("DWORD")] uint dwAddDisposition,
        [NativeTypeName("PCCRL_CONTEXT *")] CRL_CONTEXT** ppStoreContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertAddCTLLinkToStore(
        HCERTSTORE hCertStore,
        [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext,
        [NativeTypeName("DWORD")] uint dwAddDisposition,
        [NativeTypeName("PCCTL_CONTEXT *")] CTL_CONTEXT** ppStoreContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CertAddStoreToCollection(
        HCERTSTORE hCollectionStore,
        HCERTSTORE hSiblingStore,
        [NativeTypeName("DWORD")] uint dwUpdateFlags,
        [NativeTypeName("DWORD")] uint dwPriority
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern void CertRemoveStoreFromCollection(
        HCERTSTORE hCollectionStore,
        HCERTSTORE hSiblingStore
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertControlStore(
        HCERTSTORE hCertStore,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD")] uint dwCtrlType,
        [NativeTypeName("const void *")] void* pvCtrlPara
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CertSetStoreProperty(
        HCERTSTORE hCertStore,
        [NativeTypeName("DWORD")] uint dwPropId,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("const void *")] void* pvData
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertGetStoreProperty(
        HCERTSTORE hCertStore,
        [NativeTypeName("DWORD")] uint dwPropId,
        void* pvData,
        [NativeTypeName("DWORD *")] uint* pcbData
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("const void *")]
    public static extern void* CertCreateContext(
        [NativeTypeName("DWORD")] uint dwContextType,
        [NativeTypeName("DWORD")] uint dwEncodingType,
        [NativeTypeName("const BYTE *")] byte* pbEncoded,
        [NativeTypeName("DWORD")] uint cbEncoded,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("PCERT_CREATE_CONTEXT_PARA")] CERT_CREATE_CONTEXT_PARA* pCreatePara
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CertRegisterSystemStore(
        [NativeTypeName("const void *")] void* pvSystemStore,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("PCERT_SYSTEM_STORE_INFO")] CERT_SYSTEM_STORE_INFO* pStoreInfo,
        void* pvReserved
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CertRegisterPhysicalStore(
        [NativeTypeName("const void *")] void* pvSystemStore,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPCWSTR")] ushort* pwszStoreName,
        [NativeTypeName("PCERT_PHYSICAL_STORE_INFO")] CERT_PHYSICAL_STORE_INFO* pStoreInfo,
        void* pvReserved
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CertUnregisterSystemStore(
        [NativeTypeName("const void *")] void* pvSystemStore,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CertUnregisterPhysicalStore(
        [NativeTypeName("const void *")] void* pvSystemStore,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPCWSTR")] ushort* pwszStoreName
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CertEnumSystemStoreLocation(
        [NativeTypeName("DWORD")] uint dwFlags,
        void* pvArg,
        [NativeTypeName("PFN_CERT_ENUM_SYSTEM_STORE_LOCATION")]
            delegate* unmanaged<ushort*, uint, void*, void*, BOOL> pfnEnum
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CertEnumSystemStore(
        [NativeTypeName("DWORD")] uint dwFlags,
        void* pvSystemStoreLocationPara,
        void* pvArg,
        [NativeTypeName("PFN_CERT_ENUM_SYSTEM_STORE")]
            delegate* unmanaged<void*, uint, CERT_SYSTEM_STORE_INFO*, void*, void*, BOOL> pfnEnum
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertEnumPhysicalStore(
        [NativeTypeName("const void *")] void* pvSystemStore,
        [NativeTypeName("DWORD")] uint dwFlags,
        void* pvArg,
        [NativeTypeName("PFN_CERT_ENUM_PHYSICAL_STORE")]
            delegate* unmanaged<
            void*,
            uint,
            ushort*,
            CERT_PHYSICAL_STORE_INFO*,
            void*,
            void*,
            BOOL> pfnEnum
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CertGetEnhancedKeyUsage(
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("PCERT_ENHKEY_USAGE")] CTL_USAGE* pUsage,
        [NativeTypeName("DWORD *")] uint* pcbUsage
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertSetEnhancedKeyUsage(
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext,
        [NativeTypeName("PCERT_ENHKEY_USAGE")] CTL_USAGE* pUsage
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertAddEnhancedKeyUsageIdentifier(
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext,
        [NativeTypeName("LPCSTR")] sbyte* pszUsageIdentifier
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertRemoveEnhancedKeyUsageIdentifier(
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext,
        [NativeTypeName("LPCSTR")] sbyte* pszUsageIdentifier
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertGetValidUsages(
        [NativeTypeName("DWORD")] uint cCerts,
        [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** rghCerts,
        int* cNumOIDs,
        [NativeTypeName("LPSTR *")] sbyte** rghOIDs,
        [NativeTypeName("DWORD *")] uint* pcbOIDs
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptMsgGetAndVerifySigner(
        HCRYPTMSG hCryptMsg,
        [NativeTypeName("DWORD")] uint cSignerStore,
        HCERTSTORE* rghSignerStore,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppSigner,
        [NativeTypeName("DWORD *")] uint* pdwSignerIndex
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptMsgSignCTL(
        [NativeTypeName("DWORD")] uint dwMsgEncodingType,
        byte* pbCtlContent,
        [NativeTypeName("DWORD")] uint cbCtlContent,
        [NativeTypeName("PCMSG_SIGNED_ENCODE_INFO")] CMSG_SIGNED_ENCODE_INFO* pSignInfo,
        [NativeTypeName("DWORD")] uint dwFlags,
        byte* pbEncoded,
        [NativeTypeName("DWORD *")] uint* pcbEncoded
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptMsgEncodeAndSignCTL(
        [NativeTypeName("DWORD")] uint dwMsgEncodingType,
        [NativeTypeName("PCTL_INFO")] CTL_INFO* pCtlInfo,
        [NativeTypeName("PCMSG_SIGNED_ENCODE_INFO")] CMSG_SIGNED_ENCODE_INFO* pSignInfo,
        [NativeTypeName("DWORD")] uint dwFlags,
        byte* pbEncoded,
        [NativeTypeName("DWORD *")] uint* pcbEncoded
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CertFindSubjectInSortedCTL(
        [NativeTypeName("PCRYPT_DATA_BLOB")] CRYPT_DATA_BLOB* pSubjectIdentifier,
        [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext,
        [NativeTypeName("DWORD")] uint dwFlags,
        void* pvReserved,
        [NativeTypeName("PCRYPT_DER_BLOB")] CRYPT_DATA_BLOB* pEncodedAttributes
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CertEnumSubjectInSortedCTL(
        [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pCtlContext,
        void** ppvNextSubject,
        [NativeTypeName("PCRYPT_DER_BLOB")] CRYPT_DATA_BLOB* pSubjectIdentifier,
        [NativeTypeName("PCRYPT_DER_BLOB")] CRYPT_DATA_BLOB* pEncodedAttributes
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertVerifyCTLUsage(
        [NativeTypeName("DWORD")] uint dwEncodingType,
        [NativeTypeName("DWORD")] uint dwSubjectType,
        void* pvSubject,
        [NativeTypeName("PCTL_USAGE")] CTL_USAGE* pSubjectUsage,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("PCTL_VERIFY_USAGE_PARA")] CTL_VERIFY_USAGE_PARA* pVerifyUsagePara,
        [NativeTypeName("PCTL_VERIFY_USAGE_STATUS")] CTL_VERIFY_USAGE_STATUS* pVerifyUsageStatus
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertVerifyRevocation(
        [NativeTypeName("DWORD")] uint dwEncodingType,
        [NativeTypeName("DWORD")] uint dwRevType,
        [NativeTypeName("DWORD")] uint cContext,
        [NativeTypeName("PVOID[]")] void** rgpvContext,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("PCERT_REVOCATION_PARA")] CERT_REVOCATION_PARA* pRevPara,
        [NativeTypeName("PCERT_REVOCATION_STATUS")] CERT_REVOCATION_STATUS* pRevStatus
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertCompareIntegerBlob(
        [NativeTypeName("PCRYPT_INTEGER_BLOB")] CRYPT_DATA_BLOB* pInt1,
        [NativeTypeName("PCRYPT_INTEGER_BLOB")] CRYPT_DATA_BLOB* pInt2
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CertCompareCertificate(
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("PCERT_INFO")] CERT_INFO* pCertId1,
        [NativeTypeName("PCERT_INFO")] CERT_INFO* pCertId2
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CertCompareCertificateName(
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("PCERT_NAME_BLOB")] CRYPT_DATA_BLOB* pCertName1,
        [NativeTypeName("PCERT_NAME_BLOB")] CRYPT_DATA_BLOB* pCertName2
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertIsRDNAttrsInCertificateName(
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("PCERT_NAME_BLOB")] CRYPT_DATA_BLOB* pCertName,
        [NativeTypeName("PCERT_RDN")] CERT_RDN* pRDN
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CertComparePublicKeyInfo(
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pPublicKey1,
        [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pPublicKey2
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint CertGetPublicKeyLength(
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pPublicKey
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptVerifyCertificateSignature(
        HCRYPTPROV_LEGACY hCryptProv,
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("const BYTE *")] byte* pbEncoded,
        [NativeTypeName("DWORD")] uint cbEncoded,
        [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pPublicKey
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptVerifyCertificateSignatureEx(
        HCRYPTPROV_LEGACY hCryptProv,
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("DWORD")] uint dwSubjectType,
        void* pvSubject,
        [NativeTypeName("DWORD")] uint dwIssuerType,
        void* pvIssuer,
        [NativeTypeName("DWORD")] uint dwFlags,
        void* pvExtra
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL CertIsStrongHashToSign(
        [NativeTypeName("PCCERT_STRONG_SIGN_PARA")] CERT_STRONG_SIGN_PARA* pStrongSignPara,
        [NativeTypeName("LPCWSTR")] ushort* pwszCNGHashAlgid,
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pSigningCert
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptHashToBeSigned(
        HCRYPTPROV_LEGACY hCryptProv,
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("const BYTE *")] byte* pbEncoded,
        [NativeTypeName("DWORD")] uint cbEncoded,
        byte* pbComputedHash,
        [NativeTypeName("DWORD *")] uint* pcbComputedHash
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptHashCertificate(
        HCRYPTPROV_LEGACY hCryptProv,
        [NativeTypeName("ALG_ID")] uint Algid,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("const BYTE *")] byte* pbEncoded,
        [NativeTypeName("DWORD")] uint cbEncoded,
        byte* pbComputedHash,
        [NativeTypeName("DWORD *")] uint* pcbComputedHash
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptHashCertificate2(
        [NativeTypeName("LPCWSTR")] ushort* pwszCNGHashAlgid,
        [NativeTypeName("DWORD")] uint dwFlags,
        void* pvReserved,
        [NativeTypeName("const BYTE *")] byte* pbEncoded,
        [NativeTypeName("DWORD")] uint cbEncoded,
        byte* pbComputedHash,
        [NativeTypeName("DWORD *")] uint* pcbComputedHash
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptSignCertificate(
        HCRYPTPROV_OR_NCRYPT_KEY_HANDLE hCryptProvOrNCryptKey,
        [NativeTypeName("DWORD")] uint dwKeySpec,
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("const BYTE *")] byte* pbEncodedToBeSigned,
        [NativeTypeName("DWORD")] uint cbEncodedToBeSigned,
        [NativeTypeName("PCRYPT_ALGORITHM_IDENTIFIER")]
            CRYPT_ALGORITHM_IDENTIFIER* pSignatureAlgorithm,
        [NativeTypeName("const void *")] void* pvHashAuxInfo,
        byte* pbSignature,
        [NativeTypeName("DWORD *")] uint* pcbSignature
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptSignAndEncodeCertificate(
        HCRYPTPROV_OR_NCRYPT_KEY_HANDLE hCryptProvOrNCryptKey,
        [NativeTypeName("DWORD")] uint dwKeySpec,
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("LPCSTR")] sbyte* lpszStructType,
        [NativeTypeName("const void *")] void* pvStructInfo,
        [NativeTypeName("PCRYPT_ALGORITHM_IDENTIFIER")]
            CRYPT_ALGORITHM_IDENTIFIER* pSignatureAlgorithm,
        [NativeTypeName("const void *")] void* pvHashAuxInfo,
        byte* pbEncoded,
        [NativeTypeName("DWORD *")] uint* pcbEncoded
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int CertVerifyTimeValidity(
        [NativeTypeName("LPFILETIME")] FILETIME* pTimeToVerify,
        [NativeTypeName("PCERT_INFO")] CERT_INFO* pCertInfo
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int CertVerifyCRLTimeValidity(
        [NativeTypeName("LPFILETIME")] FILETIME* pTimeToVerify,
        [NativeTypeName("PCRL_INFO")] CRL_INFO* pCrlInfo
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CertVerifyValidityNesting(
        [NativeTypeName("PCERT_INFO")] CERT_INFO* pSubjectInfo,
        [NativeTypeName("PCERT_INFO")] CERT_INFO* pIssuerInfo
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CertVerifyCRLRevocation(
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("PCERT_INFO")] CERT_INFO* pCertId,
        [NativeTypeName("DWORD")] uint cCrlInfo,
        [NativeTypeName("PCRL_INFO[]")] CRL_INFO** rgpCrlInfo
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [return: NativeTypeName("LPCSTR")]
    public static extern sbyte* CertAlgIdToOID([NativeTypeName("DWORD")] uint dwAlgId);

    [DllImport("crypt32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CertOIDToAlgId([NativeTypeName("LPCSTR")] sbyte* pszObjId);

    [DllImport("crypt32", ExactSpelling = true)]
    [return: NativeTypeName("PCERT_EXTENSION")]
    public static extern CERT_EXTENSION* CertFindExtension(
        [NativeTypeName("LPCSTR")] sbyte* pszObjId,
        [NativeTypeName("DWORD")] uint cExtensions,
        [NativeTypeName("CERT_EXTENSION[]")] CERT_EXTENSION* rgExtensions
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [return: NativeTypeName("PCRYPT_ATTRIBUTE")]
    public static extern CRYPT_ATTRIBUTE* CertFindAttribute(
        [NativeTypeName("LPCSTR")] sbyte* pszObjId,
        [NativeTypeName("DWORD")] uint cAttr,
        [NativeTypeName("CRYPT_ATTRIBUTE[]")] CRYPT_ATTRIBUTE* rgAttr
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [return: NativeTypeName("PCERT_RDN_ATTR")]
    public static extern CERT_RDN_ATTR* CertFindRDNAttr(
        [NativeTypeName("LPCSTR")] sbyte* pszObjId,
        [NativeTypeName("PCERT_NAME_INFO")] CERT_NAME_INFO* pName
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertGetIntendedKeyUsage(
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("PCERT_INFO")] CERT_INFO* pCertInfo,
        byte* pbKeyUsage,
        [NativeTypeName("DWORD")] uint cbKeyUsage
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptInstallDefaultContext(
        HCRYPTPROV hCryptProv,
        [NativeTypeName("DWORD")] uint dwDefaultType,
        [NativeTypeName("const void *")] void* pvDefaultPara,
        [NativeTypeName("DWORD")] uint dwFlags,
        void* pvReserved,
        HCRYPTDEFAULTCONTEXT* phDefaultContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptUninstallDefaultContext(
        HCRYPTDEFAULTCONTEXT hDefaultContext,
        [NativeTypeName("DWORD")] uint dwFlags,
        void* pvReserved
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptExportPublicKeyInfo(
        HCRYPTPROV_OR_NCRYPT_KEY_HANDLE hCryptProvOrNCryptKey,
        [NativeTypeName("DWORD")] uint dwKeySpec,
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pInfo,
        [NativeTypeName("DWORD *")] uint* pcbInfo
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptExportPublicKeyInfoEx(
        HCRYPTPROV_OR_NCRYPT_KEY_HANDLE hCryptProvOrNCryptKey,
        [NativeTypeName("DWORD")] uint dwKeySpec,
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("LPSTR")] sbyte* pszPublicKeyObjId,
        [NativeTypeName("DWORD")] uint dwFlags,
        void* pvAuxInfo,
        [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pInfo,
        [NativeTypeName("DWORD *")] uint* pcbInfo
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CryptExportPublicKeyInfoFromBCryptKeyHandle(
        [NativeTypeName("BCRYPT_KEY_HANDLE")] void* hBCryptKey,
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("LPSTR")] sbyte* pszPublicKeyObjId,
        [NativeTypeName("DWORD")] uint dwFlags,
        void* pvAuxInfo,
        [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pInfo,
        [NativeTypeName("DWORD *")] uint* pcbInfo
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptImportPublicKeyInfo(
        HCRYPTPROV hCryptProv,
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pInfo,
        HCRYPTKEY* phKey
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptImportPublicKeyInfoEx(
        HCRYPTPROV hCryptProv,
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pInfo,
        [NativeTypeName("ALG_ID")] uint aiKeyAlg,
        [NativeTypeName("DWORD")] uint dwFlags,
        void* pvAuxInfo,
        HCRYPTKEY* phKey
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptImportPublicKeyInfoEx2(
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pInfo,
        [NativeTypeName("DWORD")] uint dwFlags,
        void* pvAuxInfo,
        [NativeTypeName("BCRYPT_KEY_HANDLE *")] void** phKey
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptAcquireCertificatePrivateKey(
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCert,
        [NativeTypeName("DWORD")] uint dwFlags,
        void* pvParameters,
        HCRYPTPROV_OR_NCRYPT_KEY_HANDLE* phCryptProvOrNCryptKey,
        [NativeTypeName("DWORD *")] uint* pdwKeySpec,
        BOOL* pfCallerFreeProvOrNCryptKey
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptFindCertificateKeyProvInfo(
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCert,
        [NativeTypeName("DWORD")] uint dwFlags,
        void* pvReserved
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptImportPKCS8(
        CRYPT_PKCS8_IMPORT_PARAMS sPrivateKeyAndParams,
        [NativeTypeName("DWORD")] uint dwFlags,
        HCRYPTPROV* phCryptProv,
        void* pvAuxInfo
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptExportPKCS8(
        HCRYPTPROV hCryptProv,
        [NativeTypeName("DWORD")] uint dwKeySpec,
        [NativeTypeName("LPSTR")] sbyte* pszPrivateKeyObjId,
        [NativeTypeName("DWORD")] uint dwFlags,
        void* pvAuxInfo,
        byte* pbPrivateKeyBlob,
        [NativeTypeName("DWORD *")] uint* pcbPrivateKeyBlob
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptHashPublicKeyInfo(
        HCRYPTPROV_LEGACY hCryptProv,
        [NativeTypeName("ALG_ID")] uint Algid,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pInfo,
        byte* pbComputedHash,
        [NativeTypeName("DWORD *")] uint* pcbComputedHash
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CertRDNValueToStrA(
        [NativeTypeName("DWORD")] uint dwValueType,
        [NativeTypeName("PCERT_RDN_VALUE_BLOB")] CRYPT_DATA_BLOB* pValue,
        [NativeTypeName("LPSTR")] sbyte* psz,
        [NativeTypeName("DWORD")] uint csz
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CertRDNValueToStrW(
        [NativeTypeName("DWORD")] uint dwValueType,
        [NativeTypeName("PCERT_RDN_VALUE_BLOB")] CRYPT_DATA_BLOB* pValue,
        [NativeTypeName("LPWSTR")] ushort* psz,
        [NativeTypeName("DWORD")] uint csz
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CertNameToStrA(
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("PCERT_NAME_BLOB")] CRYPT_DATA_BLOB* pName,
        [NativeTypeName("DWORD")] uint dwStrType,
        [NativeTypeName("LPSTR")] sbyte* psz,
        [NativeTypeName("DWORD")] uint csz
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CertNameToStrW(
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("PCERT_NAME_BLOB")] CRYPT_DATA_BLOB* pName,
        [NativeTypeName("DWORD")] uint dwStrType,
        [NativeTypeName("LPWSTR")] ushort* psz,
        [NativeTypeName("DWORD")] uint csz
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertStrToNameA(
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("LPCSTR")] sbyte* pszX500,
        [NativeTypeName("DWORD")] uint dwStrType,
        void* pvReserved,
        byte* pbEncoded,
        [NativeTypeName("DWORD *")] uint* pcbEncoded,
        [NativeTypeName("LPCSTR *")] sbyte** ppszError
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertStrToNameW(
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("LPCWSTR")] ushort* pszX500,
        [NativeTypeName("DWORD")] uint dwStrType,
        void* pvReserved,
        byte* pbEncoded,
        [NativeTypeName("DWORD *")] uint* pcbEncoded,
        [NativeTypeName("LPCWSTR *")] ushort** ppszError
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CertGetNameStringA(
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext,
        [NativeTypeName("DWORD")] uint dwType,
        [NativeTypeName("DWORD")] uint dwFlags,
        void* pvTypePara,
        [NativeTypeName("LPSTR")] sbyte* pszNameString,
        [NativeTypeName("DWORD")] uint cchNameString
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CertGetNameStringW(
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext,
        [NativeTypeName("DWORD")] uint dwType,
        [NativeTypeName("DWORD")] uint dwFlags,
        void* pvTypePara,
        [NativeTypeName("LPWSTR")] ushort* pszNameString,
        [NativeTypeName("DWORD")] uint cchNameString
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptSignMessage(
        [NativeTypeName("PCRYPT_SIGN_MESSAGE_PARA")] CRYPT_SIGN_MESSAGE_PARA* pSignPara,
        BOOL fDetachedSignature,
        [NativeTypeName("DWORD")] uint cToBeSigned,
        [NativeTypeName("const BYTE *[]")] byte** rgpbToBeSigned,
        [NativeTypeName("DWORD[]")] uint* rgcbToBeSigned,
        byte* pbSignedBlob,
        [NativeTypeName("DWORD *")] uint* pcbSignedBlob
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptVerifyMessageSignature(
        [NativeTypeName("PCRYPT_VERIFY_MESSAGE_PARA")] CRYPT_VERIFY_MESSAGE_PARA* pVerifyPara,
        [NativeTypeName("DWORD")] uint dwSignerIndex,
        [NativeTypeName("const BYTE *")] byte* pbSignedBlob,
        [NativeTypeName("DWORD")] uint cbSignedBlob,
        byte* pbDecoded,
        [NativeTypeName("DWORD *")] uint* pcbDecoded,
        [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppSignerCert
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LONG")]
    public static extern int CryptGetMessageSignerCount(
        [NativeTypeName("DWORD")] uint dwMsgEncodingType,
        [NativeTypeName("const BYTE *")] byte* pbSignedBlob,
        [NativeTypeName("DWORD")] uint cbSignedBlob
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HCERTSTORE CryptGetMessageCertificates(
        [NativeTypeName("DWORD")] uint dwMsgAndCertEncodingType,
        HCRYPTPROV_LEGACY hCryptProv,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("const BYTE *")] byte* pbSignedBlob,
        [NativeTypeName("DWORD")] uint cbSignedBlob
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptVerifyDetachedMessageSignature(
        [NativeTypeName("PCRYPT_VERIFY_MESSAGE_PARA")] CRYPT_VERIFY_MESSAGE_PARA* pVerifyPara,
        [NativeTypeName("DWORD")] uint dwSignerIndex,
        [NativeTypeName("const BYTE *")] byte* pbDetachedSignBlob,
        [NativeTypeName("DWORD")] uint cbDetachedSignBlob,
        [NativeTypeName("DWORD")] uint cToBeSigned,
        [NativeTypeName("const BYTE *[]")] byte** rgpbToBeSigned,
        [NativeTypeName("DWORD[]")] uint* rgcbToBeSigned,
        [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppSignerCert
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptEncryptMessage(
        [NativeTypeName("PCRYPT_ENCRYPT_MESSAGE_PARA")] CRYPT_ENCRYPT_MESSAGE_PARA* pEncryptPara,
        [NativeTypeName("DWORD")] uint cRecipientCert,
        [NativeTypeName("PCCERT_CONTEXT[]")] CERT_CONTEXT** rgpRecipientCert,
        [NativeTypeName("const BYTE *")] byte* pbToBeEncrypted,
        [NativeTypeName("DWORD")] uint cbToBeEncrypted,
        byte* pbEncryptedBlob,
        [NativeTypeName("DWORD *")] uint* pcbEncryptedBlob
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptDecryptMessage(
        [NativeTypeName("PCRYPT_DECRYPT_MESSAGE_PARA")] CRYPT_DECRYPT_MESSAGE_PARA* pDecryptPara,
        [NativeTypeName("const BYTE *")] byte* pbEncryptedBlob,
        [NativeTypeName("DWORD")] uint cbEncryptedBlob,
        byte* pbDecrypted,
        [NativeTypeName("DWORD *")] uint* pcbDecrypted,
        [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppXchgCert
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptSignAndEncryptMessage(
        [NativeTypeName("PCRYPT_SIGN_MESSAGE_PARA")] CRYPT_SIGN_MESSAGE_PARA* pSignPara,
        [NativeTypeName("PCRYPT_ENCRYPT_MESSAGE_PARA")] CRYPT_ENCRYPT_MESSAGE_PARA* pEncryptPara,
        [NativeTypeName("DWORD")] uint cRecipientCert,
        [NativeTypeName("PCCERT_CONTEXT[]")] CERT_CONTEXT** rgpRecipientCert,
        [NativeTypeName("const BYTE *")] byte* pbToBeSignedAndEncrypted,
        [NativeTypeName("DWORD")] uint cbToBeSignedAndEncrypted,
        byte* pbSignedAndEncryptedBlob,
        [NativeTypeName("DWORD *")] uint* pcbSignedAndEncryptedBlob
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptDecryptAndVerifyMessageSignature(
        [NativeTypeName("PCRYPT_DECRYPT_MESSAGE_PARA")] CRYPT_DECRYPT_MESSAGE_PARA* pDecryptPara,
        [NativeTypeName("PCRYPT_VERIFY_MESSAGE_PARA")] CRYPT_VERIFY_MESSAGE_PARA* pVerifyPara,
        [NativeTypeName("DWORD")] uint dwSignerIndex,
        [NativeTypeName("const BYTE *")] byte* pbEncryptedBlob,
        [NativeTypeName("DWORD")] uint cbEncryptedBlob,
        byte* pbDecrypted,
        [NativeTypeName("DWORD *")] uint* pcbDecrypted,
        [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppXchgCert,
        [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppSignerCert
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptDecodeMessage(
        [NativeTypeName("DWORD")] uint dwMsgTypeFlags,
        [NativeTypeName("PCRYPT_DECRYPT_MESSAGE_PARA")] CRYPT_DECRYPT_MESSAGE_PARA* pDecryptPara,
        [NativeTypeName("PCRYPT_VERIFY_MESSAGE_PARA")] CRYPT_VERIFY_MESSAGE_PARA* pVerifyPara,
        [NativeTypeName("DWORD")] uint dwSignerIndex,
        [NativeTypeName("const BYTE *")] byte* pbEncodedBlob,
        [NativeTypeName("DWORD")] uint cbEncodedBlob,
        [NativeTypeName("DWORD")] uint dwPrevInnerContentType,
        [NativeTypeName("DWORD *")] uint* pdwMsgType,
        [NativeTypeName("DWORD *")] uint* pdwInnerContentType,
        byte* pbDecoded,
        [NativeTypeName("DWORD *")] uint* pcbDecoded,
        [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppXchgCert,
        [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppSignerCert
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptHashMessage(
        [NativeTypeName("PCRYPT_HASH_MESSAGE_PARA")] CRYPT_HASH_MESSAGE_PARA* pHashPara,
        BOOL fDetachedHash,
        [NativeTypeName("DWORD")] uint cToBeHashed,
        [NativeTypeName("const BYTE *[]")] byte** rgpbToBeHashed,
        [NativeTypeName("DWORD[]")] uint* rgcbToBeHashed,
        byte* pbHashedBlob,
        [NativeTypeName("DWORD *")] uint* pcbHashedBlob,
        byte* pbComputedHash,
        [NativeTypeName("DWORD *")] uint* pcbComputedHash
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptVerifyMessageHash(
        [NativeTypeName("PCRYPT_HASH_MESSAGE_PARA")] CRYPT_HASH_MESSAGE_PARA* pHashPara,
        byte* pbHashedBlob,
        [NativeTypeName("DWORD")] uint cbHashedBlob,
        byte* pbToBeHashed,
        [NativeTypeName("DWORD *")] uint* pcbToBeHashed,
        byte* pbComputedHash,
        [NativeTypeName("DWORD *")] uint* pcbComputedHash
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptVerifyDetachedMessageHash(
        [NativeTypeName("PCRYPT_HASH_MESSAGE_PARA")] CRYPT_HASH_MESSAGE_PARA* pHashPara,
        byte* pbDetachedHashBlob,
        [NativeTypeName("DWORD")] uint cbDetachedHashBlob,
        [NativeTypeName("DWORD")] uint cToBeHashed,
        [NativeTypeName("const BYTE *[]")] byte** rgpbToBeHashed,
        [NativeTypeName("DWORD[]")] uint* rgcbToBeHashed,
        byte* pbComputedHash,
        [NativeTypeName("DWORD *")] uint* pcbComputedHash
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptSignMessageWithKey(
        [NativeTypeName("PCRYPT_KEY_SIGN_MESSAGE_PARA")] CRYPT_KEY_SIGN_MESSAGE_PARA* pSignPara,
        [NativeTypeName("const BYTE *")] byte* pbToBeSigned,
        [NativeTypeName("DWORD")] uint cbToBeSigned,
        byte* pbSignedBlob,
        [NativeTypeName("DWORD *")] uint* pcbSignedBlob
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptVerifyMessageSignatureWithKey(
        [NativeTypeName("PCRYPT_KEY_VERIFY_MESSAGE_PARA")]
            CRYPT_KEY_VERIFY_MESSAGE_PARA* pVerifyPara,
        [NativeTypeName("PCERT_PUBLIC_KEY_INFO")] CERT_PUBLIC_KEY_INFO* pPublicKeyInfo,
        [NativeTypeName("const BYTE *")] byte* pbSignedBlob,
        [NativeTypeName("DWORD")] uint cbSignedBlob,
        byte* pbDecoded,
        [NativeTypeName("DWORD *")] uint* pcbDecoded
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HCERTSTORE CertOpenSystemStoreA(
        HCRYPTPROV_LEGACY hProv,
        [NativeTypeName("LPCSTR")] sbyte* szSubsystemProtocol
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HCERTSTORE CertOpenSystemStoreW(
        HCRYPTPROV_LEGACY hProv,
        [NativeTypeName("LPCWSTR")] ushort* szSubsystemProtocol
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertAddEncodedCertificateToSystemStoreA(
        [NativeTypeName("LPCSTR")] sbyte* szCertStoreName,
        [NativeTypeName("const BYTE *")] byte* pbCertEncoded,
        [NativeTypeName("DWORD")] uint cbCertEncoded
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertAddEncodedCertificateToSystemStoreW(
        [NativeTypeName("LPCWSTR")] ushort* szCertStoreName,
        [NativeTypeName("const BYTE *")] byte* pbCertEncoded,
        [NativeTypeName("DWORD")] uint cbCertEncoded
    );

    [DllImport("wintrust", ExactSpelling = true)]
    public static extern HRESULT FindCertsByIssuer(
        [NativeTypeName("PCERT_CHAIN")] CERT_CHAIN* pCertChains,
        [NativeTypeName("DWORD *")] uint* pcbCertChains,
        [NativeTypeName("DWORD *")] uint* pcCertChains,
        byte* pbEncodedIssuerName,
        [NativeTypeName("DWORD")] uint cbEncodedIssuerName,
        [NativeTypeName("LPCWSTR")] ushort* pwszPurpose,
        [NativeTypeName("DWORD")] uint dwKeySpec
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptQueryObject(
        [NativeTypeName("DWORD")] uint dwObjectType,
        [NativeTypeName("const void *")] void* pvObject,
        [NativeTypeName("DWORD")] uint dwExpectedContentTypeFlags,
        [NativeTypeName("DWORD")] uint dwExpectedFormatTypeFlags,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD *")] uint* pdwMsgAndCertEncodingType,
        [NativeTypeName("DWORD *")] uint* pdwContentType,
        [NativeTypeName("DWORD *")] uint* pdwFormatType,
        HCERTSTORE* phCertStore,
        HCRYPTMSG* phMsg,
        [NativeTypeName("const void **")] void** ppvContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [return: NativeTypeName("LPVOID")]
    public static extern void* CryptMemAlloc([NativeTypeName("ULONG")] uint cbSize);

    [DllImport("crypt32", ExactSpelling = true)]
    [return: NativeTypeName("LPVOID")]
    public static extern void* CryptMemRealloc(
        [NativeTypeName("LPVOID")] void* pv,
        [NativeTypeName("ULONG")] uint cbSize
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern void CryptMemFree([NativeTypeName("LPVOID")] void* pv);

    [DllImport("crypt32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern BOOL CryptCreateAsyncHandle(
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("PHCRYPTASYNC")] HANDLE* phAsync
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19043.0")]
    [SupportedOSPlatform("windows10.0.20348.0")]
    public static extern BOOL CryptSetAsyncParam(
        HCRYPTASYNC hAsync,
        [NativeTypeName("LPSTR")] sbyte* pszParamOid,
        [NativeTypeName("LPVOID")] void* pvParam,
        [NativeTypeName("PFN_CRYPT_ASYNC_PARAM_FREE_FUNC")]
            delegate* unmanaged<sbyte*, void*, void> pfnFree
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern BOOL CryptGetAsyncParam(
        HCRYPTASYNC hAsync,
        [NativeTypeName("LPSTR")] sbyte* pszParamOid,
        [NativeTypeName("LPVOID *")] void** ppvParam,
        [NativeTypeName("PFN_CRYPT_ASYNC_PARAM_FREE_FUNC *")]
            delegate* unmanaged<sbyte*, void*, void>* ppfnFree
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern BOOL CryptCloseAsyncHandle(HCRYPTASYNC hAsync);

    [DllImport("cryptnet", ExactSpelling = true)]
    public static extern BOOL CryptRetrieveObjectByUrlA(
        [NativeTypeName("LPCSTR")] sbyte* pszUrl,
        [NativeTypeName("LPCSTR")] sbyte* pszObjectOid,
        [NativeTypeName("DWORD")] uint dwRetrievalFlags,
        [NativeTypeName("DWORD")] uint dwTimeout,
        [NativeTypeName("LPVOID *")] void** ppvObject,
        HCRYPTASYNC hAsyncRetrieve,
        [NativeTypeName("PCRYPT_CREDENTIALS")] CRYPT_CREDENTIALS* pCredentials,
        [NativeTypeName("LPVOID")] void* pvVerify,
        [NativeTypeName("PCRYPT_RETRIEVE_AUX_INFO")] CRYPT_RETRIEVE_AUX_INFO* pAuxInfo
    );

    [DllImport("cryptnet", ExactSpelling = true)]
    public static extern BOOL CryptRetrieveObjectByUrlW(
        [NativeTypeName("LPCWSTR")] ushort* pszUrl,
        [NativeTypeName("LPCSTR")] sbyte* pszObjectOid,
        [NativeTypeName("DWORD")] uint dwRetrievalFlags,
        [NativeTypeName("DWORD")] uint dwTimeout,
        [NativeTypeName("LPVOID *")] void** ppvObject,
        HCRYPTASYNC hAsyncRetrieve,
        [NativeTypeName("PCRYPT_CREDENTIALS")] CRYPT_CREDENTIALS* pCredentials,
        [NativeTypeName("LPVOID")] void* pvVerify,
        [NativeTypeName("PCRYPT_RETRIEVE_AUX_INFO")] CRYPT_RETRIEVE_AUX_INFO* pAuxInfo
    );

    [DllImport("cryptnet", ExactSpelling = true)]
    public static extern BOOL CryptInstallCancelRetrieval(
        [NativeTypeName("PFN_CRYPT_CANCEL_RETRIEVAL")]
            delegate* unmanaged<uint, void*, BOOL> pfnCancel,
        [NativeTypeName("const void *")] void* pvArg,
        [NativeTypeName("DWORD")] uint dwFlags,
        void* pvReserved
    );

    [DllImport("cryptnet", ExactSpelling = true)]
    public static extern BOOL CryptUninstallCancelRetrieval(
        [NativeTypeName("DWORD")] uint dwFlags,
        void* pvReserved
    );

    [DllImport("cryptnet", ExactSpelling = true)]
    public static extern BOOL CryptCancelAsyncRetrieval(HCRYPTASYNC hAsyncRetrieval);

    [DllImport("cryptnet", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptGetObjectUrl(
        [NativeTypeName("LPCSTR")] sbyte* pszUrlOid,
        [NativeTypeName("LPVOID")] void* pvPara,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("PCRYPT_URL_ARRAY")] CRYPT_URL_ARRAY* pUrlArray,
        [NativeTypeName("DWORD *")] uint* pcbUrlArray,
        [NativeTypeName("PCRYPT_URL_INFO")] CRYPT_URL_INFO* pUrlInfo,
        [NativeTypeName("DWORD *")] uint* pcbUrlInfo,
        [NativeTypeName("LPVOID")] void* pvReserved
    );

    [DllImport("cryptnet", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptGetTimeValidObject(
        [NativeTypeName("LPCSTR")] sbyte* pszTimeValidOid,
        [NativeTypeName("LPVOID")] void* pvPara,
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pIssuer,
        [NativeTypeName("LPFILETIME")] FILETIME* pftValidFor,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD")] uint dwTimeout,
        [NativeTypeName("LPVOID *")] void** ppvObject,
        [NativeTypeName("PCRYPT_CREDENTIALS")] CRYPT_CREDENTIALS* pCredentials,
        [NativeTypeName("PCRYPT_GET_TIME_VALID_OBJECT_EXTRA_INFO")]
            CRYPT_GET_TIME_VALID_OBJECT_EXTRA_INFO* pExtraInfo
    );

    [DllImport("cryptnet", ExactSpelling = true)]
    public static extern BOOL CryptFlushTimeValidObject(
        [NativeTypeName("LPCSTR")] sbyte* pszFlushTimeValidOid,
        [NativeTypeName("LPVOID")] void* pvPara,
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pIssuer,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPVOID")] void* pvReserved
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PCCERT_CONTEXT")]
    public static extern CERT_CONTEXT* CertCreateSelfSignCertificate(
        HCRYPTPROV_OR_NCRYPT_KEY_HANDLE hCryptProvOrNCryptKey,
        [NativeTypeName("PCERT_NAME_BLOB")] CRYPT_DATA_BLOB* pSubjectIssuerBlob,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("PCRYPT_KEY_PROV_INFO")] CRYPT_KEY_PROV_INFO* pKeyProvInfo,
        [NativeTypeName("PCRYPT_ALGORITHM_IDENTIFIER")]
            CRYPT_ALGORITHM_IDENTIFIER* pSignatureAlgorithm,
        [NativeTypeName("PSYSTEMTIME")] SYSTEMTIME* pStartTime,
        [NativeTypeName("PSYSTEMTIME")] SYSTEMTIME* pEndTime,
        [NativeTypeName("PCERT_EXTENSIONS")] CERT_EXTENSIONS* pExtensions
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptGetKeyIdentifierProperty(
        [NativeTypeName("const CRYPT_HASH_BLOB *")] CRYPT_DATA_BLOB* pKeyIdentifier,
        [NativeTypeName("DWORD")] uint dwPropId,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPCWSTR")] ushort* pwszComputerName,
        void* pvReserved,
        void* pvData,
        [NativeTypeName("DWORD *")] uint* pcbData
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptSetKeyIdentifierProperty(
        [NativeTypeName("const CRYPT_HASH_BLOB *")] CRYPT_DATA_BLOB* pKeyIdentifier,
        [NativeTypeName("DWORD")] uint dwPropId,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPCWSTR")] ushort* pwszComputerName,
        void* pvReserved,
        [NativeTypeName("const void *")] void* pvData
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptEnumKeyIdentifierProperties(
        [NativeTypeName("const CRYPT_HASH_BLOB *")] CRYPT_DATA_BLOB* pKeyIdentifier,
        [NativeTypeName("DWORD")] uint dwPropId,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPCWSTR")] ushort* pwszComputerName,
        void* pvReserved,
        void* pvArg,
        [NativeTypeName("PFN_CRYPT_ENUM_KEYID_PROP")]
            delegate* unmanaged<
            CRYPT_DATA_BLOB*,
            uint,
            void*,
            void*,
            uint,
            uint*,
            void**,
            uint*,
            BOOL> pfnEnum
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptCreateKeyIdentifierFromCSP(
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("LPCSTR")] sbyte* pszPubKeyOID,
        [NativeTypeName("const PUBLICKEYSTRUC *")] PUBLICKEYSTRUC* pPubKeyStruc,
        [NativeTypeName("DWORD")] uint cbPubKeyStruc,
        [NativeTypeName("DWORD")] uint dwFlags,
        void* pvReserved,
        byte* pbHash,
        [NativeTypeName("DWORD *")] uint* pcbHash
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertCreateCertificateChainEngine(
        [NativeTypeName("PCERT_CHAIN_ENGINE_CONFIG")] CERT_CHAIN_ENGINE_CONFIG* pConfig,
        HCERTCHAINENGINE* phChainEngine
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern void CertFreeCertificateChainEngine(HCERTCHAINENGINE hChainEngine);

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0")]
    public static extern BOOL CertResyncCertificateChainEngine(HCERTCHAINENGINE hChainEngine);

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertGetCertificateChain(
        HCERTCHAINENGINE hChainEngine,
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext,
        [NativeTypeName("LPFILETIME")] FILETIME* pTime,
        HCERTSTORE hAdditionalStore,
        [NativeTypeName("PCERT_CHAIN_PARA")] CERT_CHAIN_PARA* pChainPara,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPVOID")] void* pvReserved,
        [NativeTypeName("PCCERT_CHAIN_CONTEXT *")] CERT_CHAIN_CONTEXT** ppChainContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern void CertFreeCertificateChain(
        [NativeTypeName("PCCERT_CHAIN_CONTEXT")] CERT_CHAIN_CONTEXT* pChainContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [return: NativeTypeName("PCCERT_CHAIN_CONTEXT")]
    public static extern CERT_CHAIN_CONTEXT* CertDuplicateCertificateChain(
        [NativeTypeName("PCCERT_CHAIN_CONTEXT")] CERT_CHAIN_CONTEXT* pChainContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [return: NativeTypeName("PCCERT_CHAIN_CONTEXT")]
    public static extern CERT_CHAIN_CONTEXT* CertFindChainInStore(
        HCERTSTORE hCertStore,
        [NativeTypeName("DWORD")] uint dwCertEncodingType,
        [NativeTypeName("DWORD")] uint dwFindFlags,
        [NativeTypeName("DWORD")] uint dwFindType,
        [NativeTypeName("const void *")] void* pvFindPara,
        [NativeTypeName("PCCERT_CHAIN_CONTEXT")] CERT_CHAIN_CONTEXT* pPrevChainContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CertVerifyCertificateChainPolicy(
        [NativeTypeName("LPCSTR")] sbyte* pszPolicyOID,
        [NativeTypeName("PCCERT_CHAIN_CONTEXT")] CERT_CHAIN_CONTEXT* pChainContext,
        [NativeTypeName("PCERT_CHAIN_POLICY_PARA")] CERT_CHAIN_POLICY_PARA* pPolicyPara,
        [NativeTypeName("PCERT_CHAIN_POLICY_STATUS")] CERT_CHAIN_POLICY_STATUS* pPolicyStatus
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CryptStringToBinaryA(
        [NativeTypeName("LPCSTR")] sbyte* pszString,
        [NativeTypeName("DWORD")] uint cchString,
        [NativeTypeName("DWORD")] uint dwFlags,
        byte* pbBinary,
        [NativeTypeName("DWORD *")] uint* pcbBinary,
        [NativeTypeName("DWORD *")] uint* pdwSkip,
        [NativeTypeName("DWORD *")] uint* pdwFlags
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CryptStringToBinaryW(
        [NativeTypeName("LPCWSTR")] ushort* pszString,
        [NativeTypeName("DWORD")] uint cchString,
        [NativeTypeName("DWORD")] uint dwFlags,
        byte* pbBinary,
        [NativeTypeName("DWORD *")] uint* pcbBinary,
        [NativeTypeName("DWORD *")] uint* pdwSkip,
        [NativeTypeName("DWORD *")] uint* pdwFlags
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CryptBinaryToStringA(
        [NativeTypeName("const BYTE *")] byte* pbBinary,
        [NativeTypeName("DWORD")] uint cbBinary,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPSTR")] sbyte* pszString,
        [NativeTypeName("DWORD *")] uint* pcchString
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CryptBinaryToStringW(
        [NativeTypeName("const BYTE *")] byte* pbBinary,
        [NativeTypeName("DWORD")] uint cbBinary,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPWSTR")] ushort* pszString,
        [NativeTypeName("DWORD *")] uint* pcchString
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HCERTSTORE PFXImportCertStore(
        CRYPT_DATA_BLOB* pPFX,
        [NativeTypeName("LPCWSTR")] ushort* szPassword,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL PFXIsPFXBlob(CRYPT_DATA_BLOB* pPFX);

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL PFXVerifyPassword(
        CRYPT_DATA_BLOB* pPFX,
        [NativeTypeName("LPCWSTR")] ushort* szPassword,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PFXExportCertStoreEx(
        HCERTSTORE hStore,
        CRYPT_DATA_BLOB* pPFX,
        [NativeTypeName("LPCWSTR")] ushort* szPassword,
        void* pvPara,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PFXExportCertStore(
        HCERTSTORE hStore,
        CRYPT_DATA_BLOB* pPFX,
        [NativeTypeName("LPCWSTR")] ushort* szPassword,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HCERT_SERVER_OCSP_RESPONSE CertOpenServerOcspResponse(
        [NativeTypeName("PCCERT_CHAIN_CONTEXT")] CERT_CHAIN_CONTEXT* pChainContext,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("PCERT_SERVER_OCSP_RESPONSE_OPEN_PARA")]
            CERT_SERVER_OCSP_RESPONSE_OPEN_PARA* pOpenPara
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern void CertAddRefServerOcspResponse(
        HCERT_SERVER_OCSP_RESPONSE hServerOcspResponse
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern void CertCloseServerOcspResponse(
        HCERT_SERVER_OCSP_RESPONSE hServerOcspResponse,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [return: NativeTypeName("PCCERT_SERVER_OCSP_RESPONSE_CONTEXT")]
    public static extern CERT_SERVER_OCSP_RESPONSE_CONTEXT* CertGetServerOcspResponseContext(
        HCERT_SERVER_OCSP_RESPONSE hServerOcspResponse,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPVOID")] void* pvReserved
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern void CertAddRefServerOcspResponseContext(
        [NativeTypeName("PCCERT_SERVER_OCSP_RESPONSE_CONTEXT")]
            CERT_SERVER_OCSP_RESPONSE_CONTEXT* pServerOcspResponseContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern void CertFreeServerOcspResponseContext(
        [NativeTypeName("PCCERT_SERVER_OCSP_RESPONSE_CONTEXT")]
            CERT_SERVER_OCSP_RESPONSE_CONTEXT* pServerOcspResponseContext
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertRetrieveLogoOrBiometricInfo(
        [NativeTypeName("PCCERT_CONTEXT")] CERT_CONTEXT* pCertContext,
        [NativeTypeName("LPCSTR")] sbyte* lpszLogoOrBiometricType,
        [NativeTypeName("DWORD")] uint dwRetrievalFlags,
        [NativeTypeName("DWORD")] uint dwTimeout,
        [NativeTypeName("DWORD")] uint dwFlags,
        void* pvReserved,
        byte** ppbData,
        [NativeTypeName("DWORD *")] uint* pcbData,
        [NativeTypeName("LPWSTR *")] ushort** ppwszMimeType
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CertSelectCertificateChains(
        [NativeTypeName("LPCGUID")] Guid* pSelectionContext,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("PCCERT_SELECT_CHAIN_PARA")] CERT_SELECT_CHAIN_PARA* pChainParameters,
        [NativeTypeName("DWORD")] uint cCriteria,
        [NativeTypeName("PCCERT_SELECT_CRITERIA")] CERT_SELECT_CRITERIA* rgpCriteria,
        HCERTSTORE hStore,
        [NativeTypeName("PDWORD")] uint* pcSelection,
        [NativeTypeName("PCCERT_CHAIN_CONTEXT **")] CERT_CHAIN_CONTEXT*** pprgpSelection
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern void CertFreeCertificateChainList(
        [NativeTypeName("PCCERT_CHAIN_CONTEXT *")] CERT_CHAIN_CONTEXT** prgpSelection
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptRetrieveTimeStamp(
        [NativeTypeName("LPCWSTR")] ushort* wszUrl,
        [NativeTypeName("DWORD")] uint dwRetrievalFlags,
        [NativeTypeName("DWORD")] uint dwTimeout,
        [NativeTypeName("LPCSTR")] sbyte* pszHashId,
        [NativeTypeName("const CRYPT_TIMESTAMP_PARA *")] CRYPT_TIMESTAMP_PARA* pPara,
        [NativeTypeName("const BYTE *")] byte* pbData,
        [NativeTypeName("DWORD")] uint cbData,
        [NativeTypeName("PCRYPT_TIMESTAMP_CONTEXT *")] CRYPT_TIMESTAMP_CONTEXT** ppTsContext,
        [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppTsSigner,
        HCERTSTORE* phStore
    );

    [DllImport("crypt32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CryptVerifyTimeStampSignature(
        [NativeTypeName("const BYTE *")] byte* pbTSContentInfo,
        [NativeTypeName("DWORD")] uint cbTSContentInfo,
        [NativeTypeName("const BYTE *")] byte* pbData,
        [NativeTypeName("DWORD")] uint cbData,
        HCERTSTORE hAdditionalStore,
        [NativeTypeName("PCRYPT_TIMESTAMP_CONTEXT *")] CRYPT_TIMESTAMP_CONTEXT** ppTsContext,
        [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppTsSigner,
        HCERTSTORE* phStore
    );

    [DllImport("crypt32", ExactSpelling = true)]
    public static extern BOOL CertIsWeakHash(
        [NativeTypeName("DWORD")] uint dwHashUseType,
        [NativeTypeName("LPCWSTR")] ushort* pwszCNGHashAlgid,
        [NativeTypeName("DWORD")] uint dwChainFlags,
        [NativeTypeName("PCCERT_CHAIN_CONTEXT")] CERT_CHAIN_CONTEXT* pSignerChainContext,
        [NativeTypeName("LPFILETIME")] FILETIME* pTimeStamp,
        [NativeTypeName("LPCWSTR")] ushort* pwszFileName
    );

    [NativeTypeName("#define RSA1024BIT_KEY 0x04000000")]
    public const int RSA1024BIT_KEY = 0x04000000;

    [NativeTypeName("#define SIMPLEBLOB 0x1")]
    public const int SIMPLEBLOB = 0x1;

    [NativeTypeName("#define PUBLICKEYBLOB 0x6")]
    public const int PUBLICKEYBLOB = 0x6;

    [NativeTypeName("#define PRIVATEKEYBLOB 0x7")]
    public const int PRIVATEKEYBLOB = 0x7;

    [NativeTypeName("#define PLAINTEXTKEYBLOB 0x8")]
    public const int PLAINTEXTKEYBLOB = 0x8;

    [NativeTypeName("#define OPAQUEKEYBLOB 0x9")]
    public const int OPAQUEKEYBLOB = 0x9;

    [NativeTypeName("#define PUBLICKEYBLOBEX 0xA")]
    public const int PUBLICKEYBLOBEX = 0xA;

    [NativeTypeName("#define SYMMETRICWRAPKEYBLOB 0xB")]
    public const int SYMMETRICWRAPKEYBLOB = 0xB;

    [NativeTypeName("#define KEYSTATEBLOB 0xC")]
    public const int KEYSTATEBLOB = 0xC;

    [NativeTypeName("#define AT_KEYEXCHANGE 1")]
    public const int AT_KEYEXCHANGE = 1;

    [NativeTypeName("#define AT_SIGNATURE 2")]
    public const int AT_SIGNATURE = 2;

    [NativeTypeName("#define PKCS5_PADDING 1")]
    public const int PKCS5_PADDING = 1;

    [NativeTypeName("#define RANDOM_PADDING 2")]
    public const int RANDOM_PADDING = 2;

    [NativeTypeName("#define ZERO_PADDING 3")]
    public const int ZERO_PADDING = 3;

    [NativeTypeName("#define HP_ALGID 0x0001")]
    public const int HP_ALGID = 0x0001;

    [NativeTypeName("#define HP_HASHVAL 0x0002")]
    public const int HP_HASHVAL = 0x0002;

    [NativeTypeName("#define HP_HASHSIZE 0x0004")]
    public const int HP_HASHSIZE = 0x0004;

    [NativeTypeName("#define HP_HMAC_INFO 0x0005")]
    public const int HP_HMAC_INFO = 0x0005;

    [NativeTypeName("#define HP_TLS1PRF_LABEL 0x0006")]
    public const int HP_TLS1PRF_LABEL = 0x0006;

    [NativeTypeName("#define HP_TLS1PRF_SEED 0x0007")]
    public const int HP_TLS1PRF_SEED = 0x0007;

    [NativeTypeName("#define MAXUIDLEN 64")]
    public const int MAXUIDLEN = 64;

    [NativeTypeName("#define EXPO_OFFLOAD_REG_VALUE \"ExpoOffload\"")]
    public static ReadOnlySpan<byte> EXPO_OFFLOAD_REG_VALUE => "ExpoOffload"u8;

    [NativeTypeName("#define EXPO_OFFLOAD_FUNC_NAME \"OffloadModExpo\"")]
    public static ReadOnlySpan<byte> EXPO_OFFLOAD_FUNC_NAME => "OffloadModExpo"u8;

    [NativeTypeName(
        "#define szKEY_CRYPTOAPI_PRIVATE_KEY_OPTIONS \"Software\\Policies\\Microsoft\\Cryptography\""
    )]
    public static ReadOnlySpan<byte> szKEY_CRYPTOAPI_PRIVATE_KEY_OPTIONS =>
        "Software\\Policies\\Microsoft\\Cryptography"u8;

    [NativeTypeName("#define szKEY_CACHE_ENABLED \"CachePrivateKeys\"")]
    public static ReadOnlySpan<byte> szKEY_CACHE_ENABLED => "CachePrivateKeys"u8;

    [NativeTypeName("#define szKEY_CACHE_SECONDS \"PrivateKeyLifetimeSeconds\"")]
    public static ReadOnlySpan<byte> szKEY_CACHE_SECONDS => "PrivateKeyLifetimeSeconds"u8;

    [NativeTypeName("#define szPRIV_KEY_CACHE_MAX_ITEMS \"PrivKeyCacheMaxItems\"")]
    public static ReadOnlySpan<byte> szPRIV_KEY_CACHE_MAX_ITEMS => "PrivKeyCacheMaxItems"u8;

    [NativeTypeName("#define cPRIV_KEY_CACHE_MAX_ITEMS_DEFAULT 20")]
    public const int cPRIV_KEY_CACHE_MAX_ITEMS_DEFAULT = 20;

    [NativeTypeName(
        "#define szPRIV_KEY_CACHE_PURGE_INTERVAL_SECONDS \"PrivKeyCachePurgeIntervalSeconds\""
    )]
    public static ReadOnlySpan<byte> szPRIV_KEY_CACHE_PURGE_INTERVAL_SECONDS =>
        "PrivKeyCachePurgeIntervalSeconds"u8;

    [NativeTypeName("#define cPRIV_KEY_CACHE_PURGE_INTERVAL_SECONDS_DEFAULT 86400")]
    public const int cPRIV_KEY_CACHE_PURGE_INTERVAL_SECONDS_DEFAULT = 86400;

    [NativeTypeName("#define CUR_BLOB_VERSION 2")]
    public const int CUR_BLOB_VERSION = 2;

    [NativeTypeName("#define INTERNATIONAL_USAGE 0x00000001")]
    public const int INTERNATIONAL_USAGE = 0x00000001;

    [NativeTypeName("#define CryptAcquireContext CryptAcquireContextW")]
    public static delegate* <HCRYPTPROV*, ushort*, ushort*, uint, uint, BOOL> CryptAcquireContext =>
        &CryptAcquireContextW;

    [NativeTypeName("#define CryptSignHash CryptSignHashW")]
    public static delegate* <HCRYPTHASH, uint, ushort*, uint, byte*, uint*, BOOL> CryptSignHash =>
        &CryptSignHashW;

    [NativeTypeName("#define CryptVerifySignature CryptVerifySignatureW")]
    public static delegate* <
        HCRYPTHASH,
        byte*,
        uint,
        HCRYPTKEY,
        ushort*,
        uint,
        BOOL> CryptVerifySignature => &CryptVerifySignatureW;

    [NativeTypeName("#define CryptSetProvider CryptSetProviderW")]
    public static delegate* <ushort*, uint, BOOL> CryptSetProvider => &CryptSetProviderW;

    [NativeTypeName("#define CryptSetProviderEx CryptSetProviderExW")]
    public static delegate* <ushort*, uint, uint*, uint, BOOL> CryptSetProviderEx =>
        &CryptSetProviderExW;

    [NativeTypeName("#define CryptGetDefaultProvider CryptGetDefaultProviderW")]
    public static delegate* <uint, uint*, uint, ushort*, uint*, BOOL> CryptGetDefaultProvider =>
        &CryptGetDefaultProviderW;

    [NativeTypeName("#define CryptEnumProviderTypes CryptEnumProviderTypesW")]
    public static delegate* <
        uint,
        uint*,
        uint,
        uint*,
        ushort*,
        uint*,
        BOOL> CryptEnumProviderTypes => &CryptEnumProviderTypesW;

    [NativeTypeName("#define CryptEnumProviders CryptEnumProvidersW")]
    public static delegate* <uint, uint*, uint, uint*, ushort*, uint*, BOOL> CryptEnumProviders =>
        &CryptEnumProvidersW;

    [NativeTypeName("#define RSA_CSP_PUBLICKEYBLOB ((LPCSTR) 19)")]
    public static sbyte* RSA_CSP_PUBLICKEYBLOB => ((sbyte*)(19));

    [NativeTypeName("#define X942_DH_PARAMETERS ((LPCSTR) 50)")]
    public static sbyte* X942_DH_PARAMETERS => ((sbyte*)(50));

    [NativeTypeName("#define X942_OTHER_INFO ((LPCSTR) 52)")]
    public static sbyte* X942_OTHER_INFO => ((sbyte*)(52));

    [NativeTypeName("#define CNG_RSA_PUBLIC_KEY_BLOB ((LPCSTR) 72)")]
    public static sbyte* CNG_RSA_PUBLIC_KEY_BLOB => ((sbyte*)(72));

    [NativeTypeName("#define ECC_CMS_SHARED_INFO ((LPCSTR) 77)")]
    public static sbyte* ECC_CMS_SHARED_INFO => ((sbyte*)(77));

    [NativeTypeName("#define CNG_RSA_PRIVATE_KEY_BLOB ((LPCSTR) 83)")]
    public static sbyte* CNG_RSA_PRIVATE_KEY_BLOB => ((sbyte*)(83));

    [NativeTypeName("#define PKCS7_SIGNER_INFO ((LPCSTR) 500)")]
    public static sbyte* PKCS7_SIGNER_INFO => ((sbyte*)(500));

    [NativeTypeName("#define CMS_SIGNER_INFO ((LPCSTR) 501)")]
    public static sbyte* CMS_SIGNER_INFO => ((sbyte*)(501));

    [NativeTypeName("#define wszURI_NTDS_OBJECTSID_PREFIX L\"tag:microsoft.com,2022-09-14:sid:\"")]
    public const string wszURI_NTDS_OBJECTSID_PREFIX = "tag:microsoft.com,2022-09-14:sid:";

    [NativeTypeName("#define SITE_PIN_RULES_ALL_SUBDOMAINS_FLAG 0x1")]
    public const int SITE_PIN_RULES_ALL_SUBDOMAINS_FLAG = 0x1;

    [NativeTypeName("#define CROSS_CERT_DIST_POINT_ERR_INDEX_MASK 0xFF")]
    public const int CROSS_CERT_DIST_POINT_ERR_INDEX_MASK = 0xFF;

    [NativeTypeName("#define CROSS_CERT_DIST_POINT_ERR_INDEX_SHIFT 24")]
    public const int CROSS_CERT_DIST_POINT_ERR_INDEX_SHIFT = 24;

    [NativeTypeName("#define SORTED_CTL_EXT_FLAGS_OFFSET (0*4)")]
    public const int SORTED_CTL_EXT_FLAGS_OFFSET = (0 * 4);

    [NativeTypeName("#define SORTED_CTL_EXT_COUNT_OFFSET (1*4)")]
    public const int SORTED_CTL_EXT_COUNT_OFFSET = (1 * 4);

    [NativeTypeName("#define SORTED_CTL_EXT_MAX_COLLISION_OFFSET (2*4)")]
    public const int SORTED_CTL_EXT_MAX_COLLISION_OFFSET = (2 * 4);

    [NativeTypeName("#define SORTED_CTL_EXT_HASH_BUCKET_OFFSET (3*4)")]
    public const int SORTED_CTL_EXT_HASH_BUCKET_OFFSET = (3 * 4);

    [NativeTypeName("#define SORTED_CTL_EXT_HASHED_SUBJECT_IDENTIFIER_FLAG 0x1")]
    public const int SORTED_CTL_EXT_HASHED_SUBJECT_IDENTIFIER_FLAG = 0x1;

    [NativeTypeName("#define szOIDVerisign_MessageType \"2.16.840.1.113733.1.9.2\"")]
    public static ReadOnlySpan<byte> szOIDVerisign_MessageType => "2.16.840.1.113733.1.9.2"u8;

    [NativeTypeName("#define szOIDVerisign_PkiStatus \"2.16.840.1.113733.1.9.3\"")]
    public static ReadOnlySpan<byte> szOIDVerisign_PkiStatus => "2.16.840.1.113733.1.9.3"u8;

    [NativeTypeName("#define szOIDVerisign_FailInfo \"2.16.840.1.113733.1.9.4\"")]
    public static ReadOnlySpan<byte> szOIDVerisign_FailInfo => "2.16.840.1.113733.1.9.4"u8;

    [NativeTypeName("#define szOIDVerisign_SenderNonce \"2.16.840.1.113733.1.9.5\"")]
    public static ReadOnlySpan<byte> szOIDVerisign_SenderNonce => "2.16.840.1.113733.1.9.5"u8;

    [NativeTypeName("#define szOIDVerisign_RecipientNonce \"2.16.840.1.113733.1.9.6\"")]
    public static ReadOnlySpan<byte> szOIDVerisign_RecipientNonce => "2.16.840.1.113733.1.9.6"u8;

    [NativeTypeName("#define szOIDVerisign_TransactionID \"2.16.840.1.113733.1.9.7\"")]
    public static ReadOnlySpan<byte> szOIDVerisign_TransactionID => "2.16.840.1.113733.1.9.7"u8;

    [NativeTypeName("#define NETSCAPE_SSL_CLIENT_AUTH_CERT_TYPE 0x80")]
    public const int NETSCAPE_SSL_CLIENT_AUTH_CERT_TYPE = 0x80;

    [NativeTypeName("#define NETSCAPE_SSL_SERVER_AUTH_CERT_TYPE 0x40")]
    public const int NETSCAPE_SSL_SERVER_AUTH_CERT_TYPE = 0x40;

    [NativeTypeName("#define NETSCAPE_SMIME_CERT_TYPE 0x20")]
    public const int NETSCAPE_SMIME_CERT_TYPE = 0x20;

    [NativeTypeName("#define NETSCAPE_SIGN_CERT_TYPE 0x10")]
    public const int NETSCAPE_SIGN_CERT_TYPE = 0x10;

    [NativeTypeName("#define NETSCAPE_SSL_CA_CERT_TYPE 0x04")]
    public const int NETSCAPE_SSL_CA_CERT_TYPE = 0x04;

    [NativeTypeName("#define NETSCAPE_SMIME_CA_CERT_TYPE 0x02")]
    public const int NETSCAPE_SMIME_CA_CERT_TYPE = 0x02;

    [NativeTypeName("#define NETSCAPE_SIGN_CA_CERT_TYPE 0x01")]
    public const int NETSCAPE_SIGN_CA_CERT_TYPE = 0x01;

    [NativeTypeName("#define CertRDNValueToStr CertRDNValueToStrW")]
    public static delegate* <uint, CRYPT_DATA_BLOB*, ushort*, uint, uint> CertRDNValueToStr =>
        &CertRDNValueToStrW;

    [NativeTypeName("#define CertNameToStr CertNameToStrW")]
    public static delegate* <uint, CRYPT_DATA_BLOB*, uint, ushort*, uint, uint> CertNameToStr =>
        &CertNameToStrW;

    [NativeTypeName("#define CertStrToName CertStrToNameW")]
    public static delegate* <
        uint,
        ushort*,
        uint,
        void*,
        byte*,
        uint*,
        ushort**,
        BOOL> CertStrToName => &CertStrToNameW;

    [NativeTypeName("#define CertGetNameString CertGetNameStringW")]
    public static delegate* <
        CERT_CONTEXT*,
        uint,
        uint,
        void*,
        ushort*,
        uint,
        uint> CertGetNameString => &CertGetNameStringW;

    [NativeTypeName("#define CertOpenSystemStore CertOpenSystemStoreW")]
    public static delegate* <HCRYPTPROV_LEGACY, ushort*, HCERTSTORE> CertOpenSystemStore =>
        &CertOpenSystemStoreW;

    [NativeTypeName(
        "#define CertAddEncodedCertificateToSystemStore CertAddEncodedCertificateToSystemStoreW"
    )]
    public static delegate* <ushort*, byte*, uint, BOOL> CertAddEncodedCertificateToSystemStore =>
        &CertAddEncodedCertificateToSystemStoreW;

    [NativeTypeName("#define CREDENTIAL_OID_PASSWORD_CREDENTIALS_A ((LPCSTR)1)")]
    public static sbyte* CREDENTIAL_OID_PASSWORD_CREDENTIALS_A => ((sbyte*)(1));

    [NativeTypeName("#define CREDENTIAL_OID_PASSWORD_CREDENTIALS_W ((LPCSTR)2)")]
    public static sbyte* CREDENTIAL_OID_PASSWORD_CREDENTIALS_W => ((sbyte*)(2));

    [NativeTypeName(
        "#define CREDENTIAL_OID_PASSWORD_CREDENTIALS CREDENTIAL_OID_PASSWORD_CREDENTIALS_W"
    )]
    public static sbyte* CREDENTIAL_OID_PASSWORD_CREDENTIALS => ((sbyte*)(2));

    [NativeTypeName("#define CryptRetrieveObjectByUrl CryptRetrieveObjectByUrlW")]
    public static delegate* <
        ushort*,
        sbyte*,
        uint,
        uint,
        void**,
        HCRYPTASYNC,
        CRYPT_CREDENTIALS*,
        void*,
        CRYPT_RETRIEVE_AUX_INFO*,
        BOOL> CryptRetrieveObjectByUrl => &CryptRetrieveObjectByUrlW;

    [NativeTypeName("#define USAGE_MATCH_TYPE_AND 0x00000000")]
    public const int USAGE_MATCH_TYPE_AND = 0x00000000;

    [NativeTypeName("#define USAGE_MATCH_TYPE_OR 0x00000001")]
    public const int USAGE_MATCH_TYPE_OR = 0x00000001;

    [NativeTypeName("#define REVOCATION_OID_CRL_REVOCATION ((LPCSTR)1)")]
    public static sbyte* REVOCATION_OID_CRL_REVOCATION => ((sbyte*)(1));

    [NativeTypeName("#define AUTHTYPE_CLIENT 1")]
    public const int AUTHTYPE_CLIENT = 1;

    [NativeTypeName("#define AUTHTYPE_SERVER 2")]
    public const int AUTHTYPE_SERVER = 2;

    [NativeTypeName("#define BASIC_CONSTRAINTS_CERT_CHAIN_POLICY_CA_FLAG 0x80000000")]
    public const uint BASIC_CONSTRAINTS_CERT_CHAIN_POLICY_CA_FLAG = 0x80000000;

    [NativeTypeName("#define BASIC_CONSTRAINTS_CERT_CHAIN_POLICY_END_ENTITY_FLAG 0x40000000")]
    public const int BASIC_CONSTRAINTS_CERT_CHAIN_POLICY_END_ENTITY_FLAG = 0x40000000;

    [NativeTypeName("#define MICROSOFT_ROOT_CERT_CHAIN_POLICY_ENABLE_TEST_ROOT_FLAG 0x00010000")]
    public const int MICROSOFT_ROOT_CERT_CHAIN_POLICY_ENABLE_TEST_ROOT_FLAG = 0x00010000;

    [NativeTypeName(
        "#define MICROSOFT_ROOT_CERT_CHAIN_POLICY_CHECK_APPLICATION_ROOT_FLAG 0x00020000"
    )]
    public const int MICROSOFT_ROOT_CERT_CHAIN_POLICY_CHECK_APPLICATION_ROOT_FLAG = 0x00020000;

    [NativeTypeName("#define MICROSOFT_ROOT_CERT_CHAIN_POLICY_DISABLE_FLIGHT_ROOT_FLAG 0x00040000")]
    public const int MICROSOFT_ROOT_CERT_CHAIN_POLICY_DISABLE_FLIGHT_ROOT_FLAG = 0x00040000;

    [NativeTypeName("#define CryptStringToBinary CryptStringToBinaryW")]
    public static delegate* <
        ushort*,
        uint,
        uint,
        byte*,
        uint*,
        uint*,
        uint*,
        BOOL> CryptStringToBinary => &CryptStringToBinaryW;

    [NativeTypeName("#define CryptBinaryToString CryptBinaryToStringW")]
    public static delegate* <byte*, uint, uint, ushort*, uint*, BOOL> CryptBinaryToString =>
        &CryptBinaryToStringW;

    [NativeTypeName("#define REPORT_NO_PRIVATE_KEY 0x0001")]
    public const int REPORT_NO_PRIVATE_KEY = 0x0001;

    [NativeTypeName("#define REPORT_NOT_ABLE_TO_EXPORT_PRIVATE_KEY 0x0002")]
    public const int REPORT_NOT_ABLE_TO_EXPORT_PRIVATE_KEY = 0x0002;

    [NativeTypeName("#define EXPORT_PRIVATE_KEYS 0x0004")]
    public const int EXPORT_PRIVATE_KEYS = 0x0004;
}
