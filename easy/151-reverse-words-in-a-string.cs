/**
 * 151. Reverse Words in a String
 * https://leetcode.com/problems/reverse-words-in-a-string/
 */

/**
 * Solution:
 * Split the string into words, remove extra spaces, reverse the order of words,
 * and then join them back into a single string.
 */
public class Solution {
    public string ReverseWords(string s) {
        string[] parts = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        Array.Reverse(parts);

        return string.Join(" ", parts);
    }
}