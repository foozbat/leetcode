/**
 * 189. Rotate Array
 * https://leetcode.com/problems/rotate-array/
 */

/**
 * Solution:
 * Reverse parts of the array to achieve rotation in O(n) time:
 *  1. Reverse the entire array.
 *  2. Reverse the first k elements.
 *  3. Reverse the remaining elements.
 */
public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        int len = nums.Length;

        if (nums.Length < 2)
            return;

        // don't rotate more than the length of the array
        k %= len;

        Reverse(nums, 0, len - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, len - 1);
    }

    public void Reverse(int[] nums, int i, int j)
    {
        while(i < j)
        {
            int tmp = nums[i];
            nums[i] = nums[j];
            nums[j] = tmp;
            i++;
            j--;
        }
    }
}