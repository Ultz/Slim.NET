// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct PHIDP_PREPARSED_DATA
    : IComparable,
        IComparable<PHIDP_PREPARSED_DATA>,
        IEquatable<PHIDP_PREPARSED_DATA>,
        IFormattable
{
    public readonly void* Value;

    public PHIDP_PREPARSED_DATA(void* value)
    {
        Value = value;
    }

    public static PHIDP_PREPARSED_DATA NULL => new PHIDP_PREPARSED_DATA(null);

    public static bool operator ==(PHIDP_PREPARSED_DATA left, PHIDP_PREPARSED_DATA right) =>
        left.Value == right.Value;

    public static bool operator !=(PHIDP_PREPARSED_DATA left, PHIDP_PREPARSED_DATA right) =>
        left.Value != right.Value;

    public static bool operator <(PHIDP_PREPARSED_DATA left, PHIDP_PREPARSED_DATA right) =>
        left.Value < right.Value;

    public static bool operator <=(PHIDP_PREPARSED_DATA left, PHIDP_PREPARSED_DATA right) =>
        left.Value <= right.Value;

    public static bool operator >(PHIDP_PREPARSED_DATA left, PHIDP_PREPARSED_DATA right) =>
        left.Value > right.Value;

    public static bool operator >=(PHIDP_PREPARSED_DATA left, PHIDP_PREPARSED_DATA right) =>
        left.Value >= right.Value;

    public static explicit operator PHIDP_PREPARSED_DATA(void* value) =>
        new PHIDP_PREPARSED_DATA(value);

    public static implicit operator void*(PHIDP_PREPARSED_DATA value) => value.Value;

    public static explicit operator PHIDP_PREPARSED_DATA(byte value) =>
        new PHIDP_PREPARSED_DATA(unchecked((void*)(value)));

    public static explicit operator byte(PHIDP_PREPARSED_DATA value) => (byte)(value.Value);

    public static explicit operator PHIDP_PREPARSED_DATA(short value) =>
        new PHIDP_PREPARSED_DATA(unchecked((void*)(value)));

    public static explicit operator short(PHIDP_PREPARSED_DATA value) => (short)(value.Value);

    public static explicit operator PHIDP_PREPARSED_DATA(int value) =>
        new PHIDP_PREPARSED_DATA(unchecked((void*)(value)));

    public static explicit operator int(PHIDP_PREPARSED_DATA value) => (int)(value.Value);

    public static explicit operator PHIDP_PREPARSED_DATA(long value) =>
        new PHIDP_PREPARSED_DATA(unchecked((void*)(value)));

    public static explicit operator long(PHIDP_PREPARSED_DATA value) => (long)(value.Value);

    public static explicit operator PHIDP_PREPARSED_DATA(nint value) =>
        new PHIDP_PREPARSED_DATA(unchecked((void*)(value)));

    public static implicit operator nint(PHIDP_PREPARSED_DATA value) => (nint)(value.Value);

    public static explicit operator PHIDP_PREPARSED_DATA(sbyte value) =>
        new PHIDP_PREPARSED_DATA(unchecked((void*)(value)));

    public static explicit operator sbyte(PHIDP_PREPARSED_DATA value) => (sbyte)(value.Value);

    public static explicit operator PHIDP_PREPARSED_DATA(ushort value) =>
        new PHIDP_PREPARSED_DATA(unchecked((void*)(value)));

    public static explicit operator ushort(PHIDP_PREPARSED_DATA value) => (ushort)(value.Value);

    public static explicit operator PHIDP_PREPARSED_DATA(uint value) =>
        new PHIDP_PREPARSED_DATA(unchecked((void*)(value)));

    public static explicit operator uint(PHIDP_PREPARSED_DATA value) => (uint)(value.Value);

    public static explicit operator PHIDP_PREPARSED_DATA(ulong value) =>
        new PHIDP_PREPARSED_DATA(unchecked((void*)(value)));

    public static explicit operator ulong(PHIDP_PREPARSED_DATA value) => (ulong)(value.Value);

    public static explicit operator PHIDP_PREPARSED_DATA(nuint value) =>
        new PHIDP_PREPARSED_DATA(unchecked((void*)(value)));

    public static implicit operator nuint(PHIDP_PREPARSED_DATA value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is PHIDP_PREPARSED_DATA other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of PHIDP_PREPARSED_DATA.");
    }

    public int CompareTo(PHIDP_PREPARSED_DATA other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is PHIDP_PREPARSED_DATA other) && Equals(other);

    public bool Equals(PHIDP_PREPARSED_DATA other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
