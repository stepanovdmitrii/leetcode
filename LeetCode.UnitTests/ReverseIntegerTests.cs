using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Strings;
using NUnit.Framework;

namespace LeetCode.UnitTests
{
    [TestFixture]
    public class ReverseIntegerTests
    {
        [Test]
        public void TestMinMax()
        {
            var solution = new ReverseIntegerSolution();
            Assert.AreEqual(0, solution.Reverse(int.MaxValue));
            Assert.AreEqual(0, solution.Reverse(int.MinValue));
        }

        [Test]
        public void TestSpecial()
        {
            var solution = new ReverseIntegerSolution();
            Assert.AreEqual(0, solution.Reverse(-1563847412));
            Assert.AreEqual(0, solution.Reverse(1534236469));
        }
    }
}
