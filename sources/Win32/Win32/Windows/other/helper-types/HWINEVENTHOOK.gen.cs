// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HWINEVENTHOOK
    : IComparable,
        IComparable<HWINEVENTHOOK>,
        IEquatable<HWINEVENTHOOK>,
        IFormattable
{
    public readonly void* Value;

    public HWINEVENTHOOK(void* value)
    {
        Value = value;
    }

    public static HWINEVENTHOOK INVALID_VALUE => new HWINEVENTHOOK((void*)(-1));
    public static HWINEVENTHOOK NULL => new HWINEVENTHOOK(null);

    public static bool operator ==(HWINEVENTHOOK left, HWINEVENTHOOK right) =>
        left.Value == right.Value;

    public static bool operator !=(HWINEVENTHOOK left, HWINEVENTHOOK right) =>
        left.Value != right.Value;

    public static bool operator <(HWINEVENTHOOK left, HWINEVENTHOOK right) =>
        left.Value < right.Value;

    public static bool operator <=(HWINEVENTHOOK left, HWINEVENTHOOK right) =>
        left.Value <= right.Value;

    public static bool operator >(HWINEVENTHOOK left, HWINEVENTHOOK right) =>
        left.Value > right.Value;

    public static bool operator >=(HWINEVENTHOOK left, HWINEVENTHOOK right) =>
        left.Value >= right.Value;

    public static explicit operator HWINEVENTHOOK(void* value) => new HWINEVENTHOOK(value);

    public static implicit operator void*(HWINEVENTHOOK value) => value.Value;

    public static explicit operator HWINEVENTHOOK(HANDLE value) => new HWINEVENTHOOK(value);

    public static implicit operator HANDLE(HWINEVENTHOOK value) => new HANDLE(value.Value);

    public static explicit operator HWINEVENTHOOK(byte value) =>
        new HWINEVENTHOOK(unchecked((void*)(value)));

    public static explicit operator byte(HWINEVENTHOOK value) => (byte)(value.Value);

    public static explicit operator HWINEVENTHOOK(short value) =>
        new HWINEVENTHOOK(unchecked((void*)(value)));

    public static explicit operator short(HWINEVENTHOOK value) => (short)(value.Value);

    public static explicit operator HWINEVENTHOOK(int value) =>
        new HWINEVENTHOOK(unchecked((void*)(value)));

    public static explicit operator int(HWINEVENTHOOK value) => (int)(value.Value);

    public static explicit operator HWINEVENTHOOK(long value) =>
        new HWINEVENTHOOK(unchecked((void*)(value)));

    public static explicit operator long(HWINEVENTHOOK value) => (long)(value.Value);

    public static explicit operator HWINEVENTHOOK(nint value) =>
        new HWINEVENTHOOK(unchecked((void*)(value)));

    public static implicit operator nint(HWINEVENTHOOK value) => (nint)(value.Value);

    public static explicit operator HWINEVENTHOOK(sbyte value) =>
        new HWINEVENTHOOK(unchecked((void*)(value)));

    public static explicit operator sbyte(HWINEVENTHOOK value) => (sbyte)(value.Value);

    public static explicit operator HWINEVENTHOOK(ushort value) =>
        new HWINEVENTHOOK(unchecked((void*)(value)));

    public static explicit operator ushort(HWINEVENTHOOK value) => (ushort)(value.Value);

    public static explicit operator HWINEVENTHOOK(uint value) =>
        new HWINEVENTHOOK(unchecked((void*)(value)));

    public static explicit operator uint(HWINEVENTHOOK value) => (uint)(value.Value);

    public static explicit operator HWINEVENTHOOK(ulong value) =>
        new HWINEVENTHOOK(unchecked((void*)(value)));

    public static explicit operator ulong(HWINEVENTHOOK value) => (ulong)(value.Value);

    public static explicit operator HWINEVENTHOOK(nuint value) =>
        new HWINEVENTHOOK(unchecked((void*)(value)));

    public static implicit operator nuint(HWINEVENTHOOK value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HWINEVENTHOOK other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HWINEVENTHOOK.");
    }

    public int CompareTo(HWINEVENTHOOK other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HWINEVENTHOOK other) && Equals(other);

    public bool Equals(HWINEVENTHOOK other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
