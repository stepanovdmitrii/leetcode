using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LinkedList
{
    class CopyListWithRandomPointerSolution
    {
        public class Node
        {
            public int val;
            public Node next;
            public Node random;

            public Node(int _val)
            {
                val = _val;
                next = null;
                random = null;
            }
        }

        public Node CopyRandomList(Node head)
        {
            if (head == null) return null;
            var map = new Dictionary<Node, Node>();
            Node stub = new Node(-1);
            Node prev = stub;

            Node source = head;
            while(source != null)
            {
                var copy = GetOrCreate(source, map);
                prev.next = copy;

                prev = copy;
                source = source.next;
            }

            return stub.next;
        }

        private static Node GetOrCreate(Node source, Dictionary<Node, Node> map)
        {
            if(map.TryGetValue(source, out var founded))
            {
                return founded;
            }
            var copy = new Node(source.val);
            map[source] = copy;
            if(source.random != null)
            {
                copy.random = GetOrCreate(source.random, map);
            }
            return copy;
        }
    }
}
