using System;

namespace LeetCode.Solutions
{
    /// <summary>
    /// Input: customers = [1,0,1,2,1,1,7,5], grumpy = [0,1,0,1,0,1,0,1], X = 3
    // Output: 16
    // Explanation: The bookstore owner keeps themselves not grumpy for the last 3 minutes.
    // The maximum number of customers that can be satisfied = 1 + 1 + 1 + 1 + 7 + 5 = 16.
    /// </summary>
    public class _1052GrumpyBookstoreOwner
    {

        public int GetMax(int[] customers, int[] grumpy, int x)
        {
            int windowStart = 0;
            int windowEnd = 0;
            int maxSum = 0;
            int currentSum = 0;
            while (windowEnd < customers.Length)
            {
                var startCustomer = customers[windowEnd];
                currentSum += startCustomer;

                if (windowEnd > x)
                {
                    currentSum -= customers[windowStart] * grumpy[windowStart];
                    windowStart++;
                }
                maxSum = Math.Max(currentSum, maxSum);

                windowEnd++;
            }

            return maxSum;
        }

        public int MaxCountAlternative(int[] customers, int[] grumpy, int X)
        {
            int satisfied = 0, maxMakeSatisfied = 0;
            for (int i = 0, winOfMakeSatisfied = 0; i < grumpy.Length; ++i)
            {
                if (grumpy[i] == 0) satisfied += customers[i];
                else winOfMakeSatisfied += customers[i];

                if (i >= X)
                {
                    winOfMakeSatisfied -= grumpy[i - X] * customers[i - X];
                }

                maxMakeSatisfied = Math.Max(winOfMakeSatisfied, maxMakeSatisfied);
            }
            return satisfied + maxMakeSatisfied;
        }
    }
}
