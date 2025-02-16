// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

/// <include file='SIGNER_SUBJECT_INFO.xml' path='doc/member[@name="SIGNER_SUBJECT_INFO"]/*'/>
public unsafe partial struct SIGNER_SUBJECT_INFO
{
    /// <include file='SIGNER_SUBJECT_INFO.xml' path='doc/member[@name="SIGNER_SUBJECT_INFO.cbSize"]/*'/>

    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SIGNER_SUBJECT_INFO.xml' path='doc/member[@name="SIGNER_SUBJECT_INFO.pdwIndex"]/*'/>

    [NativeTypeName("DWORD *")]
    public uint* pdwIndex;

    /// <include file='SIGNER_SUBJECT_INFO.xml' path='doc/member[@name="SIGNER_SUBJECT_INFO.dwSubjectChoice"]/*'/>

    [NativeTypeName("DWORD")]
    public uint dwSubjectChoice;

    /// <include file='SIGNER_SUBJECT_INFO.xml' path='doc/member[@name="SIGNER_SUBJECT_INFO.Anonymous"]/*'/>

    [NativeTypeName("__AnonymousRecord_mssign32_L30_C9")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pSignerFileInfo"]/*'/>

    [UnscopedRef]
    public ref SIGNER_FILE_INFO* pSignerFileInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pSignerFileInfo; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pSignerBlobInfo"]/*'/>

    [UnscopedRef]
    public ref SIGNER_BLOB_INFO* pSignerBlobInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pSignerBlobInfo; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pSignerFileInfo"]/*'/>

        [FieldOffset(0)]
        public SIGNER_FILE_INFO* pSignerFileInfo;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pSignerBlobInfo"]/*'/>

        [FieldOffset(0)]
        public SIGNER_BLOB_INFO* pSignerBlobInfo;
    }
}
