using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Rodjenihm.Lib.Combinatorics
{
    public class Combinations<T> : IEnumerable<IEnumerable<T>>
    {
        private readonly T[] source;
        private readonly int k;
        private readonly Comparer<T> comparer;

        public Combinations(IEnumerable<T> source, int k, Comparison<T> comparison = null)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            this.source = source.ToArray();
            this.k = k;
            comparer = comparison == null ? Comparer<T>.Default : Comparer<T>.Create(comparison);
        }

        public IEnumerator<IEnumerable<T>> GetEnumerator()
        {
            return new CombinationEnumerator<T>(source, k, comparer);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
