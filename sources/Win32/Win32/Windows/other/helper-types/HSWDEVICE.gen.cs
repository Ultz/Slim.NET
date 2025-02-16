// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HSWDEVICE
    : IComparable,
        IComparable<HSWDEVICE>,
        IEquatable<HSWDEVICE>,
        IFormattable
{
    public readonly void* Value;

    public HSWDEVICE(void* value)
    {
        Value = value;
    }

    public static HSWDEVICE INVALID_VALUE => new HSWDEVICE((void*)(-1));
    public static HSWDEVICE NULL => new HSWDEVICE(null);

    public static bool operator ==(HSWDEVICE left, HSWDEVICE right) => left.Value == right.Value;

    public static bool operator !=(HSWDEVICE left, HSWDEVICE right) => left.Value != right.Value;

    public static bool operator <(HSWDEVICE left, HSWDEVICE right) => left.Value < right.Value;

    public static bool operator <=(HSWDEVICE left, HSWDEVICE right) => left.Value <= right.Value;

    public static bool operator >(HSWDEVICE left, HSWDEVICE right) => left.Value > right.Value;

    public static bool operator >=(HSWDEVICE left, HSWDEVICE right) => left.Value >= right.Value;

    public static explicit operator HSWDEVICE(void* value) => new HSWDEVICE(value);

    public static implicit operator void*(HSWDEVICE value) => value.Value;

    public static explicit operator HSWDEVICE(HANDLE value) => new HSWDEVICE(value);

    public static implicit operator HANDLE(HSWDEVICE value) => new HANDLE(value.Value);

    public static explicit operator HSWDEVICE(byte value) =>
        new HSWDEVICE(unchecked((void*)(value)));

    public static explicit operator byte(HSWDEVICE value) => (byte)(value.Value);

    public static explicit operator HSWDEVICE(short value) =>
        new HSWDEVICE(unchecked((void*)(value)));

    public static explicit operator short(HSWDEVICE value) => (short)(value.Value);

    public static explicit operator HSWDEVICE(int value) =>
        new HSWDEVICE(unchecked((void*)(value)));

    public static explicit operator int(HSWDEVICE value) => (int)(value.Value);

    public static explicit operator HSWDEVICE(long value) =>
        new HSWDEVICE(unchecked((void*)(value)));

    public static explicit operator long(HSWDEVICE value) => (long)(value.Value);

    public static explicit operator HSWDEVICE(nint value) =>
        new HSWDEVICE(unchecked((void*)(value)));

    public static implicit operator nint(HSWDEVICE value) => (nint)(value.Value);

    public static explicit operator HSWDEVICE(sbyte value) =>
        new HSWDEVICE(unchecked((void*)(value)));

    public static explicit operator sbyte(HSWDEVICE value) => (sbyte)(value.Value);

    public static explicit operator HSWDEVICE(ushort value) =>
        new HSWDEVICE(unchecked((void*)(value)));

    public static explicit operator ushort(HSWDEVICE value) => (ushort)(value.Value);

    public static explicit operator HSWDEVICE(uint value) =>
        new HSWDEVICE(unchecked((void*)(value)));

    public static explicit operator uint(HSWDEVICE value) => (uint)(value.Value);

    public static explicit operator HSWDEVICE(ulong value) =>
        new HSWDEVICE(unchecked((void*)(value)));

    public static explicit operator ulong(HSWDEVICE value) => (ulong)(value.Value);

    public static explicit operator HSWDEVICE(nuint value) =>
        new HSWDEVICE(unchecked((void*)(value)));

    public static implicit operator nuint(HSWDEVICE value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HSWDEVICE other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HSWDEVICE.");
    }

    public int CompareTo(HSWDEVICE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HSWDEVICE other) && Equals(other);

    public bool Equals(HSWDEVICE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
