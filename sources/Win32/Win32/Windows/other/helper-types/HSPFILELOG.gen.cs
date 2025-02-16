// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HSPFILELOG
    : IComparable,
        IComparable<HSPFILELOG>,
        IEquatable<HSPFILELOG>,
        IFormattable
{
    public readonly void* Value;

    public HSPFILELOG(void* value)
    {
        Value = value;
    }

    public static HSPFILELOG INVALID_VALUE => new HSPFILELOG((void*)(-1));
    public static HSPFILELOG NULL => new HSPFILELOG(null);

    public static bool operator ==(HSPFILELOG left, HSPFILELOG right) => left.Value == right.Value;

    public static bool operator !=(HSPFILELOG left, HSPFILELOG right) => left.Value != right.Value;

    public static bool operator <(HSPFILELOG left, HSPFILELOG right) => left.Value < right.Value;

    public static bool operator <=(HSPFILELOG left, HSPFILELOG right) => left.Value <= right.Value;

    public static bool operator >(HSPFILELOG left, HSPFILELOG right) => left.Value > right.Value;

    public static bool operator >=(HSPFILELOG left, HSPFILELOG right) => left.Value >= right.Value;

    public static explicit operator HSPFILELOG(void* value) => new HSPFILELOG(value);

    public static implicit operator void*(HSPFILELOG value) => value.Value;

    public static explicit operator HSPFILELOG(HANDLE value) => new HSPFILELOG(value);

    public static implicit operator HANDLE(HSPFILELOG value) => new HANDLE(value.Value);

    public static explicit operator HSPFILELOG(byte value) =>
        new HSPFILELOG(unchecked((void*)(value)));

    public static explicit operator byte(HSPFILELOG value) => (byte)(value.Value);

    public static explicit operator HSPFILELOG(short value) =>
        new HSPFILELOG(unchecked((void*)(value)));

    public static explicit operator short(HSPFILELOG value) => (short)(value.Value);

    public static explicit operator HSPFILELOG(int value) =>
        new HSPFILELOG(unchecked((void*)(value)));

    public static explicit operator int(HSPFILELOG value) => (int)(value.Value);

    public static explicit operator HSPFILELOG(long value) =>
        new HSPFILELOG(unchecked((void*)(value)));

    public static explicit operator long(HSPFILELOG value) => (long)(value.Value);

    public static explicit operator HSPFILELOG(nint value) =>
        new HSPFILELOG(unchecked((void*)(value)));

    public static implicit operator nint(HSPFILELOG value) => (nint)(value.Value);

    public static explicit operator HSPFILELOG(sbyte value) =>
        new HSPFILELOG(unchecked((void*)(value)));

    public static explicit operator sbyte(HSPFILELOG value) => (sbyte)(value.Value);

    public static explicit operator HSPFILELOG(ushort value) =>
        new HSPFILELOG(unchecked((void*)(value)));

    public static explicit operator ushort(HSPFILELOG value) => (ushort)(value.Value);

    public static explicit operator HSPFILELOG(uint value) =>
        new HSPFILELOG(unchecked((void*)(value)));

    public static explicit operator uint(HSPFILELOG value) => (uint)(value.Value);

    public static explicit operator HSPFILELOG(ulong value) =>
        new HSPFILELOG(unchecked((void*)(value)));

    public static explicit operator ulong(HSPFILELOG value) => (ulong)(value.Value);

    public static explicit operator HSPFILELOG(nuint value) =>
        new HSPFILELOG(unchecked((void*)(value)));

    public static implicit operator nuint(HSPFILELOG value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HSPFILELOG other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HSPFILELOG.");
    }

    public int CompareTo(HSPFILELOG other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HSPFILELOG other) && Equals(other);

    public bool Equals(HSPFILELOG other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
