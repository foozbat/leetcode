/**
 * 49. Group Anagrams
 * https://leetcode.com/problems/group-anagrams/
 */

/**
 * Solution:
 * Use a dictionary to map sorted string signatures to lists of anagrams.
 * Return the values of the dictionary as the result.
 */
public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> signatures = new Dictionary<string, List<string>>();

        foreach (string str in strs)
        {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string signature = new string(chars);

            if (!signatures.ContainsKey(signature))
            {
                signatures[signature] = new List<string>();
            }

            signatures[signature].Add(str);
            
        }

        return signatures.Values.ToList<IList<string>>();
    }
} 