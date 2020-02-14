using Algorithms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _745_Prefix_And_Suffix_Search
{
    public class WordFilter
    {
        private readonly WeightedTrie weightedTree;
        public WordFilter()
        {
            weightedTree = new WeightedTrie();
        }
        public WordFilter(string[] words)
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
