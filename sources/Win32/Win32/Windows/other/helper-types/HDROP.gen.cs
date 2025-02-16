// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HDROP
    : IComparable,
        IComparable<HDROP>,
        IEquatable<HDROP>,
        IFormattable
{
    public readonly void* Value;

    public HDROP(void* value)
    {
        Value = value;
    }

    public static HDROP INVALID_VALUE => new HDROP((void*)(-1));
    public static HDROP NULL => new HDROP(null);

    public static bool operator ==(HDROP left, HDROP right) => left.Value == right.Value;

    public static bool operator !=(HDROP left, HDROP right) => left.Value != right.Value;

    public static bool operator <(HDROP left, HDROP right) => left.Value < right.Value;

    public static bool operator <=(HDROP left, HDROP right) => left.Value <= right.Value;

    public static bool operator >(HDROP left, HDROP right) => left.Value > right.Value;

    public static bool operator >=(HDROP left, HDROP right) => left.Value >= right.Value;

    public static explicit operator HDROP(void* value) => new HDROP(value);

    public static implicit operator void*(HDROP value) => value.Value;

    public static explicit operator HDROP(HANDLE value) => new HDROP(value);

    public static implicit operator HANDLE(HDROP value) => new HANDLE(value.Value);

    public static explicit operator HDROP(byte value) => new HDROP(unchecked((void*)(value)));

    public static explicit operator byte(HDROP value) => (byte)(value.Value);

    public static explicit operator HDROP(short value) => new HDROP(unchecked((void*)(value)));

    public static explicit operator short(HDROP value) => (short)(value.Value);

    public static explicit operator HDROP(int value) => new HDROP(unchecked((void*)(value)));

    public static explicit operator int(HDROP value) => (int)(value.Value);

    public static explicit operator HDROP(long value) => new HDROP(unchecked((void*)(value)));

    public static explicit operator long(HDROP value) => (long)(value.Value);

    public static explicit operator HDROP(nint value) => new HDROP(unchecked((void*)(value)));

    public static implicit operator nint(HDROP value) => (nint)(value.Value);

    public static explicit operator HDROP(sbyte value) => new HDROP(unchecked((void*)(value)));

    public static explicit operator sbyte(HDROP value) => (sbyte)(value.Value);

    public static explicit operator HDROP(ushort value) => new HDROP(unchecked((void*)(value)));

    public static explicit operator ushort(HDROP value) => (ushort)(value.Value);

    public static explicit operator HDROP(uint value) => new HDROP(unchecked((void*)(value)));

    public static explicit operator uint(HDROP value) => (uint)(value.Value);

    public static explicit operator HDROP(ulong value) => new HDROP(unchecked((void*)(value)));

    public static explicit operator ulong(HDROP value) => (ulong)(value.Value);

    public static explicit operator HDROP(nuint value) => new HDROP(unchecked((void*)(value)));

    public static implicit operator nuint(HDROP value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HDROP other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HDROP.");
    }

    public int CompareTo(HDROP other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HDROP other) && Equals(other);

    public bool Equals(HDROP other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
