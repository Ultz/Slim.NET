// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HMETAFILE
    : IComparable,
        IComparable<HMETAFILE>,
        IEquatable<HMETAFILE>,
        IFormattable
{
    public readonly void* Value;

    public HMETAFILE(void* value)
    {
        Value = value;
    }

    public static HMETAFILE INVALID_VALUE => new HMETAFILE((void*)(-1));
    public static HMETAFILE NULL => new HMETAFILE(null);

    public static bool operator ==(HMETAFILE left, HMETAFILE right) => left.Value == right.Value;

    public static bool operator !=(HMETAFILE left, HMETAFILE right) => left.Value != right.Value;

    public static bool operator <(HMETAFILE left, HMETAFILE right) => left.Value < right.Value;

    public static bool operator <=(HMETAFILE left, HMETAFILE right) => left.Value <= right.Value;

    public static bool operator >(HMETAFILE left, HMETAFILE right) => left.Value > right.Value;

    public static bool operator >=(HMETAFILE left, HMETAFILE right) => left.Value >= right.Value;

    public static explicit operator HMETAFILE(void* value) => new HMETAFILE(value);

    public static implicit operator void*(HMETAFILE value) => value.Value;

    public static explicit operator HMETAFILE(HANDLE value) => new HMETAFILE(value);

    public static implicit operator HANDLE(HMETAFILE value) => new HANDLE(value.Value);

    public static explicit operator HMETAFILE(byte value) =>
        new HMETAFILE(unchecked((void*)(value)));

    public static explicit operator byte(HMETAFILE value) => (byte)(value.Value);

    public static explicit operator HMETAFILE(short value) =>
        new HMETAFILE(unchecked((void*)(value)));

    public static explicit operator short(HMETAFILE value) => (short)(value.Value);

    public static explicit operator HMETAFILE(int value) =>
        new HMETAFILE(unchecked((void*)(value)));

    public static explicit operator int(HMETAFILE value) => (int)(value.Value);

    public static explicit operator HMETAFILE(long value) =>
        new HMETAFILE(unchecked((void*)(value)));

    public static explicit operator long(HMETAFILE value) => (long)(value.Value);

    public static explicit operator HMETAFILE(nint value) =>
        new HMETAFILE(unchecked((void*)(value)));

    public static implicit operator nint(HMETAFILE value) => (nint)(value.Value);

    public static explicit operator HMETAFILE(sbyte value) =>
        new HMETAFILE(unchecked((void*)(value)));

    public static explicit operator sbyte(HMETAFILE value) => (sbyte)(value.Value);

    public static explicit operator HMETAFILE(ushort value) =>
        new HMETAFILE(unchecked((void*)(value)));

    public static explicit operator ushort(HMETAFILE value) => (ushort)(value.Value);

    public static explicit operator HMETAFILE(uint value) =>
        new HMETAFILE(unchecked((void*)(value)));

    public static explicit operator uint(HMETAFILE value) => (uint)(value.Value);

    public static explicit operator HMETAFILE(ulong value) =>
        new HMETAFILE(unchecked((void*)(value)));

    public static explicit operator ulong(HMETAFILE value) => (ulong)(value.Value);

    public static explicit operator HMETAFILE(nuint value) =>
        new HMETAFILE(unchecked((void*)(value)));

    public static implicit operator nuint(HMETAFILE value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HMETAFILE other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HMETAFILE.");
    }

    public int CompareTo(HMETAFILE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HMETAFILE other) && Equals(other);

    public bool Equals(HMETAFILE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
