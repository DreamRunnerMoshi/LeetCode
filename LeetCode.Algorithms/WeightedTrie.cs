using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class WeightedTrie
    {

        private readonly TrieNode trieRootNode;
        public WeightedTrie()
        {
            trieRootNode = new TrieNode();
        }

        public void Insert(string word, int weight)
        {
            Insert(word, trieRootNode, weight);
        }

        private void Insert(string word, TrieNode node, int weight)
        {
            if (word.Length == 0)
            {
                node.isWord = true;
                return;
            };

            var letter = word[0];
            if (!node.childrens.ContainsKey(letter))
            {
                node.childrens[letter] = new TrieNode() { weight = weight };
            }

            var currentNode = node.childrens[letter];
            if (currentNode.weight < weight) currentNode.weight = weight;
            Insert(word.Substring(1), currentNode, weight);
        }

        public List<TrieNode> GetStartsWithWords(string prefix)
        {
            var words = new List<TrieNode>();

            GetStartsWithWords(prefix, trieRootNode, "");

            return words;
        }

        private List<TrieNode> GetStartsWithWords(string prefix, TrieNode node, string currentWord)
        {
            if (prefix.Length == 0) return GetPossibleWords(node, currentWord);
            var letter = prefix[0];
            if (!node.childrens.ContainsKey(letter)) return GetPossibleWords(node, currentWord);
            currentWord += letter;

            return GetStartsWithWords(prefix.Substring(1), node.childrens[letter], currentWord);
        }

        private List<TrieNode> GetPossibleWords(TrieNode trieNode, string currentWord)
        {
            var words = new List<TrieNode>();

            if (trieNode.childrens.Count == 0) return new List<TrieNode>() { trieNode };
            if (trieNode.isWord) words.Add(trieNode);

            var nextKey = trieNode.childrens.Keys.First();
            var nextNode = trieNode.childrens[nextKey];

            foreach (var key in trieNode.childrens.Keys)
            {
                if (trieNode.childrens[key].weight > nextNode.weight)
                {
                    nextNode = trieNode.childrens[key];
                    nextKey = key;
                }
            }
            currentWord += nextKey;

            return GetPossibleWords(nextNode, currentWord);
        }

    }
}

