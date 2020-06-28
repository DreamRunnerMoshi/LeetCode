using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.ProgramClient
{
    public class SlidingWindowTemplate
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            var result = new List<int>();

            int pLength = p.Length;
            var sLength = s.Length;

            if (sLength == 0 || pLength > sLength) return result;

            int startIndex = 0;
            int endIndex = pLength - 1;

            var pDictionary = GetDictionary(p);

            var windowString = s.Substring(startIndex, pLength);

            var matchChars = CheckAnagram(windowString, pDictionary);

            while (true)
            {
                if (matchChars == pLength)
                {
                    result.Add(startIndex);
                    startIndex++;
                    endIndex++;
                    matchChars--;
                }

                var endKey = s[endIndex];
                if (pDictionary.ContainsKey(endKey))
                {
                    matchChars++;
                }
                else
                {
                    matchChars = 0;
                    startIndex = endIndex + 1;
                    endIndex = startIndex;
                }
            }
        }

        private int CheckAnagram(string windowString, Dictionary<char, int> pDictionary)
        {
            int matchChars = 0;
            foreach (var key in windowString)
            {
                if (pDictionary.ContainsKey(key)) matchChars++;
            }

            return matchChars;
        }

        private Dictionary<char, int> GetDictionary(string p)
        {
            var dictionary = new Dictionary<char, int>();

            for (int i = 0; i < p.Length; i++)
            {
                if (!dictionary.ContainsKey(p[i]))
                {
                    dictionary.Add(p[i], 0);
                }

                dictionary[p[i]]++;
            }

            return dictionary;
        }
    }
}
