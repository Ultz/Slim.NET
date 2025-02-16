// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HINF
    : IComparable,
        IComparable<HINF>,
        IEquatable<HINF>,
        IFormattable
{
    public readonly void* Value;

    public HINF(void* value)
    {
        Value = value;
    }

    public static HINF INVALID_VALUE => new HINF((void*)(-1));
    public static HINF NULL => new HINF(null);

    public static bool operator ==(HINF left, HINF right) => left.Value == right.Value;

    public static bool operator !=(HINF left, HINF right) => left.Value != right.Value;

    public static bool operator <(HINF left, HINF right) => left.Value < right.Value;

    public static bool operator <=(HINF left, HINF right) => left.Value <= right.Value;

    public static bool operator >(HINF left, HINF right) => left.Value > right.Value;

    public static bool operator >=(HINF left, HINF right) => left.Value >= right.Value;

    public static explicit operator HINF(void* value) => new HINF(value);

    public static implicit operator void*(HINF value) => value.Value;

    public static explicit operator HINF(HANDLE value) => new HINF(value);

    public static implicit operator HANDLE(HINF value) => new HANDLE(value.Value);

    public static explicit operator HINF(byte value) => new HINF(unchecked((void*)(value)));

    public static explicit operator byte(HINF value) => (byte)(value.Value);

    public static explicit operator HINF(short value) => new HINF(unchecked((void*)(value)));

    public static explicit operator short(HINF value) => (short)(value.Value);

    public static explicit operator HINF(int value) => new HINF(unchecked((void*)(value)));

    public static explicit operator int(HINF value) => (int)(value.Value);

    public static explicit operator HINF(long value) => new HINF(unchecked((void*)(value)));

    public static explicit operator long(HINF value) => (long)(value.Value);

    public static explicit operator HINF(nint value) => new HINF(unchecked((void*)(value)));

    public static implicit operator nint(HINF value) => (nint)(value.Value);

    public static explicit operator HINF(sbyte value) => new HINF(unchecked((void*)(value)));

    public static explicit operator sbyte(HINF value) => (sbyte)(value.Value);

    public static explicit operator HINF(ushort value) => new HINF(unchecked((void*)(value)));

    public static explicit operator ushort(HINF value) => (ushort)(value.Value);

    public static explicit operator HINF(uint value) => new HINF(unchecked((void*)(value)));

    public static explicit operator uint(HINF value) => (uint)(value.Value);

    public static explicit operator HINF(ulong value) => new HINF(unchecked((void*)(value)));

    public static explicit operator ulong(HINF value) => (ulong)(value.Value);

    public static explicit operator HINF(nuint value) => new HINF(unchecked((void*)(value)));

    public static implicit operator nuint(HINF value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HINF other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HINF.");
    }

    public int CompareTo(HINF other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HINF other) && Equals(other);

    public bool Equals(HINF other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
