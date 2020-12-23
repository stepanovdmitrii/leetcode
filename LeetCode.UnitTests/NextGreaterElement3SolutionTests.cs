using LeetCode.Strings;
using NUnit.Framework;

namespace LeetCode.UnitTests
{
    [TestFixture]
    public class NextGreaterElement3SolutionTests
    {
        [Test]
        public void TestCase26()
        {
            var solution = new NextGreaterElement3Solution();
            Assert.That(solution.NextGreaterElement(230241), Is.EqualTo(230412));
        }

    }
}
