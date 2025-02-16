// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

/// <include file='SIGNER_SIGN_EX2_PARAMS.xml' path='doc/member[@name="SIGNER_SIGN_EX2_PARAMS"]/*'/>
public unsafe partial struct SIGNER_SIGN_EX2_PARAMS
{
    /// <include file='SIGNER_SIGN_EX2_PARAMS.xml' path='doc/member[@name="SIGNER_SIGN_EX2_PARAMS.dwFlags"]/*'/>

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='SIGNER_SIGN_EX2_PARAMS.xml' path='doc/member[@name="SIGNER_SIGN_EX2_PARAMS.pSubjectInfo"]/*'/>

    [NativeTypeName("PSIGNER_SUBJECT_INFO")]
    public SIGNER_SUBJECT_INFO* pSubjectInfo;

    /// <include file='SIGNER_SIGN_EX2_PARAMS.xml' path='doc/member[@name="SIGNER_SIGN_EX2_PARAMS.pSigningCert"]/*'/>

    [NativeTypeName("PSIGNER_CERT")]
    public SIGNER_CERT* pSigningCert;

    /// <include file='SIGNER_SIGN_EX2_PARAMS.xml' path='doc/member[@name="SIGNER_SIGN_EX2_PARAMS.pSignatureInfo"]/*'/>

    [NativeTypeName("PSIGNER_SIGNATURE_INFO")]
    public SIGNER_SIGNATURE_INFO* pSignatureInfo;

    /// <include file='SIGNER_SIGN_EX2_PARAMS.xml' path='doc/member[@name="SIGNER_SIGN_EX2_PARAMS.pProviderInfo"]/*'/>

    [NativeTypeName("PSIGNER_PROVIDER_INFO")]
    public SIGNER_PROVIDER_INFO* pProviderInfo;

    /// <include file='SIGNER_SIGN_EX2_PARAMS.xml' path='doc/member[@name="SIGNER_SIGN_EX2_PARAMS.dwTimestampFlags"]/*'/>

    [NativeTypeName("DWORD")]
    public uint dwTimestampFlags;

    /// <include file='SIGNER_SIGN_EX2_PARAMS.xml' path='doc/member[@name="SIGNER_SIGN_EX2_PARAMS.pszAlgorithmOid"]/*'/>

    [NativeTypeName("PCSTR")]
    public sbyte* pszAlgorithmOid;

    /// <include file='SIGNER_SIGN_EX2_PARAMS.xml' path='doc/member[@name="SIGNER_SIGN_EX2_PARAMS.pwszTimestampURL"]/*'/>

    [NativeTypeName("PCWSTR")]
    public ushort* pwszTimestampURL;

    /// <include file='SIGNER_SIGN_EX2_PARAMS.xml' path='doc/member[@name="SIGNER_SIGN_EX2_PARAMS.pCryptAttrs"]/*'/>

    [NativeTypeName("PCRYPT_ATTRIBUTES")]
    public CRYPT_ATTRIBUTES* pCryptAttrs;

    /// <include file='SIGNER_SIGN_EX2_PARAMS.xml' path='doc/member[@name="SIGNER_SIGN_EX2_PARAMS.pSipData"]/*'/>

    [NativeTypeName("PVOID")]
    public void* pSipData;

    /// <include file='SIGNER_SIGN_EX2_PARAMS.xml' path='doc/member[@name="SIGNER_SIGN_EX2_PARAMS.pSignerContext"]/*'/>

    [NativeTypeName("PSIGNER_CONTEXT *")]
    public SIGNER_CONTEXT** pSignerContext;

    /// <include file='SIGNER_SIGN_EX2_PARAMS.xml' path='doc/member[@name="SIGNER_SIGN_EX2_PARAMS.pCryptoPolicy"]/*'/>

    [NativeTypeName("PVOID")]
    public void* pCryptoPolicy;

    /// <include file='SIGNER_SIGN_EX2_PARAMS.xml' path='doc/member[@name="SIGNER_SIGN_EX2_PARAMS.pReserved"]/*'/>

    [NativeTypeName("PVOID")]
    public void* pReserved;
}
