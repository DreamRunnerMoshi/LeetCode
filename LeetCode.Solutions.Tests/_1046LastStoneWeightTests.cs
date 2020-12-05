using LeetCode.Solutions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests
{

    public class _1046LastStoneWeightTests
    {
        _1046LastStoneWeight _1046LastStoneWeight;

        public _1046LastStoneWeightTests()
        {
            _1046LastStoneWeight = new _1046LastStoneWeight();
        }

        [Fact]
        public void Test1()
        {
            var items = new int[] { 2, 7, 4, 1, 8, 1 };
            var lastStoneStands = _1046LastStoneWeight.LastStoneWeight(items);
            Assert.Equal(1, lastStoneStands);

            items = new int[] {3, 7, 2};
            lastStoneStands = _1046LastStoneWeight.LastStoneWeight(items);
            Assert.Equal(2, lastStoneStands);

            items = new int[] {9, 3, 2, 10 };
            lastStoneStands = _1046LastStoneWeight.LastStoneWeight(items);
            Assert.Equal(0, lastStoneStands);
        }
    }
}
