using System;
using System.Collections.Generic;
using System.Linq;

public class SubsetsOfSet
{
    private readonly int n;
    private readonly List<string> bitmasks;
    public SubsetsOfSet(int n)
    {
        this.n = n;
    }

    public List<List<int>> GetSubsets(List<int> nums)
    {
        var allSets = new List<List<int>>();

        for (int x = 0; x < (1 << n); x++)
        {
            var set = new List<int>() { -1, -1, -1 };
            int setIndex = 0;
            for (int p = 0; p < n; p++)
            {
                if ((x & (1 << p)) != 0)
                {
                    set[setIndex++] = nums[p];
                }
            }

            allSets.Add(set);
        }
        PrintAllSubsets(allSets);
        return allSets;
    }

    private void PrintAllSubsets(List<List<int>> subsets)
    {
        subsets.ForEach(_ =>
        {
            _.Where(_ => _ != -1).ToList().ForEach(s => Console.Write(s + " "));
            Console.WriteLine();
        });
    }
}