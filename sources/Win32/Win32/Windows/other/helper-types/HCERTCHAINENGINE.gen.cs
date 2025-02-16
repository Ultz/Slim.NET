// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HCERTCHAINENGINE
    : IComparable,
        IComparable<HCERTCHAINENGINE>,
        IEquatable<HCERTCHAINENGINE>,
        IFormattable
{
    public readonly void* Value;

    public HCERTCHAINENGINE(void* value)
    {
        Value = value;
    }

    public static HCERTCHAINENGINE INVALID_VALUE => new HCERTCHAINENGINE((void*)(-1));
    public static HCERTCHAINENGINE NULL => new HCERTCHAINENGINE(null);

    public static bool operator ==(HCERTCHAINENGINE left, HCERTCHAINENGINE right) =>
        left.Value == right.Value;

    public static bool operator !=(HCERTCHAINENGINE left, HCERTCHAINENGINE right) =>
        left.Value != right.Value;

    public static bool operator <(HCERTCHAINENGINE left, HCERTCHAINENGINE right) =>
        left.Value < right.Value;

    public static bool operator <=(HCERTCHAINENGINE left, HCERTCHAINENGINE right) =>
        left.Value <= right.Value;

    public static bool operator >(HCERTCHAINENGINE left, HCERTCHAINENGINE right) =>
        left.Value > right.Value;

    public static bool operator >=(HCERTCHAINENGINE left, HCERTCHAINENGINE right) =>
        left.Value >= right.Value;

    public static explicit operator HCERTCHAINENGINE(void* value) => new HCERTCHAINENGINE(value);

    public static implicit operator void*(HCERTCHAINENGINE value) => value.Value;

    public static explicit operator HCERTCHAINENGINE(HANDLE value) => new HCERTCHAINENGINE(value);

    public static implicit operator HANDLE(HCERTCHAINENGINE value) => new HANDLE(value.Value);

    public static explicit operator HCERTCHAINENGINE(byte value) =>
        new HCERTCHAINENGINE(unchecked((void*)(value)));

    public static explicit operator byte(HCERTCHAINENGINE value) => (byte)(value.Value);

    public static explicit operator HCERTCHAINENGINE(short value) =>
        new HCERTCHAINENGINE(unchecked((void*)(value)));

    public static explicit operator short(HCERTCHAINENGINE value) => (short)(value.Value);

    public static explicit operator HCERTCHAINENGINE(int value) =>
        new HCERTCHAINENGINE(unchecked((void*)(value)));

    public static explicit operator int(HCERTCHAINENGINE value) => (int)(value.Value);

    public static explicit operator HCERTCHAINENGINE(long value) =>
        new HCERTCHAINENGINE(unchecked((void*)(value)));

    public static explicit operator long(HCERTCHAINENGINE value) => (long)(value.Value);

    public static explicit operator HCERTCHAINENGINE(nint value) =>
        new HCERTCHAINENGINE(unchecked((void*)(value)));

    public static implicit operator nint(HCERTCHAINENGINE value) => (nint)(value.Value);

    public static explicit operator HCERTCHAINENGINE(sbyte value) =>
        new HCERTCHAINENGINE(unchecked((void*)(value)));

    public static explicit operator sbyte(HCERTCHAINENGINE value) => (sbyte)(value.Value);

    public static explicit operator HCERTCHAINENGINE(ushort value) =>
        new HCERTCHAINENGINE(unchecked((void*)(value)));

    public static explicit operator ushort(HCERTCHAINENGINE value) => (ushort)(value.Value);

    public static explicit operator HCERTCHAINENGINE(uint value) =>
        new HCERTCHAINENGINE(unchecked((void*)(value)));

    public static explicit operator uint(HCERTCHAINENGINE value) => (uint)(value.Value);

    public static explicit operator HCERTCHAINENGINE(ulong value) =>
        new HCERTCHAINENGINE(unchecked((void*)(value)));

    public static explicit operator ulong(HCERTCHAINENGINE value) => (ulong)(value.Value);

    public static explicit operator HCERTCHAINENGINE(nuint value) =>
        new HCERTCHAINENGINE(unchecked((void*)(value)));

    public static implicit operator nuint(HCERTCHAINENGINE value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HCERTCHAINENGINE other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HCERTCHAINENGINE.");
    }

    public int CompareTo(HCERTCHAINENGINE other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HCERTCHAINENGINE other) && Equals(other);

    public bool Equals(HCERTCHAINENGINE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
