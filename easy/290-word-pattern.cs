/*
    290. Word Pattern

    Given a pattern and a string s, find if s follows the same pattern.

    Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s. Specifically:
        Each letter in pattern maps to exactly one unique word in s.
        Each unique word in s maps to exactly one letter in pattern.
        No two letters map to the same word, and no two words map to the same letter.

    Example 1:
        Input: pattern = "abba", s = "dog cat cat dog"
        Output: true

    Explanation:
        The bijection can be established as:
            'a' maps to "dog".
            'b' maps to "cat".

    Example 2:
        Input: pattern = "abba", s = "dog cat cat fish"
        Output: false

    Example 3:
        Input: pattern = "aaaa", s = "dog cat cat dog"
        Output: false

    Constraints:

        1 <= pattern.length <= 300
        pattern contains only lower-case English letters.
        1 <= s.length <= 3000
        s contains only lowercase English letters and spaces ' '.
        s does not contain any leading or trailing spaces.
        All the words in s are separated by a single space.
*/

/*
    Solution:

    Use two dictionaries to store the mapping from pattern to string and string to pattern.
*/
public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        string[] words = s.Split(' ');
        var p_to_s = new Dictionary<char, string>();
        var s_to_p = new Dictionary<string, char>();

        if (pattern.Length != words.Length)
        {
            return false;
        }

        for (int i=0; i<pattern.Length; i++)
        {
            if (p_to_s.ContainsKey(pattern[i]) && p_to_s[pattern[i]] != words[i])
            {
                return false;
            } 
            else if (s_to_p.ContainsKey(words[i]) && s_to_p[words[i]] != pattern[i])
            {
                return false;
            }
            else
            {
                p_to_s[pattern[i]] = words[i];
                s_to_p[words[i]] = pattern[i];
            }
        }

        return true;
    }
}