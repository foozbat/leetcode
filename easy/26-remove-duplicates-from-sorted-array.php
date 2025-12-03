<?php
/**
 * 26. Remove Duplicates from Sorted Array
 * https://leetcode.com/problems/remove-duplicates-from-sorted-array/
 */

/**
 * Solution
 * Push all non duplicate numbers onto a new array and return.
 */
class Solution {

    /**
     * @param Integer[] $nums
     * @return Integer
     */
    function removeDuplicates(&$nums) {
        $prev = $nums[0];
        $ret = [$nums[0]];

        for ($i=1; $i<sizeof($nums); $i++) {
            if ($nums[$i] != $prev) {
                $ret[] = $nums[$i];
                $prev = $nums[$i];
            }
        }

        $nums = $ret;

        return sizeof($nums);
    }
}