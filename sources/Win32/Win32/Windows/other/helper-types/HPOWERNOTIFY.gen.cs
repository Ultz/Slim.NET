// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HPOWERNOTIFY
    : IComparable,
        IComparable<HPOWERNOTIFY>,
        IEquatable<HPOWERNOTIFY>,
        IFormattable
{
    public readonly void* Value;

    public HPOWERNOTIFY(void* value)
    {
        Value = value;
    }

    public static HPOWERNOTIFY INVALID_VALUE => new HPOWERNOTIFY((void*)(-1));
    public static HPOWERNOTIFY NULL => new HPOWERNOTIFY(null);

    public static bool operator ==(HPOWERNOTIFY left, HPOWERNOTIFY right) =>
        left.Value == right.Value;

    public static bool operator !=(HPOWERNOTIFY left, HPOWERNOTIFY right) =>
        left.Value != right.Value;

    public static bool operator <(HPOWERNOTIFY left, HPOWERNOTIFY right) =>
        left.Value < right.Value;

    public static bool operator <=(HPOWERNOTIFY left, HPOWERNOTIFY right) =>
        left.Value <= right.Value;

    public static bool operator >(HPOWERNOTIFY left, HPOWERNOTIFY right) =>
        left.Value > right.Value;

    public static bool operator >=(HPOWERNOTIFY left, HPOWERNOTIFY right) =>
        left.Value >= right.Value;

    public static explicit operator HPOWERNOTIFY(void* value) => new HPOWERNOTIFY(value);

    public static implicit operator void*(HPOWERNOTIFY value) => value.Value;

    public static explicit operator HPOWERNOTIFY(HANDLE value) => new HPOWERNOTIFY(value);

    public static implicit operator HANDLE(HPOWERNOTIFY value) => new HANDLE(value.Value);

    public static explicit operator HPOWERNOTIFY(byte value) =>
        new HPOWERNOTIFY(unchecked((void*)(value)));

    public static explicit operator byte(HPOWERNOTIFY value) => (byte)(value.Value);

    public static explicit operator HPOWERNOTIFY(short value) =>
        new HPOWERNOTIFY(unchecked((void*)(value)));

    public static explicit operator short(HPOWERNOTIFY value) => (short)(value.Value);

    public static explicit operator HPOWERNOTIFY(int value) =>
        new HPOWERNOTIFY(unchecked((void*)(value)));

    public static explicit operator int(HPOWERNOTIFY value) => (int)(value.Value);

    public static explicit operator HPOWERNOTIFY(long value) =>
        new HPOWERNOTIFY(unchecked((void*)(value)));

    public static explicit operator long(HPOWERNOTIFY value) => (long)(value.Value);

    public static explicit operator HPOWERNOTIFY(nint value) =>
        new HPOWERNOTIFY(unchecked((void*)(value)));

    public static implicit operator nint(HPOWERNOTIFY value) => (nint)(value.Value);

    public static explicit operator HPOWERNOTIFY(sbyte value) =>
        new HPOWERNOTIFY(unchecked((void*)(value)));

    public static explicit operator sbyte(HPOWERNOTIFY value) => (sbyte)(value.Value);

    public static explicit operator HPOWERNOTIFY(ushort value) =>
        new HPOWERNOTIFY(unchecked((void*)(value)));

    public static explicit operator ushort(HPOWERNOTIFY value) => (ushort)(value.Value);

    public static explicit operator HPOWERNOTIFY(uint value) =>
        new HPOWERNOTIFY(unchecked((void*)(value)));

    public static explicit operator uint(HPOWERNOTIFY value) => (uint)(value.Value);

    public static explicit operator HPOWERNOTIFY(ulong value) =>
        new HPOWERNOTIFY(unchecked((void*)(value)));

    public static explicit operator ulong(HPOWERNOTIFY value) => (ulong)(value.Value);

    public static explicit operator HPOWERNOTIFY(nuint value) =>
        new HPOWERNOTIFY(unchecked((void*)(value)));

    public static implicit operator nuint(HPOWERNOTIFY value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HPOWERNOTIFY other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HPOWERNOTIFY.");
    }

    public int CompareTo(HPOWERNOTIFY other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HPOWERNOTIFY other) && Equals(other);

    public bool Equals(HPOWERNOTIFY other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
