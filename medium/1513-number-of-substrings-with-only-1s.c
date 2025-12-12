/**
 * 1513. Number of Substrings With Only 1s
 * https://leetcode.com/problems/number-of-substrings-with-only-1s/
 */

/**
 * Solution
 * Iterate through the string, counting consecutive '1's. When a '0' is encountered
 * or the end of the string is reached, use the formula k*(k+1)/2 to calculate
 * the number of substrings that can be formed from the consecutive '1's counted so far.
 * Sum these counts and return the total modulo 10^9 + 7.
 */
int numSub(char* s) {
    int i = 0;
    long current_count = 0;
    long total_count = 0;

    while (s[i] != '\0') {
        if (s[i] == '1')
            current_count++;
        else {
            // use the sum of the first k positive integers to increment the total: 1+2+3+…+k = k∗(k+1)/2
            total_count += (current_count * (current_count + 1) / 2) % 1000000007;
            current_count = 0;
        }
        i++;
    }
    total_count += (current_count * (current_count + 1) / 2) % 1000000007;

    return total_count;
}