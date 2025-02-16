// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HPEN
    : IComparable,
        IComparable<HPEN>,
        IEquatable<HPEN>,
        IFormattable
{
    public readonly void* Value;

    public HPEN(void* value)
    {
        Value = value;
    }

    public static HPEN INVALID_VALUE => new HPEN((void*)(-1));
    public static HPEN NULL => new HPEN(null);

    public static bool operator ==(HPEN left, HPEN right) => left.Value == right.Value;

    public static bool operator !=(HPEN left, HPEN right) => left.Value != right.Value;

    public static bool operator <(HPEN left, HPEN right) => left.Value < right.Value;

    public static bool operator <=(HPEN left, HPEN right) => left.Value <= right.Value;

    public static bool operator >(HPEN left, HPEN right) => left.Value > right.Value;

    public static bool operator >=(HPEN left, HPEN right) => left.Value >= right.Value;

    public static explicit operator HPEN(void* value) => new HPEN(value);

    public static implicit operator void*(HPEN value) => value.Value;

    public static explicit operator HPEN(HANDLE value) => new HPEN(value);

    public static implicit operator HANDLE(HPEN value) => new HANDLE(value.Value);

    public static explicit operator HPEN(byte value) => new HPEN(unchecked((void*)(value)));

    public static explicit operator byte(HPEN value) => (byte)(value.Value);

    public static explicit operator HPEN(short value) => new HPEN(unchecked((void*)(value)));

    public static explicit operator short(HPEN value) => (short)(value.Value);

    public static explicit operator HPEN(int value) => new HPEN(unchecked((void*)(value)));

    public static explicit operator int(HPEN value) => (int)(value.Value);

    public static explicit operator HPEN(long value) => new HPEN(unchecked((void*)(value)));

    public static explicit operator long(HPEN value) => (long)(value.Value);

    public static explicit operator HPEN(nint value) => new HPEN(unchecked((void*)(value)));

    public static implicit operator nint(HPEN value) => (nint)(value.Value);

    public static explicit operator HPEN(sbyte value) => new HPEN(unchecked((void*)(value)));

    public static explicit operator sbyte(HPEN value) => (sbyte)(value.Value);

    public static explicit operator HPEN(ushort value) => new HPEN(unchecked((void*)(value)));

    public static explicit operator ushort(HPEN value) => (ushort)(value.Value);

    public static explicit operator HPEN(uint value) => new HPEN(unchecked((void*)(value)));

    public static explicit operator uint(HPEN value) => (uint)(value.Value);

    public static explicit operator HPEN(ulong value) => new HPEN(unchecked((void*)(value)));

    public static explicit operator ulong(HPEN value) => (ulong)(value.Value);

    public static explicit operator HPEN(nuint value) => new HPEN(unchecked((void*)(value)));

    public static implicit operator nuint(HPEN value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HPEN other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HPEN.");
    }

    public int CompareTo(HPEN other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HPEN other) && Equals(other);

    public bool Equals(HPEN other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
