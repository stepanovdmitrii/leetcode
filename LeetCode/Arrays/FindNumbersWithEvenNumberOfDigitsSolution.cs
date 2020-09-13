using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Arrays
{
    class FindNumbersWithEvenNumberOfDigitsSolution
    {
        public int FindNumbers(int[] nums)
        {
            int result = 0;

            for(int i = 0; i < nums.Length; ++i)
            {
                int current = GetNumberOfDigits(nums[i]);
                if(current % 2 == 0)
                {
                    ++result;
                }
            }

            return result;
        }

        private static int GetNumberOfDigits(int value)
        {
            int result = 0;
            while(value > 0)
            {
                value = value / 10;
                ++result;
            }
            return result;
        }
    }
}
