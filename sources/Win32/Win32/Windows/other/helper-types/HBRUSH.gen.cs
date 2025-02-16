// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HBRUSH
    : IComparable,
        IComparable<HBRUSH>,
        IEquatable<HBRUSH>,
        IFormattable
{
    public readonly void* Value;

    public HBRUSH(void* value)
    {
        Value = value;
    }

    public static HBRUSH INVALID_VALUE => new HBRUSH((void*)(-1));
    public static HBRUSH NULL => new HBRUSH(null);

    public static bool operator ==(HBRUSH left, HBRUSH right) => left.Value == right.Value;

    public static bool operator !=(HBRUSH left, HBRUSH right) => left.Value != right.Value;

    public static bool operator <(HBRUSH left, HBRUSH right) => left.Value < right.Value;

    public static bool operator <=(HBRUSH left, HBRUSH right) => left.Value <= right.Value;

    public static bool operator >(HBRUSH left, HBRUSH right) => left.Value > right.Value;

    public static bool operator >=(HBRUSH left, HBRUSH right) => left.Value >= right.Value;

    public static explicit operator HBRUSH(void* value) => new HBRUSH(value);

    public static implicit operator void*(HBRUSH value) => value.Value;

    public static explicit operator HBRUSH(HANDLE value) => new HBRUSH(value);

    public static implicit operator HANDLE(HBRUSH value) => new HANDLE(value.Value);

    public static explicit operator HBRUSH(byte value) => new HBRUSH(unchecked((void*)(value)));

    public static explicit operator byte(HBRUSH value) => (byte)(value.Value);

    public static explicit operator HBRUSH(short value) => new HBRUSH(unchecked((void*)(value)));

    public static explicit operator short(HBRUSH value) => (short)(value.Value);

    public static explicit operator HBRUSH(int value) => new HBRUSH(unchecked((void*)(value)));

    public static explicit operator int(HBRUSH value) => (int)(value.Value);

    public static explicit operator HBRUSH(long value) => new HBRUSH(unchecked((void*)(value)));

    public static explicit operator long(HBRUSH value) => (long)(value.Value);

    public static explicit operator HBRUSH(nint value) => new HBRUSH(unchecked((void*)(value)));

    public static implicit operator nint(HBRUSH value) => (nint)(value.Value);

    public static explicit operator HBRUSH(sbyte value) => new HBRUSH(unchecked((void*)(value)));

    public static explicit operator sbyte(HBRUSH value) => (sbyte)(value.Value);

    public static explicit operator HBRUSH(ushort value) => new HBRUSH(unchecked((void*)(value)));

    public static explicit operator ushort(HBRUSH value) => (ushort)(value.Value);

    public static explicit operator HBRUSH(uint value) => new HBRUSH(unchecked((void*)(value)));

    public static explicit operator uint(HBRUSH value) => (uint)(value.Value);

    public static explicit operator HBRUSH(ulong value) => new HBRUSH(unchecked((void*)(value)));

    public static explicit operator ulong(HBRUSH value) => (ulong)(value.Value);

    public static explicit operator HBRUSH(nuint value) => new HBRUSH(unchecked((void*)(value)));

    public static implicit operator nuint(HBRUSH value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HBRUSH other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HBRUSH.");
    }

    public int CompareTo(HBRUSH other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HBRUSH other) && Equals(other);

    public bool Equals(HBRUSH other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
