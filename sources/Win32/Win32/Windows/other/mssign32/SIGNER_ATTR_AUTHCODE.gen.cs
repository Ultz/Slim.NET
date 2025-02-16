// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

/// <include file='SIGNER_ATTR_AUTHCODE.xml' path='doc/member[@name="SIGNER_ATTR_AUTHCODE"]/*'/>
public unsafe partial struct SIGNER_ATTR_AUTHCODE
{
    /// <include file='SIGNER_ATTR_AUTHCODE.xml' path='doc/member[@name="SIGNER_ATTR_AUTHCODE.cbSize"]/*'/>

    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SIGNER_ATTR_AUTHCODE.xml' path='doc/member[@name="SIGNER_ATTR_AUTHCODE.fCommercial"]/*'/>

    public BOOL fCommercial;

    /// <include file='SIGNER_ATTR_AUTHCODE.xml' path='doc/member[@name="SIGNER_ATTR_AUTHCODE.fIndividual"]/*'/>

    public BOOL fIndividual;

    /// <include file='SIGNER_ATTR_AUTHCODE.xml' path='doc/member[@name="SIGNER_ATTR_AUTHCODE.pwszName"]/*'/>

    [NativeTypeName("LPCWSTR")]
    public ushort* pwszName;

    /// <include file='SIGNER_ATTR_AUTHCODE.xml' path='doc/member[@name="SIGNER_ATTR_AUTHCODE.pwszInfo"]/*'/>

    [NativeTypeName("LPCWSTR")]
    public ushort* pwszInfo;
}
