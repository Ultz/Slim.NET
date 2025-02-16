using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Silk.NET.Core
{
    /// <summary>
    /// A single dimensional pointer wrapper class
    /// </summary>
    public unsafe struct Ptr
    {
        /// <summary>
        /// Creates an instance of <see cref="Ptr"/> from a native pointer
        /// </summary>
        /// <param name="ptr"></param>
        public Ptr(void* ptr)
        {
            Native = ptr;
        }

        /// <summary>
        /// The native pointer
        /// </summary>
        public readonly void* Native;

        /// <summary>
        /// A reference to the pointer value
        /// </summary>
        public ref byte Handle => ref Unsafe.AsRef<byte>(Native);

        /// <summary>
        /// Gets a ref to the offset pointer value
        /// </summary>
        /// <param name="index"></param>
        /// <returns>the offset pointer value</returns>
        public ref byte this[nuint index] =>
            ref Unsafe.AsRef<byte>(((nuint)Native + (index)).ToPointer());

        /// <summary>
        /// Gets the underlying pointer.
        /// </summary>
        /// <returns>The underlying pointer.</returns>
        /// <remarks>
        /// This function allows a <see cref="Ptr"/> to be used in a <c>fixed</c> statement.
        /// </remarks>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public ref byte GetPinnableReference() => ref Handle;

        /// <summary>
        /// Creates a span with the given length from this pointer.
        /// </summary>
        /// <param name="length">the span length</param>
        /// <typeparam name="T"></typeparam>
        /// <returns>the span</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Span<T> AsSpan<T>(int length)
            where T : unmanaged => new(Native, length);

        /// <summary>
        /// Creates an array with the given length for this pointer
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="length"></param>
        /// <returns></returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public T[] ToArray<T>(int length)
            where T : unmanaged => AsSpan<T>(length).ToArray();

        /// <summary>
        /// Determines whether a pointer and reference are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and reference are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ptr lh, Ref rh) => lh.Native == (void*)rh;

        /// <summary>
        /// Determines whether a pointer and reference are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and reference are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ptr lh, Ref rh) => lh.Native != (void*)rh;

        /// <summary>
        /// Determines whether a pointer and reference are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and reference are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        // TODO analyzer to ensure ptr is on stack or otherwise pinned
        public static bool operator ==(Ref lh, Ptr rh) => (void*)lh == rh.Native;

        /// <summary>
        /// Determines whether a pointer and reference are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and reference are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ref lh, Ptr rh) => (void*)lh != rh.Native;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ptr lh, void* rh) => lh.Native == rh;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ptr lh, void* rh) => lh.Native != rh;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(void* lh, Ptr rh) => lh == rh.Native;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(void* lh, Ptr rh) => lh != rh.Native;

        /// <summary>
        /// Determines whether a pointer and nullptr are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and nullptr are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ptr lh, NullPtr rh) => lh.Native == null;

        /// <summary>
        /// Determines whether a pointer and nullptr are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and nullptr are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ptr lh, NullPtr rh) => lh.Native != null;

        /// <summary>
        /// Determines whether a pointer and nullptr are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and nullptr are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(NullPtr lh, Ptr rh) => null == rh.Native;

        /// <summary>
        /// Determines whether a pointer and nullptr are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and nullptr are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(NullPtr lh, Ptr rh) => null != rh.Native;

        /// <summary>
        /// Creates a <see cref="Ptr"/> from a native pointer
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ptr(void* ptr) => new(ptr);

        /// <summary>
        /// Creates a native pointer from a <see cref="Ptr"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator void*(Ptr ptr) => ptr.Native;

        /// <summary>
        /// Creates a <see cref="nuint"/> from a <see cref="Ptr"/>
        /// </summary>
        /// <param name="ptr">the pointer</param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static explicit operator nuint(Ptr ptr) => new(ptr.Native);

        /// <summary>
        /// Creates a <see cref="Ptr"/> from a <see cref="nuint"/>
        /// </summary>
        /// <param name="ptr">the integer</param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static explicit operator Ptr(nuint ptr) => new(ptr.ToPointer());

        /// <summary>
        /// Creates a <see cref="Ref"/> from a <see cref="Ptr"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ref(Ptr ptr) => ptr.Native;

        /// <summary>
        /// Creates a <see cref="Ptr"/> from a <see cref="Ref"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static explicit operator Ptr(Ref ptr) => (void*)ptr;

        /// <summary>
        /// Reads this pointer as a null terminated string
        /// </summary>
        /// <returns>null-terminated string</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public string ReadToString() => SilkMarshal.NativeToString(ref Handle) ?? string.Empty;

        /// <summary>
        /// Creates a string from a <see cref="Ptr"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static explicit operator string(Ptr ptr) => ptr.ReadToString();

        /// <summary>
        /// Casts the underlying pointer to a native-sized integer.
        /// </summary>
        /// <param name="ptr">The pointer.</param>
        /// <returns>The integer.</returns>
        public static explicit operator nint(Ptr ptr) => (nint)(void*)ptr;

        /// <summary>
        /// Interprets the given native-sized integer as a pointer.
        /// </summary>
        /// <param name="ptr">The integer.</param>
        /// <returns>The pointer.</returns>
        public static explicit operator Ptr(nint ptr) => (void*)ptr;

        /// <summary>
        /// Creates a null ptr
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ptr(NullPtr ptr) => new(null);

        /// <summary>
        /// Determine whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>Whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ptr lh, Ptr rh) => lh.Native == rh.Native;

        /// <summary>
        /// Determine whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>Whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ptr lh, Ptr rh) => lh.Native != rh.Native;

        /// <inheritdoc/>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public override bool Equals([NotNullWhen(true)] object? obj) => base.Equals(obj);

        /// <inheritdoc/>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public override int GetHashCode() => base.GetHashCode();
    }
}
