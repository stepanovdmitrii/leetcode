using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LinkedList
{
    class RemoveNthFromTheEndSolution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (n == 0) return head;

            ListNode prev = null;
            ListNode delete = head;
            ListNode current = head;
            int offset = 0;
            while(current != null)
            {
                if (offset == n)
                {
                    prev = delete;
                    delete = delete.next;
                }
                else
                {
                    ++offset;
                }
                current = current.next;
            }

            if(prev == null) //head
            {
                return head.next;
            }
            else
            {
                prev.next = delete.next;
            }

            return head;
        }
    }
}
