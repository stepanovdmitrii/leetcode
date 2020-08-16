using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Design
{
    public class MinStack
    {
        private readonly Stack<int> _values = new Stack<int>();
        private readonly Stack<int> _min = new Stack<int>();

        /** initialize your data structure here. */
        public MinStack()
        {

        }

        public void Push(int x)
        {
            _values.Push(x);
            if(_min.Count == 0)
            {
                _min.Push(x);
            }
            else
            {
                _min.Push(Math.Min(_min.Peek(), x));
            }
        }

        public void Pop()
        {
            _values.Pop();
            _min.Pop();
        }

        public int Top()
        {
            return _values.Peek();
        }

        public int GetMin()
        {
            return _min.Peek();
        }
    }
}
