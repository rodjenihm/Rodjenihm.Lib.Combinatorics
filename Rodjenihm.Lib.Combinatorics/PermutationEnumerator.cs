using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Rodjenihm.Lib.Combinatorics
{
    internal class PermutationEnumerator<T> : IEnumerator<IEnumerable<T>>
    {
        private readonly T[] source;
        private readonly T[] current;
        private readonly Comparer<T> comparer;
        private bool first = true;

        public PermutationEnumerator(T[] source, Comparer<T> comparer)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            this.source = source.ToArray();
            current = source.ToArray();
            this.comparer = comparer ?? throw new ArgumentNullException(nameof(comparer));
            Array.Sort(current, comparer);
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
            int i = current.Length - 1;
            while (i > 0 && comparer.Compare(current[i - 1], current[i]) >= 0)
                i--;

            if (i == 0)
                return false;

            int j = current.Length - 1;
            while (comparer.Compare(current[j], current[i - 1]) <= 0)
                j--;

            Swap(i - 1, j);

            j = current.Length - 1;
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
