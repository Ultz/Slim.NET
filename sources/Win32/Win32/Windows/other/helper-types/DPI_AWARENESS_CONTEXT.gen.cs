// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct DPI_AWARENESS_CONTEXT
    : IComparable,
        IComparable<DPI_AWARENESS_CONTEXT>,
        IEquatable<DPI_AWARENESS_CONTEXT>,
        IFormattable
{
    public readonly void* Value;

    public DPI_AWARENESS_CONTEXT(void* value)
    {
        Value = value;
    }

    public static DPI_AWARENESS_CONTEXT INVALID_VALUE => new DPI_AWARENESS_CONTEXT((void*)(-1));
    public static DPI_AWARENESS_CONTEXT NULL => new DPI_AWARENESS_CONTEXT(null);

    public static bool operator ==(DPI_AWARENESS_CONTEXT left, DPI_AWARENESS_CONTEXT right) =>
        left.Value == right.Value;

    public static bool operator !=(DPI_AWARENESS_CONTEXT left, DPI_AWARENESS_CONTEXT right) =>
        left.Value != right.Value;

    public static bool operator <(DPI_AWARENESS_CONTEXT left, DPI_AWARENESS_CONTEXT right) =>
        left.Value < right.Value;

    public static bool operator <=(DPI_AWARENESS_CONTEXT left, DPI_AWARENESS_CONTEXT right) =>
        left.Value <= right.Value;

    public static bool operator >(DPI_AWARENESS_CONTEXT left, DPI_AWARENESS_CONTEXT right) =>
        left.Value > right.Value;

    public static bool operator >=(DPI_AWARENESS_CONTEXT left, DPI_AWARENESS_CONTEXT right) =>
        left.Value >= right.Value;

    public static explicit operator DPI_AWARENESS_CONTEXT(void* value) =>
        new DPI_AWARENESS_CONTEXT(value);

    public static implicit operator void*(DPI_AWARENESS_CONTEXT value) => value.Value;

    public static explicit operator DPI_AWARENESS_CONTEXT(HANDLE value) =>
        new DPI_AWARENESS_CONTEXT(value);

    public static implicit operator HANDLE(DPI_AWARENESS_CONTEXT value) => new HANDLE(value.Value);

    public static explicit operator DPI_AWARENESS_CONTEXT(byte value) =>
        new DPI_AWARENESS_CONTEXT(unchecked((void*)(value)));

    public static explicit operator byte(DPI_AWARENESS_CONTEXT value) => (byte)(value.Value);

    public static explicit operator DPI_AWARENESS_CONTEXT(short value) =>
        new DPI_AWARENESS_CONTEXT(unchecked((void*)(value)));

    public static explicit operator short(DPI_AWARENESS_CONTEXT value) => (short)(value.Value);

    public static explicit operator DPI_AWARENESS_CONTEXT(int value) =>
        new DPI_AWARENESS_CONTEXT(unchecked((void*)(value)));

    public static explicit operator int(DPI_AWARENESS_CONTEXT value) => (int)(value.Value);

    public static explicit operator DPI_AWARENESS_CONTEXT(long value) =>
        new DPI_AWARENESS_CONTEXT(unchecked((void*)(value)));

    public static explicit operator long(DPI_AWARENESS_CONTEXT value) => (long)(value.Value);

    public static explicit operator DPI_AWARENESS_CONTEXT(nint value) =>
        new DPI_AWARENESS_CONTEXT(unchecked((void*)(value)));

    public static implicit operator nint(DPI_AWARENESS_CONTEXT value) => (nint)(value.Value);

    public static explicit operator DPI_AWARENESS_CONTEXT(sbyte value) =>
        new DPI_AWARENESS_CONTEXT(unchecked((void*)(value)));

    public static explicit operator sbyte(DPI_AWARENESS_CONTEXT value) => (sbyte)(value.Value);

    public static explicit operator DPI_AWARENESS_CONTEXT(ushort value) =>
        new DPI_AWARENESS_CONTEXT(unchecked((void*)(value)));

    public static explicit operator ushort(DPI_AWARENESS_CONTEXT value) => (ushort)(value.Value);

    public static explicit operator DPI_AWARENESS_CONTEXT(uint value) =>
        new DPI_AWARENESS_CONTEXT(unchecked((void*)(value)));

    public static explicit operator uint(DPI_AWARENESS_CONTEXT value) => (uint)(value.Value);

    public static explicit operator DPI_AWARENESS_CONTEXT(ulong value) =>
        new DPI_AWARENESS_CONTEXT(unchecked((void*)(value)));

    public static explicit operator ulong(DPI_AWARENESS_CONTEXT value) => (ulong)(value.Value);

    public static explicit operator DPI_AWARENESS_CONTEXT(nuint value) =>
        new DPI_AWARENESS_CONTEXT(unchecked((void*)(value)));

    public static implicit operator nuint(DPI_AWARENESS_CONTEXT value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is DPI_AWARENESS_CONTEXT other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of DPI_AWARENESS_CONTEXT.");
    }

    public int CompareTo(DPI_AWARENESS_CONTEXT other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is DPI_AWARENESS_CONTEXT other) && Equals(other);

    public bool Equals(DPI_AWARENESS_CONTEXT other) =>
        ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
