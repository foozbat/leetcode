/**
 * 48. Rotate Image
 * https://leetcode.com/problems/rotate-image/
 */

/**
 * Solution:
 * Transpose the matrix and then reverse each row to achieve a 90-degree rotation.
 */
 public class Solution
 {
    public void Rotate(int[][] matrix)
    {
        int size = matrix.Length;

        // transpose matrix
        for (int r = 0; r < size; r++)
        {
            for (int c = r + 1; c < size; c++)
            {
                int tmp = matrix[r][c];
                matrix[r][c] = matrix[c][r];
                matrix[c][r] = tmp;
            }
        }

        // reverse each row
        for (int r = 0; r < size; r++)
        {
            int i = 0;
            int j = size - 1;

            while (i < j)
            {
                int tmp = matrix[r][i];
                matrix[r][i] = matrix[r][j];
                matrix[r][j] = tmp;
                i++;
                j--;
            }
        }
    }
}