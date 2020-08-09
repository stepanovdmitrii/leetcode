using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Trees
{
    class SortedTreeToBSTSolution
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums == null || nums.Length == 0) return null;

            int mid = nums.Length / 2;
            TreeNode root = new TreeNode(nums[mid]);
            Split(nums.AsSpan(), mid, out var lower, out var greater);
            Append(root, lower, greater);
            return root;
        }

        private void Append(TreeNode parent, Span<int> lower, Span<int> greater)
        {
            if(lower.Length > 0)
            {
                int mid = lower.Length / 2;
                parent.left = new TreeNode(lower[mid]);
                Split(lower, mid, out var nextLower, out var nextGreater);
                Append(parent.left, nextLower, nextGreater);
            }
            if(greater.Length > 0)
            {
                int mid = greater.Length / 2;
                parent.right = new TreeNode(greater[mid]);
                Split(greater, mid, out var nextLower, out var nextGreater);
                Append(parent.right, nextLower, nextGreater);
            }
        }

        private static void Split(Span<int> source, int index, out Span<int> lower, out Span<int> greater)
        {
            if(index == 0)
            {
                lower = Span<int>.Empty;
            }
            else
            {
                lower = source.Slice(0, index);
            }

            if(index >= source.Length)
            {
                greater = Span<int>.Empty;
            }
            else
            {
                greater = source.Slice(index + 1, source.Length - index - 1);
            }
        }
    }
}
