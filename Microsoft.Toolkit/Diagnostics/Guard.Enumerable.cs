﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

#nullable enable

namespace Microsoft.Toolkit.Diagnostics
{
    /// <summary>
    /// Helper methods to verify conditions when running code.
    /// </summary>
    public static partial class Guard
    {
        /// <summary>
        /// Asserts that the input <typeparamref name="T"/> array instance must be empty.
        /// </summary>
        /// <typeparam name="T">The type of items in the input <typeparamref name="T"/> array instance.</typeparam>
        /// <param name="array">The input <typeparamref name="T"/> array instance to check the size for.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="array"/> is != 0.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsEmpty<T>(T[] array, string name)
        {
            IsEmpty(new ReadOnlySpan<T>(array), name);
        }

        /// <summary>
        /// Asserts that the input <typeparamref name="T"/> array instance must not be empty.
        /// </summary>
        /// <typeparam name="T">The type of items in the input <typeparamref name="T"/> array instance.</typeparam>
        /// <param name="array">The input <typeparamref name="T"/> array instance to check the size for.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="array"/> is == 0.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNotEmpty<T>(T[] array, string name)
        {
            IsNotEmpty(new ReadOnlySpan<T>(array), name);
        }

        /// <summary>
        /// Asserts that the input <typeparamref name="T"/> array instance must have a size of a specified value.
        /// </summary>
        /// <typeparam name="T">The type of items in the input <typeparamref name="T"/> array instance.</typeparam>
        /// <param name="array">The input <typeparamref name="T"/> array instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="array"/> is != <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeEqualTo<T>(T[] array, int size, string name)
        {
            HasSizeEqualTo(new ReadOnlySpan<T>(array), size, name);
        }

        /// <summary>
        /// Asserts that the input <typeparamref name="T"/> array instance must have a size not equal to a specified value.
        /// </summary>
        /// <typeparam name="T">The type of items in the input <typeparamref name="T"/> array instance.</typeparam>
        /// <param name="array">The input <typeparamref name="T"/> array instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="array"/> is == <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeNotEqualTo<T>(T[] array, int size, string name)
        {
            HasSizeNotEqualTo(new ReadOnlySpan<T>(array), size, name);
        }

        /// <summary>
        /// Asserts that the input <typeparamref name="T"/> array instance must have a size of at least specified value.
        /// </summary>
        /// <typeparam name="T">The type of items in the input <typeparamref name="T"/> array instance.</typeparam>
        /// <param name="array">The input <typeparamref name="T"/> array instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="array"/> is &lt;= <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeAtLeast<T>(T[] array, int size, string name)
        {
            HasSizeAtLeast(new ReadOnlySpan<T>(array), size, name);
        }

        /// <summary>
        /// Asserts that the input <typeparamref name="T"/> array instance must have a size of at least or equal to a specified value.
        /// </summary>
        /// <typeparam name="T">The type of items in the input <typeparamref name="T"/> array instance.</typeparam>
        /// <param name="array">The input <typeparamref name="T"/> array instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="array"/> is &lt; <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeAtLeastOrEqualTo<T>(T[] array, int size, string name)
        {
            HasSizeAtLeastOrEqualTo(new ReadOnlySpan<T>(array), size, name);
        }

        /// <summary>
        /// Asserts that the input <typeparamref name="T"/> array instance must have a size of less than a specified value.
        /// </summary>
        /// <typeparam name="T">The type of items in the input <typeparamref name="T"/> array instance.</typeparam>
        /// <param name="array">The input <typeparamref name="T"/> array instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="array"/> is >= <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeLessThan<T>(T[] array, int size, string name)
        {
            HasSizeLessThan(new ReadOnlySpan<T>(array), size, name);
        }

        /// <summary>
        /// Asserts that the input <typeparamref name="T"/> array instance must have a size of less than or equal to a specified value.
        /// </summary>
        /// <typeparam name="T">The type of items in the input <typeparamref name="T"/> array instance.</typeparam>
        /// <param name="array">The input <typeparamref name="T"/> array instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="array"/> is > <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeLessThanOrEqualTo<T>(T[] array, int size, string name)
        {
            HasSizeLessThanOrEqualTo(new ReadOnlySpan<T>(array), size, name);
        }

        /// <summary>
        /// Asserts that the source <see cref="ReadOnlyMemory{T}"/> instance must have the same size of a destination <see cref="Memory{T}"/> instance.
        /// </summary>
        /// <typeparam name="T">The type of items in the input <see cref="ReadOnlyMemory{T}"/> instance.</typeparam>
        /// <param name="source">The source <see cref="ReadOnlyMemory{T}"/> instance to check the size for.</param>
        /// <param name="destination">The destination <see cref="Memory{T}"/> instance to check the size for.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="source"/> is != the one of <paramref name="destination"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeEqualTo<T>(T[] source, T[] destination, string name)
        {
            HasSizeEqualTo(new ReadOnlySpan<T>(source), destination.AsSpan(), name);
        }

        /// <summary>
        /// Asserts that the source <see cref="ReadOnlyMemory{T}"/> instance must have a size of less than or equal to that of a destination <see cref="Span{T}"/> instance.
        /// </summary>
        /// <typeparam name="T">The type of items in the input <see cref="ReadOnlyMemory{T}"/> instance.</typeparam>
        /// <param name="source">The source <see cref="ReadOnlyMemory{T}"/> instance to check the size for.</param>
        /// <param name="destination">The destination <see cref="Memory{T}"/> instance to check the size for.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="source"/> is > the one of <paramref name="destination"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeLessThanOrEqualTo<T>(T[] source, T[] destination, string name)
        {
            HasSizeLessThanOrEqualTo(new ReadOnlySpan<T>(source), destination.AsSpan(), name);
        }

        /// <summary>
        /// Asserts that the input <see cref="IEnumerable{T}"/> instance must be empty.
        /// </summary>
        /// <typeparam name="T">The type of items in the input <see cref="IEnumerable{T}"/> instance.</typeparam>
        /// <param name="enumerable">The input <see cref="IEnumerable{T}"/> instance to check the size for.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="enumerable"/> is != 0.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsEmpty<T>(IEnumerable<T> enumerable, string name)
        {
            if ((enumerable as ICollection<T>)?.Count is int collectionCount)
            {
                if (collectionCount != 0)
                {
                    ThrowArgumentException(name, $"Parameter {name} must be empty, had a size of {collectionCount}");

                    return;
                }
            }

            if ((enumerable as IReadOnlyCollection<T>)?.Count is int readOnlyCollectionCount)
            {
                if (readOnlyCollectionCount != 0)
                {
                    ThrowArgumentException(name, $"Parameter {name} must be empty, had a size of {readOnlyCollectionCount}");

                    return;
                }
            }

            if (enumerable.Any())
            {
                ThrowArgumentException(name, $"Parameter {name} must be empty");
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="IEnumerable{T}"/> instance must not be empty.
        /// </summary>
        /// <typeparam name="T">The type of items in the input <see cref="IEnumerable{T}"/> instance.</typeparam>
        /// <param name="enumerable">The input <see cref="IEnumerable{T}"/> instance to check the size for.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="enumerable"/> is == 0.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNotEmpty<T>(IEnumerable<T> enumerable, string name)
        {
            if ((enumerable as ICollection<T>)?.Count is int collectionCount)
            {
                if (collectionCount == 0)
                {
                    ThrowArgumentException(name, $"Parameter {name} must not be empty");

                    return;
                }
            }

            if ((enumerable as IReadOnlyCollection<T>)?.Count is int readOnlyCollectionCount)
            {
                if (readOnlyCollectionCount == 0)
                {
                    ThrowArgumentException(name, $"Parameter {name} must not be empty");

                    return;
                }
            }

            if (enumerable.Any())
            {
                ThrowArgumentException(name, $"Parameter {name} must not be empty");
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="IEnumerable{T}"/> instance must have a size of a specified value.
        /// </summary>
        /// <typeparam name="T">The type of items in the input <see cref="IEnumerable{T}"/> instance.</typeparam>
        /// <param name="enumerable">The input <see cref="IEnumerable{T}"/> instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="enumerable"/> is != <paramref name="size"/>.</exception>
        /// <remarks>The method will skip enumerating <paramref name="enumerable"/> if possible (if it's an <see cref="ICollection{T}"/> or <see cref="IReadOnlyCollection{T}"/>).</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeEqualTo<T>(IEnumerable<T> enumerable, int size, string name)
        {
            int actualSize;

            if (((enumerable as ICollection<T>)?.Count is int collectionCount &&
                 (actualSize = collectionCount) != size) ||
                ((enumerable as IReadOnlyCollection<T>)?.Count is int readOnlyCollectionCount &&
                 (actualSize = readOnlyCollectionCount) != size) ||
                (actualSize = enumerable.Count()) != size)
            {
                ThrowArgumentException(name, $"Parameter {name} must be sized == {size}, had a size of {actualSize}");
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="IEnumerable{T}"/> instance must have a size not equal to a specified value.
        /// </summary>
        /// <typeparam name="T">The type of items in the input <see cref="IEnumerable{T}"/> instance.</typeparam>
        /// <param name="enumerable">The input <see cref="IEnumerable{T}"/> instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="enumerable"/> is == <paramref name="size"/>.</exception>
        /// <remarks>The method will skip enumerating <paramref name="enumerable"/> if possible (if it's an <see cref="ICollection{T}"/> or <see cref="IReadOnlyCollection{T}"/>).</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeNotEqualTo<T>(IEnumerable<T> enumerable, int size, string name)
        {
            int actualSize;

            if (((enumerable as ICollection<T>)?.Count is int collectionCount &&
                 (actualSize = collectionCount) == size) ||
                ((enumerable as IReadOnlyCollection<T>)?.Count is int readOnlyCollectionCount &&
                 (actualSize = readOnlyCollectionCount) == size) ||
                (actualSize = enumerable.Count()) == size)
            {
                ThrowArgumentException(name, $"Parameter {name} must be sized != {size}, had a size of {actualSize}");
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="IEnumerable{T}"/> instance must have a size of at least specified value.
        /// </summary>
        /// <typeparam name="T">The type of items in the input <see cref="IEnumerable{T}"/> instance.</typeparam>
        /// <param name="enumerable">The input <see cref="IEnumerable{T}"/> instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="enumerable"/> is &lt;= <paramref name="size"/>.</exception>
        /// <remarks>The method will skip enumerating <paramref name="enumerable"/> if possible (if it's an <see cref="ICollection{T}"/> or <see cref="IReadOnlyCollection{T}"/>).</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeAtLeast<T>(IEnumerable<T> enumerable, int size, string name)
        {
            int actualSize;

            if (((enumerable as ICollection<T>)?.Count is int collectionCount &&
                 (actualSize = collectionCount) <= size) ||
                ((enumerable as IReadOnlyCollection<T>)?.Count is int readOnlyCollectionCount &&
                 (actualSize = readOnlyCollectionCount) <= size) ||
                (actualSize = enumerable.Count()) <= size)
            {
                ThrowArgumentException(name, $"Parameter {name} must be sized > {size}, had a size of {actualSize}");
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="IEnumerable{T}"/> instance must have a size of at least or equal to a specified value.
        /// </summary>
        /// <typeparam name="T">The type of items in the input <see cref="IEnumerable{T}"/> instance.</typeparam>
        /// <param name="enumerable">The input <see cref="IEnumerable{T}"/> instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="enumerable"/> is &lt; <paramref name="size"/>.</exception>
        /// <remarks>The method will skip enumerating <paramref name="enumerable"/> if possible (if it's an <see cref="ICollection{T}"/> or <see cref="IReadOnlyCollection{T}"/>).</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeAtLeastOrEqualTo<T>(IEnumerable<T> enumerable, int size, string name)
        {
            int actualSize;

            if (((enumerable as ICollection<T>)?.Count is int collectionCount &&
                 (actualSize = collectionCount) < size) ||
                ((enumerable as IReadOnlyCollection<T>)?.Count is int readOnlyCollectionCount &&
                 (actualSize = readOnlyCollectionCount) < size) ||
                (actualSize = enumerable.Count()) < size)
            {
                ThrowArgumentException(name, $"Parameter {name} must be sized >= {size}, had a size of {actualSize}");
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="IEnumerable{T}"/> instance must have a size of less than a specified value.
        /// </summary>
        /// <typeparam name="T">The type of items in the input <see cref="IEnumerable{T}"/> instance.</typeparam>
        /// <param name="enumerable">The input <see cref="IEnumerable{T}"/> instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="enumerable"/> is >= <paramref name="size"/>.</exception>
        /// <remarks>The method will skip enumerating <paramref name="enumerable"/> if possible (if it's an <see cref="ICollection{T}"/> or <see cref="IReadOnlyCollection{T}"/>).</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeLessThan<T>(IEnumerable<T> enumerable, int size, string name)
        {
            int actualSize;

            if (((enumerable as ICollection<T>)?.Count is int collectionCount &&
                 (actualSize = collectionCount) >= size) ||
                ((enumerable as IReadOnlyCollection<T>)?.Count is int readOnlyCollectionCount &&
                 (actualSize = readOnlyCollectionCount) >= size) ||
                (actualSize = enumerable.Count()) >= size)
            {
                ThrowArgumentException(name, $"Parameter {name} must be sized < {size}, had a size of {actualSize}");
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="IEnumerable{T}"/> instance must have a size of less than or equal to a specified value.
        /// </summary>
        /// <typeparam name="T">The type of items in the input <see cref="IEnumerable{T}"/> instance.</typeparam>
        /// <param name="enumerable">The input <see cref="IEnumerable{T}"/> instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="enumerable"/> is > <paramref name="size"/>.</exception>
        /// <remarks>The method will skip enumerating <paramref name="enumerable"/> if possible (if it's an <see cref="ICollection{T}"/> or <see cref="IReadOnlyCollection{T}"/>).</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeLessThanOrEqualTo<T>(IEnumerable<T> enumerable, int size, string name)
        {
            int actualSize;

            if (((enumerable as ICollection<T>)?.Count is int collectionCount &&
                 (actualSize = collectionCount) > size) ||
                ((enumerable as IReadOnlyCollection<T>)?.Count is int readOnlyCollectionCount &&
                 (actualSize = readOnlyCollectionCount) > size) ||
                (actualSize = enumerable.Count()) > size)
            {
                ThrowArgumentException(name, $"Parameter {name} must be sized <= {size}, had a size of {actualSize}");
            }
        }
    }
}