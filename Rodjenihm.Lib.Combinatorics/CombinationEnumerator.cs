using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Rodjenihm.Lib.Combinatorics
{
    internal class CombinationEnumerator<T> : IEnumerator<IEnumerable<T>>
    {
        private readonly T[] source;
        private T[] cur;
        private readonly int order;
        private readonly int[] selector;
        private bool first = true;

        public CombinationEnumerator(T[] source, int order, Comparer<T> comparer)
        {
            this.source = source.ToArray();
            this.order = order;
            selector = Enumerable.Range(0, order).ToArray();
            Array.Sort(this.source, comparer);
            cur = this.source.Take(order).ToArray();
        }

        public IEnumerable<T> Current => new List<T>(selector.Select(i => source[i]).ToArray());

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

            return NextSelector();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        private bool NextSelector()
        {
            int i = order - 1;
            int max = source.Length - 1;

            while (selector[i] == max)
            {
                i--;
                max--;

                if (i < 0)
                    return false;
            }

            selector[i]++;

            for (int j = i + 1; j < order; j++)
                selector[j] = selector[j - 1] + 1;

            if (Current.SequenceEqual(cur))
                return NextSelector();

            cur = Current.ToArray();

            return true;
        }
    }
}
