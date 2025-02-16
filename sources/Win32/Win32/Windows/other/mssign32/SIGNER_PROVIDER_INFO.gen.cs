// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

/// <include file='SIGNER_PROVIDER_INFO.xml' path='doc/member[@name="SIGNER_PROVIDER_INFO"]/*'/>
public unsafe partial struct SIGNER_PROVIDER_INFO
{
    /// <include file='SIGNER_PROVIDER_INFO.xml' path='doc/member[@name="SIGNER_PROVIDER_INFO.cbSize"]/*'/>

    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SIGNER_PROVIDER_INFO.xml' path='doc/member[@name="SIGNER_PROVIDER_INFO.pwszProviderName"]/*'/>

    [NativeTypeName("LPCWSTR")]
    public ushort* pwszProviderName;

    /// <include file='SIGNER_PROVIDER_INFO.xml' path='doc/member[@name="SIGNER_PROVIDER_INFO.dwProviderType"]/*'/>

    [NativeTypeName("DWORD")]
    public uint dwProviderType;

    /// <include file='SIGNER_PROVIDER_INFO.xml' path='doc/member[@name="SIGNER_PROVIDER_INFO.dwKeySpec"]/*'/>

    [NativeTypeName("DWORD")]
    public uint dwKeySpec;

    /// <include file='SIGNER_PROVIDER_INFO.xml' path='doc/member[@name="SIGNER_PROVIDER_INFO.dwPvkChoice"]/*'/>

    [NativeTypeName("DWORD")]
    public uint dwPvkChoice;

    /// <include file='SIGNER_PROVIDER_INFO.xml' path='doc/member[@name="SIGNER_PROVIDER_INFO.Anonymous"]/*'/>

    [NativeTypeName("__AnonymousRecord_mssign32_L74_C9")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pwszPvkFileName"]/*'/>

    [UnscopedRef]
    public ref ushort* pwszPvkFileName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pwszPvkFileName; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pwszKeyContainer"]/*'/>

    [UnscopedRef]
    public ref ushort* pwszKeyContainer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pwszKeyContainer; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pwszPvkFileName"]/*'/>

        [FieldOffset(0)]
        [NativeTypeName("LPWSTR")]
        public ushort* pwszPvkFileName;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pwszKeyContainer"]/*'/>

        [FieldOffset(0)]
        [NativeTypeName("LPWSTR")]
        public ushort* pwszKeyContainer;
    }
}
