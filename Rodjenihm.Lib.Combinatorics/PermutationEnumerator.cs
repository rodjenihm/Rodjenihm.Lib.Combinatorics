using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rodjenihm.Lib.Combinatorics
{
    internal class PermutationEnumerator<T> : IEnumerator<List<T>>
    {
        private readonly T[] input;
        private T[] current;
        private readonly Comparer<T> comparer;
        private bool first = true;

        public PermutationEnumerator(T[] input, Comparer<T> comparer)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            this.input = input.ToArray();
            this.current = input.ToArray();
            this.comparer = comparer ?? throw new ArgumentNullException(nameof(comparer));
        }

        public List<T> Current => new List<T>(this.current);

        object IEnumerator.Current => this.Current;

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

            NextPermutation();

            return current.SequenceEqual(input) ? false : true;
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
            {
                this.current = this.current.Reverse().ToArray();
                return true;
            }

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
