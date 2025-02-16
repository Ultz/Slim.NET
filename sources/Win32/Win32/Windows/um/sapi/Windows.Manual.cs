// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    [NativeTypeName("#define SPRULETRANS_TEXTBUFFER (SPSTATEHANDLE)(-1)")]
    public static SPSTATEHANDLE SPRULETRANS_TEXTBUFFER => (SPSTATEHANDLE)(-1);

    [NativeTypeName("#define SPRULETRANS_WILDCARD (SPSTATEHANDLE)(-2)")]
    public static SPSTATEHANDLE SPRULETRANS_WILDCARD => (SPSTATEHANDLE)(-2);

    [NativeTypeName("#define SPRULETRANS_DICTATION (SPSTATEHANDLE)(-3)")]
    public static SPSTATEHANDLE SPRULETRANS_DICTATION => (SPSTATEHANDLE)(-3);

    public static ulong SPFEI(int SPEI_ord) => ((1UL << SPEI_ord) | SPFEI_FLAGCHECK);
}
