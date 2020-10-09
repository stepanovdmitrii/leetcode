using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LinkedList
{
    public sealed class RemoveElementsByValSolution
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode newHead = head;
            while(newHead != null && newHead.val == val)
            {
                newHead = newHead.next;
            }

            if (newHead == null) return null;

            ListNode prev = newHead;
            ListNode current = newHead.next;

            while(current != null)
            {
                if(current.val == val)
                {
                    current = current.next;
                    prev.next = current;
                }
                else
                {
                    prev = current;
                    current = current.next;
                }
            }

            return newHead;
        }
    }
}
