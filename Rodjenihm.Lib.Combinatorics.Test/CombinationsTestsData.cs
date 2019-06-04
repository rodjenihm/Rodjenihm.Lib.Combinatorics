using NUnit.Framework;
using System.Collections.Generic;

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
                                new List<int> { 1, 2, 3 },
                            }
                    );

                yield return new
                    TestCaseData
                    (
                        new List<int> { 3, 2, 1 },
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
                        new List<int> { 1, 4, 2, 3 },
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
                        new List<int> { 4, 2, 3, 1 },
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

        public static IEnumerable<TestCaseData> InputWithOneRepetitionsTestCases
        {
            get
            {
                yield return new
                    TestCaseData
                    (
                        new List<int> { 1, 1, 3 },
                        3,
                        new List<List<int>>
                            {
                                new List<int> { 1, 1, 3},
                            }
                    );

                yield return new
                    TestCaseData
                    (
                        new List<int> { 1, 3, 1 },
                        2,
                        new List<List<int>>
                            {
                                new List<int> { 1, 1 },
                                new List<int> { 1, 3 },
                            }
                    );

                yield return new
                   TestCaseData
                   (
                       new List<int> { 1, 3, 2, 3 },
                       4,
                       new List<List<int>>
                           {
                                new List<int> { 1, 2, 3, 3 },
                           }
                   );

                yield return new
                    TestCaseData
                    (
                        new List<int> { 3, 3, 2, 1 },
                        3,
                        new List<List<int>>
                            {
                                new List<int> { 1, 2, 3 },
                                new List<int> { 1, 3, 3 },
                                new List<int> { 2, 3, 3 },
                            }
                    );

                yield return new
                    TestCaseData
                    (
                        new List<int> { 3, 3, 1, 2 },
                        2,
                        new List<List<int>>
                            {
                                new List<int> { 1, 2 },
                                new List<int> { 1, 3 },
                                new List<int> { 2, 3 },
                                new List<int> { 3, 3 },
                            }
                    );

                yield return new
                    TestCaseData
                    (
                        new List<string> { "A", "B", "C", "C", "D" },
                        3,
                        new List<List<string>>
                            {
                                new List<string> { "A", "B", "C" },
                                new List<string> { "A", "B", "D" },
                                new List<string> { "A", "C", "C" },
                                new List<string> { "A", "C", "D" },
                                new List<string> { "B", "C", "C" },
                                new List<string> { "B", "C", "D" },
                                new List<string> { "C", "C", "D" },
                            }
                    );
            }
        }
    }
}
