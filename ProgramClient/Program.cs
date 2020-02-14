using Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgramClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // var lnrs = new LongestSubstringWithoutRepeating();
            // Console.WriteLine(lnrs.LengthOfLongestSubstring("pwwkew"));
            // Console.WriteLine(lnrs.LengthOfLongestSubstring("au"));
            // Console.WriteLine(lnrs.LengthOfLongestSubstring(""));

            // var mtsa = new MedianOfTwoSortedArrays();
            // var a = new[] { 0, 0 };
            // var b = new[] { 0, 0 };

            // Console.WriteLine(mtsa.FindMedianSortedArrays(a, b));

            //var nge = new _496NextGreaterElement_I();
            //nge.NextGreaterElement(new[] { 4, 1, 2 }, new[] { 1, 3, 4, 2 });
            //nge.NextGreaterElement(new[] { 137, 59, 92, 122, 52, 131, 79, 236 }, new[] { 137, 59, 92, 122, 52, 131, 79, 236 });
            // var nge2 = new _503_Next_Greater_Element_II();
            // nge2.NextGreaterElements(new int[] { 100, 1, 11, 1, 120, 111, 123, 1, -1, -100 })
            //     .ToList()
            //     .ForEach(Console.WriteLine);

            // var cache = new LRUCache(2);

            // cache.put(1, 1);
            // cache.put(2, 2);
            // cache.get(1);       // returns 1
            // cache.put(3, 3);    // evicts key 2
            // cache.get(2);       // returns -1 (not found)
            // cache.put(4, 4);    // evicts key 1
            // cache.get(1);       // returns -1 (not found)
            // cache.get(3);       // returns 3
            // cache.get(4);       // returns 4

            //var openWith = new SortedDictionary<string, string>();

            // Add some elements to the dictionary. There are no 
            // duplicate keys, but some of the values are duplicates.
            // openWith.Add("txt", "notepad.exe");
            // openWith.Add("bmp", "paint.exe");
            // openWith.Add("bmp11", "paint.exe");
            // openWith.Add("bmp02", "paint.exe");
            // openWith.Add("dib", "paint.exe");
            // openWith.Add("rtf", "wordpad.exe");

            // var list = new List<string>() { "c", "aa", "1a", "a", "d", "ab", "ab02", "ab11" };
            // list.Sort();
            // openWith.Keys.ToList().ForEach(Console.WriteLine);

            //var allSubsets = new SubsetsOfSet(3);
            //allSubsets.GetSubsets(new List<int>() { 1, 2, 3 });

            //var multiDictionary = new Multidictionary<string, string>();

            //var input = new List<string>() { "cat", "act", "door", "odor", "hello", "ohell", "me" };


            //var groups = input.Partition(s => string.Concat(s.OrderBy(c => c)));

            //var anagramsTable = new Multidictionary<string, string>();
            //foreach (string str in input)
            //{
            //    anagramsTable.Add(string.Concat(str.OrderBy(c => c)), str);
            //}

            //anagramsTable.Values
            //  .Select(vs => vs.ToList())
            //  .ToList()
            //  .ForEach(_ =>
            //  {
            //      Console.Write("[");
            //      _.ForEach(w =>
            //      {
            //          Console.Write(w + " ");
            //      });
            //      Console.Write("]");
            //      Console.WriteLine();
            //  });


            var sln = new _1300SumOfMutatedArrayToTarget();
            //Console.WriteLine(sln.FindBestValue(new int[] { 48772, 52931, 14253, 32289, 75263 }, 40876) == 8175);
            Console.WriteLine(sln.FindBestValue(new int[] { 1547, 83230, 57084, 93444, 70879 }, 71237) == 17422);
            Console.WriteLine(sln.FindBestValue(new int[] { 2, 3, 5 }, 10) == 5);
            Console.WriteLine(sln.FindBestValue(new int[] { 3, 6, 8, 10, 20 }, 35) == 9);
            Console.WriteLine(sln.FindBestValue(new int[] { 4, 6, 8, 10, 20, 35, 40 }, 92) == 22);
            Console.WriteLine(sln.FindBestValue(new int[] { 4, 9, 3 }, 10) == 3);
        }
    }
}
