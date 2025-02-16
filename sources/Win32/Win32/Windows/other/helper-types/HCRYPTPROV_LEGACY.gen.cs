// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HCRYPTPROV_LEGACY
    : IComparable,
        IComparable<HCRYPTPROV_LEGACY>,
        IEquatable<HCRYPTPROV_LEGACY>,
        IFormattable
{
    public readonly void* Value;

    public HCRYPTPROV_LEGACY(void* value)
    {
        Value = value;
    }

    public static HCRYPTPROV_LEGACY INVALID_VALUE => new HCRYPTPROV_LEGACY((void*)(-1));
    public static HCRYPTPROV_LEGACY NULL => new HCRYPTPROV_LEGACY(null);

    public static bool operator ==(HCRYPTPROV_LEGACY left, HCRYPTPROV_LEGACY right) =>
        left.Value == right.Value;

    public static bool operator !=(HCRYPTPROV_LEGACY left, HCRYPTPROV_LEGACY right) =>
        left.Value != right.Value;

    public static bool operator <(HCRYPTPROV_LEGACY left, HCRYPTPROV_LEGACY right) =>
        left.Value < right.Value;

    public static bool operator <=(HCRYPTPROV_LEGACY left, HCRYPTPROV_LEGACY right) =>
        left.Value <= right.Value;

    public static bool operator >(HCRYPTPROV_LEGACY left, HCRYPTPROV_LEGACY right) =>
        left.Value > right.Value;

    public static bool operator >=(HCRYPTPROV_LEGACY left, HCRYPTPROV_LEGACY right) =>
        left.Value >= right.Value;

    public static explicit operator HCRYPTPROV_LEGACY(void* value) => new HCRYPTPROV_LEGACY(value);

    public static implicit operator void*(HCRYPTPROV_LEGACY value) => value.Value;

    public static explicit operator HCRYPTPROV_LEGACY(HANDLE value) => new HCRYPTPROV_LEGACY(value);

    public static implicit operator HANDLE(HCRYPTPROV_LEGACY value) => new HANDLE(value.Value);

    public static explicit operator HCRYPTPROV_LEGACY(byte value) =>
        new HCRYPTPROV_LEGACY(unchecked((void*)(value)));

    public static explicit operator byte(HCRYPTPROV_LEGACY value) => (byte)(value.Value);

    public static explicit operator HCRYPTPROV_LEGACY(short value) =>
        new HCRYPTPROV_LEGACY(unchecked((void*)(value)));

    public static explicit operator short(HCRYPTPROV_LEGACY value) => (short)(value.Value);

    public static explicit operator HCRYPTPROV_LEGACY(int value) =>
        new HCRYPTPROV_LEGACY(unchecked((void*)(value)));

    public static explicit operator int(HCRYPTPROV_LEGACY value) => (int)(value.Value);

    public static explicit operator HCRYPTPROV_LEGACY(long value) =>
        new HCRYPTPROV_LEGACY(unchecked((void*)(value)));

    public static explicit operator long(HCRYPTPROV_LEGACY value) => (long)(value.Value);

    public static explicit operator HCRYPTPROV_LEGACY(nint value) =>
        new HCRYPTPROV_LEGACY(unchecked((void*)(value)));

    public static implicit operator nint(HCRYPTPROV_LEGACY value) => (nint)(value.Value);

    public static explicit operator HCRYPTPROV_LEGACY(sbyte value) =>
        new HCRYPTPROV_LEGACY(unchecked((void*)(value)));

    public static explicit operator sbyte(HCRYPTPROV_LEGACY value) => (sbyte)(value.Value);

    public static explicit operator HCRYPTPROV_LEGACY(ushort value) =>
        new HCRYPTPROV_LEGACY(unchecked((void*)(value)));

    public static explicit operator ushort(HCRYPTPROV_LEGACY value) => (ushort)(value.Value);

    public static explicit operator HCRYPTPROV_LEGACY(uint value) =>
        new HCRYPTPROV_LEGACY(unchecked((void*)(value)));

    public static explicit operator uint(HCRYPTPROV_LEGACY value) => (uint)(value.Value);

    public static explicit operator HCRYPTPROV_LEGACY(ulong value) =>
        new HCRYPTPROV_LEGACY(unchecked((void*)(value)));

    public static explicit operator ulong(HCRYPTPROV_LEGACY value) => (ulong)(value.Value);

    public static explicit operator HCRYPTPROV_LEGACY(nuint value) =>
        new HCRYPTPROV_LEGACY(unchecked((void*)(value)));

    public static implicit operator nuint(HCRYPTPROV_LEGACY value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HCRYPTPROV_LEGACY other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HCRYPTPROV_LEGACY.");
    }

    public int CompareTo(HCRYPTPROV_LEGACY other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HCRYPTPROV_LEGACY other) && Equals(other);

    public bool Equals(HCRYPTPROV_LEGACY other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
