// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HMIXER
    : IComparable,
        IComparable<HMIXER>,
        IEquatable<HMIXER>,
        IFormattable
{
    public readonly void* Value;

    public HMIXER(void* value)
    {
        Value = value;
    }

    public static HMIXER INVALID_VALUE => new HMIXER((void*)(-1));
    public static HMIXER NULL => new HMIXER(null);

    public static bool operator ==(HMIXER left, HMIXER right) => left.Value == right.Value;

    public static bool operator !=(HMIXER left, HMIXER right) => left.Value != right.Value;

    public static bool operator <(HMIXER left, HMIXER right) => left.Value < right.Value;

    public static bool operator <=(HMIXER left, HMIXER right) => left.Value <= right.Value;

    public static bool operator >(HMIXER left, HMIXER right) => left.Value > right.Value;

    public static bool operator >=(HMIXER left, HMIXER right) => left.Value >= right.Value;

    public static explicit operator HMIXER(void* value) => new HMIXER(value);

    public static implicit operator void*(HMIXER value) => value.Value;

    public static explicit operator HMIXER(HANDLE value) => new HMIXER(value);

    public static implicit operator HANDLE(HMIXER value) => new HANDLE(value.Value);

    public static explicit operator HMIXER(byte value) => new HMIXER(unchecked((void*)(value)));

    public static explicit operator byte(HMIXER value) => (byte)(value.Value);

    public static explicit operator HMIXER(short value) => new HMIXER(unchecked((void*)(value)));

    public static explicit operator short(HMIXER value) => (short)(value.Value);

    public static explicit operator HMIXER(int value) => new HMIXER(unchecked((void*)(value)));

    public static explicit operator int(HMIXER value) => (int)(value.Value);

    public static explicit operator HMIXER(long value) => new HMIXER(unchecked((void*)(value)));

    public static explicit operator long(HMIXER value) => (long)(value.Value);

    public static explicit operator HMIXER(nint value) => new HMIXER(unchecked((void*)(value)));

    public static implicit operator nint(HMIXER value) => (nint)(value.Value);

    public static explicit operator HMIXER(sbyte value) => new HMIXER(unchecked((void*)(value)));

    public static explicit operator sbyte(HMIXER value) => (sbyte)(value.Value);

    public static explicit operator HMIXER(ushort value) => new HMIXER(unchecked((void*)(value)));

    public static explicit operator ushort(HMIXER value) => (ushort)(value.Value);

    public static explicit operator HMIXER(uint value) => new HMIXER(unchecked((void*)(value)));

    public static explicit operator uint(HMIXER value) => (uint)(value.Value);

    public static explicit operator HMIXER(ulong value) => new HMIXER(unchecked((void*)(value)));

    public static explicit operator ulong(HMIXER value) => (ulong)(value.Value);

    public static explicit operator HMIXER(nuint value) => new HMIXER(unchecked((void*)(value)));

    public static implicit operator nuint(HMIXER value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HMIXER other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HMIXER.");
    }

    public int CompareTo(HMIXER other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HMIXER other) && Equals(other);

    public bool Equals(HMIXER other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
