// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HCERTSTOREPROV
    : IComparable,
        IComparable<HCERTSTOREPROV>,
        IEquatable<HCERTSTOREPROV>,
        IFormattable
{
    public readonly void* Value;

    public HCERTSTOREPROV(void* value)
    {
        Value = value;
    }

    public static HCERTSTOREPROV INVALID_VALUE => new HCERTSTOREPROV((void*)(-1));
    public static HCERTSTOREPROV NULL => new HCERTSTOREPROV(null);

    public static bool operator ==(HCERTSTOREPROV left, HCERTSTOREPROV right) =>
        left.Value == right.Value;

    public static bool operator !=(HCERTSTOREPROV left, HCERTSTOREPROV right) =>
        left.Value != right.Value;

    public static bool operator <(HCERTSTOREPROV left, HCERTSTOREPROV right) =>
        left.Value < right.Value;

    public static bool operator <=(HCERTSTOREPROV left, HCERTSTOREPROV right) =>
        left.Value <= right.Value;

    public static bool operator >(HCERTSTOREPROV left, HCERTSTOREPROV right) =>
        left.Value > right.Value;

    public static bool operator >=(HCERTSTOREPROV left, HCERTSTOREPROV right) =>
        left.Value >= right.Value;

    public static explicit operator HCERTSTOREPROV(void* value) => new HCERTSTOREPROV(value);

    public static implicit operator void*(HCERTSTOREPROV value) => value.Value;

    public static explicit operator HCERTSTOREPROV(HANDLE value) => new HCERTSTOREPROV(value);

    public static implicit operator HANDLE(HCERTSTOREPROV value) => new HANDLE(value.Value);

    public static explicit operator HCERTSTOREPROV(byte value) =>
        new HCERTSTOREPROV(unchecked((void*)(value)));

    public static explicit operator byte(HCERTSTOREPROV value) => (byte)(value.Value);

    public static explicit operator HCERTSTOREPROV(short value) =>
        new HCERTSTOREPROV(unchecked((void*)(value)));

    public static explicit operator short(HCERTSTOREPROV value) => (short)(value.Value);

    public static explicit operator HCERTSTOREPROV(int value) =>
        new HCERTSTOREPROV(unchecked((void*)(value)));

    public static explicit operator int(HCERTSTOREPROV value) => (int)(value.Value);

    public static explicit operator HCERTSTOREPROV(long value) =>
        new HCERTSTOREPROV(unchecked((void*)(value)));

    public static explicit operator long(HCERTSTOREPROV value) => (long)(value.Value);

    public static explicit operator HCERTSTOREPROV(nint value) =>
        new HCERTSTOREPROV(unchecked((void*)(value)));

    public static implicit operator nint(HCERTSTOREPROV value) => (nint)(value.Value);

    public static explicit operator HCERTSTOREPROV(sbyte value) =>
        new HCERTSTOREPROV(unchecked((void*)(value)));

    public static explicit operator sbyte(HCERTSTOREPROV value) => (sbyte)(value.Value);

    public static explicit operator HCERTSTOREPROV(ushort value) =>
        new HCERTSTOREPROV(unchecked((void*)(value)));

    public static explicit operator ushort(HCERTSTOREPROV value) => (ushort)(value.Value);

    public static explicit operator HCERTSTOREPROV(uint value) =>
        new HCERTSTOREPROV(unchecked((void*)(value)));

    public static explicit operator uint(HCERTSTOREPROV value) => (uint)(value.Value);

    public static explicit operator HCERTSTOREPROV(ulong value) =>
        new HCERTSTOREPROV(unchecked((void*)(value)));

    public static explicit operator ulong(HCERTSTOREPROV value) => (ulong)(value.Value);

    public static explicit operator HCERTSTOREPROV(nuint value) =>
        new HCERTSTOREPROV(unchecked((void*)(value)));

    public static implicit operator nuint(HCERTSTOREPROV value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HCERTSTOREPROV other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HCERTSTOREPROV.");
    }

    public int CompareTo(HCERTSTOREPROV other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HCERTSTOREPROV other) && Equals(other);

    public bool Equals(HCERTSTOREPROV other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
