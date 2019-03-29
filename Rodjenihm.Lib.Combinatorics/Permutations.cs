using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Rodjenihm.Lib.Combinatorics
{
    public class Permutations<T> : IEnumerable<IEnumerable<T>>
    {
        private readonly T[] input;
        private readonly Comparer<T> comparer;

        public Permutations(IEnumerable<T> input, Comparison<T> comparison = null)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            this.input = input.ToArray();
            comparer = comparison == null ? Comparer<T>.Default : Comparer<T>.Create(comparison);
        }

        public IEnumerator<IEnumerable<T>> GetEnumerator()
        {
            return new PermutationEnumerator<T>(input, comparer);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
