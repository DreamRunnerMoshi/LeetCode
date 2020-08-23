using System.Collections.Generic;

namespace LeetCode.Solutions
{
    public class _3LongestSubstringWithoutRepeating
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 1) return 1;

            var hashSet = new HashSet<char>();
            var seqCount = new List<int>();
            int currentCount = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i];
                if (hashSet.Contains(c))
                {
                    seqCount.Add(currentCount);
                    currentCount = 0;
                    hashSet = new HashSet<char>();
                    hashSet.Add(c);
                }
                currentCount++;
                hashSet.Add(c);
            }
            seqCount.Add(currentCount);

            int max = 0;

            foreach (var item in seqCount)
            {
                if (item > max) max = item;
            }

            return max;
        }
    }
}
