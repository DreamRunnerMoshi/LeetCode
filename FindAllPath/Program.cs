using System;

namespace FindAllPath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //  var board = new char[4][];
            // board[0] = new char[] { 'o', 'a', 'a', 'n' };
            // board[1] = new char[] { 'e', 't', 'a', 'e' };
            // board[2] = new char[] { 'i', 'h', 'k', 'r' };
            // board[3] = new char[] { 'i', 'f', 'l', 'v' };

            var board = new char[3][];
            board[0] = new char[] { 'o', 'a'  };
            board[1] = new char[] { 'e', 't' };
            board[2] = new char[] { 'i', 'h' };

            int m = board.Length;
            int n = board[0].Length;

            var matrixTraversal = new MatrixTraversal();
            int maxLengthOfPath = m + n - 1;
            matrixTraversal.printMatrix(board, m, n, 0, 0, new char[maxLengthOfPath], 0);
        }
    }
}
