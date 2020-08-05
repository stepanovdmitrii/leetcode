using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LinkedList
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }


    class DeleteNodeSolution
    {
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}
