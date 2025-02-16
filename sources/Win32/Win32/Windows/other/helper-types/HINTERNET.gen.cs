// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HINTERNET
    : IComparable,
        IComparable<HINTERNET>,
        IEquatable<HINTERNET>,
        IFormattable
{
    public readonly void* Value;

    public HINTERNET(void* value)
    {
        Value = value;
    }

    public static HINTERNET INVALID_VALUE => new HINTERNET((void*)(-1));
    public static HINTERNET NULL => new HINTERNET(null);

    public static bool operator ==(HINTERNET left, HINTERNET right) => left.Value == right.Value;

    public static bool operator !=(HINTERNET left, HINTERNET right) => left.Value != right.Value;

    public static bool operator <(HINTERNET left, HINTERNET right) => left.Value < right.Value;

    public static bool operator <=(HINTERNET left, HINTERNET right) => left.Value <= right.Value;

    public static bool operator >(HINTERNET left, HINTERNET right) => left.Value > right.Value;

    public static bool operator >=(HINTERNET left, HINTERNET right) => left.Value >= right.Value;

    public static explicit operator HINTERNET(void* value) => new HINTERNET(value);

    public static implicit operator void*(HINTERNET value) => value.Value;

    public static explicit operator HINTERNET(HANDLE value) => new HINTERNET(value);

    public static implicit operator HANDLE(HINTERNET value) => new HANDLE(value.Value);

    public static explicit operator HINTERNET(byte value) =>
        new HINTERNET(unchecked((void*)(value)));

    public static explicit operator byte(HINTERNET value) => (byte)(value.Value);

    public static explicit operator HINTERNET(short value) =>
        new HINTERNET(unchecked((void*)(value)));

    public static explicit operator short(HINTERNET value) => (short)(value.Value);

    public static explicit operator HINTERNET(int value) =>
        new HINTERNET(unchecked((void*)(value)));

    public static explicit operator int(HINTERNET value) => (int)(value.Value);

    public static explicit operator HINTERNET(long value) =>
        new HINTERNET(unchecked((void*)(value)));

    public static explicit operator long(HINTERNET value) => (long)(value.Value);

    public static explicit operator HINTERNET(nint value) =>
        new HINTERNET(unchecked((void*)(value)));

    public static implicit operator nint(HINTERNET value) => (nint)(value.Value);

    public static explicit operator HINTERNET(sbyte value) =>
        new HINTERNET(unchecked((void*)(value)));

    public static explicit operator sbyte(HINTERNET value) => (sbyte)(value.Value);

    public static explicit operator HINTERNET(ushort value) =>
        new HINTERNET(unchecked((void*)(value)));

    public static explicit operator ushort(HINTERNET value) => (ushort)(value.Value);

    public static explicit operator HINTERNET(uint value) =>
        new HINTERNET(unchecked((void*)(value)));

    public static explicit operator uint(HINTERNET value) => (uint)(value.Value);

    public static explicit operator HINTERNET(ulong value) =>
        new HINTERNET(unchecked((void*)(value)));

    public static explicit operator ulong(HINTERNET value) => (ulong)(value.Value);

    public static explicit operator HINTERNET(nuint value) =>
        new HINTERNET(unchecked((void*)(value)));

    public static implicit operator nuint(HINTERNET value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HINTERNET other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HINTERNET.");
    }

    public int CompareTo(HINTERNET other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HINTERNET other) && Equals(other);

    public bool Equals(HINTERNET other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
