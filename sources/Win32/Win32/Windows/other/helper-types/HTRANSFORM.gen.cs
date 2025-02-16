// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HTRANSFORM
    : IComparable,
        IComparable<HTRANSFORM>,
        IEquatable<HTRANSFORM>,
        IFormattable
{
    public readonly void* Value;

    public HTRANSFORM(void* value)
    {
        Value = value;
    }

    public static HTRANSFORM INVALID_VALUE => new HTRANSFORM((void*)(-1));
    public static HTRANSFORM NULL => new HTRANSFORM(null);

    public static bool operator ==(HTRANSFORM left, HTRANSFORM right) => left.Value == right.Value;

    public static bool operator !=(HTRANSFORM left, HTRANSFORM right) => left.Value != right.Value;

    public static bool operator <(HTRANSFORM left, HTRANSFORM right) => left.Value < right.Value;

    public static bool operator <=(HTRANSFORM left, HTRANSFORM right) => left.Value <= right.Value;

    public static bool operator >(HTRANSFORM left, HTRANSFORM right) => left.Value > right.Value;

    public static bool operator >=(HTRANSFORM left, HTRANSFORM right) => left.Value >= right.Value;

    public static explicit operator HTRANSFORM(void* value) => new HTRANSFORM(value);

    public static implicit operator void*(HTRANSFORM value) => value.Value;

    public static explicit operator HTRANSFORM(HANDLE value) => new HTRANSFORM(value);

    public static implicit operator HANDLE(HTRANSFORM value) => new HANDLE(value.Value);

    public static explicit operator HTRANSFORM(byte value) =>
        new HTRANSFORM(unchecked((void*)(value)));

    public static explicit operator byte(HTRANSFORM value) => (byte)(value.Value);

    public static explicit operator HTRANSFORM(short value) =>
        new HTRANSFORM(unchecked((void*)(value)));

    public static explicit operator short(HTRANSFORM value) => (short)(value.Value);

    public static explicit operator HTRANSFORM(int value) =>
        new HTRANSFORM(unchecked((void*)(value)));

    public static explicit operator int(HTRANSFORM value) => (int)(value.Value);

    public static explicit operator HTRANSFORM(long value) =>
        new HTRANSFORM(unchecked((void*)(value)));

    public static explicit operator long(HTRANSFORM value) => (long)(value.Value);

    public static explicit operator HTRANSFORM(nint value) =>
        new HTRANSFORM(unchecked((void*)(value)));

    public static implicit operator nint(HTRANSFORM value) => (nint)(value.Value);

    public static explicit operator HTRANSFORM(sbyte value) =>
        new HTRANSFORM(unchecked((void*)(value)));

    public static explicit operator sbyte(HTRANSFORM value) => (sbyte)(value.Value);

    public static explicit operator HTRANSFORM(ushort value) =>
        new HTRANSFORM(unchecked((void*)(value)));

    public static explicit operator ushort(HTRANSFORM value) => (ushort)(value.Value);

    public static explicit operator HTRANSFORM(uint value) =>
        new HTRANSFORM(unchecked((void*)(value)));

    public static explicit operator uint(HTRANSFORM value) => (uint)(value.Value);

    public static explicit operator HTRANSFORM(ulong value) =>
        new HTRANSFORM(unchecked((void*)(value)));

    public static explicit operator ulong(HTRANSFORM value) => (ulong)(value.Value);

    public static explicit operator HTRANSFORM(nuint value) =>
        new HTRANSFORM(unchecked((void*)(value)));

    public static implicit operator nuint(HTRANSFORM value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HTRANSFORM other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HTRANSFORM.");
    }

    public int CompareTo(HTRANSFORM other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HTRANSFORM other) && Equals(other);

    public bool Equals(HTRANSFORM other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
