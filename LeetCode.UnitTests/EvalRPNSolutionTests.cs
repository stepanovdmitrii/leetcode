using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Stack;
using NUnit.Framework;

namespace LeetCode.UnitTests
{
    [TestFixture]
    public class EvalRPNSolutionTests
    {
        [Test]
        public void Test_Example1()
        {
            var solution = new EvalRPNSolution();

            Assert.AreEqual(9, solution.EvalRPN(new[] { "2", "1", "+", "3", "*" }));
        }

        [Test]
        public void Test_Example2()
        {
            var solution = new EvalRPNSolution();

            Assert.AreEqual(6, solution.EvalRPN(new[] { "4", "13", "5", "/", "+" }));
        }

        [Test]
        public void Test_Example3()
        {
            var solution = new EvalRPNSolution();

            Assert.AreEqual(22, solution.EvalRPN(new[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" }));
        }
    }
}
