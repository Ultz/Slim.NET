// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HGLRC
    : IComparable,
        IComparable<HGLRC>,
        IEquatable<HGLRC>,
        IFormattable
{
    public readonly void* Value;

    public HGLRC(void* value)
    {
        Value = value;
    }

    public static HGLRC INVALID_VALUE => new HGLRC((void*)(-1));
    public static HGLRC NULL => new HGLRC(null);

    public static bool operator ==(HGLRC left, HGLRC right) => left.Value == right.Value;

    public static bool operator !=(HGLRC left, HGLRC right) => left.Value != right.Value;

    public static bool operator <(HGLRC left, HGLRC right) => left.Value < right.Value;

    public static bool operator <=(HGLRC left, HGLRC right) => left.Value <= right.Value;

    public static bool operator >(HGLRC left, HGLRC right) => left.Value > right.Value;

    public static bool operator >=(HGLRC left, HGLRC right) => left.Value >= right.Value;

    public static explicit operator HGLRC(void* value) => new HGLRC(value);

    public static implicit operator void*(HGLRC value) => value.Value;

    public static explicit operator HGLRC(HANDLE value) => new HGLRC(value);

    public static implicit operator HANDLE(HGLRC value) => new HANDLE(value.Value);

    public static explicit operator HGLRC(byte value) => new HGLRC(unchecked((void*)(value)));

    public static explicit operator byte(HGLRC value) => (byte)(value.Value);

    public static explicit operator HGLRC(short value) => new HGLRC(unchecked((void*)(value)));

    public static explicit operator short(HGLRC value) => (short)(value.Value);

    public static explicit operator HGLRC(int value) => new HGLRC(unchecked((void*)(value)));

    public static explicit operator int(HGLRC value) => (int)(value.Value);

    public static explicit operator HGLRC(long value) => new HGLRC(unchecked((void*)(value)));

    public static explicit operator long(HGLRC value) => (long)(value.Value);

    public static explicit operator HGLRC(nint value) => new HGLRC(unchecked((void*)(value)));

    public static implicit operator nint(HGLRC value) => (nint)(value.Value);

    public static explicit operator HGLRC(sbyte value) => new HGLRC(unchecked((void*)(value)));

    public static explicit operator sbyte(HGLRC value) => (sbyte)(value.Value);

    public static explicit operator HGLRC(ushort value) => new HGLRC(unchecked((void*)(value)));

    public static explicit operator ushort(HGLRC value) => (ushort)(value.Value);

    public static explicit operator HGLRC(uint value) => new HGLRC(unchecked((void*)(value)));

    public static explicit operator uint(HGLRC value) => (uint)(value.Value);

    public static explicit operator HGLRC(ulong value) => new HGLRC(unchecked((void*)(value)));

    public static explicit operator ulong(HGLRC value) => (ulong)(value.Value);

    public static explicit operator HGLRC(nuint value) => new HGLRC(unchecked((void*)(value)));

    public static implicit operator nuint(HGLRC value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HGLRC other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HGLRC.");
    }

    public int CompareTo(HGLRC other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HGLRC other) && Equals(other);

    public bool Equals(HGLRC other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
