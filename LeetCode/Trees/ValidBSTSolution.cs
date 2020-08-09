using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Trees
{
    class ValidBSTSolution
    {
        class Walker
        {
            private bool _hasPrevious = false;
            private int _previous = 0;
            public bool _valid = true;

            public void SetNext(int value)
            {
                if (_hasPrevious)
                {
                    _valid = _valid && value > _previous;
                }

                _hasPrevious = true;
                _previous = value;
            }
        }

        public bool IsValidBST(TreeNode root)
        {
            var walker = new Walker();
            Traverse(root, walker);
            return walker._valid;
        }

        private void Traverse(TreeNode node, Walker walker)
        {
            if (node == null) return;
            if (walker._valid == false) return;

            Traverse(node.left, walker);
            walker.SetNext(node.val);
            Traverse(node.right, walker);
        }
    }
}
