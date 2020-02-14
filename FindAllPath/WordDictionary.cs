public class WordDictionary {

    /** Initialize your data structure here. */
    private readonly Trie trie;
    public WordDictionary() {
        trie = new Trie();
    }
    
    /** Adds a word into the data structure. */
    public void AddWord(string word) {
        trie.Insert(word);
    }
    
    /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
   public bool Search(string word)
    {
        var root = trie.GetRootNode();
        return Search(word, root);
    }

    private bool Search(string word, Node node)
    {
        if (node.isWord && word.Length == 0) return true;
        if (word.Length == 0) return false;
        var letter = word[0];
        if (node.childrens.ContainsKey(letter))
        {
            return Search(word.Substring(1), node.childrens[letter]);
        }

        if(letter == '.')
        {
            var sub = word.Substring(1);
            foreach(var child in node.childrens)
            {
                if(Search(sub, child.Value)) return true;
            }

            return false;
        }

        return false;
    }
}