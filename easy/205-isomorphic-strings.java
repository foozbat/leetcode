/*
    205. Isomorphic Strings

    Given two strings s and t, determine if they are isomorphic.

    Two strings s and t are isomorphic if the characters in s can be replaced to get t.

    All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character, but a character may map to itself.

    Example 1:
        Input: s = "egg", t = "add"
        Output: true
        Explanation:
        The strings s and t can be made identical by:
            Mapping 'e' to 'a'.
            Mapping 'g' to 'd'.

    Example 2:
        Input: s = "foo", t = "bar"
        Output: false
        Explanation:
        The strings s and t can not be made identical as 'o' needs to be mapped to both 'a' and 'r'.

    Example 3:
        Input: s = "paper", t = "title"
        Output: true

    Constraints:
        1 <= s.length <= 5 * 10^4
        t.length == s.length
        s and t consist of any valid ascii character.
*/

/*
    Solution:

    Use two hash maps to store the character mappings from s to t and from t to s.
    Iterate through the characters of both strings simultaneously.
    Store a mapping of s to t and t to s, if the mapping already exists and it does not match the current character, return false.

    Note: This java solution is fairly slow.
*/
class Solution {
    public boolean isIsomorphic(String s, String t) {
        HashMap<Character, Character> st = new HashMap<>();
        HashMap<Character, Character> ts = new HashMap<>();

        for (int i=0; i<s.length(); i++) {
            char cs = s.charAt(i);
            char ct = t.charAt(i);

            if (st.get(cs) != null && st.get(cs) != ct) {
                return false;
            } else if (ts.get(ct) != null && ts.get(ct) != cs) {
                return false;
            } else {
                st.put(cs, ct);
                ts.put(ct, cs);
            }
        }

        return true;
    }
}