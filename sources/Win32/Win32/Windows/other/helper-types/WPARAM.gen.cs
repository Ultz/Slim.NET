// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct WPARAM
    : IComparable,
        IComparable<WPARAM>,
        IEquatable<WPARAM>,
        IFormattable
{
    public readonly nuint Value;

    public WPARAM(nuint value)
    {
        Value = value;
    }

    public static bool operator ==(WPARAM left, WPARAM right) => left.Value == right.Value;

    public static bool operator !=(WPARAM left, WPARAM right) => left.Value != right.Value;

    public static bool operator <(WPARAM left, WPARAM right) => left.Value < right.Value;

    public static bool operator <=(WPARAM left, WPARAM right) => left.Value <= right.Value;

    public static bool operator >(WPARAM left, WPARAM right) => left.Value > right.Value;

    public static bool operator >=(WPARAM left, WPARAM right) => left.Value >= right.Value;

    public static implicit operator WPARAM(byte value) => new WPARAM(value);

    public static explicit operator byte(WPARAM value) => (byte)(value.Value);

    public static explicit operator WPARAM(short value) => new WPARAM(unchecked((nuint)(value)));

    public static explicit operator short(WPARAM value) => (short)(value.Value);

    public static explicit operator WPARAM(int value) => new WPARAM(unchecked((nuint)(value)));

    public static explicit operator int(WPARAM value) => (int)(value.Value);

    public static explicit operator WPARAM(long value) => new WPARAM(unchecked((nuint)(value)));

    public static explicit operator long(WPARAM value) => (long)(value.Value);

    public static explicit operator WPARAM(nint value) => new WPARAM(unchecked((nuint)(value)));

    public static explicit operator nint(WPARAM value) => (nint)(value.Value);

    public static explicit operator WPARAM(sbyte value) => new WPARAM(unchecked((nuint)(value)));

    public static explicit operator sbyte(WPARAM value) => (sbyte)(value.Value);

    public static implicit operator WPARAM(ushort value) => new WPARAM(value);

    public static explicit operator ushort(WPARAM value) => (ushort)(value.Value);

    public static implicit operator WPARAM(uint value) => new WPARAM(value);

    public static explicit operator uint(WPARAM value) => (uint)(value.Value);

    public static explicit operator WPARAM(ulong value) => new WPARAM(unchecked((nuint)(value)));

    public static implicit operator ulong(WPARAM value) => value.Value;

    public static implicit operator WPARAM(nuint value) => new WPARAM(value);

    public static implicit operator nuint(WPARAM value) => value.Value;

    public int CompareTo(object? obj)
    {
        if (obj is WPARAM other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of WPARAM.");
    }

    public int CompareTo(WPARAM other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is WPARAM other) && Equals(other);

    public bool Equals(WPARAM other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        Value.ToString(format, formatProvider);
}
