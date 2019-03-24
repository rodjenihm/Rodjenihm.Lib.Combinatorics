using NUnit.Framework;
using Rodjenihm.Lib.Combinatorics;
using System.Collections;
using System.Collections.Generic;

namespace Tests
{
    public class PermutationsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCaseSource(typeof(PermutationsTestsData), nameof(PermutationsTestsData.InputWithZeroRepetitionsTestCases))]
        public void _InputWithZeroRepetitions_GeneratesAllPermutations<T>(IEnumerable<T> input, List<List<T>> expected)
        {
            var permutations = new Permutations<T>(input);

            var actual = new List<List<T>>(permutations);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCaseSource(typeof(PermutationsTestsData), nameof(PermutationsTestsData.InputWithOneRepetitionsTestCases))]
        public void _InputWithOneRepetitions_GeneratesAllPermutations<T>(IEnumerable<T> input, List<List<T>> expected)
        {
            var permutations = new Permutations<T>(input);

            var actual = new List<List<T>>(permutations);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCaseSource(typeof(PermutationsTestsData), nameof(PermutationsTestsData.InputWithTwoRepetitionsTestCases))]
        public void _InputWithTwoRepetitions_GeneratesAllPermutations<T>(IEnumerable<T> input, List<List<T>> expected)
        {
            var permutations = new Permutations<T>(input);

            var actual = new List<List<T>>(permutations);

            Assert.AreEqual(expected, actual);
        }
    }
}