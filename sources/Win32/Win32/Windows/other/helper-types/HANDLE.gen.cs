// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HANDLE
    : IComparable,
        IComparable<HANDLE>,
        IEquatable<HANDLE>,
        IFormattable
{
    public readonly void* Value;

    public HANDLE(void* value)
    {
        Value = value;
    }

    public static HANDLE INVALID_VALUE => new HANDLE((void*)(-1));
    public static HANDLE NULL => new HANDLE(null);

    public static bool operator ==(HANDLE left, HANDLE right) => left.Value == right.Value;

    public static bool operator !=(HANDLE left, HANDLE right) => left.Value != right.Value;

    public static bool operator <(HANDLE left, HANDLE right) => left.Value < right.Value;

    public static bool operator <=(HANDLE left, HANDLE right) => left.Value <= right.Value;

    public static bool operator >(HANDLE left, HANDLE right) => left.Value > right.Value;

    public static bool operator >=(HANDLE left, HANDLE right) => left.Value >= right.Value;

    public static explicit operator HANDLE(void* value) => new HANDLE(value);

    public static implicit operator void*(HANDLE value) => value.Value;

    public static explicit operator HANDLE(byte value) => new HANDLE(unchecked((void*)(value)));

    public static explicit operator byte(HANDLE value) => (byte)(value.Value);

    public static explicit operator HANDLE(short value) => new HANDLE(unchecked((void*)(value)));

    public static explicit operator short(HANDLE value) => (short)(value.Value);

    public static explicit operator HANDLE(int value) => new HANDLE(unchecked((void*)(value)));

    public static explicit operator int(HANDLE value) => (int)(value.Value);

    public static explicit operator HANDLE(long value) => new HANDLE(unchecked((void*)(value)));

    public static explicit operator long(HANDLE value) => (long)(value.Value);

    public static explicit operator HANDLE(nint value) => new HANDLE(unchecked((void*)(value)));

    public static implicit operator nint(HANDLE value) => (nint)(value.Value);

    public static explicit operator HANDLE(sbyte value) => new HANDLE(unchecked((void*)(value)));

    public static explicit operator sbyte(HANDLE value) => (sbyte)(value.Value);

    public static explicit operator HANDLE(ushort value) => new HANDLE(unchecked((void*)(value)));

    public static explicit operator ushort(HANDLE value) => (ushort)(value.Value);

    public static explicit operator HANDLE(uint value) => new HANDLE(unchecked((void*)(value)));

    public static explicit operator uint(HANDLE value) => (uint)(value.Value);

    public static explicit operator HANDLE(ulong value) => new HANDLE(unchecked((void*)(value)));

    public static explicit operator ulong(HANDLE value) => (ulong)(value.Value);

    public static explicit operator HANDLE(nuint value) => new HANDLE(unchecked((void*)(value)));

    public static implicit operator nuint(HANDLE value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HANDLE other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HANDLE.");
    }

    public int CompareTo(HANDLE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HANDLE other) && Equals(other);

    public bool Equals(HANDLE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
