using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Strings
{
    class CountAndSaySolution
    {
        public string CountAndSay(int n)
        {
            if (n == 1) return "1";

            string previous = CountAndSay(n - 1);
            int counter = 0;
            char current = ' ';
            string result = string.Empty;

            for(int index = 0; index < previous.Length; ++index)
            {
                if(index == 0)
                {
                    current = previous[0];
                }

                if(current == previous[index])
                {
                    ++counter;
                }
                else
                {
                    result = result + counter.ToString() + current.ToString();
                    current = previous[index];
                    counter = 1;
                }
            }

            if(counter > 0)
            {
                result = result + counter.ToString() + current.ToString();
            }

            return result;
        }
    }
}
