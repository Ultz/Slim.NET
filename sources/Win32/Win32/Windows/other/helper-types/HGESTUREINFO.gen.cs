// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HGESTUREINFO
    : IComparable,
        IComparable<HGESTUREINFO>,
        IEquatable<HGESTUREINFO>,
        IFormattable
{
    public readonly void* Value;

    public HGESTUREINFO(void* value)
    {
        Value = value;
    }

    public static HGESTUREINFO INVALID_VALUE => new HGESTUREINFO((void*)(-1));
    public static HGESTUREINFO NULL => new HGESTUREINFO(null);

    public static bool operator ==(HGESTUREINFO left, HGESTUREINFO right) =>
        left.Value == right.Value;

    public static bool operator !=(HGESTUREINFO left, HGESTUREINFO right) =>
        left.Value != right.Value;

    public static bool operator <(HGESTUREINFO left, HGESTUREINFO right) =>
        left.Value < right.Value;

    public static bool operator <=(HGESTUREINFO left, HGESTUREINFO right) =>
        left.Value <= right.Value;

    public static bool operator >(HGESTUREINFO left, HGESTUREINFO right) =>
        left.Value > right.Value;

    public static bool operator >=(HGESTUREINFO left, HGESTUREINFO right) =>
        left.Value >= right.Value;

    public static explicit operator HGESTUREINFO(void* value) => new HGESTUREINFO(value);

    public static implicit operator void*(HGESTUREINFO value) => value.Value;

    public static explicit operator HGESTUREINFO(HANDLE value) => new HGESTUREINFO(value);

    public static implicit operator HANDLE(HGESTUREINFO value) => new HANDLE(value.Value);

    public static explicit operator HGESTUREINFO(byte value) =>
        new HGESTUREINFO(unchecked((void*)(value)));

    public static explicit operator byte(HGESTUREINFO value) => (byte)(value.Value);

    public static explicit operator HGESTUREINFO(short value) =>
        new HGESTUREINFO(unchecked((void*)(value)));

    public static explicit operator short(HGESTUREINFO value) => (short)(value.Value);

    public static explicit operator HGESTUREINFO(int value) =>
        new HGESTUREINFO(unchecked((void*)(value)));

    public static explicit operator int(HGESTUREINFO value) => (int)(value.Value);

    public static explicit operator HGESTUREINFO(long value) =>
        new HGESTUREINFO(unchecked((void*)(value)));

    public static explicit operator long(HGESTUREINFO value) => (long)(value.Value);

    public static explicit operator HGESTUREINFO(nint value) =>
        new HGESTUREINFO(unchecked((void*)(value)));

    public static implicit operator nint(HGESTUREINFO value) => (nint)(value.Value);

    public static explicit operator HGESTUREINFO(sbyte value) =>
        new HGESTUREINFO(unchecked((void*)(value)));

    public static explicit operator sbyte(HGESTUREINFO value) => (sbyte)(value.Value);

    public static explicit operator HGESTUREINFO(ushort value) =>
        new HGESTUREINFO(unchecked((void*)(value)));

    public static explicit operator ushort(HGESTUREINFO value) => (ushort)(value.Value);

    public static explicit operator HGESTUREINFO(uint value) =>
        new HGESTUREINFO(unchecked((void*)(value)));

    public static explicit operator uint(HGESTUREINFO value) => (uint)(value.Value);

    public static explicit operator HGESTUREINFO(ulong value) =>
        new HGESTUREINFO(unchecked((void*)(value)));

    public static explicit operator ulong(HGESTUREINFO value) => (ulong)(value.Value);

    public static explicit operator HGESTUREINFO(nuint value) =>
        new HGESTUREINFO(unchecked((void*)(value)));

    public static implicit operator nuint(HGESTUREINFO value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HGESTUREINFO other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HGESTUREINFO.");
    }

    public int CompareTo(HGESTUREINFO other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HGESTUREINFO other) && Equals(other);

    public bool Equals(HGESTUREINFO other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
