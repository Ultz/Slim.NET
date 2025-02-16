// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HANDLE_PTR
    : IComparable,
        IComparable<HANDLE_PTR>,
        IEquatable<HANDLE_PTR>,
        IFormattable
{
    public readonly void* Value;

    public HANDLE_PTR(void* value)
    {
        Value = value;
    }

    public static HANDLE_PTR NULL => new HANDLE_PTR(null);

    public static bool operator ==(HANDLE_PTR left, HANDLE_PTR right) => left.Value == right.Value;

    public static bool operator !=(HANDLE_PTR left, HANDLE_PTR right) => left.Value != right.Value;

    public static bool operator <(HANDLE_PTR left, HANDLE_PTR right) => left.Value < right.Value;

    public static bool operator <=(HANDLE_PTR left, HANDLE_PTR right) => left.Value <= right.Value;

    public static bool operator >(HANDLE_PTR left, HANDLE_PTR right) => left.Value > right.Value;

    public static bool operator >=(HANDLE_PTR left, HANDLE_PTR right) => left.Value >= right.Value;

    public static explicit operator HANDLE_PTR(void* value) => new HANDLE_PTR(value);

    public static implicit operator void*(HANDLE_PTR value) => value.Value;

    public static explicit operator HANDLE_PTR(byte value) =>
        new HANDLE_PTR(unchecked((void*)(value)));

    public static explicit operator byte(HANDLE_PTR value) => (byte)(value.Value);

    public static explicit operator HANDLE_PTR(short value) =>
        new HANDLE_PTR(unchecked((void*)(value)));

    public static explicit operator short(HANDLE_PTR value) => (short)(value.Value);

    public static explicit operator HANDLE_PTR(int value) =>
        new HANDLE_PTR(unchecked((void*)(value)));

    public static explicit operator int(HANDLE_PTR value) => (int)(value.Value);

    public static explicit operator HANDLE_PTR(long value) =>
        new HANDLE_PTR(unchecked((void*)(value)));

    public static explicit operator long(HANDLE_PTR value) => (long)(value.Value);

    public static explicit operator HANDLE_PTR(nint value) =>
        new HANDLE_PTR(unchecked((void*)(value)));

    public static implicit operator nint(HANDLE_PTR value) => (nint)(value.Value);

    public static explicit operator HANDLE_PTR(sbyte value) =>
        new HANDLE_PTR(unchecked((void*)(value)));

    public static explicit operator sbyte(HANDLE_PTR value) => (sbyte)(value.Value);

    public static explicit operator HANDLE_PTR(ushort value) =>
        new HANDLE_PTR(unchecked((void*)(value)));

    public static explicit operator ushort(HANDLE_PTR value) => (ushort)(value.Value);

    public static explicit operator HANDLE_PTR(uint value) =>
        new HANDLE_PTR(unchecked((void*)(value)));

    public static explicit operator uint(HANDLE_PTR value) => (uint)(value.Value);

    public static explicit operator HANDLE_PTR(ulong value) =>
        new HANDLE_PTR(unchecked((void*)(value)));

    public static explicit operator ulong(HANDLE_PTR value) => (ulong)(value.Value);

    public static explicit operator HANDLE_PTR(nuint value) =>
        new HANDLE_PTR(unchecked((void*)(value)));

    public static implicit operator nuint(HANDLE_PTR value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HANDLE_PTR other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HANDLE_PTR.");
    }

    public int CompareTo(HANDLE_PTR other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HANDLE_PTR other) && Equals(other);

    public bool Equals(HANDLE_PTR other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
