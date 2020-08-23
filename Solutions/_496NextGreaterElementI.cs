using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramClient
{
    public class _496NextGreaterElementI
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            var ngElements = new int[nums1.Length];
            var dict = this.GetNGEDictionary(nums2);

            for (int i = 0; i < nums1.Length; i++)
            {
                ngElements[i] = dict[nums1[i]];
            }

            return ngElements;
        }

        private Dictionary<int, int> GetNGEDictionary(int[] nums)
        {
            var stack = new Stack<int>();
            stack.Push(nums[0]);
            var dict = new Dictionary<int, int>();

            for (int i = 1; i < nums.Length; i++)
            {
                var next = nums[i];

                if (stack.Count == 0)
                {
                    stack.Push(next);
                    continue;
                }

                var element = stack.Peek();
                while (element < next)
                {
                    //Console.WriteLine($"{element} --> {next}");
                    dict.Add(element, next);
                    stack.Pop();
                    if (stack.Count == 0) break;
                    element = stack.Peek();
                }

                stack.Push(next);
            }

            while (stack.Count > 0)
            {
                //Console.WriteLine($"{stack.Pop()}--> -1");
                dict.Add(stack.Pop(), -1);
            }

            return dict;
        }
    }
}
