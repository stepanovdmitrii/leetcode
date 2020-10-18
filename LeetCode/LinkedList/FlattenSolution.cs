using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LinkedList
{
    class FlattenSolution
    {
        public class Node
        {
            public int val;
            public Node prev;
            public Node next;
            public Node child;
        }

        public Node Flatten(Node head)
        {
            if (head == null) return null;
            var result = new Node();
            var resultHead = result;

            Visit(head, result, out _);

            resultHead.next.prev = null;
            return resultHead.next;
        }

        private static void Visit(Node head, Node target, out Node nextTarget)
        {
            nextTarget = target;
            if (head == null) return;
            var current = head;

            while(current != null)
            {
                var n = new Node();
                n.val = current.val;
                n.prev = target;
                target.next = n;
                target = n;
                Visit(current.child, target, out Node nextTargetLocal);
                target = nextTargetLocal;
                current = current.next;
            }
            nextTarget = target;
        }
    }
}
