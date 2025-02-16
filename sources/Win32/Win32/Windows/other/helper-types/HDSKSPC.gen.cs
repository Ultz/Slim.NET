// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HDSKSPC
    : IComparable,
        IComparable<HDSKSPC>,
        IEquatable<HDSKSPC>,
        IFormattable
{
    public readonly void* Value;

    public HDSKSPC(void* value)
    {
        Value = value;
    }

    public static HDSKSPC INVALID_VALUE => new HDSKSPC((void*)(-1));
    public static HDSKSPC NULL => new HDSKSPC(null);

    public static bool operator ==(HDSKSPC left, HDSKSPC right) => left.Value == right.Value;

    public static bool operator !=(HDSKSPC left, HDSKSPC right) => left.Value != right.Value;

    public static bool operator <(HDSKSPC left, HDSKSPC right) => left.Value < right.Value;

    public static bool operator <=(HDSKSPC left, HDSKSPC right) => left.Value <= right.Value;

    public static bool operator >(HDSKSPC left, HDSKSPC right) => left.Value > right.Value;

    public static bool operator >=(HDSKSPC left, HDSKSPC right) => left.Value >= right.Value;

    public static explicit operator HDSKSPC(void* value) => new HDSKSPC(value);

    public static implicit operator void*(HDSKSPC value) => value.Value;

    public static explicit operator HDSKSPC(HANDLE value) => new HDSKSPC(value);

    public static implicit operator HANDLE(HDSKSPC value) => new HANDLE(value.Value);

    public static explicit operator HDSKSPC(byte value) => new HDSKSPC(unchecked((void*)(value)));

    public static explicit operator byte(HDSKSPC value) => (byte)(value.Value);

    public static explicit operator HDSKSPC(short value) => new HDSKSPC(unchecked((void*)(value)));

    public static explicit operator short(HDSKSPC value) => (short)(value.Value);

    public static explicit operator HDSKSPC(int value) => new HDSKSPC(unchecked((void*)(value)));

    public static explicit operator int(HDSKSPC value) => (int)(value.Value);

    public static explicit operator HDSKSPC(long value) => new HDSKSPC(unchecked((void*)(value)));

    public static explicit operator long(HDSKSPC value) => (long)(value.Value);

    public static explicit operator HDSKSPC(nint value) => new HDSKSPC(unchecked((void*)(value)));

    public static implicit operator nint(HDSKSPC value) => (nint)(value.Value);

    public static explicit operator HDSKSPC(sbyte value) => new HDSKSPC(unchecked((void*)(value)));

    public static explicit operator sbyte(HDSKSPC value) => (sbyte)(value.Value);

    public static explicit operator HDSKSPC(ushort value) => new HDSKSPC(unchecked((void*)(value)));

    public static explicit operator ushort(HDSKSPC value) => (ushort)(value.Value);

    public static explicit operator HDSKSPC(uint value) => new HDSKSPC(unchecked((void*)(value)));

    public static explicit operator uint(HDSKSPC value) => (uint)(value.Value);

    public static explicit operator HDSKSPC(ulong value) => new HDSKSPC(unchecked((void*)(value)));

    public static explicit operator ulong(HDSKSPC value) => (ulong)(value.Value);

    public static explicit operator HDSKSPC(nuint value) => new HDSKSPC(unchecked((void*)(value)));

    public static implicit operator nuint(HDSKSPC value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HDSKSPC other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HDSKSPC.");
    }

    public int CompareTo(HDSKSPC other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HDSKSPC other) && Equals(other);

    public bool Equals(HDSKSPC other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
