using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions
{
    public class _39CombinationSum
    {

        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            List<IList<int>> ans = new List<IList<int>>();

            FindCombination(candidates, target, new List<int>(), 0, ans);

            return ans;
        }

        private void FindCombination(int[] candidates, int target, List<int> result, int currentIndex, List<IList<int>> ans)
        {
            Array.Sort(candidates);
            if (target < 0) return;

            if (target == 0)
            {
                var r = new List<int>(result);
                ans.Add(r);
                return;
            }

            while (currentIndex < candidates.Length && target - candidates[currentIndex] >= 0)
            {
                result.Add(candidates[currentIndex]);
                FindCombination(candidates, target - candidates[currentIndex], result, currentIndex, ans);
                currentIndex++;
                result.RemoveAt(result.Count - 1);
            }
        }
    }
}
