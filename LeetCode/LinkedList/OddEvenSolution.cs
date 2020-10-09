using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LinkedList
{
    class OddEvenSolution
    {
        public ListNode OddEvenList(ListNode head)
        {
            ListNode even = new ListNode(-1); //dummy
            ListNode odd = new ListNode(-1); //dummy

            ListNode evenLast = even;
            ListNode oddLast = odd;

            int counter = 0;
            ListNode current = head;
            while(current != null)
            {
                if(counter % 2 == 0)
                {
                    evenLast.next = current;
                    evenLast = current;
                }
                else
                {
                    oddLast.next = current;
                    oddLast = current;
                }
                ++counter;
                current = current.next;
            }

            evenLast.next = odd.next;
            Print(even.next);
            return even.next;
        }

        private void Print(ListNode head)
        {
            ListNode current = head;
            while(current != null)
            {
                Console.WriteLine(current.val);
                current = current.next;
            }
        }
    }
}
