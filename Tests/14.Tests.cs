using Solutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class LongestCommonPrefixTests
    {
        readonly LongestCommonPrefixSolution solution = new LongestCommonPrefixSolution();
        [Fact]
        public void Test1()
        {
            // Arrange
            string[] strs = ["flower", "flow", "flight"];
            string expected = "fl";

            // Act
            string result = solution.LongestCommonPrefix(strs);

            // Assert
            Xunit.Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            string[] strs = ["dog", "racecar", "car"];
            string expected = "";

            // Act
            string result = solution.LongestCommonPrefix(strs);

            // Assert
            Xunit.Assert.Equal(expected, result);
        }


        [Fact]
        public void Test3()
        {
            // Arrange
            string[] strs = ["flower", "flow", "flight"];
            string expected = "1994";

            // Act
            string result = solution.LongestCommonPrefix(strs);

            // Assert
            Xunit.Assert.Equal(expected, result);
        }
    }
}
