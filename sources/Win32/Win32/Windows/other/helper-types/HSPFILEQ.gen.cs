// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HSPFILEQ
    : IComparable,
        IComparable<HSPFILEQ>,
        IEquatable<HSPFILEQ>,
        IFormattable
{
    public readonly void* Value;

    public HSPFILEQ(void* value)
    {
        Value = value;
    }

    public static HSPFILEQ INVALID_VALUE => new HSPFILEQ((void*)(-1));
    public static HSPFILEQ NULL => new HSPFILEQ(null);

    public static bool operator ==(HSPFILEQ left, HSPFILEQ right) => left.Value == right.Value;

    public static bool operator !=(HSPFILEQ left, HSPFILEQ right) => left.Value != right.Value;

    public static bool operator <(HSPFILEQ left, HSPFILEQ right) => left.Value < right.Value;

    public static bool operator <=(HSPFILEQ left, HSPFILEQ right) => left.Value <= right.Value;

    public static bool operator >(HSPFILEQ left, HSPFILEQ right) => left.Value > right.Value;

    public static bool operator >=(HSPFILEQ left, HSPFILEQ right) => left.Value >= right.Value;

    public static explicit operator HSPFILEQ(void* value) => new HSPFILEQ(value);

    public static implicit operator void*(HSPFILEQ value) => value.Value;

    public static explicit operator HSPFILEQ(HANDLE value) => new HSPFILEQ(value);

    public static implicit operator HANDLE(HSPFILEQ value) => new HANDLE(value.Value);

    public static explicit operator HSPFILEQ(byte value) => new HSPFILEQ(unchecked((void*)(value)));

    public static explicit operator byte(HSPFILEQ value) => (byte)(value.Value);

    public static explicit operator HSPFILEQ(short value) =>
        new HSPFILEQ(unchecked((void*)(value)));

    public static explicit operator short(HSPFILEQ value) => (short)(value.Value);

    public static explicit operator HSPFILEQ(int value) => new HSPFILEQ(unchecked((void*)(value)));

    public static explicit operator int(HSPFILEQ value) => (int)(value.Value);

    public static explicit operator HSPFILEQ(long value) => new HSPFILEQ(unchecked((void*)(value)));

    public static explicit operator long(HSPFILEQ value) => (long)(value.Value);

    public static explicit operator HSPFILEQ(nint value) => new HSPFILEQ(unchecked((void*)(value)));

    public static implicit operator nint(HSPFILEQ value) => (nint)(value.Value);

    public static explicit operator HSPFILEQ(sbyte value) =>
        new HSPFILEQ(unchecked((void*)(value)));

    public static explicit operator sbyte(HSPFILEQ value) => (sbyte)(value.Value);

    public static explicit operator HSPFILEQ(ushort value) =>
        new HSPFILEQ(unchecked((void*)(value)));

    public static explicit operator ushort(HSPFILEQ value) => (ushort)(value.Value);

    public static explicit operator HSPFILEQ(uint value) => new HSPFILEQ(unchecked((void*)(value)));

    public static explicit operator uint(HSPFILEQ value) => (uint)(value.Value);

    public static explicit operator HSPFILEQ(ulong value) =>
        new HSPFILEQ(unchecked((void*)(value)));

    public static explicit operator ulong(HSPFILEQ value) => (ulong)(value.Value);

    public static explicit operator HSPFILEQ(nuint value) =>
        new HSPFILEQ(unchecked((void*)(value)));

    public static implicit operator nuint(HSPFILEQ value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HSPFILEQ other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HSPFILEQ.");
    }

    public int CompareTo(HSPFILEQ other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HSPFILEQ other) && Equals(other);

    public bool Equals(HSPFILEQ other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
