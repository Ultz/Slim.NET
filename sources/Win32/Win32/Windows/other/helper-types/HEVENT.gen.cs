// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HEVENT
    : IComparable,
        IComparable<HEVENT>,
        IEquatable<HEVENT>,
        IFormattable
{
    public readonly void* Value;

    public HEVENT(void* value)
    {
        Value = value;
    }

    public static HEVENT INVALID_VALUE => new HEVENT((void*)(-1));
    public static HEVENT NULL => new HEVENT(null);

    public static bool operator ==(HEVENT left, HEVENT right) => left.Value == right.Value;

    public static bool operator !=(HEVENT left, HEVENT right) => left.Value != right.Value;

    public static bool operator <(HEVENT left, HEVENT right) => left.Value < right.Value;

    public static bool operator <=(HEVENT left, HEVENT right) => left.Value <= right.Value;

    public static bool operator >(HEVENT left, HEVENT right) => left.Value > right.Value;

    public static bool operator >=(HEVENT left, HEVENT right) => left.Value >= right.Value;

    public static explicit operator HEVENT(void* value) => new HEVENT(value);

    public static implicit operator void*(HEVENT value) => value.Value;

    public static explicit operator HEVENT(HANDLE value) => new HEVENT(value);

    public static implicit operator HANDLE(HEVENT value) => new HANDLE(value.Value);

    public static explicit operator HEVENT(byte value) => new HEVENT(unchecked((void*)(value)));

    public static explicit operator byte(HEVENT value) => (byte)(value.Value);

    public static explicit operator HEVENT(short value) => new HEVENT(unchecked((void*)(value)));

    public static explicit operator short(HEVENT value) => (short)(value.Value);

    public static explicit operator HEVENT(int value) => new HEVENT(unchecked((void*)(value)));

    public static explicit operator int(HEVENT value) => (int)(value.Value);

    public static explicit operator HEVENT(long value) => new HEVENT(unchecked((void*)(value)));

    public static explicit operator long(HEVENT value) => (long)(value.Value);

    public static explicit operator HEVENT(nint value) => new HEVENT(unchecked((void*)(value)));

    public static implicit operator nint(HEVENT value) => (nint)(value.Value);

    public static explicit operator HEVENT(sbyte value) => new HEVENT(unchecked((void*)(value)));

    public static explicit operator sbyte(HEVENT value) => (sbyte)(value.Value);

    public static explicit operator HEVENT(ushort value) => new HEVENT(unchecked((void*)(value)));

    public static explicit operator ushort(HEVENT value) => (ushort)(value.Value);

    public static explicit operator HEVENT(uint value) => new HEVENT(unchecked((void*)(value)));

    public static explicit operator uint(HEVENT value) => (uint)(value.Value);

    public static explicit operator HEVENT(ulong value) => new HEVENT(unchecked((void*)(value)));

    public static explicit operator ulong(HEVENT value) => (ulong)(value.Value);

    public static explicit operator HEVENT(nuint value) => new HEVENT(unchecked((void*)(value)));

    public static implicit operator nuint(HEVENT value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HEVENT other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HEVENT.");
    }

    public int CompareTo(HEVENT other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HEVENT other) && Equals(other);

    public bool Equals(HEVENT other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
