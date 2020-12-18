using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SortingAndSearching
{
    class SortArraySolution
    {
        public int[] SortArray(int[] nums)
        {
            if(nums == null || nums.Length <= 1)
            {
                return nums;
            }
            int[] result = new int[nums.Length];
            int index = 0;
            foreach (int v in Sort(nums.AsSpan<int>()))
            {
                result[index++] = v;
            }
            return result;
        }

        private IEnumerable<int> Sort(Span<int> batch)
        {
            if (batch.Length == 0) return Enumerable.Empty<int>();
            if (batch.Length == 1) return new[] { batch[0] };
            int pivot = batch.Length / 2;
            IEnumerable<int> left = Sort(batch.Slice(0, pivot));
            IEnumerable<int> right = Sort(batch.Slice(pivot));
            return MergeSort(left, right);
        }

        private static IEnumerable<int> MergeSort(IEnumerable<int> left, IEnumerable<int> right)
        {
            using (var leftEnumerator = left.GetEnumerator())
            using (var rightEnumerator = right.GetEnumerator())
            {
                bool leftHasNext = leftEnumerator.MoveNext();
                bool rightHasNext = rightEnumerator.MoveNext();
                while (leftHasNext && rightHasNext)
                {
                    if (leftEnumerator.Current < rightEnumerator.Current)
                    {
                        yield return leftEnumerator.Current;
                        leftHasNext = leftEnumerator.MoveNext();
                    }
                    else
                    {
                        yield return rightEnumerator.Current;
                        rightHasNext = rightEnumerator.MoveNext();
                    }
                }

                while (leftHasNext)
                {
                    yield return leftEnumerator.Current;
                    leftHasNext = leftEnumerator.MoveNext();
                }

                while (rightHasNext)
                {
                    yield return rightEnumerator.Current;
                    rightHasNext = rightEnumerator.MoveNext();
                }
            }
        }
    }
}
