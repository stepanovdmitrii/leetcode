using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LinkedList
{
    class RotateRightSolution
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (k == 0) return head;
            if (head == null) return null;

            ListNode last = head;
            int count = 1;
            while(last.next != null)
            {
                ++count;
                last = last.next;
            }

            k = k % count;

            if (k == 0) return head;

            int offset = count - k;
            ListNode newLast = head;
            while(offset - 1 > 0)
            {
                newLast = newLast.next;
                --offset;
            }

            var result = newLast.next;
            newLast.next = null;
            last.next = head;

            return result;
        }
    }
}
