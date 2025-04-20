using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using Solutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class CountFairPairsTests
    {
        readonly CountFairPairsSolution solution = new CountFairPairsSolution();

        [Fact]
        public void Test1()
        {
            // Arrange
            int[] nums = [0, 1, 7, 4, 4, 5];
            int lower = 3;
            int upper = 6;
            long expected = 6;

            // Act
            long result = solution.CountFairPairs(nums, lower, upper);

            // Assert
            Xunit.Assert.Equal(result, expected);
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            int[] nums = [1, 7, 9, 2, 5];
            int lower = 3;
            int upper = 6;
            long expected = 6;

            // Act
            long result = solution.CountFairPairs(nums, lower, upper);

            // Assert
            Xunit.Assert.Equal(result, expected);
        }
    }
}
