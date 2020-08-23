using LeetCode.Solutions;
using System;
using Xunit;

namespace LeetCode.Tests
{
    public class _1052GrumpyBookstoreOwnerTests
    {
        private _1052GrumpyBookstoreOwner grumpyBookstoreOwner;

        public _1052GrumpyBookstoreOwnerTests()
        {
            grumpyBookstoreOwner = new _1052GrumpyBookstoreOwner();
        }
        [Fact]
        public void Test1()
        {
            var cutomers = new int[] { 1, 0, 1, 2, 1, 1, 7, 5 };
            var grumpy = new int[] { 0, 1, 0, 1, 0, 1, 0, 1 };
            int x = 3;
            var actual = grumpyBookstoreOwner.GetMax(cutomers, grumpy, x);
            var expected = 16;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WhenConsecutiveGrumpy()
        {

            var cutomers = new int[] { 4, 10, 10, 11, 12 };
            var grumpy = new int[] { 1, 1, 0, 0, 1 };
            int x = 2;
            var actual = grumpyBookstoreOwner.GetMax(cutomers, grumpy, x);
            var expected = 35;

            Assert.Equal(expected, actual);
        }
    }
}
