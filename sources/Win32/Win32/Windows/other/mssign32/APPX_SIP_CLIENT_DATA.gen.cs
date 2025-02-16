// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

/// <include file='APPX_SIP_CLIENT_DATA.xml' path='doc/member[@name="APPX_SIP_CLIENT_DATA"]/*'/>
public unsafe partial struct APPX_SIP_CLIENT_DATA
{
    /// <include file='APPX_SIP_CLIENT_DATA.xml' path='doc/member[@name="APPX_SIP_CLIENT_DATA.pSignerParams"]/*'/>

    [NativeTypeName("PSIGNER_SIGN_EX2_PARAMS")]
    public SIGNER_SIGN_EX2_PARAMS* pSignerParams;

    /// <include file='APPX_SIP_CLIENT_DATA.xml' path='doc/member[@name="APPX_SIP_CLIENT_DATA.pAppxSipState"]/*'/>

    public IUnknown pAppxSipState;
}
