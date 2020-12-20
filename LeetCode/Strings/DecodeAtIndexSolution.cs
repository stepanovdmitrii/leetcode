using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Strings
{
    public sealed class DecodeAtIndexSolution
    {
        private sealed class Iterator : IEnumerable<char>
        {
            private readonly string _input;
            private readonly int _tailStart;
            private readonly int _tailCount;
            private readonly IEnumerable<char> _previous;
            private readonly int _repeat;

            public Iterator(string input, int tailStart, int tailCount, int repeat, IEnumerable<char> previous)
            {
                _input = input;
                _tailStart = tailStart;
                _tailCount = tailCount;
                _repeat = repeat;
                _previous = previous;
            }

            public IEnumerator<char> GetEnumerator()
            {
                for(int repeat = 0; repeat < _repeat; ++repeat)
                {
                    foreach(var ch in _previous)
                    {
                        yield return ch;
                    }
                    for(int idx = _tailStart; idx < _tailStart + _tailCount; ++idx)
                    {
                        yield return _input[idx];
                    }
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public string DecodeAtIndex(string S, int K)
        {
            long size = 0;
            foreach(var ch in S)
            {
                if (char.IsDigit(ch))
                {
                    size *= long.Parse(ch.ToString());
                }
                else
                {
                    size++;
                }
            }

            long k = K - 1;

            for(int idx = S.Length - 1; idx >= 0; --idx)
            {
                if (char.IsDigit(S[idx]))
                {
                    long mult = long.Parse(S[idx].ToString());
                    long baseSize = size / mult;
                    if(k >= baseSize && k < size)
                    {
                        k = k % baseSize;
                    }
                    size = baseSize;
                }
                else
                {
                    --size;
                    if(size == k)
                    {
                        return S[idx].ToString();
                    }
                }
            }

            return string.Empty;
        }

        private static IEnumerable<char> Enumerate(string S)
        {
            var result = Enumerable.Empty<char>();

            int tailStart = 0;
            int tailCount = 0;
            for(int idx = 0; idx < S.Length; ++idx)
            {
                if (char.IsDigit(S[idx]))
                {
                    int repeat = int.Parse(S[idx].ToString());
                    var next = new Iterator(S, tailStart, tailCount, repeat, result);
                    result = next;
                    tailCount = tailStart = 0;
                }
                else
                {
                    if(tailCount == 0)
                    {
                        tailStart = idx;
                    }
                    ++tailCount;
                }
            }

            if(tailCount > 0)
            {
                var next = new Iterator(S, tailStart, tailCount, 1, result);
                result = next;
            }

            return result;
        }
    }
}
