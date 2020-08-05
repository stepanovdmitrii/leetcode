using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace LeetCode.LinkedList
{
    class CycleSolution
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null) return false;
            ListNode slow = head;
            ListNode fast = head.next;
            while(fast.next != null && fast.next.next != null)
            {
                if (ReferenceEquals(slow, fast))
                    return true;

                slow = slow.next;
                fast = fast.next.next;
            }
            return false;
        }
    }
}
