using NUnit.Framework;
using System.Collections;
using Task01Logic;

namespace Task01Tests
{
    [TestFixture]
    public class DelegateTests
    {
        public static IEnumerable SumAscendingTestCases
        {
            get
            {
                yield return new TestCaseData(new[]
                {
                        new[] {2, 1, 4, -1},
                        new[] {-1, 2, -55, 0},
                        new[] {1}
                    }, new[]
                {
                        new[] {-1, 2, -55, 0},
                        new[] {1},
                        new[] {2, 1, 4, -1}
                    });

                yield return new TestCaseData(new[]
                {
                        new[] {3, 4, 5},
                        new[] {2, 3, 4},
                        new[] {1, 2, 3}
                    }, new[]
                {
                        new[] {1, 2, 3},
                        new[] {2, 3, 4},
                        new[] {3, 4, 5}
                    });
                
                yield return new TestCaseData(new[]
                {
                        new[] {1, 2, 3},
                        new[] {2, 1, 3}
                    }, new[]
                {
                        new[] {1, 2, 3},
                        new[] {2, 1, 3}
                    });
            }
        }

        public static IEnumerable SumDescendingTestCases
        {
            get
            {
                yield return new TestCaseData(new[]
                {
                        new[] {2, 1, 4, -1},
                        new[] {-1, 2, -55, 0},
                        new[] {1}
                    }, new[]
                {
                        new[] {-1, 2, -55, 0},
                        new[] {1},
                        new[] {2, 1, 4, -1}
                    });

                yield return new TestCaseData(new[]
                {
                        new[] {3, 4, 5},
                        new[] {2, 3, 4},
                        new[] {1, 2, 3}
                    }, new[]
                {
                        new[] {3, 4, 5},
                        new[] {2, 3, 4},
                        new[] {1, 2, 3}
                    });

                yield return new TestCaseData(new[]
                {
                        new[] {1, 2, 3},
                        new[] {2, 1, 3}
                    }, new[]
                {
                        new[] {1, 2, 3},
                        new[] {2, 1, 3}
                    });
            }
        }

        public static IEnumerable MaxElementAscendingTestCase
        {
            get
            {
                yield return new TestCaseData(new[]
                {
                        new[] {2, 1, 4, -1},
                        new[] {-1, 2, -55, 0},
                        new[] {1}
                    }, new[]
                {
                        new[] {1},
                        new[] {-1, 2, -55, 0},
                        new[] {2, 1, 4, -1}
                    });

                yield return new TestCaseData(new[]
                {
                        new[] {3, 4, 5},
                        new[] {2, 3, 4},
                        new[] {1, 2, 3}
                    }, new[]
                {
                        new[] {1, 2, 3},
                        new[] {2, 3, 4},
                        new[] {3, 4, 5}
                    });

                yield return new TestCaseData(new[]
                {
                        new[] {1, 2, 3},
                        new[] {2, 1, 3}
                    }, new[]
                {
                        new[] {1, 2, 3},
                        new[] {2, 1, 3}
                    });
            }
        }

        public static IEnumerable MaxElementDescendingTestCase
        {
            get
            {
                yield return new TestCaseData(new[]
                {
                        new[] {2, 1, 4, -1},
                        new[] {-1, 2, -55, 0},
                        new[] {1}
                    }, new[]
                {
                        new[] {2, 1, 4, -1},
                        new[] {-1, 2, -55, 0},
                        new[] {1}
                    });

                yield return new TestCaseData(new[]
                {
                        new[] {3, 4, 5},
                        new[] {2, 3, 4},
                        new[] {1, 2, 3}
                    }, new[]
                {
                        new[] {3, 4, 5},
                        new[] {2, 3, 4},
                        new[] {1, 2, 3}
                    });

                yield return new TestCaseData(new[]
                {
                        new[] {1, 2, 3},
                        new[] {2, 1, 3}
                    }, new[]
                {
                        new[] {1, 2, 3},
                        new[] {2, 1, 3}
                    });
            }
        }

        public static IEnumerable MinElementAscenidingTestCase
        {
            get
            {
                yield return new TestCaseData(new[]
                {
                        new[] {2, 1, 4, -1},
                        new[] {-1, 2, -55, 0},
                        new[] {1}
                    }, new[]
                {
                        new[] {-1, 2, -55, 0},
                        new[] {2, 1, 4, -1},
                        new[] {1}
                    });

                yield return new TestCaseData(new[]
                {
                        new[] {3, 4, 5},
                        new[] {2, 3, 4},
                        new[] {1, 2, 3}
                    }, new[]
                {
                        new[] {1, 2, 3},
                        new[] {2, 3, 4},
                        new[] {3, 4, 5}
                    });

                yield return new TestCaseData(new[]
                {
                        new[] {1, 2, 3},
                        new[] {2, 1, 3}
                    }, new[]
                {
                        new[] {1, 2, 3},
                        new[] {2, 1, 3}
                    });
            }
        }

        public static IEnumerable MinElementDescendingTestCase
        {
            get
            {
                yield return new TestCaseData(new[]
                {
                        new[] {1},
                        new[] {2, 1, 4, -1},
                        new[] {-1, 2, -55, 0}
                    }, new[]
                {
                        new[] {2, 1, 4, -1},
                        new[] {-1, 2, -55, 0},
                        new[] {1}
                    });

                yield return new TestCaseData(new[]
                {
                        new[] {3, 4, 5},
                        new[] {2, 3, 4},
                        new[] {1, 2, 3}
                    }, new[]
                {
                        new[] {3, 4, 5},
                        new[] {2, 3, 4},
                        new[] {1, 2, 3}
                    });

                yield return new TestCaseData(new[]
                {
                        new[] {1, 2, 3},
                        new[] {2, 1, 3}
                    }, new[]
                {
                        new[] {1, 2, 3},
                        new[] {2, 1, 3}
                    });
            }
        }

        [Test, TestCaseSource(nameof(SumAscendingTestCases))]
        public void DelegateSort_SumAscending(int[][] array, int[][] result)
        {
            ComparerDelegate comparerDelegate = new SumAscending().Compare;
            DelegateSort.SortWithDelegate(array, comparerDelegate);
            Assert.AreEqual(result, array);
        }

        [Test, TestCaseSource(nameof(MaxElementAscendingTestCase))]
        public void InterfaceSort_MaxElementDescending(int[][] array, int[][] result)
        {
            InterfaceSort.SortWithInterface(array, new MaxElementAscending());
            Assert.AreEqual(result, array);
        }
    }
}
