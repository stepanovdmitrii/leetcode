using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LinkedList
{
    class ReverseLinkedListSolution
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode current = head;
            while(current != null)
            {
                ListNode next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            return prev;
        }
    }
}
