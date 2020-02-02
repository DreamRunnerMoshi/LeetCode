using System;

namespace _1004._Max_Consecutive_Ones
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] A = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 };
            int k = 3;

            int[] A = new int[] { 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 };
            //int[] A = new int[] {0,0,1,1,1,0,0};

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

            Console.WriteLine(max);
        }
    }
}
