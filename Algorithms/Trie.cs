public class Trie
{

    private readonly TrieNode root;
    /** Initialize your data structure here. */
    public Trie()
    {
        root = new TrieNode();
    }

    /** Inserts a word into the trie. */
    public void Insert(string word)
    {
        Insert(word, root);
    }

    private void Insert(string word, TrieNode node)
    {
        if (word.Length == 0)
        {
            node.isWord = true;
            return;
        };

        var letter = word[0];
        if (!node.childrens.ContainsKey(letter))
        {
            node.childrens[letter] = new TrieNode();
        }

        var currentNode = node.childrens[letter];

        Insert(word.Substring(1), currentNode);
    }

    /** Returns if the word is in the trie. */
    public bool Search(string word)
    {
        return Search(word, root);
    }

    private bool Search(string word, TrieNode node)
    {
        if (node.isWord && word.Length == 0) return true;
        if (word.Length == 0) return false;
        var letter = word[0];
        if (node.childrens.ContainsKey(letter))
        {
            return Search(word.Substring(1), node.childrens[letter]);
        }

        return false;
    }

    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix)
    {
        return StartsWith(prefix, root);
    }

    private bool StartsWith(string prefix, TrieNode node)
    {
        if (prefix.Length == 0) return true;
        var letter = prefix[0];
        if (!node.childrens.ContainsKey(letter)) return false;

        return StartsWith(prefix.Substring(1), node.childrens[letter]);
    }
}