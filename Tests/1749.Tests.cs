using Solutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class MaxAbsSumSubarrayTests
    {
        readonly MaxAbsSumSubarraySolution solution = new MaxAbsSumSubarraySolution();
        [Fact]
        public void Test1()
        {
            // Arrange
            int[] nums = [1, -3, 2, 3, -4];
            int expected = 5;

            // Act
            int result = solution.MaxAbsoluteSum(nums);

            // Assert
            Xunit.Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            int[] nums = [2, -5, 1, -4, 3, -2];
            int expected = 8;

            // Act
            int result = solution.MaxAbsoluteSum(nums);

            // Assert
            Xunit.Assert.Equal(expected, result);
        }

        [Fact]
        public void Test3()
        {
            // Arrange
            int[] nums = [-7, -1, 0, -2, 1, 3, 8, -2, -6, -1, -10, -6, -6, 8, -4, -9, -4, 1, 4, -9];
            int expected = 44;

            // Act
            int result = solution.MaxAbsoluteSum(nums);

            // Assert
            Xunit.Assert.Equal(expected, result);
        }
    }
}
