// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HPAINTBUFFER
    : IComparable,
        IComparable<HPAINTBUFFER>,
        IEquatable<HPAINTBUFFER>,
        IFormattable
{
    public readonly void* Value;

    public HPAINTBUFFER(void* value)
    {
        Value = value;
    }

    public static HPAINTBUFFER INVALID_VALUE => new HPAINTBUFFER((void*)(-1));
    public static HPAINTBUFFER NULL => new HPAINTBUFFER(null);

    public static bool operator ==(HPAINTBUFFER left, HPAINTBUFFER right) =>
        left.Value == right.Value;

    public static bool operator !=(HPAINTBUFFER left, HPAINTBUFFER right) =>
        left.Value != right.Value;

    public static bool operator <(HPAINTBUFFER left, HPAINTBUFFER right) =>
        left.Value < right.Value;

    public static bool operator <=(HPAINTBUFFER left, HPAINTBUFFER right) =>
        left.Value <= right.Value;

    public static bool operator >(HPAINTBUFFER left, HPAINTBUFFER right) =>
        left.Value > right.Value;

    public static bool operator >=(HPAINTBUFFER left, HPAINTBUFFER right) =>
        left.Value >= right.Value;

    public static explicit operator HPAINTBUFFER(void* value) => new HPAINTBUFFER(value);

    public static implicit operator void*(HPAINTBUFFER value) => value.Value;

    public static explicit operator HPAINTBUFFER(HANDLE value) => new HPAINTBUFFER(value);

    public static implicit operator HANDLE(HPAINTBUFFER value) => new HANDLE(value.Value);

    public static explicit operator HPAINTBUFFER(byte value) =>
        new HPAINTBUFFER(unchecked((void*)(value)));

    public static explicit operator byte(HPAINTBUFFER value) => (byte)(value.Value);

    public static explicit operator HPAINTBUFFER(short value) =>
        new HPAINTBUFFER(unchecked((void*)(value)));

    public static explicit operator short(HPAINTBUFFER value) => (short)(value.Value);

    public static explicit operator HPAINTBUFFER(int value) =>
        new HPAINTBUFFER(unchecked((void*)(value)));

    public static explicit operator int(HPAINTBUFFER value) => (int)(value.Value);

    public static explicit operator HPAINTBUFFER(long value) =>
        new HPAINTBUFFER(unchecked((void*)(value)));

    public static explicit operator long(HPAINTBUFFER value) => (long)(value.Value);

    public static explicit operator HPAINTBUFFER(nint value) =>
        new HPAINTBUFFER(unchecked((void*)(value)));

    public static implicit operator nint(HPAINTBUFFER value) => (nint)(value.Value);

    public static explicit operator HPAINTBUFFER(sbyte value) =>
        new HPAINTBUFFER(unchecked((void*)(value)));

    public static explicit operator sbyte(HPAINTBUFFER value) => (sbyte)(value.Value);

    public static explicit operator HPAINTBUFFER(ushort value) =>
        new HPAINTBUFFER(unchecked((void*)(value)));

    public static explicit operator ushort(HPAINTBUFFER value) => (ushort)(value.Value);

    public static explicit operator HPAINTBUFFER(uint value) =>
        new HPAINTBUFFER(unchecked((void*)(value)));

    public static explicit operator uint(HPAINTBUFFER value) => (uint)(value.Value);

    public static explicit operator HPAINTBUFFER(ulong value) =>
        new HPAINTBUFFER(unchecked((void*)(value)));

    public static explicit operator ulong(HPAINTBUFFER value) => (ulong)(value.Value);

    public static explicit operator HPAINTBUFFER(nuint value) =>
        new HPAINTBUFFER(unchecked((void*)(value)));

    public static implicit operator nuint(HPAINTBUFFER value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HPAINTBUFFER other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HPAINTBUFFER.");
    }

    public int CompareTo(HPAINTBUFFER other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HPAINTBUFFER other) && Equals(other);

    public bool Equals(HPAINTBUFFER other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
