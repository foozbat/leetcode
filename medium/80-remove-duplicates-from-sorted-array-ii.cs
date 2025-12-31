/**
 * 80. Remove Duplicates from Sorted Array II
 * https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/
 */

/**
 * Solution:
 * Use a dictionary to track the count of each number.
 */
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int ptr = 0;
        Dictionary<int, int> matches = new();

        foreach (var num in nums)
        {
            if (!matches.ContainsKey(num))
            {
                matches[num] = 1;
                nums[ptr++] = num;
            }
            else if (matches[num] < 2)
            {
                matches[num]++;
                nums[ptr++] = num;
            }
        }

        return ptr;
    }
}