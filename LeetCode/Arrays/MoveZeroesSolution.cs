using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Arrays
{
    class MoveZeroesSolution
    {
        public void MoveZeroes(int[] nums)
        {
            if (nums.Length <= 1) return;

            
            int target = 0;
            while (target < nums.Length && nums[target] != 0)
            {
                target++;
            }
            if (target == nums.Length) return;

            int source = target + 1;
            while (source < nums.Length)
            {
                if(nums[source] != 0)
                {
                    Swap(nums, target, source);
                    ++target;
                }
                ++source;
            }
        }

        private void Swap(int[] nums, int first, int second)
        {
            int tmp = nums[first];
            nums[first] = nums[second];
            nums[second] = tmp;
        }


    }
}
