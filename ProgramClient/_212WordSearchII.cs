using System;
using System.Collections.Generic;
using System.Linq;

public class Cell
{
    public int row;
    public int colum;
}

public class _212WordSearchII
{
    private readonly Trie trie;
    private HashSet<string> visited;
    public _212WordSearchII()
    {
        trie = new Trie();
    }
    public IList<string> FindWords(char[][] board, string[] words)
    {
        for (int rotation = 1; rotation <= 3; rotation++)
        {
            for (int i = 0; i < (board[0].Length); i++)
            {
                var startCell = new Cell()
                {
                    row = 0,
                    colum = i
                };
                visited = new HashSet<string>();
                visited.Add(startCell.row + "#" + startCell.colum);
                InsertWord(board, startCell, "", visited);
            }

            board = GetRotatedBoard(board);
        }
        var result = new List<string>();
        for (int w = 0; w < words.Length; w++)
        {
            var isContains = trie.Search(words[w]);
            if (isContains) result.Add(words[w]);
        }

        return result;
    }

    private void InsertWord(char[][] board, Cell cell, string curr, HashSet<string> visited)
    {
        var m = board.Length;
        var n = board[0].Length;
        int maxLengthOfPath = m + n - 1;

        printMatrix(board, m, n, cell.row, cell.colum, new char[maxLengthOfPath], 0);
        return;
    }

    private void InsertPath(char[] path)
    {
        var pathString = String.Join("", path.ToList().Where(_ => _ != '\0'));
        trie.Insert(pathString);
        Console.WriteLine(pathString);
    }
    private void printMatrix(char[][] mat, int m, int n,
                                    int i, int j, char[] path, int idx)
    {
        path[idx] = mat[i][j];
        InsertPath(path);
        if (i == m - 1)
        {
            for (int k = j + 1; k < n; k++)
            {
                path[idx + k - j] = mat[i][k];
                InsertPath(path);
            }
            return;
        }

        if (j == n - 1)
        {
            for (int k = i + 1; k < m; k++)
            {
                path[idx + k - i] = mat[k][j];
                InsertPath(path);
            }
            return;
        }

        printMatrix(mat, m, n, i + 1, j, path, idx + 1);
        printMatrix(mat, m, n, i, j + 1, path, idx + 1);
    }
    private char[][] GetRotatedBoard(char[][] mat)
    {
        int N = mat.GetLength(0);
        // Consider all squares one by one 
        for (int x = 0; x < N / 2; x++)
        {
            // Consider elements in group of 4 in  
            // current square 
            for (int y = x; y < N - x - 1; y++)
            {
                // store current cell in temp variable 
                char temp = mat[x][y];

                // move values from right to top 
                mat[x][y] = mat[y][N - 1 - x];

                // move values from bottom to right 
                mat[y][N - 1 - x] = mat[N - 1 - x][N - 1 - y];

                // move values from left to bottom 
                mat[N - 1 - x][N - 1 - y] = mat[N - 1 - y][x];

                // assign temp to left 
                mat[N - 1 - y][x] = temp;
            }
        }

        return mat;
    }
    private List<Cell> GetNeighbours(Cell cell)
    {
        var neighbours = new List<Cell>();

        neighbours.Add(new Cell()
        {
            row = cell.row + 1,
            colum = cell.colum
        });

        neighbours.Add(new Cell()
        {
            row = cell.row,
            colum = cell.colum + 1
        });

        neighbours.Add(new Cell()
        {
            row = cell.row - 1,
            colum = cell.colum
        });

        neighbours.Add(new Cell()
        {
            row = cell.row,
            colum = cell.colum - 1
        });

        return neighbours;
    }
}