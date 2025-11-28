/**
 * 28. Find the Index of the First Occurrence in a String
 * https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/
 */

/**
 * Solution:
 * Two pointers brute force approach.
 */
int strStr(char* haystack, char* needle) {
    int h_len = strlen(haystack);
    int n_len = strlen(needle);

    if (n_len == 0) return 0;

    for (int i = 0; i <= h_len - n_len; i++) {
        int j = 0;

        while (j < n_len && haystack[i + j] == needle[j]) {
            j++;
        }

        if (j == n_len) {
            return i;
        }        
    }

    return -1;
}