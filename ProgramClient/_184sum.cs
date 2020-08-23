using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions
{
    public class _184sum
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            var len = nums.Length;
            Array.Sort(nums);

            var set = new HashSet<Quadruplet>();

            for (int i = 0; i < len - 3; i++)
            {
                int a = nums[i];

                for (int j = i + 1; j < len - 2; j++)
                {
                    int b = nums[j];

                    var k = j + 1;
                    var l = len - 1;

                    while (k < l)
                    {
                        var c = nums[k];
                        var d = nums[l];

                        var sum = a + b + c + d;

                        if (sum == target)
                        {
                            set.Add(new Quadruplet(a, b, c, d));
                            k++; l--;
                        }

                        if (sum < target) k++;
                        if (sum > target) l--;
                    }
                }
            }
            var ansSet = set.Select(s => (IList<int>)new List<int>() { s.a, s.b, s.c, s.d }).ToList();
            return ansSet;
        }
    }
    public class Quadruplet
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public int d { get; set; }

        public Quadruplet(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public override bool Equals(object obj)
        {
            var other = (Quadruplet)obj;

            var thisList = new[] { a, b, c, d };
            var otherList = new[] { other.a, other.b, other.c, other.d };

            return !thisList.Except(otherList).Any() && !otherList.Except(thisList).Any();
        }

        public override int GetHashCode()
        {
            return a.GetHashCode() ^ b.GetHashCode() ^ c.GetHashCode() ^ d.GetHashCode();
        }
    }
}
