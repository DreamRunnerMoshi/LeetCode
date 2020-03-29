using System;
using System.Collections.Generic;
using System.Linq;

namespace BiweeklyContest
{
    public class Item
    {
        public int Number { get; set; }
        public int Power { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var cinemaSeatAllocation = new CinemaSeatAllocation();
            var reserved1 = new int[][] { new int[2] { 2, 1 }, new int[2] { 1, 8 }, new int[2] { 2, 6 } };
            var reserved2 = new int[][] { new int[2] { 4, 3 }, new int[2] { 1, 4 }, new int[2] { 4, 6 }, new int[2] { 4, 6 } };
            var reserved3 = new int[][] { 
                new int[2] { 1, 2 }
                , new int[2] { 1, 3 }
                , new int[2] { 1, 8 }
                , new int[2] { 2, 6 }
                , new int[2] { 3, 1 }
                , new int[2] { 3, 10 }
            };
            //var count = cinemaSeatAllocation.MaxNumberOfFamilies(2, reserved1);
            //Console.WriteLine(count);
            //count = cinemaSeatAllocation.MaxNumberOfFamilies(4, reserved2);
            //Console.WriteLine(count);
            var count = cinemaSeatAllocation.MaxNumberOfFamilies(3, reserved3);
            Console.WriteLine(count);
            //int count = FindTheDistanceValue(new int[] { 1, 4, 2, 3 }, new int[] { -4, -3, 6, 10, 20, 30 }, 3);
            //Console.WriteLine(GetKth(1,1000,777));
        }

        public static int GetKth(int lo, int hi, int k)
        {
            var list = new List<Item>();
            for (int i = lo; i <= hi; i++)
            {
                list.Add(new Item() { Power = GetPowerValue(i), Number = i });
            }

            var sorted = list.OrderBy(_ => _.Power).ThenBy(_ => _.Number).ToList();
            return sorted[k - 1].Number;
        }

        public static int GetPowerValue(int n)
        {
            if (n == 1) return 1;
            return (n % 2 == 0) ? (1 + GetPowerValue(n / 2)) : (1 + GetPowerValue(3 * n + 1));
        }

        public static int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
        {
            int count = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                var a = arr1[i];
                bool isResult = true;
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (Math.Abs(a - arr2[j]) <= d)
                    {
                        isResult = false;
                        break;
                    }
                }

                if (isResult) count++;
            }

            return count;
        }
    }
}
