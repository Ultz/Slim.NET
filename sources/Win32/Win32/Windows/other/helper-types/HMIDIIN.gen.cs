// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HMIDIIN
    : IComparable,
        IComparable<HMIDIIN>,
        IEquatable<HMIDIIN>,
        IFormattable
{
    public readonly void* Value;

    public HMIDIIN(void* value)
    {
        Value = value;
    }

    public static HMIDIIN INVALID_VALUE => new HMIDIIN((void*)(-1));
    public static HMIDIIN NULL => new HMIDIIN(null);

    public static bool operator ==(HMIDIIN left, HMIDIIN right) => left.Value == right.Value;

    public static bool operator !=(HMIDIIN left, HMIDIIN right) => left.Value != right.Value;

    public static bool operator <(HMIDIIN left, HMIDIIN right) => left.Value < right.Value;

    public static bool operator <=(HMIDIIN left, HMIDIIN right) => left.Value <= right.Value;

    public static bool operator >(HMIDIIN left, HMIDIIN right) => left.Value > right.Value;

    public static bool operator >=(HMIDIIN left, HMIDIIN right) => left.Value >= right.Value;

    public static explicit operator HMIDIIN(void* value) => new HMIDIIN(value);

    public static implicit operator void*(HMIDIIN value) => value.Value;

    public static explicit operator HMIDIIN(HANDLE value) => new HMIDIIN(value);

    public static implicit operator HANDLE(HMIDIIN value) => new HANDLE(value.Value);

    public static explicit operator HMIDIIN(byte value) => new HMIDIIN(unchecked((void*)(value)));

    public static explicit operator byte(HMIDIIN value) => (byte)(value.Value);

    public static explicit operator HMIDIIN(short value) => new HMIDIIN(unchecked((void*)(value)));

    public static explicit operator short(HMIDIIN value) => (short)(value.Value);

    public static explicit operator HMIDIIN(int value) => new HMIDIIN(unchecked((void*)(value)));

    public static explicit operator int(HMIDIIN value) => (int)(value.Value);

    public static explicit operator HMIDIIN(long value) => new HMIDIIN(unchecked((void*)(value)));

    public static explicit operator long(HMIDIIN value) => (long)(value.Value);

    public static explicit operator HMIDIIN(nint value) => new HMIDIIN(unchecked((void*)(value)));

    public static implicit operator nint(HMIDIIN value) => (nint)(value.Value);

    public static explicit operator HMIDIIN(sbyte value) => new HMIDIIN(unchecked((void*)(value)));

    public static explicit operator sbyte(HMIDIIN value) => (sbyte)(value.Value);

    public static explicit operator HMIDIIN(ushort value) => new HMIDIIN(unchecked((void*)(value)));

    public static explicit operator ushort(HMIDIIN value) => (ushort)(value.Value);

    public static explicit operator HMIDIIN(uint value) => new HMIDIIN(unchecked((void*)(value)));

    public static explicit operator uint(HMIDIIN value) => (uint)(value.Value);

    public static explicit operator HMIDIIN(ulong value) => new HMIDIIN(unchecked((void*)(value)));

    public static explicit operator ulong(HMIDIIN value) => (ulong)(value.Value);

    public static explicit operator HMIDIIN(nuint value) => new HMIDIIN(unchecked((void*)(value)));

    public static implicit operator nuint(HMIDIIN value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HMIDIIN other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HMIDIIN.");
    }

    public int CompareTo(HMIDIIN other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HMIDIIN other) && Equals(other);

    public bool Equals(HMIDIIN other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
