using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LinkedList
{
    public class MergeTwoListsSolution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            ListNode head = null;
            if(l1.val < l2.val)
            {
                head = l1;
                l1 = l1.next;
            }
            else
            {
                head = l2;
                l2 = l2.next;
            }

            ListNode current = head;
            while(true)
            {
                if(l1 == null && l2 == null)
                {
                    break;
                }
                else if (l1 == null)
                {
                    current.next = l2;
                    current = current.next;
                    l2 = l2.next;
                }
                else if (l2 == null)
                {
                    current.next = l1;
                    current = current.next;
                    l1 = l1.next;
                }
                else if (l2.val <= l1.val)
                {
                    current.next = l2;
                    current = current.next;
                    l2 = l2.next;
                }
                else
                {
                    current.next = l1;
                    current = current.next;
                    l1 = l1.next;
                }
            }
            return head;
        }
    }
}
