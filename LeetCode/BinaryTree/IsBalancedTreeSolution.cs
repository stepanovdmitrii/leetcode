using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.BinaryTree
{
    class IsBalancedTreeSolution
    {
        private bool _isBalanced = true;

        public bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;
            Visit(root, 0);
            return _isBalanced;
        }

        private int Visit(TreeNode node, int length)
        {
            if (!_isBalanced) return -1;
            if (node == null) return length;
            int leftLength = Visit(node.left, length + 1);
            int rightLength = Visit(node.right, length + 1);
            if (!_isBalanced) return -1;
            _isBalanced = System.Math.Abs(leftLength - rightLength) <= 1;
            return System.Math.Max(leftLength, rightLength);
        }
    }
}
