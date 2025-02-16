// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct PACKAGE_INFO_REFERENCE
    : IComparable,
        IComparable<PACKAGE_INFO_REFERENCE>,
        IEquatable<PACKAGE_INFO_REFERENCE>,
        IFormattable
{
    public readonly void* Value;

    public PACKAGE_INFO_REFERENCE(void* value)
    {
        Value = value;
    }

    public static PACKAGE_INFO_REFERENCE NULL => new PACKAGE_INFO_REFERENCE(null);

    public static bool operator ==(PACKAGE_INFO_REFERENCE left, PACKAGE_INFO_REFERENCE right) =>
        left.Value == right.Value;

    public static bool operator !=(PACKAGE_INFO_REFERENCE left, PACKAGE_INFO_REFERENCE right) =>
        left.Value != right.Value;

    public static bool operator <(PACKAGE_INFO_REFERENCE left, PACKAGE_INFO_REFERENCE right) =>
        left.Value < right.Value;

    public static bool operator <=(PACKAGE_INFO_REFERENCE left, PACKAGE_INFO_REFERENCE right) =>
        left.Value <= right.Value;

    public static bool operator >(PACKAGE_INFO_REFERENCE left, PACKAGE_INFO_REFERENCE right) =>
        left.Value > right.Value;

    public static bool operator >=(PACKAGE_INFO_REFERENCE left, PACKAGE_INFO_REFERENCE right) =>
        left.Value >= right.Value;

    public static explicit operator PACKAGE_INFO_REFERENCE(void* value) =>
        new PACKAGE_INFO_REFERENCE(value);

    public static implicit operator void*(PACKAGE_INFO_REFERENCE value) => value.Value;

    public static explicit operator PACKAGE_INFO_REFERENCE(byte value) =>
        new PACKAGE_INFO_REFERENCE(unchecked((void*)(value)));

    public static explicit operator byte(PACKAGE_INFO_REFERENCE value) => (byte)(value.Value);

    public static explicit operator PACKAGE_INFO_REFERENCE(short value) =>
        new PACKAGE_INFO_REFERENCE(unchecked((void*)(value)));

    public static explicit operator short(PACKAGE_INFO_REFERENCE value) => (short)(value.Value);

    public static explicit operator PACKAGE_INFO_REFERENCE(int value) =>
        new PACKAGE_INFO_REFERENCE(unchecked((void*)(value)));

    public static explicit operator int(PACKAGE_INFO_REFERENCE value) => (int)(value.Value);

    public static explicit operator PACKAGE_INFO_REFERENCE(long value) =>
        new PACKAGE_INFO_REFERENCE(unchecked((void*)(value)));

    public static explicit operator long(PACKAGE_INFO_REFERENCE value) => (long)(value.Value);

    public static explicit operator PACKAGE_INFO_REFERENCE(nint value) =>
        new PACKAGE_INFO_REFERENCE(unchecked((void*)(value)));

    public static implicit operator nint(PACKAGE_INFO_REFERENCE value) => (nint)(value.Value);

    public static explicit operator PACKAGE_INFO_REFERENCE(sbyte value) =>
        new PACKAGE_INFO_REFERENCE(unchecked((void*)(value)));

    public static explicit operator sbyte(PACKAGE_INFO_REFERENCE value) => (sbyte)(value.Value);

    public static explicit operator PACKAGE_INFO_REFERENCE(ushort value) =>
        new PACKAGE_INFO_REFERENCE(unchecked((void*)(value)));

    public static explicit operator ushort(PACKAGE_INFO_REFERENCE value) => (ushort)(value.Value);

    public static explicit operator PACKAGE_INFO_REFERENCE(uint value) =>
        new PACKAGE_INFO_REFERENCE(unchecked((void*)(value)));

    public static explicit operator uint(PACKAGE_INFO_REFERENCE value) => (uint)(value.Value);

    public static explicit operator PACKAGE_INFO_REFERENCE(ulong value) =>
        new PACKAGE_INFO_REFERENCE(unchecked((void*)(value)));

    public static explicit operator ulong(PACKAGE_INFO_REFERENCE value) => (ulong)(value.Value);

    public static explicit operator PACKAGE_INFO_REFERENCE(nuint value) =>
        new PACKAGE_INFO_REFERENCE(unchecked((void*)(value)));

    public static implicit operator nuint(PACKAGE_INFO_REFERENCE value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is PACKAGE_INFO_REFERENCE other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of PACKAGE_INFO_REFERENCE.");
    }

    public int CompareTo(PACKAGE_INFO_REFERENCE other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is PACKAGE_INFO_REFERENCE other) && Equals(other);

    public bool Equals(PACKAGE_INFO_REFERENCE other) =>
        ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
