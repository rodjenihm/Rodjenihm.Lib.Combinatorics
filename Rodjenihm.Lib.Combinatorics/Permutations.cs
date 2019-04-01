﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Rodjenihm.Lib.Combinatorics
{
    public class Permutations<T> : IEnumerable<IEnumerable<T>>
    {
        private readonly T[] source;
        private readonly Comparer<T> comparer;

        public Permutations(IEnumerable<T> source, Comparer<T> comparer = null)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            this.source = source.ToArray();
            this.comparer = comparer ?? Comparer<T>.Default;
        }

        public IEnumerator<IEnumerable<T>> GetEnumerator()
        {
            return new PermutationEnumerator<T>(source, comparer);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
