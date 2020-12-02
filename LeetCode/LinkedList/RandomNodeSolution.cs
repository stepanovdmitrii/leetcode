using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LinkedList
{
    class RandomNodeSolution
    {
        public class Solution
        {
            private readonly Random _random;
            private readonly int _length;
            private readonly ListNode _head;

            /** @param head The linked list's head.
                Note that the head is guaranteed to be not null, so it contains at least one node. */
            public Solution(ListNode head)
            {
                _random = new Random();
                _length = GetLength(head);
                _head = head;
            }

            private static int GetLength(ListNode head)
            {
                int count = 0;
                ListNode current = head;
                while(current != null)
                {
                    ++count;
                    current = current.next;
                }
                return count;
            }

            /** Returns a random node's value. */
            public int GetRandom()
            {
                int position = _random.Next(0, _length);
                int current = 0;
                ListNode node = _head;
                while(current != position)
                {
                    node = node.next;
                    ++current;
                }
                return node.val;
            }
        }
    }
}
