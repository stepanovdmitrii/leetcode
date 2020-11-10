using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.BinarySearch
{
    class FindClosestElementsSolution
    {
        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            if (k <= 0) return new List<int>();
            k = k > arr.Length ? arr.Length : k;
            int lowerBound = LowerBound(arr, x);
            if (lowerBound == -1)
            {
                return arr.TakeLast(k).ToList();
            }
            else if (lowerBound == 0)
            {
                return arr.Take(k).ToList();
            }
            else
            {
                var result = new LinkedList<int>();
                int left = lowerBound - 1;
                int right = lowerBound;
                while(k > 0)
                {
                    if(left < 0)
                    {
                        result.AddLast(arr[right]);
                        ++right;
                    }
                    else if (right == arr.Length)
                    {
                        result.AddFirst(arr[left]);
                        --left;
                    }
                    else
                    {
                        int leftDiff = x - arr[left];
                        int rightDiff = arr[right] - x;
                        if(rightDiff < leftDiff)
                        {
                            result.AddLast(arr[right]);
                            ++right;
                        }
                        else
                        {
                            result.AddFirst(arr[left]);
                            --left;
                        }
                    }
                    --k;
                }
                return result.ToList();
            }
        }
        int LowerBound(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            while(left <= right)
            {
                int mid = left + (right - left) / 2;
                if(arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return left < arr.Length ? left : -1;
        }
    }
}
