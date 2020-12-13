using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Stack
{
    class DecodeStringSolution
    {
        public string DecodeString(string s)
        {
            return DecodeString(s.AsSpan());
        }

        private static string DecodeString(ReadOnlySpan<char> s)
        {
            var sb = new System.Text.StringBuilder();
            var count = new StringBuilder();
            for (int idx = 0; idx < s.Length; ++idx)
            {
                while (Char.IsDigit(s[idx]))
                {
                    count.Append(s[idx]);
                    ++idx;
                }

                if (count.Length > 0 && s[idx] != '[') throw new InvalidOperationException("Format");

                if (s[idx] == '[')
                {
                    int end = FindEnd(s, idx);
                    string decoded = DecodeString(s.Slice(idx + 1, end - idx - 1));

                    int repeats = int.Parse(count.ToString());
                    for (int i = 0; i < repeats; ++i)
                    {
                        sb.Append(decoded);
                    }
                    idx = end;
                    count.Clear();
                }
                
                if (Char.IsLetter(s[idx])) sb.Append(s[idx]);
            }
            return sb.ToString();
        }

        private static int FindEnd(ReadOnlySpan<char> s, int start)
        {
            if (s[start] != '[') throw new InvalidOperationException(nameof(FindEnd));

            var stack = new Stack<int>();
            stack.Push(start);

            for(int i = start + 1; i < s.Length; ++i)
            {
                if(s[i] == '[')
                {
                    stack.Push(i);
                }
                else if (s[i] == ']')
                {
                    stack.Pop();
                }

                if (stack.Count == 0) return i;
            }


            throw new InvalidOperationException("End not found");
        }
    }
}
