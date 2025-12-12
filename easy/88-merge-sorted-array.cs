/**
 * 88. Merge Sorted Array
 * https://leetcode.com/problems/merge-sorted-array/
 */

/**
 * Solution
 * Merge from the back of nums1 to avoid overwriting values
 */
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int n1_idx = m - 1;
        int n2_idx = n - 1;
        int m_idx = nums1.Length - 1;

        while (n2_idx >= 0 ) {
            if (n1_idx < 0 || nums2[n2_idx] >= nums1[n1_idx]) {
                nums1[m_idx--] = nums2[n2_idx--];
            } else {
                 nums1[m_idx--] = nums1[n1_idx--];
            }
        }
    }
}