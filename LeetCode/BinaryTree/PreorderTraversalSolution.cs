using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.BinaryTree
{
    class PreorderTraversalSolution
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            var result = new List<int>();

            var stack = new Stack<TreeNode>();
            if (root != null)
            {
                stack.Push(root);
            }
            while(stack.Count > 0)
            {
                var current = stack.Pop();
                result.Add(current.val);

                if(current.right != null)
                {
                    stack.Push(current.right);
                }

                if(current.left != null)
                {
                    stack.Push(current.left);
                }
            }

            return result;
        }
    }
}
