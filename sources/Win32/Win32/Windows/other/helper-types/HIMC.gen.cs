// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HIMC
    : IComparable,
        IComparable<HIMC>,
        IEquatable<HIMC>,
        IFormattable
{
    public readonly void* Value;

    public HIMC(void* value)
    {
        Value = value;
    }

    public static HIMC INVALID_VALUE => new HIMC((void*)(-1));
    public static HIMC NULL => new HIMC(null);

    public static bool operator ==(HIMC left, HIMC right) => left.Value == right.Value;

    public static bool operator !=(HIMC left, HIMC right) => left.Value != right.Value;

    public static bool operator <(HIMC left, HIMC right) => left.Value < right.Value;

    public static bool operator <=(HIMC left, HIMC right) => left.Value <= right.Value;

    public static bool operator >(HIMC left, HIMC right) => left.Value > right.Value;

    public static bool operator >=(HIMC left, HIMC right) => left.Value >= right.Value;

    public static explicit operator HIMC(void* value) => new HIMC(value);

    public static implicit operator void*(HIMC value) => value.Value;

    public static explicit operator HIMC(HANDLE value) => new HIMC(value);

    public static implicit operator HANDLE(HIMC value) => new HANDLE(value.Value);

    public static explicit operator HIMC(byte value) => new HIMC(unchecked((void*)(value)));

    public static explicit operator byte(HIMC value) => (byte)(value.Value);

    public static explicit operator HIMC(short value) => new HIMC(unchecked((void*)(value)));

    public static explicit operator short(HIMC value) => (short)(value.Value);

    public static explicit operator HIMC(int value) => new HIMC(unchecked((void*)(value)));

    public static explicit operator int(HIMC value) => (int)(value.Value);

    public static explicit operator HIMC(long value) => new HIMC(unchecked((void*)(value)));

    public static explicit operator long(HIMC value) => (long)(value.Value);

    public static explicit operator HIMC(nint value) => new HIMC(unchecked((void*)(value)));

    public static implicit operator nint(HIMC value) => (nint)(value.Value);

    public static explicit operator HIMC(sbyte value) => new HIMC(unchecked((void*)(value)));

    public static explicit operator sbyte(HIMC value) => (sbyte)(value.Value);

    public static explicit operator HIMC(ushort value) => new HIMC(unchecked((void*)(value)));

    public static explicit operator ushort(HIMC value) => (ushort)(value.Value);

    public static explicit operator HIMC(uint value) => new HIMC(unchecked((void*)(value)));

    public static explicit operator uint(HIMC value) => (uint)(value.Value);

    public static explicit operator HIMC(ulong value) => new HIMC(unchecked((void*)(value)));

    public static explicit operator ulong(HIMC value) => (ulong)(value.Value);

    public static explicit operator HIMC(nuint value) => new HIMC(unchecked((void*)(value)));

    public static implicit operator nuint(HIMC value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HIMC other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HIMC.");
    }

    public int CompareTo(HIMC other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HIMC other) && Equals(other);

    public bool Equals(HIMC other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
