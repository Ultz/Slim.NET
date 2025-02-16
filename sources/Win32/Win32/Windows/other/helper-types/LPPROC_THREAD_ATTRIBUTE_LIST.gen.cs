// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct LPPROC_THREAD_ATTRIBUTE_LIST
    : IComparable,
        IComparable<LPPROC_THREAD_ATTRIBUTE_LIST>,
        IEquatable<LPPROC_THREAD_ATTRIBUTE_LIST>,
        IFormattable
{
    public readonly void* Value;

    public LPPROC_THREAD_ATTRIBUTE_LIST(void* value)
    {
        Value = value;
    }

    public static LPPROC_THREAD_ATTRIBUTE_LIST NULL => new LPPROC_THREAD_ATTRIBUTE_LIST(null);

    public static bool operator ==(
        LPPROC_THREAD_ATTRIBUTE_LIST left,
        LPPROC_THREAD_ATTRIBUTE_LIST right
    ) => left.Value == right.Value;

    public static bool operator !=(
        LPPROC_THREAD_ATTRIBUTE_LIST left,
        LPPROC_THREAD_ATTRIBUTE_LIST right
    ) => left.Value != right.Value;

    public static bool operator <(
        LPPROC_THREAD_ATTRIBUTE_LIST left,
        LPPROC_THREAD_ATTRIBUTE_LIST right
    ) => left.Value < right.Value;

    public static bool operator <=(
        LPPROC_THREAD_ATTRIBUTE_LIST left,
        LPPROC_THREAD_ATTRIBUTE_LIST right
    ) => left.Value <= right.Value;

    public static bool operator >(
        LPPROC_THREAD_ATTRIBUTE_LIST left,
        LPPROC_THREAD_ATTRIBUTE_LIST right
    ) => left.Value > right.Value;

    public static bool operator >=(
        LPPROC_THREAD_ATTRIBUTE_LIST left,
        LPPROC_THREAD_ATTRIBUTE_LIST right
    ) => left.Value >= right.Value;

    public static explicit operator LPPROC_THREAD_ATTRIBUTE_LIST(void* value) =>
        new LPPROC_THREAD_ATTRIBUTE_LIST(value);

    public static implicit operator void*(LPPROC_THREAD_ATTRIBUTE_LIST value) => value.Value;

    public static explicit operator LPPROC_THREAD_ATTRIBUTE_LIST(byte value) =>
        new LPPROC_THREAD_ATTRIBUTE_LIST(unchecked((void*)(value)));

    public static explicit operator byte(LPPROC_THREAD_ATTRIBUTE_LIST value) => (byte)(value.Value);

    public static explicit operator LPPROC_THREAD_ATTRIBUTE_LIST(short value) =>
        new LPPROC_THREAD_ATTRIBUTE_LIST(unchecked((void*)(value)));

    public static explicit operator short(LPPROC_THREAD_ATTRIBUTE_LIST value) =>
        (short)(value.Value);

    public static explicit operator LPPROC_THREAD_ATTRIBUTE_LIST(int value) =>
        new LPPROC_THREAD_ATTRIBUTE_LIST(unchecked((void*)(value)));

    public static explicit operator int(LPPROC_THREAD_ATTRIBUTE_LIST value) => (int)(value.Value);

    public static explicit operator LPPROC_THREAD_ATTRIBUTE_LIST(long value) =>
        new LPPROC_THREAD_ATTRIBUTE_LIST(unchecked((void*)(value)));

    public static explicit operator long(LPPROC_THREAD_ATTRIBUTE_LIST value) => (long)(value.Value);

    public static explicit operator LPPROC_THREAD_ATTRIBUTE_LIST(nint value) =>
        new LPPROC_THREAD_ATTRIBUTE_LIST(unchecked((void*)(value)));

    public static implicit operator nint(LPPROC_THREAD_ATTRIBUTE_LIST value) => (nint)(value.Value);

    public static explicit operator LPPROC_THREAD_ATTRIBUTE_LIST(sbyte value) =>
        new LPPROC_THREAD_ATTRIBUTE_LIST(unchecked((void*)(value)));

    public static explicit operator sbyte(LPPROC_THREAD_ATTRIBUTE_LIST value) =>
        (sbyte)(value.Value);

    public static explicit operator LPPROC_THREAD_ATTRIBUTE_LIST(ushort value) =>
        new LPPROC_THREAD_ATTRIBUTE_LIST(unchecked((void*)(value)));

    public static explicit operator ushort(LPPROC_THREAD_ATTRIBUTE_LIST value) =>
        (ushort)(value.Value);

    public static explicit operator LPPROC_THREAD_ATTRIBUTE_LIST(uint value) =>
        new LPPROC_THREAD_ATTRIBUTE_LIST(unchecked((void*)(value)));

    public static explicit operator uint(LPPROC_THREAD_ATTRIBUTE_LIST value) => (uint)(value.Value);

    public static explicit operator LPPROC_THREAD_ATTRIBUTE_LIST(ulong value) =>
        new LPPROC_THREAD_ATTRIBUTE_LIST(unchecked((void*)(value)));

    public static explicit operator ulong(LPPROC_THREAD_ATTRIBUTE_LIST value) =>
        (ulong)(value.Value);

    public static explicit operator LPPROC_THREAD_ATTRIBUTE_LIST(nuint value) =>
        new LPPROC_THREAD_ATTRIBUTE_LIST(unchecked((void*)(value)));

    public static implicit operator nuint(LPPROC_THREAD_ATTRIBUTE_LIST value) =>
        (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is LPPROC_THREAD_ATTRIBUTE_LIST other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException(
                "obj is not an instance of LPPROC_THREAD_ATTRIBUTE_LIST."
            );
    }

    public int CompareTo(LPPROC_THREAD_ATTRIBUTE_LIST other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is LPPROC_THREAD_ATTRIBUTE_LIST other) && Equals(other);

    public bool Equals(LPPROC_THREAD_ATTRIBUTE_LIST other) =>
        ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
