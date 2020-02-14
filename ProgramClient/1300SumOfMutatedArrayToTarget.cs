using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramClient
{
    public class _1300SumOfMutatedArrayToTarget
    {

        public int FindBestValue(int[] arr, int target)
        {

            Array.Sort(arr);

            var count = arr.Length;


            /* when target is less than the (smallestValue *count) */
            int currentSum = arr[0] + (count - 1) * arr[0];
            if (currentSum > target)
            {
                return FindTargetWhenSmaller(target, count);
            }

            int left = 0, right = 0;
            int rightCount = count - 1;
            int leftSum = 0;
            
            //finding two numbers to find target in between

            for (int i = 0; i < count; i++)
            {
                leftSum += i > 0 ? arr[i - 1] : 0;
                rightCount = (count - i);

                int rightSum = rightCount * arr[i];
                if (leftSum + rightSum == target) return arr[i];

                if (leftSum + rightSum > target)
                {
                    left = i > 0 ? arr[i - 1] : 0;
                    right = arr[i];
                    break;
                }
            }

            return findTarget(leftSum, left, right, rightCount, target);
        }

        private int findTarget(int leftSum, int left, int right, int rightCount, int target)
        {
            int prevDiff = 1000000, result = 0;

            while (right > left)
            {
                int middle = left + (right - left) / 2;
                int rightSum = rightCount * middle;
                int total = leftSum + rightSum;

                var diff = total - target;

                if (diff == 0) return middle;

                if (diff > 0)
                    right = middle;
                else
                    left = middle + 1;

                var absDiff = Math.Abs(diff);

                if (prevDiff >= absDiff)
                {
                    result = middle;
                    prevDiff = absDiff;
                }
            }

            return result;
        }

        private int FindTargetWhenSmaller(int target, int count)
        {
            int value = (int)(target / count);
            int leftValue = Math.Abs((value * count) - target);
            int rightValue = Math.Abs(((value + 1) * count) - target);
            return leftValue > rightValue ? value + 1 : value;
        }
    }
}
