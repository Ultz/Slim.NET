// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    [NativeTypeName("#define PVK_TYPE_FILE_NAME 0x01")]
    public const int PVK_TYPE_FILE_NAME = 0x01;

    [NativeTypeName("#define PVK_TYPE_KEYCONTAINER 0x02")]
    public const int PVK_TYPE_KEYCONTAINER = 0x02;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SignerSignEx2"]/*'/>

    [DllImport("mssign32", ExactSpelling = true)]
    public static extern HRESULT SignerSignEx2(
        [NativeTypeName("DWORD")] uint dwFlags,
        SIGNER_SUBJECT_INFO* pSubjectInfo,
        SIGNER_CERT* pSignerCert,
        SIGNER_SIGNATURE_INFO* pSignatureInfo,
        SIGNER_PROVIDER_INFO* pProviderInfo,
        [NativeTypeName("DWORD")] uint dwTimestampFlags,
        [NativeTypeName("PCSTR")] sbyte* pszTimestampAlgorithmOid,
        [NativeTypeName("PCWSTR")] ushort* pwszHttpTimeStamp,
        [NativeTypeName("PCRYPT_ATTRIBUTES")] CRYPT_ATTRIBUTES* psRequest,
        [NativeTypeName("PVOID")] void* pSipData,
        SIGNER_CONTEXT** ppSignerContext,
        [NativeTypeName("PCERT_STRONG_SIGN_PARA")] CERT_STRONG_SIGN_PARA* pCryptoPolicy,
        [NativeTypeName("PVOID")] void* pReserved
    );

    [Transformed]
    [NativeFunction("mssign32", EntryPoint = "SignerSignEx2")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT SignerSignEx2(
        [NativeTypeName("DWORD")] uint dwFlags,
        Ref<SIGNER_SUBJECT_INFO> pSubjectInfo,
        Ref<SIGNER_CERT> pSignerCert,
        Ref<SIGNER_SIGNATURE_INFO> pSignatureInfo,
        Ref<SIGNER_PROVIDER_INFO> pProviderInfo,
        [NativeTypeName("DWORD")] uint dwTimestampFlags,
        [NativeTypeName("PCSTR")] Ref<sbyte> pszTimestampAlgorithmOid,
        [NativeTypeName("PCWSTR")] Ref<ushort> pwszHttpTimeStamp,
        [NativeTypeName("PCRYPT_ATTRIBUTES")] Ref<CRYPT_ATTRIBUTES> psRequest,
        [NativeTypeName("PVOID")] Ref pSipData,
        Ref2D<SIGNER_CONTEXT> ppSignerContext,
        [NativeTypeName("PCERT_STRONG_SIGN_PARA")] Ref<CERT_STRONG_SIGN_PARA> pCryptoPolicy,
        [NativeTypeName("PVOID")] Ref pReserved
    )
    {
        fixed (void* __dsl_pReserved = pReserved)
        fixed (CERT_STRONG_SIGN_PARA* __dsl_pCryptoPolicy = pCryptoPolicy)
        fixed (SIGNER_CONTEXT** __dsl_ppSignerContext = ppSignerContext)
        fixed (void* __dsl_pSipData = pSipData)
        fixed (CRYPT_ATTRIBUTES* __dsl_psRequest = psRequest)
        fixed (ushort* __dsl_pwszHttpTimeStamp = pwszHttpTimeStamp)
        fixed (sbyte* __dsl_pszTimestampAlgorithmOid = pszTimestampAlgorithmOid)
        fixed (SIGNER_PROVIDER_INFO* __dsl_pProviderInfo = pProviderInfo)
        fixed (SIGNER_SIGNATURE_INFO* __dsl_pSignatureInfo = pSignatureInfo)
        fixed (SIGNER_CERT* __dsl_pSignerCert = pSignerCert)
        fixed (SIGNER_SUBJECT_INFO* __dsl_pSubjectInfo = pSubjectInfo)
        {
            return (HRESULT)SignerSignEx2(
                dwFlags,
                __dsl_pSubjectInfo,
                __dsl_pSignerCert,
                __dsl_pSignatureInfo,
                __dsl_pProviderInfo,
                dwTimestampFlags,
                __dsl_pszTimestampAlgorithmOid,
                __dsl_pwszHttpTimeStamp,
                __dsl_psRequest,
                __dsl_pSipData,
                __dsl_ppSignerContext,
                __dsl_pCryptoPolicy,
                __dsl_pReserved
            );
        }
    }
}
