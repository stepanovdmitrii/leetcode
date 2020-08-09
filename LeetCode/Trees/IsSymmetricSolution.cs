using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Trees
{
    class IsSymmetricSolution
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;
            if (root.left == null && root.right == null) return true;

            var forward = new Queue<TreeNode>();
            var reverse = new Queue<TreeNode>();

            forward.Enqueue(root.left);
            reverse.Enqueue(root.right);

            while(forward.Count > 0 && reverse.Count > 0)
            {
                var left = forward.Dequeue();
                var right = reverse.Dequeue();
                int? leftVal = left?.val;
                int? rightVal = right?.val;
                if (leftVal != rightVal) return false;
                if (left != null)
                {
                    forward.Enqueue(left.left);
                    forward.Enqueue(left.right);
                }
                if(right != null)
                {
                    reverse.Enqueue(right.right);
                    reverse.Enqueue(right.left);
                }
            }

            return forward.Count == 0 && reverse.Count == 0;
        }
    }
}
