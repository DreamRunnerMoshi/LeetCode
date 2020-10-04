using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions
{
    public class LargestTimeForGivenDigits
    {
        List<string> list = new List<string>();
        public string LargestTimeFromDigits(int[] A)
        {
            var input = string.Join(string.Empty, A);
            int max = -1;
            permute(input, 0, 3);
            string ans = string.Empty;
            list.ForEach(x =>
            {
                var hourPart = ((x[0] - 48) * 10 + x[1] - 48);
                var minutePart = (((x[2]) - 48) * 10) + (x[3] - 48);

                if (!(hourPart > 23 || minutePart > 59))
                {
                    var totalMinute = hourPart * 60 + minutePart;
                    if (totalMinute > max)
                    {
                        max = totalMinute;
                        ans = x;
                    }
                }
            });

            return ans == string.Empty? string.Empty : ans.Substring(0, 2) + ":" + ans.Substring(2, 2);
        }

        private void permute(String str,
                                int l, int r)
        {
            if (l == r)
                list.Add(str);
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    permute(str, l + 1, r);
                    str = swap(str, l, i);
                }
            }
        }


        private String swap(String a,
                             int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
