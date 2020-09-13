using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Arrays
{
    class DupilcateZerosSolution
    {
        public void DuplicateZeros(int[] arr)
        {
            int index = 0;
            while (index < arr.Length - 1)
            {
                if(arr[index] != 0)
                {
                    ++index;
                    continue;
                }

                for(int i = arr.Length - 2; i >= index; --i)
                {
                    arr[i + 1] = arr[i];
                }
                index += 2;
            }
        }
    }
}
