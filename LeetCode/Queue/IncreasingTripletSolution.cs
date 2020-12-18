using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Queue
{
    class IncreasingTripletSolution
    {
        public bool IncreasingTriplet(int[] nums)
        {
            if (nums.Length < 3) return false;
            if (nums.Length == 3) return nums[0] < nums[1] && nums[1] < nums[2];

            int minOne = int.MaxValue;
            int minTwo = int.MaxValue;

            foreach(var num in nums)
            {
                if (num < minOne)
                {
                    minOne = num;
                }

                if (num > minOne)
                {
                    minTwo = num < minTwo ? num : minTwo;
                }

                if (num > minTwo)
                {
                    return true;
                }
            }

            return false;
        }


    }
}
