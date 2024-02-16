using System.Collections.Generic;

namespace Algostruct.Questions.LeetCode
{
    // Given an m x n integer matrix matrix, if an element is 0, set its entire row and column to 0's.
    // Input: matrix = [[1,1,1],[1,0,1],[1,1,1]]
    // Output: [[1,0,1],[0,0,0],[1,0,1]]
    public class SetMatrixZeroes
    {
        readonly HashSet<int> rowIndexes = new();
        readonly HashSet<int> columnIndexes = new();

        public void SetZeroes(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        rowIndexes.Add(i);
                        columnIndexes.Add(j);
                    }
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (rowIndexes.Contains(i) || columnIndexes.Contains(j))
                        matrix[i][j] = 0;
                }
            }
        }
    }
}
