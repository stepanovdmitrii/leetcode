using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Arrays
{
    class NumbersDissapearedInArraySolution
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            var result = new List<int>();

            for(int i = 0; i < nums.Length; ++i)
            {
                int index = System.Math.Abs(nums[i]) - 1;
                nums[index] *= nums[index] < 0 ? 1 : -1;
            }

            for(int i = 0; i < nums.Length; ++i)
            {
                if(nums[i] > 0)
                {
                    result.Add(i + 1);
                }
            }


            return result;
        }
    }
}
