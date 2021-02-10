using FeefoTechnical.models;
using System.Collections.Generic;
using Xunit;

namespace FeefoTechnical.UnitTests
{
    public class ArrayManipulatorTests
    {
        private readonly ArrayManipulator _arrayManipulator;

        public ArrayManipulatorTests()
        {
            _arrayManipulator = new ArrayManipulator();
        }

        [Theory(DisplayName = "GIVEN an input array of numbers, " +
                              "WHEN passed into the ArrayManipulator" +
                              "THEN the Median value is returned.")]
        [MemberData(nameof(TestData))]
        public void FindMedian_IntArrayPassedIn_ReturnsMedian(dynamic provided, dynamic expected)
        {
            var median = _arrayManipulator.FindMedian(provided.Input);
            Assert.Equal(expected.Output.Median, median);
        }

        [Theory(DisplayName = "GIVEN an input array of numbers, " +
                              "WHEN passed into the ArrayManipulator" +
                              "THEN the Mean value is returned.")]
        [MemberData(nameof(TestData))]
        public void FindMean_IntArrayPassedIn_ReturnsMean(dynamic provided, dynamic expected)
        {
            var mean = _arrayManipulator.FindMean(provided.Input);
            Assert.Equal(expected.Output.Mean, mean);
        }

        [Theory(DisplayName = "GIVEN an input array of numbers, " +
                              "WHEN passed into the ArrayManipulator" +
                              "THEN the Mode value is returned.")]
        [MemberData(nameof(TestData))]
        public void FindMode_IntArrayPassedIn_ReturnsMode(dynamic provided, dynamic expected)
        {
            var mode = _arrayManipulator.FindMode(provided.Input);
            Assert.Equal(expected.Output.Mode, mode);
        }

        [Theory(DisplayName = "GIVEN an input array of numbers, " +
                              "WHEN passed into the ArrayManipulator" +
                              "THEN the Range value is returned.")]
        [MemberData(nameof(TestData))]
        public void FindRange_IntArrayPassedIn_ReturnsRange(dynamic provided, dynamic expected)
        {
            var range = _arrayManipulator.FindRange(provided.Input);
            Assert.Equal(expected.Output.Range, range);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                new
                {
                    Input = new int[] { 3, 5, 6, 1, 5, 0, 5, 9, 6, 7 },

                },
                new
                {
                    Output = new
                    {
                        Median = 5,
                        Mean = 4,
                        Mode = 5,
                        Range = 9
                    }
                }
            };

            yield return new object[]
            {
                new
                {
                    Input = new int[] { 9, 8, 6, 3, 6, 7, 5, 6, 8, 0 },
                },
                new
                {
                    Output = new
                    {
                        Median = 6,
                        Mean = 5,
                        Mode = 6,
                        Range = 9
                    }
                }
            };

            yield return new object[]
            {
                new
                {
                    Input = new int[] { 8, 9, 2, 0, 4, 8, 4, 7, 9, 8, 4 },
                },
                new
                {
                    Output = new
                    {
                        Median = 7,
                        Mean = 5,
                        Mode = 8,
                        Range = 9
                    }
                }
            };

            yield return new object[]
            {
                new
                {
                    Input = new int[] { 7, 10, 2, 1, 4, 0, 2, 6, 7, 6, 3},
                },
                new
                {
                    Output = new
                    {
                        Median = 4,
                        Mean = 4,
                        Mode = 7,
                        Range = 10
                    }
                }
            };

            yield return new object[]
            {
                new
                {
                    Input = new int[] { 6, 0, 11, 11, 1, 10, 18, 18, 3, 19, 8, 11, 12, 6, 2, 11, 19, 4, 18, 13  },
                },
                new
                {
                    Output = new
                    {
                        Median = 11,
                        Mean = 10,
                        Mode = 11,
                        Range = 19
                    }
                }
            };

            yield return new object[]
            {
                new
                {
                    Input = new int[] { 2, 10, 3, 2, 3, 12, 14, 19, 17, 12, 12, 6, 3, 7, 8, 8, 8, 18, 19, 11  },
                },
                new
                {
                    Output = new
                    {
                        Median = 9,
                        Mean = 9,
                        Mode = 3,
                        Range = 17
                    }
                }
            };
        }
    }
}

