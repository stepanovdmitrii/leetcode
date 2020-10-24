using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.BinaryTree
{
    class HasPathSumSolution
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            return TryFind(root, 0, sum);
        }

        private static bool TryFind(TreeNode node, int currentSum, int required)
        {
            if (node == null) return false;
            if(node.left == null && node.right == null && node.val + currentSum == required)
            {
                return true;
            }

            if (node.val + currentSum > required) return false;

            return TryFind(node.left, currentSum + node.val, required) || TryFind(node.right, currentSum + node.val, required);
        }
    }
}
