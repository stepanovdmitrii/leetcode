using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Stack
{
    class DailyTemperaturesSolution
    {
        public int[] DailyTemperatures(int[] T)
        {
            var result = new int[T.Length];
            var stack = new Stack<int>();

            for(int idx = T.Length - 1; idx >= 0; --idx)
            {
                while(stack.Count > 0 && T[idx] >= T[stack.Peek()])
                {
                    stack.Pop();
                }

                result[idx] = stack.Count == 0 ? 0 : stack.Peek() - idx;

                stack.Push(idx);
            }


            return result;
        }
    }
}
