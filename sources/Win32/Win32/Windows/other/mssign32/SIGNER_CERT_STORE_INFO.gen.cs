// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

/// <include file='SIGNER_CERT_STORE_INFO.xml' path='doc/member[@name="SIGNER_CERT_STORE_INFO"]/*'/>
public unsafe partial struct SIGNER_CERT_STORE_INFO
{
    /// <include file='SIGNER_CERT_STORE_INFO.xml' path='doc/member[@name="SIGNER_CERT_STORE_INFO.cbSize"]/*'/>

    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SIGNER_CERT_STORE_INFO.xml' path='doc/member[@name="SIGNER_CERT_STORE_INFO.pSigningCert"]/*'/>

    [NativeTypeName("PCCERT_CONTEXT")]
    public CERT_CONTEXT* pSigningCert;

    /// <include file='SIGNER_CERT_STORE_INFO.xml' path='doc/member[@name="SIGNER_CERT_STORE_INFO.dwCertPolicy"]/*'/>

    [NativeTypeName("DWORD")]
    public uint dwCertPolicy;

    /// <include file='SIGNER_CERT_STORE_INFO.xml' path='doc/member[@name="SIGNER_CERT_STORE_INFO.hCertStore"]/*'/>

    public HCERTSTORE hCertStore;
}
