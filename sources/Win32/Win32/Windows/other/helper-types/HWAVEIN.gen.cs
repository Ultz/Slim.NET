// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HWAVEIN
    : IComparable,
        IComparable<HWAVEIN>,
        IEquatable<HWAVEIN>,
        IFormattable
{
    public readonly void* Value;

    public HWAVEIN(void* value)
    {
        Value = value;
    }

    public static HWAVEIN INVALID_VALUE => new HWAVEIN((void*)(-1));
    public static HWAVEIN NULL => new HWAVEIN(null);

    public static bool operator ==(HWAVEIN left, HWAVEIN right) => left.Value == right.Value;

    public static bool operator !=(HWAVEIN left, HWAVEIN right) => left.Value != right.Value;

    public static bool operator <(HWAVEIN left, HWAVEIN right) => left.Value < right.Value;

    public static bool operator <=(HWAVEIN left, HWAVEIN right) => left.Value <= right.Value;

    public static bool operator >(HWAVEIN left, HWAVEIN right) => left.Value > right.Value;

    public static bool operator >=(HWAVEIN left, HWAVEIN right) => left.Value >= right.Value;

    public static explicit operator HWAVEIN(void* value) => new HWAVEIN(value);

    public static implicit operator void*(HWAVEIN value) => value.Value;

    public static explicit operator HWAVEIN(HANDLE value) => new HWAVEIN(value);

    public static implicit operator HANDLE(HWAVEIN value) => new HANDLE(value.Value);

    public static explicit operator HWAVEIN(byte value) => new HWAVEIN(unchecked((void*)(value)));

    public static explicit operator byte(HWAVEIN value) => (byte)(value.Value);

    public static explicit operator HWAVEIN(short value) => new HWAVEIN(unchecked((void*)(value)));

    public static explicit operator short(HWAVEIN value) => (short)(value.Value);

    public static explicit operator HWAVEIN(int value) => new HWAVEIN(unchecked((void*)(value)));

    public static explicit operator int(HWAVEIN value) => (int)(value.Value);

    public static explicit operator HWAVEIN(long value) => new HWAVEIN(unchecked((void*)(value)));

    public static explicit operator long(HWAVEIN value) => (long)(value.Value);

    public static explicit operator HWAVEIN(nint value) => new HWAVEIN(unchecked((void*)(value)));

    public static implicit operator nint(HWAVEIN value) => (nint)(value.Value);

    public static explicit operator HWAVEIN(sbyte value) => new HWAVEIN(unchecked((void*)(value)));

    public static explicit operator sbyte(HWAVEIN value) => (sbyte)(value.Value);

    public static explicit operator HWAVEIN(ushort value) => new HWAVEIN(unchecked((void*)(value)));

    public static explicit operator ushort(HWAVEIN value) => (ushort)(value.Value);

    public static explicit operator HWAVEIN(uint value) => new HWAVEIN(unchecked((void*)(value)));

    public static explicit operator uint(HWAVEIN value) => (uint)(value.Value);

    public static explicit operator HWAVEIN(ulong value) => new HWAVEIN(unchecked((void*)(value)));

    public static explicit operator ulong(HWAVEIN value) => (ulong)(value.Value);

    public static explicit operator HWAVEIN(nuint value) => new HWAVEIN(unchecked((void*)(value)));

    public static implicit operator nuint(HWAVEIN value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HWAVEIN other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HWAVEIN.");
    }

    public int CompareTo(HWAVEIN other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HWAVEIN other) && Equals(other);

    public bool Equals(HWAVEIN other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
