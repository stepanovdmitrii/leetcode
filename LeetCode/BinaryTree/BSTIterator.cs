using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.BinaryTree
{
    public class BSTIterator
    {
        private readonly Stack<TreeNode> _stack;

        public BSTIterator(TreeNode root)
        {
            _stack = new Stack<TreeNode>();
            Fill(root);
        }

        private void Fill(TreeNode current)
        {
            while(current != null)
            {
                _stack.Push(current);
                current = current.left;
            }
        }

        public int Next()
        {
            var current = _stack.Pop();

            Fill(current.right);

            return current.val;
        }

        public bool HasNext()
        {
            return _stack.Count > 0;
        }
    }
}
