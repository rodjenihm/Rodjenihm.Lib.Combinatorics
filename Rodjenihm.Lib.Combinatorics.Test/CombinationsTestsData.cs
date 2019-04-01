using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rodjenihm.Lib.Combinatorics.Test
{
    class CombinationsTestsData
    {
        public static IEnumerable<TestCaseData> InputWithZeroRepetitionsTestCases
        {
            get
            {
                yield return new
                    TestCaseData
                    (
                        new List<int> { 1, 2, 3 },
                        3,
                        new List<List<int>>
                            {
                                new List<int> { 1, 2, 3},
                            }
                    );

                yield return new
                    TestCaseData
                    (
                        new List<int> { 1, 2, 3 },
                        2,
                        new List<List<int>>
                            {
                                new List<int> { 1, 2 },
                                new List<int> { 1, 3 },
                                new List<int> { 2, 3 },
                            }
                    );

                yield return new
                   TestCaseData
                   (
                       new List<int> { 1, 2, 3, 4 },
                       4,
                       new List<List<int>>
                           {
                                new List<int> { 1, 2, 3, 4 },
                           }
                   );

                yield return new
                    TestCaseData
                    (
                        new List<int> { 1, 2, 3, 4 },
                        3,
                        new List<List<int>>
                            {
                                new List<int> { 1, 2, 3 },
                                new List<int> { 1, 2, 4 },
                                new List<int> { 1, 3, 4 },
                                new List<int> { 2, 3, 4 },
                            }
                    );

                yield return new
                    TestCaseData
                    (
                        new List<int> { 1, 2, 3, 4 },
                        2,
                        new List<List<int>>
                            {
                                new List<int> { 1, 2 },
                                new List<int> { 1, 3 },
                                new List<int> { 1, 4 },
                                new List<int> { 2, 3 },
                                new List<int> { 2, 4 },
                                new List<int> { 3, 4 },
                            }
                    );
            }
        }
    }
}
