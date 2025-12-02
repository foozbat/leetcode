/**
 * 228. Summary Ranges
 * https://leetcode.com/problems/summary-ranges/
 */

/**
 * Solution
 * Foreach element in the array, check if current is consecutive to previous number.
 * If not, store the range found and start a new range.
 * At the end, store the last range found.
 */
/**
 * @param {number[]} nums
 * @return {string[]}
 */
var summaryRanges = function(nums) {
    let ranges = [];

    if (nums.length == 0) {
        return ranges;
    }

    let start = nums[0];

    for (let i = 1; i < nums.length; i++) {
        let previous = nums[i - 1];
        if (nums[i] != previous + 1) { 
            if (start == previous) {
                ranges.push(`${start}`);
            } else {
                ranges.push(`${start}->${previous}`);
            }
            start = nums[i];
        }
    }

    if (start == nums.at(-1)) {
        ranges.push(`${start}`);
    } else {
        ranges.push(`${start}->${nums.at(-1)}`);
    }

    return ranges;
};