using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    class PermutationsTestsData
    {
        public static IEnumerable<TestCaseData> InputWithZeroRepetitionsTestCases
        {
            get
            {
                yield return new
                    TestCaseData
                    (
                        new List<int> { 1, 2, 3 },
                        new List<List<int>>
                            {
                                new List<int> { 1, 2, 3 },
                                new List<int> { 1, 3, 2 },
                                new List<int> { 2, 1, 3 },
                                new List<int> { 2, 3, 1 },
                                new List<int> { 3, 1, 2 },
                                new List<int> { 3, 2, 1 },
                            }
                    );

                yield return new
                    TestCaseData
                    (
                        new List<int> { 2, 1, 3 },
                        new List<List<int>>
                            {
                                new List<int> { 2, 1, 3 },
                                new List<int> { 2, 3, 1 },
                                new List<int> { 3, 1, 2 },
                                new List<int> { 3, 2, 1 },
                                new List<int> { 1, 2, 3 },
                                new List<int> { 1, 3, 2 },
                            }
                    );

                yield return new
                    TestCaseData
                    (
                        new List<int> { 3, 2, 1 },
                        new List<List<int>>
                            {
                                new List<int> { 3, 2, 1 },
                                new List<int> { 1, 2, 3 },
                                new List<int> { 1, 3, 2 },
                                new List<int> { 2, 1, 3 },
                                new List<int> { 2, 3, 1 },
                                new List<int> { 3, 1, 2 },
                            }
                    );

                yield return new
                    TestCaseData
                    (
                        new List<string> { "A", "B", "C" },
                        new List<List<string>>
                            {
                                new List<string> { "A", "B", "C"},
                                new List<string> { "A", "C", "B"},
                                new List<string> { "B", "A", "C"},
                                new List<string> { "B", "C", "A"},
                                new List<string> { "C", "A", "B"},
                                new List<string> { "C", "B", "A"},
                            }
                    );

                yield return new
                    TestCaseData
                    (
                        new List<string> { "B", "C", "A" },
                        new List<List<string>>
                            {
                                new List<string> { "B", "C", "A"},
                                new List<string> { "C", "A", "B"},
                                new List<string> { "C", "B", "A"},
                                new List<string> { "A", "B", "C"},
                                new List<string> { "A", "C", "B"},
                                new List<string> { "B", "A", "C"},
                            }
                    );

                yield return new
                    TestCaseData
                    (
                        new List<string> { "C", "B", "A" },
                        new List<List<string>>
                            {
                                new List<string> { "C", "B", "A"},
                                new List<string> { "A", "B", "C"},
                                new List<string> { "A", "C", "B"},
                                new List<string> { "B", "A", "C"},
                                new List<string> { "B", "C", "A"},
                                new List<string> { "C", "A", "B"},
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
                        new List<List<int>>
                            {
                                new List<int> { 1, 1, 3 },
                                new List<int> { 1, 3, 1 },
                                new List<int> { 3, 1, 1 },
                            }
                    );

                yield return new
                    TestCaseData
                    (
                        new List<int> { 1, 3, 1 },
                        new List<List<int>>
                            {
                                new List<int> { 1, 3, 1 },
                                new List<int> { 3, 1, 1 },
                                new List<int> { 1, 1, 3 },
                            }
                    );

                yield return new
                    TestCaseData
                    (
                        new List<int> { 3, 1, 1 },
                        new List<List<int>>
                            {
                                new List<int> { 3, 1, 1 },
                                new List<int> { 1, 1, 3 },
                                new List<int> { 1, 3, 1 },
                            }
                    );

                yield return new
                    TestCaseData
                    (
                        new List<string> { "A", "A", "B" },
                        new List<List<string>>
                            {
                                new List<string> { "A", "A", "B"},
                                new List<string> { "A", "B", "A"},
                                new List<string> { "B", "A", "A"},
                            }
                    );

                yield return new
                    TestCaseData
                    (
                        new List<string> { "A", "B", "A" },
                        new List<List<string>>
                            {
                                new List<string> { "A", "B", "A"},
                                new List<string> { "B", "A", "A"},
                                new List<string> { "A", "A", "B"},
                            }
                    );

                yield return new
                    TestCaseData
                    (
                        new List<string> { "B", "A", "A" },
                        new List<List<string>>
                            {
                                new List<string> { "B", "A", "A"},
                                new List<string> { "A", "A", "B"},
                                new List<string> { "A", "B", "A"},
                            }
                    );
            }

        }

        public static IEnumerable<TestCaseData> InputWithTwoRepetitionsTestCases
        {
            get
            {
                yield return new
                    TestCaseData
                    (
                        new List<int> { 1, 1, 2, 2 },
                        new List<List<int>>
                            {
                                new List<int> { 1, 1, 2, 2 },
                                new List<int> { 1, 2, 1, 2 },
                                new List<int> { 1, 2, 2, 1 },
                                new List<int> { 2, 1, 1, 2 },
                                new List<int> { 2, 1, 2, 1 },
                                new List<int> { 2, 2, 1, 1 },
                            }
                    );

                yield return new
                    TestCaseData
                    (
                        new List<int> { 1, 2, 2, 1 },
                        new List<List<int>>
                            {
                                new List<int> { 1, 2, 2, 1 },
                                new List<int> { 2, 1, 1, 2 },
                                new List<int> { 2, 1, 2, 1 },
                                new List<int> { 2, 2, 1, 1 },
                                new List<int> { 1, 1, 2, 2 },
                                new List<int> { 1, 2, 1, 2 },
                            }
                    );

                yield return new
                    TestCaseData
                    (
                        new List<int> { 2, 2, 1, 1 },
                        new List<List<int>>
                            {
                                new List<int> { 2, 2, 1, 1 },
                                new List<int> { 1, 1, 2, 2 },
                                new List<int> { 1, 2, 1, 2 },
                                new List<int> { 1, 2, 2, 1 },
                                new List<int> { 2, 1, 1, 2 },
                                new List<int> { 2, 1, 2, 1 },
                            }
                    );
            }
        }
    }
}