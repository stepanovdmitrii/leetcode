using LeetCode.Strings;
using NUnit.Framework;

namespace LeetCode.UnitTests
{
    [TestFixture]
    public sealed class DecodeAtIndexTests
    {
        [Test]
        public void Test_Case3()
        {
            var solution = new DecodeAtIndexSolution();
            Assert.AreEqual("o", solution.DecodeAtIndex("leet2code3", 10));
        }

        [Test]
        public void Test_Case33()
        {
            var solution = new DecodeAtIndexSolution();
            Assert.AreEqual("y", solution.DecodeAtIndex("y959q969u3hb22odq595", 222280369));
        }

        [Test]
        public void Test_Case2()
        {
            var solution = new DecodeAtIndexSolution();
            Assert.AreEqual("a", solution.DecodeAtIndex("a2345678999999999999999", 1));
        }

        [Test]
        public void Test_Case11()
        {
            var solution = new DecodeAtIndexSolution();
            Assert.AreEqual("a", solution.DecodeAtIndex("a23", 6));
        }
    }
}
