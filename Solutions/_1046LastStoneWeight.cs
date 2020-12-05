using LeetCode.Algorithms;

namespace LeetCode.Solutions
{
    public class _1046LastStoneWeight
    {
        public int LastStoneWeight(int[] stones)
        {
            var priorityQueue = new PriorityQueue(1000, stones);
            var count = stones.Length;
            while (count > 1)
            {
                var item1 = priorityQueue.Pop();
                var item2 = priorityQueue.Pop();
                var toInsert = item1 - item2;
                priorityQueue.Insert(toInsert);
                count--;
            }
            return priorityQueue.Pop();
        }
    }
}
