using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Rodjenihm.Lib.Combinatorics.Test
{
    [TestFixture]
    public class PermutationsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCaseSource(typeof(PermutationsTestsData), nameof(PermutationsTestsData.InputWithZeroRepetitionsTestCases))]
        public void InputWithZeroRepetitions_GeneratesAllPermutations<T>(IEnumerable<T> source, IEnumerable<IEnumerable<T>> expected)
        {
            var permutations = new Permutations<T>(source);

            var actual = new List<IEnumerable<T>>(permutations);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCaseSource(typeof(PermutationsTestsData), nameof(PermutationsTestsData.InputWithOneRepetitionsTestCases))]
        public void InputWithOneRepetitions_GeneratesAllPermutations<T>(IEnumerable<T> source, IEnumerable<IEnumerable<T>> expected)
        {
            var permutations = new Permutations<T>(source);

            var actual = new List<IEnumerable<T>>(permutations);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCaseSource(typeof(PermutationsTestsData), nameof(PermutationsTestsData.InputWithTwoRepetitionsTestCases))]
        public void InputWithTwoRepetitions_GeneratesAllPermutations<T>(IEnumerable<T> source, IEnumerable<IEnumerable<T>> expected)
        {
            var permutations = new Permutations<T>(source);

            var actual = new List<IEnumerable<T>>(permutations);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void InputHasOneElement_GeneratesOnePermutation()
        {
            int[] source = new int[] { 1 };

            var permutations = new Permutations<int>(source);

            var expected = new List<IEnumerable<int>>
            {
                new List<int> { 1 }
            };

            var actual = new List<IEnumerable<int>>(permutations);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void InputIsNull_ThrowsArgumentNullException()
        {
            int[] source = null;

            Assert.Throws<ArgumentNullException>(() => new Permutations<int>(source));
        }
    }
}