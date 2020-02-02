using System;
using System.Linq;

namespace _208_Implement_Trie
{
    class Program
    {
        static void Main(string[] args)
        {
            // Trie trie = new Trie();
            // trie.Insert("Hello");
            // trie.Insert("Word");

            // Console.WriteLine(trie.Search("Helloa"));
            // Console.WriteLine(trie.StartsWith("Hel"));

            // int[][] a = new int[10][];
            // Console.WriteLine(" l: " + a.GetLength(0) + " " + a.Rank / a.GetLength(0));

            // trie.Insert("apple");
            // Console.WriteLine(trie.Search("apple"));   // returns true
            // Console.WriteLine(trie.Search("app"));     // returns false
            // Console.WriteLine(trie.StartsWith("app")); // returns true
            // trie.Insert("app");
            // Console.WriteLine(trie.Search("app"));     // returns true


            var board = new char[4][];
            board[0] = new char[] { 'o', 'a', 'a', 'n' };
            board[1] = new char[] { 'e', 't', 'a', 'e' };
            board[2] = new char[] { 'i', 'h', 'k', 'r' };
            board[3] = new char[] { 'i', 'f', 'l', 'v' };

            WordSearchFromBoard fromBoard = new WordSearchFromBoard();
            var words = fromBoard.FindWords(board, new[] { "oath","pea","eat","rain"}).ToList();

           words.ForEach(Console.WriteLine);
        }
    }
}
