using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.BinaryTree
{
    class InorderTraversalSolution
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            var result = new List<int>();
            if (root == null) return result;

            var stack = new Stack<TreeNode>();
            var current = root;
            while(current != null || stack.Count > 0)
            {
                while(current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }

                current = stack.Pop();
                result.Add(current.val);
                current = current.right;
            }

            return result;
        }
    }
}
