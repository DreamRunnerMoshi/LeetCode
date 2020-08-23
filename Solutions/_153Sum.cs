using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions
{
    public class _153Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            if (nums.Length < 3) return new List<IList<int>>(); // if nums less than 3 element

            var len = nums.Length;
            Array.Sort(nums);
            var map = new Dictionary<int, List<int>>();

            for (int k = 0; k < len; k++)
            {
                if (!map.ContainsKey(nums[k]))
                {
                    map.Add(nums[k], new List<int>());
                }
                map[nums[k]].Add(k);
            }

            var set = new HashSet<Triple>();

            for (int i = 0; i < len - 2; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    var sum = nums[i] + nums[j];
                    var remain = 0 - sum;
                    if (map.ContainsKey(remain))
                    {
                        var isValid = false;
                        var indexArray = map[remain];
                        var lastElement = indexArray[indexArray.Count() - 1];
                        if (lastElement > j) isValid = true;
                        if (!isValid) continue;

                        var key = new Triple(nums[i], nums[j], remain);
                        set.Add(key);
                    }
                }
            }

            var allSet = new List<IList<int>>();
            foreach (var key in set)
            {
                allSet.Add(new List<int>() { key.x, key.y, key.z });
            }

            return allSet;
        }
    }
    public class Triple
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public Triple(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override bool Equals(object obj)
        {
            return obj is Triple triple &&
                   (x == triple.x || x == triple.y || x == triple.z) &&
                   (y == triple.x || y == triple.y || y == triple.z) &&
                   (z == triple.x || z == triple.y || z == triple.z);
        }

        public override int GetHashCode()
        {
            return x.GetHashCode() ^ y.GetHashCode() ^ z.GetHashCode();
        }
    }
}
