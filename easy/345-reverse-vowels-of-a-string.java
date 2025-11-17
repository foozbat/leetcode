/*

    345. Reverse Vowels of a String

    Given a string s, reverse only all the vowels in the string and return it.

    The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.

    Example 1:
        Input: s = "IceCreAm"
        Output: "AceCreIm"

    Explanation:
        The vowels in s are ['I', 'e', 'e', 'A']. On reversing the vowels, s becomes "AceCreIm".

    Example 2:
        Input: s = "leetcode"
        Output: "leotcede"

    Constraints:
        1 <= s.length <= 3 * 105
        s consist of printable ASCII characters.
*/

// Note, this isn't the most efficient solution, but it is more readable than most.
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