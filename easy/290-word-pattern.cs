/**
 * 290. Word Pattern
 * https://leetcode.com/problems/word-pattern/
 */

/**
 * Solution:
 * Use two dictionaries to store the mapping from pattern to string and string to pattern.
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