using Solutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class TwoSumTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            TwoSumSolution solution = new TwoSumSolution();
            int[] nums = [2, 7, 11, 15];
            int target = 9;
            int[] expected = [0, 1];

            // Act
            int[] result = solution.TwoSum(nums, target);

            // Assert
            Xunit.Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            TwoSumSolution solution = new TwoSumSolution();
            int[] nums = [3, 2, 4];
            int target = 6;
            int[] expected = [1, 2];

            // Act
            int[] result = solution.TwoSum(nums, target);

            // Assert
            Xunit.Assert.Equal(expected, result);
        }

        [Fact]
        public void Test3()
        {
            // Arrange
            TwoSumSolution solution = new TwoSumSolution();
            int[] nums = [3, 3];
            int target = 6;
            int[] expected = [0, 1];

            // Act
            int[] result = solution.TwoSum(nums, target);

            // Assert
            Xunit.Assert.Equal(expected, result);
        }
    }
}
