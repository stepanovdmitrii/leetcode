using System;

namespace LeetCode.BinaryTree
{
    class InorderPostorderConstructSolution
    {
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            return Construct(inorder, postorder);
        }

        private TreeNode Construct(Span<int> inorder, Span<int> postorder)
        {
            if (inorder == null || inorder.Length == 0 || postorder == null || postorder.Length == 0) return null;
            var current = new TreeNode(postorder[postorder.Length - 1]);
            int indexOfCurrent = inorder.IndexOf(current.val);

            var inorderFromLeft = indexOfCurrent == 0 ? Span<int>.Empty : inorder.Slice(0, indexOfCurrent);
            var inorderFromRight = indexOfCurrent == inorder.Length - 1 ? Span<int>.Empty : inorder.Slice(indexOfCurrent + 1);

            var postorderFromLeft = inorderFromLeft.Length == 0 ? Span<int>.Empty : postorder.Slice(0, inorderFromLeft.Length);
            var postorderFromRight = inorderFromRight.Length == 0 ? Span<int>.Empty : postorder.Slice(inorderFromLeft.Length, inorderFromRight.Length);

            current.left = Construct(inorderFromLeft, postorderFromLeft);
            current.right = Construct(inorderFromRight, postorderFromRight);

            return current;
        }
    }
}
