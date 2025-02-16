// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HSEMAPHORE
    : IComparable,
        IComparable<HSEMAPHORE>,
        IEquatable<HSEMAPHORE>,
        IFormattable
{
    public readonly void* Value;

    public HSEMAPHORE(void* value)
    {
        Value = value;
    }

    public static HSEMAPHORE INVALID_VALUE => new HSEMAPHORE((void*)(-1));
    public static HSEMAPHORE NULL => new HSEMAPHORE(null);

    public static bool operator ==(HSEMAPHORE left, HSEMAPHORE right) => left.Value == right.Value;

    public static bool operator !=(HSEMAPHORE left, HSEMAPHORE right) => left.Value != right.Value;

    public static bool operator <(HSEMAPHORE left, HSEMAPHORE right) => left.Value < right.Value;

    public static bool operator <=(HSEMAPHORE left, HSEMAPHORE right) => left.Value <= right.Value;

    public static bool operator >(HSEMAPHORE left, HSEMAPHORE right) => left.Value > right.Value;

    public static bool operator >=(HSEMAPHORE left, HSEMAPHORE right) => left.Value >= right.Value;

    public static explicit operator HSEMAPHORE(void* value) => new HSEMAPHORE(value);

    public static implicit operator void*(HSEMAPHORE value) => value.Value;

    public static explicit operator HSEMAPHORE(HANDLE value) => new HSEMAPHORE(value);

    public static implicit operator HANDLE(HSEMAPHORE value) => new HANDLE(value.Value);

    public static explicit operator HSEMAPHORE(byte value) =>
        new HSEMAPHORE(unchecked((void*)(value)));

    public static explicit operator byte(HSEMAPHORE value) => (byte)(value.Value);

    public static explicit operator HSEMAPHORE(short value) =>
        new HSEMAPHORE(unchecked((void*)(value)));

    public static explicit operator short(HSEMAPHORE value) => (short)(value.Value);

    public static explicit operator HSEMAPHORE(int value) =>
        new HSEMAPHORE(unchecked((void*)(value)));

    public static explicit operator int(HSEMAPHORE value) => (int)(value.Value);

    public static explicit operator HSEMAPHORE(long value) =>
        new HSEMAPHORE(unchecked((void*)(value)));

    public static explicit operator long(HSEMAPHORE value) => (long)(value.Value);

    public static explicit operator HSEMAPHORE(nint value) =>
        new HSEMAPHORE(unchecked((void*)(value)));

    public static implicit operator nint(HSEMAPHORE value) => (nint)(value.Value);

    public static explicit operator HSEMAPHORE(sbyte value) =>
        new HSEMAPHORE(unchecked((void*)(value)));

    public static explicit operator sbyte(HSEMAPHORE value) => (sbyte)(value.Value);

    public static explicit operator HSEMAPHORE(ushort value) =>
        new HSEMAPHORE(unchecked((void*)(value)));

    public static explicit operator ushort(HSEMAPHORE value) => (ushort)(value.Value);

    public static explicit operator HSEMAPHORE(uint value) =>
        new HSEMAPHORE(unchecked((void*)(value)));

    public static explicit operator uint(HSEMAPHORE value) => (uint)(value.Value);

    public static explicit operator HSEMAPHORE(ulong value) =>
        new HSEMAPHORE(unchecked((void*)(value)));

    public static explicit operator ulong(HSEMAPHORE value) => (ulong)(value.Value);

    public static explicit operator HSEMAPHORE(nuint value) =>
        new HSEMAPHORE(unchecked((void*)(value)));

    public static implicit operator nuint(HSEMAPHORE value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HSEMAPHORE other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HSEMAPHORE.");
    }

    public int CompareTo(HSEMAPHORE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HSEMAPHORE other) && Equals(other);

    public bool Equals(HSEMAPHORE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
