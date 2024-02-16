namespace Algostruct.Questions.CodeSignal
{
    // Given matrix, a rectangular matrix of integers, where each value represents the cost
    // of the room, your task is to return the total sum of all rooms that are suitable for the CodeBots
    // (ie: add up all the values that don't appear below a 0).
    // For
    // matrix = [[0, 1, 1, 2],
    //           [0, 5, 0, 0],
    //           [2, 0, 3, 3]]
    // the output should be
    // solution(matrix) = 9.
    public class MatrixElementsSum
    {
        public static int Solution(int[][] matrix)
        {
            int[] skippedColumns = new int[matrix[0].Length];

            int sumAboveZeros = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (skippedColumns[j] == 1)
                    {
                        continue;
                    }

                    if (matrix[i][j] <= 0)
                    {
                        skippedColumns[j] = 1;
                        continue;
                    }

                    sumAboveZeros += matrix[i][j];
                }
            }

            return sumAboveZeros;
        }
    }
}
