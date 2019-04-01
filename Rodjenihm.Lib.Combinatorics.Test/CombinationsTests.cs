using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

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
            int k,
            IEnumerable<IEnumerable<T>> expected)
        {
            var combinations = new Combinations<T>(source, k);

            var actual = new List<IEnumerable<T>>(combinations);

            Assert.AreEqual(expected, actual);
        }

    }
}
