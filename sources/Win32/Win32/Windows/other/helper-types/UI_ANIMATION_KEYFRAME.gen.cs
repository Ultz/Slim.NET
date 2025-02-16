// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct UI_ANIMATION_KEYFRAME
    : IComparable,
        IComparable<UI_ANIMATION_KEYFRAME>,
        IEquatable<UI_ANIMATION_KEYFRAME>,
        IFormattable
{
    public readonly int* Value;

    public UI_ANIMATION_KEYFRAME(int* value)
    {
        Value = value;
    }

    public static UI_ANIMATION_KEYFRAME NULL => new UI_ANIMATION_KEYFRAME(null);

    public static bool operator ==(UI_ANIMATION_KEYFRAME left, UI_ANIMATION_KEYFRAME right) =>
        left.Value == right.Value;

    public static bool operator !=(UI_ANIMATION_KEYFRAME left, UI_ANIMATION_KEYFRAME right) =>
        left.Value != right.Value;

    public static bool operator <(UI_ANIMATION_KEYFRAME left, UI_ANIMATION_KEYFRAME right) =>
        left.Value < right.Value;

    public static bool operator <=(UI_ANIMATION_KEYFRAME left, UI_ANIMATION_KEYFRAME right) =>
        left.Value <= right.Value;

    public static bool operator >(UI_ANIMATION_KEYFRAME left, UI_ANIMATION_KEYFRAME right) =>
        left.Value > right.Value;

    public static bool operator >=(UI_ANIMATION_KEYFRAME left, UI_ANIMATION_KEYFRAME right) =>
        left.Value >= right.Value;

    public static explicit operator UI_ANIMATION_KEYFRAME(void* value) =>
        new UI_ANIMATION_KEYFRAME((int*)(value));

    public static implicit operator void*(UI_ANIMATION_KEYFRAME value) => value.Value;

    public static explicit operator UI_ANIMATION_KEYFRAME(byte value) =>
        new UI_ANIMATION_KEYFRAME(unchecked((int*)(value)));

    public static explicit operator byte(UI_ANIMATION_KEYFRAME value) => (byte)(value.Value);

    public static explicit operator UI_ANIMATION_KEYFRAME(short value) =>
        new UI_ANIMATION_KEYFRAME(unchecked((int*)(value)));

    public static explicit operator short(UI_ANIMATION_KEYFRAME value) => (short)(value.Value);

    public static explicit operator UI_ANIMATION_KEYFRAME(int value) =>
        new UI_ANIMATION_KEYFRAME(unchecked((int*)(value)));

    public static explicit operator int(UI_ANIMATION_KEYFRAME value) => (int)(value.Value);

    public static explicit operator UI_ANIMATION_KEYFRAME(long value) =>
        new UI_ANIMATION_KEYFRAME(unchecked((int*)(value)));

    public static explicit operator long(UI_ANIMATION_KEYFRAME value) => (long)(value.Value);

    public static explicit operator UI_ANIMATION_KEYFRAME(nint value) =>
        new UI_ANIMATION_KEYFRAME(unchecked((int*)(value)));

    public static implicit operator nint(UI_ANIMATION_KEYFRAME value) => (nint)(value.Value);

    public static explicit operator UI_ANIMATION_KEYFRAME(sbyte value) =>
        new UI_ANIMATION_KEYFRAME(unchecked((int*)(value)));

    public static explicit operator sbyte(UI_ANIMATION_KEYFRAME value) => (sbyte)(value.Value);

    public static explicit operator UI_ANIMATION_KEYFRAME(ushort value) =>
        new UI_ANIMATION_KEYFRAME(unchecked((int*)(value)));

    public static explicit operator ushort(UI_ANIMATION_KEYFRAME value) => (ushort)(value.Value);

    public static explicit operator UI_ANIMATION_KEYFRAME(uint value) =>
        new UI_ANIMATION_KEYFRAME(unchecked((int*)(value)));

    public static explicit operator uint(UI_ANIMATION_KEYFRAME value) => (uint)(value.Value);

    public static explicit operator UI_ANIMATION_KEYFRAME(ulong value) =>
        new UI_ANIMATION_KEYFRAME(unchecked((int*)(value)));

    public static explicit operator ulong(UI_ANIMATION_KEYFRAME value) => (ulong)(value.Value);

    public static explicit operator UI_ANIMATION_KEYFRAME(nuint value) =>
        new UI_ANIMATION_KEYFRAME(unchecked((int*)(value)));

    public static implicit operator nuint(UI_ANIMATION_KEYFRAME value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is UI_ANIMATION_KEYFRAME other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of UI_ANIMATION_KEYFRAME.");
    }

    public int CompareTo(UI_ANIMATION_KEYFRAME other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is UI_ANIMATION_KEYFRAME other) && Equals(other);

    public bool Equals(UI_ANIMATION_KEYFRAME other) =>
        ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
