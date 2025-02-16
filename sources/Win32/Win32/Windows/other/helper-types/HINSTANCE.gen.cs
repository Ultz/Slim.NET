// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HINSTANCE
    : IComparable,
        IComparable<HINSTANCE>,
        IEquatable<HINSTANCE>,
        IFormattable
{
    public readonly void* Value;

    public HINSTANCE(void* value)
    {
        Value = value;
    }

    public static HINSTANCE INVALID_VALUE => new HINSTANCE((void*)(-1));
    public static HINSTANCE NULL => new HINSTANCE(null);

    public static bool operator ==(HINSTANCE left, HINSTANCE right) => left.Value == right.Value;

    public static bool operator !=(HINSTANCE left, HINSTANCE right) => left.Value != right.Value;

    public static bool operator <(HINSTANCE left, HINSTANCE right) => left.Value < right.Value;

    public static bool operator <=(HINSTANCE left, HINSTANCE right) => left.Value <= right.Value;

    public static bool operator >(HINSTANCE left, HINSTANCE right) => left.Value > right.Value;

    public static bool operator >=(HINSTANCE left, HINSTANCE right) => left.Value >= right.Value;

    public static explicit operator HINSTANCE(void* value) => new HINSTANCE(value);

    public static implicit operator void*(HINSTANCE value) => value.Value;

    public static explicit operator HINSTANCE(HANDLE value) => new HINSTANCE(value);

    public static implicit operator HANDLE(HINSTANCE value) => new HANDLE(value.Value);

    public static explicit operator HINSTANCE(byte value) =>
        new HINSTANCE(unchecked((void*)(value)));

    public static explicit operator byte(HINSTANCE value) => (byte)(value.Value);

    public static explicit operator HINSTANCE(short value) =>
        new HINSTANCE(unchecked((void*)(value)));

    public static explicit operator short(HINSTANCE value) => (short)(value.Value);

    public static explicit operator HINSTANCE(int value) =>
        new HINSTANCE(unchecked((void*)(value)));

    public static explicit operator int(HINSTANCE value) => (int)(value.Value);

    public static explicit operator HINSTANCE(long value) =>
        new HINSTANCE(unchecked((void*)(value)));

    public static explicit operator long(HINSTANCE value) => (long)(value.Value);

    public static explicit operator HINSTANCE(nint value) =>
        new HINSTANCE(unchecked((void*)(value)));

    public static implicit operator nint(HINSTANCE value) => (nint)(value.Value);

    public static explicit operator HINSTANCE(sbyte value) =>
        new HINSTANCE(unchecked((void*)(value)));

    public static explicit operator sbyte(HINSTANCE value) => (sbyte)(value.Value);

    public static explicit operator HINSTANCE(ushort value) =>
        new HINSTANCE(unchecked((void*)(value)));

    public static explicit operator ushort(HINSTANCE value) => (ushort)(value.Value);

    public static explicit operator HINSTANCE(uint value) =>
        new HINSTANCE(unchecked((void*)(value)));

    public static explicit operator uint(HINSTANCE value) => (uint)(value.Value);

    public static explicit operator HINSTANCE(ulong value) =>
        new HINSTANCE(unchecked((void*)(value)));

    public static explicit operator ulong(HINSTANCE value) => (ulong)(value.Value);

    public static explicit operator HINSTANCE(nuint value) =>
        new HINSTANCE(unchecked((void*)(value)));

    public static implicit operator nuint(HINSTANCE value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HINSTANCE other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HINSTANCE.");
    }

    public int CompareTo(HINSTANCE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HINSTANCE other) && Equals(other);

    public bool Equals(HINSTANCE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
