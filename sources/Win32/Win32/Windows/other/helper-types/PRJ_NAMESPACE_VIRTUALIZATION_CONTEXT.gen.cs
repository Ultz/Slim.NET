// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT
    : IComparable,
        IComparable<PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT>,
        IEquatable<PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT>,
        IFormattable
{
    public readonly void* Value;

    public PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(void* value)
    {
        Value = value;
    }

    public static PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT INVALID_VALUE =>
        new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT((void*)(-1));
    public static PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT NULL =>
        new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(null);

    public static bool operator ==(
        PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT left,
        PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT right
    ) => left.Value == right.Value;

    public static bool operator !=(
        PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT left,
        PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT right
    ) => left.Value != right.Value;

    public static bool operator <(
        PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT left,
        PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT right
    ) => left.Value < right.Value;

    public static bool operator <=(
        PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT left,
        PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT right
    ) => left.Value <= right.Value;

    public static bool operator >(
        PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT left,
        PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT right
    ) => left.Value > right.Value;

    public static bool operator >=(
        PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT left,
        PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT right
    ) => left.Value >= right.Value;

    public static explicit operator PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(void* value) =>
        new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(value);

    public static implicit operator void*(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT value) =>
        value.Value;

    public static explicit operator PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(HANDLE value) =>
        new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(value);

    public static implicit operator HANDLE(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT value) =>
        new HANDLE(value.Value);

    public static explicit operator PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(byte value) =>
        new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(unchecked((void*)(value)));

    public static explicit operator byte(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT value) =>
        (byte)(value.Value);

    public static explicit operator PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(short value) =>
        new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(unchecked((void*)(value)));

    public static explicit operator short(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT value) =>
        (short)(value.Value);

    public static explicit operator PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(int value) =>
        new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(unchecked((void*)(value)));

    public static explicit operator int(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT value) =>
        (int)(value.Value);

    public static explicit operator PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(long value) =>
        new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(unchecked((void*)(value)));

    public static explicit operator long(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT value) =>
        (long)(value.Value);

    public static explicit operator PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(nint value) =>
        new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(unchecked((void*)(value)));

    public static implicit operator nint(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT value) =>
        (nint)(value.Value);

    public static explicit operator PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(sbyte value) =>
        new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(unchecked((void*)(value)));

    public static explicit operator sbyte(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT value) =>
        (sbyte)(value.Value);

    public static explicit operator PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(ushort value) =>
        new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(unchecked((void*)(value)));

    public static explicit operator ushort(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT value) =>
        (ushort)(value.Value);

    public static explicit operator PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(uint value) =>
        new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(unchecked((void*)(value)));

    public static explicit operator uint(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT value) =>
        (uint)(value.Value);

    public static explicit operator PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(ulong value) =>
        new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(unchecked((void*)(value)));

    public static explicit operator ulong(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT value) =>
        (ulong)(value.Value);

    public static explicit operator PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(nuint value) =>
        new PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT(unchecked((void*)(value)));

    public static implicit operator nuint(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT value) =>
        (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException(
                "obj is not an instance of PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT."
            );
    }

    public int CompareTo(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT other) && Equals(other);

    public bool Equals(PRJ_NAMESPACE_VIRTUALIZATION_CONTEXT other) =>
        ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
