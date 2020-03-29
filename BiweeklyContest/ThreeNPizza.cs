using System;
using System.Collections.Generic;
using System.Text;

namespace BiweeklyContest
{
    public class ThreeNPizza
    {
        public int MaxSizeSlices(int[] slices)
        {
            int max = -1;
            for (int i = 0; i < slices.Length; i++)
            {
                var list = new List<int>(slices);
                var value = SumOfMySlices(list,0, 0);
            }

            return max;
        }

        private int SumOfMySlices(List<int> slices, int initIndex, int currentSum)
        {
            if (slices.Count == 0) return 0;
            currentSum += slices[initIndex];
            slices.RemoveAt(initIndex);
            slices.RemoveAt(initIndex);

            if (initIndex == 0) slices.RemoveAt(slices.Count - 1);
            else slices.Remove(initIndex - 1);

            return currentSum + SumOfMySlices(slices, 1, 0);
        }
    }
}
