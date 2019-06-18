using NUnit.Framework;
using System.Collections.Generic;

namespace Rodjenihm.Lib.Combinatorics.Test
{
    class PermutationsTestsData
    {
        public static IEnumerable<TestCaseData> InputWithZeroRepetitionsTestCases
        {
            get
            {
                var arg2_1 = new List<List<int>>
                            {
                                new List<int> { 1, 2, 3 },
                                new List<int> { 1, 3, 2 },
                                new List<int> { 2, 1, 3 },
                                new List<int> { 2, 3, 1 },
                                new List<int> { 3, 1, 2 },
                                new List<int> { 3, 2, 1 },
                            };

                var arg2_2 = new List<List<string>>
                            {
                                new List<string> { "A", "B", "C"},
                                new List<string> { "A", "C", "B"},
                                new List<string> { "B", "A", "C"},
                                new List<string> { "B", "C", "A"},
                                new List<string> { "C", "A", "B"},
                                new List<string> { "C", "B", "A"},
                            };

                yield return new
                    TestCaseData
                    (
                        new List<int> { 1, 2, 3 },
                        arg2_1
                    );

                yield return new
                    TestCaseData
                    (
                        new List<int> { 2, 1, 3 },
                        arg2_1
                    );

                yield return new
                    TestCaseData
                    (
                        new List<int> { 3, 2, 1 },
                        arg2_1
                    );

                yield return new
                    TestCaseData
                    (
                        new List<string> { "A", "B", "C" },
                        arg2_2
                    );

                yield return new
                    TestCaseData
                    (
                        new List<string> { "B", "C", "A" },
                        arg2_2
                    );

                yield return new
                    TestCaseData
                    (
                        new List<string> { "C", "B", "A" },
                        arg2_2
                    );
            }
        }

        public static IEnumerable<TestCaseData> InputWithOneRepetitionsTestCases
        {
            get
            {
                var arg2_1 = new List<List<int>>
                            {
                                new List<int> { 1, 1, 3 },
                                new List<int> { 1, 3, 1 },
                                new List<int> { 3, 1, 1 },
                            };

                var arg2_2 = new List<List<string>>
                            {
                                new List<string> { "A", "A", "B"},
                                new List<string> { "A", "B", "A"},
                                new List<string> { "B", "A", "A"},
                            };

                yield return new
                    TestCaseData
                    (
                        new List<int> { 1, 1, 3 },
                        arg2_1
                    );

                yield return new
                    TestCaseData
                    (
                        new List<int> { 1, 3, 1 },
                        arg2_1
                    );

                yield return new
                    TestCaseData
                    (
                        new List<int> { 3, 1, 1 },
                        arg2_1
                    );

                yield return new
                    TestCaseData
                    (
                        new List<string> { "A", "A", "B" },
                        arg2_2
                    );

                yield return new
                    TestCaseData
                    (
                        new List<string> { "A", "B", "A" },
                        arg2_2
                    );

                yield return new
                    TestCaseData
                    (
                        new List<string> { "B", "A", "A" },
                        arg2_2
                    );
            }

        }

        public static IEnumerable<TestCaseData> InputWithTwoRepetitionsTestCases
        {
            get
            {
                var arg2_1 = new List<List<int>>
                            {
                                new List<int> { 1, 1, 2, 2 },
                                new List<int> { 1, 2, 1, 2 },
                                new List<int> { 1, 2, 2, 1 },
                                new List<int> { 2, 1, 1, 2 },
                                new List<int> { 2, 1, 2, 1 },
                                new List<int> { 2, 2, 1, 1 },
                            };

                yield return new
                    TestCaseData
                    (
                        new List<int> { 1, 1, 2, 2 },
                        arg2_1
                    );

                yield return new
                    TestCaseData
                    (
                        new List<int> { 1, 2, 2, 1 },
                        arg2_1
                    );

                yield return new
                    TestCaseData
                    (
                        new List<int> { 2, 2, 1, 1 },
                        arg2_1
                    );
            }
        }

        public static IEnumerable<TestCaseData> InputWithZeroRepetitionsAndLimitsTestCases
        {
            get
            {
                var arg2_3 = new List<List<int>>
                            {
                                new List<int> { 1, 2, 3, 4 },
                                new List<int> { 1, 3, 2, 4 },
                            };

                var arg2_4 = new List<List<int>>
                            {
                                new List<int> { 1, 2, 3, 4, 5 },
                                new List<int> { 1, 2, 4, 3, 5 },
                                new List<int> { 1, 3, 2, 4, 5 },
                                new List<int> { 1, 3, 4, 2, 5 },
                                new List<int> { 1, 4, 2, 3, 5 },
                                new List<int> { 1, 4, 3, 2, 5 },
                            };

                var arg2_5 = new List<List<int>>
                            {
                                new List<int> { 1, 1, 0, 0, 1, 1, 0},
                                new List<int> { 1, 1, 0, 1, 0, 1, 0},
                                new List<int> { 1, 1, 0, 1, 1, 0, 0},
                                new List<int> { 1, 1, 1, 0, 0, 1, 0},
                                new List<int> { 1, 1, 1, 0, 1, 0, 0},
                                new List<int> { 1, 1, 1, 1, 0, 0, 0},
                            };

                yield return new
                  TestCaseData
                    (
                        new List<int> { 1, 2, 3, 4 },
                        1,
                        3,
                        arg2_3
                    );

                yield return new
                  TestCaseData
                    (
                        new List<int> { 1, 2, 3, 4, 5 },
                        1,
                        4,
                        arg2_4
                    );

                yield return new
                  TestCaseData
                    (
                        new List<int> { 1, 1, 1, 1, 0, 0, 0 },
                        2,
                        6,
                        arg2_5
                    );
            }
        }
    }
}
