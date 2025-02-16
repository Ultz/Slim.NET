// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct COMPRESSOR_HANDLE
    : IComparable,
        IComparable<COMPRESSOR_HANDLE>,
        IEquatable<COMPRESSOR_HANDLE>,
        IFormattable
{
    public readonly void* Value;

    public COMPRESSOR_HANDLE(void* value)
    {
        Value = value;
    }

    public static COMPRESSOR_HANDLE INVALID_VALUE => new COMPRESSOR_HANDLE((void*)(-1));
    public static COMPRESSOR_HANDLE NULL => new COMPRESSOR_HANDLE(null);

    public static bool operator ==(COMPRESSOR_HANDLE left, COMPRESSOR_HANDLE right) =>
        left.Value == right.Value;

    public static bool operator !=(COMPRESSOR_HANDLE left, COMPRESSOR_HANDLE right) =>
        left.Value != right.Value;

    public static bool operator <(COMPRESSOR_HANDLE left, COMPRESSOR_HANDLE right) =>
        left.Value < right.Value;

    public static bool operator <=(COMPRESSOR_HANDLE left, COMPRESSOR_HANDLE right) =>
        left.Value <= right.Value;

    public static bool operator >(COMPRESSOR_HANDLE left, COMPRESSOR_HANDLE right) =>
        left.Value > right.Value;

    public static bool operator >=(COMPRESSOR_HANDLE left, COMPRESSOR_HANDLE right) =>
        left.Value >= right.Value;

    public static explicit operator COMPRESSOR_HANDLE(void* value) => new COMPRESSOR_HANDLE(value);

    public static implicit operator void*(COMPRESSOR_HANDLE value) => value.Value;

    public static explicit operator COMPRESSOR_HANDLE(HANDLE value) => new COMPRESSOR_HANDLE(value);

    public static implicit operator HANDLE(COMPRESSOR_HANDLE value) => new HANDLE(value.Value);

    public static explicit operator COMPRESSOR_HANDLE(byte value) =>
        new COMPRESSOR_HANDLE(unchecked((void*)(value)));

    public static explicit operator byte(COMPRESSOR_HANDLE value) => (byte)(value.Value);

    public static explicit operator COMPRESSOR_HANDLE(short value) =>
        new COMPRESSOR_HANDLE(unchecked((void*)(value)));

    public static explicit operator short(COMPRESSOR_HANDLE value) => (short)(value.Value);

    public static explicit operator COMPRESSOR_HANDLE(int value) =>
        new COMPRESSOR_HANDLE(unchecked((void*)(value)));

    public static explicit operator int(COMPRESSOR_HANDLE value) => (int)(value.Value);

    public static explicit operator COMPRESSOR_HANDLE(long value) =>
        new COMPRESSOR_HANDLE(unchecked((void*)(value)));

    public static explicit operator long(COMPRESSOR_HANDLE value) => (long)(value.Value);

    public static explicit operator COMPRESSOR_HANDLE(nint value) =>
        new COMPRESSOR_HANDLE(unchecked((void*)(value)));

    public static implicit operator nint(COMPRESSOR_HANDLE value) => (nint)(value.Value);

    public static explicit operator COMPRESSOR_HANDLE(sbyte value) =>
        new COMPRESSOR_HANDLE(unchecked((void*)(value)));

    public static explicit operator sbyte(COMPRESSOR_HANDLE value) => (sbyte)(value.Value);

    public static explicit operator COMPRESSOR_HANDLE(ushort value) =>
        new COMPRESSOR_HANDLE(unchecked((void*)(value)));

    public static explicit operator ushort(COMPRESSOR_HANDLE value) => (ushort)(value.Value);

    public static explicit operator COMPRESSOR_HANDLE(uint value) =>
        new COMPRESSOR_HANDLE(unchecked((void*)(value)));

    public static explicit operator uint(COMPRESSOR_HANDLE value) => (uint)(value.Value);

    public static explicit operator COMPRESSOR_HANDLE(ulong value) =>
        new COMPRESSOR_HANDLE(unchecked((void*)(value)));

    public static explicit operator ulong(COMPRESSOR_HANDLE value) => (ulong)(value.Value);

    public static explicit operator COMPRESSOR_HANDLE(nuint value) =>
        new COMPRESSOR_HANDLE(unchecked((void*)(value)));

    public static implicit operator nuint(COMPRESSOR_HANDLE value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is COMPRESSOR_HANDLE other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of COMPRESSOR_HANDLE.");
    }

    public int CompareTo(COMPRESSOR_HANDLE other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is COMPRESSOR_HANDLE other) && Equals(other);

    public bool Equals(COMPRESSOR_HANDLE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
