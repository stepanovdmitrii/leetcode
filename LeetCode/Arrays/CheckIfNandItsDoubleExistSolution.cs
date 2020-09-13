using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Arrays
{
    class CheckIfNandItsDoubleExistSolution
    {
        public bool CheckIfExist(int[] arr)
        {
            for(int index = 0; index < arr.Length; ++index)
            {
                if(arr[index] % 2 == 0 && Find(arr, index, arr[index] / 2))
                {
                    return true;
                }
                if(Find(arr, index, arr[index] * 2))
                {
                    return true;
                }
            }
            return false;
        }

        private bool Find(int[] arr, int exclude, int value)
        {
            for(int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] == value && i != exclude) return true;
            }
            return false;
        }
    }
}
