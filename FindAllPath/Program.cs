using System;

namespace FindAllPath
{
    class Program
    {
        static void Main(string[] args)
        {
            //  var board = new char[4][];
            // board[0] = new char[] { 'o', 'a', 'a', 'n' };
            // board[1] = new char[] { 'e', 't', 'a', 'e' };
            // board[2] = new char[] { 'i', 'h', 'k', 'r' };
            // board[3] = new char[] { 'i', 'f', 'l', 'v' };

            var board = new char[3][];
            board[0] = new char[] { 'o', 'a', 'c' };
            board[1] = new char[] { 'e', 't', 'a' };
            board[2] = new char[] { 'i', 'h', 'b' };

            int m = board.Length;
            int n = board[0].Length;

            var matrixTraversal = new MatrixTraversal();
            int maxLengthOfPath = m + n - 1;
            //matrixTraversal.printMatrix(board, m, n, 0, 0, new char[maxLengthOfPath], 0);


            var dict = new WordDictionary();
            dict.AddWord("at");
            dict.AddWord("and");
            dict.AddWord("an");
            dict.AddWord("add");
            Console.WriteLine(dict.Search("a"));//-> false
            Console.WriteLine(dict.Search(".at"));//-> false
            dict.AddWord("bat");
            Console.WriteLine(dict.Search(".at"));//-> false
            Console.WriteLine(dict.Search("an."));//-> true
            Console.WriteLine(dict.Search("a.d."));//-> true
            Console.WriteLine(dict.Search("b."));//-> true
            Console.WriteLine(dict.Search("a.d"));//-> true
            Console.WriteLine(dict.Search("."));//-> true
        }
    }
}
