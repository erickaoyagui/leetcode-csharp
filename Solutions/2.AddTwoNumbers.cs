using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class AddTwoNumbersSolution
    {
        public ListNode AddTwoNumbersRecursive(ListNode l1, ListNode l2, int carry = 0)
        {
            if (l1 == null && l2 == null && carry == 0) return null; // Recursive return statement

            int newVal = (l1 == null ? 0 : l1.val)
                + (l2 == null ? 0 : l2.val)
                + carry;

            carry = newVal / 10;

            ListNode result = new ListNode(newVal % 10, AddTwoNumbersRecursive(l1?.next,
                l2?.next,
                carry));

            return result;
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();
            ListNode aux = result;
            int carry = 0;
            int newVal = 0;

            while (l1 != null || l2 != null || carry > 0)
            {
                newVal = (l1 == null ? 0 : l1.val)
                + (l2 == null ? 0 : l2.val)
                + carry;

                carry = newVal / 10;

                aux.next = new ListNode(newVal % 10); 

                l1 = l1?.next;
                l2 = l2?.next;

                aux = aux.next;
            }

            return result.next;
        }
    }

    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
