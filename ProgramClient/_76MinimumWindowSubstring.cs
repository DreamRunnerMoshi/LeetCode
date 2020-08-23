using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions
{
    public class _76MinimumWindowSubstring
    {
        public string MinWindow(string s, string t)
        {
            int windowSum = t.Length;
            int minLength = int.MaxValue;
            int windowStart = 0;
            int minStart = -1;
            int minEnd = -1;

            var map = new Dictionary<char, int>();

            for (int i = 0; i < t.Length; i++)
            {
                if (!map.ContainsKey(t[i])) map.Add(t[i], 0);
                map[t[i]]++;
            }

            var refMap = new Dictionary<char, int>();

            int uniqueCount = 0;

            for (int windowEnd = 0; windowEnd < s.Length; windowEnd++)
            {

                var endChar = s[windowEnd];
                if (map.ContainsKey(endChar))
                {

                    if (!refMap.ContainsKey(endChar)) refMap.Add(endChar, 0);
                    refMap[endChar]++;

                    if (map[endChar] == refMap[endChar]) uniqueCount++;
                }

                while (uniqueCount == map.Keys.Count)
                {

                    var currentMin = windowEnd - windowStart + 1;
                    if (currentMin < minLength)
                    {
                        minLength = currentMin;
                        minStart = windowStart;
                        minEnd = windowEnd;
                    }

                    char startKey = s[windowStart];

                    if (map.ContainsKey(startKey))
                    {

                        refMap[startKey]--;

                        if (map[startKey] > refMap[startKey]) uniqueCount--;
                    }
                    windowStart++; // slide the window ahead
                }
            }
            if (minStart == -1) return string.Empty;

            return s.Substring(minStart, minEnd - minStart + 1);
        }
    }
}
