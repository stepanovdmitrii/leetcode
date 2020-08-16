using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Design
{
    class ShuffleAnArraySolution
    {
        private int[] _nums;
        private int[] _shuffled;
        private readonly Random _random;

        public ShuffleAnArraySolution(int[] nums)
        {
            _nums = nums;
            _shuffled = new int[_nums.Length];
            Array.Copy(_nums, _shuffled, _nums.Length);
            _random = new Random();
        }

        /** Resets the array to its original configuration and return it. */
        public int[] Reset()
        {
            return _nums;
        }

        /** Returns a random shuffling of the array. */
        public int[] Shuffle()
        {
            for(int i = _shuffled.Length - 1; i > 0; --i)
            {
                int j = _random.Next(0, i + 1);
                int tmp = _shuffled[i];
                _shuffled[i] = _shuffled[j];
                _shuffled[j] = tmp;
            }
            return _shuffled;
        }
    }
}
