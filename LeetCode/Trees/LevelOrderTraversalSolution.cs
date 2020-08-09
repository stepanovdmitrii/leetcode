using System.Collections.Generic;

namespace LeetCode.Trees
{
    class LevelOrderTraversalSolution
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();
            if (root == null) return result;
            Visit(root, 0, result);
            return result;
        }

        private void Visit(TreeNode node, int level, IList<IList<int>> acc)
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
