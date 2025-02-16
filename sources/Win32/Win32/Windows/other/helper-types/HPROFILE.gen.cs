// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HPROFILE
    : IComparable,
        IComparable<HPROFILE>,
        IEquatable<HPROFILE>,
        IFormattable
{
    public readonly void* Value;

    public HPROFILE(void* value)
    {
        Value = value;
    }

    public static HPROFILE INVALID_VALUE => new HPROFILE((void*)(-1));
    public static HPROFILE NULL => new HPROFILE(null);

    public static bool operator ==(HPROFILE left, HPROFILE right) => left.Value == right.Value;

    public static bool operator !=(HPROFILE left, HPROFILE right) => left.Value != right.Value;

    public static bool operator <(HPROFILE left, HPROFILE right) => left.Value < right.Value;

    public static bool operator <=(HPROFILE left, HPROFILE right) => left.Value <= right.Value;

    public static bool operator >(HPROFILE left, HPROFILE right) => left.Value > right.Value;

    public static bool operator >=(HPROFILE left, HPROFILE right) => left.Value >= right.Value;

    public static explicit operator HPROFILE(void* value) => new HPROFILE(value);

    public static implicit operator void*(HPROFILE value) => value.Value;

    public static explicit operator HPROFILE(HANDLE value) => new HPROFILE(value);

    public static implicit operator HANDLE(HPROFILE value) => new HANDLE(value.Value);

    public static explicit operator HPROFILE(byte value) => new HPROFILE(unchecked((void*)(value)));

    public static explicit operator byte(HPROFILE value) => (byte)(value.Value);

    public static explicit operator HPROFILE(short value) =>
        new HPROFILE(unchecked((void*)(value)));

    public static explicit operator short(HPROFILE value) => (short)(value.Value);

    public static explicit operator HPROFILE(int value) => new HPROFILE(unchecked((void*)(value)));

    public static explicit operator int(HPROFILE value) => (int)(value.Value);

    public static explicit operator HPROFILE(long value) => new HPROFILE(unchecked((void*)(value)));

    public static explicit operator long(HPROFILE value) => (long)(value.Value);

    public static explicit operator HPROFILE(nint value) => new HPROFILE(unchecked((void*)(value)));

    public static implicit operator nint(HPROFILE value) => (nint)(value.Value);

    public static explicit operator HPROFILE(sbyte value) =>
        new HPROFILE(unchecked((void*)(value)));

    public static explicit operator sbyte(HPROFILE value) => (sbyte)(value.Value);

    public static explicit operator HPROFILE(ushort value) =>
        new HPROFILE(unchecked((void*)(value)));

    public static explicit operator ushort(HPROFILE value) => (ushort)(value.Value);

    public static explicit operator HPROFILE(uint value) => new HPROFILE(unchecked((void*)(value)));

    public static explicit operator uint(HPROFILE value) => (uint)(value.Value);

    public static explicit operator HPROFILE(ulong value) =>
        new HPROFILE(unchecked((void*)(value)));

    public static explicit operator ulong(HPROFILE value) => (ulong)(value.Value);

    public static explicit operator HPROFILE(nuint value) =>
        new HPROFILE(unchecked((void*)(value)));

    public static implicit operator nuint(HPROFILE value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HPROFILE other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HPROFILE.");
    }

    public int CompareTo(HPROFILE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HPROFILE other) && Equals(other);

    public bool Equals(HPROFILE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
