// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HKL
    : IComparable,
        IComparable<HKL>,
        IEquatable<HKL>,
        IFormattable
{
    public readonly void* Value;

    public HKL(void* value)
    {
        Value = value;
    }

    public static HKL INVALID_VALUE => new HKL((void*)(-1));
    public static HKL NULL => new HKL(null);

    public static bool operator ==(HKL left, HKL right) => left.Value == right.Value;

    public static bool operator !=(HKL left, HKL right) => left.Value != right.Value;

    public static bool operator <(HKL left, HKL right) => left.Value < right.Value;

    public static bool operator <=(HKL left, HKL right) => left.Value <= right.Value;

    public static bool operator >(HKL left, HKL right) => left.Value > right.Value;

    public static bool operator >=(HKL left, HKL right) => left.Value >= right.Value;

    public static explicit operator HKL(void* value) => new HKL(value);

    public static implicit operator void*(HKL value) => value.Value;

    public static explicit operator HKL(HANDLE value) => new HKL(value);

    public static implicit operator HANDLE(HKL value) => new HANDLE(value.Value);

    public static explicit operator HKL(byte value) => new HKL(unchecked((void*)(value)));

    public static explicit operator byte(HKL value) => (byte)(value.Value);

    public static explicit operator HKL(short value) => new HKL(unchecked((void*)(value)));

    public static explicit operator short(HKL value) => (short)(value.Value);

    public static explicit operator HKL(int value) => new HKL(unchecked((void*)(value)));

    public static explicit operator int(HKL value) => (int)(value.Value);

    public static explicit operator HKL(long value) => new HKL(unchecked((void*)(value)));

    public static explicit operator long(HKL value) => (long)(value.Value);

    public static explicit operator HKL(nint value) => new HKL(unchecked((void*)(value)));

    public static implicit operator nint(HKL value) => (nint)(value.Value);

    public static explicit operator HKL(sbyte value) => new HKL(unchecked((void*)(value)));

    public static explicit operator sbyte(HKL value) => (sbyte)(value.Value);

    public static explicit operator HKL(ushort value) => new HKL(unchecked((void*)(value)));

    public static explicit operator ushort(HKL value) => (ushort)(value.Value);

    public static explicit operator HKL(uint value) => new HKL(unchecked((void*)(value)));

    public static explicit operator uint(HKL value) => (uint)(value.Value);

    public static explicit operator HKL(ulong value) => new HKL(unchecked((void*)(value)));

    public static explicit operator ulong(HKL value) => (ulong)(value.Value);

    public static explicit operator HKL(nuint value) => new HKL(unchecked((void*)(value)));

    public static implicit operator nuint(HKL value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HKL other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HKL.");
    }

    public int CompareTo(HKL other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HKL other) && Equals(other);

    public bool Equals(HKL other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
