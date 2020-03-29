using Algorithms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ProgramClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new _1377FrogPositionAfterTSeconds();

            var graph = new int[][]{
                new []{1, 2 },new []{1, 3 },new []{1, 7 },new []{2, 4 },new []{2, 6 },new []{3, 5 }
            };
            Console.WriteLine(c.FrogPosition(7, graph, 2, 4));

            // var lnrs = nsew LongestSubstringWithoutRepeating();
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

            var words = new List<string>() { "litu", "flit", "lift", "lute", "tule", "etui", "lieu", "lite", "tile", "flue", "fuel", "felt", "left", "file", "lief", "life", "flub", "bute", "tube", "blue", "lube", "belt", "blet", "bite", "bile", "luau", "latu", "alit", "lati", "tail", "tali", "tufa", "flat", "fiat", "alif", "fail", "fila", "late", "tael", "tale", "teal", "tela", "ilea", "fate", "feat", "feta", "alef", "feal", "flea", "leaf", "abut", "tabu", "tuba", "blat", "bait", "bail", "flab", "beau", "abet", "bate", "beat", "beta", "able", "bale", "blae" };

           

            var groups = words.GroupBy(s => string.Concat(s.OrderBy(c => c)));
            groups.Select(_=>_.Key);
            var anagramDictionary = new Multidictionary<string, string>();
            words.ForEach(word => anagramDictionary.Add(string.Concat(word.OrderBy(c => c)), word));
            var anagrams = anagramDictionary.Values.Select(vs => vs);

            anagramDictionary.Values
              .Select(vs => vs.ToList())
              .ToList()
              .ForEach(_ =>
              {
                  _.ForEach(w =>
                  {
                      Console.Write(w + " ");
                  });
                  Console.WriteLine();
              });


            var sln = new _1300SumOfMutatedArrayToTarget();
            //Console.WriteLine(sln.FindBestValue(new int[] { 48772, 52931, 14253, 32289, 75263 }, 40876) == 8175);
            Console.WriteLine(sln.FindBestValue(new int[] { 1547, 83230, 57084, 93444, 70879 }, 71237) == 17422);
            Console.WriteLine(sln.FindBestValue(new int[] { 2, 3, 5 }, 10) == 5);
            Console.WriteLine(sln.FindBestValue(new int[] { 3, 6, 8, 10, 20 }, 35) == 9);
            Console.WriteLine(sln.FindBestValue(new int[] { 4, 6, 8, 10, 20, 35, 40 }, 92) == 22);
            Console.WriteLine(sln.FindBestValue(new int[] { 4, 9, 3 }, 10) == 3);

            var addTwoNumbers = new _2_AddTwoNumbers();
            var l1 = new ListNode(7);
            l1.next = new ListNode(1);

            var l2 = new ListNode(5);
            l2.next = new ListNode(6);



            addTwoNumbers.AddTwoNumbers(l1, l2);
        }

        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            var personsWithMaxLoss = peopleAndBalances.Select(_ => new PersonWithMinLoss(_));
            //var maxValue = personsWithMaxLoss.Max(_ => _.MaxLoss);
            //var personWithMaxLoss = personsWithMaxLoss.Where(x => (x.MaxLoss - maxValue) < 0.0001m).First();
            var personWithMaxLoss = personsWithMaxLoss.Aggregate((cur, next) => (cur == null || cur.MaxLoss < next.MaxLoss) ? next : cur);
            return $"{personWithMaxLoss.Name} lost the most money. -¤{personWithMaxLoss.MaxLoss}.";
        }

    }

    public class PersonWithMinLoss
    {
        public string Name { get; set; }
        public decimal MaxLoss { get; set; }
        private readonly List<decimal> Amounts;

        public PersonWithMinLoss(string currentPersonData)
        {
            var parts = currentPersonData.Split(',');
            this.Amounts = parts[1..]
                .Select(_ => decimal.Parse(_, NumberStyles.Currency | NumberStyles.Number)).ToList();
            this.Name = parts[0];
            this.MaxLoss = GetMaxLoss();
        }

        private decimal GetMaxLoss()
        {
            decimal maxLoss = int.MinValue;

            for (int i = 0; i < Amounts.Count - 1; i++)
            {
                var loss = Amounts[i] - Amounts[i + 1];
                if (loss > maxLoss) maxLoss = loss;
            }

            return maxLoss;
        }
    }
}
