// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HSYNTHETICPOINTERDEVICE
    : IComparable,
        IComparable<HSYNTHETICPOINTERDEVICE>,
        IEquatable<HSYNTHETICPOINTERDEVICE>,
        IFormattable
{
    public readonly void* Value;

    public HSYNTHETICPOINTERDEVICE(void* value)
    {
        Value = value;
    }

    public static HSYNTHETICPOINTERDEVICE INVALID_VALUE => new HSYNTHETICPOINTERDEVICE((void*)(-1));
    public static HSYNTHETICPOINTERDEVICE NULL => new HSYNTHETICPOINTERDEVICE(null);

    public static bool operator ==(HSYNTHETICPOINTERDEVICE left, HSYNTHETICPOINTERDEVICE right) =>
        left.Value == right.Value;

    public static bool operator !=(HSYNTHETICPOINTERDEVICE left, HSYNTHETICPOINTERDEVICE right) =>
        left.Value != right.Value;

    public static bool operator <(HSYNTHETICPOINTERDEVICE left, HSYNTHETICPOINTERDEVICE right) =>
        left.Value < right.Value;

    public static bool operator <=(HSYNTHETICPOINTERDEVICE left, HSYNTHETICPOINTERDEVICE right) =>
        left.Value <= right.Value;

    public static bool operator >(HSYNTHETICPOINTERDEVICE left, HSYNTHETICPOINTERDEVICE right) =>
        left.Value > right.Value;

    public static bool operator >=(HSYNTHETICPOINTERDEVICE left, HSYNTHETICPOINTERDEVICE right) =>
        left.Value >= right.Value;

    public static explicit operator HSYNTHETICPOINTERDEVICE(void* value) =>
        new HSYNTHETICPOINTERDEVICE(value);

    public static implicit operator void*(HSYNTHETICPOINTERDEVICE value) => value.Value;

    public static explicit operator HSYNTHETICPOINTERDEVICE(HANDLE value) =>
        new HSYNTHETICPOINTERDEVICE(value);

    public static implicit operator HANDLE(HSYNTHETICPOINTERDEVICE value) =>
        new HANDLE(value.Value);

    public static explicit operator HSYNTHETICPOINTERDEVICE(byte value) =>
        new HSYNTHETICPOINTERDEVICE(unchecked((void*)(value)));

    public static explicit operator byte(HSYNTHETICPOINTERDEVICE value) => (byte)(value.Value);

    public static explicit operator HSYNTHETICPOINTERDEVICE(short value) =>
        new HSYNTHETICPOINTERDEVICE(unchecked((void*)(value)));

    public static explicit operator short(HSYNTHETICPOINTERDEVICE value) => (short)(value.Value);

    public static explicit operator HSYNTHETICPOINTERDEVICE(int value) =>
        new HSYNTHETICPOINTERDEVICE(unchecked((void*)(value)));

    public static explicit operator int(HSYNTHETICPOINTERDEVICE value) => (int)(value.Value);

    public static explicit operator HSYNTHETICPOINTERDEVICE(long value) =>
        new HSYNTHETICPOINTERDEVICE(unchecked((void*)(value)));

    public static explicit operator long(HSYNTHETICPOINTERDEVICE value) => (long)(value.Value);

    public static explicit operator HSYNTHETICPOINTERDEVICE(nint value) =>
        new HSYNTHETICPOINTERDEVICE(unchecked((void*)(value)));

    public static implicit operator nint(HSYNTHETICPOINTERDEVICE value) => (nint)(value.Value);

    public static explicit operator HSYNTHETICPOINTERDEVICE(sbyte value) =>
        new HSYNTHETICPOINTERDEVICE(unchecked((void*)(value)));

    public static explicit operator sbyte(HSYNTHETICPOINTERDEVICE value) => (sbyte)(value.Value);

    public static explicit operator HSYNTHETICPOINTERDEVICE(ushort value) =>
        new HSYNTHETICPOINTERDEVICE(unchecked((void*)(value)));

    public static explicit operator ushort(HSYNTHETICPOINTERDEVICE value) => (ushort)(value.Value);

    public static explicit operator HSYNTHETICPOINTERDEVICE(uint value) =>
        new HSYNTHETICPOINTERDEVICE(unchecked((void*)(value)));

    public static explicit operator uint(HSYNTHETICPOINTERDEVICE value) => (uint)(value.Value);

    public static explicit operator HSYNTHETICPOINTERDEVICE(ulong value) =>
        new HSYNTHETICPOINTERDEVICE(unchecked((void*)(value)));

    public static explicit operator ulong(HSYNTHETICPOINTERDEVICE value) => (ulong)(value.Value);

    public static explicit operator HSYNTHETICPOINTERDEVICE(nuint value) =>
        new HSYNTHETICPOINTERDEVICE(unchecked((void*)(value)));

    public static implicit operator nuint(HSYNTHETICPOINTERDEVICE value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HSYNTHETICPOINTERDEVICE other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HSYNTHETICPOINTERDEVICE.");
    }

    public int CompareTo(HSYNTHETICPOINTERDEVICE other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is HSYNTHETICPOINTERDEVICE other) && Equals(other);

    public bool Equals(HSYNTHETICPOINTERDEVICE other) =>
        ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
