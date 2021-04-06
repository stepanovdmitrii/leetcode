using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.BinaryTree
{
    class ZigzagLevelOrderSolution
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            var result = new List<List<int>>();
            var copy = new List<IList<int>>();
            Visit(root, 0, result);
            for(int i = 0; i < result.Count; i++)
            {
                if (i % 2 == 1)
                {
                    result[i].Reverse();
                }
                copy.Add(result[i]);
            }

            return copy;
        }

        private void Visit(TreeNode node, int level, List<List<int>> acc)
        {
            if (node == null) return;
            while (acc.Count <= level)
            {
                acc.Add(new List<int>());
            }
            var levelAcc = acc[level];
            levelAcc.Add(node.val);

            Visit(node.left, level + 1, acc);
            Visit(node.right, level + 1, acc);
        }
    }
}
