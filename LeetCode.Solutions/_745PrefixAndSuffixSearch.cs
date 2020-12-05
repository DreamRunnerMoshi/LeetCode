using Algorithms;
using System;
using System.Linq;

namespace _745_Prefix_And_Suffix_Search
{
    /// <summary>
    /// <see cref="https://leetcode.com/problems/prefix-and-suffix-search/"/>
    /// </summary>
    public class _745PrefixAndSuffixSearch
    {
        private readonly WeightedTrie weightedTree;
        public _745PrefixAndSuffixSearch()
        {
            weightedTree = new WeightedTrie();
        }
        public _745PrefixAndSuffixSearch(string[] words)
        {
            for (int w = 0; w < words.Length; w++)
            {
                weightedTree.Insert(words[w], w);
                weightedTree.Insert(words[0].Reverse().ToString(), w);
            }
        }

        public int F(string prefix, string suffix)
        {
            var prefixWord = weightedTree.GetStartsWithWords(prefix);
            var suffixWord = weightedTree.GetStartsWithWords(suffix);
            return 0;
        }
    }

    /**
     * Your WordFilter object will be instantiated and called as such:
     * WordFilter obj = new WordFilter(words);
     * int param_1 = obj.F(prefix,suffix);
     */
}
