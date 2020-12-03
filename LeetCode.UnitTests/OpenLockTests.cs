using LeetCode.Queue;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace LeetCode.UnitTests
{
    [TestFixture]
    public class OpenLockTests
    {
        [Test]
        public void Test_TimeLimit()
        {
            var solution = new OpenLockSolution();
            var deadends = new string[] { "8887", "8889", "8878", "8898", "8788", "8988", "7888", "9888" };
            string target = "8888";
            Assert.That(solution.OpenLock(deadends, target), new EqualConstraint(-1));
        }

        [Test]
        public void Test_Case6()
        {
            var solution = new OpenLockSolution();
            var deadends = new string[] { "0201", "0101", "0102", "1212", "2002" };
            string target = "0202";
            Assert.That(solution.OpenLock(deadends, target), new EqualConstraint(6));
        }
    }
}
