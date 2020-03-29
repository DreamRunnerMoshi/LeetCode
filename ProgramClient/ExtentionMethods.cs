using Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgramClient
{
    public static class ExtentionMethods
    {
        public static IEnumerable<IEnumerable<T>> Partition<T>(this IEnumerable<T> items, Func<T, T> canonicalize)
        {
            return items.GroupBy(_ => canonicalize(_)).Select(_ => _);
        }
        //var anagramsTable = new Multidictionary<T, T>();

        //items.Select(_=> anagramsTable.Add(canonicalize(_)),str);

        //foreach (string str in items)
        //{
        //    anagramsTable.Add(canonicalize(str), str);
        //}
        //}
    }
}
