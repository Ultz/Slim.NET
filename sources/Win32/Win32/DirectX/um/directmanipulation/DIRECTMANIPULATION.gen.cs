// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DIRECTMANIPULATION
{
    [NativeTypeName("#define DIRECTMANIPULATION_KEYBOARDFOCUS ( 0xfffffffe )")]
    public const uint DIRECTMANIPULATION_KEYBOARDFOCUS = (0xfffffffe);

    [NativeTypeName("#define DIRECTMANIPULATION_MOUSEFOCUS ( 0xfffffffd )")]
    public const uint DIRECTMANIPULATION_MOUSEFOCUS = (0xfffffffd);

    [NativeTypeName("#define DIRECTMANIPULATION_MINIMUM_ZOOM ( ( float  )0.1 )")]
    public const float DIRECTMANIPULATION_MINIMUM_ZOOM = ((float)(0.1));
}
