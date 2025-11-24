/*
    Given an array nums of size n, return the majority element.

    The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

    Example 1:
        Input: nums = [3,2,3]
        Output: 3

    Example 2:
        Input: nums = [2,2,1,1,1,2,2]
        Output: 2

    Constraints:
        n == nums.length
        1 <= n <= 5 * 10^4
        -109 <= nums[i] <= 109
        The input is generated such that a majority element will exist in the array.
*/

/*
    Solution:

    Use the Boyer-Moore Voting Algorithm to find the majority element in linear time and constant space.
    Keep track of a candidate and a counter. When the counter is zero, set the candidate to the current element.
    Increment the counter if the current element is the same as the candidate, otherwise decrement it.
    The candidate at the end of the iteration will be the majority element.
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