using NUnit.Framework;
using Rodjenihm.Lib.Combinatorics;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Tests
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
        public void InputWithZeroRepetitions_GeneratesAllPermutations<T>(IEnumerable<T> input, List<List<T>> expected)
        {
            var permutations = new Permutations<T>(input);

            var actual = new List<List<T>>(permutations);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCaseSource(typeof(PermutationsTestsData), nameof(PermutationsTestsData.InputWithOneRepetitionsTestCases))]
        public void InputWithOneRepetitions_GeneratesAllPermutations<T>(IEnumerable<T> input, List<List<T>> expected)
        {
            var permutations = new Permutations<T>(input);

            var actual = new List<List<T>>(permutations);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCaseSource(typeof(PermutationsTestsData), nameof(PermutationsTestsData.InputWithTwoRepetitionsTestCases))]
        public void InputWithTwoRepetitions_GeneratesAllPermutations<T>(IEnumerable<T> input, List<List<T>> expected)
        {
            var permutations = new Permutations<T>(input);

            var actual = new List<List<T>>(permutations);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void InputHasOneElement_GeneratesOnePermutation()
        {
            int[] input = new int[] { 1 };

            var permutations = new Permutations<int>(input);

            var expected = new List<List<int>>
            {
                new List<int> { 1 }
            };

            var actual = new List<List<int>>(permutations);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void InputIsNull_ThrowsArgumentNullException()
        {
            int[] input = null;

            Assert.Throws<ArgumentNullException>(() => new Permutations<int>(input));
        }
    }
}