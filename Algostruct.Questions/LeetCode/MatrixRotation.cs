namespace Algostruct.Questions.LeetCode
{
    // You are given an n x n 2D matrix representing an image, rotate the image by 90 degrees (clockwise).

    // You have to rotate the image in-place, which means you have to modify the input 2D matrix directly.
    // DO NOT allocate another 2D matrix and do the rotation.
    public class MatrixRotation
    {
        public static void Rotate(int[][] matrix)
        {
            if (matrix.Length == 1 || matrix.Length != matrix[0].Length)
                return;

            for (int rotation = 0; rotation < matrix.Length / 2; rotation++)
            {
                int highestIndexToRotate = matrix.Length - rotation - 1;

                for (int i = rotation; i < highestIndexToRotate; i++)
                {
                    int offsetIndex = i - rotation;
                    int firstCellToRotate = matrix[rotation][i];

                    matrix[rotation][i] = matrix[highestIndexToRotate - offsetIndex][rotation];
                    matrix[highestIndexToRotate - offsetIndex][rotation] = matrix[highestIndexToRotate][highestIndexToRotate - offsetIndex];
                    matrix[highestIndexToRotate][highestIndexToRotate - offsetIndex] = matrix[i][highestIndexToRotate];
                    matrix[i][highestIndexToRotate] = firstCellToRotate;
                }
            }
        }
    }
}
