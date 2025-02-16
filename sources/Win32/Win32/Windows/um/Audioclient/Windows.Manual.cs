// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.Win32.FACILITY;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    public static HRESULT AUDCLNT_ERR(int n) => MAKE_HRESULT(SEVERITY_ERROR, FACILITY_AUDCLNT, n);

    public static HRESULT AUDCLNT_SUCCESS(int n) =>
        MAKE_SCODE(SEVERITY_SUCCESS, FACILITY_AUDCLNT, n);
}
