// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

/// <include file='SIGNER_BLOB_INFO.xml' path='doc/member[@name="SIGNER_BLOB_INFO"]/*'/>
public unsafe partial struct SIGNER_BLOB_INFO
{
    /// <include file='SIGNER_BLOB_INFO.xml' path='doc/member[@name="SIGNER_BLOB_INFO.cbSize"]/*'/>

    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SIGNER_BLOB_INFO.xml' path='doc/member[@name="SIGNER_BLOB_INFO.pGuidSubject"]/*'/>

    public Guid* pGuidSubject;

    /// <include file='SIGNER_BLOB_INFO.xml' path='doc/member[@name="SIGNER_BLOB_INFO.cbBlob"]/*'/>

    [NativeTypeName("DWORD")]
    public uint cbBlob;

    /// <include file='SIGNER_BLOB_INFO.xml' path='doc/member[@name="SIGNER_BLOB_INFO.pbBlob"]/*'/>

    public byte* pbBlob;

    /// <include file='SIGNER_BLOB_INFO.xml' path='doc/member[@name="SIGNER_BLOB_INFO.pwszDisplayName"]/*'/>

    [NativeTypeName("LPCWSTR")]
    public ushort* pwszDisplayName;
}
