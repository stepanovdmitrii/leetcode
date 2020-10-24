using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.BinaryTree
{
    class PostorderTraversalSolution
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            var result = new List<int>();
            if (root == null) return result;
            Visit(root, result);
            return result;
        }

        private void Visit(TreeNode node, List<int> result)
        {
            if (node.left != null) Visit(node.left, result);
            if (node.right != null) Visit(node.right, result);
            result.Add(node.val);
        }
    }
}
