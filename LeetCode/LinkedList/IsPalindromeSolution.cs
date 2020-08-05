using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LinkedList
{
    class IsPalindromeSolution
    {
        public bool IsPalindrome(ListNode head)
        {
            if (head == null) return true;
            if (head.next == null) return true;

            int count = 0;
            ListNode current = head;
            while(current != null)
            {
                ++count;
                current = current.next;
            }

            int reverse = count / 2;

            current = head;
            ListNode prev = null;
            while(reverse > 0)
            {
                ListNode tmp = current.next;
                current.next = prev;
                prev = current;
                current = tmp;
                --reverse;
            }

            ListNode reversed = prev;
            if (count % 2 == 1) current = current.next;

            while(current != null && reversed != null)
            {
                if (current.val != reversed.val) return false;
                current = current.next;
                reversed = reversed.next;
            }

            return true;
        }
    }
}
