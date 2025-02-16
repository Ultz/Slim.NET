// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HMIXEROBJ
    : IComparable,
        IComparable<HMIXEROBJ>,
        IEquatable<HMIXEROBJ>,
        IFormattable
{
    public readonly void* Value;

    public HMIXEROBJ(void* value)
    {
        Value = value;
    }

    public static HMIXEROBJ INVALID_VALUE => new HMIXEROBJ((void*)(-1));
    public static HMIXEROBJ NULL => new HMIXEROBJ(null);

    public static bool operator ==(HMIXEROBJ left, HMIXEROBJ right) => left.Value == right.Value;

    public static bool operator !=(HMIXEROBJ left, HMIXEROBJ right) => left.Value != right.Value;

    public static bool operator <(HMIXEROBJ left, HMIXEROBJ right) => left.Value < right.Value;

    public static bool operator <=(HMIXEROBJ left, HMIXEROBJ right) => left.Value <= right.Value;

    public static bool operator >(HMIXEROBJ left, HMIXEROBJ right) => left.Value > right.Value;

    public static bool operator >=(HMIXEROBJ left, HMIXEROBJ right) => left.Value >= right.Value;

    public static explicit operator HMIXEROBJ(void* value) => new HMIXEROBJ(value);

    public static implicit operator void*(HMIXEROBJ value) => value.Value;

    public static explicit operator HMIXEROBJ(HANDLE value) => new HMIXEROBJ(value);

    public static implicit operator HANDLE(HMIXEROBJ value) => new HANDLE(value.Value);

    public static explicit operator HMIXEROBJ(byte value) =>
        new HMIXEROBJ(unchecked((void*)(value)));

    public static explicit operator byte(HMIXEROBJ value) => (byte)(value.Value);

    public static explicit operator HMIXEROBJ(short value) =>
        new HMIXEROBJ(unchecked((void*)(value)));

    public static explicit operator short(HMIXEROBJ value) => (short)(value.Value);

    public static explicit operator HMIXEROBJ(int value) =>
        new HMIXEROBJ(unchecked((void*)(value)));

    public static explicit operator int(HMIXEROBJ value) => (int)(value.Value);

    public static explicit operator HMIXEROBJ(long value) =>
        new HMIXEROBJ(unchecked((void*)(value)));

    public static explicit operator long(HMIXEROBJ value) => (long)(value.Value);

    public static explicit operator HMIXEROBJ(nint value) =>
        new HMIXEROBJ(unchecked((void*)(value)));

    public static implicit operator nint(HMIXEROBJ value) => (nint)(value.Value);

    public static explicit operator HMIXEROBJ(sbyte value) =>
        new HMIXEROBJ(unchecked((void*)(value)));

    public static explicit operator sbyte(HMIXEROBJ value) => (sbyte)(value.Value);

    public static explicit operator HMIXEROBJ(ushort value) =>
        new HMIXEROBJ(unchecked((void*)(value)));

    public static explicit operator ushort(HMIXEROBJ value) => (ushort)(value.Value);

    public static explicit operator HMIXEROBJ(uint value) =>
        new HMIXEROBJ(unchecked((void*)(value)));

    public static explicit operator uint(HMIXEROBJ value) => (uint)(value.Value);

    public static explicit operator HMIXEROBJ(ulong value) =>
        new HMIXEROBJ(unchecked((void*)(value)));

    public static explicit operator ulong(HMIXEROBJ value) => (ulong)(value.Value);

    public static explicit operator HMIXEROBJ(nuint value) =>
        new HMIXEROBJ(unchecked((void*)(value)));

    public static implicit operator nuint(HMIXEROBJ value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HMIXEROBJ other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HMIXEROBJ.");
    }

    public int CompareTo(HMIXEROBJ other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HMIXEROBJ other) && Equals(other);

    public bool Equals(HMIXEROBJ other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
