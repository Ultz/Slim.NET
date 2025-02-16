// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HANIMATIONBUFFER
    : IComparable,
        IComparable<HANIMATIONBUFFER>,
        IEquatable<HANIMATIONBUFFER>,
        IFormattable
{
    public readonly void* Value;

    public HANIMATIONBUFFER(void* value)
    {
        Value = value;
    }

    public static HANIMATIONBUFFER INVALID_VALUE => new HANIMATIONBUFFER((void*)(-1));
    public static HANIMATIONBUFFER NULL => new HANIMATIONBUFFER(null);

    public static bool operator ==(HANIMATIONBUFFER left, HANIMATIONBUFFER right) =>
        left.Value == right.Value;

    public static bool operator !=(HANIMATIONBUFFER left, HANIMATIONBUFFER right) =>
        left.Value != right.Value;

    public static bool operator <(HANIMATIONBUFFER left, HANIMATIONBUFFER right) =>
        left.Value < right.Value;

    public static bool operator <=(HANIMATIONBUFFER left, HANIMATIONBUFFER right) =>
        left.Value <= right.Value;

    public static bool operator >(HANIMATIONBUFFER left, HANIMATIONBUFFER right) =>
        left.Value > right.Value;

    public static bool operator >=(HANIMATIONBUFFER left, HANIMATIONBUFFER right) =>
        left.Value >= right.Value;

    public static explicit operator HANIMATIONBUFFER(void* value) => new HANIMATIONBUFFER(value);

    public static implicit operator void*(HANIMATIONBUFFER value) => value.Value;

    public static explicit operator HANIMATIONBUFFER(HANDLE value) => new HANIMATIONBUFFER(value);

    public static implicit operator HANDLE(HANIMATIONBUFFER value) => new HANDLE(value.Value);

    public static explicit operator HANIMATIONBUFFER(byte value) =>
        new HANIMATIONBUFFER(unchecked((void*)(value)));

    public static explicit operator byte(HANIMATIONBUFFER value) => (byte)(value.Value);

    public static explicit operator HANIMATIONBUFFER(short value) =>
        new HANIMATIONBUFFER(unchecked((void*)(value)));

    public static explicit operator short(HANIMATIONBUFFER value) => (short)(value.Value);

    public static explicit operator HANIMATIONBUFFER(int value) =>
        new HANIMATIONBUFFER(unchecked((void*)(value)));

    public static explicit operator int(HANIMATIONBUFFER value) => (int)(value.Value);

    public static explicit operator HANIMATIONBUFFER(long value) =>
        new HANIMATIONBUFFER(unchecked((void*)(value)));

    public static explicit operator long(HANIMATIONBUFFER value) => (long)(value.Value);

    public static explicit operator HANIMATIONBUFFER(nint value) =>
        new HANIMATIONBUFFER(unchecked((void*)(value)));

    public static implicit operator nint(HANIMATIONBUFFER value) => (nint)(value.Value);

    public static explicit operator HANIMATIONBUFFER(sbyte value) =>
        new HANIMATIONBUFFER(unchecked((void*)(value)));

    public static explicit operator sbyte(HANIMATIONBUFFER value) => (sbyte)(value.Value);

    public static explicit operator HANIMATIONBUFFER(ushort value) =>
        new HANIMATIONBUFFER(unchecked((void*)(value)));

    public static explicit operator ushort(HANIMATIONBUFFER value) => (ushort)(value.Value);

    public static explicit operator HANIMATIONBUFFER(uint value) =>
        new HANIMATIONBUFFER(unchecked((void*)(value)));

    public static explicit operator uint(HANIMATIONBUFFER value) => (uint)(value.Value);

    public static explicit operator HANIMATIONBUFFER(ulong value) =>
        new HANIMATIONBUFFER(unchecked((void*)(value)));

    public static explicit operator ulong(HANIMATIONBUFFER value) => (ulong)(value.Value);

    public static explicit operator HANIMATIONBUFFER(nuint value) =>
        new HANIMATIONBUFFER(unchecked((void*)(value)));

    public static implicit operator nuint(HANIMATIONBUFFER value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HANIMATIONBUFFER other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HANIMATIONBUFFER.");
    }

    public int CompareTo(HANIMATIONBUFFER other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HANIMATIONBUFFER other) && Equals(other);

    public bool Equals(HANIMATIONBUFFER other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
