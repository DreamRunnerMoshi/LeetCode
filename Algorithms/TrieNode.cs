
using System.Collections.Generic;

public class TrieNode
{
    public Dictionary<char, TrieNode> childrens { get; set; }
    public bool isWord = false;
    public int weight = 0;

    public TrieNode()
    {
        childrens = new Dictionary<char, TrieNode>();
    }
}
