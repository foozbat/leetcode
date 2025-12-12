/**
 * 125. Valid Palindrome
 * https://leetcode.com/problems/valid-palindrome/
 */

/**
 * Solution
 * Two-pointer approach to check for palindrome after cleaning the string.
 */
/**
 * @param {string} s
 * @return {boolean}
 */
var isPalindrome = function(s) {f
    s = s.replace(/[^a-zA-Z0-9]/g, "").toLowerCase();

    let i = 0;
    let j = s.length - 1;

    while (i < j) {
        if (s[i++] != s[j--]) {
            return false;
        }
    }

    return true;
};