// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HMODULE
    : IComparable,
        IComparable<HMODULE>,
        IEquatable<HMODULE>,
        IFormattable
{
    public readonly void* Value;

    public HMODULE(void* value)
    {
        Value = value;
    }

    public static HMODULE INVALID_VALUE => new HMODULE((void*)(-1));
    public static HMODULE NULL => new HMODULE(null);

    public static bool operator ==(HMODULE left, HMODULE right) => left.Value == right.Value;

    public static bool operator !=(HMODULE left, HMODULE right) => left.Value != right.Value;

    public static bool operator <(HMODULE left, HMODULE right) => left.Value < right.Value;

    public static bool operator <=(HMODULE left, HMODULE right) => left.Value <= right.Value;

    public static bool operator >(HMODULE left, HMODULE right) => left.Value > right.Value;

    public static bool operator >=(HMODULE left, HMODULE right) => left.Value >= right.Value;

    public static explicit operator HMODULE(void* value) => new HMODULE(value);

    public static implicit operator void*(HMODULE value) => value.Value;

    public static explicit operator HMODULE(HANDLE value) => new HMODULE(value);

    public static implicit operator HANDLE(HMODULE value) => new HANDLE(value.Value);

    public static explicit operator HMODULE(byte value) => new HMODULE(unchecked((void*)(value)));

    public static explicit operator byte(HMODULE value) => (byte)(value.Value);

    public static explicit operator HMODULE(short value) => new HMODULE(unchecked((void*)(value)));

    public static explicit operator short(HMODULE value) => (short)(value.Value);

    public static explicit operator HMODULE(int value) => new HMODULE(unchecked((void*)(value)));

    public static explicit operator int(HMODULE value) => (int)(value.Value);

    public static explicit operator HMODULE(long value) => new HMODULE(unchecked((void*)(value)));

    public static explicit operator long(HMODULE value) => (long)(value.Value);

    public static explicit operator HMODULE(nint value) => new HMODULE(unchecked((void*)(value)));

    public static implicit operator nint(HMODULE value) => (nint)(value.Value);

    public static explicit operator HMODULE(sbyte value) => new HMODULE(unchecked((void*)(value)));

    public static explicit operator sbyte(HMODULE value) => (sbyte)(value.Value);

    public static explicit operator HMODULE(ushort value) => new HMODULE(unchecked((void*)(value)));

    public static explicit operator ushort(HMODULE value) => (ushort)(value.Value);

    public static explicit operator HMODULE(uint value) => new HMODULE(unchecked((void*)(value)));

    public static explicit operator uint(HMODULE value) => (uint)(value.Value);

    public static explicit operator HMODULE(ulong value) => new HMODULE(unchecked((void*)(value)));

    public static explicit operator ulong(HMODULE value) => (ulong)(value.Value);

    public static explicit operator HMODULE(nuint value) => new HMODULE(unchecked((void*)(value)));

    public static implicit operator nuint(HMODULE value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HMODULE other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HMODULE.");
    }

    public int CompareTo(HMODULE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HMODULE other) && Equals(other);

    public bool Equals(HMODULE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
