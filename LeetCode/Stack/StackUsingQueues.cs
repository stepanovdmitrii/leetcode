using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Stack
{
    class StackUsingQueues
    {

        public class MyStack
        {
            private readonly Queue<int> _buffer = new Queue<int>();

            public MyStack()
            {

            }

            public void Push(int x)
            {
                _buffer.Enqueue(x);
                for(int i = 0; i < _buffer.Count - 1; ++i)
                {
                    _buffer.Enqueue(_buffer.Dequeue());
                }
            }

            /** Removes the element on top of the stack and returns that element. */
            public int Pop()
            {
                return _buffer.Dequeue();
            }

            /** Get the top element. */
            public int Top()
            {
                return _buffer.Peek();
            }

            /** Returns whether the stack is empty. */
            public bool Empty()
            {
                return _buffer.Count == 0;
            }
        }

    }
}
