// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HLOCAL
    : IComparable,
        IComparable<HLOCAL>,
        IEquatable<HLOCAL>,
        IFormattable
{
    public readonly void* Value;

    public HLOCAL(void* value)
    {
        Value = value;
    }

    public static HLOCAL INVALID_VALUE => new HLOCAL((void*)(-1));
    public static HLOCAL NULL => new HLOCAL(null);

    public static bool operator ==(HLOCAL left, HLOCAL right) => left.Value == right.Value;

    public static bool operator !=(HLOCAL left, HLOCAL right) => left.Value != right.Value;

    public static bool operator <(HLOCAL left, HLOCAL right) => left.Value < right.Value;

    public static bool operator <=(HLOCAL left, HLOCAL right) => left.Value <= right.Value;

    public static bool operator >(HLOCAL left, HLOCAL right) => left.Value > right.Value;

    public static bool operator >=(HLOCAL left, HLOCAL right) => left.Value >= right.Value;

    public static explicit operator HLOCAL(void* value) => new HLOCAL(value);

    public static implicit operator void*(HLOCAL value) => value.Value;

    public static explicit operator HLOCAL(HANDLE value) => new HLOCAL(value);

    public static implicit operator HANDLE(HLOCAL value) => new HANDLE(value.Value);

    public static explicit operator HLOCAL(byte value) => new HLOCAL(unchecked((void*)(value)));

    public static explicit operator byte(HLOCAL value) => (byte)(value.Value);

    public static explicit operator HLOCAL(short value) => new HLOCAL(unchecked((void*)(value)));

    public static explicit operator short(HLOCAL value) => (short)(value.Value);

    public static explicit operator HLOCAL(int value) => new HLOCAL(unchecked((void*)(value)));

    public static explicit operator int(HLOCAL value) => (int)(value.Value);

    public static explicit operator HLOCAL(long value) => new HLOCAL(unchecked((void*)(value)));

    public static explicit operator long(HLOCAL value) => (long)(value.Value);

    public static explicit operator HLOCAL(nint value) => new HLOCAL(unchecked((void*)(value)));

    public static implicit operator nint(HLOCAL value) => (nint)(value.Value);

    public static explicit operator HLOCAL(sbyte value) => new HLOCAL(unchecked((void*)(value)));

    public static explicit operator sbyte(HLOCAL value) => (sbyte)(value.Value);

    public static explicit operator HLOCAL(ushort value) => new HLOCAL(unchecked((void*)(value)));

    public static explicit operator ushort(HLOCAL value) => (ushort)(value.Value);

    public static explicit operator HLOCAL(uint value) => new HLOCAL(unchecked((void*)(value)));

    public static explicit operator uint(HLOCAL value) => (uint)(value.Value);

    public static explicit operator HLOCAL(ulong value) => new HLOCAL(unchecked((void*)(value)));

    public static explicit operator ulong(HLOCAL value) => (ulong)(value.Value);

    public static explicit operator HLOCAL(nuint value) => new HLOCAL(unchecked((void*)(value)));

    public static implicit operator nuint(HLOCAL value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HLOCAL other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HLOCAL.");
    }

    public int CompareTo(HLOCAL other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HLOCAL other) && Equals(other);

    public bool Equals(HLOCAL other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
