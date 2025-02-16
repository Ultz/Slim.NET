// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HMIDI
    : IComparable,
        IComparable<HMIDI>,
        IEquatable<HMIDI>,
        IFormattable
{
    public readonly void* Value;

    public HMIDI(void* value)
    {
        Value = value;
    }

    public static HMIDI INVALID_VALUE => new HMIDI((void*)(-1));
    public static HMIDI NULL => new HMIDI(null);

    public static bool operator ==(HMIDI left, HMIDI right) => left.Value == right.Value;

    public static bool operator !=(HMIDI left, HMIDI right) => left.Value != right.Value;

    public static bool operator <(HMIDI left, HMIDI right) => left.Value < right.Value;

    public static bool operator <=(HMIDI left, HMIDI right) => left.Value <= right.Value;

    public static bool operator >(HMIDI left, HMIDI right) => left.Value > right.Value;

    public static bool operator >=(HMIDI left, HMIDI right) => left.Value >= right.Value;

    public static explicit operator HMIDI(void* value) => new HMIDI(value);

    public static implicit operator void*(HMIDI value) => value.Value;

    public static explicit operator HMIDI(HANDLE value) => new HMIDI(value);

    public static implicit operator HANDLE(HMIDI value) => new HANDLE(value.Value);

    public static explicit operator HMIDI(byte value) => new HMIDI(unchecked((void*)(value)));

    public static explicit operator byte(HMIDI value) => (byte)(value.Value);

    public static explicit operator HMIDI(short value) => new HMIDI(unchecked((void*)(value)));

    public static explicit operator short(HMIDI value) => (short)(value.Value);

    public static explicit operator HMIDI(int value) => new HMIDI(unchecked((void*)(value)));

    public static explicit operator int(HMIDI value) => (int)(value.Value);

    public static explicit operator HMIDI(long value) => new HMIDI(unchecked((void*)(value)));

    public static explicit operator long(HMIDI value) => (long)(value.Value);

    public static explicit operator HMIDI(nint value) => new HMIDI(unchecked((void*)(value)));

    public static implicit operator nint(HMIDI value) => (nint)(value.Value);

    public static explicit operator HMIDI(sbyte value) => new HMIDI(unchecked((void*)(value)));

    public static explicit operator sbyte(HMIDI value) => (sbyte)(value.Value);

    public static explicit operator HMIDI(ushort value) => new HMIDI(unchecked((void*)(value)));

    public static explicit operator ushort(HMIDI value) => (ushort)(value.Value);

    public static explicit operator HMIDI(uint value) => new HMIDI(unchecked((void*)(value)));

    public static explicit operator uint(HMIDI value) => (uint)(value.Value);

    public static explicit operator HMIDI(ulong value) => new HMIDI(unchecked((void*)(value)));

    public static explicit operator ulong(HMIDI value) => (ulong)(value.Value);

    public static explicit operator HMIDI(nuint value) => new HMIDI(unchecked((void*)(value)));

    public static implicit operator nuint(HMIDI value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HMIDI other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HMIDI.");
    }

    public int CompareTo(HMIDI other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HMIDI other) && Equals(other);

    public bool Equals(HMIDI other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
