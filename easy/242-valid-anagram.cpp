/*
    242. Valid Anagram

    Given two strings s and t, return true if t is an anagram of s, and false otherwise.

    Example 1:
        Input: s = "anagram", t = "nagaram"

    Output: true
    
    Example 2:
        Input: s = "rat", t = "car"
        Output: false

    Constraints:
        1 <= s.length, t.length <= 5 * 104
        s and t consist of lowercase English letters.
*/

/*
    Solution:

    Count each occurance of a character in s, then decrement the count for each character in t.
*/
class Solution {
public:
    bool isAnagram(string s, string t) {
        int s_len = s.length();
        int t_len = t.length();

        if (s_len != t_len) {
            return false;
        }

        std::unordered_map<char, int> char_counts;

        for (int i = 0; i < s_len; i++) {
            char_counts[s[i]]++;
        }

        for (int i = 0; i < t_len; i++) {
            if (!char_counts.contains(t[i]) || --char_counts[t[i]] < 0) {
                return false;
            }
        }

        return true;
    }
};