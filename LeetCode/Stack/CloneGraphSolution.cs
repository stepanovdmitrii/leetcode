using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Stack
{
    class CloneGraphSolution
    {
        public class Node
        {
            public int val;
            public IList<Node> neighbors;

            public Node()
            {
                val = 0;
                neighbors = new List<Node>();
            }

            public Node(int _val)
            {
                val = _val;
                neighbors = new List<Node>();
            }

            public Node(int _val, List<Node> _neighbors)
            {
                val = _val;
                neighbors = _neighbors;
            }
        }


        public Node CloneGraph(Node node)
        {
            var cloned = new Dictionary<int, Node>();
            return Clone(node, cloned);
        }

        private Node Clone(Node node, Dictionary<int, Node> cloned)
        {
            if (node == null) return null;
            var result = new Node();
            result.val = node.val;
            cloned.Add(result.val, result);

            foreach(var sourceNode in node.neighbors)
            {
                if(cloned.TryGetValue(sourceNode.val, out var clone))
                {
                    result.neighbors.Add(clone);
                }
                else
                {
                    result.neighbors.Add(Clone(sourceNode, cloned));
                }
            }

            return result;
        }
    }
}
