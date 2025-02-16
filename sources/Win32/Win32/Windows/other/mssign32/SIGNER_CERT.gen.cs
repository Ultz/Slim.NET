// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

/// <include file='SIGNER_CERT.xml' path='doc/member[@name="SIGNER_CERT"]/*'/>
public unsafe partial struct SIGNER_CERT
{
    /// <include file='SIGNER_CERT.xml' path='doc/member[@name="SIGNER_CERT.cbSize"]/*'/>

    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SIGNER_CERT.xml' path='doc/member[@name="SIGNER_CERT.dwCertChoice"]/*'/>

    [NativeTypeName("DWORD")]
    public uint dwCertChoice;

    /// <include file='SIGNER_CERT.xml' path='doc/member[@name="SIGNER_CERT.Anonymous"]/*'/>

    [NativeTypeName("__AnonymousRecord_mssign32_L111_C9")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='SIGNER_CERT.xml' path='doc/member[@name="SIGNER_CERT.hwnd"]/*'/>

    public HWND hwnd;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pwszSpcFile"]/*'/>

    [UnscopedRef]
    public ref ushort* pwszSpcFile
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pwszSpcFile; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pCertStoreInfo"]/*'/>

    [UnscopedRef]
    public ref SIGNER_CERT_STORE_INFO* pCertStoreInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pCertStoreInfo; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pSpcChainInfo"]/*'/>

    [UnscopedRef]
    public ref SIGNER_SPC_CHAIN_INFO* pSpcChainInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pSpcChainInfo; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pwszSpcFile"]/*'/>

        [FieldOffset(0)]
        [NativeTypeName("LPCWSTR")]
        public ushort* pwszSpcFile;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pCertStoreInfo"]/*'/>

        [FieldOffset(0)]
        public SIGNER_CERT_STORE_INFO* pCertStoreInfo;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pSpcChainInfo"]/*'/>

        [FieldOffset(0)]
        public SIGNER_SPC_CHAIN_INFO* pSpcChainInfo;
    }
}
