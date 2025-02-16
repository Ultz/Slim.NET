// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static partial class SIGNER
{
    [NativeTypeName("#define SIGNER_SUBJECT_FILE 0x01")]
    public const int SIGNER_SUBJECT_FILE = 0x01;

    [NativeTypeName("#define SIGNER_SUBJECT_BLOB 0x02")]
    public const int SIGNER_SUBJECT_BLOB = 0x02;

    [NativeTypeName("#define SIGNER_NO_ATTR 0x00")]
    public const int SIGNER_NO_ATTR = 0x00;

    [NativeTypeName("#define SIGNER_AUTHCODE_ATTR 0x01")]
    public const int SIGNER_AUTHCODE_ATTR = 0x01;

    [NativeTypeName("#define SIGNER_CERT_POLICY_STORE 0x01")]
    public const int SIGNER_CERT_POLICY_STORE = 0x01;

    [NativeTypeName("#define SIGNER_CERT_POLICY_CHAIN 0x02")]
    public const int SIGNER_CERT_POLICY_CHAIN = 0x02;

    [NativeTypeName("#define SIGNER_CERT_POLICY_SPC 0x04")]
    public const int SIGNER_CERT_POLICY_SPC = 0x04;

    [NativeTypeName("#define SIGNER_CERT_POLICY_CHAIN_NO_ROOT 0x08")]
    public const int SIGNER_CERT_POLICY_CHAIN_NO_ROOT = 0x08;

    [NativeTypeName("#define SIGNER_CERT_SPC_FILE 0x01")]
    public const int SIGNER_CERT_SPC_FILE = 0x01;

    [NativeTypeName("#define SIGNER_CERT_STORE 0x02")]
    public const int SIGNER_CERT_STORE = 0x02;

    [NativeTypeName("#define SIGNER_CERT_SPC_CHAIN 0x03")]
    public const int SIGNER_CERT_SPC_CHAIN = 0x03;
}
