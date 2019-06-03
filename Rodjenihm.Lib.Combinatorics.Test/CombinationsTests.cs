using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Rodjenihm.Lib.Combinatorics.Test
{
    [TestFixture]
    public class CombinationsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCaseSource(typeof(CombinationsTestsData), nameof(CombinationsTestsData.InputWithZeroRepetitionsTestCases))]
        public void InputWithZeroRepetitions_GeneratesAllCombinationss<T>(
            IEnumerable<T> source,
            int order,
            IEnumerable<IEnumerable<T>> expected)
        {
            var combinations = new Combinations<T>(source, order);

            var actual = new List<IEnumerable<T>>(combinations);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCaseSource(typeof(CombinationsTestsData), nameof(CombinationsTestsData.InputWithOneRepetitionsTestCases))]
        public void InputWithOneRepetitions_GeneratesAllCombinations<T>(
            IEnumerable<T> source,
            int order,
            IEnumerable<IEnumerable<T>> expected)
        {
            var combinations = new Combinations<T>(source, order);

            var actual = new List<IEnumerable<T>>(combinations);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void InputIsNull_ThrowsArgumentNullException()
        {
            int[] source = null;

            Assert.Throws<ArgumentNullException>(() => new Combinations<int>(source, 2));
        }

        [Test]
        public void OrderIsBiggerThanSourceCount_ThrowsArgumentOutOfRangeException()
        {
            int[] source = new int[] { 1, 2, 3 };

            Assert.Throws<ArgumentOutOfRangeException>(() => new Combinations<int>(source, 4));
        }

    }
}
