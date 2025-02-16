// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HDEVNOTIFY
    : IComparable,
        IComparable<HDEVNOTIFY>,
        IEquatable<HDEVNOTIFY>,
        IFormattable
{
    public readonly void* Value;

    public HDEVNOTIFY(void* value)
    {
        Value = value;
    }

    public static HDEVNOTIFY INVALID_VALUE => new HDEVNOTIFY((void*)(-1));
    public static HDEVNOTIFY NULL => new HDEVNOTIFY(null);

    public static bool operator ==(HDEVNOTIFY left, HDEVNOTIFY right) => left.Value == right.Value;

    public static bool operator !=(HDEVNOTIFY left, HDEVNOTIFY right) => left.Value != right.Value;

    public static bool operator <(HDEVNOTIFY left, HDEVNOTIFY right) => left.Value < right.Value;

    public static bool operator <=(HDEVNOTIFY left, HDEVNOTIFY right) => left.Value <= right.Value;

    public static bool operator >(HDEVNOTIFY left, HDEVNOTIFY right) => left.Value > right.Value;

    public static bool operator >=(HDEVNOTIFY left, HDEVNOTIFY right) => left.Value >= right.Value;

    public static explicit operator HDEVNOTIFY(void* value) => new HDEVNOTIFY(value);

    public static implicit operator void*(HDEVNOTIFY value) => value.Value;

    public static explicit operator HDEVNOTIFY(HANDLE value) => new HDEVNOTIFY(value);

    public static implicit operator HANDLE(HDEVNOTIFY value) => new HANDLE(value.Value);

    public static explicit operator HDEVNOTIFY(byte value) =>
        new HDEVNOTIFY(unchecked((void*)(value)));

    public static explicit operator byte(HDEVNOTIFY value) => (byte)(value.Value);

    public static explicit operator HDEVNOTIFY(short value) =>
        new HDEVNOTIFY(unchecked((void*)(value)));

    public static explicit operator short(HDEVNOTIFY value) => (short)(value.Value);

    public static explicit operator HDEVNOTIFY(int value) =>
        new HDEVNOTIFY(unchecked((void*)(value)));

    public static explicit operator int(HDEVNOTIFY value) => (int)(value.Value);

    public static explicit operator HDEVNOTIFY(long value) =>
        new HDEVNOTIFY(unchecked((void*)(value)));

    public static explicit operator long(HDEVNOTIFY value) => (long)(value.Value);

    public static explicit operator HDEVNOTIFY(nint value) =>
        new HDEVNOTIFY(unchecked((void*)(value)));

    public static implicit operator nint(HDEVNOTIFY value) => (nint)(value.Value);

    public static explicit operator HDEVNOTIFY(sbyte value) =>
        new HDEVNOTIFY(unchecked((void*)(value)));

    public static explicit operator sbyte(HDEVNOTIFY value) => (sbyte)(value.Value);

    public static explicit operator HDEVNOTIFY(ushort value) =>
        new HDEVNOTIFY(unchecked((void*)(value)));

    public static explicit operator ushort(HDEVNOTIFY value) => (ushort)(value.Value);

    public static explicit operator HDEVNOTIFY(uint value) =>
        new HDEVNOTIFY(unchecked((void*)(value)));

    public static explicit operator uint(HDEVNOTIFY value) => (uint)(value.Value);

    public static explicit operator HDEVNOTIFY(ulong value) =>
        new HDEVNOTIFY(unchecked((void*)(value)));

    public static explicit operator ulong(HDEVNOTIFY value) => (ulong)(value.Value);

    public static explicit operator HDEVNOTIFY(nuint value) =>
        new HDEVNOTIFY(unchecked((void*)(value)));

    public static implicit operator nuint(HDEVNOTIFY value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HDEVNOTIFY other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HDEVNOTIFY.");
    }

    public int CompareTo(HDEVNOTIFY other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HDEVNOTIFY other) && Equals(other);

    public bool Equals(HDEVNOTIFY other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
