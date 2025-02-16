// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HRGN
    : IComparable,
        IComparable<HRGN>,
        IEquatable<HRGN>,
        IFormattable
{
    public readonly void* Value;

    public HRGN(void* value)
    {
        Value = value;
    }

    public static HRGN INVALID_VALUE => new HRGN((void*)(-1));
    public static HRGN NULL => new HRGN(null);

    public static bool operator ==(HRGN left, HRGN right) => left.Value == right.Value;

    public static bool operator !=(HRGN left, HRGN right) => left.Value != right.Value;

    public static bool operator <(HRGN left, HRGN right) => left.Value < right.Value;

    public static bool operator <=(HRGN left, HRGN right) => left.Value <= right.Value;

    public static bool operator >(HRGN left, HRGN right) => left.Value > right.Value;

    public static bool operator >=(HRGN left, HRGN right) => left.Value >= right.Value;

    public static explicit operator HRGN(void* value) => new HRGN(value);

    public static implicit operator void*(HRGN value) => value.Value;

    public static explicit operator HRGN(HANDLE value) => new HRGN(value);

    public static implicit operator HANDLE(HRGN value) => new HANDLE(value.Value);

    public static explicit operator HRGN(byte value) => new HRGN(unchecked((void*)(value)));

    public static explicit operator byte(HRGN value) => (byte)(value.Value);

    public static explicit operator HRGN(short value) => new HRGN(unchecked((void*)(value)));

    public static explicit operator short(HRGN value) => (short)(value.Value);

    public static explicit operator HRGN(int value) => new HRGN(unchecked((void*)(value)));

    public static explicit operator int(HRGN value) => (int)(value.Value);

    public static explicit operator HRGN(long value) => new HRGN(unchecked((void*)(value)));

    public static explicit operator long(HRGN value) => (long)(value.Value);

    public static explicit operator HRGN(nint value) => new HRGN(unchecked((void*)(value)));

    public static implicit operator nint(HRGN value) => (nint)(value.Value);

    public static explicit operator HRGN(sbyte value) => new HRGN(unchecked((void*)(value)));

    public static explicit operator sbyte(HRGN value) => (sbyte)(value.Value);

    public static explicit operator HRGN(ushort value) => new HRGN(unchecked((void*)(value)));

    public static explicit operator ushort(HRGN value) => (ushort)(value.Value);

    public static explicit operator HRGN(uint value) => new HRGN(unchecked((void*)(value)));

    public static explicit operator uint(HRGN value) => (uint)(value.Value);

    public static explicit operator HRGN(ulong value) => new HRGN(unchecked((void*)(value)));

    public static explicit operator ulong(HRGN value) => (ulong)(value.Value);

    public static explicit operator HRGN(nuint value) => new HRGN(unchecked((void*)(value)));

    public static implicit operator nuint(HRGN value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HRGN other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HRGN.");
    }

    public int CompareTo(HRGN other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HRGN other) && Equals(other);

    public bool Equals(HRGN other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
