using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Stack
{
    public class EvalRPNSolution
    {
        private static Dictionary<string, Func<int, int, int>> Functions = new Dictionary<string, Func<int, int, int>>
        {
            {"+", (left, right) => left + right },
            {"-", (left, right) => left - right },
            {"*", (left, right) => left * right },
            {"/", (left, right) => (int)(left / right) }
        };
        public int EvalRPN(string[] tokens)
        {
            var expression = new Stack<string>();
            foreach(var token in tokens)
            {
                expression.Push(token);
            }
            return GetResult(expression.Pop(), expression);
        }

        private static int GetResult(string current, Stack<string> expression)
        {
            if (int.TryParse(current, out int value)) return value;

            Func<int, int, int> func = Functions[current];

            int right = GetResult(expression.Pop(), expression);
            int left = GetResult(expression.Pop(), expression);
            
            return func(left, right);
        }
    }
}
