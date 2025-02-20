using Solutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class RomanToIntegerTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            RomanToIntegerSolution solution = new RomanToIntegerSolution();

            string s = "III";
            int expected = 3;

            // Act
            int result = solution.RomanToInt(s);

            // Assert
            Xunit.Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            RomanToIntegerSolution solution = new RomanToIntegerSolution();

            string s = "LVIII";
            int expected = 58;

            // Act
            int result = solution.RomanToInt(s);

            // Assert
            Xunit.Assert.Equal(expected, result);
        }


        [Fact]
        public void Test3()
        {
            // Arrange
            RomanToIntegerSolution solution = new RomanToIntegerSolution();

            string s = "MCMXCIV";
            int expected = 1994;

            // Act
            int result = solution.RomanToInt(s);

            // Assert
            Xunit.Assert.Equal(expected, result);
        }
    }
}
