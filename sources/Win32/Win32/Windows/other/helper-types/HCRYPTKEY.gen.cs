// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HCRYPTKEY
    : IComparable,
        IComparable<HCRYPTKEY>,
        IEquatable<HCRYPTKEY>,
        IFormattable
{
    public readonly void* Value;

    public HCRYPTKEY(void* value)
    {
        Value = value;
    }

    public static HCRYPTKEY INVALID_VALUE => new HCRYPTKEY((void*)(-1));
    public static HCRYPTKEY NULL => new HCRYPTKEY(null);

    public static bool operator ==(HCRYPTKEY left, HCRYPTKEY right) => left.Value == right.Value;

    public static bool operator !=(HCRYPTKEY left, HCRYPTKEY right) => left.Value != right.Value;

    public static bool operator <(HCRYPTKEY left, HCRYPTKEY right) => left.Value < right.Value;

    public static bool operator <=(HCRYPTKEY left, HCRYPTKEY right) => left.Value <= right.Value;

    public static bool operator >(HCRYPTKEY left, HCRYPTKEY right) => left.Value > right.Value;

    public static bool operator >=(HCRYPTKEY left, HCRYPTKEY right) => left.Value >= right.Value;

    public static explicit operator HCRYPTKEY(void* value) => new HCRYPTKEY(value);

    public static implicit operator void*(HCRYPTKEY value) => value.Value;

    public static explicit operator HCRYPTKEY(HANDLE value) => new HCRYPTKEY(value);

    public static implicit operator HANDLE(HCRYPTKEY value) => new HANDLE(value.Value);

    public static explicit operator HCRYPTKEY(byte value) =>
        new HCRYPTKEY(unchecked((void*)(value)));

    public static explicit operator byte(HCRYPTKEY value) => (byte)(value.Value);

    public static explicit operator HCRYPTKEY(short value) =>
        new HCRYPTKEY(unchecked((void*)(value)));

    public static explicit operator short(HCRYPTKEY value) => (short)(value.Value);

    public static explicit operator HCRYPTKEY(int value) =>
        new HCRYPTKEY(unchecked((void*)(value)));

    public static explicit operator int(HCRYPTKEY value) => (int)(value.Value);

    public static explicit operator HCRYPTKEY(long value) =>
        new HCRYPTKEY(unchecked((void*)(value)));

    public static explicit operator long(HCRYPTKEY value) => (long)(value.Value);

    public static explicit operator HCRYPTKEY(nint value) =>
        new HCRYPTKEY(unchecked((void*)(value)));

    public static implicit operator nint(HCRYPTKEY value) => (nint)(value.Value);

    public static explicit operator HCRYPTKEY(sbyte value) =>
        new HCRYPTKEY(unchecked((void*)(value)));

    public static explicit operator sbyte(HCRYPTKEY value) => (sbyte)(value.Value);

    public static explicit operator HCRYPTKEY(ushort value) =>
        new HCRYPTKEY(unchecked((void*)(value)));

    public static explicit operator ushort(HCRYPTKEY value) => (ushort)(value.Value);

    public static explicit operator HCRYPTKEY(uint value) =>
        new HCRYPTKEY(unchecked((void*)(value)));

    public static explicit operator uint(HCRYPTKEY value) => (uint)(value.Value);

    public static explicit operator HCRYPTKEY(ulong value) =>
        new HCRYPTKEY(unchecked((void*)(value)));

    public static explicit operator ulong(HCRYPTKEY value) => (ulong)(value.Value);

    public static explicit operator HCRYPTKEY(nuint value) =>
        new HCRYPTKEY(unchecked((void*)(value)));

    public static implicit operator nuint(HCRYPTKEY value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HCRYPTKEY other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HCRYPTKEY.");
    }

    public int CompareTo(HCRYPTKEY other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HCRYPTKEY other) && Equals(other);

    public bool Equals(HCRYPTKEY other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
