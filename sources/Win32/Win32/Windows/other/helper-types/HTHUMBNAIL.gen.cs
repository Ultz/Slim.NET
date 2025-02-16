// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HTHUMBNAIL
    : IComparable,
        IComparable<HTHUMBNAIL>,
        IEquatable<HTHUMBNAIL>,
        IFormattable
{
    public readonly void* Value;

    public HTHUMBNAIL(void* value)
    {
        Value = value;
    }

    public static HTHUMBNAIL INVALID_VALUE => new HTHUMBNAIL((void*)(-1));
    public static HTHUMBNAIL NULL => new HTHUMBNAIL(null);

    public static bool operator ==(HTHUMBNAIL left, HTHUMBNAIL right) => left.Value == right.Value;

    public static bool operator !=(HTHUMBNAIL left, HTHUMBNAIL right) => left.Value != right.Value;

    public static bool operator <(HTHUMBNAIL left, HTHUMBNAIL right) => left.Value < right.Value;

    public static bool operator <=(HTHUMBNAIL left, HTHUMBNAIL right) => left.Value <= right.Value;

    public static bool operator >(HTHUMBNAIL left, HTHUMBNAIL right) => left.Value > right.Value;

    public static bool operator >=(HTHUMBNAIL left, HTHUMBNAIL right) => left.Value >= right.Value;

    public static explicit operator HTHUMBNAIL(void* value) => new HTHUMBNAIL(value);

    public static implicit operator void*(HTHUMBNAIL value) => value.Value;

    public static explicit operator HTHUMBNAIL(HANDLE value) => new HTHUMBNAIL(value);

    public static implicit operator HANDLE(HTHUMBNAIL value) => new HANDLE(value.Value);

    public static explicit operator HTHUMBNAIL(byte value) =>
        new HTHUMBNAIL(unchecked((void*)(value)));

    public static explicit operator byte(HTHUMBNAIL value) => (byte)(value.Value);

    public static explicit operator HTHUMBNAIL(short value) =>
        new HTHUMBNAIL(unchecked((void*)(value)));

    public static explicit operator short(HTHUMBNAIL value) => (short)(value.Value);

    public static explicit operator HTHUMBNAIL(int value) =>
        new HTHUMBNAIL(unchecked((void*)(value)));

    public static explicit operator int(HTHUMBNAIL value) => (int)(value.Value);

    public static explicit operator HTHUMBNAIL(long value) =>
        new HTHUMBNAIL(unchecked((void*)(value)));

    public static explicit operator long(HTHUMBNAIL value) => (long)(value.Value);

    public static explicit operator HTHUMBNAIL(nint value) =>
        new HTHUMBNAIL(unchecked((void*)(value)));

    public static implicit operator nint(HTHUMBNAIL value) => (nint)(value.Value);

    public static explicit operator HTHUMBNAIL(sbyte value) =>
        new HTHUMBNAIL(unchecked((void*)(value)));

    public static explicit operator sbyte(HTHUMBNAIL value) => (sbyte)(value.Value);

    public static explicit operator HTHUMBNAIL(ushort value) =>
        new HTHUMBNAIL(unchecked((void*)(value)));

    public static explicit operator ushort(HTHUMBNAIL value) => (ushort)(value.Value);

    public static explicit operator HTHUMBNAIL(uint value) =>
        new HTHUMBNAIL(unchecked((void*)(value)));

    public static explicit operator uint(HTHUMBNAIL value) => (uint)(value.Value);

    public static explicit operator HTHUMBNAIL(ulong value) =>
        new HTHUMBNAIL(unchecked((void*)(value)));

    public static explicit operator ulong(HTHUMBNAIL value) => (ulong)(value.Value);

    public static explicit operator HTHUMBNAIL(nuint value) =>
        new HTHUMBNAIL(unchecked((void*)(value)));

    public static implicit operator nuint(HTHUMBNAIL value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HTHUMBNAIL other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HTHUMBNAIL.");
    }

    public int CompareTo(HTHUMBNAIL other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HTHUMBNAIL other) && Equals(other);

    public bool Equals(HTHUMBNAIL other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
