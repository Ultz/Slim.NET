// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HCOMDB
    : IComparable,
        IComparable<HCOMDB>,
        IEquatable<HCOMDB>,
        IFormattable
{
    public readonly void* Value;

    public HCOMDB(void* value)
    {
        Value = value;
    }

    public static HCOMDB INVALID_VALUE => new HCOMDB((void*)(-1));
    public static HCOMDB NULL => new HCOMDB(null);

    public static bool operator ==(HCOMDB left, HCOMDB right) => left.Value == right.Value;

    public static bool operator !=(HCOMDB left, HCOMDB right) => left.Value != right.Value;

    public static bool operator <(HCOMDB left, HCOMDB right) => left.Value < right.Value;

    public static bool operator <=(HCOMDB left, HCOMDB right) => left.Value <= right.Value;

    public static bool operator >(HCOMDB left, HCOMDB right) => left.Value > right.Value;

    public static bool operator >=(HCOMDB left, HCOMDB right) => left.Value >= right.Value;

    public static explicit operator HCOMDB(void* value) => new HCOMDB(value);

    public static implicit operator void*(HCOMDB value) => value.Value;

    public static explicit operator HCOMDB(HANDLE value) => new HCOMDB(value);

    public static implicit operator HANDLE(HCOMDB value) => new HANDLE(value.Value);

    public static explicit operator HCOMDB(byte value) => new HCOMDB(unchecked((void*)(value)));

    public static explicit operator byte(HCOMDB value) => (byte)(value.Value);

    public static explicit operator HCOMDB(short value) => new HCOMDB(unchecked((void*)(value)));

    public static explicit operator short(HCOMDB value) => (short)(value.Value);

    public static explicit operator HCOMDB(int value) => new HCOMDB(unchecked((void*)(value)));

    public static explicit operator int(HCOMDB value) => (int)(value.Value);

    public static explicit operator HCOMDB(long value) => new HCOMDB(unchecked((void*)(value)));

    public static explicit operator long(HCOMDB value) => (long)(value.Value);

    public static explicit operator HCOMDB(nint value) => new HCOMDB(unchecked((void*)(value)));

    public static implicit operator nint(HCOMDB value) => (nint)(value.Value);

    public static explicit operator HCOMDB(sbyte value) => new HCOMDB(unchecked((void*)(value)));

    public static explicit operator sbyte(HCOMDB value) => (sbyte)(value.Value);

    public static explicit operator HCOMDB(ushort value) => new HCOMDB(unchecked((void*)(value)));

    public static explicit operator ushort(HCOMDB value) => (ushort)(value.Value);

    public static explicit operator HCOMDB(uint value) => new HCOMDB(unchecked((void*)(value)));

    public static explicit operator uint(HCOMDB value) => (uint)(value.Value);

    public static explicit operator HCOMDB(ulong value) => new HCOMDB(unchecked((void*)(value)));

    public static explicit operator ulong(HCOMDB value) => (ulong)(value.Value);

    public static explicit operator HCOMDB(nuint value) => new HCOMDB(unchecked((void*)(value)));

    public static implicit operator nuint(HCOMDB value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HCOMDB other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HCOMDB.");
    }

    public int CompareTo(HCOMDB other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HCOMDB other) && Equals(other);

    public bool Equals(HCOMDB other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
