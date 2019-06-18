using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Rodjenihm.Lib.Combinatorics
{
    internal class PermutationEnumerator<T> : IEnumerator<IEnumerable<T>>
    {
        private readonly T[] current;
        private readonly int start;
        private readonly int end;
        private readonly Comparer<T> comparer;
        private bool first = true;

        public PermutationEnumerator(T[] source, int start, int end, Comparer<T> comparer)
        {
            current = source.ToArray();
            this.start = start;
            this.end = end;
            this.comparer = comparer;
            Array.Sort(current, index: start, length: end - start, comparer);
        }

        public IEnumerable<T> Current => new List<T>(current);

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

            return NextPermutation();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        private bool NextPermutation()
        {
            int i = end - 1;
            while (i > start && comparer.Compare(current[i - 1], current[i]) >= 0)
                i--;

            if (i == start)
                return false;

            int j = end - 1;
            while (comparer.Compare(current[j], current[i - 1]) <= 0)
                j--;

            Swap(i - 1, j);

            j = end - 1;
            while (i < j)
                Swap(i++, j--);

            return true;
        }

        private void Swap(int i, int j)
        {
            T temp = current[i];
            current[i] = current[j];
            current[j] = temp;
        }
    }
}
