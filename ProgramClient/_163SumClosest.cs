using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions
{
    public class _163SumClosest
    {
        public int threeSumClosest(int[] nums, int target)
        {
            var len = nums.Length;
            Array.Sort(nums);
            int closest = int.MaxValue;
            int closestSum = 0;
            for (int i = 0; i < len; i++)
            {
                var first = i;
                var second = i + 1;
                var third = len - 1;

                while (second < third)
                {
                    var sum = nums[first] + nums[second] + nums[third];
                    if (Math.Abs(sum - target) < closest)
                    {
                        closestSum = sum;
                        closest = Math.Abs(sum - target);
                    }

                    if (sum < target)
                    {
                        second++;
                    }
                    else
                    {
                        third--;
                    }
                }
            }
            return closestSum;
        }
    }
}
