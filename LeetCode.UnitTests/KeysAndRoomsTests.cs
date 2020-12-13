using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Queue;
using NUnit.Framework;

namespace LeetCode.UnitTests
{
    [TestFixture]
    public sealed class KeysAndRoomsTests
    {
        [Test]
        public void Test_Case23()
        {
            var solution = new KeysAndRoomsSolution();
            var input = new List<IList<int>> {
                new List<int> { 1 },
            new List<int> { 2 },
            new List<int> { 3 },
            new List<int>()
            };
            Assert.IsTrue(solution.CanVisitAllRooms(input));
        }

        [Test]
        public void Test_Case34()
        {
            var solution = new KeysAndRoomsSolution();
            var input = new List<IList<int>> {
                new List<int> { 2,3 },
            new List<int> {  },
            new List<int> { 2 },
            new List<int>{1,3,1}
            };
            Assert.IsTrue(solution.CanVisitAllRooms(input));
        }
    }
}
