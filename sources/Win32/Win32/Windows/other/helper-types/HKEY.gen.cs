// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HKEY
    : IComparable,
        IComparable<HKEY>,
        IEquatable<HKEY>,
        IFormattable
{
    public readonly void* Value;

    public HKEY(void* value)
    {
        Value = value;
    }

    public static HKEY INVALID_VALUE => new HKEY((void*)(-1));
    public static HKEY NULL => new HKEY(null);

    public static bool operator ==(HKEY left, HKEY right) => left.Value == right.Value;

    public static bool operator !=(HKEY left, HKEY right) => left.Value != right.Value;

    public static bool operator <(HKEY left, HKEY right) => left.Value < right.Value;

    public static bool operator <=(HKEY left, HKEY right) => left.Value <= right.Value;

    public static bool operator >(HKEY left, HKEY right) => left.Value > right.Value;

    public static bool operator >=(HKEY left, HKEY right) => left.Value >= right.Value;

    public static explicit operator HKEY(void* value) => new HKEY(value);

    public static implicit operator void*(HKEY value) => value.Value;

    public static explicit operator HKEY(HANDLE value) => new HKEY(value);

    public static implicit operator HANDLE(HKEY value) => new HANDLE(value.Value);

    public static explicit operator HKEY(byte value) => new HKEY(unchecked((void*)(value)));

    public static explicit operator byte(HKEY value) => (byte)(value.Value);

    public static explicit operator HKEY(short value) => new HKEY(unchecked((void*)(value)));

    public static explicit operator short(HKEY value) => (short)(value.Value);

    public static explicit operator HKEY(int value) => new HKEY(unchecked((void*)(value)));

    public static explicit operator int(HKEY value) => (int)(value.Value);

    public static explicit operator HKEY(long value) => new HKEY(unchecked((void*)(value)));

    public static explicit operator long(HKEY value) => (long)(value.Value);

    public static explicit operator HKEY(nint value) => new HKEY(unchecked((void*)(value)));

    public static implicit operator nint(HKEY value) => (nint)(value.Value);

    public static explicit operator HKEY(sbyte value) => new HKEY(unchecked((void*)(value)));

    public static explicit operator sbyte(HKEY value) => (sbyte)(value.Value);

    public static explicit operator HKEY(ushort value) => new HKEY(unchecked((void*)(value)));

    public static explicit operator ushort(HKEY value) => (ushort)(value.Value);

    public static explicit operator HKEY(uint value) => new HKEY(unchecked((void*)(value)));

    public static explicit operator uint(HKEY value) => (uint)(value.Value);

    public static explicit operator HKEY(ulong value) => new HKEY(unchecked((void*)(value)));

    public static explicit operator ulong(HKEY value) => (ulong)(value.Value);

    public static explicit operator HKEY(nuint value) => new HKEY(unchecked((void*)(value)));

    public static implicit operator nuint(HKEY value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HKEY other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HKEY.");
    }

    public int CompareTo(HKEY other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HKEY other) && Equals(other);

    public bool Equals(HKEY other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
