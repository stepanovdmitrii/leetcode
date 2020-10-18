using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LinkedList
{
    class AddTwoNumbersSolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var first = l1;
            var second = l2;
            var result = new ListNode(0);
            var head = result;
            int overflow = 0;

            while(first != null || second != null)
            {
                int firstVal = first?.val ?? 0;
                int secondVal = second?.val ?? 0;
                int sum = firstVal + secondVal + overflow;
                var current = sum % 10;
                result.next = new ListNode(current);
                result = result.next;
                overflow = sum / 10;

                first = first?.next;
                second = second?.next;
            }

            if(overflow > 0)
            {
                result.next = new ListNode(overflow);
            }

            return head.next;
        }
    }
}
