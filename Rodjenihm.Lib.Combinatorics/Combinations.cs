using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Rodjenihm.Lib.Combinatorics
{
    public class Combinations<T> : IEnumerable<IEnumerable<T>>
    {
        private readonly T[] source;
        private readonly int order;
        private readonly Comparer<T> comparer;

        public Combinations(IEnumerable<T> source, int order, Comparer<T> comparer = null)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (order > source.Count() || order <= 0)
                throw new ArgumentOutOfRangeException(nameof(order));

            this.source = source.ToArray();
            this.order = order;
            this.comparer = comparer ?? Comparer<T>.Default;
        }

        public IEnumerator<IEnumerable<T>> GetEnumerator()
        {
            return new CombinationEnumerator<T>(source, order, comparer);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
