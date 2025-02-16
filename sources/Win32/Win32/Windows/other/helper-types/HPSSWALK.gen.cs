// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HPSSWALK
    : IComparable,
        IComparable<HPSSWALK>,
        IEquatable<HPSSWALK>,
        IFormattable
{
    public readonly void* Value;

    public HPSSWALK(void* value)
    {
        Value = value;
    }

    public static HPSSWALK INVALID_VALUE => new HPSSWALK((void*)(-1));
    public static HPSSWALK NULL => new HPSSWALK(null);

    public static bool operator ==(HPSSWALK left, HPSSWALK right) => left.Value == right.Value;

    public static bool operator !=(HPSSWALK left, HPSSWALK right) => left.Value != right.Value;

    public static bool operator <(HPSSWALK left, HPSSWALK right) => left.Value < right.Value;

    public static bool operator <=(HPSSWALK left, HPSSWALK right) => left.Value <= right.Value;

    public static bool operator >(HPSSWALK left, HPSSWALK right) => left.Value > right.Value;

    public static bool operator >=(HPSSWALK left, HPSSWALK right) => left.Value >= right.Value;

    public static explicit operator HPSSWALK(void* value) => new HPSSWALK(value);

    public static implicit operator void*(HPSSWALK value) => value.Value;

    public static explicit operator HPSSWALK(HANDLE value) => new HPSSWALK(value);

    public static implicit operator HANDLE(HPSSWALK value) => new HANDLE(value.Value);

    public static explicit operator HPSSWALK(byte value) => new HPSSWALK(unchecked((void*)(value)));

    public static explicit operator byte(HPSSWALK value) => (byte)(value.Value);

    public static explicit operator HPSSWALK(short value) =>
        new HPSSWALK(unchecked((void*)(value)));

    public static explicit operator short(HPSSWALK value) => (short)(value.Value);

    public static explicit operator HPSSWALK(int value) => new HPSSWALK(unchecked((void*)(value)));

    public static explicit operator int(HPSSWALK value) => (int)(value.Value);

    public static explicit operator HPSSWALK(long value) => new HPSSWALK(unchecked((void*)(value)));

    public static explicit operator long(HPSSWALK value) => (long)(value.Value);

    public static explicit operator HPSSWALK(nint value) => new HPSSWALK(unchecked((void*)(value)));

    public static implicit operator nint(HPSSWALK value) => (nint)(value.Value);

    public static explicit operator HPSSWALK(sbyte value) =>
        new HPSSWALK(unchecked((void*)(value)));

    public static explicit operator sbyte(HPSSWALK value) => (sbyte)(value.Value);

    public static explicit operator HPSSWALK(ushort value) =>
        new HPSSWALK(unchecked((void*)(value)));

    public static explicit operator ushort(HPSSWALK value) => (ushort)(value.Value);

    public static explicit operator HPSSWALK(uint value) => new HPSSWALK(unchecked((void*)(value)));

    public static explicit operator uint(HPSSWALK value) => (uint)(value.Value);

    public static explicit operator HPSSWALK(ulong value) =>
        new HPSSWALK(unchecked((void*)(value)));

    public static explicit operator ulong(HPSSWALK value) => (ulong)(value.Value);

    public static explicit operator HPSSWALK(nuint value) =>
        new HPSSWALK(unchecked((void*)(value)));

    public static implicit operator nuint(HPSSWALK value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HPSSWALK other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HPSSWALK.");
    }

    public int CompareTo(HPSSWALK other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HPSSWALK other) && Equals(other);

    public bool Equals(HPSSWALK other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
