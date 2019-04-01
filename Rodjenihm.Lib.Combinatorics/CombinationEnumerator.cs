using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Rodjenihm.Lib.Combinatorics
{
    internal class CombinationEnumerator<T> : IEnumerator<IEnumerable<T>>
    {
        private readonly T[] source;
        private readonly int k;
        private readonly Comparer<T> comparer;
        private readonly int[] selector;
        private bool first = true;

        public CombinationEnumerator(T[] source, int k, Comparer<T> comparer)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            this.source = source.ToArray();
            this.k = k;
            this.comparer = comparer;
            selector = Enumerable.Range(0, k).ToArray();
        }

        public IEnumerable<T> Current => selector.Select(i => source[i]).ToList();

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (first)
            {
                first = false;
                return true;
            }

            return NextCombination();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        private bool NextCombination()
        {
            int i = k - 1;
            int max = source.Length - 1;

            while (selector[i] == max)
            {
                i--;
                max--;

                if (i < 0)
                    return false;
            }

            selector[i]++;

            for (int j = i + 1; j < k; j++)
                selector[j] = selector[j - 1] + 1;

            return true;
        }
    }
}
