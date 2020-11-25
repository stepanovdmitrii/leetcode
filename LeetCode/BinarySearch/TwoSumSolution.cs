using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.BinarySearch
{
    class TwoSumSolution
    {
        public int[] TwoSum2(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;
            while(left < right)
            {
                int sum = numbers[left] + numbers[right];
                if(sum < target)
                {
                    ++left;
                }
                else if(sum > target)
                {
                    --right;
                }
                else
                {
                    break;
                }
            }
            return new[] { left + 1, right + 1 };
        }

        public int[] TwoSum(int[] numbers, int target)
        {
            for(int index = 0; index < numbers.Length; ++index)
            {
                int sub = target - numbers[index];
                if (TryFindIndexOf(numbers, sub, out int found) && found != index)
                {
                    return index < found ? new[] { index + 1, found + 1 } : new[] { found + 1, index + 1 };
                }
            }
            return new[] { -1, -1 };
        }

        private bool TryFindIndexOf(int[] numbers, int targetValue, out int indexOfTarget)
        {
            indexOfTarget = -1;
            int left = 0;
            int right = numbers.Length - 1;
            while(left <= right)
            {
                int mid = left + (right - left) / 2;

                if(numbers[mid] == targetValue)
                {
                    indexOfTarget = mid;
                    return true;
                }

                if(numbers[mid] > targetValue)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }

            }
            return false;
        }
    }
}
