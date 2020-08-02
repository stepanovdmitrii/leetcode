using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Strings;
using NUnit.Framework;

namespace LeetCode.UnitTests
{
    [TestFixture]
    class StringToIntegerTests
    {
        [Test]
        public void Test()
        {
            var solution = new StringToIntegerSolution();
            //Assert.AreEqual(42, solution.MyAtoi("42"));
            Assert.AreEqual(2147483647, solution.MyAtoi("2147483648"));
        }
    }
}
