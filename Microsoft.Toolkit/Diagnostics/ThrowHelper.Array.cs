// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Microsoft.Toolkit.Extensions;

#nullable enable

namespace Microsoft.Toolkit.Diagnostics
{
    /// <summary>
    /// Helper methods to throw exceptions
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1618", Justification = "Internal helper methods")]
    internal static partial class ThrowHelper
    {
        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.IsEmpty{T}(T[],string)"/> fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForIsEmpty<T>(T[] array, string name)
        {
            ThrowArgumentException(name, $"Parameter \"{name}\" ({typeof(T[]).ToTypeString()}) must be empty, had a size of {array.Length}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.IsNotEmpty{T}(T[],string)"/> fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForIsNotEmpty<T>(string name)
        {
            ThrowArgumentException(name, $"Parameter \"{name}\" ({typeof(T[]).ToTypeString()}) must not be empty");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeEqualTo{T}(T[],int,string)"/> fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeEqualTo<T>(T[] array, int size, string name)
        {
            ThrowArgumentException(name, $"Parameter \"{name}\" ({typeof(T[]).ToTypeString()}) must be sized == {size}, had a size of {array.Length}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeNotEqualTo{T}(T[],int,string)"/> fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeNotEqualTo<T>(T[] array, int size, string name)
        {
            ThrowArgumentException(name, $"Parameter \"{name}\" ({typeof(T[]).ToTypeString()}) must be sized != {size}, had a size of {array.Length}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeOver{T}(T[],int,string)"/> fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeOver<T>(T[] array, int size, string name)
        {
            ThrowArgumentException(name, $"Parameter \"{name}\" ({typeof(T[]).ToTypeString()}) must be sized > {size}, had a size of {array.Length}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeAtLeast{T}(T[],int,string)"/> fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeAtLeast<T>(T[] array, int size, string name)
        {
            ThrowArgumentException(name, $"Parameter \"{name}\" ({typeof(T[]).ToTypeString()}) must be sized >= {size}, had a size of {array.Length}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeLessThan{T}(T[],int,string)"/> fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeLessThan<T>(T[] array, int size, string name)
        {
            ThrowArgumentException(name, $"Parameter \"{name}\" ({typeof(T[]).ToTypeString()}) must be sized < {size}, had a size of {array.Length}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeLessThanOrEqualTo{T}(T[],int,string)"/> fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeLessThanOrEqualTo<T>(T[] array, int size, string name)
        {
            ThrowArgumentException(name, $"Parameter \"{name}\" ({typeof(T[]).ToTypeString()}) must be sized <= {size}, had a size of {array.Length}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeEqualTo{T}(T[],T[],string)"/> fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeEqualTo<T>(T[] source, T[] destination, string name)
        {
            ThrowArgumentException(name, $"The source \"{name}\" ({typeof(T[]).ToTypeString()}) must be sized == {destination.Length}, had a size of {source.Length}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.HasSizeLessThanOrEqualTo{T}(T[],T[],string)"/> fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForHasSizeLessThanOrEqualTo<T>(T[] source, T[] destination, string name)
        {
            ThrowArgumentException(name, $"The source \"{name}\" ({typeof(T[]).ToTypeString()}) must be sized <= {destination.Length}, had a size of {source.Length}");
        }
    }
}