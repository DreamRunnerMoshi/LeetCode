using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions
{
    public class _38CountAndSay
    {
        public string CountAndSay(int n)
        {
            if (n == 1) return "1";

            string ans = "1";

            for (int i = 1; i < n; i++)
            {
                int windowStart = 0;
                string innerCounting = "";
                string windowString = "";
                int lastIndex = ans.Length - 1;

                for (int windowEnd = 0; windowEnd < lastIndex; windowEnd++)
                {
                    windowString += ans[windowEnd];

                    if (windowEnd == lastIndex || ans[windowEnd + 1] != ans[windowStart])
                    {
                        innerCounting += windowString.Length + "" + ans[windowStart];
                        windowStart = windowEnd + 1;
                        windowString = "";
                    }
                }

                windowString += ans[lastIndex];
                innerCounting += windowString.Length + "" + ans[lastIndex];
                ans = innerCounting;
            }
            return ans;
        }
    }
}
