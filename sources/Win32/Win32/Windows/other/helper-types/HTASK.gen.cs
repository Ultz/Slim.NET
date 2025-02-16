// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HTASK
    : IComparable,
        IComparable<HTASK>,
        IEquatable<HTASK>,
        IFormattable
{
    public readonly void* Value;

    public HTASK(void* value)
    {
        Value = value;
    }

    public static HTASK INVALID_VALUE => new HTASK((void*)(-1));
    public static HTASK NULL => new HTASK(null);

    public static bool operator ==(HTASK left, HTASK right) => left.Value == right.Value;

    public static bool operator !=(HTASK left, HTASK right) => left.Value != right.Value;

    public static bool operator <(HTASK left, HTASK right) => left.Value < right.Value;

    public static bool operator <=(HTASK left, HTASK right) => left.Value <= right.Value;

    public static bool operator >(HTASK left, HTASK right) => left.Value > right.Value;

    public static bool operator >=(HTASK left, HTASK right) => left.Value >= right.Value;

    public static explicit operator HTASK(void* value) => new HTASK(value);

    public static implicit operator void*(HTASK value) => value.Value;

    public static explicit operator HTASK(HANDLE value) => new HTASK(value);

    public static implicit operator HANDLE(HTASK value) => new HANDLE(value.Value);

    public static explicit operator HTASK(byte value) => new HTASK(unchecked((void*)(value)));

    public static explicit operator byte(HTASK value) => (byte)(value.Value);

    public static explicit operator HTASK(short value) => new HTASK(unchecked((void*)(value)));

    public static explicit operator short(HTASK value) => (short)(value.Value);

    public static explicit operator HTASK(int value) => new HTASK(unchecked((void*)(value)));

    public static explicit operator int(HTASK value) => (int)(value.Value);

    public static explicit operator HTASK(long value) => new HTASK(unchecked((void*)(value)));

    public static explicit operator long(HTASK value) => (long)(value.Value);

    public static explicit operator HTASK(nint value) => new HTASK(unchecked((void*)(value)));

    public static implicit operator nint(HTASK value) => (nint)(value.Value);

    public static explicit operator HTASK(sbyte value) => new HTASK(unchecked((void*)(value)));

    public static explicit operator sbyte(HTASK value) => (sbyte)(value.Value);

    public static explicit operator HTASK(ushort value) => new HTASK(unchecked((void*)(value)));

    public static explicit operator ushort(HTASK value) => (ushort)(value.Value);

    public static explicit operator HTASK(uint value) => new HTASK(unchecked((void*)(value)));

    public static explicit operator uint(HTASK value) => (uint)(value.Value);

    public static explicit operator HTASK(ulong value) => new HTASK(unchecked((void*)(value)));

    public static explicit operator ulong(HTASK value) => (ulong)(value.Value);

    public static explicit operator HTASK(nuint value) => new HTASK(unchecked((void*)(value)));

    public static implicit operator nuint(HTASK value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HTASK other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HTASK.");
    }

    public int CompareTo(HTASK other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HTASK other) && Equals(other);

    public bool Equals(HTASK other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
