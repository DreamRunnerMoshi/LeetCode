using System.Collections.Generic;
using System.Linq;

namespace ProgramClient
{

    public class Element
    {
        public int Index { get; set; }
        public int Value { get; set; }

        public Element(int Index, int Value)
        {
            this.Index = Index;
            this.Value = Value;
        }
    }
    public class _503NextGreaterElementII
    {
        public int[] NextGreaterElements(int[] nums)
        {
            var ngElements = new int[nums.Length];
            return this.GetNGEDictionary(nums);
        }
        private new int[] GetNGEDictionary(int[] nums)
        {
            var stack = new Stack<Element>();
            stack.Push(new Element(0, nums[0]));
            var n2 = new List<int>();
            n2.AddRange(nums.ToList());
            n2.AddRange(nums.ToList());

            var ans = new int[nums.Length];
            var hashSet = new HashSet<int>();
            for (int i = 1; i < n2.Count; i++)
            {
                var next = n2[i];

                if (stack.Count == 0)
                {
                    stack.Push(new Element(i, next));
                    continue;
                }

                var element = stack.Peek();
                while (element.Value < next)
                {
                    int index = element.Index % nums.Length;
                    if (!hashSet.Contains(index))
                    {
                        ans[index] = next;
                        hashSet.Add(index);
                    }
                    stack.Pop();
                    if (stack.Count == 0) break;
                    element = stack.Peek();
                }

                stack.Push(new Element(i, next));
            }

            while (stack.Count > 0)
            {
                var element = stack.Pop();
                int index = element.Index % nums.Length;
                if (!hashSet.Contains(index))
                {
                    ans[index] = -1;
                    hashSet.Add(index);
                }
            }

            return ans;
        }
    }
}
