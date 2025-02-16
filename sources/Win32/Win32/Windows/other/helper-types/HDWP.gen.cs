// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HDWP
    : IComparable,
        IComparable<HDWP>,
        IEquatable<HDWP>,
        IFormattable
{
    public readonly void* Value;

    public HDWP(void* value)
    {
        Value = value;
    }

    public static HDWP INVALID_VALUE => new HDWP((void*)(-1));
    public static HDWP NULL => new HDWP(null);

    public static bool operator ==(HDWP left, HDWP right) => left.Value == right.Value;

    public static bool operator !=(HDWP left, HDWP right) => left.Value != right.Value;

    public static bool operator <(HDWP left, HDWP right) => left.Value < right.Value;

    public static bool operator <=(HDWP left, HDWP right) => left.Value <= right.Value;

    public static bool operator >(HDWP left, HDWP right) => left.Value > right.Value;

    public static bool operator >=(HDWP left, HDWP right) => left.Value >= right.Value;

    public static explicit operator HDWP(void* value) => new HDWP(value);

    public static implicit operator void*(HDWP value) => value.Value;

    public static explicit operator HDWP(HANDLE value) => new HDWP(value);

    public static implicit operator HANDLE(HDWP value) => new HANDLE(value.Value);

    public static explicit operator HDWP(byte value) => new HDWP(unchecked((void*)(value)));

    public static explicit operator byte(HDWP value) => (byte)(value.Value);

    public static explicit operator HDWP(short value) => new HDWP(unchecked((void*)(value)));

    public static explicit operator short(HDWP value) => (short)(value.Value);

    public static explicit operator HDWP(int value) => new HDWP(unchecked((void*)(value)));

    public static explicit operator int(HDWP value) => (int)(value.Value);

    public static explicit operator HDWP(long value) => new HDWP(unchecked((void*)(value)));

    public static explicit operator long(HDWP value) => (long)(value.Value);

    public static explicit operator HDWP(nint value) => new HDWP(unchecked((void*)(value)));

    public static implicit operator nint(HDWP value) => (nint)(value.Value);

    public static explicit operator HDWP(sbyte value) => new HDWP(unchecked((void*)(value)));

    public static explicit operator sbyte(HDWP value) => (sbyte)(value.Value);

    public static explicit operator HDWP(ushort value) => new HDWP(unchecked((void*)(value)));

    public static explicit operator ushort(HDWP value) => (ushort)(value.Value);

    public static explicit operator HDWP(uint value) => new HDWP(unchecked((void*)(value)));

    public static explicit operator uint(HDWP value) => (uint)(value.Value);

    public static explicit operator HDWP(ulong value) => new HDWP(unchecked((void*)(value)));

    public static explicit operator ulong(HDWP value) => (ulong)(value.Value);

    public static explicit operator HDWP(nuint value) => new HDWP(unchecked((void*)(value)));

    public static implicit operator nuint(HDWP value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HDWP other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HDWP.");
    }

    public int CompareTo(HDWP other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HDWP other) && Equals(other);

    public bool Equals(HDWP other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
