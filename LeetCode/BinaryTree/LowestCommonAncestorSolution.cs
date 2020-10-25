using System.Collections.Generic;

namespace LeetCode.BinaryTree
{
    class LowestCommonAncestorSolution
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root.val == p.val || root.val == q.val) return root;
            if (p.val == q.val) return p;

            var parents = new Dictionary<TreeNode, TreeNode>(new TreeNodeEqualityComparer());
            
            FillParents(root, null, parents, p, q);

            var pPath = FindPath(p, parents);
            var qPath = FindPath(q, parents);

            var fromP = pPath?.First;
            var fromQ = qPath?.First;
            
            TreeNode result = root;
            while(fromP != null && fromQ != null && fromP.Value.val == fromQ.Value.val)
            {
                result = fromP.Value;
                fromP = fromP.Next;
                fromQ = fromQ.Next;
            }

            return result;
        }

        public TreeNode LowestCommonAncestorSimple(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || root == p || root == q) return root;
            var fromLeft = LowestCommonAncestorSimple(root.left, p, q);
            var fromRight = LowestCommonAncestorSimple(root.right, p, q);
            if (fromLeft != null && fromRight != null) return root;
            return fromLeft ?? fromRight;
        }

        private void FillParents(TreeNode node, TreeNode parent, Dictionary<TreeNode, TreeNode> parents, TreeNode p, TreeNode q)
        {
            if (node == null) return;

            parents[node] = parent;

            if(!parents.ContainsKey(p) || !parents.ContainsKey(q))
            {
                FillParents(node.left, node, parents, p, q);
                FillParents(node.right, node, parents, p, q);
            }
        }

        private LinkedList<TreeNode> FindPath(TreeNode node, Dictionary<TreeNode, TreeNode> parents)
        {
            var result = new LinkedList<TreeNode>();
            var current = node;
            while(current != null)
            {
                result.AddFirst(current);
                current = parents[current];
            }
            return result;
        }

        private sealed class TreeNodeEqualityComparer : IEqualityComparer<TreeNode>
        {
            public bool Equals(TreeNode x, TreeNode y)
            {
                if (x == null && y == null) return true;
                if (x == null || y == null) return false;
                return x.val == y.val;
            }

            public int GetHashCode(TreeNode obj)
            {
                return obj.val;
            }
        }
    }
}
