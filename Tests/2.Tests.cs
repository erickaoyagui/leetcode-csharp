using Solutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class AddTwoNumbersTests
    {
        readonly AddTwoNumbersSolution solution = new AddTwoNumbersSolution();
        private bool AreListsEqual(ListNode l1, ListNode l2)
        {
            while (l1 != null && l2 != null)
            {
                if (l1.val != l2.val) return false;
                l1 = l1.next;
                l2 = l2.next;
            }
            return l1 == null && l2 == null;
        }

        [Fact]
        public void Test1()
        {
            // Arrange
            ListNode l1 = new ListNode(2,
                new ListNode(4,
                new ListNode(3)));

            ListNode l2 = new ListNode(5,
                            new ListNode(6,
                            new ListNode(4)));

            ListNode expected = new ListNode(7,
                new ListNode(0,
                new ListNode(8)));

            // Act
            ListNode result = solution.AddTwoNumbers(l1, l2);

            // Assert
            Xunit.Assert.True(AreListsEqual(expected, result));
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            ListNode l1 = new ListNode(0);

            ListNode l2 = new ListNode(0);

            ListNode expected = new ListNode(0);

            // Act
            ListNode result = solution.AddTwoNumbers(l1, l2);

            // Assert
            Xunit.Assert.True(AreListsEqual(expected, result));
        }

        [Fact]
        public void Test3()
        {
            // Arrange
            ListNode l1 = new ListNode(9,
                new ListNode(9,
                new ListNode(9,
                new ListNode(9,
                new ListNode(9,
                new ListNode(9,
                new ListNode(9)))))));

            ListNode l2 = new ListNode(9,
                            new ListNode(9,
                            new ListNode(9,
                            new ListNode(9))));

            ListNode expected = new ListNode(8,
                new ListNode(9,
                new ListNode(9,
                new ListNode(9,
                new ListNode(0,
                new ListNode(0,
                new ListNode(0,
                new ListNode(1))))))));

            // Act
            ListNode result = solution.AddTwoNumbers(l1, l2);

            // Assert
            Xunit.Assert.True(AreListsEqual(expected, result));
        }
    }
}
