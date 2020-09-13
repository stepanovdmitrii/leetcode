using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Arrays
{
    class ReplaseWithGreatestRight
    {
        public int[] ReplaceElements(int[] arr)
        {
            int tmp = 0;
            int max = arr[arr.Length - 1];
            arr[arr.Length - 1] = -1;
            for(int i = arr.Length - 2; i >= 0; --i)
            {
                tmp = arr[i];
                arr[i] = max;
                max = max > tmp ? max : tmp;
            }
            return arr;
        }
    }
}
