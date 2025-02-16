// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct OAHWND
    : IComparable,
        IComparable<OAHWND>,
        IEquatable<OAHWND>,
        IFormattable
{
    public readonly void* Value;

    public OAHWND(void* value)
    {
        Value = value;
    }

    public static OAHWND NULL => new OAHWND(null);

    public static bool operator ==(OAHWND left, OAHWND right) => left.Value == right.Value;

    public static bool operator !=(OAHWND left, OAHWND right) => left.Value != right.Value;

    public static bool operator <(OAHWND left, OAHWND right) => left.Value < right.Value;

    public static bool operator <=(OAHWND left, OAHWND right) => left.Value <= right.Value;

    public static bool operator >(OAHWND left, OAHWND right) => left.Value > right.Value;

    public static bool operator >=(OAHWND left, OAHWND right) => left.Value >= right.Value;

    public static explicit operator OAHWND(void* value) => new OAHWND(value);

    public static implicit operator void*(OAHWND value) => value.Value;

    public static explicit operator OAHWND(byte value) => new OAHWND(unchecked((void*)(value)));

    public static explicit operator byte(OAHWND value) => (byte)(value.Value);

    public static explicit operator OAHWND(short value) => new OAHWND(unchecked((void*)(value)));

    public static explicit operator short(OAHWND value) => (short)(value.Value);

    public static explicit operator OAHWND(int value) => new OAHWND(unchecked((void*)(value)));

    public static explicit operator int(OAHWND value) => (int)(value.Value);

    public static explicit operator OAHWND(long value) => new OAHWND(unchecked((void*)(value)));

    public static explicit operator long(OAHWND value) => (long)(value.Value);

    public static explicit operator OAHWND(nint value) => new OAHWND(unchecked((void*)(value)));

    public static implicit operator nint(OAHWND value) => (nint)(value.Value);

    public static explicit operator OAHWND(sbyte value) => new OAHWND(unchecked((void*)(value)));

    public static explicit operator sbyte(OAHWND value) => (sbyte)(value.Value);

    public static explicit operator OAHWND(ushort value) => new OAHWND(unchecked((void*)(value)));

    public static explicit operator ushort(OAHWND value) => (ushort)(value.Value);

    public static explicit operator OAHWND(uint value) => new OAHWND(unchecked((void*)(value)));

    public static explicit operator uint(OAHWND value) => (uint)(value.Value);

    public static explicit operator OAHWND(ulong value) => new OAHWND(unchecked((void*)(value)));

    public static explicit operator ulong(OAHWND value) => (ulong)(value.Value);

    public static explicit operator OAHWND(nuint value) => new OAHWND(unchecked((void*)(value)));

    public static implicit operator nuint(OAHWND value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is OAHWND other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of OAHWND.");
    }

    public int CompareTo(OAHWND other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is OAHWND other) && Equals(other);

    public bool Equals(OAHWND other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
