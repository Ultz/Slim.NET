// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HACCEL
    : IComparable,
        IComparable<HACCEL>,
        IEquatable<HACCEL>,
        IFormattable
{
    public readonly void* Value;

    public HACCEL(void* value)
    {
        Value = value;
    }

    public static HACCEL INVALID_VALUE => new HACCEL((void*)(-1));
    public static HACCEL NULL => new HACCEL(null);

    public static bool operator ==(HACCEL left, HACCEL right) => left.Value == right.Value;

    public static bool operator !=(HACCEL left, HACCEL right) => left.Value != right.Value;

    public static bool operator <(HACCEL left, HACCEL right) => left.Value < right.Value;

    public static bool operator <=(HACCEL left, HACCEL right) => left.Value <= right.Value;

    public static bool operator >(HACCEL left, HACCEL right) => left.Value > right.Value;

    public static bool operator >=(HACCEL left, HACCEL right) => left.Value >= right.Value;

    public static explicit operator HACCEL(void* value) => new HACCEL(value);

    public static implicit operator void*(HACCEL value) => value.Value;

    public static explicit operator HACCEL(HANDLE value) => new HACCEL(value);

    public static implicit operator HANDLE(HACCEL value) => new HANDLE(value.Value);

    public static explicit operator HACCEL(byte value) => new HACCEL(unchecked((void*)(value)));

    public static explicit operator byte(HACCEL value) => (byte)(value.Value);

    public static explicit operator HACCEL(short value) => new HACCEL(unchecked((void*)(value)));

    public static explicit operator short(HACCEL value) => (short)(value.Value);

    public static explicit operator HACCEL(int value) => new HACCEL(unchecked((void*)(value)));

    public static explicit operator int(HACCEL value) => (int)(value.Value);

    public static explicit operator HACCEL(long value) => new HACCEL(unchecked((void*)(value)));

    public static explicit operator long(HACCEL value) => (long)(value.Value);

    public static explicit operator HACCEL(nint value) => new HACCEL(unchecked((void*)(value)));

    public static implicit operator nint(HACCEL value) => (nint)(value.Value);

    public static explicit operator HACCEL(sbyte value) => new HACCEL(unchecked((void*)(value)));

    public static explicit operator sbyte(HACCEL value) => (sbyte)(value.Value);

    public static explicit operator HACCEL(ushort value) => new HACCEL(unchecked((void*)(value)));

    public static explicit operator ushort(HACCEL value) => (ushort)(value.Value);

    public static explicit operator HACCEL(uint value) => new HACCEL(unchecked((void*)(value)));

    public static explicit operator uint(HACCEL value) => (uint)(value.Value);

    public static explicit operator HACCEL(ulong value) => new HACCEL(unchecked((void*)(value)));

    public static explicit operator ulong(HACCEL value) => (ulong)(value.Value);

    public static explicit operator HACCEL(nuint value) => new HACCEL(unchecked((void*)(value)));

    public static implicit operator nuint(HACCEL value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HACCEL other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HACCEL.");
    }

    public int CompareTo(HACCEL other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HACCEL other) && Equals(other);

    public bool Equals(HACCEL other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
