using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.BinaryTree
{
    class LowestCommonAncestorOfDeepestLeavesSolution
    {

        public TreeNode SubtreeWithAllDeepest(TreeNode root)
        {
            return LcaDeepestLeaves(root);
        }

        public TreeNode LcaDeepestLeaves(TreeNode root)
        {
            return Visit(root).Node;
        }

        private static NodeAndDepth Visit(TreeNode node)
        {
            if (node == null) return new NodeAndDepth { Node = null, Depth = -1 };

            var leftResult = Visit(node.left);
            var rightResult = Visit(node.right);

            if(leftResult.Depth > rightResult.Depth)
            {
                leftResult.Depth++;
                return leftResult;
            }
            else if (rightResult.Depth > leftResult.Depth)
            {
                rightResult.Depth++;
                return rightResult;
            }
            else
            {
                return new NodeAndDepth { Depth = leftResult.Depth + 1, Node = node };
            }
        }

        private sealed class NodeAndDepth
        {
            public TreeNode Node { get; set; }
            public int Depth { get; set; }
        }
    }
}
