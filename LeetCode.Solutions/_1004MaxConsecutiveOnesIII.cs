using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions
{
    public class _1004MaxConsecutiveOnesIII
    {
        public int GetMax(string A, int k)
        {
            int max = -1;

            int wStart = 0;
            int wEnd = 0;

            while (wEnd < A.Length)
            {
                while (wEnd < A.Length && k > 0)
                {
                    if (A[wEnd] == 0) k--;
                    wEnd++;
                }

                while (wEnd < A.Length && A[wEnd] == 1) wEnd++;

                max = max < (wEnd - wStart) ? (wEnd - wStart) : max;

                if (wEnd < A.Length && A[wStart] == 0) k++;

                //while (wStart < A.Length && A[wStart] == 1) wStart++;
                wStart++;
            }
            return max;
        }
    }
}
