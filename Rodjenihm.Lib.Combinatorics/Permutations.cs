using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Rodjenihm.Lib.Combinatorics
{
    public class Permutations<T> : IEnumerable<IEnumerable<T>>
    {
        private readonly T[] source;
        private readonly int start;
        private readonly int end;
        private readonly Comparer<T> comparer;

        public Permutations(IEnumerable<T> source, Comparer<T> comparer = null)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            this.source = source.ToArray();
            start = 0;
            end = this.source.Length;
            this.comparer = comparer ?? Comparer<T>.Default;
        }

        public Permutations(IEnumerable<T> source, int start, int end, Comparer<T> comparer = null) : this(source, comparer)
        {
            this.start = start;
            this.end = end;
        }

        public IEnumerator<IEnumerable<T>> GetEnumerator()
        {
            return new PermutationEnumerator<T>(source, start, end, comparer);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
