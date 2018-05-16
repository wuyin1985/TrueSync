﻿using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#if NET_2_0_SUBSET || NET_2_0 || NET_3_0 || NET_3_5 || NET_4_0 || PROFILE328

namespace System.Collections.Generic
{
    /// <summary>
    /// Represents a read-only collection of elements that can be accessed by index.
    /// Enables System.Collections.Generic.IReadOnlyList to be used in .NET 4.5 projects
    /// </summary>
    /// <typeparam name="T"></typeparam>
#if NET_2_0_SUBSET || NET_2_0 || NET_3_0 || NET_3_5
    public interface IReadOnlyList<T> : IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable
#else
    public interface IReadOnlyList<out T> : IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable
#endif
    {
        /// <summary>
        /// Gets the element at the specified index in the read-only list.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        T this[int index] { get; }
    }
}

#else

[assembly: TypeForwardedTo(typeof(IReadOnlyList<>))]

#endif
