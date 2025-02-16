// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct EC_OBJECT_ARRAY_PROPERTY_HANDLE
    : IComparable,
        IComparable<EC_OBJECT_ARRAY_PROPERTY_HANDLE>,
        IEquatable<EC_OBJECT_ARRAY_PROPERTY_HANDLE>,
        IFormattable
{
    public readonly void* Value;

    public EC_OBJECT_ARRAY_PROPERTY_HANDLE(void* value)
    {
        Value = value;
    }

    public static EC_OBJECT_ARRAY_PROPERTY_HANDLE INVALID_VALUE =>
        new EC_OBJECT_ARRAY_PROPERTY_HANDLE((void*)(-1));
    public static EC_OBJECT_ARRAY_PROPERTY_HANDLE NULL => new EC_OBJECT_ARRAY_PROPERTY_HANDLE(null);

    public static bool operator ==(
        EC_OBJECT_ARRAY_PROPERTY_HANDLE left,
        EC_OBJECT_ARRAY_PROPERTY_HANDLE right
    ) => left.Value == right.Value;

    public static bool operator !=(
        EC_OBJECT_ARRAY_PROPERTY_HANDLE left,
        EC_OBJECT_ARRAY_PROPERTY_HANDLE right
    ) => left.Value != right.Value;

    public static bool operator <(
        EC_OBJECT_ARRAY_PROPERTY_HANDLE left,
        EC_OBJECT_ARRAY_PROPERTY_HANDLE right
    ) => left.Value < right.Value;

    public static bool operator <=(
        EC_OBJECT_ARRAY_PROPERTY_HANDLE left,
        EC_OBJECT_ARRAY_PROPERTY_HANDLE right
    ) => left.Value <= right.Value;

    public static bool operator >(
        EC_OBJECT_ARRAY_PROPERTY_HANDLE left,
        EC_OBJECT_ARRAY_PROPERTY_HANDLE right
    ) => left.Value > right.Value;

    public static bool operator >=(
        EC_OBJECT_ARRAY_PROPERTY_HANDLE left,
        EC_OBJECT_ARRAY_PROPERTY_HANDLE right
    ) => left.Value >= right.Value;

    public static explicit operator EC_OBJECT_ARRAY_PROPERTY_HANDLE(void* value) =>
        new EC_OBJECT_ARRAY_PROPERTY_HANDLE(value);

    public static implicit operator void*(EC_OBJECT_ARRAY_PROPERTY_HANDLE value) => value.Value;

    public static explicit operator EC_OBJECT_ARRAY_PROPERTY_HANDLE(HANDLE value) =>
        new EC_OBJECT_ARRAY_PROPERTY_HANDLE(value);

    public static implicit operator HANDLE(EC_OBJECT_ARRAY_PROPERTY_HANDLE value) =>
        new HANDLE(value.Value);

    public static explicit operator EC_OBJECT_ARRAY_PROPERTY_HANDLE(byte value) =>
        new EC_OBJECT_ARRAY_PROPERTY_HANDLE(unchecked((void*)(value)));

    public static explicit operator byte(EC_OBJECT_ARRAY_PROPERTY_HANDLE value) =>
        (byte)(value.Value);

    public static explicit operator EC_OBJECT_ARRAY_PROPERTY_HANDLE(short value) =>
        new EC_OBJECT_ARRAY_PROPERTY_HANDLE(unchecked((void*)(value)));

    public static explicit operator short(EC_OBJECT_ARRAY_PROPERTY_HANDLE value) =>
        (short)(value.Value);

    public static explicit operator EC_OBJECT_ARRAY_PROPERTY_HANDLE(int value) =>
        new EC_OBJECT_ARRAY_PROPERTY_HANDLE(unchecked((void*)(value)));

    public static explicit operator int(EC_OBJECT_ARRAY_PROPERTY_HANDLE value) =>
        (int)(value.Value);

    public static explicit operator EC_OBJECT_ARRAY_PROPERTY_HANDLE(long value) =>
        new EC_OBJECT_ARRAY_PROPERTY_HANDLE(unchecked((void*)(value)));

    public static explicit operator long(EC_OBJECT_ARRAY_PROPERTY_HANDLE value) =>
        (long)(value.Value);

    public static explicit operator EC_OBJECT_ARRAY_PROPERTY_HANDLE(nint value) =>
        new EC_OBJECT_ARRAY_PROPERTY_HANDLE(unchecked((void*)(value)));

    public static implicit operator nint(EC_OBJECT_ARRAY_PROPERTY_HANDLE value) =>
        (nint)(value.Value);

    public static explicit operator EC_OBJECT_ARRAY_PROPERTY_HANDLE(sbyte value) =>
        new EC_OBJECT_ARRAY_PROPERTY_HANDLE(unchecked((void*)(value)));

    public static explicit operator sbyte(EC_OBJECT_ARRAY_PROPERTY_HANDLE value) =>
        (sbyte)(value.Value);

    public static explicit operator EC_OBJECT_ARRAY_PROPERTY_HANDLE(ushort value) =>
        new EC_OBJECT_ARRAY_PROPERTY_HANDLE(unchecked((void*)(value)));

    public static explicit operator ushort(EC_OBJECT_ARRAY_PROPERTY_HANDLE value) =>
        (ushort)(value.Value);

    public static explicit operator EC_OBJECT_ARRAY_PROPERTY_HANDLE(uint value) =>
        new EC_OBJECT_ARRAY_PROPERTY_HANDLE(unchecked((void*)(value)));

    public static explicit operator uint(EC_OBJECT_ARRAY_PROPERTY_HANDLE value) =>
        (uint)(value.Value);

    public static explicit operator EC_OBJECT_ARRAY_PROPERTY_HANDLE(ulong value) =>
        new EC_OBJECT_ARRAY_PROPERTY_HANDLE(unchecked((void*)(value)));

    public static explicit operator ulong(EC_OBJECT_ARRAY_PROPERTY_HANDLE value) =>
        (ulong)(value.Value);

    public static explicit operator EC_OBJECT_ARRAY_PROPERTY_HANDLE(nuint value) =>
        new EC_OBJECT_ARRAY_PROPERTY_HANDLE(unchecked((void*)(value)));

    public static implicit operator nuint(EC_OBJECT_ARRAY_PROPERTY_HANDLE value) =>
        (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is EC_OBJECT_ARRAY_PROPERTY_HANDLE other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException(
                "obj is not an instance of EC_OBJECT_ARRAY_PROPERTY_HANDLE."
            );
    }

    public int CompareTo(EC_OBJECT_ARRAY_PROPERTY_HANDLE other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is EC_OBJECT_ARRAY_PROPERTY_HANDLE other) && Equals(other);

    public bool Equals(EC_OBJECT_ARRAY_PROPERTY_HANDLE other) =>
        ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
