// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/in6addr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public partial struct IN6_ADDR
{
    [UnscopedRef]
    public ref _u_e__Union _S6_un => ref u;

    [UnscopedRef]
    public ref _u_e__Union._Byte_e__FixedBuffer s6_addr => ref _S6_un._S6_u8;

    [UnscopedRef]
    public ref _u_e__Union._Byte_e__FixedBuffer s6_bytes => ref u.Byte;

    [UnscopedRef]
    public ref _u_e__Union._Word_e__FixedBuffer s6_words => ref u.Word;

    public partial struct _u_e__Union
    {
        [UnscopedRef]
        public ref _Byte_e__FixedBuffer _S6_u8 => ref Byte;
    }
}
