// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HCRYPTMSG
    : IComparable,
        IComparable<HCRYPTMSG>,
        IEquatable<HCRYPTMSG>,
        IFormattable
{
    public readonly void* Value;

    public HCRYPTMSG(void* value)
    {
        Value = value;
    }

    public static HCRYPTMSG INVALID_VALUE => new HCRYPTMSG((void*)(-1));
    public static HCRYPTMSG NULL => new HCRYPTMSG(null);

    public static bool operator ==(HCRYPTMSG left, HCRYPTMSG right) => left.Value == right.Value;

    public static bool operator !=(HCRYPTMSG left, HCRYPTMSG right) => left.Value != right.Value;

    public static bool operator <(HCRYPTMSG left, HCRYPTMSG right) => left.Value < right.Value;

    public static bool operator <=(HCRYPTMSG left, HCRYPTMSG right) => left.Value <= right.Value;

    public static bool operator >(HCRYPTMSG left, HCRYPTMSG right) => left.Value > right.Value;

    public static bool operator >=(HCRYPTMSG left, HCRYPTMSG right) => left.Value >= right.Value;

    public static explicit operator HCRYPTMSG(void* value) => new HCRYPTMSG(value);

    public static implicit operator void*(HCRYPTMSG value) => value.Value;

    public static explicit operator HCRYPTMSG(HANDLE value) => new HCRYPTMSG(value);

    public static implicit operator HANDLE(HCRYPTMSG value) => new HANDLE(value.Value);

    public static explicit operator HCRYPTMSG(byte value) =>
        new HCRYPTMSG(unchecked((void*)(value)));

    public static explicit operator byte(HCRYPTMSG value) => (byte)(value.Value);

    public static explicit operator HCRYPTMSG(short value) =>
        new HCRYPTMSG(unchecked((void*)(value)));

    public static explicit operator short(HCRYPTMSG value) => (short)(value.Value);

    public static explicit operator HCRYPTMSG(int value) =>
        new HCRYPTMSG(unchecked((void*)(value)));

    public static explicit operator int(HCRYPTMSG value) => (int)(value.Value);

    public static explicit operator HCRYPTMSG(long value) =>
        new HCRYPTMSG(unchecked((void*)(value)));

    public static explicit operator long(HCRYPTMSG value) => (long)(value.Value);

    public static explicit operator HCRYPTMSG(nint value) =>
        new HCRYPTMSG(unchecked((void*)(value)));

    public static implicit operator nint(HCRYPTMSG value) => (nint)(value.Value);

    public static explicit operator HCRYPTMSG(sbyte value) =>
        new HCRYPTMSG(unchecked((void*)(value)));

    public static explicit operator sbyte(HCRYPTMSG value) => (sbyte)(value.Value);

    public static explicit operator HCRYPTMSG(ushort value) =>
        new HCRYPTMSG(unchecked((void*)(value)));

    public static explicit operator ushort(HCRYPTMSG value) => (ushort)(value.Value);

    public static explicit operator HCRYPTMSG(uint value) =>
        new HCRYPTMSG(unchecked((void*)(value)));

    public static explicit operator uint(HCRYPTMSG value) => (uint)(value.Value);

    public static explicit operator HCRYPTMSG(ulong value) =>
        new HCRYPTMSG(unchecked((void*)(value)));

    public static explicit operator ulong(HCRYPTMSG value) => (ulong)(value.Value);

    public static explicit operator HCRYPTMSG(nuint value) =>
        new HCRYPTMSG(unchecked((void*)(value)));

    public static implicit operator nuint(HCRYPTMSG value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HCRYPTMSG other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HCRYPTMSG.");
    }

    public int CompareTo(HCRYPTMSG other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HCRYPTMSG other) && Equals(other);

    public bool Equals(HCRYPTMSG other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
