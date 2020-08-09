using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Trees
{
    class MaxDepthSolution
    {
        public int MaxDepth(TreeNode root)
        {
            return MaxDepthInternal(root, 0);
        }

        private int MaxDepthInternal(TreeNode node, int depth)
        {
            if (node == null) return depth;

            int left = MaxDepthInternal(node.left, depth + 1);
            int right = MaxDepthInternal(node.right, depth + 1);
            return left > right ? left : right;
        }
    }
}
