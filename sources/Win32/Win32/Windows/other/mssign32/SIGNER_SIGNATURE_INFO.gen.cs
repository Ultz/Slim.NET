// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

/// <include file='SIGNER_SIGNATURE_INFO.xml' path='doc/member[@name="SIGNER_SIGNATURE_INFO"]/*'/>
public unsafe partial struct SIGNER_SIGNATURE_INFO
{
    /// <include file='SIGNER_SIGNATURE_INFO.xml' path='doc/member[@name="SIGNER_SIGNATURE_INFO.cbSize"]/*'/>

    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SIGNER_SIGNATURE_INFO.xml' path='doc/member[@name="SIGNER_SIGNATURE_INFO.algidHash"]/*'/>

    [NativeTypeName("ALG_ID")]
    public uint algidHash;

    /// <include file='SIGNER_SIGNATURE_INFO.xml' path='doc/member[@name="SIGNER_SIGNATURE_INFO.dwAttrChoice"]/*'/>

    [NativeTypeName("DWORD")]
    public uint dwAttrChoice;

    /// <include file='SIGNER_SIGNATURE_INFO.xml' path='doc/member[@name="SIGNER_SIGNATURE_INFO.Anonymous"]/*'/>

    [NativeTypeName("__AnonymousRecord_mssign32_L55_C9")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='SIGNER_SIGNATURE_INFO.xml' path='doc/member[@name="SIGNER_SIGNATURE_INFO.psAuthenticated"]/*'/>

    [NativeTypeName("PCRYPT_ATTRIBUTES")]
    public CRYPT_ATTRIBUTES* psAuthenticated;

    /// <include file='SIGNER_SIGNATURE_INFO.xml' path='doc/member[@name="SIGNER_SIGNATURE_INFO.psUnauthenticated"]/*'/>

    [NativeTypeName("PCRYPT_ATTRIBUTES")]
    public CRYPT_ATTRIBUTES* psUnauthenticated;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pAttrAuthcode"]/*'/>

    [UnscopedRef]
    public ref SIGNER_ATTR_AUTHCODE* pAttrAuthcode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pAttrAuthcode; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pAttrAuthcode"]/*'/>

        [FieldOffset(0)]
        public SIGNER_ATTR_AUTHCODE* pAttrAuthcode;
    }
}
