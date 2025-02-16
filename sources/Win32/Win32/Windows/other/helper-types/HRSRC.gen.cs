// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HRSRC
    : IComparable,
        IComparable<HRSRC>,
        IEquatable<HRSRC>,
        IFormattable
{
    public readonly void* Value;

    public HRSRC(void* value)
    {
        Value = value;
    }

    public static HRSRC INVALID_VALUE => new HRSRC((void*)(-1));
    public static HRSRC NULL => new HRSRC(null);

    public static bool operator ==(HRSRC left, HRSRC right) => left.Value == right.Value;

    public static bool operator !=(HRSRC left, HRSRC right) => left.Value != right.Value;

    public static bool operator <(HRSRC left, HRSRC right) => left.Value < right.Value;

    public static bool operator <=(HRSRC left, HRSRC right) => left.Value <= right.Value;

    public static bool operator >(HRSRC left, HRSRC right) => left.Value > right.Value;

    public static bool operator >=(HRSRC left, HRSRC right) => left.Value >= right.Value;

    public static explicit operator HRSRC(void* value) => new HRSRC(value);

    public static implicit operator void*(HRSRC value) => value.Value;

    public static explicit operator HRSRC(HANDLE value) => new HRSRC(value);

    public static implicit operator HANDLE(HRSRC value) => new HANDLE(value.Value);

    public static explicit operator HRSRC(byte value) => new HRSRC(unchecked((void*)(value)));

    public static explicit operator byte(HRSRC value) => (byte)(value.Value);

    public static explicit operator HRSRC(short value) => new HRSRC(unchecked((void*)(value)));

    public static explicit operator short(HRSRC value) => (short)(value.Value);

    public static explicit operator HRSRC(int value) => new HRSRC(unchecked((void*)(value)));

    public static explicit operator int(HRSRC value) => (int)(value.Value);

    public static explicit operator HRSRC(long value) => new HRSRC(unchecked((void*)(value)));

    public static explicit operator long(HRSRC value) => (long)(value.Value);

    public static explicit operator HRSRC(nint value) => new HRSRC(unchecked((void*)(value)));

    public static implicit operator nint(HRSRC value) => (nint)(value.Value);

    public static explicit operator HRSRC(sbyte value) => new HRSRC(unchecked((void*)(value)));

    public static explicit operator sbyte(HRSRC value) => (sbyte)(value.Value);

    public static explicit operator HRSRC(ushort value) => new HRSRC(unchecked((void*)(value)));

    public static explicit operator ushort(HRSRC value) => (ushort)(value.Value);

    public static explicit operator HRSRC(uint value) => new HRSRC(unchecked((void*)(value)));

    public static explicit operator uint(HRSRC value) => (uint)(value.Value);

    public static explicit operator HRSRC(ulong value) => new HRSRC(unchecked((void*)(value)));

    public static explicit operator ulong(HRSRC value) => (ulong)(value.Value);

    public static explicit operator HRSRC(nuint value) => new HRSRC(unchecked((void*)(value)));

    public static implicit operator nuint(HRSRC value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HRSRC other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HRSRC.");
    }

    public int CompareTo(HRSRC other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HRSRC other) && Equals(other);

    public bool Equals(HRSRC other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
