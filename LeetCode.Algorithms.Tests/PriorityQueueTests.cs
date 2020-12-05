using System;
using Xunit;

namespace LeetCode.Algorithms.Tests
{
    public class PriorityQueueTests
    {
        private PriorityQueue priorityQueue;
        public PriorityQueueTests()
        {
            priorityQueue = new PriorityQueue(7, new int[] { 2, 7, 4, 1, 8 });
        }

        [Fact]
        public void Test1()
        {
            Assert.Equal(8, priorityQueue.GetMax());
            priorityQueue.Insert(10);
            Assert.Equal(10, priorityQueue.GetMax());
        }
    }
}
