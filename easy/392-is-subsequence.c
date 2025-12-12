/*
 * 392. Is Subsequence
 * https://leetcode.com/problems/is-subsequence/
 */

/**
 * Solution
 * Two pointers approach. Iterate through both strings. Increment pointer for s only when there is a match.
 * Return true if we reach the end of s.
 */
bool isSubsequence(char* s, char* t) {
    int i = 0;
    int j = 0;

    while (i < strlen(s) && j < strlen(t)) {
        if (s[i] == t[j]) {
            i++;
        }
        j++;
    }

    if (i == strlen(s)) {
        return true;
    }
    return false;
}