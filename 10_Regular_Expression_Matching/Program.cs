using System;

namespace _10_Regular_Expression_Matching
{
    class Program
    {

        static void Main(string[] args)
        {
            // var s = "mississippi";
            // var p = "mis*is*ip*.";

            // var s = "aaa";
            // var p = ".*";


            var s = "ab";
            var p = ".*";
            Console.WriteLine(new Program().IsMatch(s,p));
        }

        public bool IsMatch(string s, string p)
        {
            var c = p[0];
            var lCharIndex = 0;
            var result = new char [s.Length];

            for(int i=0; i<s.Length; i++)
            {
                if(c=='.') {
                    result[i] = s[i];
                    lCharIndex ++;
                    c=p[lCharIndex];
                    continue;
                }
                if(i-1>0 && c == '*')
                {
                    if(result[i-1] == s[i])
                    {
                        result[i] = s[i];
                        lCharIndex ++;
                        c=p[lCharIndex];
                        continue;
                    }
                    else 
                    {
                        return false;
                    }
                }

                if(c == s[i])
                {
                    result[i] = s[i];
                    lCharIndex ++;
                    c=p[lCharIndex];
                    continue;
                }
            return false;
            }
            return true;
        }
    }
}
