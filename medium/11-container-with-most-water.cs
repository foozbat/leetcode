/**
 * 11. Container With Most Water
 * https://leetcode.com/problems/container-with-most-water/
 */

/**
 * Solution:
 * Use two pointers starting from both ends of the array.
 * Calculate the area formed by the lines at the two pointers, using the shorter line as the height.
 * Move the pointer pointing to the shorter line inward to potentially find a taller line.
 * Repeat until the pointers meet, keeping track of the maximum area found.
 */
public class Solution {
    public int MaxArea(int[] height) {
        int i = 0;
        int j = height.Length - 1;
        int max_area = 0;

        while (i < j)
        {
            int area = Math.Min(height[i], height[j]) * (j - i);
            max_area = area > max_area ? area : max_area;

            if (height[i] < height[j])
            {
                i++;
            }
            else
            {
                j--;
            }
        }

        return max_area;
    }
}