// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HHOOK
    : IComparable,
        IComparable<HHOOK>,
        IEquatable<HHOOK>,
        IFormattable
{
    public readonly void* Value;

    public HHOOK(void* value)
    {
        Value = value;
    }

    public static HHOOK INVALID_VALUE => new HHOOK((void*)(-1));
    public static HHOOK NULL => new HHOOK(null);

    public static bool operator ==(HHOOK left, HHOOK right) => left.Value == right.Value;

    public static bool operator !=(HHOOK left, HHOOK right) => left.Value != right.Value;

    public static bool operator <(HHOOK left, HHOOK right) => left.Value < right.Value;

    public static bool operator <=(HHOOK left, HHOOK right) => left.Value <= right.Value;

    public static bool operator >(HHOOK left, HHOOK right) => left.Value > right.Value;

    public static bool operator >=(HHOOK left, HHOOK right) => left.Value >= right.Value;

    public static explicit operator HHOOK(void* value) => new HHOOK(value);

    public static implicit operator void*(HHOOK value) => value.Value;

    public static explicit operator HHOOK(HANDLE value) => new HHOOK(value);

    public static implicit operator HANDLE(HHOOK value) => new HANDLE(value.Value);

    public static explicit operator HHOOK(byte value) => new HHOOK(unchecked((void*)(value)));

    public static explicit operator byte(HHOOK value) => (byte)(value.Value);

    public static explicit operator HHOOK(short value) => new HHOOK(unchecked((void*)(value)));

    public static explicit operator short(HHOOK value) => (short)(value.Value);

    public static explicit operator HHOOK(int value) => new HHOOK(unchecked((void*)(value)));

    public static explicit operator int(HHOOK value) => (int)(value.Value);

    public static explicit operator HHOOK(long value) => new HHOOK(unchecked((void*)(value)));

    public static explicit operator long(HHOOK value) => (long)(value.Value);

    public static explicit operator HHOOK(nint value) => new HHOOK(unchecked((void*)(value)));

    public static implicit operator nint(HHOOK value) => (nint)(value.Value);

    public static explicit operator HHOOK(sbyte value) => new HHOOK(unchecked((void*)(value)));

    public static explicit operator sbyte(HHOOK value) => (sbyte)(value.Value);

    public static explicit operator HHOOK(ushort value) => new HHOOK(unchecked((void*)(value)));

    public static explicit operator ushort(HHOOK value) => (ushort)(value.Value);

    public static explicit operator HHOOK(uint value) => new HHOOK(unchecked((void*)(value)));

    public static explicit operator uint(HHOOK value) => (uint)(value.Value);

    public static explicit operator HHOOK(ulong value) => new HHOOK(unchecked((void*)(value)));

    public static explicit operator ulong(HHOOK value) => (ulong)(value.Value);

    public static explicit operator HHOOK(nuint value) => new HHOOK(unchecked((void*)(value)));

    public static implicit operator nuint(HHOOK value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HHOOK other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HHOOK.");
    }

    public int CompareTo(HHOOK other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HHOOK other) && Equals(other);

    public bool Equals(HHOOK other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
