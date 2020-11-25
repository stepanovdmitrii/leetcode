using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.BinarySearch
{
    public class SmallestDistancePairSolution
    {
        public int SmallestDistancePair(int[] nums, int k)
        {
            Array.Sort<int>(nums);
            int low = 0;
            int high = nums[nums.Length - 1] - nums[0];
            while(low < high)
            {
                int mid = low + (high - low) / 2;
                int count = Count(nums, mid);

                if(count < k)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }

            return low;
        }

        private static int Count(int[] nums, int diff)
        {
            int result = 0;
            int left = 0;
            for(int right = 0; right < nums.Length; ++right)
            {
                while(nums[right] - nums[left] > diff)
                {
                    ++left;
                }
                result += right - left;
            }
            return result;
        }


        public int SmallestDistancePair_TimeLimit(int[] nums, int k)
        {
            Array.Sort<int>(nums);
            return Enumerable.Range(0, nums.Length)
                .Select(idx => GetDiffsOrderedByAsc(nums, idx))
                .Aggregate(MergeSorted)
                .Skip(k - 1)
                .First();
        }

        private static IEnumerable<int> GetDiffsOrderedByAsc(int[] nums, int index)
        {
            for (int next = index + 1; next < nums.Length; ++next)
            {
                yield return nums[next] - nums[index];
            }
        }

        private static IEnumerable<int> MergeSorted(IEnumerable<int> left, IEnumerable<int> right)
        {
            using(var leftEnumerator = left.GetEnumerator())
            using(var rightEnumerator = right.GetEnumerator())
            {
                bool hasLeft = leftEnumerator.MoveNext();
                bool hasRight = rightEnumerator.MoveNext();
                while(hasLeft || hasRight)
                {
                    if(hasLeft && hasRight)
                    {
                        if(leftEnumerator.Current < rightEnumerator.Current)
                        {
                            yield return leftEnumerator.Current;
                            hasLeft = leftEnumerator.MoveNext();
                        }
                        else
                        {
                            yield return rightEnumerator.Current;
                            hasRight = rightEnumerator.MoveNext();
                        }
                    }
                    else if (hasLeft)
                    {
                        yield return leftEnumerator.Current;
                        hasLeft = leftEnumerator.MoveNext();
                    }
                    else if (hasRight)
                    {
                        yield return rightEnumerator.Current;
                        hasRight = rightEnumerator.MoveNext();
                    }
                }
            }
        }
    }
}
