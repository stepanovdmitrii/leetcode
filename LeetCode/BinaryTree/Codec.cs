using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.BinaryTree
{
    public class Codec
    {
        private const string ValueSeparator = ",";
        private const string InorderPostorderSeparator = ";";
        private const string KeyValueSeparator = ":";

        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            var nodeId = new Dictionary<TreeNode, int>();
            var inorder = InorderTraversal(root, nodeId);
            var postorder = PostorderTraversal(root, nodeId);
            return string.Join(InorderPostorderSeparator,
                string.Join(ValueSeparator, inorder.Select(v => v.ToString())),
                string.Join(ValueSeparator, postorder.Select(v => v.ToString())),
                string.Join(ValueSeparator, nodeId.Select(p => string.Join(KeyValueSeparator, p.Value, p.Key.val)))
                );
        }

        private IList<int> InorderTraversal(TreeNode root, Dictionary<TreeNode, int> nodeId)
        {
            var result = new List<int>();
            if (root == null) return result;

            var stack = new Stack<TreeNode>();
            var current = root;
            while (current != null || stack.Count > 0)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }

                current = stack.Pop();

                var id = nodeId.Count;
                nodeId[current] = id;
                result.Add(id);

                current = current.right;
            }

            return result;
        }

        private IList<int> PostorderTraversal(TreeNode root, IReadOnlyDictionary<TreeNode, int> nodeId)
        {
            var result = new List<int>();
            if (root == null) return result;
            Visit(root, result, nodeId);
            return result;
        }

        private void Visit(TreeNode node, List<int> result, IReadOnlyDictionary<TreeNode, int> nodeId)
        {
            if (node.left != null) Visit(node.left, result, nodeId);
            if (node.right != null) Visit(node.right, result, nodeId);
            result.Add(nodeId[node]);
        }



        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            if (string.IsNullOrEmpty(data)) return null;
            var orders = data.Split(InorderPostorderSeparator, StringSplitOptions.RemoveEmptyEntries);
            if (orders.Length == 0) return null;

            var inorder = orders[0].Split(ValueSeparator).Select(s => int.Parse(s)).ToArray();
            var postorder = orders[1].Split(ValueSeparator).Select(s => int.Parse(s)).ToArray();
            var map = orders[2].Split(ValueSeparator).Select(p => p.Split(KeyValueSeparator)).ToDictionary(arr => int.Parse(arr[0]), arr => int.Parse(arr[1]));

            return BuildTree(inorder, postorder, map);
        }

        private TreeNode BuildTree(int[] inorder, int[] postorder, IReadOnlyDictionary<int, int> map)
        {
            return Construct(inorder, postorder, map);
        }

        private TreeNode Construct(Span<int> inorder, Span<int> postorder, IReadOnlyDictionary<int, int> map)
        {
            if (inorder == null || inorder.Length == 0 || postorder == null || postorder.Length == 0) return null;
            var current = new TreeNode(map[postorder[postorder.Length - 1]]);
            int indexOfCurrent = inorder.IndexOf(postorder[postorder.Length - 1]);

            var inorderFromLeft = indexOfCurrent == 0 ? Span<int>.Empty : inorder.Slice(0, indexOfCurrent);
            var inorderFromRight = indexOfCurrent == inorder.Length - 1 ? Span<int>.Empty : inorder.Slice(indexOfCurrent + 1);

            var postorderFromLeft = inorderFromLeft.Length == 0 ? Span<int>.Empty : postorder.Slice(0, inorderFromLeft.Length);
            var postorderFromRight = inorderFromRight.Length == 0 ? Span<int>.Empty : postorder.Slice(inorderFromLeft.Length, inorderFromRight.Length);

            current.left = Construct(inorderFromLeft, postorderFromLeft, map);
            current.right = Construct(inorderFromRight, postorderFromRight, map);

            return current;
        }
    }
}
