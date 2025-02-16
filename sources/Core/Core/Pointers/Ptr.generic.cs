using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Silk.NET.Core
{
    /// <summary>
    /// A single dimensional pointer wrapper class
    /// </summary>
    public unsafe struct Ptr<T>(T* ptr)
        where T : unmanaged
    {
        /// <summary>
        /// The native pointer
        /// </summary>
        public readonly T* Native = ptr;

        /// <summary>
        /// A reference to the pointer value
        /// </summary>
        public readonly ref T Handle => ref Unsafe.AsRef<T>(Native);

        /// <summary>
        /// Gets a ref to the offset pointer value
        /// </summary>
        /// <param name="index"></param>
        /// <returns>the offset pointer value</returns>
        public ref T this[nuint index] =>
            ref Unsafe.AsRef<T>(((nuint)Native + (index * (nuint)sizeof(T))).ToPointer());

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
        public ref T GetPinnableReference() => ref Handle;

        /// <summary>
        /// Creates a span with the given length from this pointer.
        /// </summary>
        /// <param name="length">the span length</param>
        /// <returns>the span</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Span<T> AsSpan(int length) => new(Native, length);

        /// <summary>
        /// Creates an array with the given length from this pointer.
        /// </summary>
        /// <param name="length">the span length</param>
        /// <returns>the span</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public T[] ToArray(int length) => AsSpan(length).ToArray();

        /// <summary>
        /// Determines whether a pointer and reference are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and reference are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ptr<T> lh, Ref<T> rh) => lh.Native == (void*)rh;

        /// <summary>
        /// Determines whether a pointer and reference are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and reference are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ptr<T> lh, Ref<T> rh) => lh.Native != (void*)rh;

        /// <summary>
        /// Determines whether a pointer and reference are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and reference are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ref<T> lh, Ptr<T> rh) => (void*)lh == rh.Native;

        /// <summary>
        /// Determines whether a pointer and reference are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and reference are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ref<T> lh, Ptr<T> rh) => (void*)lh != rh.Native;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ptr<T> lh, void* rh) => lh.Native == rh;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ptr<T> lh, void* rh) => lh.Native != rh;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(void* lh, Ptr<T> rh) => lh == rh.Native;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(void* lh, Ptr<T> rh) => lh != rh.Native;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ptr<T> lh, T* rh) => lh.Native == rh;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ptr<T> lh, T* rh) => lh.Native != rh;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(T* lh, Ptr<T> rh) => lh == rh.Native;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(T* lh, Ptr<T> rh) => lh != rh.Native;

        /// <summary>
        /// Determines whether a pointer and nullptr are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and nullptr are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ptr<T> lh, NullPtr rh) => lh.Native == null;

        /// <summary>
        /// Determines whether a pointer and nullptr are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and nullptr are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ptr<T> lh, NullPtr rh) => lh.Native != null;

        /// <summary>
        /// Determines whether a pointer and nullptr are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and nullptr are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(NullPtr lh, Ptr<T> rh) => null == rh.Native;

        /// <summary>
        /// Determines whether a pointer and nullptr are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and nullptr are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(NullPtr lh, Ptr<T> rh) => null != rh.Native;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ptr<T> lh, Ptr rh) => lh.Native == rh.Native;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ptr<T> lh, Ptr rh) => lh.Native != rh.Native;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ptr lh, Ptr<T> rh) => lh.Native == rh.Native;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ptr lh, Ptr<T> rh) => lh.Native != rh.Native;

        /// <summary>
        /// Creates a <see cref="Ptr"/> from a native pointer
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ptr<T>(void* ptr) => new((T*)ptr);

        /// <summary>
        /// Creates a native pointer from a <see cref="Ptr{T}"/>
        /// </summary>
        /// <param name="ptr"></param>
        public static implicit operator void*(Ptr<T> ptr) => ptr.Native;

        /// <summary>
        /// Creates a <see cref="Ptr"/> from a native pointer
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ptr<T>(T* ptr) => new((T*)ptr);

        /// <summary>
        /// Creates a native pointer from a <see cref="Ptr{T}"/>
        /// </summary>
        /// <param name="ptr"></param>
        public static implicit operator T*(Ptr<T> ptr) => ptr.Native;


        /// <summary>
        /// Creates a <see cref="nuint"/> from a <see cref="Ptr{T}"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator nuint(Ptr<T> ptr) => new(ptr.Native);

        /// <summary>
        /// Creates a <see cref="Ptr"/> from a <see cref="nuint"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ptr<T>(nuint ptr) => new((T*)ptr.ToPointer());

        /// <summary>
        /// Creates a <see cref="nint"/> from a <see cref="Ptr{T}"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator nint(Ptr<T> ptr) => new(ptr.Native);

        /// <summary>
        /// Creates a <see cref="Ptr{T}"/> from a <see cref="nint"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ptr<T>(nint ptr) => new((T*)ptr.ToPointer());

        /// <summary>
        /// Creates a <see cref="Ref{T}"/> from a <see cref="Ptr{T}"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ref<T>(Ptr<T> ptr) => ptr.Native;

        /// <summary>
        /// Creates a <see cref="Ptr{T}"/> from a <see cref="Ref{T}"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        // TODO analyzer to ensure ptr is on stack or otherwise pinned
        public static explicit operator Ptr<T>(Ref<T> ptr) => (T*)ptr;

        /// <summary>
        /// Creates a <see cref="Ptr"/> from a <see cref="Ptr{T}"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ptr(Ptr<T> ptr) => new Ptr(ptr.Native);

        /// <summary>
        /// Creates a <see cref="Ref"/> from a <see cref="Ptr{T}"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ref(Ptr<T> ptr) => ptr.Native;

        /// <summary>
        /// Creates a <see cref="Ptr{T}"/> from a <see cref="Ptr"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ptr<T>(Ptr ptr) => new Ptr(ptr.Native);

        /// <summary>
        /// Creates a string from a <see cref="Ptr{T}"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static unsafe explicit operator string(Ptr<T> ptr)
        {
            if (
                typeof(T) == typeof(char)
                || typeof(T) == typeof(short)
                || typeof(T) == typeof(ushort)
            )
            {
                fixed (void* raw = ptr)
                {
                    return new string((char*)raw);
                }
            }

            if (typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
            {
                fixed (void* raw = ptr)
                {
                    return Encoding.UTF8.GetString(
                        MemoryMarshal.CreateReadOnlySpanFromNullTerminated((byte*)raw)
                    );
                }
            }

            if (typeof(T) == typeof(int) || typeof(T) == typeof(uint))
            {
                fixed (void* raw = ptr)
                {
                    int words;
                    for (words = 0; ((uint*)raw)[words] != 0; words++)
                    {
                        // do nothing
                    }

                    return Encoding.UTF32.GetString((byte*)raw, words * 4);
                }
            }

            throw new InvalidCastException();
        }

        /// <summary>
        /// Creates a null ptr
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ptr<T>(NullPtr ptr) => new(null);

        /// <summary>
        /// Determine whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>Whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ptr<T> lh, Ptr<T> rh) => lh.Native == rh.Native;

        /// <summary>
        /// Determine whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>Whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ptr<T> lh, Ptr<T> rh) => lh.Native != rh.Native;

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
