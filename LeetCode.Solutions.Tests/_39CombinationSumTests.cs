using LeetCode.Solutions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests
{
    public class _39CombinationSumTests
    {
        _39CombinationSum _39CombinationSum;

        public _39CombinationSumTests()
        {
            _39CombinationSum = new _39CombinationSum();
        }
        [Fact]
        public void Test()
        {
            var actual = _39CombinationSum.CombinationSum(new int[] { 2, 4, 6, 8 }, 8);
            actual = _39CombinationSum.CombinationSum(new int[] { 2, 3, 6, 7 }, 7);
            actual = _39CombinationSum.CombinationSum(new int[] { 2 }, 1);
            actual = _39CombinationSum.CombinationSum(new int[] { 1 }, 1);
            actual = _39CombinationSum.CombinationSum(new int[] { 1 }, 2);
        }
    }
}
