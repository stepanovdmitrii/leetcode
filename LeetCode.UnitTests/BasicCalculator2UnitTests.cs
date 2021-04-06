using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Design;
using NUnit.Framework;

namespace LeetCode.UnitTests
{
    [TestFixture]
    public class BasicCalculator2UnitTests
    {
        [Test]
        public void Test1()
        {
            var solution = new BasicCalculator2();
            Assert.AreEqual(7, solution.Calculate("3+2*2"));
        }
    }
}
