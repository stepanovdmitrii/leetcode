using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Other
{
    class PascalTriangleSolution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var result = new List<IList<int>>();
            for(int row = 0; row < numRows; ++row)
            {
                Console.WriteLine(row);
                var current = new int[row + 1];
                current[0] = 1;
                current[current.Length - 1] = 1;
                for(int i = 1; i < current.Length - 1; ++i)
                {
                    current[i] = result[row - 1][i - 1] + result[row - 1][i];
                }

                result.Add(current.ToList());
            }


            return result;
        }
    }
}
