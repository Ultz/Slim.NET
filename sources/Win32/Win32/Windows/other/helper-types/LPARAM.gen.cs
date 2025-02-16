// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct LPARAM
    : IComparable,
        IComparable<LPARAM>,
        IEquatable<LPARAM>,
        IFormattable
{
    public readonly nint Value;

    public LPARAM(nint value)
    {
        Value = value;
    }

    public static bool operator ==(LPARAM left, LPARAM right) => left.Value == right.Value;

    public static bool operator !=(LPARAM left, LPARAM right) => left.Value != right.Value;

    public static bool operator <(LPARAM left, LPARAM right) => left.Value < right.Value;

    public static bool operator <=(LPARAM left, LPARAM right) => left.Value <= right.Value;

    public static bool operator >(LPARAM left, LPARAM right) => left.Value > right.Value;

    public static bool operator >=(LPARAM left, LPARAM right) => left.Value >= right.Value;

    public static implicit operator LPARAM(byte value) => new LPARAM(value);

    public static explicit operator byte(LPARAM value) => (byte)(value.Value);

    public static implicit operator LPARAM(short value) => new LPARAM(value);

    public static explicit operator short(LPARAM value) => (short)(value.Value);

    public static implicit operator LPARAM(int value) => new LPARAM(value);

    public static explicit operator int(LPARAM value) => (int)(value.Value);

    public static explicit operator LPARAM(long value) => new LPARAM(unchecked((nint)(value)));

    public static implicit operator long(LPARAM value) => value.Value;

    public static implicit operator LPARAM(nint value) => new LPARAM(value);

    public static implicit operator nint(LPARAM value) => value.Value;

    public static implicit operator LPARAM(sbyte value) => new LPARAM(value);

    public static explicit operator sbyte(LPARAM value) => (sbyte)(value.Value);

    public static implicit operator LPARAM(ushort value) => new LPARAM(value);

    public static explicit operator ushort(LPARAM value) => (ushort)(value.Value);

    public static explicit operator LPARAM(uint value) => new LPARAM(unchecked((nint)(value)));

    public static explicit operator uint(LPARAM value) => (uint)(value.Value);

    public static explicit operator LPARAM(ulong value) => new LPARAM(unchecked((nint)(value)));

    public static explicit operator ulong(LPARAM value) => (ulong)(value.Value);

    public static explicit operator LPARAM(nuint value) => new LPARAM(unchecked((nint)(value)));

    public static explicit operator nuint(LPARAM value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is LPARAM other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of LPARAM.");
    }

    public int CompareTo(LPARAM other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is LPARAM other) && Equals(other);

    public bool Equals(LPARAM other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        Value.ToString(format, formatProvider);
}
