using System;
using System.Linq;

public class MatrixTraversal
{


    /* mat: Pointer to the starting of mXn matrix 
i, j: Current position of the robot (For the first call use 0,0) 
m, n: Dimentions of given the matrix 
pi: Next index to be filed in path array 
*path[0..pi-1]: The path traversed by robot till now (Array to hold the 
                path need to have space for at least m+n elements) */
    public void printMatrix(char[][] mat, int m, int n,
                                    int i, int j, char[] path, int idx)
    {
        path[idx] = mat[i][j];
        // Reached the bottom of the matrix so we are left with 
        // only option to move right 
        if (i == m - 1)
        {
            for (int k = j + 1; k < n; k++)
            {
                path[idx + k - j] = mat[i][k];
            }
            return;
        }

        if (j == n - 1)
        {
            for (int k = i + 1; k < m; k++)
            {
                path[idx + k - i] = mat[k][j];
            }
            return;
        }

        printMatrix(mat, m, n, i + 1, j, path, idx + 1);
        printMatrix(mat, m, n, i, j + 1, path, idx + 1);
    }

    public void PrintAllPaths(char[][] mat, int m, int n,
                                int i, int j, char[] path, int idx)
    {

    }

}
