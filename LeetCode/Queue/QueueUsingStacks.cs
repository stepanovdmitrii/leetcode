using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Queue
{
    class QueueUsingStacks
    {

        public class MyQueue
        {
            private readonly Stack<int> _push = new Stack<int>();
            private readonly Stack<int> _pop = new Stack<int>();

            public MyQueue()
            {

            }

            public void Push(int x)
            {
                _push.Push(x);
            }

            public int Pop()
            {
                if (_pop.Count == 0) Flush();
                return _pop.Pop();
            }

            public int Peek()
            {
                if (_pop.Count == 0) Flush();
                return _pop.Peek();
            }

            private void Flush()
            {
                while(_push.Count > 0)
                {
                    _pop.Push(_push.Pop());
                }
            }

            public bool Empty()
            {
                return _push.Count == 0 && _pop.Count == 0;
            }
        }


    }
}
