/*
58. Length of Last Word
https://leetcode.com/problems/length-of-last-word/
*/


/**
 * Solution
 * One-liner to get the length of the last word.
 */
/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLastWord = function(s) {
    return s.replace(/\s+/g, " ").trim().split(" ").at(-1).length;
};