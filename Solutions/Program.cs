using LeetCode.Solutions;
using System;
using System.Runtime.CompilerServices;

namespace ProgramClient
{

    public class Program
    {
        static void Main(string[] args)
        {
            var largestTimeForGivenDigits = new LargestTimeForGivenDigits();
            Console.WriteLine(largestTimeForGivenDigits.LargestTimeFromDigits(new[] { 1, 2, 3, 4 }));
            largestTimeForGivenDigits = new LargestTimeForGivenDigits();
            Console.WriteLine(largestTimeForGivenDigits.LargestTimeFromDigits(new[] { 5,5,5,5 }));
        }
    }
}
