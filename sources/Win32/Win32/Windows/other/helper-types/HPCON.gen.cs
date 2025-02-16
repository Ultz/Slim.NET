// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HPCON
    : IComparable,
        IComparable<HPCON>,
        IEquatable<HPCON>,
        IFormattable
{
    public readonly void* Value;

    public HPCON(void* value)
    {
        Value = value;
    }

    public static HPCON INVALID_VALUE => new HPCON((void*)(-1));
    public static HPCON NULL => new HPCON(null);

    public static bool operator ==(HPCON left, HPCON right) => left.Value == right.Value;

    public static bool operator !=(HPCON left, HPCON right) => left.Value != right.Value;

    public static bool operator <(HPCON left, HPCON right) => left.Value < right.Value;

    public static bool operator <=(HPCON left, HPCON right) => left.Value <= right.Value;

    public static bool operator >(HPCON left, HPCON right) => left.Value > right.Value;

    public static bool operator >=(HPCON left, HPCON right) => left.Value >= right.Value;

    public static explicit operator HPCON(void* value) => new HPCON(value);

    public static implicit operator void*(HPCON value) => value.Value;

    public static explicit operator HPCON(HANDLE value) => new HPCON(value);

    public static implicit operator HANDLE(HPCON value) => new HANDLE(value.Value);

    public static explicit operator HPCON(byte value) => new HPCON(unchecked((void*)(value)));

    public static explicit operator byte(HPCON value) => (byte)(value.Value);

    public static explicit operator HPCON(short value) => new HPCON(unchecked((void*)(value)));

    public static explicit operator short(HPCON value) => (short)(value.Value);

    public static explicit operator HPCON(int value) => new HPCON(unchecked((void*)(value)));

    public static explicit operator int(HPCON value) => (int)(value.Value);

    public static explicit operator HPCON(long value) => new HPCON(unchecked((void*)(value)));

    public static explicit operator long(HPCON value) => (long)(value.Value);

    public static explicit operator HPCON(nint value) => new HPCON(unchecked((void*)(value)));

    public static implicit operator nint(HPCON value) => (nint)(value.Value);

    public static explicit operator HPCON(sbyte value) => new HPCON(unchecked((void*)(value)));

    public static explicit operator sbyte(HPCON value) => (sbyte)(value.Value);

    public static explicit operator HPCON(ushort value) => new HPCON(unchecked((void*)(value)));

    public static explicit operator ushort(HPCON value) => (ushort)(value.Value);

    public static explicit operator HPCON(uint value) => new HPCON(unchecked((void*)(value)));

    public static explicit operator uint(HPCON value) => (uint)(value.Value);

    public static explicit operator HPCON(ulong value) => new HPCON(unchecked((void*)(value)));

    public static explicit operator ulong(HPCON value) => (ulong)(value.Value);

    public static explicit operator HPCON(nuint value) => new HPCON(unchecked((void*)(value)));

    public static implicit operator nuint(HPCON value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HPCON other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HPCON.");
    }

    public int CompareTo(HPCON other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HPCON other) && Equals(other);

    public bool Equals(HPCON other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
