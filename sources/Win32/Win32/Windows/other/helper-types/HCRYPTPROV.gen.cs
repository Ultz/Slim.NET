// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HCRYPTPROV
    : IComparable,
        IComparable<HCRYPTPROV>,
        IEquatable<HCRYPTPROV>,
        IFormattable
{
    public readonly void* Value;

    public HCRYPTPROV(void* value)
    {
        Value = value;
    }

    public static HCRYPTPROV INVALID_VALUE => new HCRYPTPROV((void*)(-1));
    public static HCRYPTPROV NULL => new HCRYPTPROV(null);

    public static bool operator ==(HCRYPTPROV left, HCRYPTPROV right) => left.Value == right.Value;

    public static bool operator !=(HCRYPTPROV left, HCRYPTPROV right) => left.Value != right.Value;

    public static bool operator <(HCRYPTPROV left, HCRYPTPROV right) => left.Value < right.Value;

    public static bool operator <=(HCRYPTPROV left, HCRYPTPROV right) => left.Value <= right.Value;

    public static bool operator >(HCRYPTPROV left, HCRYPTPROV right) => left.Value > right.Value;

    public static bool operator >=(HCRYPTPROV left, HCRYPTPROV right) => left.Value >= right.Value;

    public static explicit operator HCRYPTPROV(void* value) => new HCRYPTPROV(value);

    public static implicit operator void*(HCRYPTPROV value) => value.Value;

    public static explicit operator HCRYPTPROV(HANDLE value) => new HCRYPTPROV(value);

    public static implicit operator HANDLE(HCRYPTPROV value) => new HANDLE(value.Value);

    public static explicit operator HCRYPTPROV(byte value) =>
        new HCRYPTPROV(unchecked((void*)(value)));

    public static explicit operator byte(HCRYPTPROV value) => (byte)(value.Value);

    public static explicit operator HCRYPTPROV(short value) =>
        new HCRYPTPROV(unchecked((void*)(value)));

    public static explicit operator short(HCRYPTPROV value) => (short)(value.Value);

    public static explicit operator HCRYPTPROV(int value) =>
        new HCRYPTPROV(unchecked((void*)(value)));

    public static explicit operator int(HCRYPTPROV value) => (int)(value.Value);

    public static explicit operator HCRYPTPROV(long value) =>
        new HCRYPTPROV(unchecked((void*)(value)));

    public static explicit operator long(HCRYPTPROV value) => (long)(value.Value);

    public static explicit operator HCRYPTPROV(nint value) =>
        new HCRYPTPROV(unchecked((void*)(value)));

    public static implicit operator nint(HCRYPTPROV value) => (nint)(value.Value);

    public static explicit operator HCRYPTPROV(sbyte value) =>
        new HCRYPTPROV(unchecked((void*)(value)));

    public static explicit operator sbyte(HCRYPTPROV value) => (sbyte)(value.Value);

    public static explicit operator HCRYPTPROV(ushort value) =>
        new HCRYPTPROV(unchecked((void*)(value)));

    public static explicit operator ushort(HCRYPTPROV value) => (ushort)(value.Value);

    public static explicit operator HCRYPTPROV(uint value) =>
        new HCRYPTPROV(unchecked((void*)(value)));

    public static explicit operator uint(HCRYPTPROV value) => (uint)(value.Value);

    public static explicit operator HCRYPTPROV(ulong value) =>
        new HCRYPTPROV(unchecked((void*)(value)));

    public static explicit operator ulong(HCRYPTPROV value) => (ulong)(value.Value);

    public static explicit operator HCRYPTPROV(nuint value) =>
        new HCRYPTPROV(unchecked((void*)(value)));

    public static implicit operator nuint(HCRYPTPROV value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HCRYPTPROV other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HCRYPTPROV.");
    }

    public int CompareTo(HCRYPTPROV other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HCRYPTPROV other) && Equals(other);

    public bool Equals(HCRYPTPROV other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
