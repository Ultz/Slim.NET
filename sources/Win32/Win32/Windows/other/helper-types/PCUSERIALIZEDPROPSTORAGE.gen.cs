// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct PCUSERIALIZEDPROPSTORAGE
    : IComparable,
        IComparable<PCUSERIALIZEDPROPSTORAGE>,
        IEquatable<PCUSERIALIZEDPROPSTORAGE>,
        IFormattable
{
    public readonly void* Value;

    public PCUSERIALIZEDPROPSTORAGE(void* value)
    {
        Value = value;
    }

    public static PCUSERIALIZEDPROPSTORAGE NULL => new PCUSERIALIZEDPROPSTORAGE(null);

    public static bool operator ==(PCUSERIALIZEDPROPSTORAGE left, PCUSERIALIZEDPROPSTORAGE right) =>
        left.Value == right.Value;

    public static bool operator !=(PCUSERIALIZEDPROPSTORAGE left, PCUSERIALIZEDPROPSTORAGE right) =>
        left.Value != right.Value;

    public static bool operator <(PCUSERIALIZEDPROPSTORAGE left, PCUSERIALIZEDPROPSTORAGE right) =>
        left.Value < right.Value;

    public static bool operator <=(PCUSERIALIZEDPROPSTORAGE left, PCUSERIALIZEDPROPSTORAGE right) =>
        left.Value <= right.Value;

    public static bool operator >(PCUSERIALIZEDPROPSTORAGE left, PCUSERIALIZEDPROPSTORAGE right) =>
        left.Value > right.Value;

    public static bool operator >=(PCUSERIALIZEDPROPSTORAGE left, PCUSERIALIZEDPROPSTORAGE right) =>
        left.Value >= right.Value;

    public static explicit operator PCUSERIALIZEDPROPSTORAGE(void* value) =>
        new PCUSERIALIZEDPROPSTORAGE(value);

    public static implicit operator void*(PCUSERIALIZEDPROPSTORAGE value) => value.Value;

    public static explicit operator PCUSERIALIZEDPROPSTORAGE(byte value) =>
        new PCUSERIALIZEDPROPSTORAGE(unchecked((void*)(value)));

    public static explicit operator byte(PCUSERIALIZEDPROPSTORAGE value) => (byte)(value.Value);

    public static explicit operator PCUSERIALIZEDPROPSTORAGE(short value) =>
        new PCUSERIALIZEDPROPSTORAGE(unchecked((void*)(value)));

    public static explicit operator short(PCUSERIALIZEDPROPSTORAGE value) => (short)(value.Value);

    public static explicit operator PCUSERIALIZEDPROPSTORAGE(int value) =>
        new PCUSERIALIZEDPROPSTORAGE(unchecked((void*)(value)));

    public static explicit operator int(PCUSERIALIZEDPROPSTORAGE value) => (int)(value.Value);

    public static explicit operator PCUSERIALIZEDPROPSTORAGE(long value) =>
        new PCUSERIALIZEDPROPSTORAGE(unchecked((void*)(value)));

    public static explicit operator long(PCUSERIALIZEDPROPSTORAGE value) => (long)(value.Value);

    public static explicit operator PCUSERIALIZEDPROPSTORAGE(nint value) =>
        new PCUSERIALIZEDPROPSTORAGE(unchecked((void*)(value)));

    public static implicit operator nint(PCUSERIALIZEDPROPSTORAGE value) => (nint)(value.Value);

    public static explicit operator PCUSERIALIZEDPROPSTORAGE(sbyte value) =>
        new PCUSERIALIZEDPROPSTORAGE(unchecked((void*)(value)));

    public static explicit operator sbyte(PCUSERIALIZEDPROPSTORAGE value) => (sbyte)(value.Value);

    public static explicit operator PCUSERIALIZEDPROPSTORAGE(ushort value) =>
        new PCUSERIALIZEDPROPSTORAGE(unchecked((void*)(value)));

    public static explicit operator ushort(PCUSERIALIZEDPROPSTORAGE value) => (ushort)(value.Value);

    public static explicit operator PCUSERIALIZEDPROPSTORAGE(uint value) =>
        new PCUSERIALIZEDPROPSTORAGE(unchecked((void*)(value)));

    public static explicit operator uint(PCUSERIALIZEDPROPSTORAGE value) => (uint)(value.Value);

    public static explicit operator PCUSERIALIZEDPROPSTORAGE(ulong value) =>
        new PCUSERIALIZEDPROPSTORAGE(unchecked((void*)(value)));

    public static explicit operator ulong(PCUSERIALIZEDPROPSTORAGE value) => (ulong)(value.Value);

    public static explicit operator PCUSERIALIZEDPROPSTORAGE(nuint value) =>
        new PCUSERIALIZEDPROPSTORAGE(unchecked((void*)(value)));

    public static implicit operator nuint(PCUSERIALIZEDPROPSTORAGE value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is PCUSERIALIZEDPROPSTORAGE other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of PCUSERIALIZEDPROPSTORAGE.");
    }

    public int CompareTo(PCUSERIALIZEDPROPSTORAGE other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is PCUSERIALIZEDPROPSTORAGE other) && Equals(other);

    public bool Equals(PCUSERIALIZEDPROPSTORAGE other) =>
        ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
