using System.Collections.Generic;

namespace LeetCode.BinaryTree
{
    class PopulationNextRightPointersSolution
    {
        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node next;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, Node _left, Node _right, Node _next)
            {
                val = _val;
                left = _left;
                right = _right;
                next = _next;
            }
        }

        public Node Connect(Node root)
        {
            if (root == null) return null;
            var result = new List<IList<Node>>();
            Visit(root, 0, result);

            foreach(var level in result)
            {
                for(int index = 0; index < level.Count; ++index)
                {
                    if(index < level.Count - 1)
                    {
                        level[index].next = level[index + 1];
                    }
                }
            }


            return root;

        }

        private void Visit(Node node, int level, IList<IList<Node>> acc)
        {
            if (node == null) return;
            while (acc.Count <= level)
            {
                acc.Add(new List<Node>());
            }
            var levelAcc = acc[level];
            levelAcc.Add(node);

            Visit(node.left, level + 1, acc);
            Visit(node.right, level + 1, acc);
        }
    }
}
