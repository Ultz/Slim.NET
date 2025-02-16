// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct COLORREF
    : IComparable,
        IComparable<COLORREF>,
        IEquatable<COLORREF>,
        IFormattable
{
    public readonly uint Value;

    public COLORREF(uint value)
    {
        Value = value;
    }

    public static bool operator ==(COLORREF left, COLORREF right) => left.Value == right.Value;

    public static bool operator !=(COLORREF left, COLORREF right) => left.Value != right.Value;

    public static bool operator <(COLORREF left, COLORREF right) => left.Value < right.Value;

    public static bool operator <=(COLORREF left, COLORREF right) => left.Value <= right.Value;

    public static bool operator >(COLORREF left, COLORREF right) => left.Value > right.Value;

    public static bool operator >=(COLORREF left, COLORREF right) => left.Value >= right.Value;

    public static implicit operator COLORREF(byte value) => new COLORREF(value);

    public static explicit operator byte(COLORREF value) => (byte)(value.Value);

    public static explicit operator COLORREF(short value) => new COLORREF(unchecked((uint)(value)));

    public static explicit operator short(COLORREF value) => (short)(value.Value);

    public static explicit operator COLORREF(int value) => new COLORREF(unchecked((uint)(value)));

    public static explicit operator int(COLORREF value) => (int)(value.Value);

    public static explicit operator COLORREF(long value) => new COLORREF(unchecked((uint)(value)));

    public static implicit operator long(COLORREF value) => value.Value;

    public static explicit operator COLORREF(nint value) => new COLORREF(unchecked((uint)(value)));

    public static explicit operator nint(COLORREF value) => (nint)(value.Value);

    public static explicit operator COLORREF(sbyte value) => new COLORREF(unchecked((uint)(value)));

    public static explicit operator sbyte(COLORREF value) => (sbyte)(value.Value);

    public static implicit operator COLORREF(ushort value) => new COLORREF(value);

    public static explicit operator ushort(COLORREF value) => (ushort)(value.Value);

    public static implicit operator COLORREF(uint value) => new COLORREF(value);

    public static implicit operator uint(COLORREF value) => value.Value;

    public static explicit operator COLORREF(ulong value) => new COLORREF(unchecked((uint)(value)));

    public static implicit operator ulong(COLORREF value) => value.Value;

    public static explicit operator COLORREF(nuint value) => new COLORREF(unchecked((uint)(value)));

    public static implicit operator nuint(COLORREF value) => value.Value;

    public int CompareTo(object? obj)
    {
        if (obj is COLORREF other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of COLORREF.");
    }

    public int CompareTo(COLORREF other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is COLORREF other) && Equals(other);

    public bool Equals(COLORREF other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString("X8");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        Value.ToString(format, formatProvider);
}
