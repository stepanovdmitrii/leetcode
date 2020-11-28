using System;
using System.Collections.Generic;

namespace LeetCode.BinaryTree
{
    class GenerateTreesSolution
    {
        public IList<TreeNode> GenerateTrees(int n)
        {
            if (n == 0) return new List<TreeNode>();
            var arr = new int[n];
            for (int i = 0; i < n; ++i) arr[i] = i + 1;

            return Generate(arr.AsSpan());
        }

        private static List<TreeNode> Generate(Span<int> values)
        {
            if (values == null || values.IsEmpty) return new List<TreeNode> { null };
            if (values.Length == 1) return new List<TreeNode> { new TreeNode(values[0], null, null) };

            var result = new List<TreeNode>();

            for(int idx = 0; idx < values.Length; ++idx)
            {
                var left = values.Slice(0, idx);
                var right = idx == values.Length - 1 ? Span<int>.Empty : values.Slice(idx + 1);

                foreach(var leftSubTree in Generate(left))
                {
                    foreach(var rigthSubTree in Generate(right))
                    {
                        result.Add(new TreeNode(values[idx], leftSubTree, rigthSubTree));
                    }
                }
            }
            return result;
        }
    }
}
