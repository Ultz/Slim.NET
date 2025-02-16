// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HUSKEY
    : IComparable,
        IComparable<HUSKEY>,
        IEquatable<HUSKEY>,
        IFormattable
{
    public readonly void* Value;

    public HUSKEY(void* value)
    {
        Value = value;
    }

    public static HUSKEY INVALID_VALUE => new HUSKEY((void*)(-1));
    public static HUSKEY NULL => new HUSKEY(null);

    public static bool operator ==(HUSKEY left, HUSKEY right) => left.Value == right.Value;

    public static bool operator !=(HUSKEY left, HUSKEY right) => left.Value != right.Value;

    public static bool operator <(HUSKEY left, HUSKEY right) => left.Value < right.Value;

    public static bool operator <=(HUSKEY left, HUSKEY right) => left.Value <= right.Value;

    public static bool operator >(HUSKEY left, HUSKEY right) => left.Value > right.Value;

    public static bool operator >=(HUSKEY left, HUSKEY right) => left.Value >= right.Value;

    public static explicit operator HUSKEY(void* value) => new HUSKEY(value);

    public static implicit operator void*(HUSKEY value) => value.Value;

    public static explicit operator HUSKEY(HANDLE value) => new HUSKEY(value);

    public static implicit operator HANDLE(HUSKEY value) => new HANDLE(value.Value);

    public static explicit operator HUSKEY(byte value) => new HUSKEY(unchecked((void*)(value)));

    public static explicit operator byte(HUSKEY value) => (byte)(value.Value);

    public static explicit operator HUSKEY(short value) => new HUSKEY(unchecked((void*)(value)));

    public static explicit operator short(HUSKEY value) => (short)(value.Value);

    public static explicit operator HUSKEY(int value) => new HUSKEY(unchecked((void*)(value)));

    public static explicit operator int(HUSKEY value) => (int)(value.Value);

    public static explicit operator HUSKEY(long value) => new HUSKEY(unchecked((void*)(value)));

    public static explicit operator long(HUSKEY value) => (long)(value.Value);

    public static explicit operator HUSKEY(nint value) => new HUSKEY(unchecked((void*)(value)));

    public static implicit operator nint(HUSKEY value) => (nint)(value.Value);

    public static explicit operator HUSKEY(sbyte value) => new HUSKEY(unchecked((void*)(value)));

    public static explicit operator sbyte(HUSKEY value) => (sbyte)(value.Value);

    public static explicit operator HUSKEY(ushort value) => new HUSKEY(unchecked((void*)(value)));

    public static explicit operator ushort(HUSKEY value) => (ushort)(value.Value);

    public static explicit operator HUSKEY(uint value) => new HUSKEY(unchecked((void*)(value)));

    public static explicit operator uint(HUSKEY value) => (uint)(value.Value);

    public static explicit operator HUSKEY(ulong value) => new HUSKEY(unchecked((void*)(value)));

    public static explicit operator ulong(HUSKEY value) => (ulong)(value.Value);

    public static explicit operator HUSKEY(nuint value) => new HUSKEY(unchecked((void*)(value)));

    public static implicit operator nuint(HUSKEY value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HUSKEY other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HUSKEY.");
    }

    public int CompareTo(HUSKEY other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HUSKEY other) && Equals(other);

    public bool Equals(HUSKEY other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
