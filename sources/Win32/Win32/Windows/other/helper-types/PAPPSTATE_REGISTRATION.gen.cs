// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct PAPPSTATE_REGISTRATION
    : IComparable,
        IComparable<PAPPSTATE_REGISTRATION>,
        IEquatable<PAPPSTATE_REGISTRATION>,
        IFormattable
{
    public readonly void* Value;

    public PAPPSTATE_REGISTRATION(void* value)
    {
        Value = value;
    }

    public static PAPPSTATE_REGISTRATION NULL => new PAPPSTATE_REGISTRATION(null);

    public static bool operator ==(PAPPSTATE_REGISTRATION left, PAPPSTATE_REGISTRATION right) =>
        left.Value == right.Value;

    public static bool operator !=(PAPPSTATE_REGISTRATION left, PAPPSTATE_REGISTRATION right) =>
        left.Value != right.Value;

    public static bool operator <(PAPPSTATE_REGISTRATION left, PAPPSTATE_REGISTRATION right) =>
        left.Value < right.Value;

    public static bool operator <=(PAPPSTATE_REGISTRATION left, PAPPSTATE_REGISTRATION right) =>
        left.Value <= right.Value;

    public static bool operator >(PAPPSTATE_REGISTRATION left, PAPPSTATE_REGISTRATION right) =>
        left.Value > right.Value;

    public static bool operator >=(PAPPSTATE_REGISTRATION left, PAPPSTATE_REGISTRATION right) =>
        left.Value >= right.Value;

    public static explicit operator PAPPSTATE_REGISTRATION(void* value) =>
        new PAPPSTATE_REGISTRATION(value);

    public static implicit operator void*(PAPPSTATE_REGISTRATION value) => value.Value;

    public static explicit operator PAPPSTATE_REGISTRATION(byte value) =>
        new PAPPSTATE_REGISTRATION(unchecked((void*)(value)));

    public static explicit operator byte(PAPPSTATE_REGISTRATION value) => (byte)(value.Value);

    public static explicit operator PAPPSTATE_REGISTRATION(short value) =>
        new PAPPSTATE_REGISTRATION(unchecked((void*)(value)));

    public static explicit operator short(PAPPSTATE_REGISTRATION value) => (short)(value.Value);

    public static explicit operator PAPPSTATE_REGISTRATION(int value) =>
        new PAPPSTATE_REGISTRATION(unchecked((void*)(value)));

    public static explicit operator int(PAPPSTATE_REGISTRATION value) => (int)(value.Value);

    public static explicit operator PAPPSTATE_REGISTRATION(long value) =>
        new PAPPSTATE_REGISTRATION(unchecked((void*)(value)));

    public static explicit operator long(PAPPSTATE_REGISTRATION value) => (long)(value.Value);

    public static explicit operator PAPPSTATE_REGISTRATION(nint value) =>
        new PAPPSTATE_REGISTRATION(unchecked((void*)(value)));

    public static implicit operator nint(PAPPSTATE_REGISTRATION value) => (nint)(value.Value);

    public static explicit operator PAPPSTATE_REGISTRATION(sbyte value) =>
        new PAPPSTATE_REGISTRATION(unchecked((void*)(value)));

    public static explicit operator sbyte(PAPPSTATE_REGISTRATION value) => (sbyte)(value.Value);

    public static explicit operator PAPPSTATE_REGISTRATION(ushort value) =>
        new PAPPSTATE_REGISTRATION(unchecked((void*)(value)));

    public static explicit operator ushort(PAPPSTATE_REGISTRATION value) => (ushort)(value.Value);

    public static explicit operator PAPPSTATE_REGISTRATION(uint value) =>
        new PAPPSTATE_REGISTRATION(unchecked((void*)(value)));

    public static explicit operator uint(PAPPSTATE_REGISTRATION value) => (uint)(value.Value);

    public static explicit operator PAPPSTATE_REGISTRATION(ulong value) =>
        new PAPPSTATE_REGISTRATION(unchecked((void*)(value)));

    public static explicit operator ulong(PAPPSTATE_REGISTRATION value) => (ulong)(value.Value);

    public static explicit operator PAPPSTATE_REGISTRATION(nuint value) =>
        new PAPPSTATE_REGISTRATION(unchecked((void*)(value)));

    public static implicit operator nuint(PAPPSTATE_REGISTRATION value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is PAPPSTATE_REGISTRATION other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of PAPPSTATE_REGISTRATION.");
    }

    public int CompareTo(PAPPSTATE_REGISTRATION other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is PAPPSTATE_REGISTRATION other) && Equals(other);

    public bool Equals(PAPPSTATE_REGISTRATION other) =>
        ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
