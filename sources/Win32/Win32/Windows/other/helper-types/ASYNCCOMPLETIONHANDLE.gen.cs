// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct ASYNCCOMPLETIONHANDLE
    : IComparable,
        IComparable<ASYNCCOMPLETIONHANDLE>,
        IEquatable<ASYNCCOMPLETIONHANDLE>,
        IFormattable
{
    public readonly void* Value;

    public ASYNCCOMPLETIONHANDLE(void* value)
    {
        Value = value;
    }

    public static ASYNCCOMPLETIONHANDLE NULL => new ASYNCCOMPLETIONHANDLE(null);

    public static bool operator ==(ASYNCCOMPLETIONHANDLE left, ASYNCCOMPLETIONHANDLE right) =>
        left.Value == right.Value;

    public static bool operator !=(ASYNCCOMPLETIONHANDLE left, ASYNCCOMPLETIONHANDLE right) =>
        left.Value != right.Value;

    public static bool operator <(ASYNCCOMPLETIONHANDLE left, ASYNCCOMPLETIONHANDLE right) =>
        left.Value < right.Value;

    public static bool operator <=(ASYNCCOMPLETIONHANDLE left, ASYNCCOMPLETIONHANDLE right) =>
        left.Value <= right.Value;

    public static bool operator >(ASYNCCOMPLETIONHANDLE left, ASYNCCOMPLETIONHANDLE right) =>
        left.Value > right.Value;

    public static bool operator >=(ASYNCCOMPLETIONHANDLE left, ASYNCCOMPLETIONHANDLE right) =>
        left.Value >= right.Value;

    public static explicit operator ASYNCCOMPLETIONHANDLE(void* value) =>
        new ASYNCCOMPLETIONHANDLE(value);

    public static implicit operator void*(ASYNCCOMPLETIONHANDLE value) => value.Value;

    public static explicit operator ASYNCCOMPLETIONHANDLE(byte value) =>
        new ASYNCCOMPLETIONHANDLE(unchecked((void*)(value)));

    public static explicit operator byte(ASYNCCOMPLETIONHANDLE value) => (byte)(value.Value);

    public static explicit operator ASYNCCOMPLETIONHANDLE(short value) =>
        new ASYNCCOMPLETIONHANDLE(unchecked((void*)(value)));

    public static explicit operator short(ASYNCCOMPLETIONHANDLE value) => (short)(value.Value);

    public static explicit operator ASYNCCOMPLETIONHANDLE(int value) =>
        new ASYNCCOMPLETIONHANDLE(unchecked((void*)(value)));

    public static explicit operator int(ASYNCCOMPLETIONHANDLE value) => (int)(value.Value);

    public static explicit operator ASYNCCOMPLETIONHANDLE(long value) =>
        new ASYNCCOMPLETIONHANDLE(unchecked((void*)(value)));

    public static explicit operator long(ASYNCCOMPLETIONHANDLE value) => (long)(value.Value);

    public static explicit operator ASYNCCOMPLETIONHANDLE(nint value) =>
        new ASYNCCOMPLETIONHANDLE(unchecked((void*)(value)));

    public static implicit operator nint(ASYNCCOMPLETIONHANDLE value) => (nint)(value.Value);

    public static explicit operator ASYNCCOMPLETIONHANDLE(sbyte value) =>
        new ASYNCCOMPLETIONHANDLE(unchecked((void*)(value)));

    public static explicit operator sbyte(ASYNCCOMPLETIONHANDLE value) => (sbyte)(value.Value);

    public static explicit operator ASYNCCOMPLETIONHANDLE(ushort value) =>
        new ASYNCCOMPLETIONHANDLE(unchecked((void*)(value)));

    public static explicit operator ushort(ASYNCCOMPLETIONHANDLE value) => (ushort)(value.Value);

    public static explicit operator ASYNCCOMPLETIONHANDLE(uint value) =>
        new ASYNCCOMPLETIONHANDLE(unchecked((void*)(value)));

    public static explicit operator uint(ASYNCCOMPLETIONHANDLE value) => (uint)(value.Value);

    public static explicit operator ASYNCCOMPLETIONHANDLE(ulong value) =>
        new ASYNCCOMPLETIONHANDLE(unchecked((void*)(value)));

    public static explicit operator ulong(ASYNCCOMPLETIONHANDLE value) => (ulong)(value.Value);

    public static explicit operator ASYNCCOMPLETIONHANDLE(nuint value) =>
        new ASYNCCOMPLETIONHANDLE(unchecked((void*)(value)));

    public static implicit operator nuint(ASYNCCOMPLETIONHANDLE value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is ASYNCCOMPLETIONHANDLE other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of ASYNCCOMPLETIONHANDLE.");
    }

    public int CompareTo(ASYNCCOMPLETIONHANDLE other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is ASYNCCOMPLETIONHANDLE other) && Equals(other);

    public bool Equals(ASYNCCOMPLETIONHANDLE other) =>
        ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
