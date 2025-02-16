// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics;
using System.Runtime.CompilerServices;
using static Silk.NET.Win32.AF;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte IN6_ADDR_EQUAL(
        [NativeTypeName("CONST IN6_ADDR *")] IN6_ADDR* x,
        [NativeTypeName("CONST IN6_ADDR *")] IN6_ADDR* y
    )
    {
        long* a;
        long* b;
        a = (long*)x;
        b = (long*)y;
        return (byte)(((a[1] == b[1]) && (a[0] == b[0])) ? 1 : 0);
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte IN6_ADDR_EQUAL(
        [NativeTypeName("CONST IN6_ADDR *")] Ref<IN6_ADDR> x,
        [NativeTypeName("CONST IN6_ADDR *")] Ref<IN6_ADDR> y
    )
    {
        fixed (IN6_ADDR* __dsl_y = y)
        fixed (IN6_ADDR* __dsl_x = x)
        {
            return (byte)IN6_ADDR_EQUAL(__dsl_x, __dsl_y);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte IN6_IS_ADDR_ANYCAST([NativeTypeName("CONST IN6_ADDR *")] IN6_ADDR* a)
    {
        return (byte)(
            (
                (IN6_IS_ADDR_SUBNET_RESERVED_ANYCAST(a) != 0)
                | (IN6_IS_ADDR_SUBNET_ROUTER_ANYCAST(a) != 0)
            )
                ? 1
                : 0
        );
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte IN6_IS_ADDR_ANYCAST([NativeTypeName("CONST IN6_ADDR *")] Ref<IN6_ADDR> a)
    {
        fixed (IN6_ADDR* __dsl_a = a)
        {
            return (byte)IN6_IS_ADDR_ANYCAST(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte IN6_IS_ADDR_EUI64([NativeTypeName("CONST IN6_ADDR *")] IN6_ADDR* a)
    {
        return (byte)((((a->s6_bytes[0] & 0xE0) != 0) && !(IN6_IS_ADDR_MULTICAST(a) != 0)) ? 1 : 0);
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte IN6_IS_ADDR_EUI64([NativeTypeName("CONST IN6_ADDR *")] Ref<IN6_ADDR> a)
    {
        fixed (IN6_ADDR* __dsl_a = a)
        {
            return (byte)IN6_IS_ADDR_EUI64(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte IN6_IS_ADDR_GLOBAL([NativeTypeName("CONST IN6_ADDR *")] IN6_ADDR* a)
    {
        uint High = (a->s6_bytes[0] & 0xF0u);
        return (byte)(((High != 0) && (High != 0xF0)) ? 1 : 0);
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte IN6_IS_ADDR_GLOBAL([NativeTypeName("CONST IN6_ADDR *")] Ref<IN6_ADDR> a)
    {
        fixed (IN6_ADDR* __dsl_a = a)
        {
            return (byte)IN6_IS_ADDR_GLOBAL(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte IN6_IS_ADDR_LINKLOCAL([NativeTypeName("CONST IN6_ADDR *")] IN6_ADDR* a)
    {
        return (byte)(((a->s6_bytes[0] == 0xFE) && ((a->s6_bytes[1] & 0xC0) == 0x80)) ? 1 : 0);
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte IN6_IS_ADDR_LINKLOCAL([NativeTypeName("CONST IN6_ADDR *")] Ref<IN6_ADDR> a)
    {
        fixed (IN6_ADDR* __dsl_a = a)
        {
            return (byte)IN6_IS_ADDR_LINKLOCAL(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte IN6_IS_ADDR_LOOPBACK([NativeTypeName("CONST IN6_ADDR *")] IN6_ADDR* a)
    {
        return (byte)(
            (
                (a->s6_words[0] == 0)
                && (a->s6_words[1] == 0)
                && (a->s6_words[2] == 0)
                && (a->s6_words[3] == 0)
                && (a->s6_words[4] == 0)
                && (a->s6_words[5] == 0)
                && (a->s6_words[6] == 0)
                && (a->s6_words[7] == 0x0100)
            )
                ? 1
                : 0
        );
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte IN6_IS_ADDR_LOOPBACK([NativeTypeName("CONST IN6_ADDR *")] Ref<IN6_ADDR> a)
    {
        fixed (IN6_ADDR* __dsl_a = a)
        {
            return (byte)IN6_IS_ADDR_LOOPBACK(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte IN6_IS_ADDR_MC_GLOBAL([NativeTypeName("CONST IN6_ADDR *")] IN6_ADDR* a)
    {
        return (byte)(((IN6_IS_ADDR_MULTICAST(a) != 0) && ((a->s6_bytes[1] & 0xF) == 0xE)) ? 1 : 0);
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte IN6_IS_ADDR_MC_GLOBAL([NativeTypeName("CONST IN6_ADDR *")] Ref<IN6_ADDR> a)
    {
        fixed (IN6_ADDR* __dsl_a = a)
        {
            return (byte)IN6_IS_ADDR_MC_GLOBAL(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte IN6_IS_ADDR_MC_LINKLOCAL([NativeTypeName("CONST IN6_ADDR *")] IN6_ADDR* a)
    {
        return (byte)(((IN6_IS_ADDR_MULTICAST(a) != 0) && ((a->s6_bytes[1] & 0xF) == 2)) ? 1 : 0);
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte IN6_IS_ADDR_MC_LINKLOCAL(
        [NativeTypeName("CONST IN6_ADDR *")] Ref<IN6_ADDR> a
    )
    {
        fixed (IN6_ADDR* __dsl_a = a)
        {
            return (byte)IN6_IS_ADDR_MC_LINKLOCAL(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte IN6_IS_ADDR_MC_NODELOCAL([NativeTypeName("CONST IN6_ADDR *")] IN6_ADDR* a)
    {
        return (byte)(((IN6_IS_ADDR_MULTICAST(a) != 0) && ((a->s6_bytes[1] & 0xF) == 1)) ? 1 : 0);
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte IN6_IS_ADDR_MC_NODELOCAL(
        [NativeTypeName("CONST IN6_ADDR *")] Ref<IN6_ADDR> a
    )
    {
        fixed (IN6_ADDR* __dsl_a = a)
        {
            return (byte)IN6_IS_ADDR_MC_NODELOCAL(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte IN6_IS_ADDR_MC_ORGLOCAL([NativeTypeName("CONST IN6_ADDR *")] IN6_ADDR* a)
    {
        return (byte)(((IN6_IS_ADDR_MULTICAST(a) != 0) && ((a->s6_bytes[1] & 0xF) == 8)) ? 1 : 0);
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte IN6_IS_ADDR_MC_ORGLOCAL([NativeTypeName("CONST IN6_ADDR *")] Ref<IN6_ADDR> a)
    {
        fixed (IN6_ADDR* __dsl_a = a)
        {
            return (byte)IN6_IS_ADDR_MC_ORGLOCAL(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte IN6_IS_ADDR_MC_SITELOCAL([NativeTypeName("CONST IN6_ADDR *")] IN6_ADDR* a)
    {
        return (byte)(((IN6_IS_ADDR_MULTICAST(a) != 0) && ((a->s6_bytes[1] & 0xF) == 5)) ? 1 : 0);
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte IN6_IS_ADDR_MC_SITELOCAL(
        [NativeTypeName("CONST IN6_ADDR *")] Ref<IN6_ADDR> a
    )
    {
        fixed (IN6_ADDR* __dsl_a = a)
        {
            return (byte)IN6_IS_ADDR_MC_SITELOCAL(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte IN6_IS_ADDR_MULTICAST([NativeTypeName("CONST IN6_ADDR *")] IN6_ADDR* a)
    {
        return (byte)((a->s6_bytes[0] == 0xFF) ? 1 : 0);
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte IN6_IS_ADDR_MULTICAST([NativeTypeName("CONST IN6_ADDR *")] Ref<IN6_ADDR> a)
    {
        fixed (IN6_ADDR* __dsl_a = a)
        {
            return (byte)IN6_IS_ADDR_MULTICAST(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte IN6_IS_ADDR_SITELOCAL([NativeTypeName("CONST IN6_ADDR *")] IN6_ADDR* a)
    {
        return (byte)(((a->s6_bytes[0] == 0xFE) && ((a->s6_bytes[1] & 0xC0) == 0xC0)) ? 1 : 0);
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte IN6_IS_ADDR_SITELOCAL([NativeTypeName("CONST IN6_ADDR *")] Ref<IN6_ADDR> a)
    {
        fixed (IN6_ADDR* __dsl_a = a)
        {
            return (byte)IN6_IS_ADDR_SITELOCAL(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte IN6_IS_ADDR_SUBNET_RESERVED_ANYCAST(
        [NativeTypeName("CONST IN6_ADDR *")] IN6_ADDR* a
    )
    {
        return (byte)(
            (
                (IN6_IS_ADDR_EUI64(a) != 0)
                && (a->s6_words[4] == 0xFFFD)
                && (a->s6_words[5] == 0xFFFF)
                && (a->s6_words[6] == 0xFFFF)
                && ((a->s6_words[7] & 0x80FF) == 0x80FF)
            )
                ? 1
                : 0
        );
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte IN6_IS_ADDR_SUBNET_RESERVED_ANYCAST(
        [NativeTypeName("CONST IN6_ADDR *")] Ref<IN6_ADDR> a
    )
    {
        fixed (IN6_ADDR* __dsl_a = a)
        {
            return (byte)IN6_IS_ADDR_SUBNET_RESERVED_ANYCAST(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte IN6_IS_ADDR_SUBNET_ROUTER_ANYCAST(
        [NativeTypeName("CONST IN6_ADDR *")] IN6_ADDR* a
    )
    {
        return (byte)(
            (
                (IN6_IS_ADDR_EUI64(a) != 0)
                && (a->s6_words[4] == 0)
                && (a->s6_words[5] == 0)
                && (a->s6_words[6] == 0)
                && (a->s6_words[7] == 0)
            )
                ? 1
                : 0
        );
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte IN6_IS_ADDR_SUBNET_ROUTER_ANYCAST(
        [NativeTypeName("CONST IN6_ADDR *")] Ref<IN6_ADDR> a
    )
    {
        fixed (IN6_ADDR* __dsl_a = a)
        {
            return (byte)IN6_IS_ADDR_SUBNET_ROUTER_ANYCAST(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte IN6_IS_ADDR_UNSPECIFIED([NativeTypeName("CONST IN6_ADDR *")] IN6_ADDR* a)
    {
        return (byte)(
            (
                (a->s6_words[0] == 0)
                && (a->s6_words[1] == 0)
                && (a->s6_words[2] == 0)
                && (a->s6_words[3] == 0)
                && (a->s6_words[4] == 0)
                && (a->s6_words[5] == 0)
                && (a->s6_words[6] == 0)
                && (a->s6_words[7] == 0)
            )
                ? 1
                : 0
        );
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte IN6_IS_ADDR_UNSPECIFIED([NativeTypeName("CONST IN6_ADDR *")] Ref<IN6_ADDR> a)
    {
        fixed (IN6_ADDR* __dsl_a = a)
        {
            return (byte)IN6_IS_ADDR_UNSPECIFIED(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte IN6_IS_ADDR_V4COMPAT([NativeTypeName("CONST IN6_ADDR *")] IN6_ADDR* a)
    {
        return (byte)(
            (
                (a->s6_words[0] == 0)
                && (a->s6_words[1] == 0)
                && (a->s6_words[2] == 0)
                && (a->s6_words[3] == 0)
                && (a->s6_words[4] == 0)
                && (a->s6_words[5] == 0)
                && !(
                    (a->s6_words[6] == 0)
                    && (a->s6_addr[14] == 0)
                    && ((a->s6_addr[15] == 0) || (a->s6_addr[15] == 1))
                )
            )
                ? 1
                : 0
        );
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte IN6_IS_ADDR_V4COMPAT([NativeTypeName("CONST IN6_ADDR *")] Ref<IN6_ADDR> a)
    {
        fixed (IN6_ADDR* __dsl_a = a)
        {
            return (byte)IN6_IS_ADDR_V4COMPAT(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte IN6_IS_ADDR_V4MAPPED([NativeTypeName("CONST IN6_ADDR *")] IN6_ADDR* a)
    {
        return (byte)(
            (
                (a->s6_words[0] == 0)
                && (a->s6_words[1] == 0)
                && (a->s6_words[2] == 0)
                && (a->s6_words[3] == 0)
                && (a->s6_words[4] == 0)
                && (a->s6_words[5] == 0xFFFF)
            )
                ? 1
                : 0
        );
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte IN6_IS_ADDR_V4MAPPED([NativeTypeName("CONST IN6_ADDR *")] Ref<IN6_ADDR> a)
    {
        fixed (IN6_ADDR* __dsl_a = a)
        {
            return (byte)IN6_IS_ADDR_V4MAPPED(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte IN6_IS_ADDR_V4TRANSLATED([NativeTypeName("CONST IN6_ADDR *")] IN6_ADDR* a)
    {
        return (byte)(
            (
                (a->s6_words[0] == 0)
                && (a->s6_words[1] == 0)
                && (a->s6_words[2] == 0)
                && (a->s6_words[3] == 0)
                && (a->s6_words[4] == 0xFFFF)
                && (a->s6_words[5] == 0)
            )
                ? 1
                : 0
        );
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte IN6_IS_ADDR_V4TRANSLATED(
        [NativeTypeName("CONST IN6_ADDR *")] Ref<IN6_ADDR> a
    )
    {
        fixed (IN6_ADDR* __dsl_a = a)
        {
            return (byte)IN6_IS_ADDR_V4TRANSLATED(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte IN6ADDR_ISANY([NativeTypeName("CONST SOCKADDR_IN6 *")] SOCKADDR_IN6* a)
    {
        Debug.Assert(a->sin6_family == AF_INET6);
        return IN6_IS_ADDR_UNSPECIFIED(&a->sin6_addr);
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte IN6ADDR_ISANY([NativeTypeName("CONST SOCKADDR_IN6 *")] Ref<SOCKADDR_IN6> a)
    {
        fixed (SOCKADDR_IN6* __dsl_a = a)
        {
            return (byte)IN6ADDR_ISANY(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte IN6ADDR_ISEQUAL(
        [NativeTypeName("CONST SOCKADDR_IN6 *")] SOCKADDR_IN6* a,
        [NativeTypeName("CONST SOCKADDR_IN6 *")] SOCKADDR_IN6* b
    )
    {
        Debug.Assert(a->sin6_family == AF_INET6);
        return (byte)(
            (
                (a->sin6_scope_id == b->sin6_scope_id)
                && (IN6_ADDR_EQUAL(&a->sin6_addr, &b->sin6_addr) != 0)
            )
                ? 1
                : 0
        );
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte IN6ADDR_ISEQUAL(
        [NativeTypeName("CONST SOCKADDR_IN6 *")] Ref<SOCKADDR_IN6> a,
        [NativeTypeName("CONST SOCKADDR_IN6 *")] Ref<SOCKADDR_IN6> b
    )
    {
        fixed (SOCKADDR_IN6* __dsl_b = b)
        fixed (SOCKADDR_IN6* __dsl_a = a)
        {
            return (byte)IN6ADDR_ISEQUAL(__dsl_a, __dsl_b);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte IN6ADDR_ISLOOPBACK([NativeTypeName("CONST SOCKADDR_IN6 *")] SOCKADDR_IN6* a)
    {
        Debug.Assert(a->sin6_family == AF_INET6);
        return IN6_IS_ADDR_LOOPBACK(&a->sin6_addr);
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte IN6ADDR_ISLOOPBACK(
        [NativeTypeName("CONST SOCKADDR_IN6 *")] Ref<SOCKADDR_IN6> a
    )
    {
        fixed (SOCKADDR_IN6* __dsl_a = a)
        {
            return (byte)IN6ADDR_ISLOOPBACK(__dsl_a);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte IN6ADDR_ISUNSPECIFIED(
        [NativeTypeName("CONST SOCKADDR_IN6 *")] SOCKADDR_IN6* a
    )
    {
        Debug.Assert(a->sin6_family == AF_INET6);
        return (byte)(
            ((a->sin6_scope_id == 0) && (IN6_IS_ADDR_UNSPECIFIED(&a->sin6_addr) != 0)) ? 1 : 0
        );
    }

    [return: NativeTypeName("BOOLEAN")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static byte IN6ADDR_ISUNSPECIFIED(
        [NativeTypeName("CONST SOCKADDR_IN6 *")] Ref<SOCKADDR_IN6> a
    )
    {
        fixed (SOCKADDR_IN6* __dsl_a = a)
        {
            return (byte)IN6ADDR_ISUNSPECIFIED(__dsl_a);
        }
    }
}
