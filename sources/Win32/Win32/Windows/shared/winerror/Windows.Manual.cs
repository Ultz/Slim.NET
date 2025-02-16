// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.Win32.FACILITY;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static partial class Windows
{
    public static bool FAILED(HRESULT hr)
    {
        return hr < 0;
    }

    public static int HRESULT_CODE(HRESULT hr)
    {
        return hr & 0xFFFF;
    }

    public static int HRESULT_FACILITY(HRESULT hr)
    {
        return (hr >> 16) & 0x1FFF;
    }

    public static HRESULT HRESULT_FROM_NT(int x)
    {
        return ((HRESULT)((x) | FACILITY_NT_BIT));
    }

    public static HRESULT HRESULT_FROM_WIN32(int x)
    {
        return (x <= 0)
            ? x
            : ((x & 0x0000FFFF) | (FACILITY_WIN32 << 16) | unchecked((int)0x80000000));
    }

    public static int HRESULT_SEVERITY(HRESULT hr)
    {
        return (hr >> 31) & 0x1;
    }

    public static bool IS_ERROR(HRESULT Status)
    {
        return ((uint)Status >> 31) == SEVERITY_ERROR;
    }

    public static HRESULT MAKE_HRESULT(int sev, int fac, int code)
    {
        return (int)(((uint)sev << 31) | ((uint)fac << 16) | (uint)code);
    }

    public static HRESULT MAKE_SCODE(int sev, int fac, int code)
    {
        return (int)(((uint)sev << 31) | ((uint)fac << 16) | (uint)code);
    }

    public static int SCODE_CODE(HRESULT sc)
    {
        return sc & 0xFFFF;
    }

    public static int SCODE_FACILITY(HRESULT sc)
    {
        return (sc >> 16) & 0x1FFF;
    }

    public static int SCODE_SEVERITY(HRESULT sc)
    {
        return (sc >> 31) & 0x1;
    }

    public static bool SUCCEEDED(HRESULT hr)
    {
        return hr >= 0;
    }
}
