using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Design
{
    public sealed class BasicCalculator2
    {
        public int Calculate(string s)
        {
            List<string> tokens = ParseTokens(s);
            var stack = new Stack<int>();

            bool number = true;
            string operation = string.Empty;

            foreach(var token in tokens)
            {
                if (number)
                {
                    int value = int.Parse(token);
                    if(operation == "+" || string.IsNullOrEmpty(operation))
                    {
                        stack.Push(value);
                    }
                    else if(operation == "-")
                    {
                        value = -1 * value;
                        stack.Push(value);
                    }
                    else if(operation == "*")
                    {
                        int previous = stack.Pop();
                        stack.Push(previous * value);
                    }
                    else if(operation == "/")
                    {
                        int previous = stack.Pop();
                        stack.Push(previous / value);
                    }
                    else
                    {
                        throw new Exception($"Invalid operation: {operation}");
                    }
                }
                else
                {
                    operation = token;
                }

                number = !number;
            }


            return stack.Sum();
        }

        private static List<string> ParseTokens(string s)
        {
            var result = new List<string>();

            var sb = new StringBuilder();
            for(int idx = 0; idx < s.Length;)
            {
                while (idx < s.Length && s[idx] == ' ')
                {
                    ++idx;
                }

                sb.Clear();

                while(idx < s.Length && Char.IsDigit(s[idx]))
                {
                    sb.Append(s[idx]);
                    ++idx;
                }

                if(sb.Length > 0)
                {
                    result.Add(sb.ToString());
                }

                while (idx < s.Length && s[idx] == ' ')
                {
                    ++idx;
                }

                if (idx < s.Length)
                {
                    result.Add(s[idx].ToString());
                    ++idx;
                }

            }

            return result;
        }
    }
}
