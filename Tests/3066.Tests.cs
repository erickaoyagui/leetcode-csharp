using Solutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class MinimumOperationsToExceedThresholdValueIITests
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            MinimumOperationsToExceedThresholdValueII minimum = new MinimumOperationsToExceedThresholdValueII();
            int[] nums = [2, 11, 10, 1, 3];
            int k = 10;
            int expected = 2;

            // Act
            int result = minimum.MinOperations(nums, k);

            // Assert
            Xunit.Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            MinimumOperationsToExceedThresholdValueII minimum = new MinimumOperationsToExceedThresholdValueII();
            int[] nums = [1, 1, 2, 4, 9];
            int k = 20;
            int expected = 4;

            // Act
            int result = minimum.MinOperations(nums, k);

            // Assert
            Xunit.Assert.Equal(expected, result);
        }


        [Fact]
        public void Test3()
        {
            // Arrange
            MinimumOperationsToExceedThresholdValueII minimum = new MinimumOperationsToExceedThresholdValueII();
            int[] nums = [999999999, 999999999, 999999999];
            int k = 1000000000;
            int expected = 2;

            // Act
            int result = minimum.MinOperations(nums, k);

            // Assert
            Xunit.Assert.Equal(expected, result);
        }
    }
}
