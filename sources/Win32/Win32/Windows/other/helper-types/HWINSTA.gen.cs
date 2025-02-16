// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HWINSTA
    : IComparable,
        IComparable<HWINSTA>,
        IEquatable<HWINSTA>,
        IFormattable
{
    public readonly void* Value;

    public HWINSTA(void* value)
    {
        Value = value;
    }

    public static HWINSTA INVALID_VALUE => new HWINSTA((void*)(-1));
    public static HWINSTA NULL => new HWINSTA(null);

    public static bool operator ==(HWINSTA left, HWINSTA right) => left.Value == right.Value;

    public static bool operator !=(HWINSTA left, HWINSTA right) => left.Value != right.Value;

    public static bool operator <(HWINSTA left, HWINSTA right) => left.Value < right.Value;

    public static bool operator <=(HWINSTA left, HWINSTA right) => left.Value <= right.Value;

    public static bool operator >(HWINSTA left, HWINSTA right) => left.Value > right.Value;

    public static bool operator >=(HWINSTA left, HWINSTA right) => left.Value >= right.Value;

    public static explicit operator HWINSTA(void* value) => new HWINSTA(value);

    public static implicit operator void*(HWINSTA value) => value.Value;

    public static explicit operator HWINSTA(HANDLE value) => new HWINSTA(value);

    public static implicit operator HANDLE(HWINSTA value) => new HANDLE(value.Value);

    public static explicit operator HWINSTA(byte value) => new HWINSTA(unchecked((void*)(value)));

    public static explicit operator byte(HWINSTA value) => (byte)(value.Value);

    public static explicit operator HWINSTA(short value) => new HWINSTA(unchecked((void*)(value)));

    public static explicit operator short(HWINSTA value) => (short)(value.Value);

    public static explicit operator HWINSTA(int value) => new HWINSTA(unchecked((void*)(value)));

    public static explicit operator int(HWINSTA value) => (int)(value.Value);

    public static explicit operator HWINSTA(long value) => new HWINSTA(unchecked((void*)(value)));

    public static explicit operator long(HWINSTA value) => (long)(value.Value);

    public static explicit operator HWINSTA(nint value) => new HWINSTA(unchecked((void*)(value)));

    public static implicit operator nint(HWINSTA value) => (nint)(value.Value);

    public static explicit operator HWINSTA(sbyte value) => new HWINSTA(unchecked((void*)(value)));

    public static explicit operator sbyte(HWINSTA value) => (sbyte)(value.Value);

    public static explicit operator HWINSTA(ushort value) => new HWINSTA(unchecked((void*)(value)));

    public static explicit operator ushort(HWINSTA value) => (ushort)(value.Value);

    public static explicit operator HWINSTA(uint value) => new HWINSTA(unchecked((void*)(value)));

    public static explicit operator uint(HWINSTA value) => (uint)(value.Value);

    public static explicit operator HWINSTA(ulong value) => new HWINSTA(unchecked((void*)(value)));

    public static explicit operator ulong(HWINSTA value) => (ulong)(value.Value);

    public static explicit operator HWINSTA(nuint value) => new HWINSTA(unchecked((void*)(value)));

    public static implicit operator nuint(HWINSTA value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HWINSTA other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HWINSTA.");
    }

    public int CompareTo(HWINSTA other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HWINSTA other) && Equals(other);

    public bool Equals(HWINSTA other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
