using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Dynamic
{
    class HouseRobberSolution
    {
        public int Rob(int[] nums)
        {
            int result = 0;
            for(int index = 0; index < nums.Length; ++index)
            {
                int threeStepsBack = (index - 3) >= 0 ? nums[index - 3] : 0;
                int twoStepsBack = (index - 2) >= 0 ? nums[index - 2] : 0;
                nums[index] = System.Math.Max(twoStepsBack + nums[index], threeStepsBack + nums[index]);
                result = System.Math.Max(result, nums[index]);
            }

            return result;
        }
    }
}
