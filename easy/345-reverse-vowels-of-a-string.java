/**
 * 345. Reverse Vowels of a String
 * https://leetcode.com/problems/reverse-vowels-of-a-string/
 */

/**
 * Solution:
 * Find all vowels in the string and store them.
 * Then, build a new string by replacing the vowels in reverse order.
 * Note, this isn't the most efficient solution, but it is more readable than most.
 */
class Solution {
    public String reverseVowels(String s) {
        char[] chars = s.toCharArray();
        String vowels = "aeiouAEIOU";
        String matches = "";
        String ret_str = "";

        // find all vowels
        for (char c : chars) {
            if (vowels.indexOf(c) > -1) {
                matches += c;
            }
        }

        int rev_idx = matches.length() - 1;

        // build a new string with vowels reversed
        for (char c : chars) {
            if (vowels.indexOf(c) > -1) {
                ret_str += matches.charAt(rev_idx--);
            } else {
                ret_str += c;
            }
        }

        return ret_str;
    }
}