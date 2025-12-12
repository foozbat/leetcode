/**
 * 205. Isomorphic Strings
 * https://leetcode.com/problems/isomorphic-strings/
 */

/**
 * Solution:
 * Use two hash maps to store the character mappings from s to t and from t to s.
 * Iterate through the characters of both strings simultaneously.
 * Store a mapping of s to t and t to s, if the mapping already exists and it does not match the current character, return false.
 *
 * Note: This java solution is fairly slow.
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