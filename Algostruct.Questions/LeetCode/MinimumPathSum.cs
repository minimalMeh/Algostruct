using System;

namespace Algostruct.Questions.LeetCode
{
    // Given a m x n grid filled with non-negative numbers, find a path from top left to bottom right,
    // which minimizes the sum of all numbers along its path.
    // Input: grid = [[1,2,3],[4,5,6]]
    // Output: 12
    public class MinimumPathSum
    {
        public static int MinPathSum(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i > 0 && j > 0)
                    {
                        grid[i][j] += Math.Min(grid[i - 1][j], grid[i][j - 1]);
                    }
                    else if (i > 0) // j == 0
                    {
                        grid[i][0] += grid[i - 1][0];
                    }
                    else if (j > 0) // i == 0
                    {
                        grid[0][j] += grid[0][j - 1];
                    }
                }
            }

            return grid[m - 1][n - 1];
        }
    }
}
