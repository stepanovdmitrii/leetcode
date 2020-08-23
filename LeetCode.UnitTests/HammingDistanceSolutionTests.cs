using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Other;
using NUnit.Framework;

namespace LeetCode.UnitTests
{
    [TestFixture]
    public class HammingDistanceSolutionTests
    {
        [Test]
        public void Test()
        {
            var solution = new HammingDistanceSolution();
            Assert.AreEqual(1, solution.HammingDistance(1, 3));
        }
    }
}
