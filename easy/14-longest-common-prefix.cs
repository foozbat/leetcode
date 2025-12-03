/**
 * 14. Longest Common Prefix
 * https://leetcode.com/problems/longest-common-prefix/
 */

/**
 * Solution
 * Start with the first string as the prefix.
 * Iterate through the rest of the strings, shortening the prefix.
 * Terminate when the prefix is found in all strings or becomes empty.
 */
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string prefix = strs[0];

        for (int i=1; i<strs.Length; i++) {
            while (!strs[i].StartsWith(prefix)) {
                prefix = prefix[..^1]; // Remove last character
                if (prefix.Length == 0)
                    break;
            }
        }

        return prefix;
    }
}