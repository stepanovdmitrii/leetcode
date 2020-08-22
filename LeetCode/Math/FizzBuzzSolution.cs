using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Math
{
    class FizzBuzzSolution
    {
        public IList<string> FizzBuzz(int n)
        {
            var result = new List<string>(n);
            for(int i = 1; i <= n; ++i)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    result.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(i.ToString());
                }
            }
            return result;
        }
    }
}
