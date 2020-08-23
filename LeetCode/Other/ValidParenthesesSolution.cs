using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Other
{
    class ValidParenthesesSolution
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            foreach(char ch in s)
            {
                if (IsOpen(ch))
                {
                    stack.Push(ch);
                }
                else
                {
                    if (stack.Count == 0) return false;
                    char open = stack.Pop();
                    if(false == ArePair(open, ch))
                    {
                        return false;
                    }
                }
            }


            return stack.Count == 0;
        }

        private bool IsOpen(char ch)
        {
            return ch == '{' || ch == '[' || ch == '(';
        }

        private bool ArePair(char open, char close)
        {
            return
                (open == '(' && close == ')') ||
                (open == '[' && close == ']') ||
                (open == '{' && close == '}');
        }
    }
}
