using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Strings
{
    public sealed class NextGreaterElement3Solution
    {
        private static readonly Dictionary<char, int> CharToInt = new Dictionary<char, int>
        {
            {'0', 0 },
            {'1', 1 },
            {'2', 2 },
            {'3', 3 },
            {'4', 4 },
            {'5', 5 },
            {'6', 6 },
            {'7', 7 },
            {'8', 8 },
            {'9', 9 },
        };

        public int NextGreaterElement(int n)
        {
            int[] values = n.ToString().ToCharArray().Select(ch => CharToInt[ch]).ToArray();
            while (NextSet(values))
            {
                if(TryParse(values, out int value) && value > n)
                {
                    return value;
                }
            }
            return -1;
        }

        private static bool NextSet(int[] indicies)
        {
            int j = indicies.Length - 2;
            while(j!= -1 && indicies[j] >= indicies[j + 1])
            {
                j--;
            }
            if (j == -1) return false;

            int k = indicies.Length - 1;
            while(indicies[j] >= indicies[k])
            {
                --k;
            }
            Swap(indicies, j, k);
            int left = j + 1;
            int right = indicies.Length - 1;
            while (left < right)
                Swap(indicies, left++, right--);
            return true;
        }

        private static void Swap<T>(T[] arr, int idx1, int idx2)
        {
            T tmp = arr[idx1];
            arr[idx1] = arr[idx2];
            arr[idx2] = tmp;
        }

        private static bool TryParse(int[] values, out int value)
        {
            int mult = 1;
            value = 0;
            for(int i = values.Length - 1; i >= 0; --i)
            {
                int current = values[i];
                if (current > int.MaxValue / mult)
                {
                    value = -1;
                    return false;
                }
                current *= mult;
                
                if(current > int.MaxValue - value)
                {
                    value = -1;
                    return false;
                }
                value += current;

                mult *= 10;
            }

            return true;
        }
    }
}
