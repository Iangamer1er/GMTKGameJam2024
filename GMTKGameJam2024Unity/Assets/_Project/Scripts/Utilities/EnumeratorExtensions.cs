using System;
using System.Collections.Generic;

namespace UnityUtils{
    public static class EnumeratorExtensions{
        /// <summary>
        /// /// Performs an action on each element in the sequence.
        /// </summary>
        /// <typeparam name="T">The type of elements in the sequence.</typeparam>
        /// <param name="sequence">The sequence to iterate over.</param>
        /// <param name="action">The action to perform on each element.</param>    
        public static IEnumerable<T> ToIEnumerable<T>(this IEnumerator<T> enumerator){
            yield return enumerator.Current;
        }
    }
}
