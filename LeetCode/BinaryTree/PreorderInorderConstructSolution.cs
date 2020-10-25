using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.BinaryTree
{
    class PreorderInorderConstructSolution
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            return Construct(inorder, preorder);
        }

        private TreeNode Construct(Span<int> inorder, Span<int> preorder)
        {
            if (inorder == null || inorder.Length == 0 || preorder == null || preorder.Length == 0) return null;
            var current = new TreeNode(preorder[0]);
            int indexOfCurrent = inorder.IndexOf(current.val);

            var inorderFromLeft = indexOfCurrent == 0 ? Span<int>.Empty : inorder.Slice(0, indexOfCurrent);
            var inorderFromRight = indexOfCurrent == inorder.Length - 1 ? Span<int>.Empty : inorder.Slice(indexOfCurrent + 1);

            var preorderFromLeft = inorderFromLeft.Length == 0 ? Span<int>.Empty : preorder.Slice(1, inorderFromLeft.Length);
            var preorderFromRight = inorderFromRight.Length == 0 ? Span<int>.Empty : preorder.Slice(inorderFromLeft.Length + 1);

            current.left = Construct(inorderFromLeft, preorderFromLeft);
            current.right = Construct(inorderFromRight, preorderFromRight);

            return current;
        }
    }
}
