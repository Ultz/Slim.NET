// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HPSXA
    : IComparable,
        IComparable<HPSXA>,
        IEquatable<HPSXA>,
        IFormattable
{
    public readonly void* Value;

    public HPSXA(void* value)
    {
        Value = value;
    }

    public static HPSXA INVALID_VALUE => new HPSXA((void*)(-1));
    public static HPSXA NULL => new HPSXA(null);

    public static bool operator ==(HPSXA left, HPSXA right) => left.Value == right.Value;

    public static bool operator !=(HPSXA left, HPSXA right) => left.Value != right.Value;

    public static bool operator <(HPSXA left, HPSXA right) => left.Value < right.Value;

    public static bool operator <=(HPSXA left, HPSXA right) => left.Value <= right.Value;

    public static bool operator >(HPSXA left, HPSXA right) => left.Value > right.Value;

    public static bool operator >=(HPSXA left, HPSXA right) => left.Value >= right.Value;

    public static explicit operator HPSXA(void* value) => new HPSXA(value);

    public static implicit operator void*(HPSXA value) => value.Value;

    public static explicit operator HPSXA(HANDLE value) => new HPSXA(value);

    public static implicit operator HANDLE(HPSXA value) => new HANDLE(value.Value);

    public static explicit operator HPSXA(byte value) => new HPSXA(unchecked((void*)(value)));

    public static explicit operator byte(HPSXA value) => (byte)(value.Value);

    public static explicit operator HPSXA(short value) => new HPSXA(unchecked((void*)(value)));

    public static explicit operator short(HPSXA value) => (short)(value.Value);

    public static explicit operator HPSXA(int value) => new HPSXA(unchecked((void*)(value)));

    public static explicit operator int(HPSXA value) => (int)(value.Value);

    public static explicit operator HPSXA(long value) => new HPSXA(unchecked((void*)(value)));

    public static explicit operator long(HPSXA value) => (long)(value.Value);

    public static explicit operator HPSXA(nint value) => new HPSXA(unchecked((void*)(value)));

    public static implicit operator nint(HPSXA value) => (nint)(value.Value);

    public static explicit operator HPSXA(sbyte value) => new HPSXA(unchecked((void*)(value)));

    public static explicit operator sbyte(HPSXA value) => (sbyte)(value.Value);

    public static explicit operator HPSXA(ushort value) => new HPSXA(unchecked((void*)(value)));

    public static explicit operator ushort(HPSXA value) => (ushort)(value.Value);

    public static explicit operator HPSXA(uint value) => new HPSXA(unchecked((void*)(value)));

    public static explicit operator uint(HPSXA value) => (uint)(value.Value);

    public static explicit operator HPSXA(ulong value) => new HPSXA(unchecked((void*)(value)));

    public static explicit operator ulong(HPSXA value) => (ulong)(value.Value);

    public static explicit operator HPSXA(nuint value) => new HPSXA(unchecked((void*)(value)));

    public static implicit operator nuint(HPSXA value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HPSXA other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HPSXA.");
    }

    public int CompareTo(HPSXA other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HPSXA other) && Equals(other);

    public bool Equals(HPSXA other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
