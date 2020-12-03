using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Trees
{
    class IncreasingBSTSolution
    {
        private class Walker
        {
            private TreeNode _root;
            private TreeNode _previous;

            public void Append(TreeNode node)
            {
                if(_root == null)
                {
                    _root = new TreeNode(node.val);
                    _previous = _root;
                    return;
                }

                var next = new TreeNode(node.val);
                _previous.right = next;
                _previous = next;
            }

            public TreeNode Root => _root;
        }

        public TreeNode IncreasingBST(TreeNode root)
        {
            var walker = new Walker();
            Visit(root, walker);
            return walker.Root;
        }

        private void Visit(TreeNode node, Walker walker)
        {
            if (node == null) return;

            Visit(node.left, walker);
            walker.Append(node);
            Visit(node.right, walker);
        }
    }
}
