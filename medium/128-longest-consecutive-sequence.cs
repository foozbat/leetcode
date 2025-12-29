/**
 * 128. Longest Consecutive Sequence
 * https://leetcode.com/problems/longest-consecutive-sequence/
 */

/**
 * Solution:
 * Use a HashSet to store the numbers for O(1) lookups.
 * For each number, check if it's the start of a sequence
 * If it is, count the length of the sequence by checking for consecutive numbers.
 * Keep track of the maximum length found.
 */
public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numSet = new HashSet<int>(nums);

        int longest = 0;

        foreach (int num in numSet) {
            if (!numSet.Contains(num - 1))
            {
                int currentLen = 1;
                int currentNum = num;

                while (numSet.Contains(currentNum + 1))
                {
                    currentNum += 1;
                    currentLen += 1;
                }

                longest = Math.Max(currentLen, longest);
            }
        }

        return longest;
    }
}