using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Arrays;
using NUnit.Framework;

namespace LeetCode.UnitTests
{
    [TestFixture]
    class RotateImageTests
    {
        [Test]
        public void Test()
        {
            int[][] matrix = new int[][]
            {
                new[] {1,2,3 },
                new[] {4,5,6 },
                new[] {7,8,9 }
            };
            var solution = new RotateImageSolution();
            solution.Rotate(matrix);
            int[][] expected = new int[][]
            {
                new[] {7,4,1 },
                new[] {8,5,2 },
                new[] {9,6,3 }
            };
            for(int row = 0; row < matrix.Length; ++row)
            {
                for(int col = 0; col < matrix.Length; ++col)
                {
                    Assert.AreEqual(expected[row][col], matrix[row][col]);
                }
            }

        }
    }
}
