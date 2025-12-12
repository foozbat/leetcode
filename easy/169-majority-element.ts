/**
 * 169. Majority Element
 * https://leetcode.com/problems/majority-element/
 */

/**
 * Solution:
 * Use the Boyer-Moore Voting Algorithm to find the majority element in linear time and constant space.
 * Keep track of a candidate and a counter. When the counter is zero, set the candidate to the current element.
 * Increment the counter if the current element is the same as the candidate, otherwise decrement it.
 * The candidate at the end of the iteration will be the majority element.
*/
function majorityElement(nums: number[]): number {
    let candidate: number = nums[0];
    let counter: number = 0;

    for (let i = 0; i < nums.length; i++) {
        if (counter == 0) {
            candidate = nums[i];
        }
        if (nums[i] == candidate) {
            counter++;
        } else {
            counter--;
        }
    }

    return candidate;
};